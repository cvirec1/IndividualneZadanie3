namespace BankSystem
{
    partial class frmClientManagement
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
            this.components = new System.ComponentModel.Container();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwAcountData = new System.Windows.Forms.DataGridView();
            this.dgwCardData = new System.Windows.Forms.DataGridView();
            this.btnAllCard = new System.Windows.Forms.Button();
            this.btnActiveCard = new System.Windows.Forms.Button();
            this.btnExpiredCard = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.chbxAddCard = new System.Windows.Forms.CheckBox();
            this.lblDailyLimit = new System.Windows.Forms.Label();
            this.nupdDailyLimit = new System.Windows.Forms.NumericUpDown();
            this.btnCancelCard = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAcountData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCardData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDailyLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(12, 171);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Location = new System.Drawing.Point(392, 256);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(112, 23);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Location = new System.Drawing.Point(392, 344);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Close account";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(392, 171);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Location = new System.Drawing.Point(12, 344);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(112, 23);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(12, 256);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(112, 23);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(128, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "< Odklik na úpravu údajov o účte/klientovi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(510, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "< Odklik na zatvorenie účtu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(128, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 60);
            this.label5.TabIndex = 14;
            this.label5.Text = "< Odklik na vloženie peňazí na účet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(130, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "< Odklik na výber peňazí z účtu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(510, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 60);
            this.label7.TabIndex = 16;
            this.label7.Text = "< Odklik na zobrazenie transakcií na účte";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(510, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 60);
            this.label8.TabIndex = 17;
            this.label8.Text = "< Odklik na zadanie novej transakcie";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwAcountData
            // 
            this.dgwAcountData.AllowUserToAddRows = false;
            this.dgwAcountData.AllowUserToDeleteRows = false;
            this.dgwAcountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAcountData.Location = new System.Drawing.Point(12, 10);
            this.dgwAcountData.Name = "dgwAcountData";
            this.dgwAcountData.ReadOnly = true;
            this.dgwAcountData.Size = new System.Drawing.Size(797, 93);
            this.dgwAcountData.TabIndex = 18;
            this.dgwAcountData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAcountData_CellContentClick);
            this.dgwAcountData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAcountData_RowEnter);
            // 
            // dgwCardData
            // 
            this.dgwCardData.AllowUserToAddRows = false;
            this.dgwCardData.AllowUserToDeleteRows = false;
            this.dgwCardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCardData.Location = new System.Drawing.Point(815, 12);
            this.dgwCardData.Name = "dgwCardData";
            this.dgwCardData.ReadOnly = true;
            this.dgwCardData.Size = new System.Drawing.Size(334, 234);
            this.dgwCardData.TabIndex = 19;
            this.dgwCardData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCardData_RowEnter);
            // 
            // btnAllCard
            // 
            this.btnAllCard.Location = new System.Drawing.Point(815, 256);
            this.btnAllCard.Name = "btnAllCard";
            this.btnAllCard.Size = new System.Drawing.Size(96, 23);
            this.btnAllCard.TabIndex = 20;
            this.btnAllCard.Text = "Active/Expired";
            this.btnAllCard.UseVisualStyleBackColor = true;
            this.btnAllCard.Click += new System.EventHandler(this.btnAllCard_Click);
            // 
            // btnActiveCard
            // 
            this.btnActiveCard.Location = new System.Drawing.Point(907, 256);
            this.btnActiveCard.Name = "btnActiveCard";
            this.btnActiveCard.Size = new System.Drawing.Size(95, 23);
            this.btnActiveCard.TabIndex = 21;
            this.btnActiveCard.Text = "Active Card";
            this.btnActiveCard.UseVisualStyleBackColor = true;
            this.btnActiveCard.Click += new System.EventHandler(this.btnActiveCard_Click);
            // 
            // btnExpiredCard
            // 
            this.btnExpiredCard.Location = new System.Drawing.Point(997, 256);
            this.btnExpiredCard.Name = "btnExpiredCard";
            this.btnExpiredCard.Size = new System.Drawing.Size(76, 23);
            this.btnExpiredCard.TabIndex = 22;
            this.btnExpiredCard.Text = "Expired Card";
            this.btnExpiredCard.UseVisualStyleBackColor = true;
            this.btnExpiredCard.Click += new System.EventHandler(this.btnExpiredCard_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(882, 368);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 23;
            this.btnAddCard.Text = "Add card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Visible = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // chbxAddCard
            // 
            this.chbxAddCard.AutoSize = true;
            this.chbxAddCard.Location = new System.Drawing.Point(815, 291);
            this.chbxAddCard.Name = "chbxAddCard";
            this.chbxAddCard.Size = new System.Drawing.Size(95, 17);
            this.chbxAddCard.TabIndex = 24;
            this.chbxAddCard.Text = "Add New Card";
            this.chbxAddCard.UseVisualStyleBackColor = true;
            this.chbxAddCard.CheckedChanged += new System.EventHandler(this.chbxAddCard_CheckedChanged);
            // 
            // lblDailyLimit
            // 
            this.lblDailyLimit.AutoSize = true;
            this.lblDailyLimit.Location = new System.Drawing.Point(816, 339);
            this.lblDailyLimit.Name = "lblDailyLimit";
            this.lblDailyLimit.Size = new System.Drawing.Size(60, 13);
            this.lblDailyLimit.TabIndex = 25;
            this.lblDailyLimit.Text = "Daily Limit :";
            this.lblDailyLimit.Visible = false;
            // 
            // nupdDailyLimit
            // 
            this.nupdDailyLimit.Location = new System.Drawing.Point(882, 337);
            this.nupdDailyLimit.Name = "nupdDailyLimit";
            this.nupdDailyLimit.Size = new System.Drawing.Size(120, 20);
            this.nupdDailyLimit.TabIndex = 26;
            this.nupdDailyLimit.Visible = false;
            // 
            // btnCancelCard
            // 
            this.btnCancelCard.Location = new System.Drawing.Point(1073, 256);
            this.btnCancelCard.Name = "btnCancelCard";
            this.btnCancelCard.Size = new System.Drawing.Size(76, 23);
            this.btnCancelCard.TabIndex = 27;
            this.btnCancelCard.Text = "Cancel Card";
            this.btnCancelCard.UseVisualStyleBackColor = true;
            this.btnCancelCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 410);
            this.Controls.Add(this.btnCancelCard);
            this.Controls.Add(this.nupdDailyLimit);
            this.Controls.Add(this.lblDailyLimit);
            this.Controls.Add(this.chbxAddCard);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnExpiredCard);
            this.Controls.Add(this.btnActiveCard);
            this.Controls.Add(this.btnAllCard);
            this.Controls.Add(this.dgwCardData);
            this.Controls.Add(this.dgwAcountData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.cmdWithdrawal);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdCloseAccount);
            this.Controls.Add(this.cmdNewTransaction);
            this.Controls.Add(this.cmdUpdate);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAcountData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCardData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDailyLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwAcountData;
        private System.Windows.Forms.DataGridView dgwCardData;
        private System.Windows.Forms.Button btnAllCard;
        private System.Windows.Forms.Button btnActiveCard;
        private System.Windows.Forms.Button btnExpiredCard;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.CheckBox chbxAddCard;
        private System.Windows.Forms.Label lblDailyLimit;
        private System.Windows.Forms.NumericUpDown nupdDailyLimit;
        private System.Windows.Forms.Button btnCancelCard;
        private System.Windows.Forms.Timer timer1;
    }
}