﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;
using Data.Models;

namespace BankSystem
{
    public partial class frmMain : Form
    {
        MainViewModel mainViewModel = new MainViewModel();
        public frmMain()
        {
            InitializeComponent();
            Generator generator = new Generator();
            //IEnumerable<string> aaa = generator.GetRandomBanks(10);
            //IEnumerable<string> bbb = generator.GetRandomAddresses(10);
            //IEnumerable<string> ccc = generator.GetRandomPeople(10);
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            if (mainViewModel.CheckClient(txbIdNumber.Text))
            {                
                using (frmClientManagement newForm = new frmClientManagement(mainViewModel.GetID(txbIdNumber.Text)))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                cmdFindClient.BackColor = Color.Red;
            }
            
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }
    }
}
