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
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccesssful;
        private string message;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);
            this.Show();
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
        }

        public string PayModeId {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }

        }
        public string PayModeName {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }

        }
        public string PayModeObservation {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }

        }
        public string SearchValue {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesssful {
            get { return isSuccesssful; }
            set { isSuccesssful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }



        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPagePayModeDetail_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModelList)
        {
            DgPayMode.DataSource = payModelList;
        }
        private static PayModeView instance;

        public static PayModeView GetInstance(Form parentContainer) {
            if (instance == null || instance.IsDisposed) {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;
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

    


        public void show()
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgPayMode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPagePayModeList_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void TxtPayModeId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
