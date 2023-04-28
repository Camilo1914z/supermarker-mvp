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
    public partial class ProductView : Form , IProductView
    {
        private bool isEdit;
        private bool isSuccesssful;
        private string message;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabProductDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Add New Product";


            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Edit Product";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesssful)
                {
                    tabControl1.TabPages.Remove(tabProductDetail);
                    tabControl1.TabPages.Add(tabProductList);


                }
                MessageBox.Show(Message);

            };


            BtnDelete.Click += delegate
            {

                var result = MessageBox.Show("Are you sure you want to delete the selected Product", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);


                }

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductDetail);
                tabControl1.TabPages.Add(tabProductList);


            };


        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }

        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }

        }
        public string ProductDescription
        {
            get { return TxtProductDescription.Text; }
            set { TxtProductDescription.Text = value; }

        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesssful
        {
            get { return isSuccesssful; }
            set { isSuccesssful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void tabProductList_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void SetProductListBildingSource(BindingSource productlList)
        {
            DgProduct.DataSource = productlList;
        }
        private static ProductView instance;



        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {

                    instance.WindowState = FormWindowState.Normal;

                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
