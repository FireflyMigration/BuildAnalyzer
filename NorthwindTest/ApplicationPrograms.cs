namespace NorthwindTest
{
    class ApplicationPrograms : ENV.ProgramCollection 
    {
        public ApplicationPrograms()
        {
            Add(3, "Show Customers", "", typeof(ShowCustomers));
            Add(4, "Show Products", "", typeof(ShowProducts));
            Add(5, "Show Orders", "", typeof(ShowOrders));
            Add(6, "Print - Order", "", typeof(Print_Order));
            Add(7, "Print - Orders", "", typeof(Print_Orders));
            Add(9, "changeFormColor", "", typeof(changeFormColor));
            Add(11, "TestSubFormCallFor357", "", typeof(TestSubFormCallFor357));
        }
    }
}
