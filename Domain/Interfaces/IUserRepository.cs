using Domain.DomainEntities.User;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUser(string email);
        public void CreateUser(User user);
    }
}
