using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Bank___PRG_251_Project
{
    public partial class frmAccHolder : Form
    {
        AccHolder objAccHolder = new AccHolder();

        /*Contents of frmWelcome need to be passed into this account
         *I will declare a string field to accept username, object of type form to accept frmWelcome as a parameter,
         *and a constructor to accept the frmWelcome as a parameter*/
        private Form mainForm;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        //The constructor that accepts a username and main form as a parameter:
        public frmAccHolder(string uName, Form passMyForm)
        {
            InitializeComponent();
            this.userName = uName;
            this.mainForm = passMyForm;
            /*Why these two parameters? The two things we are sending/passing over to this form are
             the username from the previous form and the previous form itself.*/
        }
        public frmAccHolder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAccHolder_Load(object sender, EventArgs e)
        {
            txtMinBalance.Text = Convert.ToString(objAccHolder.MinBal);
            lstAccDetails.Items.Add($"Name \t\tSurname \t\tBalance \t\tAccount Type \tAccount Number");
            //Show user's balance upon form load.
            foreach (var item in frmWelcome.myUsers)
            {
                if (item.Name == UserName)
                {
                    lstAccDetails.Items.Add(item);
                }
            }
            //txtBalance.Text = Convert.ToString(objAccHolder.MinBal);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        

        private void btnPrintInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            
            foreach (var item in frmWelcome.myUsers)
            {
                if (item.Name==UserName)
                {
                    objAccHolder.DepositFunds(Convert.ToDouble(txtAmt.Text));
                    item.AccBal = item.AccBal + Convert.ToDouble(txtAmt.Text);
                    lstAccDetails.Items.Add(item);
                }
            }
            
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            
            foreach (var item in frmWelcome.myUsers)
            {
                if (item.Name == UserName)
                {
                    objAccHolder.WithdrawFunds(Convert.ToDouble(txtAmt.Text));
                    item.AccBal = item.AccBal - Convert.ToDouble(txtAmt.Text);
                    lstAccDetails.Items.Add(item); //I assume this overrides the form load display after withdraw click event
                }
            }
            
        }

        private void frmAccHolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Goodbye {userName}.");
            //if (this.mainForm != null)
            //{
            //    mainForm.ShowDialog(); //wonder which form will show from "mainForm"
            //}
        }
    }
}
