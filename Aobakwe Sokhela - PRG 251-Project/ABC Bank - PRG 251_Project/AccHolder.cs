using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bank___PRG_251_Project
{
    internal class AccHolder
    {
        /*Essential properties for an account holder;
         *the properties will be included in the static list and give information on an account holder.*/
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private double accBal;

        public double AccBal
        {
            get { return accBal; }
            set { accBal = value; }
        }

        private string pin;

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        private double minBal;

        public double MinBal //define this in the default constructor (mainly used by Cheque Acc)
        {
            get { return minBal; }
            set { minBal = value; }
        }

        private int accNum;

        public int AccNum
        {
            get { return accNum; }
            set 
            {
                accNum = value;
                Random giveAccNum = new Random(); //dedclaring an object of Random
                accNum = giveAccNum.Next(1000, 5000); //declaring AccNum to receive a random number in the range of 1000 to 5000.
                 
                //I think I should set/hardcode an AccNum for sample users, then auto-generate an AccNum for registering users.
            }
        }
        private string typeOfAcc;

        public string TypeOfAcc
        {
            get { return typeOfAcc; }
            set { typeOfAcc = value; }
        }
        public AccHolder()
        {
            //default constructor
            MinBal = 500;
        }
        public AccHolder(string uName, string uSurname, double uBal, string uPin, double uMinBal, int uAccNum, string uAccType)
        {
            this.Name = uName;
            this.Surname = uSurname;
            this.AccBal = uBal;
            this.Pin = uPin;
            this.MinBal = uMinBal;
            this.AccNum = uAccNum;
            this.TypeOfAcc = uAccType;
            //Not sure about AccNum being here, but it sure has to be used publicly - especially for displaying.
        }
        protected internal void UnknownUser(string textName, string textPin, AccHolder accHolder)
        {
            if (textName != accHolder.Name)
            {
                System.Windows.Forms.MessageBox.Show("Incorrect name. Please try again.");
                //throw new MyExceptionHandlers("Incorrect name. Please try again.");
            }
            if (textPin != accHolder.Pin)
            {
                System.Windows.Forms.MessageBox.Show("Incorrect pin. Please try again.");
                //throw new MyExceptionHandlers("Incorrect pin. Please try again.");
            }
          
        }
        //Define a method that accepts username and password as parameters
        protected internal void AccLogin(string accUser, string accPin, AccHolder accHolder)
        {
            //Parameters: accepting username textbox, accepting password textbox and a list as an object (foreach iteration).
            //Comparing the two textboxes against defined users in List.
        }
        //Defining deposit/withdrawal methods - later add them to delegate for deposit/withdrawal event
        protected internal double DepositFunds(double depositAmt)
        {
            return AccBal = AccBal + depositAmt;
        }
        protected internal void WithdrawFunds(double withdrawAmt)
        {
            try
            {
                if (MinBal > withdrawAmt)
                {
                    AccBal = AccBal - withdrawAmt;
                }
            }
            catch (Exception)
            {

                throw new MyExceptionHandlers("Minimum balance exceeded!");
            }
        }
        public override string ToString()
        {
            return($"{Name}\t\t{Surname}\t\t{AccBal}\t\t{TypeOfAcc}\t{AccNum}");
        }
    }
}
