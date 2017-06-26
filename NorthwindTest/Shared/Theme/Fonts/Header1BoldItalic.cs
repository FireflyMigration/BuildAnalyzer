using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 1 Bold Italic #72</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 1 Bold Italic")]
    public class Header1BoldItalic : FontScheme 
    {
        public Header1BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 18F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
