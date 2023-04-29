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
    public partial class CustomersView : Form , ICustomersView


    {
        private bool isEdit;
        private bool isSuccesssful;
        private string message;
        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabCustomersDetail);
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
                tabControl1.TabPages.Remove(tabCustomersList);
                tabControl1.TabPages.Add(tabCustomersDetail);
                tabCustomersDetail.Text = "Add New Customers";


            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCustomersList);
                tabControl1.TabPages.Add(tabCustomersDetail);
                tabCustomersDetail.Text = "Edit Customers";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesssful)
                {
                    tabControl1.TabPages.Remove(tabCustomersDetail);
                    tabControl1.TabPages.Add(tabCustomersList);


                }
                MessageBox.Show(Message);

            };


            BtnDelete.Click += delegate
            {

                var result = MessageBox.Show("Are you sure you want to delete the selected Customers", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);


                }

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCustomersDetail);
                tabControl1.TabPages.Add(tabCustomersList);


            };


        }

        public string CustomersId
        {
            get { return TxtCustomersId.Text; }
            set { TxtCustomersId.Text = value; }

        }
        public string CustomersName
        {
            get { return TxtCustomersName.Text; }
            set { TxtCustomersName.Text = value; }

        }
        public string CustomersObservation
        {
            get { return TxtCustomersObservation.Text; }
            set { TxtCustomersObservation.Text = value; }

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


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustomersView_Load(object sender, EventArgs e)
        {

        }

        private void CustomersView_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        public void SetCustomersListBildingSource(BindingSource customerslList)
        {
            DgCustomers.DataSource = customerslList;
        }
        private static CustomersView instance;



        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new CustomersView();
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
