using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Types
{
    /// <summary>Customer ID(T#1)</summary>
    public class CustomerID : TextColumn 
    {
        public CustomerID() : base("Customer ID", "5")
        {
            Expand += () => new NorthwindTest.ShowCustomers().Run(this);
        }
    }
}
