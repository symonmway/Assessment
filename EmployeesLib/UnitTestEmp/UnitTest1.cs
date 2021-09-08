using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeApp;
using EmployeesLib;
namespace UnitTestEmp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmployee()
        {
            Employees Employees = new Employees();
            string result = Employees.ReadAndValidate();

            //Assert
            Assert.AreEqual(result, "Validation ok");

        }

        public void Budget()
        {
            //Arrange
            string Manager = "Employee2";
            int budget;
            Employees Employees = new Employees();

            //Act
              budget = Employees.Budget(Manager);

            //Assert
            Assert.AreEqual(budget, 1000);

        }
    }
}
