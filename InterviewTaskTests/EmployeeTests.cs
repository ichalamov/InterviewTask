using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InterviewTask.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        char separator = ',';  
        Employee test = new Employee { ID = 1, Name = "Test1", Age = 24 };  

        [TestMethod()]
        public void getAsCSVRowTest_Contains_TheSeparator()
        {
            Assert.IsTrue(test.getAsCSVRow(separator).Contains(separator));
        }
    }
}