using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingGit.Startup))]
namespace TrainingGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
