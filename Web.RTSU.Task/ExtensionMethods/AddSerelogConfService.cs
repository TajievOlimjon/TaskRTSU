using Serilog;

namespace Web.RTSU.Task.ExtensionMethods
{
    public static class AddSerelogConfService
    {
        public static void AddSerelogServices(this WebApplicationBuilder builder )
        {
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();
            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(logger);
        }
    }
}
