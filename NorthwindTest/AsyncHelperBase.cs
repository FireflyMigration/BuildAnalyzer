namespace NorthwindTest
{
    /// <summary>AsyncHelperBase</summary>
    public abstract class AsyncHelperBase : ENV.AsyncHelperBase 
    {
        internal AsyncHelperBase() : base(Application.Instance)
        {
        }
    }
}
