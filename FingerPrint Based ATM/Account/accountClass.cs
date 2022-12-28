using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FingerPrint_Based_ATM.Database;
namespace FingerPrint_Based_ATM.Account
{
    public class accountClass
    {
        public class transaction
        {
            /// <summary>
            /// Withdraw Method 
            /// </summary>
            /// <param name="amount"></param>
            /// <param name="balance"></param>
            /// <returns></returns>
          
            public bool Withdraw(double amount, double balance)
            {
                bool check = false;
                if (balance >= amount)
                {
                    check = true;
                    balance -= amount;
                }
                if (!check)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


            public double Deposit(double amount, double balance)
            {
                balance += amount;
                return balance;
            }
            /*
            public  double Tranfer()
            {
                return;
            }*/

        }
    }
}