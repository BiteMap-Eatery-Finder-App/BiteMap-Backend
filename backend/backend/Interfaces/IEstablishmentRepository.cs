using backend.Models;

namespace backend.Interfaces
{
    public interface IEstablishmentRepository
    {
        public Establishment GetById(int id);
        public List<Establishment> GetAll();
    }
}
