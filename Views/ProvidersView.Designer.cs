namespace Supermarker_MVP.Views
{
    partial class ProvidersView
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
            this.tabProvidersList = new System.Windows.Forms.TabPage();
            this.tabProvidersDetail = new System.Windows.Forms.TabPage();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgProviders = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProvidersObservation = new System.Windows.Forms.TextBox();
            this.TxtProductsName = new System.Windows.Forms.TextBox();
            this.TxtProvidersId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProvidersList.SuspendLayout();
            this.tabProvidersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 454);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Providers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_MVP.Properties.Resources.providers;
            this.pictureBox1.Location = new System.Drawing.Point(32, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProvidersList);
            this.tabControl1.Controls.Add(this.tabProvidersDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProvidersList
            // 
            this.tabProvidersList.Controls.Add(this.BtnSearch);
            this.tabProvidersList.Controls.Add(this.BtnClose);
            this.tabProvidersList.Controls.Add(this.BtnDelete);
            this.tabProvidersList.Controls.Add(this.BtnEdit);
            this.tabProvidersList.Controls.Add(this.BtnNew);
            this.tabProvidersList.Controls.Add(this.DgProviders);
            this.tabProvidersList.Controls.Add(this.TxtSearch);
            this.tabProvidersList.Controls.Add(this.label2);
            this.tabProvidersList.Location = new System.Drawing.Point(4, 34);
            this.tabProvidersList.Name = "tabProvidersList";
            this.tabProvidersList.Padding = new System.Windows.Forms.Padding(3);
            this.tabProvidersList.Size = new System.Drawing.Size(1048, 416);
            this.tabProvidersList.TabIndex = 0;
            this.tabProvidersList.Text = "Providers List";
            this.tabProvidersList.UseVisualStyleBackColor = true;
            // 
            // tabProvidersDetail
            // 
            this.tabProvidersDetail.Controls.Add(this.BtnCancel);
            this.tabProvidersDetail.Controls.Add(this.BtnSave);
            this.tabProvidersDetail.Controls.Add(this.TxtProvidersObservation);
            this.tabProvidersDetail.Controls.Add(this.TxtProductsName);
            this.tabProvidersDetail.Controls.Add(this.TxtProvidersId);
            this.tabProvidersDetail.Controls.Add(this.label5);
            this.tabProvidersDetail.Controls.Add(this.label4);
            this.tabProvidersDetail.Controls.Add(this.label3);
            this.tabProvidersDetail.Location = new System.Drawing.Point(4, 34);
            this.tabProvidersDetail.Name = "tabProvidersDetail";
            this.tabProvidersDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabProvidersDetail.Size = new System.Drawing.Size(1048, 416);
            this.tabProvidersDetail.TabIndex = 1;
            this.tabProvidersDetail.Text = "Providers Detail";
            this.tabProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Image = global::Supermarker_MVP.Properties.Resources.search_small;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(579, 39);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(114, 45);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(772, 317);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(168, 60);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(772, 234);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(168, 60);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(772, 131);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(168, 60);
            this.BtnEdit.TabIndex = 19;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(772, 39);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(168, 60);
            this.BtnNew.TabIndex = 18;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            this.DgProviders.AllowUserToAddRows = false;
            this.DgProviders.AllowUserToDeleteRows = false;
            this.DgProviders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProviders.Location = new System.Drawing.Point(108, 106);
            this.DgProviders.Name = "DgProviders";
            this.DgProviders.ReadOnly = true;
            this.DgProviders.RowHeadersWidth = 62;
            this.DgProviders.RowTemplate.Height = 33;
            this.DgProviders.Size = new System.Drawing.Size(584, 272);
            this.DgProviders.TabIndex = 17;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(229, 44);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(344, 31);
            this.TxtSearch.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(781, 309);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 53);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(591, 309);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 53);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersObservation
            // 
            this.TxtProvidersObservation.Location = new System.Drawing.Point(123, 260);
            this.TxtProvidersObservation.Multiline = true;
            this.TxtProvidersObservation.Name = "TxtProvidersObservation";
            this.TxtProvidersObservation.PlaceholderText = "Products Description";
            this.TxtProvidersObservation.Size = new System.Drawing.Size(292, 77);
            this.TxtProvidersObservation.TabIndex = 22;
            // 
            // TxtProductsName
            // 
            this.TxtProductsName.Location = new System.Drawing.Point(123, 162);
            this.TxtProductsName.Name = "TxtProductsName";
            this.TxtProductsName.PlaceholderText = "Product Name";
            this.TxtProductsName.Size = new System.Drawing.Size(292, 31);
            this.TxtProductsName.TabIndex = 21;
            // 
            // TxtProvidersId
            // 
            this.TxtProvidersId.Location = new System.Drawing.Point(123, 95);
            this.TxtProvidersId.Name = "TxtProvidersId";
            this.TxtProvidersId.ReadOnly = true;
            this.TxtProvidersId.Size = new System.Drawing.Size(292, 31);
            this.TxtProvidersId.TabIndex = 20;
            this.TxtProvidersId.Text = "0";
            this.TxtProvidersId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Providers Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Providers Id";
            // 
            // ProvidersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProvidersView";
            this.Text = "Providers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProvidersList.ResumeLayout(false);
            this.tabProvidersList.PerformLayout();
            this.tabProvidersDetail.ResumeLayout(false);
            this.tabProvidersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProviders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabProvidersList;
        private TabPage tabProvidersDetail;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProviders;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersObservation;
        private TextBox TxtProductsName;
        private TextBox TxtProvidersId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}