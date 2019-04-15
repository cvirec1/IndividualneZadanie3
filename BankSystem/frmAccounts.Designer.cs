namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbIDNumber = new System.Windows.Forms.TextBox();
            this.dgwAccounts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(256, 234);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(136, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 91);
            this.label4.TabIndex = 11;
            this.label4.Text = "^\r\nButton na menežovanie aktuálne zvoleného účtu v gride";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 21);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 12;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(241, 21);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(100, 20);
            this.txbSurname.TabIndex = 13;
            this.txbSurname.TextChanged += new System.EventHandler(this.txbSurname_TextChanged);
            // 
            // txbIDNumber
            // 
            this.txbIDNumber.Location = new System.Drawing.Point(472, 21);
            this.txbIDNumber.Name = "txbIDNumber";
            this.txbIDNumber.Size = new System.Drawing.Size(100, 20);
            this.txbIDNumber.TabIndex = 14;
            this.txbIDNumber.TextChanged += new System.EventHandler(this.txbIDNumber_TextChanged);
            // 
            // dgwAccounts
            // 
            this.dgwAccounts.AllowUserToAddRows = false;
            this.dgwAccounts.AllowUserToDeleteRows = false;
            this.dgwAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccounts.Location = new System.Drawing.Point(13, 47);
            this.dgwAccounts.Name = "dgwAccounts";
            this.dgwAccounts.ReadOnly = true;
            this.dgwAccounts.Size = new System.Drawing.Size(559, 181);
            this.dgwAccounts.TabIndex = 15;
            this.dgwAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellContentClick);
            this.dgwAccounts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_RowEnter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID number :";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgwAccounts);
            this.Controls.Add(this.txbIDNumber);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbIDNumber;
        private System.Windows.Forms.DataGridView dgwAccounts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}