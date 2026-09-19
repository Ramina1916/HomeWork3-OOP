using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task02
{
    public class Professor : Person
    {
        // properties
        public string ProfessorId { get; set; }
        public string Subject { get; set; }

        // constructor
        public Professor(string name, int age, string professorId, string subject) : base(name, age)
        {
            if (professorId == null || subject == null) 
                throw new ArgumentNullException("ProfessorId and Subject can not be null, buddy!");
            else
            {
                ProfessorId = professorId;
                Subject = subject;
            }
        }

        public override string GetDetails()
        {
            // override the base class method to include professor-specific details
            return $"{base.GetDetails()}, ProfessorId: {ProfessorId}, Subject: {Subject}";
        }

    }
}
