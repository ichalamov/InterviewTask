using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

            List<String> EmployeeList = new List<String>();
            EmployeeList.Add("1");
            EmployeeList.Add("Jenny");
            EmployeeList.Add("24");
            EmployeeList.Add("2");
            EmployeeList.Add("Anna");
            EmployeeList.Add("33");
            EmployeeList.Add("3");
            EmployeeList.Add("Josh");
            EmployeeList.Add("29");
            EmployeeList.Add("4");
            EmployeeList.Add("George,Michael");
            EmployeeList.Add("41");

            Assert.AreEqual("CSV file successfully generated.", Program.GenerateToCsv(EmployeeList, sep));  
            
        }
    }
}