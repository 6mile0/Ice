namespace Ice.Configurations;

public static class DependencyInjectionExtension
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddDependencyInjectionConfiguration()
        {
            // Register application services here
            // services.AddTransient<IMyService, MyService>();

            return services;
        }
    }
}