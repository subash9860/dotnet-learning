namespace HelloWord
{
    class Employee
    {
        // this are field members
        string firstName;
        string lastName;
        int salary;

        // This are property
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // this is short hand for this properties
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        // Constructor
        public Employee(string firstName, string lastName, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
    }
}