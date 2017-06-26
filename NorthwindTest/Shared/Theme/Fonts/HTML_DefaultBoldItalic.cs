using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>HTML Default Bold Italic #71</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("HTML Default Bold Italic")]
    public class HTML_DefaultBoldItalic : FontScheme 
    {
        public HTML_DefaultBoldItalic()
        {
            try
            {
                this.Font = new Font("Arial", 12F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
