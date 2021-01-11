using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //https://github.com/nathanmalone99/Nathan-Malone-Exam my github link
   
    public abstract class Account : IComparable
    {

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public int InterestDate { get; set; }


        //abstarct method
        public abstract double CalculateInterest();
        public abstract int CompareTo(object obj);

        //output format
        public override string ToString()
        {
            return $"{AccountNumber},{LastName.ToUpper()}, {FirstName}";
        }

        public double Deposit()
        {

        }

        public double Withdraw()
        {

        }


    }
        //Cuurent Account class 
        public class CurrentAccount : Account
        {
            public double InterestRate = .03;

            //overriding calculate interest method to calculate interest 
            public override double CalculateInterest()
            {
                return Balance * InterestRate;
            }

            public override int CompareTo(object obj)
            {
                Account that = obj as Account;
                return this.InterestDate.CompareTo(that.InterestDate);
            }
        }

        public class SavingsAccount : Account
        {
            public double InterestRate = .06;


            //overriding calculate interest method to calculate interest 
            public override double CalculateInterest()
            {
                return Balance * InterestRate;
            }

            public override int CompareTo(object obj)
            {
                Account that = obj as Account;
                return this.InterestDate.CompareTo(that.InterestDate);
            }
        }
}
