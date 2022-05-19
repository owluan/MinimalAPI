using MinimalAPIJwt.Models;

namespace MinimalAPIJwt.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
