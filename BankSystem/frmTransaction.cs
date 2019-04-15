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
    public partial class frmTransaction : Form
    {
        char typeTr;
        int idAccSource;
        int idAccDest;
        TransactionViewModel transactionViewModel = new TransactionViewModel();
        public frmTransaction()
        {
            InitializeComponent();
        }
        public frmTransaction(char type,int id)
        {
            InitializeComponent();
            if(type == 'W')
            {
                typeTr = type;
                dgwSource.Visible = true;
                dgwSource.DataSource = transactionViewModel.FillSource(id);
                dgwSource.DataMember = "Account";
                dgwSource.Columns["Id"].Visible = false;
                dgwDestination.Visible = false;
                lbDestination.Visible = false;
                txbKS.Visible = false;
                txbSS.Visible = false;
                txbVS.Visible = false;
                lbKS.Visible = false;
                lbSS.Visible = false;
                lbVS.Visible = false;
                if (dgwSource.RowCount > 0)
                {
                    idAccSource = (int)dgwSource.Rows[0].Cells[0].Value;
                }
                
            }
            else if (type == 'D')
            {
                typeTr = type;
                lbSource.Visible = false;
                dgwDestination.Visible = true;
                dgwDestination.DataSource = transactionViewModel.FillSource(id);
                dgwDestination.DataMember = "Account";
                dgwDestination.Columns["Id"].Visible = false;
                dgwSource.Visible = false;
                txbKS.Visible = false;
                txbSS.Visible = false;
                txbVS.Visible = false;
                lbKS.Visible = false;
                lbSS.Visible = false;
                lbVS.Visible = false;
                if (dgwDestination.RowCount > 0)
                {
                    idAccDest = (int)dgwDestination.Rows[0].Cells[0].Value;
                }
            }
            else
            {
                dgwDestination.DataSource = transactionViewModel.FillDestination(id);
                dgwDestination.DataMember = "Account";
                dgwDestination.Columns["Id"].Visible = false;
                if (dgwDestination.RowCount > 0)
                {
                    idAccDest = (int)dgwDestination.Rows[0].Cells[0].Value;
                }
                dgwSource.DataSource = transactionViewModel.FillSource(id);
                dgwSource.DataMember = "Account";
                dgwSource.Columns["Id"].Visible = false;
                if (dgwSource.RowCount > 0)
                {
                    idAccSource = (int)dgwSource.Rows[0].Cells[0].Value;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close Transaction?", "Really!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                
            }
        }

        private void dgwSource_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idAccSource = (int)dgwSource.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwDestination_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idAccDest = (int)dgwDestination.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (typeTr == 'D')
            {
                transactionViewModel._ammount = int.Parse(txbAmount.Text);
                transactionViewModel._type = typeTr;
                if (transactionViewModel.InsertTransaction(idAccDest))
                {
                    btnSubmit.ForeColor = Color.Green;
                }
                else
                {
                    btnSubmit.ForeColor = Color.Green;
                    transactionViewModel.UpdateAmount(idAccDest);
                }
            }else if(typeTr == 'W')
            {
                transactionViewModel._ammount = int.Parse(txbAmount.Text);
                transactionViewModel._type = typeTr;
                if (transactionViewModel.InsertTransaction(idAccSource))
                {
                    btnSubmit.ForeColor = Color.Green;
                }
                else
                {
                    btnSubmit.ForeColor = Color.Green;
                    transactionViewModel.UpdateAmount(idAccSource);
                }
            }
            else
            {
                transactionViewModel._ammount = int.Parse(txbAmount.Text);
                transactionViewModel._type = typeTr;
                transactionViewModel._ks = int.Parse(txbKS.Text);
                transactionViewModel._ss = int.Parse(txbSS.Text);
                transactionViewModel._vs = int.Parse(txbVS.Text);
                if (transactionViewModel.InsertTransaction(idAccSource))
                {
                    btnSubmit.ForeColor = Color.Green;
                }
                else
                {
                    btnSubmit.ForeColor = Color.Green;
                    transactionViewModel.UpdateSourceAmount(idAccSource);
                    transactionViewModel.UpdateDestinationAmount(idAccDest);
                }
            }
            
        }
    }

}

