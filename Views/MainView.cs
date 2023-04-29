using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarker_MVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler showCustomersView;
        public event EventHandler showProvidersView;
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { showProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnCustomers.Click += delegate { showCustomersView?.Invoke(this, EventArgs.Empty); };
            BtnClose.Click += delegate { this.Close(); };
                    
        }

     
        

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPayMode_Click(object sender, EventArgs e)
        {

        }

        private void BtnPayMode_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
