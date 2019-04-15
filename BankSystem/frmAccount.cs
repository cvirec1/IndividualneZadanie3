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
        int idC;
        int idA;
        
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
        public frmAccount(int clientId,int accountId)
        {
            InitializeComponent();
            idA = accountId;
            idC = clientId;
            List<string> ClientList = accountViewModel.GetClientData(clientId);
            txbFirstName.Text = ClientList[0];
            txbLastName.Text = ClientList[1];
            txbAdress.Text = ClientList[2];
            cbxCity.SelectedItem = ClientList[3];
            txbIDNumber.Text = ClientList[4];
            List<string> AccountList = accountViewModel.GetAccountData(accountId);
            txbIBAN.Text = AccountList[0];
            txbAmount.Text = AccountList[1];
            txbOverLimit.Text = AccountList[2];
            lblClientID.Visible = true;
            lblClient.Visible = true;
            lblClient.Text = clientId.ToString();
            lblIBAN.Visible = true;
            txbIBAN.Visible = true;            
            txbAmount.Visible = true;
            lblAmount.Visible = true;
            lblOverLimit.Visible = true;
            txbOverLimit.Visible = true;
            btnAccountInsert.Visible = true;
            btnInsertClient.Text = "Update client";
            btnAccountInsert.Text = "Update account";

        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            if (btnInsertClient.Text.Contains("Create"))
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
                    txbAmount.Visible = true;
                    lblAmount.Visible = true;
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
            }
            else
            {
                accountViewModel._firstName = txbFirstName.Text;
                accountViewModel._lastName = txbLastName.Text;
                accountViewModel._idNumber = txbIDNumber.Text;
                accountViewModel._adress = txbAdress.Text;
                accountViewModel._idCity = accountViewModel.GetCityID(cbxCity.GetItemText(cbxCity.SelectedItem));
                if (accountViewModel.UpdateClient(idC))
                {
                    lblFailedClient.Visible = false;
                    btnInsertClient.ForeColor = Color.Green;
                }
                else
                {
                    lblFailedClient.Text = "Failed";
                    lblFailedClient.Visible = true;
                    btnInsertClient.ForeColor = Color.Red;
                }
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

        private void btnAccountInsert_Click(object sender, EventArgs e)
        {
            if (btnAccountInsert.Text.Contains("Create"))
            {
                accountViewModel._id_client = int.Parse(lblClient.Text);
                accountViewModel._amount = decimal.Parse(txbAmount.Text);
                accountViewModel._iban = txbIBAN.Text;
                accountViewModel._overFlow = decimal.Parse(txbOverLimit.Text);
                if (accountViewModel.InsertAccount())
                {
                    txbAmount.Enabled = false;
                    txbOverLimit.Enabled = false;
                    txbAmount.Enabled = false;
                    btnIBAN.Enabled = false;
                    btnAccountInsert.Enabled = false;
                    lblAccountFailed.Visible = false;
                    btnCancel.Text = "Press to continue";
                    btnAccountInsert.ForeColor = Color.Green;
                }
                else
                {
                    lblAccountFailed.Visible = true;
                    btnAccountInsert.ForeColor = Color.Red;
                }
            }
            else
            {
                accountViewModel._id_client = int.Parse(lblClient.Text);
                accountViewModel._amount = decimal.Parse(txbAmount.Text);
                accountViewModel._iban = txbIBAN.Text;
                accountViewModel._overFlow = decimal.Parse(txbOverLimit.Text);
                if (accountViewModel.UpdateAccount(idA))
                {
                    lblAccountFailed.Visible = false;
                    btnCancel.Text = "Press to Back";
                    btnAccountInsert.ForeColor = Color.Green;
                }
                else
                {
                    lblAccountFailed.Text = "Failed";
                    lblAccountFailed.Visible = true;
                    btnAccountInsert.ForeColor = Color.Red;
                }
            }           

        }
    }
}
