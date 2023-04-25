namespace PersonsInfo
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

        private const string _invalidFirstNameErrorMsg = "First name cannot contain fewer than 3 symbols!";
        private const string _invalidLastNameErrorMsg = "Last name cannot contain fewer than 3 symbols!";
        private const string _invalidAgeErrorMsg = "Age cannot be zero or a negative integer!";
        private const string _invalidSalaryErrorMsg = "Salary cannot be less than 460 leva!";


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get => _firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(_invalidFirstNameErrorMsg);
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(_invalidLastNameErrorMsg);
                }
                _lastName = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(_invalidAgeErrorMsg);
                }
                _age = value;
            }
        }

        public decimal Salary
        {
            get => _salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException(_invalidSalaryErrorMsg);
                }
                _salary = value;
            }
        }

        public override string ToString() => $"{FirstName} {LastName} receives {Salary:f2} leva.";

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += Salary * (percentage / 200);
            }
            else
            {
                Salary += Salary * (percentage / 100);
            }
        }
    }
}
