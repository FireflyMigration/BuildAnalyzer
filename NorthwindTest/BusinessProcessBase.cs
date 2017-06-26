namespace NorthwindTest
{
    /// <summary>BusinessProcessBase</summary>
    public abstract class BusinessProcessBase : ENV.BusinessProcessBase 
    {
        /// <summary>Application that will be used by all inheriting classes</summary>
        internal readonly Application Application = NorthwindTest.Application.Instance;
        internal BusinessProcessBase()
        {
            setApplication(Application);
        }
    }
}
