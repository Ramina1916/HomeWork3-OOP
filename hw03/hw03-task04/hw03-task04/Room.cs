using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    public class Room
    {
        public List<Patient> Patients { get; } = new List<Patient>();
        // constructors
        public int RoomNumber { get; }
        public int Capacity { get; }

        // Check if the room is full
        public bool IsFull => Patients.Count >= Capacity;

        public Room(int roomNumber, int capacity)
        {
            if (roomNumber <= 0)
                throw new ArgumentOutOfRangeException(nameof(roomNumber), roomNumber, "Room number must be positive.");

            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), capacity, "Capacity must be positive.");

            RoomNumber = roomNumber;
            Capacity = capacity;
        }
        public void AssignPatient(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient);
            if (Patients.Contains(patient))
                throw new InvalidOperationException($"Patient {patient.PatientId} is already in room {RoomNumber}.");
            if (IsFull)
                throw new RoomFullException(RoomNumber);
            

            Patients.Add(patient);
        }

        // Check whether a patient is in the room
        public bool Contains(Patient patient) => Patients.Contains(patient);

    }
}
