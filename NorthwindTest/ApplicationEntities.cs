namespace NorthwindTest
{
    class ApplicationEntities : ENV.ApplicationEntityCollection 
    {
        public ApplicationEntities()
        {
            Add(1, typeof(Models.Customers));
            Add(2, typeof(Models.Orders));
            Add(3, typeof(Models.OrderDetails));
            Add(4, typeof(Models.Products));
            Add(5, typeof(Models.Categories));
            Add(6, typeof(Models.Shippers));
            Add(7, typeof(Models.Suppliers));
        }
    }
}
