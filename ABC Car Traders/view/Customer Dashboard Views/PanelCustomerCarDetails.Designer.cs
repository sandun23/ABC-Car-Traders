
namespace ABC_Car_Traders.view.Customer_Dashboard_Views
{
    partial class PanelCustomerCarDetails
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
            this.tblCustomerCarDetails = new System.Windows.Forms.DataGridView();
            this.txtCustomerCarSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCustomerCarRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerCarDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCustomerCarDetails
            // 
            this.tblCustomerCarDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tblCustomerCarDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblCustomerCarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCustomerCarDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tblCustomerCarDetails.Location = new System.Drawing.Point(13, 116);
            this.tblCustomerCarDetails.Name = "tblCustomerCarDetails";
            this.tblCustomerCarDetails.RowHeadersWidth = 51;
            this.tblCustomerCarDetails.RowTemplate.Height = 29;
            this.tblCustomerCarDetails.Size = new System.Drawing.Size(867, 452);
            this.tblCustomerCarDetails.TabIndex = 33;
            // 
            // txtCustomerCarSearch
            // 
            this.txtCustomerCarSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCustomerCarSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerCarSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerCarSearch.ForeColor = System.Drawing.Color.White;
            this.txtCustomerCarSearch.Location = new System.Drawing.Point(481, 69);
            this.txtCustomerCarSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomerCarSearch.Name = "txtCustomerCarSearch";
            this.txtCustomerCarSearch.Size = new System.Drawing.Size(373, 27);
            this.txtCustomerCarSearch.TabIndex = 32;
            this.txtCustomerCarSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCartKeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(13, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "View Car Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(818, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(41, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "Car";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCustomerCarRefresh
            // 
            this.btnCustomerCarRefresh.Location = new System.Drawing.Point(357, 69);
            this.btnCustomerCarRefresh.Name = "btnCustomerCarRefresh";
            this.btnCustomerCarRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnCustomerCarRefresh.TabIndex = 34;
            this.btnCustomerCarRefresh.Text = "Refresh";
            this.btnCustomerCarRefresh.UseVisualStyleBackColor = true;
            this.btnCustomerCarRefresh.Click += new System.EventHandler(this.btnCustomerCarRefresh_Click);
            // 
            // PanelCustomerCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(891, 580);
            this.Controls.Add(this.btnCustomerCarRefresh);
            this.Controls.Add(this.tblCustomerCarDetails);
            this.Controls.Add(this.txtCustomerCarSearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCustomerCarDetails";
            this.Text = "CustomerCarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerCarDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCustomerCarDetails;
        private System.Windows.Forms.TextBox txtCustomerCarSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCustomerCarRefresh;
    }
}