using System;

namespace HotelCalifornia.Domain.Entities
{
    public class Room
    {
        public Room(Guid id, bool isAvailable, string number)
        {            
            Id = id;
            IsAvailable = isAvailable;
            Number = number;
        }

        // Empty ctor for EF. =/
        protected Room()
        {            
        }

        public Guid Id { get; private set; }
        public bool IsAvailable { get; private set; }
        public string Number { get; private set; }        
    }
}