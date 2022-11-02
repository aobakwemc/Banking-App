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
    public partial class frmSignup : Form
    {
        AccHolder myAccHolder = new AccHolder();
        static BindingSource myBinder = new BindingSource(); //this is how to update the datagrid
        public frmSignup()
        {
            InitializeComponent();
        }
        private Form mainForm;
        private string name;

        public string UserName
        {
            get { return name; }
            set { name = value; }
        }

        //Constructor to receive frmWelcome.cs and its contents
        public frmSignup(string uName, Form passMyForm)
        {
            InitializeComponent();
            this.UserName = uName;
            this.mainForm = passMyForm;
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            frmWelcome.myUsers = new List<AccHolder>(); //loading the form to accept new users.
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStartBal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStartBal_Click(object sender, EventArgs e)
        {
            //throw exceptions for non-monetary value.
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //txtName.Text = myAccHolder.Name;
            //txtSurname.Text = myAccHolder.Surname;
            //cmbAccType.SelectedItem = myAccHolder.TypeOfAcc;
            //txtPin.Text = myAccHolder.Pin;
            //txtStartBal.Text = Convert.ToString(myAccHolder.AccBal);
            //Convert.ToDouble(myAccHolder.AccBal);
            //txtAccNum.Text = Convert.ToString(myAccHolder.AccNum);
            //Convert.ToInt32(myAccHolder.AccNum);
            ////Now I have received user input.

            if (Convert.ToDouble(txtStartBal.Text)<500) //exception would suffice.
            {
                MessageBox.Show("Initial balance should be above 500.");
            }

            frmWelcome.myUsers = new List<AccHolder>
            {
                new AccHolder{Name=txtName.Text, Surname=txtSurname.Text, TypeOfAcc=Convert.ToString(cmbAccType.SelectedItem),AccBal=Convert.ToDouble(txtStartBal.Text), AccNum=myAccHolder.AccNum, Pin = txtPin.Text}
            };
            //Now that a user has registered, they are an AccHolder.
            myBinder.DataSource = frmWelcome.myUsers; //binding the list to the datasource.
            dgvNewUser.DataSource = myBinder; //making the datagridview bind to the datasource.
        }

        private void lstDisplayNewUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
