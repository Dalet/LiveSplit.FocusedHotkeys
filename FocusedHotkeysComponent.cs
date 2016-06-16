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
        public override string ComponentName => "Focused Hotkeys";

        public bool Enabled { get; protected set; }
        public FocusedHotkeysSettings Settings { get; set; }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(int hWnd, StringBuilder title, int size);

        bool _prevHotkeysEnabled;

        public FocusedHotkeysComponent(LiveSplitState state)
        {
            Settings = new FocusedHotkeysSettings();
            Enabled = true;
            _prevHotkeysEnabled = state.Settings.GlobalHotkeysEnabled;
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (Settings.ProcessesList.Count > 0 || Settings.WindowTitlesList.Count > 0)
            {
                if (IsFocused())
                {
                    if (Settings.AllowFocusedToggle)
                    {
                        // toggle focused hotkeys along global hotkeys if they are manually toggled during focus
                        if (state.Settings.GlobalHotkeysEnabled != _prevHotkeysEnabled)
                            Enabled = state.Settings.GlobalHotkeysEnabled;
                        else if (Enabled)
                            state.Settings.GlobalHotkeysEnabled = true;
                    }
                    else
                        state.Settings.GlobalHotkeysEnabled = Enabled = true; // reset Enabled to true if toggle setting is off
                }
                else // global hotkeys are never allowed without focus
                    state.Settings.GlobalHotkeysEnabled = false;
            }
            _prevHotkeysEnabled = state.Settings.GlobalHotkeysEnabled;
        }

        bool IsFocused()
        {
            return Settings.ProcessesList.Contains(GetActiveWindowProcess().ProcessName)
                || Settings.WindowTitlesList.Contains(GetActiveWindowTitle());
        }

        static Process GetActiveWindowProcess()
        {
            uint pid = 0;
            GetWindowThreadProcessId(GetForegroundWindow(), out pid);

            return Process.GetProcessById((int)pid);
        }

        static string GetActiveWindowTitle()
        {
            StringBuilder title = new StringBuilder(256);
            GetWindowText((int)GetForegroundWindow(), title, 256);

            return title.ToString();
        }

        public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);

        public override Control GetSettingsControl(LayoutMode mode) => Settings;

        public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);

        public override void Dispose() { }
    }
}
