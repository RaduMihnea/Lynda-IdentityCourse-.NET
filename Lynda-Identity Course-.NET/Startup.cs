using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lynda_Identity_Course_.NET.Startup))]
namespace Lynda_Identity_Course_.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
