namespace Loupedeck.MicrosoftTeamsPlugin.Actions
{
    using System;

    public class ToggleCam : PluginDynamicCommand
    {
        private Boolean _toggleState = false;

        private readonly String _image0ResourcePath;
        private readonly String _image1ResourcePath;

        public ToggleCam() : base(displayName: "Toggle cam", description: "Toggles cam on/off", groupName: "Appointments, calls and calender")
        {
            this._image0ResourcePath = EmbeddedResources.FindFile("ToggleCam0.png");
            this._image1ResourcePath = EmbeddedResources.FindFile("ToggleCam1.png");
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
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.KeyO, ModifierKey.Control | ModifierKey.Shift);
            this.ActionImageChanged();
        }
    }
}
