using Domain.DomainEntities.ChatRoomEntity;
using Domain.DomainEntities.MessageEntity;
using Domain.DomainEntities.NotificationEntity;
using Domain.DomainEntities.User;
using MongoDB.Driver;

namespace Infraesctructure.Data
{
    public interface IDBContext
    {
        IMongoCollection<User> User { get; set; }
        IMongoCollection<Notification> Notification { get; set; }
        IMongoCollection<Message> Message { get; set; }
        IMongoCollection<ChatRoom> ChatRoom { get; set; }
    }
}