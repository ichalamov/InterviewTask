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

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3); 
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            //Console.WriteLine(GenerateToCsv(numbers, sep));
            Console.WriteLine(GenerateToCsv(EmployeeList, sep));
            Console.ReadLine();

        }

        public static string GenerateToCsv(this IList items, char separator)
        {
            string result = "CSV file successfully generated.";
            StringBuilder sb = new StringBuilder();
            // Make the header row 
            sb.AppendLine("ID" + separator + "Name" + separator + "Age");

            for (int i=0, j=1; i < items.Count; i++,j++)  
            { 
                StringBuilder builder = new StringBuilder(items[i].ToString());

                if (items[i].ToString().Contains(separator.ToString()))
                {
                    // enclosing character(double quotes) must be used when required, 
                    // such as when the delimiter appears in a field.   

                    builder.Replace(items[i].ToString(), "\"" + items[i].ToString() + "\"");
                }
                builder.Append(separator);
                sb.Append(builder);
                if (j % 3 == 0)
                {
                    sb.Append('\r');
                    sb.Append('\n');
                }
 
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