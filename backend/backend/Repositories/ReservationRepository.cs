using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _context;

        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }

        public Reservation GetById(int id)
        {
            List<Reservation> reservations = _context.Reservations.ToList();
            return reservations.Find(reservation => reservation.Id == id);
        }
    }
}
