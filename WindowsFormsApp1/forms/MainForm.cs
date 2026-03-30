using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views;

namespace WindowsFormsApp1.forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlcontent.Controls.Clear();
            this.pnlcontent.Controls.Add(new DashboardView());

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.pnlcontent.Controls.Clear();
            this.pnlcontent.Controls.Add(new ProductsView());
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