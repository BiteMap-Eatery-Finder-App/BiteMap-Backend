using backend.Data;
using backend.Interfaces;
using backend.Models;
using System.Collections.Immutable;

namespace backend.Repositories
{
    public class EstablishmentRepository : IEstablishmentRepository
    {
        private readonly AppDbContext _context;
        public EstablishmentRepository(AppDbContext context) 
        {
            _context = context;
        }

        public Establishment GetById(int id)
        {
            return _context.Establishments.Where(establishment => establishment.Id == id).FirstOrDefault();
        }

        public ICollection<Establishment> GetAll()
        {
            return _context.Establishments.ToList();
        }
        
    }
}
