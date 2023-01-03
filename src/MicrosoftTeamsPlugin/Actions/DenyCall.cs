namespace Loupedeck.MicrosoftTeamsPlugin.Actions
{
    using System;

    public class DenyCall : PluginDynamicCommand
    {
        //private Boolean _toggleState = false;

        private readonly String _image0ResourcePath;
        //private readonly String _image1ResourcePath;

        public DenyCall() : base(displayName: "Deny call", description: "Denies a call", groupName: "Appointments, calls and calender")
        {
            this._image0ResourcePath = EmbeddedResources.FindFile("DenyCall0.png");
            //this._image1ResourcePath = EmbeddedResources.FindFile("DenyCall1.png");
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            /*return !this._toggleState
                ? EmbeddedResources.ReadImage(this._image0ResourcePath)
                : EmbeddedResources.ReadImage(this._image1ResourcePath);*/
            return EmbeddedResources.ReadImage(this._image0ResourcePath);
        }
        protected override void RunCommand(String actionParameter)
        {
            /*if (!this._toggleState)
            {
                this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyH);
            }
            else
            {
                this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyI);
            }
            this._toggleState = !this._toggleState;*/
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyD, ModifierKey.Control | ModifierKey.Shift);
            //this.ActionImageChanged();
        }
    }
}
