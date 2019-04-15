namespace BankSystem
{
    partial class frmTransaction
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
            this.txbVS = new System.Windows.Forms.TextBox();
            this.txbSS = new System.Windows.Forms.TextBox();
            this.txbKS = new System.Windows.Forms.TextBox();
            this.lbVS = new System.Windows.Forms.Label();
            this.lbSS = new System.Windows.Forms.Label();
            this.lbKS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgwSource = new System.Windows.Forms.DataGridView();
            this.dgwDestination = new System.Windows.Forms.DataGridView();
            this.lbSource = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // txbVS
            // 
            this.txbVS.Location = new System.Drawing.Point(151, 201);
            this.txbVS.Name = "txbVS";
            this.txbVS.Size = new System.Drawing.Size(100, 20);
            this.txbVS.TabIndex = 7;
            // 
            // txbSS
            // 
            this.txbSS.Location = new System.Drawing.Point(297, 201);
            this.txbSS.Name = "txbSS";
            this.txbSS.Size = new System.Drawing.Size(100, 20);
            this.txbSS.TabIndex = 8;
            // 
            // txbKS
            // 
            this.txbKS.Location = new System.Drawing.Point(443, 201);
            this.txbKS.Name = "txbKS";
            this.txbKS.Size = new System.Drawing.Size(100, 20);
            this.txbKS.TabIndex = 9;
            // 
            // lbVS
            // 
            this.lbVS.AutoSize = true;
            this.lbVS.Location = new System.Drawing.Point(124, 204);
            this.lbVS.Name = "lbVS";
            this.lbVS.Size = new System.Drawing.Size(21, 13);
            this.lbVS.TabIndex = 10;
            this.lbVS.Text = "VS";
            // 
            // lbSS
            // 
            this.lbSS.AutoSize = true;
            this.lbSS.Location = new System.Drawing.Point(270, 204);
            this.lbSS.Name = "lbSS";
            this.lbSS.Size = new System.Drawing.Size(21, 13);
            this.lbSS.TabIndex = 11;
            this.lbSS.Text = "SS";
            // 
            // lbKS
            // 
            this.lbKS.AutoSize = true;
            this.lbKS.Location = new System.Drawing.Point(416, 204);
            this.lbKS.Name = "lbKS";
            this.lbKS.Size = new System.Drawing.Size(21, 13);
            this.lbKS.TabIndex = 12;
            this.lbKS.Text = "KS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount :";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(208, 152);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 20);
            this.txbAmount.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(371, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgwSource
            // 
            this.dgwSource.AllowUserToAddRows = false;
            this.dgwSource.AllowUserToDeleteRows = false;
            this.dgwSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSource.Location = new System.Drawing.Point(42, 28);
            this.dgwSource.Name = "dgwSource";
            this.dgwSource.ReadOnly = true;
            this.dgwSource.Size = new System.Drawing.Size(266, 91);
            this.dgwSource.TabIndex = 17;
            this.dgwSource.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSource_RowEnter);
            // 
            // dgwDestination
            // 
            this.dgwDestination.AllowUserToAddRows = false;
            this.dgwDestination.AllowUserToDeleteRows = false;
            this.dgwDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDestination.Location = new System.Drawing.Point(335, 28);
            this.dgwDestination.Name = "dgwDestination";
            this.dgwDestination.ReadOnly = true;
            this.dgwDestination.Size = new System.Drawing.Size(262, 91);
            this.dgwDestination.TabIndex = 18;
            this.dgwDestination.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDestination_RowEnter);
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Location = new System.Drawing.Point(42, 9);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(90, 13);
            this.lbSource.TabIndex = 19;
            this.lbSource.Text = "Source Account :";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(332, 9);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(109, 13);
            this.lbDestination.TabIndex = 20;
            this.lbDestination.Text = "Destination Account :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 248);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.dgwDestination);
            this.Controls.Add(this.dgwSource);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKS);
            this.Controls.Add(this.lbSS);
            this.Controls.Add(this.lbVS);
            this.Controls.Add(this.txbKS);
            this.Controls.Add(this.txbSS);
            this.Controls.Add(this.txbVS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgwSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbVS;
        private System.Windows.Forms.TextBox txbSS;
        private System.Windows.Forms.TextBox txbKS;
        private System.Windows.Forms.Label lbVS;
        private System.Windows.Forms.Label lbSS;
        private System.Windows.Forms.Label lbKS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgwSource;
        private System.Windows.Forms.DataGridView dgwDestination;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Timer timer1;
    }
}