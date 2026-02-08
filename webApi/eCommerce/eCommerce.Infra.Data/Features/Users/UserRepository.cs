using eCommerce.Domain.Features.Users;

namespace eCommerce.Infra.Data.Features.Users;

public class UserRepository
{
    private static List<User> _users = new List<User>()
    {
        new User("Roger","senhadoroger2"),
        new User("Luana", "senhafakedaluana")
    };

    public async Task<bool> Exists(string userName, string password)
    {
        await Task.Delay(600); // simulando I/O (Banco)
        return _users.Exists(x => x.UserName.Equals(userName) && x.Password.Equals(password));
    }
}