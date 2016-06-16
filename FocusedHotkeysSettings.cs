using LiveSplit.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.FocusedHotkeys
{
    public partial class FocusedHotkeysSettings : UserControl
    {
        public BindingList<string> ProcessesList { get; set; }
        public BindingList<string> WindowTitlesList { get; set; }
        public bool AllowFocusedToggle { get; set; }

        const bool DEFAULT_ALLOW_FOCUSED_TOGGLE = false;

        public FocusedHotkeysSettings()
        {
            InitializeComponent();

            AllowFocusedToggle = DEFAULT_ALLOW_FOCUSED_TOGGLE;

            ProcessesList = new BindingList<string>();
            this.lbProcesses.DataSource = ProcessesList;

            WindowTitlesList = new BindingList<string>();
            this.lbWindowTitles.DataSource = WindowTitlesList;

            chkAllowManualToggle.DataBindings.Add("Checked", this, nameof(AllowFocusedToggle), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "AllowFocusedToggle", AllowFocusedToggle));

            XmlElement processesListNode = doc.CreateElement("ProcessesList");
            foreach (string processName in lbProcesses.Items)
            {
                processesListNode.AppendChild(SettingsHelper.ToElement(doc, "ProcessName", processName));
            }
            settingsNode.AppendChild(processesListNode);

            XmlElement windowTitlesListNode = doc.CreateElement("WindowTitlesList");
            foreach (string windowTitle in lbWindowTitles.Items)
            {
                windowTitlesListNode.AppendChild(SettingsHelper.ToElement(doc, "WindowTitle", windowTitle));
            }
            settingsNode.AppendChild(windowTitlesListNode);

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;

            AllowFocusedToggle = SettingsHelper.ParseBool(settings["AllowFocusedToggle"], DEFAULT_ALLOW_FOCUSED_TOGGLE);

            XmlElement processesListNode = settings["ProcessesList"];
            if (processesListNode != null)
            {
                foreach (XmlElement elem in processesListNode.ChildNodes)
                {
                    if (elem.InnerText != String.Empty && !ProcessesList.Contains(elem.InnerText))
                        ProcessesList.Add(elem.InnerText);
                }
            }

            XmlElement windowTitlesListNode = settings["WindowTitlesList"];
            if (windowTitlesListNode != null)
            {
                foreach (XmlElement elem in windowTitlesListNode.ChildNodes)
                {
                    if (elem.InnerText != String.Empty && !WindowTitlesList.Contains(elem.InnerText))
                        WindowTitlesList.Add(elem.InnerText);
                }
            }
        }

        void btnAddProcess_Click(object sender, EventArgs e)
        {
            string processName = cbAllProcesses.Text;
            if (!String.IsNullOrEmpty(processName) && !ProcessesList.Contains(processName) && !Regex.Match(processName, @"^\s+$").Success)
                ProcessesList.Add(processName);
            cbAllProcesses.Text = String.Empty;
        }

        void btnAddWindowTitle_Click(object sender, EventArgs e)
        {
            string title = cbAllWindowTitles.Text;
            if (!WindowTitlesList.Contains(title) && !String.IsNullOrEmpty(title) && !Regex.Match(title, @"^\s+$").Success)
                WindowTitlesList.Add(title);
            cbAllWindowTitles.Text = String.Empty;
        }

        void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if (lbProcesses.SelectedIndex >= 0)
                ProcessesList.RemoveAt(lbProcesses.SelectedIndex);
        }

        void lbProcesses_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete.Equals(e.KeyCode))
                this.btnRemoveProcess.PerformClick();
        }

        void btnRemoveWindowTitle_Click(object sender, EventArgs e)
        {
            if (lbWindowTitles.SelectedIndex >= 0)
                WindowTitlesList.RemoveAt(lbWindowTitles.SelectedIndex);
        }

        void lbWindowTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete.Equals(e.KeyCode))
                this.btnRemoveWindowTitle.PerformClick();
        }

        void cbAllProcesses_DropDown(object sender, EventArgs e)
        {
            this.cbAllProcesses.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess() != process && !cbAllProcesses.Items.Contains(process.ProcessName))
                    this.cbAllProcesses.Items.Add(process.ProcessName);
            }
        }

        void cbAllWindowTitles_DropDown(object sender, EventArgs e)
        {
            this.cbAllWindowTitles.Items.Clear();
            this.cbAllWindowTitles.Items.AddRange(GetOpenedWindowsTitles().ToArray());
        }

        static ArrayList GetOpenedWindowsTitles()
        {
            ArrayList titles = new ArrayList();

            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Length > 0 && !titles.Contains(process.MainWindowTitle))
                    titles.Add(process.MainWindowTitle);
            }
            return titles;
        }
    }
}
