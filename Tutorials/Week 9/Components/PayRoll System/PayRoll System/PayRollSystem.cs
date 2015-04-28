using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Class_Library;




namespace PayRoll_System
{
    /// <summary>
    ///  
    /// class to model a simple Payroll System
    ///  which uses Employee class 
    ///  
    /// Author: MiKe Roggenkamp
    /// Date:   April 2014
    ///  
    /// </summary>
    public class PayRollSystem {
        
        private const int CLOSED = -1;

        // list of employee of the company
        private List <Employee> employees;

        private int next;
        
        // initialize the list of employees and employee count
        public PayRollSystem() {
            employees = new List<Employee>();
        }

        
        /// <summary>
        /// Add another employee to the Payroll System
        /// </summary>
        /// <param name="employee"> employee != null</param>
        public void AddEmployee(Employee employee) {
            employees.Add (employee);
        } 


        /// <summary>
        /// 
        /// </summary>
        public int Count {
            get {
                return employees.Count;
            }
        }


        /// <summary>
        /// 
        /// Returns the employee with the specified employee number if the employee exists
        ///     otherwise returns null.
        /// 
        /// </summary>
        /// <param name="employeeNumber"> employee number of the wanted employee</param>
        /// <returns></returns>
        public Employee GetEmployee(int employeeNumber) {
            for (int i = 0; i < Count; i++) {
                if (employees[i].EmployeeNumber == employeeNumber) {
                    return employees[i];
                }
            }
            return null;
        }


        /// <summary>
        /// Opens the Pay Roll for sequential access
        /// </summary>
        public void OpenPayRoll(){
            next = 0;
        }//


        /// <summary>
        /// Reads the next employee on the Pay Roll
        ///  if at the end of the Pay Roll returns null.
        ///  
        /// Throws an Invlaid Operation Exception if Pay Roll is not opened.
        /// </summary>
        /// <returns> next employee in the Pay Roll 
        ///             or null if at the end of the Pay Roll</returns>
        public Employee ReadNextEmployee() {
            Employee employee = null;
            
            if (next == CLOSED) {
                throw new InvalidOperationException("PayRoll data is not opened.\n Neeed to call OpenPayRoll before attempting to access PayRoll.");
            }


            if (next != Count) {
                employee = employees[next];
                next++;
            }

            return employee;
        } 


        /// <summary>
        /// Closes Pay Roll for sequential access
        /// </summary>
        public void ClosePayRoll() {
            next = CLOSED;

        }


    }//end class
}
