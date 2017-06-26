namespace NorthwindTest.Shared.Theme.Controls
{
    partial class TabControl
    {
        void InitializeComponent()
        {
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            AbsoluteBindTop = true;
            Alignment = System.Drawing.ContentAlignment.TopLeft;
            RightToLeftLayout = false;
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Control_sDefault();
            AllowChangeInBrowse = false;
        }
    }
}
