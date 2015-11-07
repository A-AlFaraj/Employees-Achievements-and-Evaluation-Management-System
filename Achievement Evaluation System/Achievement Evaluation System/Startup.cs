using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Achievement_Evaluation_System.Startup))]
namespace Achievement_Evaluation_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
