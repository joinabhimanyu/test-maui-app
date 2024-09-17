using Microsoft.AspNetCore.Identity;
using test_webapi_app.DTO.AuthenticationFeature;

namespace test_webapi_app.Services.Authentication;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userRegistrationDto);
    Task<bool> ValidateUserAsync(UserLoginDto userLoginDto);
    Task<string> GenerateJwtTokenAsync(UserLoginDto userLoginDto);
}
