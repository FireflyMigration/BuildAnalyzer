using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Reserved #43</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Reserved")]
    class Reserved16 : FontScheme 
    {
        public Reserved16()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
