using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    public class Patient : Person
    {
        // properties
        public string PatientId { get; } // unique identifier for the patient
        public List<string> MedicalHistory { get; private set;} // make it 'private set' to prevent external modification, but allow adding to the list through a method
        
        public Patient(string name, int age, string nationalId, string patientId) : base(name, age, nationalId)
        {
           if(string.IsNullOrEmpty(patientId) || !patientId.All(char.IsDigit))
                throw new ArgumentException("Patient ID must contain digits only.", nameof(patientId));
            PatientId = patientId;
            // Create an empty list for this patient's medical history.
            MedicalHistory = new List<string>();
        }


        public void AddToMedicalHistory(string disease)
        {
            if (string.IsNullOrWhiteSpace(disease))
                throw new ArgumentException("Medical disease must not be empty.", nameof(disease));
            MedicalHistory.Add(disease);
        }

        public override string GetDetails() => $"{base.GetDetails()}\n PatientId: {PatientId}, History: {string.Join(", ", MedicalHistory)}"; // string.Join(", ", MedicalHistory) : Concatenates the members of a collection of type string, using the specified separator between each member.
    }
}
