
namespace ABC_Car_Traders.view
{
    partial class PanelCarPartManage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCarPartSave = new System.Windows.Forms.Button();
            this.txtSparePartName = new System.Windows.Forms.TextBox();
            this.txtSparePartPrice = new System.Windows.Forms.TextBox();
            this.txtSparePartQty = new System.Windows.Forms.TextBox();
            this.txtSparePartDesc = new System.Windows.Forms.TextBox();
            this.txtSparePartModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSparePartBrandName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblSparePart = new System.Windows.Forms.DataGridView();
            this.txtSearchSparePart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdateSparePartDetails = new System.Windows.Forms.Button();
            this.txtFillPrice = new System.Windows.Forms.TextBox();
            this.txtFillQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblFillPartName = new System.Windows.Forms.Label();
            this.lblFillBrand = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnSparePartSearch = new System.Windows.Forms.Button();
            this.cmbPartBrand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSparePartName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSparePart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.btnCarPartSave);
            this.tabPage1.Controls.Add(this.txtSparePartName);
            this.tabPage1.Controls.Add(this.txtSparePartPrice);
            this.tabPage1.Controls.Add(this.txtSparePartQty);
            this.tabPage1.Controls.Add(this.txtSparePartDesc);
            this.tabPage1.Controls.Add(this.txtSparePartModel);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtSparePartBrandName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Spare Part";
            // 
            // btnCarPartSave
            // 
            this.btnCarPartSave.BackColor = System.Drawing.Color.Lime;
            this.btnCarPartSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartSave.Location = new System.Drawing.Point(662, 482);
            this.btnCarPartSave.Name = "btnCarPartSave";
            this.btnCarPartSave.Size = new System.Drawing.Size(156, 46);
            this.btnCarPartSave.TabIndex = 54;
            this.btnCarPartSave.Text = "Save";
            this.btnCarPartSave.UseVisualStyleBackColor = false;
            this.btnCarPartSave.Click += new System.EventHandler(this.btnCarPartSave_Click);
            // 
            // txtSparePartName
            // 
            this.txtSparePartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartName.ForeColor = System.Drawing.Color.White;
            this.txtSparePartName.Location = new System.Drawing.Point(81, 177);
            this.txtSparePartName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartName.Name = "txtSparePartName";
            this.txtSparePartName.Size = new System.Drawing.Size(729, 27);
            this.txtSparePartName.TabIndex = 47;
            // 
            // txtSparePartPrice
            // 
            this.txtSparePartPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartPrice.ForeColor = System.Drawing.Color.White;
            this.txtSparePartPrice.Location = new System.Drawing.Point(491, 392);
            this.txtSparePartPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartPrice.Name = "txtSparePartPrice";
            this.txtSparePartPrice.Size = new System.Drawing.Size(326, 27);
            this.txtSparePartPrice.TabIndex = 46;
            // 
            // txtSparePartQty
            // 
            this.txtSparePartQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartQty.ForeColor = System.Drawing.Color.White;
            this.txtSparePartQty.Location = new System.Drawing.Point(84, 392);
            this.txtSparePartQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartQty.Name = "txtSparePartQty";
            this.txtSparePartQty.Size = new System.Drawing.Size(326, 27);
            this.txtSparePartQty.TabIndex = 45;
            // 
            // txtSparePartDesc
            // 
            this.txtSparePartDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartDesc.ForeColor = System.Drawing.Color.White;
            this.txtSparePartDesc.Location = new System.Drawing.Point(86, 255);
            this.txtSparePartDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartDesc.Multiline = true;
            this.txtSparePartDesc.Name = "txtSparePartDesc";
            this.txtSparePartDesc.Size = new System.Drawing.Size(731, 74);
            this.txtSparePartDesc.TabIndex = 44;
            // 
            // txtSparePartModel
            // 
            this.txtSparePartModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartModel.ForeColor = System.Drawing.Color.White;
            this.txtSparePartModel.Location = new System.Drawing.Point(486, 100);
            this.txtSparePartModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartModel.Name = "txtSparePartModel";
            this.txtSparePartModel.Size = new System.Drawing.Size(324, 27);
            this.txtSparePartModel.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(493, 367);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(86, 367);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "QTY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(84, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Description";
            // 
            // txtSparePartBrandName
            // 
            this.txtSparePartBrandName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSparePartBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSparePartBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSparePartBrandName.ForeColor = System.Drawing.Color.White;
            this.txtSparePartBrandName.Location = new System.Drawing.Point(86, 100);
            this.txtSparePartBrandName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSparePartBrandName.Name = "txtSparePartBrandName";
            this.txtSparePartBrandName.Size = new System.Drawing.Size(324, 27);
            this.txtSparePartBrandName.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(86, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(493, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(84, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Spare Part Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Add Spare Part ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.tblSparePart);
            this.tabPage2.Controls.Add(this.txtSearchSparePart);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spare Part Details";
            // 
            // tblSparePart
            // 
            this.tblSparePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSparePart.Location = new System.Drawing.Point(3, 91);
            this.tblSparePart.Name = "tblSparePart";
            this.tblSparePart.RowHeadersWidth = 51;
            this.tblSparePart.RowTemplate.Height = 29;
            this.tblSparePart.Size = new System.Drawing.Size(987, 450);
            this.tblSparePart.TabIndex = 53;
            // 
            // txtSearchSparePart
            // 
            this.txtSearchSparePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSearchSparePart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSparePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchSparePart.ForeColor = System.Drawing.Color.White;
            this.txtSearchSparePart.Location = new System.Drawing.Point(550, 43);
            this.txtSearchSparePart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchSparePart.Name = "txtSearchSparePart";
            this.txtSearchSparePart.Size = new System.Drawing.Size(324, 27);
            this.txtSearchSparePart.TabIndex = 52;
            this.txtSearchSparePart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchSpareParttKeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "View Spare Part Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(777, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Spare Part";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.btnUpdateSparePartDetails);
            this.tabPage3.Controls.Add(this.txtFillPrice);
            this.tabPage3.Controls.Add(this.txtFillQty);
            this.tabPage3.Controls.Add(this.lblQty);
            this.tabPage3.Controls.Add(this.lblFillPartName);
            this.tabPage3.Controls.Add(this.lblFillBrand);
            this.tabPage3.Controls.Add(this.lblPrice);
            this.tabPage3.Controls.Add(this.lblEdition);
            this.tabPage3.Controls.Add(this.lblBrand);
            this.tabPage3.Controls.Add(this.btnSparePartSearch);
            this.tabPage3.Controls.Add(this.cmbPartBrand);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbSparePartName);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Spare Part Details";
            // 
            // btnUpdateSparePartDetails
            // 
            this.btnUpdateSparePartDetails.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateSparePartDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSparePartDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSparePartDetails.Location = new System.Drawing.Point(592, 474);
            this.btnUpdateSparePartDetails.Name = "btnUpdateSparePartDetails";
            this.btnUpdateSparePartDetails.Size = new System.Drawing.Size(248, 40);
            this.btnUpdateSparePartDetails.TabIndex = 105;
            this.btnUpdateSparePartDetails.Text = "Update Spare Part Details";
            this.btnUpdateSparePartDetails.UseVisualStyleBackColor = false;
            this.btnUpdateSparePartDetails.Click += new System.EventHandler(this.btnUpdateSparePartDetails_Click);
            // 
            // txtFillPrice
            // 
            this.txtFillPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFillPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFillPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFillPrice.ForeColor = System.Drawing.Color.White;
            this.txtFillPrice.Location = new System.Drawing.Point(54, 337);
            this.txtFillPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFillPrice.Name = "txtFillPrice";
            this.txtFillPrice.Size = new System.Drawing.Size(125, 27);
            this.txtFillPrice.TabIndex = 103;
            // 
            // txtFillQty
            // 
            this.txtFillQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtFillQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFillQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFillQty.ForeColor = System.Drawing.Color.White;
            this.txtFillQty.Location = new System.Drawing.Point(347, 336);
            this.txtFillQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFillQty.Name = "txtFillQty";
            this.txtFillQty.Size = new System.Drawing.Size(125, 27);
            this.txtFillQty.TabIndex = 104;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQty.Location = new System.Drawing.Point(347, 313);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(44, 21);
            this.lblQty.TabIndex = 95;
            this.lblQty.Text = "QTY";
            // 
            // lblFillPartName
            // 
            this.lblFillPartName.AutoSize = true;
            this.lblFillPartName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillPartName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFillPartName.Location = new System.Drawing.Point(347, 251);
            this.lblFillPartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFillPartName.Name = "lblFillPartName";
            this.lblFillPartName.Size = new System.Drawing.Size(46, 21);
            this.lblFillPartName.TabIndex = 97;
            this.lblFillPartName.Text = "0000";
            // 
            // lblFillBrand
            // 
            this.lblFillBrand.AutoSize = true;
            this.lblFillBrand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFillBrand.Location = new System.Drawing.Point(54, 237);
            this.lblFillBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFillBrand.Name = "lblFillBrand";
            this.lblFillBrand.Size = new System.Drawing.Size(46, 21);
            this.lblFillBrand.TabIndex = 98;
            this.lblFillBrand.Text = "0000";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(54, 313);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 21);
            this.lblPrice.TabIndex = 99;
            this.lblPrice.Text = "Price";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdition.Location = new System.Drawing.Point(347, 218);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(136, 21);
            this.lblEdition.TabIndex = 101;
            this.lblEdition.Text = "Car Part Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrand.Location = new System.Drawing.Point(54, 216);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 21);
            this.lblBrand.TabIndex = 102;
            this.lblBrand.Text = "Brand";
            // 
            // btnSparePartSearch
            // 
            this.btnSparePartSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSparePartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparePartSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSparePartSearch.Location = new System.Drawing.Point(701, 100);
            this.btnSparePartSearch.Name = "btnSparePartSearch";
            this.btnSparePartSearch.Size = new System.Drawing.Size(139, 40);
            this.btnSparePartSearch.TabIndex = 79;
            this.btnSparePartSearch.Text = "Spare Part Search";
            this.btnSparePartSearch.UseVisualStyleBackColor = false;
            this.btnSparePartSearch.Click += new System.EventHandler(this.btnSparePartSearch_Click);
            // 
            // cmbPartBrand
            // 
            this.cmbPartBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbPartBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartBrand.ForeColor = System.Drawing.Color.White;
            this.cmbPartBrand.FormattingEnabled = true;
            this.cmbPartBrand.Location = new System.Drawing.Point(347, 108);
            this.cmbPartBrand.Name = "cmbPartBrand";
            this.cmbPartBrand.Size = new System.Drawing.Size(232, 28);
            this.cmbPartBrand.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(347, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 75;
            this.label7.Text = "Spare Part Brand";
            // 
            // cmbSparePartName
            // 
            this.cmbSparePartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbSparePartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSparePartName.ForeColor = System.Drawing.Color.White;
            this.cmbSparePartName.FormattingEnabled = true;
            this.cmbSparePartName.Location = new System.Drawing.Point(54, 108);
            this.cmbSparePartName.Name = "cmbSparePartName";
            this.cmbSparePartName.Size = new System.Drawing.Size(232, 28);
            this.cmbSparePartName.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(18, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "Update Spare Part Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(54, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 76;
            this.label8.Text = "Spare Part Name";
            // 
            // PanelCarPartManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(891, 580);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCarPartManage";
            this.Text = "PanelCarPartManage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSparePart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCarPartSave;
        private System.Windows.Forms.TextBox txtSparePartName;
        private System.Windows.Forms.TextBox txtSparePartPrice;
        private System.Windows.Forms.TextBox txtSparePartQty;
        private System.Windows.Forms.TextBox txtSparePartDesc;
        private System.Windows.Forms.TextBox txtSparePartModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSparePartBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tblSparePart;
        private System.Windows.Forms.TextBox txtSearchSparePart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSparePartSearch;
        private System.Windows.Forms.ComboBox cmbPartBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSparePartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateSparePartDetails;
        private System.Windows.Forms.TextBox txtFillPrice;
        private System.Windows.Forms.TextBox txtFillQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblFillPartName;
        private System.Windows.Forms.Label lblFillBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label12;
    }
}