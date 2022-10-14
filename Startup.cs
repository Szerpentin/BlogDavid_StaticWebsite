namespace BlogDavid_StaticWebsiteUsingAspMvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Https is a must!
            app.UseHttpsRedirection();
            // Let Asp Mvc default '/' to index.html
            app.UseDefaultFiles();
            // Tell Asp Mvc to serve files from under wwwroot folder
            app.UseStaticFiles();
        }
    }
}
