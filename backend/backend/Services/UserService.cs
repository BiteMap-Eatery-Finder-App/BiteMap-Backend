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

        public void Save(User user)
        {
            this.iUserRepository.Save(user);
        }

        public bool Exists(User user)
        {
            List<User> users = this.GetAll();

            foreach(User u in users)
            {
                if(u.Username == user.Username || u.Email == user.Email)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
