using System;

namespace HotelCalifornia.Domain.Entities
{
    public class Client
    {        
        public Client(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        // Empty ctor for EF. =/
        protected Client()
        {
        }
        
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}