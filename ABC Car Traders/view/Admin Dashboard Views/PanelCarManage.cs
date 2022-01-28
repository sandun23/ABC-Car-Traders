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
    public partial class PanelCarManage : Form
    {

        CarRepoImpl carRepoImpl = new CarRepoImpl();
        //private readonly CarRepoImpl carRepository = new CarRepoImpl();
        public PanelCarManage()
        {
            InitializeComponent();
            List<Car> cars = carRepoImpl.GetAllCars();
            tblCarDetails.DataSource = cars;
        }

        private void CleanTexts()
        {
            txtBrandName.Text = "";
                txtEdition.Text = "";
            txtModel.Text = "";
            txtModel.Text = "";
            cmbFuelType.Text = "";
            txtBodyType.Text = "";
            txtEngineCap.Text = "";
            txtColour.Text = "";
            txtManYear.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
        }

        //This function use to save car details
        private void btnCarSave_Click(object sender, EventArgs e)
        {
            if (txtBodyType.Text == "" || txtBrandName.Text == "" || txtEdition.Text == "" || txtModel.Text == "" || txtModel.Text == "" ||  cmbFuelType.Text == "" || txtEngineCap.Text == "" || txtColour.Text == "" || txtManYear.Text == "" || txtDesc.Text == "" || txtPrice.Text == "" || txtQty.Text == "" )
            {
                MessageBox.Show("Please Fill All the Blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Car car = new Car(0, txtBrandName.Text, txtEdition.Text, txtModel.Text, txtModel.Text, cmbFuelType.Text, txtBodyType.Text, txtEngineCap.Text, txtColour.Text, txtManYear.Text, txtDesc.Text, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(txtQty.Text));
                bool v = carRepoImpl.AddCar(car);

                if (v)
                {
                    MessageBox.Show("Done", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanTexts();

                }
                else
                {
                    MessageBox.Show("Error", "asdasd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }





        //This function use to get all car details 
        private void GetAllCars(object sender, EventArgs e)
            {
                txtCarSearch.Text = "";
                List<Car> cars = carRepoImpl.GetAllCars();
                tblCarDetails.DataSource = cars;
            }

        //This function use to search car details
        private void SearchCartKeyUp(object sender, KeyEventArgs e)
        {
            List<Car> cars = carRepoImpl.FilterCarList(txtCarSearch.Text);
            tblCarDetails.DataSource = cars;
        }
    }
}
