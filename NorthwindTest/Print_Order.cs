using Firefly.Box;
using ENV.Data;
using ENV;
namespace NorthwindTest
{
    /// <summary>Print - Order(P#6)</summary>
    /// <remark>Last change before Migration: 24/07/2016 17:12:37</remark>
    internal class Print_Order : BusinessProcessBase 
    {
        #region Models
        internal readonly Models.OrderDetails OrderDetails = new Models.OrderDetails { ReadOnly = true };
        internal readonly Models.Orders Orders = new Models.Orders { ReadOnly = true };
        internal readonly Models.Products Products = new Models.Products { ReadOnly = true };
        #endregion
        #region Parameters
        readonly Types.OrderID pi_OrderID = new Types.OrderID { Caption = "pi.Order ID" };
        #endregion
        #region Columns
        internal readonly Types.Amount vOrderTotal = new Types.Amount { Caption = "vOrderTotal" };
        #endregion
        #region Streams
        ENV.Printing.PrinterWriter _ioPrint_Order;
        #endregion
        #region Layouts
        Printing.Print_OrderC1 _layout { get { return Cached<Printing.Print_OrderC1>(); } }
        #endregion
        public Print_Order()
        {
            Title = "Print - Order";
            InitializeDataView();
            InitializeGroups();
        }
        void InitializeDataView()
        {
            From = OrderDetails;
            
            Relations.Add(Orders, Orders.OrderID.IsEqualTo(OrderDetails.OrderID), Orders.SortByPK_Orders);
            
            Relations.Add(Products, Products.ProductID.IsEqualTo(OrderDetails.ProductID), Products.SortByPK_Products);
            
            Where.Add(CndRange(() => pi_OrderID != 0, OrderDetails.OrderID.IsEqualTo(pi_OrderID)));
            
            OrderBy = OrderDetails.SortByOrderID;
            #region Column Selection
            Columns.Add(pi_OrderID);
            // Range on Order if in parameters
            Columns.Add(OrderDetails.OrderID);
            
            Columns.Add(Orders.OrderID);
            Columns.Add(Orders.CustomerID);
            Columns.Add(Orders.OrderDate);
            Columns.Add(Orders.RequiredDate);
            Columns.Add(Orders.ShippedDate);
            Columns.Add(Orders.ShipName);
            Columns.Add(Orders.ShipAddress);
            Columns.Add(Orders.ShipCity);
            Columns.Add(Orders.ShipCountry);
            
            Columns.Add(OrderDetails.ProductID);
            
            Columns.Add(Products.ProductID);
            Columns.Add(Products.ProductName);
            
            Columns.Add(OrderDetails.UnitPrice);
            Columns.Add(OrderDetails.Quantity);
            Columns.Add(OrderDetails.Discount);
            
            Columns.Add(vOrderTotal);
            MarkParameterColumns(pi_OrderID);
            #endregion
        }
        /// <summary>Print - Order(P#6)</summary>
        public void Run(NumberParameter ppi_OrderID)
        {
            BindParameter(pi_OrderID, ppi_OrderID);
            Execute();
        }
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Browse;
            AllowUserAbort = true;
            
            _ioPrint_Order = new ENV.Printing.PrinterWriter(@"c:\temp\order.pdf") { Name = "Print - Order", PrinterName = Shared.Printing.Printers.Printer1.PrinterName, Pdf = true };
            Streams.Add(_ioPrint_Order);
        }
        void InitializeGroups()
        {
            Groups[OrderDetails.OrderID].Enter += () => 
            #region
            {
                vOrderTotal.Value = 0;
                _ioPrint_Order.NewPage();
                _layout.Header.WriteTo(_ioPrint_Order);
            };
            #endregion
            Groups[OrderDetails.OrderID].Leave += () => 
            #region
            {
                _layout.Footer.WriteTo(_ioPrint_Order);
            };
            #endregion
        }
        protected override void OnLeaveRow()
        {
            if (OrderDetails.Quantity > 0)
            {
                vOrderTotal.Value = vOrderTotal + OrderDetails.UnitPrice * OrderDetails.Quantity - OrderDetails.Discount;
                _layout.Detail.WriteTo(_ioPrint_Order);
            }
        }
        #region Expressions
        internal Number Exp_2() => _ioPrint_Order.Page;
        
        internal Date Exp_3() => Date.Now;
        
        internal Number Exp_6() => OrderDetails.UnitPrice * OrderDetails.Quantity - OrderDetails.Discount;
        
        #endregion
    }
}
