using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(MyNgAPP.Startup))]

namespace MyNgAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}
