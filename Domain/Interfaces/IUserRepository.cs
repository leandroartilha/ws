using Domain.DomainEntities.User;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUser(string email);
        Task CreateUser(User user);
    }
}