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

    public struct Customer
    {
        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }
        
        public int CustomerId;
        public string FirstName;
        public string LastName;
    }
}
