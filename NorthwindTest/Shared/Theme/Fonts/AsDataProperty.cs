using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>As Data Property #36</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("As Data Property")]
    class AsDataProperty : FontScheme 
    {
        public AsDataProperty()
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
