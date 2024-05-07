using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.Forms
{
    public partial class FormMain : Form
    {
        FormCustomer formCustomer;
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void mMenu_MouseEnter(object sender, EventArgs e)
        {
            mMenu.BackColor = Color.White;
        }

        private void mMenu_MouseLeave(object sender, EventArgs e)
        {
            mMenu.BackColor = Color.Gainsboro;
        }

        private void mMenuType_MouseEnter(object sender, EventArgs e)
        {
            mMenuType.BackColor = Color.White;
        }

        private void mMenuType_MouseLeave(object sender, EventArgs e)
        {
            mMenuType.BackColor = Color.Gainsboro;
        }

        private void mManageUser_MouseEnter(object sender, EventArgs e)
        {
            mManageUser.BackColor = Color.White;
        }

        private void mManageUser_MouseLeave(object sender, EventArgs e)
        {
            mManageUser.BackColor = Color.Gainsboro;
        }

        private void mCustomer_MouseEnter(object sender, EventArgs e)
        {
            mCustomer.BackColor = Color.White;
        }

        private void mCustomer_MouseLeave(object sender, EventArgs e)
        {
            mCustomer.BackColor = Color.Gainsboro;
        }

        private void mInvoice_MouseEnter(object sender, EventArgs e)
        {
            mInvoice.BackColor = Color.White;
        }

        private void mInvoice_MouseLeave(object sender, EventArgs e)
        {
            mInvoice.BackColor = Color.Gainsboro;
        }

        private void mLogout_MouseEnter(object sender, EventArgs e)
        {
            mLogout.BackColor = Color.White;
        }

        private void mLogout_MouseLeave(object sender, EventArgs e)
        {
            mLogout.BackColor = Color.Gainsboro;
        }

        private void mCustomer_Click(object sender, EventArgs e)
        {
            if (formCustomer == null)
            { 
                formCustomer = new FormCustomer();
                formCustomer.TopLevel = false;

                formCustomer.FormBorderStyle = FormBorderStyle.None;
                formCustomer.Dock = DockStyle.Fill;

                pnMain.Controls.Add(formCustomer);
                formCustomer.Show();
                formCustomer.BringToFront();
            }
            else
            {
                formCustomer.BringToFront();
            }
        }

    }
}
