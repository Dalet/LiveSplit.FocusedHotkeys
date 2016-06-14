using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

namespace LiveSplit.FocusedHotkeys
{
    public class FocusedHotkeysFactory : IComponentFactory
    {
        public string ComponentName => "Focused Hotkeys";

        public string Description => "Enable global hotkeys only when specified programs have focus.";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new FocusedHotkeysComponent(state);

        public string UpdateName => this.ComponentName;

        public string UpdateURL => "https://raw.githubusercontent.com/Dalet/LiveSplit.FocusedHotkeys/master/";

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public string XMLURL => this.UpdateURL + "Components/update.LiveSplit.FocusedHotkeys.xml";
    }
}
