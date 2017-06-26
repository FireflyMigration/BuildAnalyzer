using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 4 #54</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 4")]
    public class Header4 : FontScheme 
    {
        public Header4()
        {
            try
            {
                this.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
