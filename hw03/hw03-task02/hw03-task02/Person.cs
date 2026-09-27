using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task02
{
    public class Person
    {
        // class properties
        public string Name { get; set; }
        public int Age { get; set; }

        // class constructor
        public Person(string name, int age)
        {
            // validate arguments of constructor
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("{0} can not be null or empty, buddy!", nameof(name)); // nameof is used to get the name of the parameter as a string
            else if (age <= 0)
                throw new ArgumentOutOfRangeException("{0} can not be less than or equal to zero, buddy!", nameof(age));
            else if (age > 120)
                throw new ArgumentOutOfRangeException("{0} can not be greater than 120, buddy!", nameof(age));
            Name = name;
            Age = age;
        }

        // mark a virtual so derived classes can override
        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
