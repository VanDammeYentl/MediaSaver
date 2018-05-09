﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaSaver.Models.Data;
using MediaSaver.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MediaSaver.API
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
            // Adding the database Connection
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MediaSaverDBContext>(options => options.UseSqlServer(connectionString));

            // Adding the repositories
            services.AddScoped<IErrorLogRepo, ErrorLogRepo>();
            services.AddScoped<IAlbumRepo, AlbumRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IMediaObjectRepo, MediaObjectRepo>();

            // Defining the API
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
