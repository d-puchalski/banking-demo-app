using BankingDemo.Core.AccountModule;
using BankingDemo.Core.Extensions.EF.Connections;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Net;

namespace BankingDemo.Core {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BankingDemo.Core.AccountService", Version = "v1" });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAdB2C"));

            services.AddHttpLogging(logging => {
                // Customize HTTP logging here.
                logging.LoggingFields = HttpLoggingFields.RequestBody | HttpLoggingFields.ResponseBody;
                logging.RequestBodyLogLimit = 4096;
                logging.ResponseBodyLogLimit = 4096;
            });

            services.AddAntiforgery();
            services.AddScoped<BankingDemo.Core.AccountModule.IAccountService, BankingDemo.Core.AccountModule.AccountService>();

            IdentityModelEventSource.ShowPII = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseSerilogRequestLogging();
            app.UseHttpLogging();

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BankingDemo.Core.AccountService v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(policyBuilder => {
                policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            CosmosDB.CheckCosmosDBStructure();
        }
    }
}
