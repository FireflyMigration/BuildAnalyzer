using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Types
{
    /// <summary>Date(T#5)</summary>
    public class Date1 : DateColumn 
    {
        public Date1() : base("Date")
        {
            DefaultValue = Date.Empty;
        }
    }
}
