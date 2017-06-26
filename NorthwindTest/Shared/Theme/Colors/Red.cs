using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Colors
{
    /// <summary>Red #3</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Red")]
    class Red : ColorScheme 
    {
        public Red()
        {
            this.ForeColor = SystemColors.WindowText;
            this.BackColor = Color.FromArgb(255,0,0);
        }
    }
}
