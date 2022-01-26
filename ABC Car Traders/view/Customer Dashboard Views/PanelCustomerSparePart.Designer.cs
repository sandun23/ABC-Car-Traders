
namespace ABC_Car_Traders.view.Customer_Dashboard_Views
{
    partial class PanelCustomerSparePart
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
            this.btnCustomerSparePartRefresh = new System.Windows.Forms.Button();
            this.tblCustomerSparePartDetails = new System.Windows.Forms.DataGridView();
            this.txtCustomerSparePartSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerSparePartDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerSparePartRefresh
            // 
            this.btnCustomerSparePartRefresh.Location = new System.Drawing.Point(356, 65);
            this.btnCustomerSparePartRefresh.Name = "btnCustomerSparePartRefresh";
            this.btnCustomerSparePartRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnCustomerSparePartRefresh.TabIndex = 39;
            this.btnCustomerSparePartRefresh.Text = "Refresh";
            this.btnCustomerSparePartRefresh.UseVisualStyleBackColor = true;
            this.btnCustomerSparePartRefresh.Click += new System.EventHandler(this.btnCustomerSparePartRefresh_Click);
            // 
            // tblCustomerSparePartDetails
            // 
            this.tblCustomerSparePartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCustomerSparePartDetails.Location = new System.Drawing.Point(12, 112);
            this.tblCustomerSparePartDetails.Name = "tblCustomerSparePartDetails";
            this.tblCustomerSparePartDetails.RowHeadersWidth = 51;
            this.tblCustomerSparePartDetails.RowTemplate.Height = 29;
            this.tblCustomerSparePartDetails.Size = new System.Drawing.Size(867, 452);
            this.tblCustomerSparePartDetails.TabIndex = 38;
            // 
            // txtCustomerSparePartSearch
            // 
            this.txtCustomerSparePartSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCustomerSparePartSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerSparePartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerSparePartSearch.ForeColor = System.Drawing.Color.White;
            this.txtCustomerSparePartSearch.Location = new System.Drawing.Point(480, 65);
            this.txtCustomerSparePartSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomerSparePartSearch.Name = "txtCustomerSparePartSearch";
            this.txtCustomerSparePartSearch.Size = new System.Drawing.Size(373, 27);
            this.txtCustomerSparePartSearch.TabIndex = 37;
            this.txtCustomerSparePartSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSpareParttKeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "View Spare Part Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(755, 42);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(98, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Spare Parts";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelCustomerSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(891, 580);
            this.Controls.Add(this.btnCustomerSparePartRefresh);
            this.Controls.Add(this.tblCustomerSparePartDetails);
            this.Controls.Add(this.txtCustomerSparePartSearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCustomerSparePart";
            this.Text = "PanelCustomerSparePart";
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerSparePartDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerSparePartRefresh;
        private System.Windows.Forms.DataGridView tblCustomerSparePartDetails;
        private System.Windows.Forms.TextBox txtCustomerSparePartSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}