using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace InterviewTask.Tests
{
    [TestClass()]
    public class ProgramTests
    {   

        [TestMethod()]
        public void GenerateToCsvTest()
        {
            char sep = ',';

            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee { ID = 1, Name = "Test1", Age = 24 });
            EmployeeList.Add(new Employee { ID = 2, Name = "Test2", Age = 33 });
            EmployeeList.Add(new Employee { ID = 3, Name = "Test3", Age = 29 });

            Assert.AreEqual("CSV file successfully generated.", Program.GenerateToCsv(EmployeeList, sep));  
            
        }
    }
}