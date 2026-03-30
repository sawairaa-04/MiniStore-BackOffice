namespace App.WindowsApp.views
{
    partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colOrdersId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(903, 576);
            this.tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.pnlSales);
            this.flpKpi.Controls.Add(this.pnlOrders);
            this.flpKpi.Controls.Add(this.pnlRevenue);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpi.Location = new System.Drawing.Point(3, 3);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(897, 114);
            this.flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(98, 37);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(18, 20);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "0";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(21, 37);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(49, 20);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Location = new System.Drawing.Point(209, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 100);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Location = new System.Drawing.Point(112, 37);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(18, 20);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "0";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Location = new System.Drawing.Point(27, 37);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(57, 20);
            this.lblOrderT.TabIndex = 0;
            this.lblOrderT.Text = "Orders";
            this.lblOrderT.Click += new System.EventHandler(this.lblOrderT_Click);
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(415, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(200, 100);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(115, 37);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(18, 20);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "0";
            this.lblRevenueV.Click += new System.EventHandler(this.lblRevenueV_Click);
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(31, 37);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(73, 20);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.listView1);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(897, 222);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(12, 18);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(83, 20);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(894, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.listView2);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 351);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(897, 222);
            this.pnlRecentOrders.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrdersId,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 40);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(891, 166);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colOrdersId
            // 
            this.colOrdersId.Text = "Order Id";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Location = new System.Drawing.Point(12, 17);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(113, 20);
            this.lblRecentOrders.TabIndex = 0;
            this.lblRecentOrders.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(903, 576);
            this.tblDashboard.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colOrdersId;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblRecentOrders;
    }
}
