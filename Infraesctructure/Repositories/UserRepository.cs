using Domain.DomainEntities.User;
using Domain.Interfaces;

namespace Infraesctructure.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}
