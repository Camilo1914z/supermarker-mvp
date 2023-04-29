namespace Supermarker_MVP.Views
{
    partial class CustomersView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomersList = new System.Windows.Forms.TabPage();
            this.tabCustomersDetail = new System.Windows.Forms.TabPage();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgCustomers = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtCustomersObservation = new System.Windows.Forms.TextBox();
            this.TxtCustomersName = new System.Windows.Forms.TextBox();
            this.TxtCustomersId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCustomersList.SuspendLayout();
            this.tabCustomersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 395);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_MVP.Properties.Resources.products;
            this.pictureBox1.Location = new System.Drawing.Point(36, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCustomersList);
            this.tabControl1.Controls.Add(this.tabCustomersDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCustomersList
            // 
            this.tabCustomersList.Controls.Add(this.BtnSearch);
            this.tabCustomersList.Controls.Add(this.BtnClose);
            this.tabCustomersList.Controls.Add(this.BtnDelete);
            this.tabCustomersList.Controls.Add(this.BtnEdit);
            this.tabCustomersList.Controls.Add(this.BtnNew);
            this.tabCustomersList.Controls.Add(this.DgCustomers);
            this.tabCustomersList.Controls.Add(this.TxtSearch);
            this.tabCustomersList.Controls.Add(this.label2);
            this.tabCustomersList.Location = new System.Drawing.Point(4, 34);
            this.tabCustomersList.Name = "tabCustomersList";
            this.tabCustomersList.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomersList.Size = new System.Drawing.Size(902, 357);
            this.tabCustomersList.TabIndex = 0;
            this.tabCustomersList.Text = "Customers List";
            this.tabCustomersList.UseVisualStyleBackColor = true;
            // 
            // tabCustomersDetail
            // 
            this.tabCustomersDetail.Controls.Add(this.BtnCancel);
            this.tabCustomersDetail.Controls.Add(this.BtnSave);
            this.tabCustomersDetail.Controls.Add(this.TxtCustomersObservation);
            this.tabCustomersDetail.Controls.Add(this.TxtCustomersName);
            this.tabCustomersDetail.Controls.Add(this.TxtCustomersId);
            this.tabCustomersDetail.Controls.Add(this.label5);
            this.tabCustomersDetail.Controls.Add(this.label4);
            this.tabCustomersDetail.Controls.Add(this.label3);
            this.tabCustomersDetail.Location = new System.Drawing.Point(4, 34);
            this.tabCustomersDetail.Name = "tabCustomersDetail";
            this.tabCustomersDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomersDetail.Size = new System.Drawing.Size(902, 357);
            this.tabCustomersDetail.TabIndex = 1;
            this.tabCustomersDetail.Text = "Customers Detail";
            this.tabCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Image = global::Supermarker_MVP.Properties.Resources.search_small;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(529, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(114, 45);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(722, 292);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(168, 60);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(722, 209);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(168, 60);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(722, 106);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(168, 60);
            this.BtnEdit.TabIndex = 19;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(722, 14);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(168, 60);
            this.BtnNew.TabIndex = 18;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // DgCustomers
            // 
            this.DgCustomers.AllowUserToAddRows = false;
            this.DgCustomers.AllowUserToDeleteRows = false;
            this.DgCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomers.Location = new System.Drawing.Point(12, 77);
            this.DgCustomers.Name = "DgCustomers";
            this.DgCustomers.ReadOnly = true;
            this.DgCustomers.RowHeadersWidth = 62;
            this.DgCustomers.RowTemplate.Height = 33;
            this.DgCustomers.Size = new System.Drawing.Size(631, 272);
            this.DgCustomers.TabIndex = 17;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(132, 11);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(391, 31);
            this.TxtSearch.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(708, 279);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 53);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(518, 279);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 53);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersObservation
            // 
            this.TxtCustomersObservation.Location = new System.Drawing.Point(50, 230);
            this.TxtCustomersObservation.Multiline = true;
            this.TxtCustomersObservation.Name = "TxtCustomersObservation";
            this.TxtCustomersObservation.PlaceholderText = "Products Description";
            this.TxtCustomersObservation.Size = new System.Drawing.Size(292, 77);
            this.TxtCustomersObservation.TabIndex = 22;
            // 
            // TxtCustomersName
            // 
            this.TxtCustomersName.Location = new System.Drawing.Point(50, 132);
            this.TxtCustomersName.Name = "TxtCustomersName";
            this.TxtCustomersName.PlaceholderText = "Product Name";
            this.TxtCustomersName.Size = new System.Drawing.Size(292, 31);
            this.TxtCustomersName.TabIndex = 21;
            // 
            // TxtCustomersId
            // 
            this.TxtCustomersId.Location = new System.Drawing.Point(50, 65);
            this.TxtCustomersId.Name = "TxtCustomersId";
            this.TxtCustomersId.ReadOnly = true;
            this.TxtCustomersId.Size = new System.Drawing.Size(292, 31);
            this.TxtCustomersId.TabIndex = 20;
            this.TxtCustomersId.Text = "0";
            this.TxtCustomersId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pay Mode Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Id";
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersView";
            this.Text = "CustomersView";
            this.Load += new System.EventHandler(this.CustomersView_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCustomersList.ResumeLayout(false);
            this.tabCustomersList.PerformLayout();
            this.tabCustomersDetail.ResumeLayout(false);
            this.tabCustomersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabCustomersList;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabCustomersDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomersObservation;
        private TextBox TxtCustomersName;
        private TextBox TxtCustomersId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}