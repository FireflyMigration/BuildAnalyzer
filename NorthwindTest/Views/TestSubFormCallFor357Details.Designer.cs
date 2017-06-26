using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    partial class TestSubFormCallFor357Details
    {
        System.ComponentModel.IContainer components;
        Shared.Theme.Controls.CompatibleLabel lblOrderID;
        Shared.Theme.Controls.CompatibleTextBox txtOrderDetails_OrderID;
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
            this.txtOrderDetails_OrderID = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.SuspendLayout();
            
            // lblOrderID
            
            this.lblOrderID.FontScheme = this.fntDefaultTableEditField;
            this.lblOrderID.Location = new System.Drawing.Point(150, 156);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Rtf = "OrderID";
            this.lblOrderID.Size = new System.Drawing.Size(38, 13);
            this.lblOrderID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblOrderID.Text = "OrderID";
            
            // txtOrderDetails_OrderID
            
            this.txtOrderDetails_OrderID.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOrderDetails_OrderID.Location = new System.Drawing.Point(193, 156);
            this.txtOrderDetails_OrderID.Name = "txtOrderDetails_OrderID";
            this.txtOrderDetails_OrderID.Size = new System.Drawing.Size(63, 16);
            this.txtOrderDetails_OrderID.Tag = "OrderID";
            this.txtOrderDetails_OrderID.Data = this._controller.OrderDetails.OrderID;
            
            // TestSubFormCallFor357Details
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.txtOrderDetails_OrderID);
            this.Controls.Add(this.lblOrderID);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "TestSubFormCallFor357Details";
            this.Text = "details";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
