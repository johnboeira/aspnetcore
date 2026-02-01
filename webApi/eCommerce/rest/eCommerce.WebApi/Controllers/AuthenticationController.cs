using eCommerce.WebApi.Contracts.Authentication;
using eCommerce.WebApi.Infra;
using eCommerce.WebApi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace eCommerce.WebApi.Controllers;

[ApiController]
public class AuthenticationController(AuthenticationRepository authenticationRepository) : ControllerBase
{
    private readonly AuthenticationRepository _authenticationRepository = authenticationRepository;

    [HttpPost]
    [Route(ApiEndpoints.Authentication.Login)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest loginRequest)
    {
        var loginOk = await _authenticationRepository.CheckIfLoginIsValid(loginRequest);

        if (loginOk)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretkeyque_deve_armazena_de_forma_segura"));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            string token = tokenHandler.WriteToken(securityToken);

            return new LoginResponse(token);
        }

        return Unauthorized();
    }
}