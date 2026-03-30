namespace App.WindowsApp.forms
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            txtName = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblId = new Label();
            cmbCategory = new ComboBox();
            nuPrice = new NumericUpDown();
            nuStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtId = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStock, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 4);
            tableLayoutPanel1.Controls.Add(lblId, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(nuPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(nuStock, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(txtId, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 299);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(136, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(661, 31);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Left;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 50);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Left;
            lblCategory.Location = new Point(3, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 50);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Location = new Point(3, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 50);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Left;
            lblStock.Location = new Point(3, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 50);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Left;
            lblStatus.Location = new Point(3, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 50);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Left;
            lblId.Location = new Point(3, 250);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 50);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(136, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(661, 33);
            cmbCategory.TabIndex = 1;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(136, 103);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(661, 31);
            nuPrice.TabIndex = 2;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(136, 153);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(661, 31);
            nuStock.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(136, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(661, 33);
            cmbStatus.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(136, 253);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(661, 31);
            txtId.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 399);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 51);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(685, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(567, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtName;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblId;
        private ComboBox cmbCategory;
        private NumericUpDown nuPrice;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown nuStock;
        private ComboBox cmbStatus;
        private TextBox txtId;
        private Button btnSave;
        private Button btnCancel;
    }
}