using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Fixed Size Font #33</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Fixed Size Font")]
    class FixedSizeFont : FontScheme 
    {
        public FixedSizeFont()
        {
            try
            {
                this.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
