namespace NorthwindTest.Shared.Theme.Controls
{
    public partial class Grid : ENV.UI.Grid 
    {
        /// <summary>Grid</summary>
        public Grid()
        {
            if (!DesignMode)
            	FixedBackColorInNonFlatStyles = ENV.UserSettings.FixedBackColorInNonFlatStyles;
            if (!DesignMode)
            	StartOnRowPosition = ENV.UserSettings.GridStartOnRowPosition;
            GridColumnType = typeof(GridColumn);
            DefaultTextBoxType = typeof(TextBox);
            InitializeComponent();
        }
    }
}
