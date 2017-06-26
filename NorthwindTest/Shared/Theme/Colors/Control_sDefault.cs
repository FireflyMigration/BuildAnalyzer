using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Colors
{
    /// <summary>Control&apos;s Default #2</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Control's Default")]
    public class Control_sDefault : ColorScheme 
    {
        public Control_sDefault()
        {
            this.ForeColor = SystemColors.WindowText;
            this.BackColor = SystemColors.Window;
        }
    }
}
