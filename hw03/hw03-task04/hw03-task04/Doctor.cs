using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    public class Doctor : Person
    {
        // properties
        public int DoctorId { get; }
        public string Specialization { get; }

        // constructor
        public Doctor(string name, int age, string nationalId, int doctorId, string specialization)
           : base(name, age, nationalId)
        {
            if (doctorId <= 0)
                throw new ArgumentOutOfRangeException(nameof(doctorId), doctorId, "Doctor ID must be positive.");

            if (string.IsNullOrWhiteSpace(specialization))
                throw new ArgumentException("Specialization must not be empty.", nameof(specialization));

            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string disease)
        {
            ArgumentNullException.ThrowIfNull(patient);
            patient.AddToMedicalHistory(disease);
        }

        public override string GetDetails() => $"{base.GetDetails()}\n DoctorId: {DoctorId}, Specialization: {Specialization}";
    }
}
