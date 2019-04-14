namespace BankSystem
{
    partial class frmAccount
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
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbIDNumber = new System.Windows.Forms.TextBox();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblIDNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(95, 31);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(154, 20);
            this.txbFirstName.TabIndex = 0;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(95, 66);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(154, 20);
            this.txbLastName.TabIndex = 1;
            // 
            // txbIDNumber
            // 
            this.txbIDNumber.Location = new System.Drawing.Point(95, 100);
            this.txbIDNumber.Name = "txbIDNumber";
            this.txbIDNumber.Size = new System.Drawing.Size(154, 20);
            this.txbIDNumber.TabIndex = 2;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(95, 136);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(154, 20);
            this.txbAdress.TabIndex = 3;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(95, 171);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(154, 21);
            this.cbxCity.TabIndex = 4;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(28, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First name :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(28, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last name :";
            // 
            // LblIDNumber
            // 
            this.LblIDNumber.AutoSize = true;
            this.LblIDNumber.Location = new System.Drawing.Point(28, 107);
            this.LblIDNumber.Name = "LblIDNumber";
            this.LblIDNumber.Size = new System.Drawing.Size(64, 13);
            this.LblIDNumber.TabIndex = 7;
            this.LblIDNumber.Text = "ID Number :";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(28, 143);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 179);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City :";
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.Location = new System.Drawing.Point(95, 216);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(154, 23);
            this.btnInsertClient.TabIndex = 10;
            this.btnInsertClient.Text = "Create Client";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.btnInsertClient);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.LblIDNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.txbAdress);
            this.Controls.Add(this.txbIDNumber);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbIDNumber;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblIDNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnInsertClient;
    }
}