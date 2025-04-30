namespace WS.Api.Token
{
    public interface ITokenService
    {
        public string GetUserIdByToken(string token);
    }
}
