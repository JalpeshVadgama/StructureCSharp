namespace StructureConstructors
{
    public struct Customer
    {
        #region Fields
        
        public int CustomerId;
        public string FirstName;
        public string LastName;
        
        #endregion 
        
        #region Constructor
        
        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }
        
        #endregion
    }
}