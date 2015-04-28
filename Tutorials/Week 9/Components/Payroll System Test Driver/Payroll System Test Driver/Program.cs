using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Class_Library;
using PayRoll_System;






namespace Payroll_System_Test_Driver {
    class Program {

        static PayRollSystem payRoll = new PayRollSystem();

        static void Main(string[] args) {

            payRoll.AddEmployee(new Casual_Employee("Joe Bloggs", 1, 25.5, 10));
            payRoll.AddEmployee(new Salaried_Employee("Bill Smith", 5, 850));
            payRoll.AddEmployee(new Salaried_Employee("Mary Jones", 3, 1000));
            payRoll.AddEmployee(new Casual_Employee("Cathy Brown", 2, 30.0, 25));
            payRoll.AddEmployee(new Commission_Employee("Kerryn Woods", 7, 1000, 0.1));
            payRoll.AddEmployee(new Base_Plus_Commissioned_Employee("Base Test", 8, 1000, 0.1, 1000));
    

            PrintEmployeeList();
            Console.WriteLine();
          
            PrintPayList();
            Console.WriteLine();
            Console.ReadLine();
        }


        static void PrintEmployeeList() {
           
            Employee employee;
            payRoll.OpenPayRoll();
            Console.WriteLine("\n\tEmployee List \n");
            employee = payRoll.ReadNextEmployee();
            while (employee != null) {
          
                Console.WriteLine(employee.GetDetails());
                employee = payRoll.ReadNextEmployee();
            }
            payRoll.ClosePayRoll();

        }//end PrintEmployeeList


        static void PrintPayList() {
            Employee employee;// = new Employee();
            payRoll.OpenPayRoll();

            Console.WriteLine("\n\tPay List\n");
            employee = payRoll.ReadNextEmployee();
            while (employee != null) {
            
                Console.WriteLine(employee.Name + "\t"
                    + employee.CalculatePay().ToString("C"));
                employee = payRoll.ReadNextEmployee();

            }
            payRoll.ClosePayRoll();
        }
    }
}
