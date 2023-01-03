namespace Loupedeck.MicrosoftTeamsPlugin.Actions
{
    using System;

    public class AcceptVideoCall : PluginDynamicCommand
    {
        //private Boolean _toggleState = false;

        private readonly String _image0ResourcePath;
        //private readonly String _image1ResourcePath;

        public AcceptVideoCall() : base(displayName: "Accept video call", description: "Accepts a call as a video call", groupName: "Appointments, calls and calender")
        {
            this._image0ResourcePath = EmbeddedResources.FindFile("AcceptVideoCall0.png");
            //this._image1ResourcePath = EmbeddedResources.FindFile("AcceptVideoCall1.png");
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyA, ModifierKey.Control | ModifierKey.Shift);
            //this.ActionImageChanged();
        }
    }
}
