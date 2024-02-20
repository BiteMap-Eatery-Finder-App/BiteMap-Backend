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
            List<Establishment> establishments = _context.Establishments.ToList();
            return establishments.Find(establishment => establishment.Id == id);
        }

        public List<Establishment> GetAll()
        {
            return _context.Establishments.ToList();
        }
        
    }
}
