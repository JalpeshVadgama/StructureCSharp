using System;

namespace StructureConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Jalpesh", "Vagdama");

            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
        }
    }
}
