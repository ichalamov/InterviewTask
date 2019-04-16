namespace InterviewTask
{
    public class Employee
    {
        public Employee()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string getAsCSVRow(char s)
        {
            return this.ID.ToString() + s + this.Name + s + this.Age.ToString();
        }
    }

}