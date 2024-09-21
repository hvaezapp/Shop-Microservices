using Ocelot.DependencyInjection;

namespace OcelotApiGw.Registration
{
    public static class OcelotRegistration
    {
        public static void RegisterOcelot(this IServiceCollection services)
        {
            services.AddOcelot();
        }


    }
}
