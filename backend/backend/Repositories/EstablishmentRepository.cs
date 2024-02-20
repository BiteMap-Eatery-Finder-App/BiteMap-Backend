using backend.Data;
using backend.Interfaces;
using backend.Models;
using System.Collections.Immutable;

namespace backend.Repositories
{
    public class EstablishmentRepository : IEstablishmentRepository
    {
        protected readonly IConfiguration _configuration;
        public AppDbContext _context;
        public EstablishmentRepository() 
        { 
            _context = new AppDbContext(_configuration);
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
