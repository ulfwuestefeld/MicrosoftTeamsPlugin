namespace Loupedeck.MicrosoftTeamsPlugin.Actions
{
    using System;

    public class Screenshare : PluginDynamicCommand
    {
        private Boolean _toggleState = false;

        private readonly String _image0ResourcePath;
        private readonly String _image1ResourcePath;

        public Screenshare() : base(displayName: "Share screen", description: "Toggles screen sharing on/off", groupName: "Appointments, calls and calender")
        {
            this._image0ResourcePath = EmbeddedResources.FindFile("Screenshare0.png");
            this._image1ResourcePath = EmbeddedResources.FindFile("Screenshare1.png");
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            return !this._toggleState
                ? EmbeddedResources.ReadImage(this._image0ResourcePath)
                : EmbeddedResources.ReadImage(this._image1ResourcePath);
        }
        protected override void RunCommand(String actionParameter)
        {
            this._toggleState = !this._toggleState;
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyE, ModifierKey.Control | ModifierKey.Shift);
            this.ActionImageChanged();
        }
    }
}
