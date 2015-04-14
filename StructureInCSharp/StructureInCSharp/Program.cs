using System;
namespace StructureInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Jalpesh";
            employee.LastName = "Vadgama";
            employee.Designation = "Project Manager";
            employee.Id = 1;

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.FirstName);
            Console.Write(employee.LastName);
            Console.WriteLine(employee.Designation);
        }
    }

    struct Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}
