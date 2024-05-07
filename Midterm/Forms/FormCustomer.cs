using Midterm.Data;
using Midterm.Model;
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
    public partial class FormCustomer : Form
    {
        DataTable dtCustomer;
        //FormMain formMain;
        public FormCustomer()
        {
            //this.formMain = formMain;
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            dtCustomer = Customers.GetAll();
            dgCustomer.DataSource = dtCustomer;
            dgCustomer.Columns[0].Visible = false;
            dgCustomer.Columns[1].HeaderText = "Customer Name";
            dgCustomer.Columns[1].Width = 200;
            dgCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomer.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomer.Columns[1].Visible = true;
            dgCustomer.Columns[2].Visible = false;
            dgCustomer.Columns[3].Visible = false;
            dgCustomer.Columns[4].Visible = false;
            dgCustomer.Columns[5].Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit formAddEdit = new FormCustomerAddEdit(null);
            if (formAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = Customers.Get(customerid);
                if (customer == null)
                {
                    MessageBox.Show("Cannot find customer");
                }
                else
                {
                    FormCustomerAddEdit formAddEdit = new
                   FormCustomerAddEdit(customer);
                    if (formAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitializeData();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\nDo you really want to delete this record ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int customerid =
               Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customers.Delete(customerid);

                MessageBox.Show("Customer had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitializeData();
            }
        }

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = Customers.Get(customerid);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CustomerName;
                    txtCompanyName.Text = customer.CompanyName;
                    txtPhone.Text = customer.Phone;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                }
            }

        }
    }
}
