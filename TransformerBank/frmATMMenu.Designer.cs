namespace TransformerBank
{
    partial class frmATMMenu
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
            this.btnStateAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.lblStateAcount = new System.Windows.Forms.Label();
            this.dgwDataAccount = new System.Windows.Forms.DataGridView();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.lblCustom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStateAccount
            // 
            this.btnStateAccount.Location = new System.Drawing.Point(35, 25);
            this.btnStateAccount.Name = "btnStateAccount";
            this.btnStateAccount.Size = new System.Drawing.Size(135, 94);
            this.btnStateAccount.TabIndex = 0;
            this.btnStateAccount.Text = "STATE ACCOUNT";
            this.btnStateAccount.UseVisualStyleBackColor = true;
            this.btnStateAccount.Click += new System.EventHandler(this.btnStateAccount_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(35, 125);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(135, 94);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "WITHDRAWAL";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(35, 225);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(135, 94);
            this.btnLogOff.TabIndex = 2;
            this.btnLogOff.Text = "LOG OFF";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // lblStateAcount
            // 
            this.lblStateAcount.AutoSize = true;
            this.lblStateAcount.Location = new System.Drawing.Point(334, 166);
            this.lblStateAcount.Name = "lblStateAcount";
            this.lblStateAcount.Size = new System.Drawing.Size(75, 13);
            this.lblStateAcount.TabIndex = 3;
            this.lblStateAcount.Text = "State Account";
            this.lblStateAcount.Visible = false;
            // 
            // dgwDataAccount
            // 
            this.dgwDataAccount.AllowUserToAddRows = false;
            this.dgwDataAccount.AllowUserToDeleteRows = false;
            this.dgwDataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDataAccount.Location = new System.Drawing.Point(280, 54);
            this.dgwDataAccount.Name = "dgwDataAccount";
            this.dgwDataAccount.ReadOnly = true;
            this.dgwDataAccount.Size = new System.Drawing.Size(242, 65);
            this.dgwDataAccount.TabIndex = 4;
            this.dgwDataAccount.Visible = false;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(337, 292);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 20);
            this.txbAmount.TabIndex = 5;
            this.txbAmount.Visible = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(474, 283);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(135, 36);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "WITHDRAWAL";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(261, 225);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 36);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5€";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(305, 225);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(41, 36);
            this.btn10.TabIndex = 8;
            this.btn10.Text = "10€";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Visible = false;
            this.btn10.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(352, 225);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(40, 36);
            this.btn20.TabIndex = 9;
            this.btn20.Text = "20€";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Visible = false;
            this.btn20.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(398, 225);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(48, 36);
            this.btn50.TabIndex = 10;
            this.btn50.Text = "50€";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Visible = false;
            this.btn50.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(452, 225);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(48, 36);
            this.btn100.TabIndex = 11;
            this.btn100.Text = "100€";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Visible = false;
            this.btn100.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(506, 225);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(50, 36);
            this.btn200.TabIndex = 12;
            this.btn200.Text = "200€";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Visible = false;
            this.btn200.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(562, 225);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(47, 36);
            this.btn500.TabIndex = 13;
            this.btn500.Text = "500€";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Visible = false;
            this.btn500.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(261, 298);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(48, 13);
            this.lblCustom.TabIndex = 15;
            this.lblCustom.Text = "Custom :";
            this.lblCustom.Visible = false;
            // 
            // frmATMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 357);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.dgwDataAccount);
            this.Controls.Add(this.lblStateAcount);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnStateAccount);
            this.Name = "frmATMMenu";
            this.Text = "frmATMMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStateAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label lblStateAcount;
        private System.Windows.Forms.DataGridView dgwDataAccount;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Label lblCustom;
    }
}