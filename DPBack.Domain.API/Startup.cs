using DPBack.Domain.Handlers;
using DPBack.Domain.Infra.Contexts;
using DPBack.Domain.Infra.Repositories;
using DPBack.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Data.SqlClient;

namespace DPBack.Domain.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddMvc();
            services.AddCors();
            //Cofiguração da base de dados
           // services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("data"));
            services.AddDbContext<DataContext>(opt => 
            opt.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            

            //Injeção de dependencia
            services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddTransient<IPetsRepository, PetRepository>();
            services.AddTransient<OwnerCreateHandler, OwnerCreateHandler>();
            services.AddTransient<PetCreateHandler, PetCreateHandler>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DPBack.Domain.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DPBack.Domain.API v1"));                
            }

            app.UseHttpsRedirection();

            

            app.UseRouting();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
