using Domain.DomainEntities.ChatRoomEntity;
using Domain.DomainEntities.MessageEntity;
using Domain.DomainEntities.NotificationEntity;
using Domain.DomainEntities.User;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infraesctructure.Data
{
    public class DBContext : IDBContext
    {
        public DBContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>
               ("DatabaseSettings:DatabaseName"));

            User = database.GetCollection<User>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionUser"));

            Notification = database.GetCollection<Notification>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionNotification"));

            Message = database.GetCollection<Message>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionMessage"));

            ChatRoom = database.GetCollection<ChatRoom>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionChatRoom"));
        }

        public IMongoCollection<User> User { get ; set; }
        public IMongoCollection<Notification> Notification { get; set; }
        public IMongoCollection<Message> Message { get; set; }
        public IMongoCollection<ChatRoom> ChatRoom { get; set; }
    }
}