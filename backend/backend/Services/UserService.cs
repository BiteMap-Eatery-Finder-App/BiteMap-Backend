using backend.Interfaces;
using backend.Models;

namespace backend.Services
{
    public class UserService
    {
        private readonly IUserRepository iUserRepository;

        public UserService(IUserRepository iUserRepository)
        {
            this.iUserRepository = iUserRepository;
        }

        public User GetById(int id)
        {
            return this.iUserRepository.GetById(id);
        }

        public User GetByUsername(string username)
        {
            return this.iUserRepository.GetByUsername(username);
        }

        public User GetByEmail(string email)
        {
            return this.iUserRepository.GetByEmail(email);
        }

        public List<User> GetAll()
        {
            return this.iUserRepository.GetAll();
        }
    }
}
