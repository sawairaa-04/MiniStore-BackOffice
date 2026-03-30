using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WindowsApp.forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();

            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cmbCategory.Items.Clear();
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbStatus.SelectedIndex = 0;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }

            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cmbCategory.SelectedItem = p.Category;
                cmbStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
