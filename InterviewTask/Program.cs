using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask
{
    public static class Program
    {
        static void Main(string[] args)
        {
            char sep = ',';
             
            List <Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee { ID = 1, Name = "Jenny", Age = 24 });
            EmployeeList.Add(new Employee { ID = 2, Name = "Anna", Age = 33 });
            EmployeeList.Add(new Employee { ID = 3, Name = "Josh", Age = 29 });
            EmployeeList.Add(new Employee { ID = 4, Name = "George,Michael", Age = 41 });


            Console.WriteLine(GenerateToCsv(EmployeeList, sep));
            Console.ReadLine();

        }

        public static string GenerateToCsv(this IList items, char separator)
        {
            string result = "CSV file successfully generated.";
            StringBuilder sb = new StringBuilder();
            // Make the header row 
            sb.AppendLine("ID" + separator + "Name" + separator + "Age");

            foreach (Employee item in items)
            {
                if (item.Name.Contains(separator.ToString())) {
                    // enclosing character(double quotes) must be used when required, 
                    // such as when the delimiter appears in a field.   

                    StringBuilder builder = new StringBuilder(item.Name);
                    builder.Replace(item.Name, "\""+item.Name+"\"");

                    item.Name = builder.ToString();
                }
                sb.AppendLine(item.getAsCSVRow(separator));
            }
            // Do not follow the last record in a file with a carriage return.
            string output = sb.ToString().TrimEnd('\r', '\n');

            Console.WriteLine(output);

            try
            {
                System.IO.File.WriteAllText(
               "result.csv",
                output);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Cannot save the .csv file... :\r\n\r\n" + ex.Message);
                result = "Something went wrong...";    
            }


            return result;
        }

        }

}