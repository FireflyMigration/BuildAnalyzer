using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Tooltips #22</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Tooltips")]
    class Tooltips : FontScheme 
    {
        public Tooltips()
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
