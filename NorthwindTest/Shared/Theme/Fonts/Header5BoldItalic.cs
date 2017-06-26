using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 5 Bold Italic #76</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 5 Bold Italic")]
    public class Header5BoldItalic : FontScheme 
    {
        public Header5BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 10F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
