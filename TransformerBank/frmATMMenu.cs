using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class frmATMMenu : Form
    {
        int accID;
        ATMViewModel aTMViewModel = new ATMViewModel();
        public frmATMMenu(int id)
        {
            accID = id;
            InitializeComponent();
        }

        private void btnStateAccount_Click(object sender, EventArgs e)
        {
            lblStateAcount.Visible = true;
            lblStateAcount.Text = aTMViewModel.GetAccountAmount(accID);            
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lblStateAcount.Visible = false;
        }
    }
}
