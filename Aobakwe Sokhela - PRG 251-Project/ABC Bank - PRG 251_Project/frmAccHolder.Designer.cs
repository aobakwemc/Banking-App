
namespace ABC_Bank___PRG_251_Project
{
    partial class frmAccHolder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtMinBalance = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblMinBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccDetails = new System.Windows.Forms.Label();
            this.lstAccDetails = new System.Windows.Forms.ListBox();
            this.accHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accHolderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(241, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your dashboard!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(151, 124);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(100, 20);
            this.txtAmt.TabIndex = 7;
            // 
            // txtMinBalance
            // 
            this.txtMinBalance.Enabled = false;
            this.txtMinBalance.Location = new System.Drawing.Point(151, 73);
            this.txtMinBalance.Name = "txtMinBalance";
            this.txtMinBalance.Size = new System.Drawing.Size(100, 20);
            this.txtMinBalance.TabIndex = 6;
            this.txtMinBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(32, 124);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(43, 13);
            this.lblAmt.TabIndex = 5;
            this.lblAmt.Text = "Amount";
            // 
            // lblMinBalance
            // 
            this.lblMinBalance.AutoSize = true;
            this.lblMinBalance.Location = new System.Drawing.Point(32, 73);
            this.lblMinBalance.Name = "lblMinBalance";
            this.lblMinBalance.Size = new System.Drawing.Size(90, 13);
            this.lblMinBalance.TabIndex = 4;
            this.lblMinBalance.Text = "Minimum Balance";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(156, 214);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click_1);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(35, 214);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click_1);
            // 
            // lblAccDetails
            // 
            this.lblAccDetails.AutoSize = true;
            this.lblAccDetails.Location = new System.Drawing.Point(517, 80);
            this.lblAccDetails.Name = "lblAccDetails";
            this.lblAccDetails.Size = new System.Drawing.Size(82, 13);
            this.lblAccDetails.TabIndex = 12;
            this.lblAccDetails.Text = "Account Details";
            // 
            // lstAccDetails
            // 
            this.lstAccDetails.FormattingEnabled = true;
            this.lstAccDetails.Location = new System.Drawing.Point(358, 103);
            this.lstAccDetails.Name = "lstAccDetails";
            this.lstAccDetails.Size = new System.Drawing.Size(509, 134);
            this.lstAccDetails.TabIndex = 11;
            // 
            // accHolderBindingSource
            // 
            this.accHolderBindingSource.DataSource = typeof(ABC_Bank___PRG_251_Project.AccHolder);
            // 
            // frmAccHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.lblAccDetails);
            this.Controls.Add(this.lstAccDetails);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtMinBalance);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblMinBalance);
            this.Controls.Add(this.label1);
            this.Name = "frmAccHolder";
            this.Text = "Account Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccHolder_FormClosing);
            this.Load += new System.EventHandler(this.frmAccHolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accHolderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accHolderBindingSource;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtMinBalance;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblMinBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAccDetails;
        private System.Windows.Forms.ListBox lstAccDetails;
    }
}