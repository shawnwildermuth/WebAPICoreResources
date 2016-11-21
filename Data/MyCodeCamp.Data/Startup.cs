using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");

      _config = builder.Build();
    }

    IConfigurationRoot _config;

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton(_config);
      services.AddDbContext<CampContext>(ServiceLifetime.Scoped)
        .AddIdentity<CampUser, IdentityRole>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure()
    {
    }
  }
}
