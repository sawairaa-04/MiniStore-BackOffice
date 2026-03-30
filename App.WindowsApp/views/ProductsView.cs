using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Core.Utilities;
using App.WindowsApp.forms;
using App.Core.Models;

namespace App.WindowsApp.views
{
    public partial class ProductsView : UserControl
    {
        IProductsService _service;
        BindingSource _dgvbindingSource = new BindingSource();


        public ProductsView(IProductsService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--All--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodform = new ProductForm(ProductFormModeEnum.Add, selectedProduct);
                prodform.ShowDialog();
            }


        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodform = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodform.ShowDialog();
            }
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodform = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodform.ShowDialog();
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
