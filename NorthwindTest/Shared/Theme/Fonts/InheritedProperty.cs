using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Inherited Property #34</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Inherited Property")]
    class InheritedProperty : FontScheme 
    {
        public InheritedProperty()
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
