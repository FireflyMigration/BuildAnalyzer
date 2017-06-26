using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Models
{
    /// <summary>Orders(E#2)</summary>
    public class Orders : Entity 
    {
        #region Columns
        [PrimaryKey]
        public readonly Types.OrderID OrderID = new Types.OrderID { Caption = "OrderID", Name = "OrderID", ReadOnlyForExistingRows = true, NullDisplayText = "" };
        public readonly Types.CustomerID CustomerID = new Types.CustomerID { Caption = "CustomerID", Name = "CustomerID", NullDisplayText = "" };
        public readonly NumberColumn EmployeeID = new NumberColumn("EmployeeID", "N10") { AllowNull = false, NullDisplayText = "" };
        public readonly Types.Date1 OrderDate = new Types.Date1 { Caption = "OrderDate", Name = "OrderDate", Format = "##/##/####", NullDisplayText = "" };
        public readonly Types.Date1 RequiredDate = new Types.Date1 { Caption = "RequiredDate", Name = "RequiredDate", Format = "##/##/####", NullDisplayText = "" };
        public readonly Types.Date1 ShippedDate = new Types.Date1 { Caption = "ShippedDate", Name = "ShippedDate", Format = "##/##/####", NullDisplayText = "" };
        public readonly NumberColumn ShipVia = new NumberColumn("ShipVia", "N10") { NullDisplayText = "" };
        public readonly NumberColumn Freight = new NumberColumn("Freight", "10.3") { NullDisplayText = "" };
        public readonly TextColumn ShipName = new TextColumn("ShipName", "40") { NullDisplayText = "" };
        public readonly TextColumn ShipAddress = new TextColumn("ShipAddress", "60") { NullDisplayText = "" };
        public readonly TextColumn ShipCity = new TextColumn("ShipCity", "15") { NullDisplayText = "" };
        public readonly TextColumn ShipRegion = new TextColumn("ShipRegion", "15") { NullDisplayText = "" };
        public readonly TextColumn ShipPostalCode = new TextColumn("ShipPostalCode", "10") { NullDisplayText = "" };
        public readonly TextColumn ShipCountry = new TextColumn("ShipCountry", "15") { NullDisplayText = "" };
        #endregion
        #region Indexes
        /// <summary>PK_Orders (#1)</summary>
        public readonly Index SortByPK_Orders = new Index { Caption = "PK_Orders", Name = "PK_Orders", AutoCreate = true, Unique = true };
        /// <summary>CustomerID (#2)</summary>
        public readonly Index SortByCustomerID = new Index { Caption = "CustomerID", Name = "CustomerID", AutoCreate = true };
        #endregion
        public Orders() : base("Orders", NorthwindTest.Shared.DataSources.NorthwindSQL)
        {
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortByPK_Orders.Add(OrderID);
            SortByCustomerID.Add(CustomerID);
        }
    }
}
