using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Colors
{
    /// <summary>Blue #4</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Blue")]
    public class Blue : ColorScheme 
    {
        public Blue()
        {
            this.ForeColor = SystemColors.WindowText;
            this.BackColor = Color.FromArgb(0,128,192);
        }
    }
}
