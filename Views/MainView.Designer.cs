namespace Supermarker_MVP.Views
{
    partial class MainView
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
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnProviders = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnPayMode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnProviders);
            this.panel1.Controls.Add(this.BtnProduct);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnPayMode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 530);
            this.panel1.TabIndex = 0;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackgroundImage = global::Supermarker_MVP.Properties.Resources.providers;
            this.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 291);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(214, 72);
            this.BtnCustomers.TabIndex = 6;
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnProviders
            // 
            this.BtnProviders.BackgroundImage = global::Supermarker_MVP.Properties.Resources.providers;
            this.BtnProviders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProviders.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProviders.Location = new System.Drawing.Point(0, 219);
            this.BtnProviders.Name = "BtnProviders";
            this.BtnProviders.Size = new System.Drawing.Size(214, 72);
            this.BtnProviders.TabIndex = 5;
            this.BtnProviders.UseVisualStyleBackColor = true;
            this.BtnProviders.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.BackgroundImage = global::Supermarker_MVP.Properties.Resources.products;
            this.BtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduct.Location = new System.Drawing.Point(0, 147);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(214, 72);
            this.BtnProduct.TabIndex = 4;
            this.BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClose.BackgroundImage = global::Supermarker_MVP.Properties.Resources.cerrar;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Location = new System.Drawing.Point(0, 456);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(214, 74);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnPayMode
            // 
            this.BtnPayMode.BackgroundImage = global::Supermarker_MVP.Properties.Resources.buy;
            this.BtnPayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPayMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPayMode.Location = new System.Drawing.Point(0, 75);
            this.BtnPayMode.Name = "BtnPayMode";
            this.BtnPayMode.Size = new System.Drawing.Size(214, 72);
            this.BtnPayMode.TabIndex = 2;
            this.BtnPayMode.UseVisualStyleBackColor = true;
            this.BtnPayMode.Click += new System.EventHandler(this.BtnPayMode_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Supermarker_MVP.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Supermarket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnClose;
        private Button BtnProduct;
        private Button BtnProviders;
        private Button BtnCustomers;
    }
}