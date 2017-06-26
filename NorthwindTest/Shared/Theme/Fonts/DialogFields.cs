using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Dialog Fields #25</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Dialog Fields")]
    class DialogFields : FontScheme 
    {
        public DialogFields()
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
