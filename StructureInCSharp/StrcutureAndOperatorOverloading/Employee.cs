namespace StrcutureAndOperatorOverloading
{
    public struct Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.EmployeeId.GetHashCode();
                result = result * 23 + ((FirstName != null) ? this.FirstName.GetHashCode() : 0);
                result = result * 23 + ((LastName != null) ? this.LastName.GetHashCode() : 0);
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                return this.Equal((Employee)obj);
            }
            return false;
        }

        private bool Equal(Employee empoyee)
        {
            return (this.EmployeeId == empoyee.EmployeeId) &&
                (this.FirstName == empoyee.FirstName) &&
                (this.LastName == empoyee.LastName);
        }
    }
}