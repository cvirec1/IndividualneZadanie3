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
    public partial class frmMain : Form
    {
        int counter = 0;
        ATMViewModel aTMViewModel = new ATMViewModel();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                if (aTMViewModel.ControlCard(int.Parse(txbCardID.Text), int.Parse(txbPIN.Text)))
                {
                    btnLogin.ForeColor = Color.Green;
                    using (frmATMMenu newForm = new frmATMMenu(aTMViewModel.GetAccountID(int.Parse(txbCardID.Text))))
                    {
                        newForm.ShowDialog();
                    }
                }
                else
                {
                    counter++;
                    btnLogin.ForeColor = Color.Red;
                }
            } 
        }

        private void txbCardID_TextChanged(object sender, EventArgs e)
        {
            counter = 0;
        }
    }
}
