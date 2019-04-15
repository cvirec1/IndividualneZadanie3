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
        int indexA;
        public frmAccounts()
        {
            InitializeComponent();
            dgwAccounts.DataSource = viewModel.GetAccountsData();
            dgwAccounts.DataMember = "Account";
            if (dgwAccounts.RowCount > 0)
            {
                indexA = (int)dgwAccounts.Rows[0].Cells[1].Value;
            }
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement(indexA))
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

        private void dgwAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexA = (int)dgwAccounts.Rows[e.RowIndex].Cells[1].Value;
        }
    }
}
