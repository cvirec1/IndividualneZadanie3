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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFailedClient = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblOverLimit = new System.Windows.Forms.Label();
            this.txbIBAN = new System.Windows.Forms.TextBox();
            this.txbOverLimit = new System.Windows.Forms.TextBox();
            this.btnAccountInsert = new System.Windows.Forms.Button();
            this.btnIBAN = new System.Windows.Forms.Button();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAccountFailed = new System.Windows.Forms.Label();
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
            this.cbxCity.Items.AddRange(new object[] {
            "Ocova",
            "Zilina",
            "Kosice",
            "Poprad",
            "Bratislava",
            "Trencin",
            "Presov",
            "Senica"});
            this.cbxCity.Location = new System.Drawing.Point(95, 179);
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
            this.btnInsertClient.Location = new System.Drawing.Point(95, 219);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(154, 23);
            this.btnInsertClient.TabIndex = 10;
            this.btnInsertClient.Text = "Create Client";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFailedClient
            // 
            this.lblFailedClient.AutoSize = true;
            this.lblFailedClient.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFailedClient.Location = new System.Drawing.Point(39, 9);
            this.lblFailedClient.Name = "lblFailedClient";
            this.lblFailedClient.Size = new System.Drawing.Size(210, 13);
            this.lblFailedClient.TabIndex = 13;
            this.lblFailedClient.Text = "Insert new client failed. Please insert again.";
            this.lblFailedClient.Visible = false;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(353, 21);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(53, 13);
            this.lblClientID.TabIndex = 14;
            this.lblClientID.Text = "Client ID :";
            this.lblClientID.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(477, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 15;
            this.lblClient.Text = "client id";
            this.lblClient.Visible = false;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(356, 72);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(38, 13);
            this.lblIBAN.TabIndex = 16;
            this.lblIBAN.Text = "IBAN :";
            this.lblIBAN.Visible = false;
            // 
            // lblOverLimit
            // 
            this.lblOverLimit.AutoSize = true;
            this.lblOverLimit.Location = new System.Drawing.Point(359, 179);
            this.lblOverLimit.Name = "lblOverLimit";
            this.lblOverLimit.Size = new System.Drawing.Size(82, 13);
            this.lblOverLimit.TabIndex = 17;
            this.lblOverLimit.Text = "OverFlow Limit :";
            this.lblOverLimit.Visible = false;
            // 
            // txbIBAN
            // 
            this.txbIBAN.Enabled = false;
            this.txbIBAN.Location = new System.Drawing.Point(402, 69);
            this.txbIBAN.Name = "txbIBAN";
            this.txbIBAN.Size = new System.Drawing.Size(190, 20);
            this.txbIBAN.TabIndex = 18;
            this.txbIBAN.Visible = false;
            // 
            // txbOverLimit
            // 
            this.txbOverLimit.Location = new System.Drawing.Point(456, 172);
            this.txbOverLimit.Name = "txbOverLimit";
            this.txbOverLimit.Size = new System.Drawing.Size(100, 20);
            this.txbOverLimit.TabIndex = 19;
            this.txbOverLimit.Visible = false;
            // 
            // btnAccountInsert
            // 
            this.btnAccountInsert.Location = new System.Drawing.Point(402, 204);
            this.btnAccountInsert.Name = "btnAccountInsert";
            this.btnAccountInsert.Size = new System.Drawing.Size(154, 23);
            this.btnAccountInsert.TabIndex = 20;
            this.btnAccountInsert.Text = "Create Account";
            this.btnAccountInsert.UseVisualStyleBackColor = true;
            this.btnAccountInsert.Visible = false;
            this.btnAccountInsert.Click += new System.EventHandler(this.btnAccountInsert_Click);
            // 
            // btnIBAN
            // 
            this.btnIBAN.Location = new System.Drawing.Point(456, 97);
            this.btnIBAN.Name = "btnIBAN";
            this.btnIBAN.Size = new System.Drawing.Size(100, 23);
            this.btnIBAN.TabIndex = 21;
            this.btnIBAN.Text = "Generate IBAN";
            this.btnIBAN.UseVisualStyleBackColor = true;
            this.btnIBAN.Visible = false;
            this.btnIBAN.Click += new System.EventHandler(this.btnIBAN_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(456, 140);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 20);
            this.txbAmount.TabIndex = 23;
            this.txbAmount.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(359, 147);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Amount :";
            this.lblAmount.Visible = false;
            // 
            // lblAccountFailed
            // 
            this.lblAccountFailed.AutoSize = true;
            this.lblAccountFailed.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAccountFailed.Location = new System.Drawing.Point(372, 8);
            this.lblAccountFailed.Name = "lblAccountFailed";
            this.lblAccountFailed.Size = new System.Drawing.Size(201, 13);
            this.lblAccountFailed.TabIndex = 24;
            this.lblAccountFailed.Text = "Insert account failed. Please insert again.";
            this.lblAccountFailed.Visible = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 324);
            this.Controls.Add(this.lblAccountFailed);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnIBAN);
            this.Controls.Add(this.btnAccountInsert);
            this.Controls.Add(this.txbOverLimit);
            this.Controls.Add(this.txbIBAN);
            this.Controls.Add(this.lblOverLimit);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblFailedClient);
            this.Controls.Add(this.btnCancel);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFailedClient;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblOverLimit;
        private System.Windows.Forms.TextBox txbIBAN;
        private System.Windows.Forms.TextBox txbOverLimit;
        private System.Windows.Forms.Button btnAccountInsert;
        private System.Windows.Forms.Button btnIBAN;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAccountFailed;
    }
}