using MinimalAPIJwt.Models;

namespace MinimalAPIJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new () { UserName = "admin", EmailAdress = "admin@email.com", Password = "123456", GivenName = "Luan", SurName = "Acioly", Role = "Administrator" },
            new () { UserName = "user", EmailAdress = "user@email.com", Password = "123456", GivenName = "Standard", SurName = "User", Role = "Standard" }
        };
    }
}
