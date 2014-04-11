//Contributor:  Nicholas Mayne


namespace Nile.Services.Authentication.External
{
    public partial interface IClaimsTranslator<T>
    {
        UserClaims Translate(T response);
    }
}