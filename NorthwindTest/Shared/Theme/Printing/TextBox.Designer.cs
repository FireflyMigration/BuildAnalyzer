namespace NorthwindTest.Shared.Theme.Printing
{
    partial class TextBox
    {
        void InitializeComponent()
        {
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            Style = Firefly.Box.UI.ControlStyle.Flat;
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            RightToLeftLayout = false;
            AbsoluteBindTop = true;
            RightToLeftByFormat = true;
        }
    }
}
