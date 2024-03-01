using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            List<User> users = _context.Users.ToList();
            return users.Find(user => user.Id == id);
        }

        public User GetByUsername(string username)
        {
            List<User> users = _context.Users.ToList();
            return users.Find(user => user.Username == username);
        }

        public User GetByEmail(string email)
        {
            List<User> users = _context.Users.ToList();
            return users.Find(user => user.Email == email);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }
    }
}
