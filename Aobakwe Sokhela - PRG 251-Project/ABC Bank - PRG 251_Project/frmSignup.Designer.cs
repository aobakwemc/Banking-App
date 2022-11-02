
namespace ABC_Bank___PRG_251_Project
{
    partial class frmSignup
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
            this.lblSignupHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblStartBal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.txtStartBal = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.dgvNewUser = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accBalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minBalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accHolderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignupHeading
            // 
            this.lblSignupHeading.AutoSize = true;
            this.lblSignupHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignupHeading.ForeColor = System.Drawing.Color.Teal;
            this.lblSignupHeading.Location = new System.Drawing.Point(207, 19);
            this.lblSignupHeading.Name = "lblSignupHeading";
            this.lblSignupHeading.Size = new System.Drawing.Size(373, 31);
            this.lblSignupHeading.TabIndex = 1;
            this.lblSignupHeading.Text = "Great, let\'s get you signed up!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(41, 103);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Location = new System.Drawing.Point(41, 136);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(89, 13);
            this.lblAccType.TabIndex = 5;
            this.lblAccType.Text = "Type of Account:";
            // 
            // lblStartBal
            // 
            this.lblStartBal.AutoSize = true;
            this.lblStartBal.Location = new System.Drawing.Point(41, 196);
            this.lblStartBal.Name = "lblStartBal";
            this.lblStartBal.Size = new System.Drawing.Size(74, 13);
            this.lblStartBal.TabIndex = 6;
            this.lblStartBal.Text = "Intial Balance:";
            this.lblStartBal.Click += new System.EventHandler(this.lblStartBal_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(255, 103);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Cheque Account",
            "Savings Account"});
            this.cmbAccType.Location = new System.Drawing.Point(255, 133);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(121, 21);
            this.cmbAccType.TabIndex = 9;
            this.cmbAccType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtStartBal
            // 
            this.txtStartBal.Location = new System.Drawing.Point(255, 196);
            this.txtStartBal.Name = "txtStartBal";
            this.txtStartBal.Size = new System.Drawing.Size(100, 20);
            this.txtStartBal.TabIndex = 10;
            this.txtStartBal.TextChanged += new System.EventHandler(this.txtStartBal_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(44, 272);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 31);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtAccNum
            // 
            this.txtAccNum.Enabled = false;
            this.txtAccNum.Location = new System.Drawing.Point(255, 236);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(100, 20);
            this.txtAccNum.TabIndex = 12;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Location = new System.Drawing.Point(41, 236);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(90, 13);
            this.lblAccNum.TabIndex = 13;
            this.lblAccNum.Text = "Account Number:";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(44, 166);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(55, 13);
            this.lblPin.TabIndex = 14;
            this.lblPin.Text = "4-digit pin:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(255, 166);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 15;
            // 
            // dgvNewUser
            // 
            this.dgvNewUser.AutoGenerateColumns = false;
            this.dgvNewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.accBalDataGridViewTextBoxColumn,
            this.minBalDataGridViewTextBoxColumn,
            this.accNumDataGridViewTextBoxColumn,
            this.typeOfAccDataGridViewTextBoxColumn});
            this.dgvNewUser.DataSource = this.accHolderBindingSource;
            this.dgvNewUser.Location = new System.Drawing.Point(396, 70);
            this.dgvNewUser.Name = "dgvNewUser";
            this.dgvNewUser.Size = new System.Drawing.Size(506, 63);
            this.dgvNewUser.TabIndex = 16;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // accBalDataGridViewTextBoxColumn
            // 
            this.accBalDataGridViewTextBoxColumn.DataPropertyName = "AccBal";
            this.accBalDataGridViewTextBoxColumn.HeaderText = "AccBal";
            this.accBalDataGridViewTextBoxColumn.Name = "accBalDataGridViewTextBoxColumn";
            // 
            // minBalDataGridViewTextBoxColumn
            // 
            this.minBalDataGridViewTextBoxColumn.DataPropertyName = "MinBal";
            this.minBalDataGridViewTextBoxColumn.HeaderText = "MinBal";
            this.minBalDataGridViewTextBoxColumn.Name = "minBalDataGridViewTextBoxColumn";
            // 
            // accNumDataGridViewTextBoxColumn
            // 
            this.accNumDataGridViewTextBoxColumn.DataPropertyName = "AccNum";
            this.accNumDataGridViewTextBoxColumn.HeaderText = "AccNum";
            this.accNumDataGridViewTextBoxColumn.Name = "accNumDataGridViewTextBoxColumn";
            // 
            // typeOfAccDataGridViewTextBoxColumn
            // 
            this.typeOfAccDataGridViewTextBoxColumn.DataPropertyName = "TypeOfAcc";
            this.typeOfAccDataGridViewTextBoxColumn.HeaderText = "TypeOfAcc";
            this.typeOfAccDataGridViewTextBoxColumn.Name = "typeOfAccDataGridViewTextBoxColumn";
            // 
            // accHolderBindingSource
            // 
            this.accHolderBindingSource.DataSource = typeof(ABC_Bank___PRG_251_Project.AccHolder);
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dgvNewUser);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtStartBal);
            this.Controls.Add(this.cmbAccType);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStartBal);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSignupHeading);
            this.Name = "frmSignup";
            this.Text = "Register Details";
            this.Load += new System.EventHandler(this.frmSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accHolderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSignupHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblStartBal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.TextBox txtStartBal;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.DataGridView dgvNewUser;
        private System.Windows.Forms.BindingSource accHolderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accBalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minBalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfAccDataGridViewTextBoxColumn;
    }
}