using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Colors
{
    /// <summary>Window&apos;s Default #1</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Window's Default")]
    public class Window_sDefault : ColorScheme 
    {
        public Window_sDefault()
        {
            this.ForeColor = SystemColors.WindowText;
            this.BackColor = SystemColors.Window;
        }
    }
}
