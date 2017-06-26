using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 6 Bold #63</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 6 Bold")]
    public class Header6Bold : FontScheme 
    {
        public Header6Bold()
        {
            try
            {
                this.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
