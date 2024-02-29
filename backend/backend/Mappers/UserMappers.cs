using backend.Dtos.User;
using backend.Models;

namespace backend.Mappers
{
    public static class UserMappers
    {
        public static LoginDTO ToLoginDto(this User userModel)
        {
            return new LoginDTO
            {
                Username = userModel.Username,
                Password = userModel.PasswordHash
            };
        }
    }
}
