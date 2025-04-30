using Domain.DomainEntities.User;
using Domain.Interfaces;
using Infraesctructure.Data;
using MongoDB.Driver;

namespace Infraesctructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDBContext _context;

        public UserRepository(IDBContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public async Task CreateUser(User user)
        {
            await _context.User.InsertOneAsync(user);
        }

        public async Task<User> GetUser(string email)
        {
            var filter = Builders<User>.Filter.Eq(x => x.Email, email);

            var user = await _context.User.Find(filter).FirstOrDefaultAsync();

            return user;
        }
    }
}