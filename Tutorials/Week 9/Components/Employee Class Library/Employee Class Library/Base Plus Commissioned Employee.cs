using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library
{
    public class Base_Plus_Commissioned_Employee : Commission_Employee
    {
        private double salary;
        private double grossSales;
        private double commRate;

        public Base_Plus_Commissioned_Employee(string name, int empNum, double sales, double rate, double baseSalary) : base(name, empNum, sales, rate)
        {
            salary = baseSalary;
            grossSales = sales;
            commRate = rate;
        }
    
        private double baseSalary{ 
             get {
                return salary;
             }
            set {
                if (value > 0) {
                    salary = value;
                } else {
                    throw new ArgumentOutOfRangeException("Base salary: ", value, "salary must be greater than 0");
                }
            }
        }

        public override double CalculatePay()
        {
            return baseSalary + (commRate * grossSales);
        }


        public override string GetDetails()
        {
            return base.GetDetails() + "Commissioned Employee\n"
               + "Base Salary:\t" + baseSalary.ToString("C")               
               + "Commission rate:\t" + commRate.ToString("C")
               + "\nGross sales per week:\t\t"
               + grossSales.ToString("F2") + "\n";
        }

        }
}
