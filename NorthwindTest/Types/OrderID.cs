using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Types
{
    /// <summary>Order ID(T#2)</summary>
    public class OrderID : NumberColumn 
    {
        public OrderID() : base("Order ID", "10")
        {
        }
    }
}
