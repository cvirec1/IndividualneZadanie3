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
        int indexCard;
        int indexAccount;
        int indexClient;
        int idclient;
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
            idclient = clientId;
            dgwAcountData.DataSource = clientManagementViewModel.GetAccountsData(clientId);
            dgwAcountData.DataMember = "Account";
            dgwAcountData.Columns["Id"].Visible = false;
            dgwAcountData.Columns["Id_client"].Visible = false;
            dgwCardData.DataSource = clientManagementViewModel.GetCardsData(clientId);
            dgwCardData.DataMember = "Card";
            if (dgwCardData.RowCount > 0)
            {
                indexCard = (int)dgwCardData.Rows[0].Cells[0].Value;
            }
            if (dgwAcountData.RowCount > 0)
            {
                indexAccount = (int)dgwAcountData.Rows[0].Cells[0].Value;
                indexClient = (int)dgwAcountData.Rows[0].Cells[1].Value;
            }
                
            number = clientId;
        }
        

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            
            using (frmAccount newForm = new frmAccount(indexClient,indexAccount))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction('D',indexAccount))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction('W',indexAccount))
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
            using (frmTransaction newForm = new frmTransaction('T',indexAccount))
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

        private void btnAllCard_Click(object sender, EventArgs e)
        {
            dgwCardData.DataSource = clientManagementViewModel.GetCardsData(number);
            dgwCardData.DataMember = "Card";
        }

        private void btnActiveCard_Click(object sender, EventArgs e)
        {
            dgwCardData.DataSource = clientManagementViewModel.GetActiveCardsData(number);
            dgwCardData.DataMember = "Card";
        }

        private void btnExpiredCard_Click(object sender, EventArgs e)
        {
            dgwCardData.DataSource = clientManagementViewModel.GetExpiredCardsData(number);
            dgwCardData.DataMember = "Card";
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if(clientManagementViewModel.InsertNewCard((int)nupdDailyLimit.Value, clientManagementViewModel.GetAccountID(number)))
            {
                btnAddCard.ForeColor = Color.Green;
                btnAddCard.Text = "Insert success";
                dgwCardData.DataSource = clientManagementViewModel.GetCardsData(number);
                dgwCardData.DataMember = "Card";
            }
            else
            {
                btnAddCard.ForeColor = Color.Red;
                btnAddCard.Text = "Insert failed";
            }
            
        }

        private void chbxAddCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAddCard.Checked == true)
            {
                btnAddCard.Visible = true;
                lblDailyLimit.Visible = true;
                nupdDailyLimit.Visible = true;
            }
            else
            {
                btnAddCard.Visible = false;
                lblDailyLimit.Visible = false;
                nupdDailyLimit.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clientManagementViewModel.CancelSelectedCard(indexCard))
            {
                btnCancelCard.ForeColor = Color.Green;
                dgwCardData.DataSource = clientManagementViewModel.GetCardsData(number);
            }
            else
            {
                btnCancelCard.ForeColor = Color.Red;
            }
        }

        private void dgwCardData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCard = (int)dgwCardData.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwAcountData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexAccount = (int)dgwAcountData.Rows[e.RowIndex].Cells[0].Value;
            indexClient = (int)dgwAcountData.Rows[e.RowIndex].Cells[1].Value;
        }

        private void dgwAcountData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwAcountData.DataSource = clientManagementViewModel.GetAccountsData(idclient);
            dgwAcountData.DataMember = "Account";
            dgwAcountData.Columns["Id"].Visible = false;
            dgwAcountData.Columns["Id_client"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {                       
            dgwAcountData.DataSource = clientManagementViewModel.GetAccountsData(number);
            dgwAcountData.DataMember = "Account";
            dgwAcountData.Columns["Id"].Visible = false;
            dgwAcountData.Columns["Id_client"].Visible = false;
            dgwCardData.DataSource = clientManagementViewModel.GetCardsData(number);
            dgwCardData.DataMember = "Card";
            if (dgwCardData.RowCount > 0)
            {
                indexCard = (int)dgwCardData.Rows[0].Cells[0].Value;
            }
            if (dgwAcountData.RowCount > 0)
            {
                indexAccount = (int)dgwAcountData.Rows[0].Cells[0].Value;
                indexClient = (int)dgwAcountData.Rows[0].Cells[1].Value;
            }
        }
    }
}
