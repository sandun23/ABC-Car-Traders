using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userRole = cmbLoginUserRole.Text;

            string email = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;

            if (userRole == "Admin")
            {

                this.Hide();
                var adminDashboard = new AdminDashboard();
                adminDashboard.Closed += (s, args) => this.Close();
                adminDashboard.Show();
            }
            else if(userRole == "Customer")
            {
                this.Hide();
                var customerDashboard = new CustomerDashboard();
                customerDashboard.Closed += (s, args) => this.Close();
                customerDashboard.Show();
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var customerRegistration = new CustomerRegistration();
            customerRegistration.Closed += (s, args) => this.Close();
            customerRegistration.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Are You Sure",s)
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
