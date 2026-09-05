using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task02
{
    public class Student : Person
    {
        // properties
        public string StudentID { get; set; }
        public string Major { get; set; }

        // constructor
        public Student(string name, int age, string studentId, string major) : base(name, age)
        {
            if(studentId == null || major == null)
                throw new ArgumentNullException("StudentID and Major can not be null, buddy!");
            else
            {
                StudentID = studentId;
                Major = major;
            }
        }

        public override string GetDetails()
        {
            // override the base class method to include student-specific details
            return $"{base.GetDetails()}, StudentID: {StudentID}, Major: {Major}";
        }
    }
}
