using Domain.DomainEntities.User;
using MongoDB.Bson;

namespace WS.Api.Middleware
{
    public interface IContextUser
    {
        public User UserLogged { get; set; }
        public ObjectId UserId { get; set; }
        public User ObterUsuarioLogado();
    }
}
