using ABC_Car_Traders.view.Customer_Dashboard_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );
        public CustomerDashboard()
        {
            InitializeComponent();
            lblTitle.Text = "Dashboard";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerDashboard panelCustomerDashboard_vrb = new PanelCustomerDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerDashboard_vrb);
            panelCustomerDashboard_vrb.Show();
        }

        private void btnCustomerDashboard_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerDashboard.Height;
            pnlCustomerNav.Top = btnCustomerDashboard.Top;
            pnlCustomerNav.Left = btnCustomerDashboard.Left;
            btnCustomerDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerDashboard panelCustomerDashboard_vrb = new PanelCustomerDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerDashboard_vrb);
            panelCustomerDashboard_vrb.Show();
        }

        private void btnCustomerCarDetails_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerCarDetails.Height;
            pnlCustomerNav.Top = btnCustomerCarDetails.Top;
            pnlCustomerNav.Left = btnCustomerCarDetails.Left;
            btnCustomerCarDetails.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Car Details";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerCarDetails panelCustomerCarDetails_vrb = new PanelCustomerCarDetails() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerCarDetails_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerCarDetails_vrb);
            panelCustomerCarDetails_vrb.Show();
        }

        private void btnCustomerSparePartDetails_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerSparePartDetails.Height;
            pnlCustomerNav.Top = btnCustomerSparePartDetails.Top;
            pnlCustomerNav.Left = btnCustomerSparePartDetails.Left;
            btnCustomerSparePartDetails.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Spare Part Details";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerSparePart panelCustomerSparePart_vrb = new PanelCustomerSparePart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerSparePart_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerSparePart_vrb);
            panelCustomerSparePart_vrb.Show();
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerOrder.Height;
            pnlCustomerNav.Top = btnCustomerOrder.Top;
            pnlCustomerNav.Left = btnCustomerOrder.Left;
            btnCustomerOrder.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Order Details";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerOrder panelCustomerOrder_vrb = new PanelCustomerOrder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerOrder_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerOrder_vrb);
            panelCustomerOrder_vrb.Show();
        }

        private void btnCustomerProfile_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerProfile.Height;
            pnlCustomerNav.Top = btnCustomerProfile.Top;
            pnlCustomerNav.Left = btnCustomerProfile.Left;
            btnCustomerProfile.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Profile Details";
            this.PnlCustomerFormLoader.Controls.Clear();
            PanelCustomerProfile panelCustomerProfile_vrb = new PanelCustomerProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelCustomerProfile_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlCustomerFormLoader.Controls.Add(panelCustomerProfile_vrb);
            panelCustomerProfile_vrb.Show();
        }

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            pnlCustomerNav.Height = btnCustomerLogout.Height;
            pnlCustomerNav.Top = btnCustomerLogout.Top;
            pnlCustomerNav.Left = btnCustomerLogout.Left;
            btnCustomerLogout.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerDashboard_Leave(object sender, EventArgs e)
        {
            btnCustomerDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerCarDetails_Leave(object sender, EventArgs e)
        {
            btnCustomerCarDetails.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerSparePartDetails_Leave(object sender, EventArgs e)
        {
            btnCustomerSparePartDetails.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerOrder_Leave(object sender, EventArgs e)
        {
            btnCustomerOrder.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerProfile_Leave(object sender, EventArgs e)
        {
            btnCustomerProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerLogout_Leave(object sender, EventArgs e)
        {
            btnCustomerLogout.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
