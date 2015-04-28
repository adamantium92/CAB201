using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library {
    /// <summary>
    /// Salaried_Employee class extends Employee
    /// </summary>
    public class Salaried_Employee : Employee {

        private double weeklySalary;

        // Constructor - calls super constructor to set common fields
        public Salaried_Employee(string name, int empNum, 
            double salary) : base(name, empNum) {

                weeklySalary = salary;
        }

       
        /// <summary>
        /// Pay for salaried employee is a fixed weekly amount
        /// </summary>
        /// <returns></returns>
        public override double CalculatePay() {
            return weeklySalary;
        }

    
        /// <summary>
        /// returns a string giving all the details of this employee
        /// </summary>
        /// <returns></returns>
        public override string GetDetails() {
            return base.GetDetails() + "Salaried Employee\n"
                + "Weekly Salary:\t\t" + weeklySalary.ToString("C") +"\n";
        }


    } //end class Salaried_Employee
}
