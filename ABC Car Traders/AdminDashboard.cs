using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ABC_Car_Traders.view;

namespace ABC_Car_Traders
{
    public partial class AdminDashboard : Form
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



        public AdminDashboard()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            PanelDashboard PanelDashboard_vrb = new PanelDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(PanelDashboard_vrb);
            PanelDashboard_vrb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            PanelDashboard PanelDashboard_vrb = new PanelDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(PanelDashboard_vrb);
            PanelDashboard_vrb.Show();
        }

        private void btnCarManage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCarManage.Height;
            pnlNav.Top = btnCarManage.Top;
            pnlNav.Left = btnCarManage.Left;
            btnCarManage.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Car Manage";
            this.PnlFormLoader.Controls.Clear();
            PanelCarManage PanelCarManage_vrb = new PanelCarManage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelCarManage_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(PanelCarManage_vrb);
            PanelCarManage_vrb.Show();
        }

        private void btnPartManage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPartManage.Height;
            pnlNav.Top = btnPartManage.Top;
            pnlNav.Left = btnPartManage.Left;
            btnPartManage.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Spare Part Manage";
            this.PnlFormLoader.Controls.Clear();
            PanelCarPartManage PanelCarPartManage_vrb = new PanelCarPartManage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PanelCarPartManage_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(PanelCarPartManage_vrb);
            PanelCarPartManage_vrb.Show();
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOrderManage.Height;
            pnlNav.Top = btnOrderManage.Top;
            pnlNav.Left = btnOrderManage.Left;
            btnOrderManage.BackColor = Color.FromArgb(46, 51, 73);

//AddingNewEventArgs btn partsssssssssssssssssssssssssssssssssssssssss

        private void btnCustomerManage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCustomerManage.Height;
            pnlNav.Top = btnCustomerManage.Top;
            pnlNav.Left = btnCustomerManage.Left;
            btnCustomerManage.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUserManage.Height;
            pnlNav.Top = btnUserManage.Top;
            pnlNav.Left = btnUserManage.Left;
            btnUserManage.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnCarManage_Leave(object sender, EventArgs e)
        {
            btnCarManage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPartManage_Leave(object sender, EventArgs e)
        {
            btnPartManage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOrderManage_Leave(object sender, EventArgs e)
        {
            btnOrderManage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerManage_Leave(object sender, EventArgs e)
        {
            btnCustomerManage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUserManage_Leave(object sender, EventArgs e)
        {
            btnUserManage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

    }
}
