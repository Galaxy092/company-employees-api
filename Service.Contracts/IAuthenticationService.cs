using Microsoft.AspNetCore.Identity;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> Register(RegisterDto registerDto);
        Task<bool> Login(LoginDto loginDto);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
