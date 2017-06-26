using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 4 Bold Italic #75</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 4 Bold Italic")]
    public class Header4BoldItalic : FontScheme 
    {
        public Header4BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 12F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
