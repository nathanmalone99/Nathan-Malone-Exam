using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public abstract class Account
    {

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double balance { get; set; }
        public int InterestDate { get; set; }


        //abstarct method
        public abstract double CalculateInterset();
        


    }
}
