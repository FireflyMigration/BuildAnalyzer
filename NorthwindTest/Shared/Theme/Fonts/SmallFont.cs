using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Small Font #31</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Small Font")]
    class SmallFont : FontScheme 
    {
        public SmallFont()
        {
            try
            {
                this.Font = new Font("Small Fonts", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
