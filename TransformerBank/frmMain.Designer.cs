namespace TransformerBank
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
            this.components = new System.ComponentModel.Container();
            this.txbCardID = new System.Windows.Forms.TextBox();
            this.txbPIN = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbCardId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txbCardID
            // 
            this.txbCardID.Location = new System.Drawing.Point(106, 252);
            this.txbCardID.Name = "txbCardID";
            this.txbCardID.Size = new System.Drawing.Size(100, 20);
            this.txbCardID.TabIndex = 0;
            this.txbCardID.TextChanged += new System.EventHandler(this.txbCardID_TextChanged);
            // 
            // txbPIN
            // 
            this.txbPIN.Location = new System.Drawing.Point(286, 252);
            this.txbPIN.Name = "txbPIN";
            this.txbPIN.Size = new System.Drawing.Size(100, 20);
            this.txbPIN.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(190, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbCardId
            // 
            this.lbCardId.AutoSize = true;
            this.lbCardId.Location = new System.Drawing.Point(45, 255);
            this.lbCardId.Name = "lbCardId";
            this.lbCardId.Size = new System.Drawing.Size(46, 13);
            this.lbCardId.TabIndex = 3;
            this.lbCardId.Text = "CardID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PIN :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(456, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCardId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPIN);
            this.Controls.Add(this.txbCardID);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCardID;
        private System.Windows.Forms.TextBox txbPIN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbCardId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

