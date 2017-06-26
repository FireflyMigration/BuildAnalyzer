using Firefly.Box;
using ENV.Data;
using ENV;
using Firefly.Box.Flow;
namespace NorthwindTest
{
    /// <summary>TestSubFormCallFor357(P#11)</summary>
    /// <remark>Last change before Migration: 05/06/2017 10:11:19</remark>
    internal class TestSubFormCallFor357 : UIControllerBase 
    {
        #region Models
        internal readonly Models.Orders Orders = new Models.Orders { Cached = true, AllowRowLocking = true };
        #endregion
        internal details details1;
        public TestSubFormCallFor357()
        {
            #region Initialize CachedControllers
            details1 = new details(this);
            #endregion
            Title = "TestSubFormCallFor357";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Orders;
            OrderBy = Orders.SortByPK_Orders;
            #region Column Selection
            Columns.Add(Orders.OrderID);
            #endregion
        }
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnRowSaving;
            View = () => new Views.TestSubFormCallFor357View(this);
        }
        #region Subforms
        internal void details_SubForm() => details1.Run();
        
        #endregion
        /// <summary>details(P#11.1)</summary>
        /// <remark>Last change before Migration: 05/06/2017 10:11:19</remark>
        internal class details : UIControllerBase 
        {
            #region Models
            internal readonly Models.OrderDetails OrderDetails = new Models.OrderDetails { AllowRowLocking = true };
            #endregion
            TestSubFormCallFor357 _parent;
            public details(TestSubFormCallFor357 parent)
            {
                _parent = parent;
                Title = "details";
                InitializeDataView()
            }
            void InitializeDataView()
            {
                From = OrderDetails;
                Where.Add(OrderDetails.OrderID.IsEqualTo(_parent.Orders.OrderID));
                
                OrderBy = OrderDetails.SortByPK_Order_Details;
                #region Column Selection
                Columns.Add(OrderDetails.OrderID);
                #endregion
            }
            /// <summary>details(P#11.1)</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                View = () => new Views.TestSubFormCallFor357Details(this);
            }
            protected override void OnStart()
            {
                Message.ShowWarning(u.Str(u.SubformExecMode(0), "7"));
            }
        }
    }
}
