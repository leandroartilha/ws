using Domain.DomainEntities.Base;
using MongoDB.Bson;

namespace Domain.DomainEntities.ChatRoomEntity
{
    public class ChatRoom : BaseEntity
    {
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public List<ObjectId> ParticipantIds { get; set; } = new();
    }
}