using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    partial class changeFormColorView
    {
        System.ComponentModel.IContainer components;
        Shared.Theme.Colors.Window_sDefault clrWindow_sDefault;
        Shared.Theme.Controls.CompatibleGrid grd;
        Shared.Theme.Controls.CompatibleGridColumn gclCustomerID;
        Shared.Theme.Controls.CompatibleGridColumn gclCompanyName;
        Shared.Theme.Controls.CompatibleGridColumn gclContactName;
        Shared.Theme.Controls.CompatibleGridColumn gclContactTitle;
        Shared.Theme.Controls.CompatibleTextBox txtCustomers_CustomerID;
        Shared.Theme.Controls.CompatibleTextBox txtCustomers_CompanyName;
        Shared.Theme.Controls.CompatibleTextBox txtCustomers_ContactName;
        Shared.Theme.Controls.CompatibleTextBox txtCustomers_ContactTitle;
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
            this.clrWindow_sDefault = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            this.grd = new NorthwindTest.Shared.Theme.Controls.CompatibleGrid();
            this.gclCustomerID = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtCustomers_CustomerID = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclCompanyName = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtCustomers_CompanyName = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclContactName = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtCustomers_ContactName = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.gclContactTitle = new NorthwindTest.Shared.Theme.Controls.CompatibleGridColumn();
            this.txtCustomers_ContactTitle = new NorthwindTest.Shared.Theme.Controls.CompatibleTextBox();
            this.grd.SuspendLayout();
            this.gclCustomerID.SuspendLayout();
            this.gclCompanyName.SuspendLayout();
            this.gclContactName.SuspendLayout();
            this.gclContactTitle.SuspendLayout();
            this.SuspendLayout();
            
            // grd
            
            this.grd.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.grd.Controls.Add(this.gclCustomerID);
            this.grd.Controls.Add(this.gclCompanyName);
            this.grd.Controls.Add(this.gclContactName);
            this.grd.Controls.Add(this.gclContactTitle);
            this.grd.Location = new System.Drawing.Point(10, 13);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(818, 296);
            
            // gclCustomerID
            
            this.gclCustomerID.AllowSort = true;
            this.gclCustomerID.Controls.Add(this.txtCustomers_CustomerID);
            this.gclCustomerID.Name = "gclCustomerID";
            this.gclCustomerID.Text = "CustomerID";
            this.gclCustomerID.Width = 60;
            
            // txtCustomers_CustomerID
            
            this.txtCustomers_CustomerID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtCustomers_CustomerID.Location = new System.Drawing.Point(3, 2);
            this.txtCustomers_CustomerID.Name = "txtCustomers_CustomerID";
            this.txtCustomers_CustomerID.Size = new System.Drawing.Size(39, 17);
            this.txtCustomers_CustomerID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCustomers_CustomerID.Tag = "CustomerID";
            this.txtCustomers_CustomerID.Data = this._controller.Customers.CustomerID;
            
            // gclCompanyName
            
            this.gclCompanyName.AllowSort = true;
            this.gclCompanyName.Controls.Add(this.txtCustomers_CompanyName);
            this.gclCompanyName.Name = "gclCompanyName";
            this.gclCompanyName.Text = "CompanyName";
            this.gclCompanyName.Width = 292;
            
            // txtCustomers_CompanyName
            
            this.txtCustomers_CompanyName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtCustomers_CompanyName.Location = new System.Drawing.Point(2, 2);
            this.txtCustomers_CompanyName.Name = "txtCustomers_CompanyName";
            this.txtCustomers_CompanyName.Size = new System.Drawing.Size(284, 17);
            this.txtCustomers_CompanyName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCustomers_CompanyName.Tag = "CompanyName";
            this.txtCustomers_CompanyName.Data = this._controller.Customers.CompanyName;
            
            // gclContactName
            
            this.gclContactName.Controls.Add(this.txtCustomers_ContactName);
            this.gclContactName.Name = "gclContactName";
            this.gclContactName.Text = "ContactName";
            this.gclContactName.Width = 223;
            
            // txtCustomers_ContactName
            
            this.txtCustomers_ContactName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtCustomers_ContactName.Location = new System.Drawing.Point(2, 2);
            this.txtCustomers_ContactName.Name = "txtCustomers_ContactName";
            this.txtCustomers_ContactName.Size = new System.Drawing.Size(214, 17);
            this.txtCustomers_ContactName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCustomers_ContactName.Tag = "ContactName";
            this.txtCustomers_ContactName.Data = this._controller.Customers.ContactName;
            
            // gclContactTitle
            
            this.gclContactTitle.Controls.Add(this.txtCustomers_ContactTitle);
            this.gclContactTitle.Name = "gclContactTitle";
            this.gclContactTitle.Text = "ContactTitle";
            this.gclContactTitle.Width = 222;
            
            // txtCustomers_ContactTitle
            
            this.txtCustomers_ContactTitle.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtCustomers_ContactTitle.Location = new System.Drawing.Point(2, 2);
            this.txtCustomers_ContactTitle.Name = "txtCustomers_ContactTitle";
            this.txtCustomers_ContactTitle.Size = new System.Drawing.Size(214, 17);
            this.txtCustomers_ContactTitle.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCustomers_ContactTitle.Tag = "ContactTitle";
            this.txtCustomers_ContactTitle.Data = this._controller.Customers.ContactTitle;
            
            // changeFormColorView
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 484);
            this.ColorScheme = this.clrWindow_sDefault;
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "changeFormColorView";
            this.Text = "changeFormColor";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.BindColorScheme += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.ColorSchemeBindingEventArgs>(this.this_BindColorScheme);
            this.grd.ResumeLayout(false);
            this.gclCustomerID.ResumeLayout(false);
            this.gclCompanyName.ResumeLayout(false);
            this.gclContactName.ResumeLayout(false);
            this.gclContactTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
