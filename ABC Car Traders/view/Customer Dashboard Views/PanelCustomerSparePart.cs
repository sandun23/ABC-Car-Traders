using ABC_Car_Traders.model;
using ABC_Car_Traders.Repo.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders.view.Customer_Dashboard_Views
{
    public partial class PanelCustomerSparePart : Form
    {

        SparePartRepoImpl sparePartRepoImpl = new SparePartRepoImpl();
        public PanelCustomerSparePart()
        {
            InitializeComponent();
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            tblCustomerSparePartDetails.DataSource = spareParts;
        }

        private void GetAllSpareParts()
        {
            txtCustomerSparePartSearch.Text = "";
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            tblCustomerSparePartDetails.DataSource = spareParts;
        }

        private void SearchSpareParttKeyUp(object sender, KeyEventArgs e)
        {
            List<SparePart> spareParts = sparePartRepoImpl.FilterSparePartList(txtCustomerSparePartSearch.Text);
            tblCustomerSparePartDetails.DataSource = spareParts;
        }

        private void btnCustomerSparePartRefresh_Click(object sender, EventArgs e)
        {
            this.GetAllSpareParts();
        }
    }
}
