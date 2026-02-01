namespace eCommerce.WebApi.Domain;

public class User
{
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public string UserName { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}