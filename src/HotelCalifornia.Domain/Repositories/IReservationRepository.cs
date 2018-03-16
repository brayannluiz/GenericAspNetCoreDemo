using HotelCalifornia.Domain.Entities;

namespace HotelCalifornia.Domain.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
         Reservation Insert(Reservation reservation); 
    }
}