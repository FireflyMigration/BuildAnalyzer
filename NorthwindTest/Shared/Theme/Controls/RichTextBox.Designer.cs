namespace NorthwindTest.Shared.Theme.Controls
{
    partial class RichTextBox
    {
        void InitializeComponent()
        {
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            AbsoluteBindTop = true;
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Control_sDefault();
            Style = Firefly.Box.UI.ControlStyle.Standard;
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            RightToLeftLayout = false;
            OnEnterEditingSelectAllText = true;
        }
    }
}
