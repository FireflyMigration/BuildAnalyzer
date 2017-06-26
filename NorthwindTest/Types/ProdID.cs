using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Types
{
    /// <summary>Prod ID(T#3)</summary>
    public class ProdID : NumberColumn 
    {
        public ProdID() : base("Prod ID", "10")
        {
            Expand += () => new NorthwindTest.ShowProducts().Run(this);
        }
    }
}
