using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 3 Bold Italic #74</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 3 Bold Italic")]
    public class Header3BoldItalic : FontScheme 
    {
        public Header3BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 14F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
