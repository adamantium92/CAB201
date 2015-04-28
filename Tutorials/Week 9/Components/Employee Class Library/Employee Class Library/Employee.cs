using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library {
    /// <summary>
    /// Abstract Class to represent an Employee
    /// An employee has:
    ///  Name
    ///  Employee Number
    ///  
    ///    
    ///  Author:  Diane Corney
    ///  Date:    August, 2005
    ///   
    /// Modification:
    /// 
    /// Author:   Mike Roggenkamp
    /// Date:     April 2014
    /// 
    /// Changed sub classes to 
    ///     Salaried Emploree
    ///     Casual Employee
    ///     
    /// </summary>
    public abstract class Employee {
        private string name;
        private int employeeNumber;
       

        // Constructor
        public Employee(string name, int empNum) {
            this.name = name;
            this.employeeNumber = empNum;
        }
        

        // Properties

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int EmployeeNumber {
            get {
                return employeeNumber;
            }
            
        }

 
        /// <summary>
        /// Calculate the pay for an employee for a fortnight
        /// </summary>
        /// <returns></returns>
        public abstract double CalculatePay();


        /// <summary>
        /// returns a formatted string containing all the employee common details
        /// </summary>
        /// <returns></returns>
        public virtual string GetDetails() {
            return ("Name:\t\t\t" + Name + "\nEmployeeNumber:\t\t"
                + EmployeeNumber.ToString("00000") + "\nEmployed as:\t\t");
        }
    }//end classs Employee
}


