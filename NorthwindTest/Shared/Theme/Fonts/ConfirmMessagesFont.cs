using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Confirm Messages Font #29</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Confirm Messages Font")]
    class ConfirmMessagesFont : FontScheme 
    {
        public ConfirmMessagesFont()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
