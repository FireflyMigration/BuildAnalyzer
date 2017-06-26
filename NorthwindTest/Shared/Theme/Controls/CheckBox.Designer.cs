namespace NorthwindTest.Shared.Theme.Controls
{
    partial class CheckBox
    {
        void InitializeComponent()
        {
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            FontScheme = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Control_sDefault();
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            RightToLeftLayout = false;
            ColumnChangeWhileFocusedForcesRowChange = true;
            FixedForeColor = true;
        }
    }
}
