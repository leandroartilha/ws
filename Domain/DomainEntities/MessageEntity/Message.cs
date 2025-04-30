using Domain.DomainEntities.Base;
using MongoDB.Bson;

namespace Domain.DomainEntities.MessageEntity
{
    public class Message : BaseEntity
    {
        public ObjectId SenderId { get; set; }
        public ObjectId ChatRoomId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}