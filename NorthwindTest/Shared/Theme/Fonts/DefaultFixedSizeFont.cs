using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Default Fixed Size Font #7</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Default Fixed Size Font")]
    public class DefaultFixedSizeFont : FontScheme 
    {
        public DefaultFixedSizeFont()
        {
            try
            {
                this.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
