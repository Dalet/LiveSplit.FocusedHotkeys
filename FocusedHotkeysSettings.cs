using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.FocusedHotkeys
{
    public partial class FocusedHotkeysSettings : UserControl
    {
        public BindingList<ProgramSetting> ProgramList { get; private set; }
        public bool AllowFocusedToggle { get; set; }
        public bool MatchCase { get; set; }

        const bool DEFAULT_ALLOW_FOCUSED_TOGGLE = false;
        const bool DEFAULT_MATCH_CASE = false;

        public FocusedHotkeysSettings()
        {
            InitializeComponent();

            AllowFocusedToggle = DEFAULT_ALLOW_FOCUSED_TOGGLE;
            MatchCase = DEFAULT_MATCH_CASE;

            ProgramList = new BindingList<ProgramSetting>();
            this.dgvPrograms.AutoGenerateColumns = false;
            this.dgvPrograms.DataSource = ProgramList;

            var titleCol = dgvPrograms.Columns[0];
            titleCol.DataPropertyName = nameof(ProgramSetting.Title);

            var typeCol = dgvPrograms.Columns[1];
            typeCol.DataPropertyName = nameof(ProgramSetting.Type);

            chkAllowManualToggle.DataBindings.Add("Checked", this, nameof(AllowFocusedToggle), false, DataSourceUpdateMode.OnPropertyChanged);
            chkMatchCase.DataBindings.Add("Checked", this, nameof(MatchCase), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AllowFocusedToggle", AllowFocusedToggle));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "MatchCase", MatchCase));

            XmlElement programsListNode = doc.CreateElement("Programs");
            foreach (ProgramSetting program in ProgramList)
            {
                var node = doc.CreateElement("Program");
                node.AppendChild(SettingsHelper.ToElement(doc, "Type", program.Type));
                node.AppendChild(SettingsHelper.ToElement(doc, "Title", program.Title));
                programsListNode.AppendChild(node);
            }
            settingsNode.AppendChild(programsListNode);

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var version = SettingsHelper.ParseVersion(settings["Version"]);
            if (version != null && version < new Version(1, 1))
            {
                ConvertOldSettings(settings);
                return;
            }

            AllowFocusedToggle = SettingsHelper.ParseBool(settings["AllowFocusedToggle"], DEFAULT_ALLOW_FOCUSED_TOGGLE);
            MatchCase = SettingsHelper.ParseBool(settings["MatchCase"], DEFAULT_MATCH_CASE);

            ProgramList.Clear();
            var programsNode = settings["Programs"];
            if (programsNode != null)
            {
                foreach (XmlElement elem in programsNode.ChildNodes)
                {
                    var title = elem["Title"]?.InnerText;
                    var typeStr = elem["Type"]?.InnerText;
                    TitleType type;

                    if (string.IsNullOrEmpty(title) || typeStr == null
                        || !Enum.TryParse(typeStr, out type))
                        continue;

                    ProgramList.Add(new ProgramSetting(title, type));
                }
            }
        }

        void ConvertOldSettings(XmlNode settings)
        {
            var version = SettingsHelper.ParseVersion(settings["Version"]);
            if (version < new Version(1, 1))
            {
                AllowFocusedToggle = SettingsHelper.ParseBool(settings["AllowFocusedToggle"], DEFAULT_ALLOW_FOCUSED_TOGGLE);

                XmlElement processesListNode = settings["ProcessesList"];
                if (processesListNode != null)
                {
                    foreach (XmlElement elem in processesListNode.ChildNodes)
                    {
                        if (elem.InnerText != string.Empty
                            && SearchProgram(elem.InnerText, TitleType.ProcessName) == null)
                        {
                            ProgramList.Add(new ProgramSetting(elem.InnerText, TitleType.ProcessName));
                        }
                    }
                }

                XmlElement windowTitlesListNode = settings["WindowTitlesList"];
                if (windowTitlesListNode != null)
                {
                    foreach (XmlElement elem in windowTitlesListNode.ChildNodes)
                    {
                        if (elem.InnerText != string.Empty
                            && SearchProgram(elem.InnerText, TitleType.WindowTitle) == null)
                        {
                            ProgramList.Add(new ProgramSetting(elem.InnerText, TitleType.WindowTitle));
                        }
                    }
                }
            }
        }

        ProgramSetting SearchProgram(string title, TitleType type)
        {
            return ProgramList.FirstOrDefault(s => s.Type == type && s.Title == title);
        }
        ProgramSetting SearchProgram(string title) => ProgramList.FirstOrDefault(s => s.Title == title);

        void dgvPrograms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) // clicking on a header
                return;

            var program = ProgramList[e.RowIndex];
            cbProgramTitle.Text = program.Title;
            rbProcessName.Checked = program.Type == TitleType.ProcessName;
            rbWindowTitle.Checked = program.Type == TitleType.WindowTitle;
        }

        void btnAddProgram_Click(object sender, EventArgs e)
        {
            string title = cbProgramTitle.Text.Trim();
            var type = rbProcessName.Checked
                ? TitleType.ProcessName
                : TitleType.WindowTitle;

            if (!string.IsNullOrEmpty(title))
            {
                // remove ".exe" extension
                if (type == TitleType.ProcessName && title.ToLower().LastIndexOf(".exe") >= 0)
                    title = title.Remove(title.ToLower().LastIndexOf(".exe"));

                var program = SearchProgram(title, type);
                if (program == null)
                {
                    program = new ProgramSetting(title, type);
                    ProgramList.Add(program);
                }
                dgvPrograms.CurrentCell = dgvPrograms[0, ProgramList.IndexOf(program)]; // select new row
            }

            cbProgramTitle.Text = string.Empty;
        }

        void btnRemoveProgram_Click(object sender, EventArgs e)
        {
            if (dgvPrograms.SelectedRows.Count <= 0)
                return;

            var index = -1;
            foreach (DataGridViewRow selectedRow in dgvPrograms.SelectedRows)
            {
                // take the smallest selected row index
                if (index < 0 || index > selectedRow.Index)
                    index = selectedRow.Index;
                ProgramList.RemoveAt(selectedRow.Index);
            }

            if (ProgramList.Count > 0)
            {
                index = index < ProgramList.Count ? index : ProgramList.Count - 1;
                ProgramList.ResetBindings(); // cell selection doesn't work half the time without this
                dgvPrograms.CurrentCell = dgvPrograms[0, index];
            }
        }

        void cbProgramTitle_DropDown(object sender, EventArgs e)
        {
            this.cbProgramTitle.Items.Clear();
            var suggestions = new SortedSet<string>();

            if (rbProcessName.Checked)
            {
                var currProcessId = Process.GetCurrentProcess().Id;
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.Id != currProcessId && process.MainWindowHandle != IntPtr.Zero)
                        suggestions.Add(process.ProcessName);
                }
            }
            else
            {
                foreach (string title in GetOpenedWindowsTitles())
                    suggestions.Add(title);
            }

            this.cbProgramTitle.Items.AddRange(suggestions.ToArray());
        }

        static List<string> GetOpenedWindowsTitles()
        {
            var titles = new List<string>();
            var currProcessId = Process.GetCurrentProcess().Id;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id != currProcessId && process.MainWindowTitle.Length > 0)
                    titles.Add(process.MainWindowTitle);
            }
            return titles;
        }
    }

    public enum TitleType
    {
        ProcessName,
        WindowTitle
    }

    public class ProgramSetting
    {
        public string Title { get; set; }
        public TitleType Type { get; set; }

        public ProgramSetting(string title, TitleType type)
        {
            Title = title;
            Type = type;
        }
    }
}
