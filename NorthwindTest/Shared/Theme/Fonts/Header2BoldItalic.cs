using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 2 Bold Italic #73</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 2 Bold Italic")]
    public class Header2BoldItalic : FontScheme 
    {
        public Header2BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 16F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
