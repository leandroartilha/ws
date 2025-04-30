using Domain.Interfaces;
using Infraesctructure.Data;
using Infraesctructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using WS.Api.Middleware;
using WS.Api.Token;

namespace WS.Infraesctructure.DependencyInjection
{
    public static class AddServices
    {
        public static void AddServicesInterfaces(this IServiceCollection services)
        {
            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChatRoomRepository, ChatRoomRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            //services.AddScoped<IMiddleware, GlobalMiddleware>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}