using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository iReservationRepository;

        public ReservationService(IReservationRepository iReservationRepository)
        {
            this.iReservationRepository = iReservationRepository;
        }

        public Reservation GetById(int id)
        {
            return this.iReservationRepository.GetById(id);
        }
    }
}
