﻿using System;
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
    public partial class ProvidersView : Form, IProvidersView
    {

        private bool isEdit;
        private bool isSuccesssful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabProvidersDetail);
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
                tabControl1.TabPages.Remove(tabProvidersList);
                tabControl1.TabPages.Add(tabProvidersDetail);
                tabProvidersDetail.Text = "Add New Providers";


            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProvidersList);
                tabControl1.TabPages.Add(tabProvidersDetail);
                tabProvidersDetail.Text = "Edit Providers";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesssful)
                {
                    tabControl1.TabPages.Remove(tabProvidersDetail);
                    tabControl1.TabPages.Add(tabProvidersList);


                }
                MessageBox.Show(Message);

            };


            BtnDelete.Click += delegate
            {

                var result = MessageBox.Show("Are you sure you want to delete the selected Providers", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);


                }

            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProvidersDetail);
                tabControl1.TabPages.Add(tabProvidersList);


            };


        }




        public string ProvidersId
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; }

        }
        public string ProvidersName
        {
            get { return TxtProvidersName.Text; }
            set { TxtProvidersName.Text = value; }

        }
        public string ProvidersObservation
        {
            get { return TxtProvidersObservation.Text; }
            set { TxtProvidersObservation.Text = value; }

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

        public void SetProvidersListBildingSource(BindingSource providerslList)
        {
            DgProviders.DataSource = providerslList;
        }
        private static ProvidersView instance;



        public static ProvidersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new ProvidersView();
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProvidersView_Load(object sender, EventArgs e)
        {

        }
    }
}
