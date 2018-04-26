using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomReservationSystem.Startup))]
namespace RoomReservationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
