using ABC_Car_Traders.model;
using ABC_Car_Traders.Repo.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerRegistration : Form
    {

        CustomerRepoImpl customerRepoImpl = new CustomerRepoImpl();
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void txtCustomerCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void txtCustomerSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerPassword.Text == "" || txtCustomerPasswordCon.Text == "" || txtCustomerName.Text == "" || txtCustomerMobileNo.Text == "" || txtCustomerEmail.Text == "" || txtCustomerUserName.Text == "")
            {
                MessageBox.Show("Please enter values");
                txtCustomerName.Focus();
                return;
            }else if (txtCustomerPassword.Text != txtCustomerPasswordCon.Text)
            {
                MessageBox.Show("Password not matching");
                txtCustomerPasswordCon.Focus();
                return;
            }
            else
            {
                Customer customer = new Customer(0, txtCustomerName.Text, txtCustomerMobileNo.Text, txtCustomerEmail.Text, txtCustomerAddress.Text, txtCustomerUserName.Text, txtCustomerPassword.Text);
                bool v = customerRepoImpl.AddCustomer(customer);

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

        private void CleanTexts()
        {
            txtCustomerName.Text = "";
            txtCustomerMobileNo.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerUserName.Text = "";
            txtCustomerPassword.Text = "";
            txtCustomerPasswordCon.Text = "";
          
        }
    }
}
