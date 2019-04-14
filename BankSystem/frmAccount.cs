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
            cbxCity.DataSource = accountViewModel.FillComboBoxCity();
            cbxCity.DisplayMember = "Name";
            cbxCity.ValueMember = "Id";
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
            //accountViewModel._idCity = cbxCity.SelectedValue();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
