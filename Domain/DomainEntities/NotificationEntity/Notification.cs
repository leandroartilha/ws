using Domain.DomainEntities.Base;

namespace Domain.DomainEntities.NotificationEntity
{
    public class Notification : BaseEntity
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }
        public string Link { get; set; }
    }
}
