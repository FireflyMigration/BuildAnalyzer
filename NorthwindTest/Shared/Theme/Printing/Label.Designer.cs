namespace NorthwindTest.Shared.Theme.Printing
{
    partial class Label
    {
        void InitializeComponent()
        {
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            Style = Firefly.Box.UI.ControlStyle.Flat;
            Alignment = System.Drawing.ContentAlignment.TopLeft;
            RightToLeftLayout = false;
            AbsoluteBindTop = true;
        }
    }
}
