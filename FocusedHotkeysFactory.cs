using System.Reflection;
using LiveSplit.UI.Components;
using System;
using LiveSplit.Model;

namespace LiveSplit.FocusedHotkeys
{
    public class FocusedHotkeysFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Focused Hotkeys"; }
        }

        public string Description
        {
            get { return "Enable global hotkeys only when specified programs have focus."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new FocusedHotkeysComponent(state);
        }

        public string UpdateName
        {
            get { return this.ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/Dalet/LiveSplit.FocusedHotkeys/master/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.FocusedHotkeys.xml"; }
        }
    }
}
