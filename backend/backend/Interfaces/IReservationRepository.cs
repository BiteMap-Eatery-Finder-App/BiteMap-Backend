using backend.Models;

namespace backend.Interfaces
{
    public interface IReservationRepository
    {
        public Reservation GetById(int id);
    }
}
