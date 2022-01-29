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

            cmbTransmission.Items.Add("Select Type");
            cmbTransmission.Items.Add("Auto");
            cmbTransmission.Items.Add("Manual");
            cmbTransmission.SelectedIndex = 0;
            

            cmbFuelType.Items.Add("Select Type");
            cmbFuelType.Items.Add("Petrol");
            cmbFuelType.Items.Add("Diesel");

            cmbFuelType.SelectedIndex = 0;

            GetSearchAllCars();
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
                MessageBox.Show("Please Fill All the Blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void GetSearchAllCars()
        {

            List<Car> cars = carRepoImpl.GetAllCars();
            cmbCarBrand.Items.Add("Please Select");
            cmbCarEdition.Items.Add("Please Select");
            cmbCarModel.Items.Add("Please Select");
            cmbCarBrand.SelectedIndex = 0;
            cmbCarEdition.SelectedIndex = 0;
            cmbCarModel.SelectedIndex = 0;
            foreach (var car in cars)
            {
                //  var car_details = car.Brand + "_" + car.Edition;
                var car_brand = car.Brand;
                var car_edition = car.Edition;
                var car_model = car.Model;
                Console.WriteLine(car_brand);
                cmbCarBrand.Items.Add(car_brand);
                cmbCarEdition.Items.Add(car_edition);
                cmbCarModel.Items.Add(car_model);
            }
        }


        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            if (cmbCarBrand.Text == "Please Select" || cmbCarEdition.Text == "Please Select" || cmbCarModel.Text == "Please Select")
            {

                MessageBox.Show("Please Select the Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                Car cars = carRepoImpl.FilterCarListCustomer(cmbCarBrand.Text, cmbCarEdition.Text, cmbCarModel.Text);

                //lblTotal.Text = "Car Model";
                //lblBrand.Text = "Car Brand";
                //lblEdition.Text = "Car Edition";
                //lblQty.Text = "QTY" + " (Remaining - " + cars.Quantity + ")";

                //lblFillBrand.Text = cars.Brand;
                //lblFillEdition.Text = cars.Edition;
                //lblFillTotal.Text = cars.Model;
                //lblFillPrice.Text = Convert.ToString(cars.Price + ".00");

                //brand = cars.Brand;
                //colour = cars.Colour;
                //model = cars.Model;
                //unit_Price = cars.Price;
                //qty = cars.Quantity;
                //txtFillQty.Text = "0";
            }
        }
    }
}
