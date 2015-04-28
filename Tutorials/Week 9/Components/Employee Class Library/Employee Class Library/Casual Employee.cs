using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library {
    /// <summary>
    /// 
    /// Casual Employee class extends Employee
    /// 
    /// </summary>
    public class Casual_Employee : Employee {

        private double wage;
        private double hoursWorked;

        // Constructor - calls super constructor to set common fields
        public Casual_Employee(string name, int empNum, double wageRate, 
            double hours) : base(name, empNum ) {

            Wage = wageRate;
            HoursWorked = hours;
        }


        // Properties

        public double Wage {
            get {
                return wage;
            }

            set {
                if (value > 0) {
                    wage = value;
                } else {

                    throw new ArgumentOutOfRangeException("Wage of ", value, "wage must be greater than 0");
                }
            }
        }

        public double HoursWorked {
            get {
                return hoursWorked;
            }
            set {
                if (value > 0) {
                    hoursWorked = value;
                } else {

                    throw new ArgumentOutOfRangeException("Hours worked of ", value, "hours worked must be greater than 0");
                }
            }
        }

        
        /// <summary>
        /// A casual employee is paid on an hourly payrate times number of hours worked
        /// </summary>
        /// <returns></returns>
        public override double CalculatePay() {
            return wage * hoursWorked;
        }

       
        /// <summary>
        /// returns a string containing all the details for this employee
        /// </summary>
        /// <returns></returns>
        public override string GetDetails() {
            return base.GetDetails() + "Casual Employee\n"
                + "Hourly Pay Rate:\t" + wage.ToString("C") 
                + "\nHours Per Week:\t\t" 
                + hoursWorked.ToString("F2") + "\n";
        }


    }//end class
}
