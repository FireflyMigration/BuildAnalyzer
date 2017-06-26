﻿namespace NorthwindTest.Shared.Theme.Controls
{
    public partial class Label : ENV.UI.Label 
    {
        /// <summary>Label</summary>
        public Label()
        {
            if (!DesignMode)
            	FixedBackColorInNonFlatStyles = ENV.UserSettings.FixedBackColorInNonFlatStyles;
            InitializeComponent();
        }
    }
}
