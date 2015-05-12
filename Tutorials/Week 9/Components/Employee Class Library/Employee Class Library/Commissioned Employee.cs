using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library
{
    public class Commission_Employee : Employee
    {
        private double commGrossSales;
        private double commissionRate;

        // Constructor - calls super constructor to set common fields
        public Commission_Employee(string name, int empNum, double sales, double rate) : base(name, empNum )
        {
            commGrossSales = sales;
            commissionRate = rate;
        }
       
        private double grossSales
        { 
             get {
                return commGrossSales;
            }
            set {
                if (value > 0) {
                    commGrossSales = value;
                } else {
                    throw new ArgumentOutOfRangeException("Number of sales: ", value, "sales must be greater than 0");
                }
            }
        }

        public override double CalculatePay()
        {
            return grossSales * commissionRate;
        }


        public override string GetDetails()
        {
            return base.GetDetails() + "Commissioned Employee\n"
               + "Commission rate:\t" + commissionRate.ToString("C")
               + "\nGross sales per week:\t\t"
               + grossSales.ToString("F2") + "\n";
        }
    }
}
