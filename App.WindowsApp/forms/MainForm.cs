using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Services;
using App.WindowsApp.views;

namespace App.WindowsApp.forms
{
    public partial class MainForm : Form
    {
        InMemoryProductServie _productService = new InMemoryProductServie();
        Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductsView(_productService));
        }
        private void ShowView<T>(Func<T>Factory) where T: UserControl
        {
            var key = typeof(T);

            if(!_views.TryGetValue(key, out var view))
            {
                view = Factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }
            if (!pnlcontent.Controls.Contains(view))
            {
                pnlcontent.Controls.Clear();
                pnlcontent.Controls.Add(view);
            }
            view.BringToFront();
        }
    }
}