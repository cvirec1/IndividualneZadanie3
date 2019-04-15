
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
        int amount;
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
            dgwDataAccount.Visible = true;
            dgwDataAccount.DataSource = aTMViewModel.FillSource(accID);
            dgwDataAccount.DataMember = "Account";
            dgwDataAccount.Columns["Id"].Visible = false;
            btnStateAccount.Enabled = false;
            btn5.Visible = true;
            btn10.Visible = true;
            btn20.Visible = true;
            btn50.Visible = true;
            btn100.Visible = true;
            btn200.Visible = true;
            btn500.Visible = true;
            lblCustom.Visible = true;
            txbAmount.Visible = true;
            btnWithdraw.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            amount = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            amount = 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amount = 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            amount = 50;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            amount = 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            amount = 200;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            amount = 500;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txbAmount.TextLength > 0)
            {
                aTMViewModel._ammount = int.Parse(txbAmount.Text);                
            }
            else
            {
                aTMViewModel._ammount = amount;
            }
            
            aTMViewModel._type = 'W';
            if (aTMViewModel.InsertTransaction(accID))
            {
                btnWithdraw.ForeColor = Color.Green;
                aTMViewModel.UpdateAmount(accID);
                Close();
            }
            else
            {
                btnWithdraw.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
