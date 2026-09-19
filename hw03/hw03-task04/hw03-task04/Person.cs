using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    public class Person
    {
        // properties
        public string Name { get; } // only constructor can set the name, making it immutable after creation
        public int Age { get; }
        public string NationalId { get; }

        
        // constructor
        public Person(string name, int age, string nationalId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name must not be empty.", nameof(name));
            // 120 -> Max age
            if (age < 0 || age > 120)
                throw new ArgumentOutOfRangeException(nameof(age), age, $"Age must be between 0 and 120.");

            if (string.IsNullOrWhiteSpace(nationalId) || !nationalId.All(char.IsAsciiDigit))
                throw new ArgumentException("National ID must contain digits only.", nameof(nationalId));

            Name = name;
            Age = age;
            NationalId = nationalId;
        }

        public virtual string GetDetails() => $"Name: {Name}, Age: {Age}, NationalId: {NationalId}";
    }
}