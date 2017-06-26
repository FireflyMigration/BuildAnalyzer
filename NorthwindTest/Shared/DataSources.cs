using ENV.Data.DataProvider;
namespace NorthwindTest.Shared
{
    public class DataSources
    {
        public static DynamicSQLSupportingDataProvider NorthwindSQL 
        {
            get
            {
                return ConnectionManager.GetSQLDataProvider("NorthwindSQL");
            }
        }
    }
}
