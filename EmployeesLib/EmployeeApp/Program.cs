using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesLib;
namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees Employees = new Employees();
           string result= Employees.ReadAndValidate();
            Console.WriteLine(result);
            Console.ReadKey();

            //prompt the user to take in the Manager ID 
            Console.WriteLine("Enter a managerID Number to get his budget");
            // read the the user input
            string number = Console.ReadLine();
            //compute the budget
            Console.WriteLine("Managers budget is \n{0}", Employees.Budget(number));
            Console.ReadKey();
        }



    }
}
