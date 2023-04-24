using JoyGAPI.DTOs;

namespace JoyGAPI.Interfaces
{
    public interface IAuthService
    {
        Task<UserDto> Login(LoginDto loginDto);
        Task<UserDto> Register(RegisterDto registerDto);
    }
}
