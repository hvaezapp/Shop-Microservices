namespace OcelotApiGw.Registration
{
    public static class LoggingRegistration
    {
        public static void RegisterLogging(this ILoggingBuilder loggingBuilder, IConfiguration configuration)
        {
            loggingBuilder.AddConfiguration(configuration.GetSection("Logging"));
            loggingBuilder.AddConsole();
            loggingBuilder.AddDebug();
        }
    }
}
