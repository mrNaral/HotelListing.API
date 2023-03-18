using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> AdminRegister(ApiAdminDto apiAdminDto);
        Task<IEnumerable<IdentityError>> UserRegister(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);

        Task<string> CreateRefreshToken();

        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
