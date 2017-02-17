using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace AADTokenGen
{
    public class TokenManager
    {
        public string HttpAutenticationHeader()
        {
            var clientConfiguration = new ClientConfiguration();

            AuthenticationContext authenticationContext = new AuthenticationContext(clientConfiguration.ActiveDirectoryTenant);

            var authenticationResult = authenticationContext.AcquireTokenAsync(
                clientConfiguration.ActiveDirectoryResource,
                clientConfiguration.ActiveDirectoryClientAppId,
                new UserPasswordCredential(
                    clientConfiguration.UserName,
                    clientConfiguration.Password));

            return string.Concat(authenticationResult.Result.AccessTokenType, " ", authenticationResult.Result.AccessToken);
        }
    }
}
