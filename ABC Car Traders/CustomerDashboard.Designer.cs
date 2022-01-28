
namespace ABC_Car_Traders
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.PnlCustomerFormLoader = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCustomerNav = new System.Windows.Forms.Panel();
            this.btnCustomerLogout = new System.Windows.Forms.Button();
            this.btnCustomerProfile = new System.Windows.Forms.Button();
            this.btnCustomerOrder = new System.Windows.Forms.Button();
            this.btnCustomerSparePartDetails = new System.Windows.Forms.Button();
            this.btnCustomerCarDetails = new System.Windows.Forms.Button();
            this.btnCustomerDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCustomerFormLoader
            // 
            this.PnlCustomerFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCustomerFormLoader.Location = new System.Drawing.Point(186, 70);
            this.PnlCustomerFormLoader.Name = "PnlCustomerFormLoader";
            this.PnlCustomerFormLoader.Size = new System.Drawing.Size(891, 580);
            this.PnlCustomerFormLoader.TabIndex = 7;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(1038, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(27, 30);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(209, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlCustomerNav);
            this.panel1.Controls.Add(this.btnCustomerLogout);
            this.panel1.Controls.Add(this.btnCustomerProfile);
            this.panel1.Controls.Add(this.btnCustomerOrder);
            this.panel1.Controls.Add(this.btnCustomerSparePartDetails);
            this.panel1.Controls.Add(this.btnCustomerCarDetails);
            this.panel1.Controls.Add(this.btnCustomerDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 650);
            this.panel1.TabIndex = 4;
            // 
            // pnlCustomerNav
            // 
            this.pnlCustomerNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlCustomerNav.Location = new System.Drawing.Point(0, 150);
            this.pnlCustomerNav.Name = "pnlCustomerNav";
            this.pnlCustomerNav.Size = new System.Drawing.Size(3, 100);
            this.pnlCustomerNav.TabIndex = 2;
            // 
            // btnCustomerLogout
            // 
            this.btnCustomerLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCustomerLogout.FlatAppearance.BorderSize = 0;
            this.btnCustomerLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerLogout.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerLogout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerLogout.Location = new System.Drawing.Point(0, 608);
            this.btnCustomerLogout.Name = "btnCustomerLogout";
            this.btnCustomerLogout.Size = new System.Drawing.Size(186, 42);
            this.btnCustomerLogout.TabIndex = 1;
            this.btnCustomerLogout.Text = "Logout";
            this.btnCustomerLogout.UseVisualStyleBackColor = false;
            this.btnCustomerLogout.Click += new System.EventHandler(this.btnCustomerLogout_Click);
            this.btnCustomerLogout.Leave += new System.EventHandler(this.btnCustomerLogout_Leave);
            // 
            // btnCustomerProfile
            // 
            this.btnCustomerProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerProfile.FlatAppearance.BorderSize = 0;
            this.btnCustomerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerProfile.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerProfile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerProfile.Location = new System.Drawing.Point(0, 336);
            this.btnCustomerProfile.Name = "btnCustomerProfile";
            this.btnCustomerProfile.Size = new System.Drawing.Size(186, 42);
            this.btnCustomerProfile.TabIndex = 1;
            this.btnCustomerProfile.Text = "Profile";
            this.btnCustomerProfile.UseVisualStyleBackColor = false;
            this.btnCustomerProfile.Click += new System.EventHandler(this.btnCustomerProfile_Click);
            this.btnCustomerProfile.Leave += new System.EventHandler(this.btnCustomerProfile_Leave);
            // 
            // btnCustomerOrder
            // 
            this.btnCustomerOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerOrder.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerOrder.Location = new System.Drawing.Point(0, 288);
            this.btnCustomerOrder.Name = "btnCustomerOrder";
            this.btnCustomerOrder.Size = new System.Drawing.Size(186, 42);
            this.btnCustomerOrder.TabIndex = 1;
            this.btnCustomerOrder.Text = "Order ";
            this.btnCustomerOrder.UseVisualStyleBackColor = false;
            this.btnCustomerOrder.Click += new System.EventHandler(this.btnCustomerOrder_Click);
            this.btnCustomerOrder.Leave += new System.EventHandler(this.btnCustomerOrder_Leave);
            // 
            // btnCustomerSparePartDetails
            // 
            this.btnCustomerSparePartDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerSparePartDetails.FlatAppearance.BorderSize = 0;
            this.btnCustomerSparePartDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSparePartDetails.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerSparePartDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerSparePartDetails.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerSparePartDetails.Location = new System.Drawing.Point(0, 240);
            this.btnCustomerSparePartDetails.Name = "btnCustomerSparePartDetails";
            this.btnCustomerSparePartDetails.Size = new System.Drawing.Size(183, 42);
            this.btnCustomerSparePartDetails.TabIndex = 1;
            this.btnCustomerSparePartDetails.Text = "Spare Part Details";
            this.btnCustomerSparePartDetails.UseVisualStyleBackColor = false;
            this.btnCustomerSparePartDetails.Click += new System.EventHandler(this.btnCustomerSparePartDetails_Click);
            this.btnCustomerSparePartDetails.Leave += new System.EventHandler(this.btnCustomerSparePartDetails_Leave);
            // 
            // btnCustomerCarDetails
            // 
            this.btnCustomerCarDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerCarDetails.FlatAppearance.BorderSize = 0;
            this.btnCustomerCarDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCarDetails.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerCarDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerCarDetails.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerCarDetails.Location = new System.Drawing.Point(0, 192);
            this.btnCustomerCarDetails.Name = "btnCustomerCarDetails";
            this.btnCustomerCarDetails.Size = new System.Drawing.Size(186, 42);
            this.btnCustomerCarDetails.TabIndex = 1;
            this.btnCustomerCarDetails.Text = "Car Details";
            this.btnCustomerCarDetails.UseVisualStyleBackColor = false;
            this.btnCustomerCarDetails.Click += new System.EventHandler(this.btnCustomerCarDetails_Click);
            this.btnCustomerCarDetails.Leave += new System.EventHandler(this.btnCustomerCarDetails_Leave);
            // 
            // btnCustomerDashboard
            // 
            this.btnCustomerDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerDashboard.FlatAppearance.BorderSize = 0;
            this.btnCustomerDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerDashboard.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnCustomerDashboard.Name = "btnCustomerDashboard";
            this.btnCustomerDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnCustomerDashboard.TabIndex = 1;
            this.btnCustomerDashboard.Text = "Dashboard";
            this.btnCustomerDashboard.UseVisualStyleBackColor = false;
            this.btnCustomerDashboard.Click += new System.EventHandler(this.btnCustomerDashboard_Click);
            this.btnCustomerDashboard.Leave += new System.EventHandler(this.btnCustomerDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusername.Location = new System.Drawing.Point(49, 107);
            this.lblusername.Name = "lblusername";
            this.lblusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblusername.Size = new System.Drawing.Size(85, 16);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "User Name";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1077, 650);
            this.Controls.Add(this.PnlCustomerFormLoader);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCustomerFormLoader;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCustomerNav;
        private System.Windows.Forms.Button btnCustomerLogout;
        private System.Windows.Forms.Button btnCustomerProfile;
        private System.Windows.Forms.Button btnCustomerOrder;
        private System.Windows.Forms.Button btnCustomerSparePartDetails;
        private System.Windows.Forms.Button btnCustomerCarDetails;
        private System.Windows.Forms.Button btnCustomerDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}