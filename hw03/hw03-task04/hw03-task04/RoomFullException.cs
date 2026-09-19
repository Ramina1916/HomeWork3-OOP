using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task04
{
    // create a custom exception class when a room is full
    public class RoomFullException : Exception
    {
        public int RoomNumber { get; }
        public RoomFullException(int roomNumber) : base($"Room {roomNumber} is full. Cannot assign more patients.") // exception method
        {
            RoomNumber = roomNumber;
        }
    }
}
