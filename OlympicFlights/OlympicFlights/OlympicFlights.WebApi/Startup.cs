using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.AirportManagement;
using OlympicFlights.DataAccess.CityManagement;
using OlympicFlights.DataAccess.ClientManagement;
using OlympicFlights.DataAccess.CountryManagement;
using OlympicFlights.DataAccess.FlightAirportManagement;
using OlympicFlights.DataAccess.FlightManagement;
using OlympicFlights.Service.AirportManagement;
using OlympicFlights.Service.ApplicationUsersManagement;
using OlympicFlights.Service.CityManagement;
using OlympicFlights.Service.ClientManagement;
using OlympicFlights.Service.CountryManagement;
using OlympicFlights.Service.FlightManagement;
using ApplicationUserDb = OlympicFlights.DataAccess.UserManagement.ApplicationUser;
using OlympicFlights.DataAccess.TicketManagement;
using OlympicFlights.Service.AdminManagement;
using OlympicFlights.Service.TicketManagement;

namespace OlympicFlights.WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper();
            services.AddDbContext<ApplicationDbContext>();

            services.AddIdentity<ApplicationUserDb,IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequiredLength = 4;
                opt.User.RequireUniqueEmail = true;
            });

            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<ICountryContext, CountryContext>();

            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICityContext, CityContext>();

            services.AddTransient<IAirportService, AirportService>();
            services.AddTransient<IAirportContext, AirportContext>();

            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IClientContext, ClientContext>();

            services.AddTransient<IFlightContext, FlightContext>();
            services.AddTransient<IFlightService, FlightService>();

            services.AddTransient<IFlightAirportsContext, FlightAirportContext>();

            services.AddTransient<ITicketContext, TicketContext>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITicketAdministrate, TicketService>();

            services.AddTransient<ChartService>();

            services.AddTransient<ApplicationUserService>();
            services.AddTransient<RoleManager<IdentityRole>>();
            services.AddTransient<UserManager<ApplicationUserDb>>();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                                        .AllowAnyHeader()
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                });
            });

            var key = Encoding.UTF8.GetBytes(Configuration["ApplicationSettings:JWT"].ToString());

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = false;
                    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    };
                });


        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseAuthentication();

            app.UseCors();
            app.UseMvc();

            CreateUserRoles(services).Wait();
        }

        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUserDb>>();

            IdentityResult roleResult;

            var adminRoleCheck = await roleManager.RoleExistsAsync(Configuration["ApplicationSettings:adminRoleName"].ToString());
            var userRoleCheck = await roleManager.RoleExistsAsync(Configuration["ApplicationSettings:userRoleName"]);

            if (!adminRoleCheck)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(Configuration["ApplicationSettings:adminRoleName"].ToString()));
            }

            if (!userRoleCheck)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(Configuration["ApplicationSettings:userRoleName"]));
            }

            var user = await userManager.FindByEmailAsync("artsiom.lyshchyk@gmail.com");
            
            if (user is null)
            {
                user = new ApplicationUserDb
                {
                    UserName = Configuration["ApplicationSettings:adminUsername"].ToString(),
                    Email = Configuration["ApplicationSettings:adminEmail"].ToString()
                };

                await userManager.CreateAsync(user, Configuration["ApplicationSettings:adminPassword"].ToString());
            }

            await userManager.AddToRoleAsync(user, Configuration["ApplicationSettings:adminRoleName"].ToString());
        }
    }
}
