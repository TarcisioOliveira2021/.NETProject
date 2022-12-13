using AutoMapperProject.Profiles;

namespace AutoMapperProject
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CarroProfile));
        }
    }
}