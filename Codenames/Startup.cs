using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codenames.Startup))]
namespace Codenames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
