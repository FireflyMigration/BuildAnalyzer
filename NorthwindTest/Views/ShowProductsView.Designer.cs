using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    partial class ShowProductsView
    {
        System.ComponentModel.IContainer components;
        Shared.Theme.Colors.Blue clrBlue;
        Controls.V9CompatibleDefaultTable grd;
        Shared.Theme.Controls.CompatibleGridColumn gclID;
        Shared.Theme.Controls.CompatibleGridColumn gclName;
        Shared.Theme.Controls.CompatibleGridColumn gclUnitPrice;
        Shared.Theme.Controls.CompatibleTextBox txtProducts_ProductID;
        Shared.Theme.Controls.CompatibleTextBox txtProducts_ProductName;
        Shared.Theme.Controls.CompatibleTextBox txtProducts_UnitPrice;
        Controls.OK btn;
        Controls.Close1 btn1;
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
            this.gclID = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtProducts_ProductID = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclName = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtProducts_ProductName = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclUnitPrice = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtProducts_UnitPrice = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.btn = new NorthwindTest.Views.Controls.OK();
            this.btn1 = new NorthwindTest.Views.Controls.Close1();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gclID.SuspendLayout();
            this.gclName.SuspendLayout();
            this.gclUnitPrice.SuspendLayout();
            this.SuspendLayout();
            
            // grd
            
            this.grd.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.grd.Controls.Add(this.gclID);
            this.grd.Controls.Add(this.gclName);
            this.grd.Controls.Add(this.gclUnitPrice);
            this.grd.Location = new System.Drawing.Point(10, 13);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(320, 296);
            
            // gclID
            
            this.gclID.AllowSort = true;
            this.gclID.Controls.Add(this.txtProducts_ProductID);
            this.gclID.Name = "gclID";
            this.gclID.Text = "ID";
            this.gclID.Width = 60;
            
            // txtProducts_ProductID
            
            this.txtProducts_ProductID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtProducts_ProductID.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtProducts_ProductID.Location = new System.Drawing.Point(3, 1);
            this.txtProducts_ProductID.Name = "txtProducts_ProductID";
            this.txtProducts_ProductID.Size = new System.Drawing.Size(55, 16);
            this.txtProducts_ProductID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProducts_ProductID.TabIndex = 1;
            this.txtProducts_ProductID.Tag = "CustomerID";
            this.txtProducts_ProductID.Data = this._controller.Products.ProductID;
            
            // gclName
            
            this.gclName.AllowSort = true;
            this.gclName.Controls.Add(this.txtProducts_ProductName);
            this.gclName.Name = "gclName";
            this.gclName.Text = "Name";
            this.gclName.Width = 170;
            
            // txtProducts_ProductName
            
            this.txtProducts_ProductName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtProducts_ProductName.Location = new System.Drawing.Point(2, 1);
            this.txtProducts_ProductName.Name = "txtProducts_ProductName";
            this.txtProducts_ProductName.Size = new System.Drawing.Size(160, 16);
            this.txtProducts_ProductName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProducts_ProductName.TabIndex = 2;
            this.txtProducts_ProductName.Tag = "CompanyName";
            this.txtProducts_ProductName.Data = this._controller.Products.ProductName;
            
            // gclUnitPrice
            
            this.gclUnitPrice.Controls.Add(this.txtProducts_UnitPrice);
            this.gclUnitPrice.Name = "gclUnitPrice";
            this.gclUnitPrice.Text = "Unit Price";
            this.gclUnitPrice.Width = 67;
            
            // txtProducts_UnitPrice
            
            this.txtProducts_UnitPrice.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtProducts_UnitPrice.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtProducts_UnitPrice.Format = "10.2C+$;";
            this.txtProducts_UnitPrice.Location = new System.Drawing.Point(2, 1);
            this.txtProducts_UnitPrice.Name = "txtProducts_UnitPrice";
            this.txtProducts_UnitPrice.Size = new System.Drawing.Size(60, 16);
            this.txtProducts_UnitPrice.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProducts_UnitPrice.TabIndex = 3;
            this.txtProducts_UnitPrice.Tag = "Address";
            this.txtProducts_UnitPrice.Data = this._controller.Products.UnitPrice;
            
            // btn
            
            this.btn.Location = new System.Drawing.Point(195, 325);
            this.btn.Name = "btn";
            this.btn.RaiseClickBeforeFocusChange = true;
            this.btn.Size = new System.Drawing.Size(60, 23);
            this.btn.TabIndex = 5;
            
            // btn1
            
            this.btn1.Location = new System.Drawing.Point(270, 325);
            this.btn1.Name = "btn1";
            this.btn1.RaiseClickBeforeFocusChange = true;
            this.btn1.Size = new System.Drawing.Size(60, 23);
            this.btn1.TabIndex = 4;
            
            // ShowProductsView
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 361);
            this.ColorScheme = this.clrBlue;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(133, 41);
            this.Name = "ShowProductsView";
            this.StartPosition = Firefly.Box.UI.WindowStartPosition.CenterMDI;
            this.Text = "Show Products";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gclID.ResumeLayout(false);
            this.gclName.ResumeLayout(false);
            this.gclUnitPrice.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
