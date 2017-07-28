using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBankBroward
{
    class BankAccount
    {
        public string CardNumber;
        public string Pin;
        public string SavingsAccount;
        public string CheckingsAccount;
        public string ClientName;
        public string Address;
        public string Email;
        public string SSN;
        public double SavingsBalance;
        public double CheckingsBalance;


        public BankAccount(string cn, string pin, string sa, string ca, string cna, string ad, string e, string ssn, double sbal, double cbal)
        {
            this.CardNumber = cn;
            this.Pin = pin;
            this.SavingsAccount = sa;
            this.CheckingsAccount = ca;
            this.ClientName = cna;
            this.Address = ad;
            this.Email = e;
            this.SSN = ssn;
            this.SavingsBalance = sbal;
            this.CheckingsBalance = cbal;
        }

       



 //public string CardNumber { get; set; } 



    }
}
