using Firefly.Box;
using ENV.Data;
namespace NorthwindTest.Models
{
    /// <summary>Shippers(E#6)</summary>
    public class Shippers : Entity 
    {
        #region Columns
        [PrimaryKey]
        public readonly NumberColumn ShipperID = new NumberColumn("ShipperID", "N10") { ReadOnlyForExistingRows = true, NullDisplayText = "" };
        public readonly TextColumn CompanyName = new TextColumn("CompanyName", "40") { NullDisplayText = "" };
        public readonly TextColumn Phone = new TextColumn("Phone", "24") { NullDisplayText = "" };
        #endregion
        #region Indexes
        /// <summary>PK_Shippers (#1)</summary>
        public readonly Index SortByPK_Shippers = new Index { Caption = "PK_Shippers", Name = "PK_Shippers", AutoCreate = true, Unique = true };
        #endregion
        public Shippers() : base("Shippers", NorthwindTest.Shared.DataSources.NorthwindSQL)
        {
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortByPK_Shippers.Add(ShipperID);
        }
    }
}
