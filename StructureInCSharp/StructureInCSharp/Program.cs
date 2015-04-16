using System;
namespace StructureInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee 
            {
                Id=1,
                FirstName="Jalpesh",
                LastName="Vadgama",
                Designation="Project Manager",
            };

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
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
