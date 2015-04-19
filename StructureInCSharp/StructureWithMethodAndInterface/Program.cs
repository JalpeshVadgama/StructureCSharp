
namespace StructureWithMethodAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable employee = new Employee
            {
                EmployeeId=1,
                FirstName="Jalpesh",
                LastName="Vadgama"
            };

            employee.Print();
        }
    }
}
