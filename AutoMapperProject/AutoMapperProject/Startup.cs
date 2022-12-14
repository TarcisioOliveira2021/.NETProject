using AutoMapperProject.Profiles;


namespace AutoMapperProject
{
    public class Startup
    {
        public IConfiguration Configuration { get;}

        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

         public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CarroProfile));
            services.AddControllers();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            if(env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

        }
    }
}