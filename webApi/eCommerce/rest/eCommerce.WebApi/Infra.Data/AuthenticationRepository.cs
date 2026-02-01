using eCommerce.WebApi.Domain;
using eCommerce.WebApi.Models.Authentication;

namespace eCommerce.WebApi.Infra;

public class AuthenticationRepository
{
    private static List<User> _users = new List<User>()
    {
        new User("Roger","senhadoroger2"),
        new User("Luana", "senhafakedaluana")
    };

    public async Task<bool> CheckIfLoginIsValid(LoginRequest loginRequest)
    {
        await Task.Delay(600); // simulando I/O (Banco)
        return _users.Exists(x => x.UserName.Equals(loginRequest.UserName) && x.Password.Equals(loginRequest.Password));
    }
}