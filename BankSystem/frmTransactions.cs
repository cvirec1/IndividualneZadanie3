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
    public partial class frmTransactions : Form
    {
        TransactionsViewModel transactionsViewModel = new TransactionsViewModel();

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            dgwTransactions.DataSource = transactionsViewModel.GetTransactionsData();
            dgwTransactions.DataMember = "Transaction";
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(int clientId)
        {

            InitializeComponent();
            dgwTransactions.DataSource = transactionsViewModel.GetAccountsTransactionsData(clientId);
            dgwTransactions.DataMember = "Transaction";           

        }
    }
}
