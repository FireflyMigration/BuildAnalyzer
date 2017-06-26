namespace NorthwindTest.Shared.Theme.Controls
{
    partial class RadioButton
    {
        void InitializeComponent()
        {
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.RadioButtonDefaultFont();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Control_sDefault();
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            FixedBackColorInNonFlatStyles = true;
            Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            Style = Firefly.Box.UI.ControlStyle.Raised;
            RightToLeftLayout = false;
            RadioTextSpacing = 5;
            Multiline = true;
        }
    }
}
