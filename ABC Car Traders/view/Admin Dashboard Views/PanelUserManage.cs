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
    public partial class PanelUserManage : Form
    {

        UserRepoImpl userRepoImpl = new UserRepoImpl();
        public PanelUserManage()
        {
            InitializeComponent();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "" || txtUserConPassword.Text == "" || txtUserEmail.Text =="" || txtUserName.Text == "" )
            {
                MessageBox.Show("Please enter values" ,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if (txtUserPassword.Text != txtUserConPassword.Text)
            {
                MessageBox.Show("Password not matching", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUserConPassword.Focus();
                return;
            }
            else
            {
                AdminUsers adminUser = new AdminUsers(0, txtUserEmail.Text, txtUserName.Text, cmbUserRole.Text, txtUserPassword.Text);
                bool v = userRepoImpl.AddAdminUser(adminUser);

                if (v)
                {
                    MessageBox.Show("Done", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // CleanTexts();

                }
                else
                {
                    MessageBox.Show("Error", "asdasd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
