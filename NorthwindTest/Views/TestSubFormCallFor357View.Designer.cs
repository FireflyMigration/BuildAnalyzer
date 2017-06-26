using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    partial class TestSubFormCallFor357View
    {
        System.ComponentModel.IContainer components;
        Shared.Theme.Controls.CompatibleLabel lblOrderID;
        Shared.Theme.Controls.CompatibleTextBox txtOrders_OrderID;
        Shared.Theme.Controls.SubForm SubFormDetails;
        Shared.Theme.Fonts.DefaultTableEditField fntDefaultTableEditField;
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
            this.fntDefaultTableEditField = new NorthwindTest.Shared.Theme.Fonts.DefaultTableEditField();
            this.lblOrderID = new NorthwindTest.Shared.Theme.Controls.CompatibleLabel();
            this.txtOrders_OrderID = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.SubFormDetails = new NorthwindTest.Shared.Theme.Controls.SubForm();
            this.SuspendLayout();
            
            // lblOrderID
            
            this.lblOrderID.FontScheme = this.fntDefaultTableEditField;
            this.lblOrderID.Location = new System.Drawing.Point(60, 26);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Rtf = "OrderID";
            this.lblOrderID.Size = new System.Drawing.Size(38, 13);
            this.lblOrderID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblOrderID.Text = "OrderID";
            
            // txtOrders_OrderID
            
            this.txtOrders_OrderID.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrders_OrderID.Location = new System.Drawing.Point(103, 26);
            this.txtOrders_OrderID.Name = "txtOrders_OrderID";
            this.txtOrders_OrderID.Size = new System.Drawing.Size(63, 16);
            this.txtOrders_OrderID.Tag = "OrderID";
            this.txtOrders_OrderID.Data = this._controller.Orders.OrderID;
            
            // SubFormDetails
            
            this.SubFormDetails.Location = new System.Drawing.Point(20, 91);
            this.SubFormDetails.Name = "SubFormDetails";
            this.SubFormDetails.Size = new System.Drawing.Size(370, 192);
            this.SubFormDetails.TabIndex = 2;
            this.SubFormDetails.Tag = "details";
            
            // TestSubFormCallFor357View
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.SubFormDetails);
            this.Controls.Add(this.txtOrders_OrderID);
            this.Controls.Add(this.lblOrderID);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "TestSubFormCallFor357View";
            this.Text = "TestSubFormCallFor357";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
