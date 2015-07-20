
using Owin;
namespace MyNgAPP
{
    public partial class Startup
    {
        // Enable the application to use OAuthAuthorization. You can then secure your Web APIs
       // static Startup()
//        {
//            PublicClientId = "web";
//
//            OAuthOptions = new OAuthAuthorizationServerOptions
//            {
//                TokenEndpointPath = new PathString("/Token"),
//                AuthorizeEndpointPath = new PathString("/Account/Authorize"),
//                Provider = new ApplicationOAuthProvider(PublicClientId),
//                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
//                AllowInsecureHttp = true
//            };
       // }
    //
      

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
          

        }
    }
}
