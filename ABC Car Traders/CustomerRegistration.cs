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
    }
}
