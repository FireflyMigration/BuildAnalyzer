using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>HTML Default Italic #64</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("HTML Default Italic")]
    public class HTML_DefaultItalic : FontScheme 
    {
        public HTML_DefaultItalic()
        {
            try
            {
                this.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
