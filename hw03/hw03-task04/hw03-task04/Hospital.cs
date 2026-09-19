using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public List<Room> Rooms { get; } = new List<Room>();

        public void AddDoctor(Doctor doctor)
        {
            ArgumentNullException.ThrowIfNull(doctor);
            Doctors.Add(doctor);
        }

        public void AddRoom(Room room)
        {
            ArgumentNullException.ThrowIfNull(room);

            foreach (Room existingRoom in Rooms)
            {
                if (existingRoom.RoomNumber == room.RoomNumber)
                    throw new ArgumentException($"Room {room.RoomNumber} already exists.", nameof(room));
            }

            Rooms.Add(room);
        }

        // Check wether a patient is already admitted in any room 
        private bool IsAdmitted(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Contains(patient))
                    return true;
            }
            return false;
        }

        // Admit a patient to the first available room. If all rooms are full, return false.
        public bool AdmitPatient(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient);

            if (IsAdmitted(patient))
                throw new InvalidOperationException($"Patient {patient.PatientId} is already admitted.");

            foreach (Room room in Rooms)
            {
                // Check IsFull first. Exceptions mark unusual cases, not normal flow.
                if (room.IsFull)
                    continue;

                room.AssignPatient(patient);
                return true;
            }
            Console.WriteLine("No room has free capacity. The patient is not admitted.");
            return false;
        }

        // Discharge a patient from the hospital. If the patient is not found in any room, return false.
        public bool DischargePatient(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient);
            foreach (Room room in Rooms)
            {
                if (room.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    return true;
                }
            }
            Console.WriteLine($"Patient {patient.PatientId} is not admitted in any room.");
            return false;
        }

        // Singleton pattern implementation
        public static Hospital Instance { get; } = new Hospital();
        private Hospital() { } // A private constructor ensures that the class cannot be instantiated from outside, enforcing the singleton pattern.
    }
}
