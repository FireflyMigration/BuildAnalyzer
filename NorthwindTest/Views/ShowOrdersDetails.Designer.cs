using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    partial class ShowOrdersDetails
    {
        System.ComponentModel.IContainer components;
        Shared.Theme.Colors.Blue clrBlue;
        Controls.V9CompatibleDefaultTable grd;
        Shared.Theme.Controls.CompatibleGridColumn gclProduct;
        Shared.Theme.Controls.CompatibleGridColumn gclUnitPrice;
        Shared.Theme.Controls.CompatibleGridColumn gclQuantity;
        Shared.Theme.Controls.CompatibleGridColumn gclDiscount;
        Shared.Theme.Controls.CompatibleGridColumn gclTotal;
        Shared.Theme.Controls.CompatibleTextBox txtOrderDetails_UnitPrice;
        Shared.Theme.Controls.CompatibleTextBox txtOrderDetails_Quantity;
        Shared.Theme.Controls.CompatibleTextBox txtOrderDetails_Discount;
        Shared.Theme.Controls.CompatibleTextBox txtExp_3;
        Shared.Theme.Controls.ComboBox cboOrderDetails_ProductID;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.clrBlue = new NorthwindTest.Shared.Theme.Colors.Blue();
            this.grd = new NorthwindTest.Views.Controls.V9CompatibleDefaultTable();
            this.gclProduct = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.cboOrderDetails_ProductID = new NorthwindTest.Shared.Theme.Controls.ComboBox();
            this.gclUnitPrice = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtOrderDetails_UnitPrice = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclQuantity = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtOrderDetails_Quantity = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclDiscount = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtOrderDetails_Discount = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclTotal = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtExp_3 = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gclProduct.SuspendLayout();
            this.gclUnitPrice.SuspendLayout();
            this.gclQuantity.SuspendLayout();
            this.gclDiscount.SuspendLayout();
            this.gclTotal.SuspendLayout();
            this.SuspendLayout();
            
            // grd
            
            this.grd.Controls.Add(this.gclProduct);
            this.grd.Controls.Add(this.gclUnitPrice);
            this.grd.Controls.Add(this.gclQuantity);
            this.grd.Controls.Add(this.gclDiscount);
            this.grd.Controls.Add(this.gclTotal);
            this.grd.Location = new System.Drawing.Point(8, 8);
            this.grd.Name = "grd";
            this.grd.RowHeight = 23;
            this.grd.Size = new System.Drawing.Size(445, 143);
            
            // gclProduct
            
            this.gclProduct.Controls.Add(this.cboOrderDetails_ProductID);
            this.gclProduct.Name = "gclProduct";
            this.gclProduct.Text = "Product";
            this.gclProduct.Width = 212;
            
            // cboOrderDetails_ProductID
            
            this.cboOrderDetails_ProductID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.cboOrderDetails_ProductID.IgnoreEmptyBoundValues = true;
            this.cboOrderDetails_ProductID.Location = new System.Drawing.Point(3, 1);
            this.cboOrderDetails_ProductID.Name = "cboOrderDetails_ProductID";
            this.cboOrderDetails_ProductID.Size = new System.Drawing.Size(202, 19);
            this.cboOrderDetails_ProductID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.cboOrderDetails_ProductID.TabIndex = 1;
            this.cboOrderDetails_ProductID.Tag = "ProductID";
            this.cboOrderDetails_ProductID.BindListSource += new Firefly.Box.UI.Advanced.BindingEventHandler<System.EventArgs>(cboOrderDetails_ProductID_BindListSource);
            this.cboOrderDetails_ProductID.Data = this._controller.OrderDetails.ProductID;
            
            // gclUnitPrice
            
            this.gclUnitPrice.Controls.Add(this.txtOrderDetails_UnitPrice);
            this.gclUnitPrice.Name = "gclUnitPrice";
            this.gclUnitPrice.Text = "Unit Price";
            this.gclUnitPrice.Width = 55;
            
            // txtOrderDetails_UnitPrice
            
            this.txtOrderDetails_UnitPrice.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtOrderDetails_UnitPrice.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_UnitPrice.Format = "5.2CZ +$;";
            this.txtOrderDetails_UnitPrice.Location = new System.Drawing.Point(2, 1);
            this.txtOrderDetails_UnitPrice.Name = "txtOrderDetails_UnitPrice";
            this.txtOrderDetails_UnitPrice.Size = new System.Drawing.Size(47, 16);
            this.txtOrderDetails_UnitPrice.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtOrderDetails_UnitPrice.TabIndex = 2;
            this.txtOrderDetails_UnitPrice.Tag = "UnitPrice";
            this.txtOrderDetails_UnitPrice.Data = this._controller.OrderDetails.UnitPrice;
            
            // gclQuantity
            
            this.gclQuantity.Controls.Add(this.txtOrderDetails_Quantity);
            this.gclQuantity.Name = "gclQuantity";
            this.gclQuantity.Text = "Quantity";
            this.gclQuantity.Width = 49;
            
            // txtOrderDetails_Quantity
            
            this.txtOrderDetails_Quantity.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtOrderDetails_Quantity.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_Quantity.Location = new System.Drawing.Point(2, 1);
            this.txtOrderDetails_Quantity.Name = "txtOrderDetails_Quantity";
            this.txtOrderDetails_Quantity.Size = new System.Drawing.Size(40, 16);
            this.txtOrderDetails_Quantity.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtOrderDetails_Quantity.TabIndex = 3;
            this.txtOrderDetails_Quantity.Tag = "Quantity";
            this.txtOrderDetails_Quantity.Data = this._controller.OrderDetails.Quantity;
            
            // gclDiscount
            
            this.gclDiscount.Controls.Add(this.txtOrderDetails_Discount);
            this.gclDiscount.Name = "gclDiscount";
            this.gclDiscount.Text = "Discount";
            this.gclDiscount.Width = 61;
            
            // txtOrderDetails_Discount
            
            this.txtOrderDetails_Discount.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtOrderDetails_Discount.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_Discount.Format = "5.2CZ +$;";
            this.txtOrderDetails_Discount.Location = new System.Drawing.Point(2, 1);
            this.txtOrderDetails_Discount.Name = "txtOrderDetails_Discount";
            this.txtOrderDetails_Discount.Size = new System.Drawing.Size(52, 16);
            this.txtOrderDetails_Discount.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtOrderDetails_Discount.TabIndex = 4;
            this.txtOrderDetails_Discount.Tag = "Discount";
            this.txtOrderDetails_Discount.Data = this._controller.OrderDetails.Discount;
            
            // gclTotal
            
            this.gclTotal.Controls.Add(this.txtExp_3);
            this.gclTotal.Name = "gclTotal";
            this.gclTotal.Text = "Total";
            this.gclTotal.Width = 47;
            
            // txtExp_3
            
            this.txtExp_3.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_3.Format = "5.2CZ +$;";
            this.txtExp_3.Location = new System.Drawing.Point(2, 1);
            this.txtExp_3.Name = "txtExp_3";
            this.txtExp_3.Size = new System.Drawing.Size(42, 16);
            this.txtExp_3.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_3.TabIndex = 5;
            this.txtExp_3.Data = Firefly.Box.UI.Advanced.ControlData.FromNumber(_controller.Exp_3);
            
            // ShowOrdersDetails
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.ChildWindow = true;
            this.ClientSize = new System.Drawing.Size(467, 158);
            this.ColorScheme = this.clrBlue;
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(26, 153);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowOrdersDetails";
            this.SystemMenu = false;
            this.Text = "Details";
            this.TitleBar = false;
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gclProduct.ResumeLayout(false);
            this.gclUnitPrice.ResumeLayout(false);
            this.gclQuantity.ResumeLayout(false);
            this.gclDiscount.ResumeLayout(false);
            this.gclTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
