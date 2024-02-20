using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class EstablishmentService
    {
        private readonly IEstablishmentRepository iEstablishmentRepository;
        public EstablishmentService(IEstablishmentRepository iEstablishmentRepository)
        {
            this.iEstablishmentRepository = iEstablishmentRepository;
        }

        public List<Establishment> GetAll()
        {
            return this.iEstablishmentRepository.GetAll();
        }

        public Establishment GetById(int id)
        {
            return this.iEstablishmentRepository.GetById(id);
        }
    }
}
