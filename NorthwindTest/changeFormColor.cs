using Firefly.Box;
using ENV.Data;
using ENV;
using Firefly.Box.Flow;
namespace NorthwindTest
{
    /// <summary>changeFormColor(P#9)</summary>
    /// <remark>Last change before Migration: 31/05/2016 21:11:45</remark>
    internal class changeFormColor : UIControllerBase 
    {
        #region Models
        internal readonly Models.Customers Customers = new Models.Customers { Cached = true, AllowRowLocking = true };
        #endregion
        public changeFormColor()
        {
            Title = "changeFormColor";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Customers;
            OrderBy = Customers.SortByPK_Customers;
            #region Column Selection
            Columns.Add(Customers.CustomerID);
            Columns.Add(Customers.CompanyName);
            Columns.Add(Customers.ContactName);
            Columns.Add(Customers.ContactTitle);
            #endregion
        }
        /// <summary>changeFormColor(P#9)</summary>
        public void Run()
        {
            Execute();
        }
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnRowSaving;
            View = () => new Views.changeFormColorView(this);
        }
        #region Expressions
        internal Number Exp_1() => u.If(Activity == Activities.Update, 3, 4);
        
        #endregion
    }
}
