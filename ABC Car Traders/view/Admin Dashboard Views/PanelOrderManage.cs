using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders.view.Admin_Dashboard_Views
{
    public partial class PanelOrderManage : Form
    {
        public PanelOrderManage()
        {
            InitializeComponent();
            tblOrderManage.ColumnCount = 8;
            tblOrderManage.Columns[0].Name = "Car Edition/Spare Part Name";
            tblOrderManage.Columns[1].Name = "Customer Name";
            tblOrderManage.Columns[1].Name = "Customer Mobile";
            tblOrderManage.Columns[1].Name = "Brand";
            tblOrderManage.Columns[2].Name = "Model";
            tblOrderManage.Columns[3].Name = "Colour";
            tblOrderManage.Columns[4].Name = "Qty";
            tblOrderManage.Columns[5].Name = "Unit Price";
            tblOrderManage.Columns[6].Name = "Sub Total";
        }
    }
}
