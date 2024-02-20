using backend.Models;

namespace backend.Interfaces
{
    public interface IUserRepository
    {
        public User GetById(int id);
        public User GetByUsername(string username);
        public User GetByEmail(string email);
        public List<User> GetAll();
    }
}
