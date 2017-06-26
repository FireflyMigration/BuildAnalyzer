namespace NorthwindTest
{
    /// <summary>FlowUIControllerBase</summary>
    public abstract class FlowUIControllerBase : ENV.FlowUIControllerBase 
    {
        /// <summary>Application that will be used by all inheriting classes</summary>
        internal readonly Application Application = NorthwindTest.Application.Instance;
        internal FlowUIControllerBase()
        {
            setApplication(Application);
        }
    }
}
