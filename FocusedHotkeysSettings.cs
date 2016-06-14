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

        public FocusedHotkeysSettings()
        {
            InitializeComponent();

            ProcessesList = new BindingList<string>();
            this.lbProcesses.DataSource = ProcessesList;

            WindowTitlesList = new BindingList<string>();
            this.lbWindowTitles.DataSource = WindowTitlesList;
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            XmlElement processesListNode = doc.CreateElement("ProcessesList");
            foreach (string processName in lbProcesses.Items)
            {
                processesListNode.AppendChild(ToElement(doc, "ProcessName", processName));
            }
            settingsNode.AppendChild(processesListNode);

            XmlElement windowTitlesListNode = doc.CreateElement("WindowTitlesList");
            foreach (string windowTitle in lbWindowTitles.Items)
            {
                windowTitlesListNode.AppendChild(ToElement(doc, "WindowTitle", windowTitle));
            }
            settingsNode.AppendChild(windowTitlesListNode);

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;

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

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            string processName = cbAllProcesses.Text;
            if (!String.IsNullOrEmpty(processName) && !ProcessesList.Contains(processName) && !Regex.Match(processName, @"^\s+$").Success)
                ProcessesList.Add(processName);
            cbAllProcesses.Text = String.Empty;
        }

        private void btnAddWindowTitle_Click(object sender, EventArgs e)
        {
            string title = cbAllWindowTitles.Text;
            if (!WindowTitlesList.Contains(title) && !String.IsNullOrEmpty(title) && !Regex.Match(title, @"^\s+$").Success)
                WindowTitlesList.Add(title);
            cbAllWindowTitles.Text = String.Empty;
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if (lbProcesses.SelectedIndex >= 0)
                ProcessesList.RemoveAt(lbProcesses.SelectedIndex);
        }

        private void lbProcesses_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete.Equals(e.KeyCode))
                this.btnRemoveProcess.PerformClick();
        }

        private void btnRemoveWindowTitle_Click(object sender, EventArgs e)
        {
            if (lbWindowTitles.SelectedIndex >= 0)
                WindowTitlesList.RemoveAt(lbWindowTitles.SelectedIndex);
        }

        private void lbWindowTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete.Equals(e.KeyCode))
                this.btnRemoveWindowTitle.PerformClick();
        }

        private void cbAllProcesses_DropDown(object sender, EventArgs e)
        {
            this.cbAllProcesses.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess() != process && !cbAllProcesses.Items.Contains(process.ProcessName))
                    this.cbAllProcesses.Items.Add(process.ProcessName);
            }
        }

        private void cbAllWindowTitles_DropDown(object sender, EventArgs e)
        {
            this.cbAllWindowTitles.Items.Clear();
            this.cbAllWindowTitles.Items.AddRange(GetOpenedWindowsTitles().ToArray());
        }

        public static ArrayList GetOpenedWindowsTitles()
        {
            ArrayList titles = new ArrayList();

            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Length > 0 && !titles.Contains(process.MainWindowTitle))
                    titles.Add(process.MainWindowTitle);
            }
            return titles;
        }

        static bool ParseBool(XmlNode settings, string setting, bool default_ = false)
        {
            bool val;
            return settings[setting] != null ?
                (Boolean.TryParse(settings[setting].InnerText, out val) ? val : default_)
                : default_;
        }

        static XmlElement ToElement<T>(XmlDocument document, string name, T value)
        {
            XmlElement str = document.CreateElement(name);
            str.InnerText = value.ToString();
            return str;
        }
    }
}
