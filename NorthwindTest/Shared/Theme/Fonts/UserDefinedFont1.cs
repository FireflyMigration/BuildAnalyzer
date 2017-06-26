using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>User Defined Font #110</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("User Defined Font")]
    class UserDefinedFont1 : FontScheme 
    {
        public UserDefinedFont1()
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
