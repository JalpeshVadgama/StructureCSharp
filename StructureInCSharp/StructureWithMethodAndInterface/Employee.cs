using System;

namespace StructureWithMethodAndInterface
{
    public struct Employee : IPrintable
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing Employee");
            Console.WriteLine(EmployeeId);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}