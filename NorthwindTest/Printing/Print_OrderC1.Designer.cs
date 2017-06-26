using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Printing
{
    partial class Print_OrderC1
    {
        internal Shared.Theme.Printing.ReportSection Header;
        Shared.Theme.Colors.Control_sDefault clrControl_sDefault;
        Shared.Theme.Printing.Label lblPage;
        Shared.Theme.Printing.TextBox txtExp_2;
        Shared.Theme.Printing.Label lblOrderPrinting;
        Shared.Theme.Printing.Label lblDate;
        Shared.Theme.Printing.TextBox txtExp_3;
        Shared.Theme.Printing.GroupBox grpDetails;
        Shared.Theme.Printing.TextBox txtOrderDetails_OrderID;
        Shared.Theme.Printing.TextBox txtOrders_ShipName;
        Shared.Theme.Printing.Label lblOrder;
        Shared.Theme.Printing.Label lblCustomer;
        Shared.Theme.Printing.Line lin;
        Shared.Theme.Printing.Label lblOrderDate;
        Shared.Theme.Printing.TextBox txtOrders_OrderDate;
        Shared.Theme.Printing.Label lblShipAddress;
        Shared.Theme.Printing.TextBox txtOrders_ShipAddress;
        Shared.Theme.Printing.Label lblRequiredDate;
        Shared.Theme.Printing.TextBox txtOrders_RequiredDate;
        Shared.Theme.Printing.Label lblShipCity;
        Shared.Theme.Printing.TextBox txtOrders_ShipCity;
        Shared.Theme.Printing.Label lblShippedDate;
        Shared.Theme.Printing.TextBox txtOrders_ShippedDate;
        Shared.Theme.Printing.Label lblShipCountry;
        Shared.Theme.Printing.TextBox txtOrders_ShipCountry;
        Shared.Theme.Printing.Label lblItemDescriptionQuantityP;
        Shared.Theme.Printing.Shape shp;
        Shared.Theme.Colors.missing6ColorInTheClrFile1 clrMissing6ColorInTheClrFile;
        Shared.Theme.Fonts.WizardLargeTitle fntWizardLargeTitle;
        Shared.Theme.Fonts.DefaultDialogText fntDefaultDialogText;
        internal Shared.Theme.Printing.ReportSection Detail;
        Shared.Theme.Colors.missing6ColorInTheClrFile1 clrMissing6ColorInTheClrFile1;
        Shared.Theme.Printing.TextBox txtOrderDetails_ProductID;
        Shared.Theme.Printing.TextBox txtProducts_ProductName;
        Shared.Theme.Printing.TextBox txtOrderDetails_Quantity;
        Shared.Theme.Printing.TextBox txtOrderDetails_UnitPrice;
        Shared.Theme.Printing.TextBox txtOrderDetails_Discount;
        Shared.Theme.Printing.TextBox txtExp_6;
        internal Shared.Theme.Printing.ReportSection Footer;
        Shared.Theme.Colors.missing6ColorInTheClrFile1 clrMissing6ColorInTheClrFile2;
        Shared.Theme.Printing.Shape shp1;
        Shared.Theme.Printing.Label lblOrderTotal;
        Shared.Theme.Printing.TextBox txtVOrderTotal;
        Shared.Theme.Fonts.WizardLargeTitle fntWizardLargeTitle1;
        void InitializeComponent()
        {
            this.Header = new NorthwindTest.Shared.Theme.Printing.ReportSection();
            this.clrControl_sDefault = new NorthwindTest.Shared.Theme.Colors.Control_sDefault();
            this.lblPage = new NorthwindTest.Shared.Theme.Printing.Label();
            this.clrMissing6ColorInTheClrFile = new NorthwindTest.Shared.Theme.Colors.missing6ColorInTheClrFile1();
            this.txtExp_2 = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblOrderPrinting = new NorthwindTest.Shared.Theme.Printing.Label();
            this.fntWizardLargeTitle = new NorthwindTest.Shared.Theme.Fonts.WizardLargeTitle();
            this.lblDate = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtExp_3 = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.grpDetails = new NorthwindTest.Shared.Theme.Printing.GroupBox();
            this.txtOrderDetails_OrderID = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtOrders_ShipName = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblOrder = new NorthwindTest.Shared.Theme.Printing.Label();
            this.fntDefaultDialogText = new NorthwindTest.Shared.Theme.Fonts.DefaultDialogText();
            this.lblCustomer = new NorthwindTest.Shared.Theme.Printing.Label();
            this.lin = new NorthwindTest.Shared.Theme.Printing.Line();
            this.lblOrderDate = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_OrderDate = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblShipAddress = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_ShipAddress = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblRequiredDate = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_RequiredDate = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblShipCity = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_ShipCity = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblShippedDate = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_ShippedDate = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblShipCountry = new NorthwindTest.Shared.Theme.Printing.Label();
            this.txtOrders_ShipCountry = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.lblItemDescriptionQuantityP = new NorthwindTest.Shared.Theme.Printing.Label();
            this.shp = new NorthwindTest.Shared.Theme.Printing.Shape();
            this.Detail = new NorthwindTest.Shared.Theme.Printing.ReportSection();
            this.clrMissing6ColorInTheClrFile1 = new NorthwindTest.Shared.Theme.Colors.missing6ColorInTheClrFile1();
            this.txtOrderDetails_ProductID = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtProducts_ProductName = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtOrderDetails_Quantity = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtOrderDetails_UnitPrice = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtOrderDetails_Discount = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.txtExp_6 = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.Footer = new NorthwindTest.Shared.Theme.Printing.ReportSection();
            this.clrMissing6ColorInTheClrFile2 = new NorthwindTest.Shared.Theme.Colors.missing6ColorInTheClrFile1();
            this.shp1 = new NorthwindTest.Shared.Theme.Printing.Shape();
            this.lblOrderTotal = new NorthwindTest.Shared.Theme.Printing.Label();
            this.fntWizardLargeTitle1 = new NorthwindTest.Shared.Theme.Fonts.WizardLargeTitle();
            this.txtVOrderTotal = new NorthwindTest.Shared.Theme.Printing.TextBox();
            this.Header.SuspendLayout();
            this.Detail.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            
            // Header
            
            this.Header.AutoScaleDimensions = new System.Drawing.SizeF(4.8F, 12F);
            this.Header.ColorScheme = this.clrControl_sDefault;
            this.Header.Controls.Add(this.shp);
            this.Header.Controls.Add(this.lblItemDescriptionQuantityP);
            this.Header.Controls.Add(this.txtOrders_ShipCountry);
            this.Header.Controls.Add(this.lblShipCountry);
            this.Header.Controls.Add(this.txtOrders_ShippedDate);
            this.Header.Controls.Add(this.lblShippedDate);
            this.Header.Controls.Add(this.txtOrders_ShipCity);
            this.Header.Controls.Add(this.lblShipCity);
            this.Header.Controls.Add(this.txtOrders_RequiredDate);
            this.Header.Controls.Add(this.lblRequiredDate);
            this.Header.Controls.Add(this.txtOrders_ShipAddress);
            this.Header.Controls.Add(this.lblShipAddress);
            this.Header.Controls.Add(this.txtOrders_OrderDate);
            this.Header.Controls.Add(this.lblOrderDate);
            this.Header.Controls.Add(this.lin);
            this.Header.Controls.Add(this.lblCustomer);
            this.Header.Controls.Add(this.lblOrder);
            this.Header.Controls.Add(this.txtOrders_ShipName);
            this.Header.Controls.Add(this.txtOrderDetails_OrderID);
            this.Header.Controls.Add(this.grpDetails);
            this.Header.Controls.Add(this.txtExp_3);
            this.Header.Controls.Add(this.lblDate);
            this.Header.Controls.Add(this.lblOrderPrinting);
            this.Header.Controls.Add(this.txtExp_2);
            this.Header.Controls.Add(this.lblPage);
            this.Header.Height = 240;
            this.Header.Name = "Header";
            this.Header.PageHeader = true;
            
            // lblPage
            
            this.lblPage.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblPage.Location = new System.Drawing.Point(365, 9);
            this.lblPage.Name = "lblPage";
            this.lblPage.Rtf = "Page:";
            this.lblPage.Size = new System.Drawing.Size(35, 12);
            this.lblPage.Text = "Page:";
            
            // txtExp_2
            
            this.txtExp_2.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.txtExp_2.Format = "4";
            this.txtExp_2.Location = new System.Drawing.Point(401, 9);
            this.txtExp_2.Name = "txtExp_2";
            this.txtExp_2.Size = new System.Drawing.Size(26, 12);
            this.txtExp_2.Data = Firefly.Box.UI.Advanced.ControlData.FromNumber(_controller.Exp_2);
            
            // lblOrderPrinting
            
            this.lblOrderPrinting.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblOrderPrinting.FontScheme = this.fntWizardLargeTitle;
            this.lblOrderPrinting.Location = new System.Drawing.Point(164, 15);
            this.lblOrderPrinting.Name = "lblOrderPrinting";
            this.lblOrderPrinting.Rtf = "Order Printing";
            this.lblOrderPrinting.Size = new System.Drawing.Size(138, 26);
            this.lblOrderPrinting.Text = "Order Printing";
            
            // lblDate
            
            this.lblDate.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblDate.Location = new System.Drawing.Point(365, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Rtf = "Date:";
            this.lblDate.Size = new System.Drawing.Size(35, 12);
            this.lblDate.Text = "Date:";
            
            // txtExp_3
            
            this.txtExp_3.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.txtExp_3.Format = "##/##/####";
            this.txtExp_3.Location = new System.Drawing.Point(402, 29);
            this.txtExp_3.Name = "txtExp_3";
            this.txtExp_3.Size = new System.Drawing.Size(78, 12);
            this.txtExp_3.Data = Firefly.Box.UI.Advanced.ControlData.FromDate(_controller.Exp_3);
            
            // grpDetails
            
            this.grpDetails.ColorScheme = this.clrControl_sDefault;
            this.grpDetails.LineWidth = 3;
            this.grpDetails.Location = new System.Drawing.Point(43, 66);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(407, 126);
            this.grpDetails.Text = "Details";
            
            // txtOrderDetails_OrderID
            
            this.txtOrderDetails_OrderID.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrderDetails_OrderID.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrderDetails_OrderID.Location = new System.Drawing.Point(92, 87);
            this.txtOrderDetails_OrderID.Name = "txtOrderDetails_OrderID";
            this.txtOrderDetails_OrderID.Size = new System.Drawing.Size(67, 18);
            this.txtOrderDetails_OrderID.Data = this._controller.OrderDetails.OrderID;
            
            // txtOrders_ShipName
            
            this.txtOrders_ShipName.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_ShipName.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_ShipName.Location = new System.Drawing.Point(251, 87);
            this.txtOrders_ShipName.Name = "txtOrders_ShipName";
            this.txtOrders_ShipName.Size = new System.Drawing.Size(191, 18);
            this.txtOrders_ShipName.Data = this._controller.Orders.ShipName;
            
            // lblOrder
            
            this.lblOrder.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblOrder.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblOrder.FontScheme = this.fntDefaultDialogText;
            this.lblOrder.Location = new System.Drawing.Point(54, 90);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Rtf = "Order:";
            this.lblOrder.Size = new System.Drawing.Size(38, 18);
            this.lblOrder.Text = "Order:";
            
            // lblCustomer
            
            this.lblCustomer.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblCustomer.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblCustomer.FontScheme = this.fntDefaultDialogText;
            this.lblCustomer.Location = new System.Drawing.Point(193, 90);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Rtf = "Customer:";
            this.lblCustomer.Size = new System.Drawing.Size(55, 18);
            this.lblCustomer.Text = "Customer:";
            
            // lin
            
            this.lin.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lin.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lin.End = new System.Drawing.Point(449, 111);
            this.lin.Name = "lin";
            this.lin.Start = new System.Drawing.Point(49, 111);
            
            // lblOrderDate
            
            this.lblOrderDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblOrderDate.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblOrderDate.FontScheme = this.fntDefaultDialogText;
            this.lblOrderDate.Location = new System.Drawing.Point(56, 120);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Rtf = "Order Date:";
            this.lblOrderDate.Size = new System.Drawing.Size(50, 12);
            this.lblOrderDate.Text = "Order Date:";
            
            // txtOrders_OrderDate
            
            this.txtOrders_OrderDate.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_OrderDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_OrderDate.Format = "##/##/####Z";
            this.txtOrders_OrderDate.Location = new System.Drawing.Point(127, 120);
            this.txtOrders_OrderDate.Name = "txtOrders_OrderDate";
            this.txtOrders_OrderDate.Size = new System.Drawing.Size(73, 15);
            this.txtOrders_OrderDate.Data = this._controller.Orders.OrderDate;
            
            // lblShipAddress
            
            this.lblShipAddress.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblShipAddress.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblShipAddress.FontScheme = this.fntDefaultDialogText;
            this.lblShipAddress.Location = new System.Drawing.Point(241, 120);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Rtf = "Ship Address:";
            this.lblShipAddress.Size = new System.Drawing.Size(60, 12);
            this.lblShipAddress.Text = "Ship Address:";
            
            // txtOrders_ShipAddress
            
            this.txtOrders_ShipAddress.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_ShipAddress.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_ShipAddress.Location = new System.Drawing.Point(312, 120);
            this.txtOrders_ShipAddress.Name = "txtOrders_ShipAddress";
            this.txtOrders_ShipAddress.Size = new System.Drawing.Size(104, 15);
            this.txtOrders_ShipAddress.Data = this._controller.Orders.ShipAddress;
            
            // lblRequiredDate
            
            this.lblRequiredDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblRequiredDate.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblRequiredDate.FontScheme = this.fntDefaultDialogText;
            this.lblRequiredDate.Location = new System.Drawing.Point(56, 141);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Rtf = "Required Date:";
            this.lblRequiredDate.Size = new System.Drawing.Size(66, 12);
            this.lblRequiredDate.Text = "Required Date:";
            
            // txtOrders_RequiredDate
            
            this.txtOrders_RequiredDate.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_RequiredDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_RequiredDate.Format = "##/##/####Z";
            this.txtOrders_RequiredDate.Location = new System.Drawing.Point(127, 141);
            this.txtOrders_RequiredDate.Name = "txtOrders_RequiredDate";
            this.txtOrders_RequiredDate.Size = new System.Drawing.Size(73, 15);
            this.txtOrders_RequiredDate.Data = this._controller.Orders.RequiredDate;
            
            // lblShipCity
            
            this.lblShipCity.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblShipCity.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblShipCity.FontScheme = this.fntDefaultDialogText;
            this.lblShipCity.Location = new System.Drawing.Point(241, 141);
            this.lblShipCity.Name = "lblShipCity";
            this.lblShipCity.Rtf = "Ship City:";
            this.lblShipCity.Size = new System.Drawing.Size(40, 12);
            this.lblShipCity.Text = "Ship City:";
            
            // txtOrders_ShipCity
            
            this.txtOrders_ShipCity.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_ShipCity.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_ShipCity.Location = new System.Drawing.Point(312, 141);
            this.txtOrders_ShipCity.Name = "txtOrders_ShipCity";
            this.txtOrders_ShipCity.Size = new System.Drawing.Size(104, 15);
            this.txtOrders_ShipCity.Data = this._controller.Orders.ShipCity;
            
            // lblShippedDate
            
            this.lblShippedDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblShippedDate.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblShippedDate.FontScheme = this.fntDefaultDialogText;
            this.lblShippedDate.Location = new System.Drawing.Point(56, 162);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Rtf = "Shipped Date:";
            this.lblShippedDate.Size = new System.Drawing.Size(62, 12);
            this.lblShippedDate.Text = "Shipped Date:";
            
            // txtOrders_ShippedDate
            
            this.txtOrders_ShippedDate.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_ShippedDate.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_ShippedDate.Format = "##/##/####Z";
            this.txtOrders_ShippedDate.Location = new System.Drawing.Point(127, 162);
            this.txtOrders_ShippedDate.Name = "txtOrders_ShippedDate";
            this.txtOrders_ShippedDate.Size = new System.Drawing.Size(73, 15);
            this.txtOrders_ShippedDate.Data = this._controller.Orders.ShippedDate;
            
            // lblShipCountry
            
            this.lblShipCountry.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.lblShipCountry.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblShipCountry.FontScheme = this.fntDefaultDialogText;
            this.lblShipCountry.Location = new System.Drawing.Point(241, 162);
            this.lblShipCountry.Name = "lblShipCountry";
            this.lblShipCountry.Rtf = "Ship Country:";
            this.lblShipCountry.Size = new System.Drawing.Size(58, 12);
            this.lblShipCountry.Text = "Ship Country:";
            
            // txtOrders_ShipCountry
            
            this.txtOrders_ShipCountry.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtOrders_ShipCountry.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpDetails);
            this.txtOrders_ShipCountry.Location = new System.Drawing.Point(312, 162);
            this.txtOrders_ShipCountry.Name = "txtOrders_ShipCountry";
            this.txtOrders_ShipCountry.Size = new System.Drawing.Size(104, 15);
            this.txtOrders_ShipCountry.Data = this._controller.Orders.ShipCountry;
            
            // lblItemDescriptionQuantityP
            
            this.lblItemDescriptionQuantityP.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.lblItemDescriptionQuantityP.Location = new System.Drawing.Point(8, 218);
            this.lblItemDescriptionQuantityP.Name = "lblItemDescriptionQuantityP";
            this.lblItemDescriptionQuantityP.Rtf = "Item                             Description                                       Quantity    Price      Discount      Total";
            this.lblItemDescriptionQuantityP.Size = new System.Drawing.Size(464, 12);
            this.lblItemDescriptionQuantityP.Text = "Item                             Description                                       Quantity    Price      Discount      Total";
            
            // shp
            
            this.shp.ColorScheme = this.clrMissing6ColorInTheClrFile;
            this.shp.LineHorizontal = true;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(7, 231);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(460, 8);
            this.shp.Text = "";
            
            // Detail
            
            this.Detail.ColorScheme = this.clrMissing6ColorInTheClrFile1;
            this.Detail.Controls.Add(this.txtExp_6);
            this.Detail.Controls.Add(this.txtOrderDetails_Discount);
            this.Detail.Controls.Add(this.txtOrderDetails_UnitPrice);
            this.Detail.Controls.Add(this.txtOrderDetails_Quantity);
            this.Detail.Controls.Add(this.txtProducts_ProductName);
            this.Detail.Controls.Add(this.txtOrderDetails_ProductID);
            this.Detail.Height = 18;
            this.Detail.Name = "Detail";
            
            // txtOrderDetails_ProductID
            
            this.txtOrderDetails_ProductID.Location = new System.Drawing.Point(7, 3);
            this.txtOrderDetails_ProductID.Name = "txtOrderDetails_ProductID";
            this.txtOrderDetails_ProductID.Size = new System.Drawing.Size(64, 12);
            this.txtOrderDetails_ProductID.Data = this._controller.OrderDetails.ProductID;
            
            // txtProducts_ProductName
            
            this.txtProducts_ProductName.Location = new System.Drawing.Point(113, 3);
            this.txtProducts_ProductName.Name = "txtProducts_ProductName";
            this.txtProducts_ProductName.Size = new System.Drawing.Size(157, 12);
            this.txtProducts_ProductName.Data = this._controller.Products.ProductName;
            
            // txtOrderDetails_Quantity
            
            this.txtOrderDetails_Quantity.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_Quantity.Location = new System.Drawing.Point(277, 3);
            this.txtOrderDetails_Quantity.Name = "txtOrderDetails_Quantity";
            this.txtOrderDetails_Quantity.Size = new System.Drawing.Size(35, 12);
            this.txtOrderDetails_Quantity.Data = this._controller.OrderDetails.Quantity;
            
            // txtOrderDetails_UnitPrice
            
            this.txtOrderDetails_UnitPrice.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_UnitPrice.Format = "5.2C+$;";
            this.txtOrderDetails_UnitPrice.Location = new System.Drawing.Point(323, 3);
            this.txtOrderDetails_UnitPrice.Name = "txtOrderDetails_UnitPrice";
            this.txtOrderDetails_UnitPrice.Size = new System.Drawing.Size(42, 12);
            this.txtOrderDetails_UnitPrice.Data = this._controller.OrderDetails.UnitPrice;
            
            // txtOrderDetails_Discount
            
            this.txtOrderDetails_Discount.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_Discount.Format = "5.2C+$;";
            this.txtOrderDetails_Discount.Location = new System.Drawing.Point(367, 3);
            this.txtOrderDetails_Discount.Name = "txtOrderDetails_Discount";
            this.txtOrderDetails_Discount.Size = new System.Drawing.Size(46, 12);
            this.txtOrderDetails_Discount.Data = this._controller.OrderDetails.Discount;
            
            // txtExp_6
            
            this.txtExp_6.ColorScheme = this.clrMissing6ColorInTheClrFile1;
            this.txtExp_6.Format = "5.2C+$;";
            this.txtExp_6.Location = new System.Drawing.Point(420, 3);
            this.txtExp_6.Name = "txtExp_6";
            this.txtExp_6.Size = new System.Drawing.Size(43, 12);
            this.txtExp_6.Data = Firefly.Box.UI.Advanced.ControlData.FromNumber(_controller.Exp_6);
            
            // Footer
            
            this.Footer.ColorScheme = this.clrMissing6ColorInTheClrFile2;
            this.Footer.Controls.Add(this.txtVOrderTotal);
            this.Footer.Controls.Add(this.lblOrderTotal);
            this.Footer.Controls.Add(this.shp1);
            this.Footer.Height = 87;
            this.Footer.Name = "Footer";
            
            // shp1
            
            this.shp1.ColorScheme = this.clrMissing6ColorInTheClrFile2;
            this.shp1.LineWidth = 3;
            this.shp1.Location = new System.Drawing.Point(187, 18);
            this.shp1.Name = "shp1";
            this.shp1.Size = new System.Drawing.Size(263, 48);
            this.shp1.Square = true;
            
            // lblOrderTotal
            
            this.lblOrderTotal.BoundTo = new Firefly.Box.UI.ControlBinding(this.shp1);
            this.lblOrderTotal.ColorScheme = this.clrMissing6ColorInTheClrFile2;
            this.lblOrderTotal.FontScheme = this.fntWizardLargeTitle1;
            this.lblOrderTotal.Location = new System.Drawing.Point(242, 35);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Rtf = "Order Total >>";
            this.lblOrderTotal.Size = new System.Drawing.Size(115, 20);
            this.lblOrderTotal.Text = "Order Total >>";
            
            // txtVOrderTotal
            
            this.txtVOrderTotal.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtVOrderTotal.BoundTo = new Firefly.Box.UI.ControlBinding(this.shp1);
            this.txtVOrderTotal.FontScheme = this.fntWizardLargeTitle1;
            this.txtVOrderTotal.Location = new System.Drawing.Point(353, 35);
            this.txtVOrderTotal.Name = "txtVOrderTotal";
            this.txtVOrderTotal.Size = new System.Drawing.Size(86, 20);
            this.txtVOrderTotal.Data = this._controller.vOrderTotal;
            
            // Print_OrderC1
            
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Footer);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 4.8D;
            this.Name = "Print_OrderC1";
            this.UseScaleConversion = false;
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 12D;
            this.Width = 488;
            this.Header.ResumeLayout(false);
            this.Detail.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
