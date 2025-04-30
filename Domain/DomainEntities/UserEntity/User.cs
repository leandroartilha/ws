using Domain.DomainEntities.Base;

namespace Domain.DomainEntities.User
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsOnline { get; set; }
        public string ConnectionId { get; set; }
        public string AvatarUrl { get; set; }
    }
}
