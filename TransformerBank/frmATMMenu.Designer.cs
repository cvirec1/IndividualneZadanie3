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
            // frmATMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 357);
            this.Controls.Add(this.lblStateAcount);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnStateAccount);
            this.Name = "frmATMMenu";
            this.Text = "frmATMMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStateAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label lblStateAcount;
    }
}