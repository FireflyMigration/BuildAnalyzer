namespace NorthwindTest.Shared.Theme.Controls
{
    partial class CompatibleGridColumn
    {
        void InitializeComponent()
        {
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            AbsoluteBindTop = true;
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableTitle();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            AllowSort = false;
            RightToLeftLayout = false;
            UseTextEndEllipsis = true;
            AllowTransparentBackColor = false;
        }
    }
}
