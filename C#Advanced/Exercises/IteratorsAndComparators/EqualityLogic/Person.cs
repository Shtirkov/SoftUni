namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            var result = Name.CompareTo(other?.Name);

            if (result == 0)
            {
                result = Age.CompareTo(other?.Age);
            }

            return result;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person)
            {
                var other = obj as Person;
                return Name == other?.Name && Age == other.Age;
            }

            return false;
        }
    }
}
