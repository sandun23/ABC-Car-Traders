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
    public partial class PanelCustomerOrder : Form
    {

        private int car_ID;
        private int spare_Part_ID;
        private int  qty;
        private string model;
        private string colour;
        private string brand;
        private double unit_Price;
        private double total;

        CarRepoImpl carRepoImpl = new CarRepoImpl();
        SparePartRepoImpl sparePartRepoImpl = new SparePartRepoImpl();
        private readonly List<OrderDetails> orderDetailsList = new List<OrderDetails>();
        public PanelCustomerOrder()
        {
            InitializeComponent();
            GetAllCars();
            GetAllSpareParts();
            tblCart.ColumnCount = 7;
            tblCart.Columns[0].Name = "Car Edition/Spare Part Name";
            tblCart.Columns[1].Name = "Brand";
            tblCart.Columns[2].Name = "Model";
            tblCart.Columns[3].Name = "Colour";
            tblCart.Columns[4].Name = "Qty";
            tblCart.Columns[5].Name = "Unit Price";
            tblCart.Columns[6].Name = "Sub Total";
        }


        private void GetAllCars()
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
                var car_edition = car.Edition ;
                var car_model = car.Model ;
                Console.WriteLine(car_brand);
                cmbCarBrand.Items.Add(car_brand);
                cmbCarEdition.Items.Add(car_edition);
                cmbCarModel.Items.Add(car_model);
            }
        }

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

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            if (cmbCarBrand.Text == "Please Select" || cmbCarEdition.Text == "Please Select" || cmbCarModel.Text == "Please Select") {

                MessageBox.Show("Please Select the Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                Car cars = carRepoImpl.FilterCarListCustomer(cmbCarBrand.Text, cmbCarEdition.Text, cmbCarModel.Text);

                lblTotal.Text = "Car Model";
                lblBrand.Text = "Car Brand";
                lblEdition.Text = "Car Edition";
                lblQty.Text = "QTY" + " (Remaining - " + cars.Quantity + ")";

                lblFillBrand.Text = cars.Brand;
                lblFillEdition.Text = cars.Edition;
                lblFillTotal.Text = cars.Model;
                lblFillPrice.Text = Convert.ToString(cars.Price + ".00");

                brand = cars.Brand;
                colour = cars.Colour;
                model = cars.Model;
                unit_Price = cars.Price;
                qty = cars.Quantity;
                txtFillQty.Text = "0";
            }
           
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
                lblTotal.Text = "";
                lblFillTotal.Text = "";


                lblFillBrand.Text = sparePart.Brand;
                lblFillEdition.Text = sparePart.SparePartName;
                lblFillPrice.Text = Convert.ToString(sparePart.Price + ".00");

                brand = sparePart.Brand;
                colour = "";
                model = sparePart.Model;
                unit_Price = sparePart.Price;
                qty = sparePart.Quantity;
                txtFillQty.Text = "0";
            }
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
          //  if (ValidateItemForm())
           // {
                // check customer enter quantity is less than or equal to available quantity
                if (qty >= Convert.ToInt32(txtFillQty.Text))
                {
                    double subTotal = unit_Price * Convert.ToInt32(txtFillQty.Text);
                    total += subTotal;
                    string[] orderCarts = { lblFillEdition.Text, brand, model, colour, Convert.ToString(txtFillQty.Text), Convert.ToString(unit_Price), Convert.ToString(subTotal) };
                    tblCart.Rows.Add(orderCarts);
                    orderDetailsList.Add(new OrderDetails(0, 0, unit_Price, Convert.ToInt32(txtFillQty.Text), subTotal, car_ID, spare_Part_ID));

                    lblFillTotal.Text = Convert.ToString(total + ".00");
                    ClearCartTable();
                }
                else
                {
                    MessageBox.Show("Insufficient Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

           // }
        }


        //private bool ValidateItemForm()
        //{
        //    if (car_ID > 0 || spare_Part_ID > 0)
        //    {
        //        if (txtFillQty.Text != " " && txtFillQty.Text != "0")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Quantity is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //}

        private void QuantityKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Quantity allows only numeric values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFillQty.Text = "0";
            }
        }

        private void ClearCartTable()
        {
            cmbCarBrand.SelectedIndex = 0;
            cmbCarEdition.SelectedIndex = 0;
            cmbCarModel.SelectedIndex = 0;
            cmbPartBrand.SelectedIndex = 0;
            cmbSparePartName.SelectedIndex = 0;

            txtFillQty.Text = "0";
            lblFillBrand.Text = "";
            lblFillEdition.Text = "";
            lblFillPrice.Text = "";
            lblFillTotal.Text = "";
          
            car_ID = 0;
            spare_Part_ID = 0;
        }

        private void btnPlaceAOrder_Click(object sender, EventArgs e)
        {
            Console.WriteLine(orderDetailsList.Count == 0);
            if (orderDetailsList.Count != 0)
            {
                OrderRepoImpl orderRepositoryImpl = new OrderRepoImpl();
                MainOrder mainOrder = new MainOrder(0, null, 1, "Pending", Convert.ToDouble(total), orderDetailsList);
                string result = orderRepositoryImpl.AddOrder(mainOrder);
                if (result != "0")
                {
                    MessageBox.Show("Order Successfully Added,  To " + result + " ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblFillTotal.Text = "";
                    tblCart.Rows.Clear();
                    orderDetailsList.Clear();
                }
                else
                {
                    MessageBox.Show("Order Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Cart is empty , Please add items before submitting", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCarEdition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
