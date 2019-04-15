namespace BankSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdNumber = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwBankData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwTopAccount = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgwAccountCount = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBankData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTopAccount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccountCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(587, 103);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 23);
            this.cmdFindClient.TabIndex = 2;
            this.cmdFindClient.Text = "Find client";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(348, 173);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(348, 234);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(112, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(348, 294);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(349, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 86);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find account number of IDCard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(466, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 60);
            this.label3.TabIndex = 7;
            this.label3.Text = "< Odklik na vytvorenie nového účtu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(466, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 60);
            this.label4.TabIndex = 8;
            this.label4.Text = "< Odklik na evidenciu s účtami/klientami.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(466, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 60);
            this.label5.TabIndex = 9;
            this.label5.Text = "< Odklik na evidenciu s transakciami.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbIdNumber
            // 
            this.txbIdNumber.Location = new System.Drawing.Point(348, 106);
            this.txbIdNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbIdNumber.Name = "txbIdNumber";
            this.txbIdNumber.Size = new System.Drawing.Size(235, 20);
            this.txbIdNumber.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 299);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwBankData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Bank Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwBankData
            // 
            this.dgwBankData.AllowUserToAddRows = false;
            this.dgwBankData.AllowUserToDeleteRows = false;
            this.dgwBankData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBankData.Location = new System.Drawing.Point(10, 6);
            this.dgwBankData.Name = "dgwBankData";
            this.dgwBankData.ReadOnly = true;
            this.dgwBankData.Size = new System.Drawing.Size(277, 258);
            this.dgwBankData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgwTopAccount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top 10 Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgwTopAccount
            // 
            this.dgwTopAccount.AllowUserToAddRows = false;
            this.dgwTopAccount.AllowUserToDeleteRows = false;
            this.dgwTopAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTopAccount.Location = new System.Drawing.Point(12, 7);
            this.dgwTopAccount.Name = "dgwTopAccount";
            this.dgwTopAccount.ReadOnly = true;
            this.dgwTopAccount.Size = new System.Drawing.Size(275, 258);
            this.dgwTopAccount.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgwAccountCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(293, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Account Count";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgwAccountCount
            // 
            this.dgwAccountCount.AllowUserToAddRows = false;
            this.dgwAccountCount.AllowUserToDeleteRows = false;
            this.dgwAccountCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccountCount.Location = new System.Drawing.Point(12, 7);
            this.dgwAccountCount.Name = "dgwAccountCount";
            this.dgwAccountCount.ReadOnly = true;
            this.dgwAccountCount.Size = new System.Drawing.Size(275, 258);
            this.dgwAccountCount.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txbIdNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Islam Bank System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBankData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTopAccount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccountCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbIdNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwBankData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwTopAccount;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgwAccountCount;
    }
}

