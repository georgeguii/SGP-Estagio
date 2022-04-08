using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using SpgEstagioTeste.Infra;
using SpgEstagioTeste.Models.Contracts;
using SpgEstagioTeste.Models.Entities.Users;

namespace SpgEstagioTeste.Models.Services
{
    public class UserService : IUserService
    {

        private readonly MongoDBOptions _options;
        private readonly IMongoCollection<User> _users;

        private const string CollectionName = "User";
        public UserService(IOptions<MongoDBOptions> options)
        {
            _options = options.Value;
            var client = new MongoClient(_options.ConnectionStringMongo);
            var database = client.GetDatabase(_options.DatabaseMongo);

            _users = database.GetCollection<User>(CollectionName);
        }

        public async Task<User> Register(User user)
        {
            await _users.InsertOneAsync(user);

            return user;
        }

        public async Task<User> Find(string email)
        {
            var filters = Builders<User>.Filter.Eq(item => item.Email, email);
            var user = await _users.Find(filters).FirstOrDefaultAsync();

            return user;
        }


        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
