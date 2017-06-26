using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Large Font #32</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Large Font")]
    class LargeFont : FontScheme 
    {
        public LargeFont()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
