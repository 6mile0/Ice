namespace Ice.Configurations;

public static class WebApplicationBuilderExtension
{
    extension(WebApplicationBuilder builder)
    {
        public WebApplicationBuilder AddBuilderConfiguration()
        {
            builder.Services.AddControllersWithViews();
            builder.Services.AddDependencyInjectionConfiguration();

            return builder;
        }
    }
}