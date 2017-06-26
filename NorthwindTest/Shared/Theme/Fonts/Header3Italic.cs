using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 3 Italic #67</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 3 Italic")]
    public class Header3Italic : FontScheme 
    {
        public Header3Italic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
