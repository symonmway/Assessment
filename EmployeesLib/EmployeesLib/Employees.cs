using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeesLib
{
    public  class Employees
    {
        static void Main(string[] args)
        {
           //using ReadAndValidate _ReadAndValidate = new ReadAndValidate();
           // ReadAndValidate();
           // Console.ReadLine();
        }


       public string ReadAndValidate()
        {
            var lines = File.ReadAllLines("Employees.csv");
            var list = new List<EmployeeList>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 2)
                {
                    var contact = new EmployeeList() { EmpID = values[0], ManID = values[1], Amnt= values[2] };
                    list.Add(contact);
                }
            }

            // Create lists with the CSV data
            var Emplist = new List<string>();
            var Manlist = new List<string>();
            var Amntlist = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] rowData = lines[i].Split(',');
                Emplist.Add(rowData[0]);
                Manlist.Add(rowData[1]);
                Amntlist.Add(rowData[2]);
            }

            //The salaries in the CSV are valid integer numbers.
            int intTest;
            for (int i = 0; i < Amntlist.Count; i++)
            {
                if  (!(int.TryParse(Amntlist[i], out intTest)))
                {
                    return Amntlist[i] + " is not a numbers";
                }
            }

            //One employee does not report to more than one manager.
            string tempName;
            for (int i = 0; i < Emplist.Count; i++)
            {
                tempName = Emplist[i];
                Emplist.Remove(Emplist[i]);

                if (Emplist.Contains(tempName))
                {
                    return Emplist[i] + "  is duplicated in Employee list";
                }
            }

            //There is only one CEO, i.e. only one employee with no manager.
             bool blceo = false;
            for (int i = 0; i < Manlist.Count; i++)
            {
                if (Manlist[i] == "")
                {
                    blceo = true;
                    Manlist.Remove(Manlist[i]);
                    for (int x = 0; x < Manlist.Count; x++)
                    { 
                        if (Manlist[x] == "")
                        {
                            return Manlist[i] + " is registered as CEO multiple times";
                        }
                    }
                }
            }

            if (blceo == false)
            {
                return "There is no CEO found";
            }


            //There is no cross refference
            string tempEmplo, tempMan;
            for (int i = 0; i < Emplist.Count; i++)
            {
                if (Emplist[i] != "")
                {
                    tempEmplo = Emplist[i];
                    tempMan = Manlist[i];
                    for (int x = 0; x < Emplist.Count; x++)
                    {
                        if (Emplist[x] == tempMan && Manlist[x] == tempEmplo)
                        {
                            return Emplist[i] + "  manager are not registered as employee";
                        }
                    }
                }
            }


            //There is no manager that is not an employee
                for (int i = 0; i < Manlist.Count; i++)
            {
                if (Emplist.Any(str => str.Contains(Manlist[i])))
                {
                    return Manlist[i] + "  manager are not registered as employee";
                }
            }

                
     

            return "Validation ok";
}
 
        public  int Budget(string man)
        {
            int intBudget = 0;
            var lines = File.ReadAllLines("Employees.csv");
 
            // loop every manager in the list and check if the exist as employee
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 3)
                {
                    if ((man == values[0]) | (man == values[1]))
                    {
                        intBudget += int.Parse(values[2]);
                    }
                }
            }
            return intBudget;
        }







        public class EmployeeList
    {
        public string EmpID { get; set; }
        public string ManID { get; set; }
        public string Amnt { get; set; }
    }
}
}