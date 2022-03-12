namespace FramesBlazor.Extensions;

public static class ServiceExtensions
{
    public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddSqlite<AppDbContext>(configuration.GetConnectionString("default"));
}
