namespace App.WindowsApp.forms
{
    partial class MainForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.flpRight);
            this.pnlHeader.Controls.Add(this.flpLeft);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1221, 34);
            this.pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            this.flpRight.Controls.Add(this.pictureBox1);
            this.flpRight.Controls.Add(this.lblUser);
            this.flpRight.Location = new System.Drawing.Point(1099, 3);
            this.flpRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(122, 121);
            this.flpRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Location = new System.Drawing.Point(41, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 38);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Admin";
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.pbLogo);
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Location = new System.Drawing.Point(0, 0);
            this.flpLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(157, 34);
            this.flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            //this.pbLogo.Image = global::WindowsFormsApp1.Properties.Resources.icon_ministore;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(32, 32);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.flpNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 34);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(222, 786);
            this.pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.btnDashboard);
            this.flpNav.Controls.Add(this.btnProducts);
            this.flpNav.Controls.Add(this.btnOrders);
            this.flpNav.Controls.Add(this.btnReports);
            this.flpNav.Controls.Add(this.btnSync);
            this.flpNav.Controls.Add(this.button1);
            this.flpNav.Controls.Add(this.btnSettings);
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpNav.Location = new System.Drawing.Point(0, 0);
            this.flpNav.Margin = new System.Windows.Forms.Padding(4);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(222, 786);
            this.flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnDashboard.Image = global::App.WindowsApp.Properties.Resources.icon_dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 49);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 40);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Location = new System.Drawing.Point(3, 95);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(200, 40);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnReports.Image = global::WindowsFormsApp1.Properties.Resources.icon_report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 141);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(200, 40);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnSync.Image = global::WindowsFormsApp1.Properties.Resources.icon_sync;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 187);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSync.Size = new System.Drawing.Size(200, 40);
            this.btnSync.TabIndex = 4;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icon_logs;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 233);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logs";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnSettings.Image = global::WindowsFormsApp1.Properties.Resources.icon_settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 279);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(200, 40);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Controls.Add(this.lblStatus);
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Location = new System.Drawing.Point(0, 820);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1221, 36);
            this.statusStrip.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready";
            // 
            // pnlcontent
            // 
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(222, 34);
            this.pnlcontent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(999, 786);
            this.pnlcontent.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 856);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.flpRight.ResumeLayout(false);
            this.flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel statusStrip;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlcontent;
    }
}