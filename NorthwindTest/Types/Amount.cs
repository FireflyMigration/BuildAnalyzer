using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Types
{
    /// <summary>Amount(T#4)</summary>
    class Amount : NumberColumn 
    {
        public Amount() : base("Amount", "5.2CZ +$;")
        {
        }
    }
}
