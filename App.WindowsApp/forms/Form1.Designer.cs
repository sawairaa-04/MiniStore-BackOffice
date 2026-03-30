namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btngreet = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(43, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(126, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Enter your name";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblmessage.Location = new System.Drawing.Point(42, 129);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(84, 28);
            this.lblmessage.TabIndex = 1;
            this.lblmessage.Text = "Message";
            // 
            // btngreet
            // 
            this.btngreet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngreet.Location = new System.Drawing.Point(395, 53);
            this.btngreet.Name = "btngreet";
            this.btngreet.Size = new System.Drawing.Size(133, 44);
            this.btngreet.TabIndex = 2;
            this.btngreet.Text = "Greet/Refresh";
            this.btngreet.UseVisualStyleBackColor = false;
            this.btngreet.Click += new System.EventHandler(this.btngreet_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnopen.Location = new System.Drawing.Point(395, 110);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(133, 63);
            this.btnopen.TabIndex = 3;
            this.btnopen.Text = "Open Dashboard";
            this.btnopen.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 26);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 683);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btngreet);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btngreet_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btngreet;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

