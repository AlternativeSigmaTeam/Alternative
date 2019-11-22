﻿using System;
using Alternative.DAL.Context;
using Alternative.Infrastructure.ContainerConfigurator;
using Alternative.Web.Mapping;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alternative.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //var connection = Configuration.GetConnectionString("AlternativeConnection");
            var connection = "Server=EPUAKHAW0861;Database=AlternativeDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<AlternativeContext>(options => options.UseSqlServer(connection));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new MappingProfile()));
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new InfrastructureModule());


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //var builder = ConfigureAutofac(services);
            containerBuilder.Populate(services);

            var container = containerBuilder.Build();

            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private ContainerBuilder ConfigureAutofac(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DALModule());
            builder.Populate(services);

            return builder;
        }
    }
}
