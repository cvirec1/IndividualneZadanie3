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
    public partial class frmClientManagement : Form
    {
        ClientManagementViewModel clientManagementViewModel = new ClientManagementViewModel();
        int number;
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int clientId)
        {
            InitializeComponent();
            dgwAcountData.DataSource = clientManagementViewModel.GetAccountsData(clientId);
            dgwAcountData.DataMember = "Account";
            dgwCardData.DataSource = clientManagementViewModel.GetCardsData(clientId);
            dgwCardData.DataMember = "Card";
            number = clientId;
        }
        

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            
            using (frmAccount newForm = new frmAccount(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            
            using (frmTransactions newForm = new frmTransactions(clientManagementViewModel.GetAccountID(number)))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close Management?", "Really!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
