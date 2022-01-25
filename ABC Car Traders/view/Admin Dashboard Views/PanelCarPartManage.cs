using ABC_Car_Traders.model;
using ABC_Car_Traders.Repo.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders.view
{
    public partial class PanelCarPartManage : Form
    {
        SparePartRepoImpl sparePartRepoImpl = new SparePartRepoImpl();
       // private readonly CarRepoImpl carRepository = new CarRepoImpl();

        public PanelCarPartManage()
        {
            InitializeComponent();
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            tblSparePart.DataSource = spareParts;
        }

        private void btnCarPartSave_Click(object sender, EventArgs e)
        {
            SparePart sparePart = new SparePart(0, txtSparePartBrandName.Text, txtSparePartName.Text, txtSparePartModel.Text, Convert.ToDouble(txtSparePartPrice.Text), Convert.ToInt32(txtSparePartQty.Text), txtSparePartDesc.Text);
            bool v = sparePartRepoImpl.AddSparePart(sparePart);

            if (v)
            {
                MessageBox.Show("Done", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanTexts();
            }
            else
            {
                MessageBox.Show("Error", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllSpareParts(object sender, EventArgs e)
        {
            txtSearchSparePart.Text = "";
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            tblSparePart.DataSource = spareParts;
        }

        private void SearchSpareParttKeyUp(object sender, KeyEventArgs e)
        {
            List<SparePart> spareParts = sparePartRepoImpl.FilterSparePartList(txtSearchSparePart.Text);
            tblSparePart.DataSource = spareParts;
        }


        private void CleanTexts()
        {
            txtSparePartBrandName.Text = "";
            txtSparePartName.Text = "";
            txtSparePartModel.Text = "";
            txtSparePartPrice.Text = "";
            txtSparePartQty.Text = "";
            txtSparePartDesc.Text = "";
        
        }

        private void txtSearchSparePart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
