
using ThomasGregTest.API.Routes;

namespace ThomasGregTest.API.Configuration
{
    public static class ConfigureRoutes
    {
        public static void ConfigRoutes(this WebApplication app)
        {
            app.ConfigRoutesCliente();
            app.ConfigRoutesLogradouro();
        }
    }
}
