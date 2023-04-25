namespace Supermarker_MVP.Views
{
    partial class ProductView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductList = new System.Windows.Forms.TabPage();
            this.tabProductDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.TxtPayModeName = new System.Windows.Forms.TextBox();
            this.TxtPayModeId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProductList.SuspendLayout();
            this.tabProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 407);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_MVP.Properties.Resources.products;
            this.pictureBox1.Location = new System.Drawing.Point(39, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductList);
            this.tabControl1.Controls.Add(this.tabProductDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.BtnClose);
            this.tabProductList.Controls.Add(this.BtnDelete);
            this.tabProductList.Controls.Add(this.BtnEdit);
            this.tabProductList.Controls.Add(this.BtnNew);
            this.tabProductList.Controls.Add(this.DgProduct);
            this.tabProductList.Controls.Add(this.TxtSearch);
            this.tabProductList.Controls.Add(this.label2);
            this.tabProductList.Location = new System.Drawing.Point(4, 34);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductList.Size = new System.Drawing.Size(941, 369);
            this.tabProductList.TabIndex = 0;
            this.tabProductList.Text = "Product List";
            this.tabProductList.UseVisualStyleBackColor = true;
            this.tabProductList.Click += new System.EventHandler(this.tabProductList_Click);
            // 
            // tabProductDetail
            // 
            this.tabProductDetail.Controls.Add(this.BtnCancel);
            this.tabProductDetail.Controls.Add(this.BtnSave);
            this.tabProductDetail.Controls.Add(this.TxtPayModeObservation);
            this.tabProductDetail.Controls.Add(this.TxtPayModeName);
            this.tabProductDetail.Controls.Add(this.TxtPayModeId);
            this.tabProductDetail.Controls.Add(this.label5);
            this.tabProductDetail.Controls.Add(this.label4);
            this.tabProductDetail.Controls.Add(this.label3);
            this.tabProductDetail.Location = new System.Drawing.Point(4, 34);
            this.tabProductDetail.Name = "tabProductDetail";
            this.tabProductDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductDetail.Size = new System.Drawing.Size(941, 369);
            this.tabProductDetail.TabIndex = 1;
            this.tabProductDetail.Text = "Product Detail";
            this.tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(156, 27);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(344, 31);
            this.TxtSearch.TabIndex = 2;
            // 
            // DgProduct
            // 
            this.DgProduct.AllowUserToAddRows = false;
            this.DgProduct.AllowUserToDeleteRows = false;
            this.DgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProduct.Location = new System.Drawing.Point(35, 89);
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 33;
            this.DgProduct.Size = new System.Drawing.Size(584, 272);
            this.DgProduct.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(699, 300);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(168, 60);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(699, 217);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(168, 60);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(699, 114);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(168, 60);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(699, 22);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(168, 60);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(744, 289);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 53);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(554, 289);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(144, 53);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.Location = new System.Drawing.Point(86, 240);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.PlaceholderText = "Pau Mode Observation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(292, 77);
            this.TxtPayModeObservation.TabIndex = 14;
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.Location = new System.Drawing.Point(86, 142);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.PlaceholderText = "Pay Mode Name";
            this.TxtPayModeName.Size = new System.Drawing.Size(292, 31);
            this.TxtPayModeName.TabIndex = 13;
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.Location = new System.Drawing.Point(86, 75);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.ReadOnly = true;
            this.TxtPayModeId.Size = new System.Drawing.Size(292, 31);
            this.TxtPayModeId.TabIndex = 12;
            this.TxtPayModeId.Text = "0";
            this.TxtPayModeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pay Mode Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pay Mode Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductView";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProductList.ResumeLayout(false);
            this.tabProductList.PerformLayout();
            this.tabProductDetail.ResumeLayout(false);
            this.tabProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private TabPage tabProductDetail;
        private Label label2;
        private TextBox TxtSearch;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}