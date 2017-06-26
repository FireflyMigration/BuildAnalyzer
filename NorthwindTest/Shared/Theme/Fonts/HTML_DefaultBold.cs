using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>HTML Default Bold #57</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("HTML Default Bold")]
    public class HTML_DefaultBold : FontScheme 
    {
        public HTML_DefaultBold()
        {
            try
            {
                this.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
