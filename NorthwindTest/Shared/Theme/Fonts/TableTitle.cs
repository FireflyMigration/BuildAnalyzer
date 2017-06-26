using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Table Title #24</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Table Title")]
    class TableTitle : FontScheme 
    {
        public TableTitle()
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
