namespace WindowsFormsApp1.views
{
    partial class ProductsView
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
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.tsProducts = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsView = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStockStatus = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProducts.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.tsProducts.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.tblFilter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProducts
            // 
            this.tblProducts.ColumnCount = 1;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Controls.Add(this.pnlToolbar, 0, 0);
            this.tblProducts.Controls.Add(this.pnlFilters, 0, 1);
            this.tblProducts.Controls.Add(this.pnlGrid, 0, 2);
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducts.Location = new System.Drawing.Point(0, 0);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.Padding = new System.Windows.Forms.Padding(16);
            this.tblProducts.RowCount = 3;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Size = new System.Drawing.Size(933, 575);
            this.tblProducts.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.tsProducts);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolbar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlToolbar.Location = new System.Drawing.Point(19, 19);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(895, 50);
            this.pnlToolbar.TabIndex = 2;
            this.pnlToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tsProducts
            // 
            this.tsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsProducts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProducts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsEdit,
            this.tsView,
            this.tsDelete,
            this.toolStripSeparator1,
            this.tsRefresh});
            this.tsProducts.Location = new System.Drawing.Point(0, 0);
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(895, 50);
            this.tsProducts.TabIndex = 2;
            this.tsProducts.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = global::WindowsFormsApp1.Properties.Resources.icon_add;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(74, 45);
            this.tsAdd.Text = "Add";
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::WindowsFormsApp1.Properties.Resources.icon_edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(70, 45);
            this.tsEdit.Text = "Edit";
            // 
            // tsView
            // 
            this.tsView.Image = global::WindowsFormsApp1.Properties.Resources.icon_view;
            this.tsView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(77, 45);
            this.tsView.Text = "View";
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::WindowsFormsApp1.Properties.Resources.icon_delete;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(90, 45);
            this.tsDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Image = global::WindowsFormsApp1.Properties.Resources.icon_refresh;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(98, 45);
            this.tsRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.tblFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(19, 75);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlFilters.Size = new System.Drawing.Size(895, 78);
            this.pnlFilters.TabIndex = 3;
            // 
            // tblFilter
            // 
            this.tblFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilter.BackColor = System.Drawing.Color.White;
            this.tblFilter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFilter.ColumnCount = 3;
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.Controls.Add(this.lblSearch, 0, 0);
            this.tblFilter.Controls.Add(this.lblCategory, 1, 0);
            this.tblFilter.Controls.Add(this.lblStockStatus, 2, 0);
            this.tblFilter.Controls.Add(this.txtSearch, 0, 1);
            this.tblFilter.Controls.Add(this.cmbCategory, 1, 1);
            this.tblFilter.Controls.Add(this.cmbStockStatus, 2, 1);
            this.tblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblFilter.Location = new System.Drawing.Point(12, 10);
            this.tblFilter.Name = "tblFilter";
            this.tblFilter.RowCount = 2;
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.Size = new System.Drawing.Size(871, 58);
            this.tblFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(4, 1);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(340, 27);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(351, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(254, 27);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.Location = new System.Drawing.Point(612, 1);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(255, 27);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(4, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(351, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(254, 28);
            this.cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.Location = new System.Drawing.Point(612, 32);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(255, 28);
            this.cmbStockStatus.TabIndex = 5;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(19, 159);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(895, 397);
            this.pnlGrid.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(871, 373);
            this.dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 8;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProducts);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(933, 575);
            this.tblProducts.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.tsProducts.ResumeLayout(false);
            this.tsProducts.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.tblFilter.ResumeLayout(false);
            this.tblFilter.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsView;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
