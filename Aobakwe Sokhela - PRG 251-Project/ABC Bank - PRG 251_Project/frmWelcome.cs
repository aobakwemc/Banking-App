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
    public partial class frmWelcome : Form
    {
        internal static List<AccHolder> myUsers = new List<AccHolder>();
        AccHolder objAccHolder = new AccHolder(); //object for AccHolder class to access members
        frmAccHolder objFrmAcc = new frmAccHolder(); //object for form frmAccHolder to ShowDialog/open the form from this form.
        frmSignup objFrmSignup = new frmSignup(); //object for form frmAccHolder to ShowDialog/open the form from this form.
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //load a static list with sample users.
            myUsers = new List<AccHolder> 
            {
                new AccHolder{Name = "Anthony", Surname = "Konrad", TypeOfAcc = "Chq Account", AccBal=3500, AccNum=4678, Pin="0007"},
                new AccHolder{Name = "Samantha", Surname = "Benkamp", TypeOfAcc = "Chq Account", AccBal=800, AccNum=5000, Pin="0004"},
                new AccHolder{Name = "Julian", Surname = "Zamo", TypeOfAcc = "Svngs Account", AccBal=30400, AccNum=2704, Pin="5050"},
                new AccHolder{Name = "Timothy", Surname = "Sulliman", TypeOfAcc = "Chq Account", AccBal=14000, AccNum=3018, Pin="1010"},
                new AccHolder{Name = "John", Surname = "Kenny", TypeOfAcc = "Svngs Account", AccBal=1800, AccNum=2480, Pin="0001"}
                //Remember NOT TO print the Pin when displaying.
            };
        }

        private void btnLogin_Click(object sender, EventArgs e) //Will need exception handling for unknwon users.
        {
            foreach (var item in myUsers)
            {
                //objAccHolder.UnknownUser(txtUsername.Text, txtPin.Text, item);
                objAccHolder.AccLogin(txtUsername.Text, txtPin.Text, item); //getting user credentials in comparison to the list.
                
                if (txtUsername.Text == item.Name && txtPin.Text == item.Pin)
                {
                    //show acc holder form. 
                    objFrmAcc = new frmAccHolder(item.Name, this); //pass given username and frmWelcome (this) to frmAccHolder
                    objFrmAcc.ShowDialog();

                    //Now we mute/hide frmWelcome after opening frmAccHolder
                    this.Hide();
                }
            }

            //I would specifically want to close this form after button click
            //Available transactions: deposit, withdraw, check balance, print account information.
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            objFrmSignup.ShowDialog();
            //I would specifically want to close this form after button click
            //Open a sign up form - frmSignup.ShowDialog();
            //Sign up form details: Open cheque account OR open savings account.
            //Further forms are opened for each account option.
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
