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
    public partial class PanelCustomerCarDetails : Form
    {

        CarRepoImpl carRepoImpl = new CarRepoImpl();
        public PanelCustomerCarDetails()
        {
            InitializeComponent();
            List<Car> cars = carRepoImpl.GetAllCars();
            tblCustomerCarDetails.DataSource = cars;


            
        }


        private void GetAllCar()
        {
            txtCustomerCarSearch.Text = "";
            List<Car> cars = carRepoImpl.GetAllCars();
            tblCustomerCarDetails.DataSource = cars;
        }

        private void SearchCartKeyUp(object sender, KeyEventArgs e)
        {
            List<Car> cars = carRepoImpl.FilterCarList(txtCustomerCarSearch.Text);
            tblCustomerCarDetails.DataSource = cars;
        }

        private void btnCustomerCarRefresh_Click(object sender, EventArgs e)
        {
            this.GetAllCar();
        }
    }
}
