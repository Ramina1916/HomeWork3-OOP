using System;
using System.Collections.Generic;
using System.Text;
using hw03_task04.Strategies;

namespace hw03_task04
{
    public class Doctor : Person
    {
        // strategy field 
        private readonly IDiagnoseStrategy _diagnoseStrategy;

        // properties
        public int DoctorId { get; }
        public string Specialization { get; }

        // constructor
        public Doctor(string name, int age, string nationalId, int doctorId, string specialization, IDiagnoseStrategy strategy)
           : base(name, age, nationalId)
        {
            if (doctorId <= 0)
                throw new ArgumentOutOfRangeException(nameof(doctorId), doctorId, "Doctor ID must be positive.");

            if (string.IsNullOrWhiteSpace(specialization))
                throw new ArgumentException("Specialization must not be empty.", nameof(specialization));
            
            ArgumentNullException.ThrowIfNull(strategy);

            _diagnoseStrategy = strategy;
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string disease)
        {
            ArgumentNullException.ThrowIfNull(patient);

            if (string.IsNullOrWhiteSpace(disease))
                throw new ArgumentException("Disease must not be empty.", nameof(disease));

            patient.AddToMedicalHistory(_diagnoseStrategy.Diagnose(disease));
        }

        public override string GetDetails() => $"{base.GetDetails()}\n DoctorId: {DoctorId}, Specialization: {Specialization}";
    }
}
