using Moq;

namespace HotelCalifornia.Tests.RepositoryFacts
{
    public class Reservation
    {
        public class CreateReservation 
        {
            public void WillThrowIfRoomIsNotAvailable() 
            {
                var repository = new Mock<IReservationRepository>();                
            }
        }
    }
}