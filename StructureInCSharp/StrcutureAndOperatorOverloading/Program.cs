using System;

namespace StrcutureAndOperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                EmployeeId=1,
                FirstName="Jalpesh",
                LastName="Vadgama"
            };

            Employee anotherEmployee = new Employee
            {
                EmployeeId=2,
                FirstName="Vishal",
                LastName="Vadgama"
            };

            bool isEqual = employee.Equals(anotherEmployee);
            Console.WriteLine("Checking equal operator with Structure");
            Console.WriteLine(isEqual);
        }
    }
}
