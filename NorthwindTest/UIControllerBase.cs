namespace NorthwindTest
{
    /// <summary>UIControllerBase</summary>
    public abstract class UIControllerBase : ENV.UIControllerBase 
    {
        /// <summary>Application that will be used by all inheriting classes</summary>
        internal readonly Application Application = NorthwindTest.Application.Instance;
        internal UIControllerBase()
        {
            setApplication(Application);
        }
    }
}
