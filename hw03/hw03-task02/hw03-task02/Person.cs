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
            if (name == null)
                throw new ArgumentNullException("Name can not be null, buddy!");
            else if (age <= 0)
                throw new ArgumentOutOfRangeException("Age can not be less than or equal to zero, buddy!");
            else if (age > 120)
                throw new ArgumentOutOfRangeException("You are no spring chicken, buddy!");
            else
            {
                Name = name;
                Age = age;
            }
        }

        // mark a virtual so derived classes can override
        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
