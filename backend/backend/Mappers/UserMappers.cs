using backend.Dtos.User;
using backend.Models;

namespace backend.Mappers
{
    public static class UserMappers
    {
        public static User ToUserFromRegisterDto(this RegisterDTO registerDto)
        {
            return new User
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                Username = registerDto.Username,
                PasswordHash = registerDto.Password,
                DateOfBirth = registerDto.DateOfBirth
            };
        }
    }
}
