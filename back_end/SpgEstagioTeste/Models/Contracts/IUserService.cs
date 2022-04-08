using SpgEstagioTeste.Models.Entities.Users;

namespace SpgEstagioTeste.Models.Contracts
{
    public interface IUserService
    {
        Task<User> Register(User user);
        Task<User> Find(string email);

        string GenerateToken(User user);
    }
}