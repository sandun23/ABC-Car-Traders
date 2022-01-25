using ABC_Car_Traders.model;
using ABC_Car_Traders.Repo.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders.view.Admin_Dashboard_Views
{
    public partial class PanelCustomerManage : Form
    {

        CustomerRepoImpl customerRepoImpl = new CustomerRepoImpl();

        public PanelCustomerManage()
        {
            InitializeComponent();
            List<Customer> customers = customerRepoImpl.GetAllCustomers();
            tblCustomerManage.DataSource = customers;
        }


        private void GetAllCustomerDetails(object sender, EventArgs e)
        {
            txtSearchCustomerDetails.Text = "";
            List<Customer> customers = customerRepoImpl.GetAllCustomers();
            tblCustomerManage.DataSource = customers;
        }

        private void SearchCustomertKeyUp(object sender, KeyEventArgs e)
        {
            List<Customer> customers = customerRepoImpl.FilterCustomerList(txtSearchCustomerDetails.Text);
            tblCustomerManage.DataSource = customers;
        }
    }
}
