using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAccounts : Form
    {
        AccountsViewModel viewModel = new AccountsViewModel();
        public frmAccounts()
        {
            InitializeComponent();
            dgwAccounts.DataSource = viewModel.GetAccountsData();
            dgwAccounts.DataMember = "Account";
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement())
            {
                newForm.ShowDialog();
            }
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {

        }

        private void dgwAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            dgwAccounts.DataSource = viewModel.FilterAccountsData(txbName.Text, txbSurname.Text, txbIDNumber.Text);
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)
        {
            dgwAccounts.DataSource = viewModel.FilterAccountsData(txbName.Text, txbSurname.Text, txbIDNumber.Text);
        }

        private void txbIDNumber_TextChanged(object sender, EventArgs e)
        {
            dgwAccounts.DataSource = viewModel.FilterAccountsData(txbName.Text, txbSurname.Text, txbIDNumber.Text);
        }
    }
}
