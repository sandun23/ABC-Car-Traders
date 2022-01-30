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
        private int spare_part_id;
       // private readonly CarRepoImpl carRepository = new CarRepoImpl();

        public PanelCarPartManage()
        {
            InitializeComponent();
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            tblSparePart.DataSource = spareParts;
            GetAllSpareParts();
        }

        //This function use to save car parts 
        private void btnCarPartSave_Click(object sender, EventArgs e)
        {
            if (txtSparePartBrandName.Text == "" || txtSparePartName.Text == "" || txtSparePartModel.Text == "" || txtSparePartPrice.Text == "" || txtSparePartQty.Text == "" || txtSparePartDesc.Text == "" )
            {
                MessageBox.Show("Please Fill All the Blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SparePart sparePart = new SparePart(0, txtSparePartBrandName.Text, txtSparePartName.Text, txtSparePartModel.Text, Convert.ToDouble(txtSparePartPrice.Text), Convert.ToInt32(txtSparePartQty.Text), txtSparePartDesc.Text);
                bool v = sparePartRepoImpl.AddSparePart(sparePart);

                if (v)
                {
                    MessageBox.Show("Successfully Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanTexts();
                }
                else
                {
                    MessageBox.Show("Error", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //This function use to get all spare parts to table in frontend

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

        //This function use to clean after save done.
        private void CleanTexts()
        {
            txtSparePartBrandName.Text = "";
            txtSparePartName.Text = "";
            txtSparePartModel.Text = "";
            txtSparePartPrice.Text = "";
            txtSparePartQty.Text = "";
            txtSparePartDesc.Text = "";

            cmbPartBrand.SelectedIndex = 0;
            cmbSparePartName.SelectedIndex = 0;

            txtFillPrice.Text = "";
            txtFillQty.Text = "";

            lblFillBrand.Text = "";
            lblFillPartName.Text = "";

        
        }

        private void btnSparePartSearch_Click(object sender, EventArgs e)
        {

            if (cmbPartBrand.Text == "Please Select" || cmbSparePartName.Text == "Please Select")
            {
                MessageBox.Show("Please Select the Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SparePart sparePart = sparePartRepoImpl.FilterSparePartListCustomer(cmbSparePartName.Text, cmbPartBrand.Text);


                lblBrand.Text = "Spare Part Brand";
                lblEdition.Text = "Spare Part Edition";
                lblQty.Text = "QTY" + " (Remaining - " + sparePart.Quantity + ")";
                

                lblFillBrand.Text = sparePart.Brand;
                lblFillPartName.Text = sparePart.SparePartName;
                txtFillPrice.Text = Convert.ToString(sparePart.Price + ".00");

                txtFillQty.Text = sparePart.Quantity.ToString();

                spare_part_id = sparePart.SparePartID;


            }
        }

        //update spare part details
        private void btnUpdateSparePartDetails_Click(object sender, EventArgs e)
        {
            bool v = sparePartRepoImpl.UpdateSparePartDetails(spare_part_id, Convert.ToDouble(txtFillPrice.Text), Convert.ToInt32(txtFillQty.Text));

            if (v)
            {
                MessageBox.Show("Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanTexts();
            }
            else
            {
                MessageBox.Show("Please Try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        //Get All Spare Part Details to car part page
        private void GetAllSpareParts()
        {
            List<SparePart> spareParts = sparePartRepoImpl.GetAllSpareParts();
            cmbSparePartName.Items.Add("Please Select");
            cmbPartBrand.Items.Add("Please Select");

            cmbSparePartName.SelectedIndex = 0;
            cmbPartBrand.SelectedIndex = 0;
            foreach (var sparePart in spareParts)
            {
                //  var car_details = car.Brand + "_" + car.Edition;
                var sparePart_name = sparePart.SparePartName;
                var sparePart_brand = sparePart.Brand;

                cmbSparePartName.Items.Add(sparePart_name);
                cmbPartBrand.Items.Add(sparePart_brand);
            }
        }

    }
}
