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
        public Customer(int customerId, string firstName,string lastName)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
