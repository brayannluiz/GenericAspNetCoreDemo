namespace HotelCalifornia.Domain.Entities
{
    public class Reservation
    {
        public Reservation(Client client, Room room)
        {
            Client = client;    
            Room = room;
        }   

        // Empty ctor for EF. =/
        protected Reservation()
        {
        }     

        public Client Client { get; private set; }
        public Room Room { get; private set; }
    }
}