namespace App.WindowsApp.views
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
            tblProducts = new TableLayoutPanel();
            pnlToolbar = new Panel();
            tsProducts = new ToolStrip();
            tsAdd = new ToolStripButton();
            tsEdit = new ToolStripButton();
            tsView = new ToolStripButton();
            tsDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilter = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            pnlToolbar.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(pnlToolbar, 0, 0);
            tblProducts.Controls.Add(pnlFilters, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(3, 4, 3, 4);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(18, 20, 18, 20);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(1037, 719);
            tblProducts.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(tsProducts);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlToolbar.Location = new Point(21, 24);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(995, 62);
            pnlToolbar.TabIndex = 2;
            pnlToolbar.Paint += panel1_Paint;
            // 
            // tsProducts
            // 
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.GripStyle = ToolStripGripStyle.Hidden;
            tsProducts.ImageScalingSize = new Size(24, 24);
            tsProducts.Items.AddRange(new ToolStripItem[] { tsAdd, tsEdit, tsView, tsDelete, toolStripSeparator1, tsRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(995, 62);
            tsProducts.TabIndex = 2;
            tsProducts.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            tsAdd.ImageTransparentColor = Color.Magenta;
            tsAdd.Name = "tsAdd";
            tsAdd.Size = new Size(50, 57);
            tsAdd.Text = "Add";
            tsAdd.Click += tsAdd_Click;
            // 
            // tsEdit
            // 
            tsEdit.ImageTransparentColor = Color.Magenta;
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(46, 57);
            tsEdit.Text = "Edit";
            tsEdit.Click += tsEdit_Click;
            // 
            // tsView
            // 
            tsView.ImageTransparentColor = Color.Magenta;
            tsView.Name = "tsView";
            tsView.Size = new Size(53, 57);
            tsView.Text = "View";
            tsView.Click += tsView_Click;
            // 
            // tsDelete
            // 
            tsDelete.ImageTransparentColor = Color.Magenta;
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(66, 57);
            tsDelete.Text = "Delete";
            tsDelete.Click += tsDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsRefresh
            // 
            tsRefresh.ImageTransparentColor = Color.Magenta;
            tsRefresh.Name = "tsRefresh";
            tsRefresh.Size = new Size(74, 57);
            tsRefresh.Text = "Refresh";
            tsRefresh.Click += tsRefresh_Click;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(tblFilter);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(21, 94);
            pnlFilters.Margin = new Padding(3, 4, 3, 4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(13, 12, 13, 12);
            pnlFilters.Size = new Size(995, 97);
            pnlFilters.TabIndex = 3;
            // 
            // tblFilter
            // 
            tblFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilter.BackColor = Color.White;
            tblFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilter.ColumnCount = 3;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.Controls.Add(lblSearch, 0, 0);
            tblFilter.Controls.Add(lblCategory, 1, 0);
            tblFilter.Controls.Add(lblStockStatus, 2, 0);
            tblFilter.Controls.Add(txtSearch, 0, 1);
            tblFilter.Controls.Add(cmbCategory, 1, 1);
            tblFilter.Controls.Add(cmbStockStatus, 2, 1);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.ForeColor = SystemColors.ControlText;
            tblFilter.Location = new Point(13, 12);
            tblFilter.Margin = new Padding(3, 4, 3, 4);
            tblFilter.Name = "tblFilter";
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.Size = new Size(969, 73);
            tblFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(4, 1);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(380, 35);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(391, 1);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(283, 35);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(681, 1);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(284, 35);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(4, 41);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 31);
            txtSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(391, 41);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(283, 33);
            cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(681, 41);
            cmbStockStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(284, 33);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(21, 199);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(13, 15, 13, 15);
            pnlGrid.Size = new Size(995, 496);
            pnlGrid.TabIndex = 4;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(13, 15);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(969, 466);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsView";
            Size = new Size(1037, 719);
            Load += ProductView_Load;
            tblProducts.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

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
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
