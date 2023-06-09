﻿using Server.WebApi.Settings;

namespace Server.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //Add all:
            ISettingsProvider settingsProvider = services.SetupSettings();
            services.SetupSwagger();
            services.SetupDataContext(settingsProvider);
            services.SetupDatabase();
            services.SetupServices();
            services.AddCors();

            services.AddControllers(options =>
            {
                options.AllowEmptyInputInBodyModelBinding = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

            app.UseWebSockets();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            // LIVE ON: http://localhost:12500/cinema/swagger/index.html
            app.UseSwagger(options =>
            {
                options.RouteTemplate = "cinema/swagger/{documentName}/cinema.json";
            });
            app.UseSwaggerUI(
                options =>
                {
                    options.RoutePrefix = "cinema/swagger";
                    options.SwaggerEndpoint("v1/cinema.json", "Cinema Service");
                });
        }
    }
}
