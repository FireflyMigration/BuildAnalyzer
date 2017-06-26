namespace NorthwindTest.Shared.Theme.Controls
{
    partial class CompatibleGrid
    {
        void InitializeComponent()
        {
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            FixedBackColorInNonFlatStyles = true;
            Border = Firefly.Box.UI.ControlBorderStyle.Thick;
            RowSeparators = false;
            ActiveRowStyle = Firefly.Box.UI.GridActiveRowStyle.RowAndControlsColor;
            ColumnSeparators = false;
            DrawPartialRow = true;
            AllowUserToReorderColumns = true;
            FixedFocusedTextboxForeColorInAlternatingRowColorStyle = true;
        }
    }
}
