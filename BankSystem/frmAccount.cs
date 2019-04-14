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

    public partial class frmAccount : Form
    {
        AccountViewModel accountViewModel = new AccountViewModel();
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
            cbxCity.SelectedIndex = 0;
            //cbxCity.DataSource = accountViewModel.FillComboBoxCity();
            //cbxCity.DisplayMember = "Name";
            //cbxCity.ValueMember = "Id";
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            accountViewModel._firstName = txbFirstName.Text;
            accountViewModel._lastName = txbLastName.Text;
            accountViewModel._idNumber = txbIDNumber.Text;
            accountViewModel._adress = txbAdress.Text;
            accountViewModel._idCity = accountViewModel.GetCityID(cbxCity.GetItemText(cbxCity.SelectedItem));
            //accountViewModel._idCity = accountViewModel.GetCityID(txbCity.Text);
            if (accountViewModel.InsertClient()) 
            //if(true)
            {
                txbFirstName.Enabled = false;
                txbLastName.Enabled = false;
                txbIDNumber.Enabled = false;
                txbAdress.Enabled = false;
                cbxCity.Enabled = false;
                btnInsertClient.Enabled = false;
                lblClientID.Visible = true;
                lblClient.Visible = true;
                lblClient.Text = accountViewModel.GetInsertedClientID().ToString();
                lblIBAN.Visible = true;
                txbIBAN.Visible = true;
                btnIBAN.Visible = true;
                lblOverLimit.Visible = true;
                txbOverLimit.Visible = true;
                btnAccountInsert.Visible = true;
                lblFailedClient.Visible = false;
                btnInsertClient.ForeColor = Color.Green;
            }
            else
            {
                lblFailedClient.Visible = true;
                btnInsertClient.ForeColor = Color.Red;
            }
            
            //accountViewModel._idCity = cbxCity.SelectedValue();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnIBAN_Click(object sender, EventArgs e)
        {
            txbIBAN.Text = accountViewModel.GetIBAN();
        }
    }
}
