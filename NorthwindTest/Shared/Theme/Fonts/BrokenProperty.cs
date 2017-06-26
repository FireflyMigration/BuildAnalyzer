using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Broken Property #35</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Broken Property")]
    class BrokenProperty : FontScheme 
    {
        public BrokenProperty()
        {
            try
            {
                this.Font = new Font("MS Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}
