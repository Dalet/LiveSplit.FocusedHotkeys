using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.FocusedHotkeys
{
    class FocusedHotkeysComponent : LogicComponent
    {
        public override string ComponentName
        {
            get { return "Focused Hotkeys"; }
        }

        public FocusedHotkeysSettings Settings { get; set; }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(int hWnd, StringBuilder title, int size);

        public FocusedHotkeysComponent(LiveSplitState state)
        {
            this.Settings = new FocusedHotkeysSettings();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return this.Settings.GetSettings(document);
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return this.Settings;
        }

        public override void SetSettings(XmlNode settings)
        {
            this.Settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (Settings.ProcessesList.Count > 0 || Settings.WindowTitlesList.Count > 0)
            {
                Process activeProcess = GetActiveWindowProcess();
                string activeWindowTitle = GetActiveWindowTitle();
                if (Settings.ProcessesList.Contains(activeProcess.ProcessName) || Settings.WindowTitlesList.Contains(activeWindowTitle))
                    state.Settings.GlobalHotkeysEnabled = true;
                else
                    state.Settings.GlobalHotkeysEnabled = false;
            }
        }

        public static Process GetActiveWindowProcess()
        {
            uint pid = 0;
            GetWindowThreadProcessId(GetForegroundWindow(), out pid);

            return Process.GetProcessById((int)pid);
        }

        public static string GetActiveWindowTitle()
        {
            StringBuilder title = new StringBuilder(256);
            GetWindowText((int)GetForegroundWindow(), title, 256);

            return title.ToString();
        }

        public override void Dispose()
        {

        }
    }
}
