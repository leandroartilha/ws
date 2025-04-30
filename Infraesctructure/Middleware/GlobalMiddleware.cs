using Domain.DomainEntities.User;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Security.Claims;

namespace WS.Api.Middleware
{
    public class GlobalMiddleware : IMiddleware
    {
        private IContextUser _contextUser;

        public GlobalMiddleware(IContextUser contextUser)
        {
            _contextUser = contextUser;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                LoginVerify(context);

                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
        }

        public void LoginVerify(HttpContext context)
        {
            var id = "";

            if (context.User.Identity.IsAuthenticated == true)
            {
                var token = context.User.Claims;

                id = context.User.FindFirstValue("id");

                foreach (var item in token)
                {
                    if (item.Type == "id")
                    {
                        id = item.Value;
                    }
                }

                _contextUser.UserLogged = new User
                {
                    _id = new MongoDB.Bson.ObjectId(id),
                };
            }
        }
    }
}