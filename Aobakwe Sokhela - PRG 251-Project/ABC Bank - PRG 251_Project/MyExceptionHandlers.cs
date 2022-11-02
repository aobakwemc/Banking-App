using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bank___PRG_251_Project
{
    class MyExceptionHandlers:Exception
    {
        public MyExceptionHandlers():base("Incorrect Username or Pin. Please try again.")
        {
            //give a default msg in the base parenthesis
        }
        public MyExceptionHandlers(string msg):base(msg)
        {
            //returns current exception
        }
        public MyExceptionHandlers(string msg, Exception innerException):base(msg, innerException)
        {
            //returns inner exception

        }
    }
}
