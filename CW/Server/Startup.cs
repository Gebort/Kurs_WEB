using CW.Server.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CW.Server
{
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")) // подключение Microsoft SQL Server
            );


            services.AddIdentity<User, IdentityRole>( // использовать сущности Identity со следующими параметрами
                config => {
                    config.SignIn.RequireConfirmedEmail = false;
                    config.Password.RequiredLength = 4;
                    config.Password.RequireNonAlphanumeric = false;
                    config.Password.RequireUppercase = false;
                    config.Password.RequireLowercase = false;
                }
                ).AddEntityFrameworkStores<ApplicationContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<User, ApplicationContext>(); // использовать авторизацию по API

            services.AddAuthentication() // добавить аутентификацию
                .AddIdentityServerJwt(); // использовать JWT-авторизацию

            services.AddControllers(); // добавить контроллеры
            services.AddRazorPages(); // добавить страницы Razor Pages
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage(); // использовать страницу исключений
                app.UseMigrationsEndPoint(); 
                app.UseWebAssemblyDebugging();
            } else {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // включить перенаправления
            app.UseBlazorFrameworkFiles(); // использовать Blazor WASM
            app.UseStaticFiles(); // маршрутизировать статические файлы

            app.UseRouting(); // использлвать правила маршрутизации

            app.UseIdentityServer(); // подключение IdentityServer 4
            app.UseAuthentication(); // поддержка аутентификации
            app.UseAuthorization(); // поддержка авторизации

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages(); // картировать страницы RazorPages
                endpoints.MapControllers(); // картировать контроллеры MVC
                endpoints.MapFallbackToFile("index.html"); // в случае ошибки перенаправлять на страницу index.html
            });
        }
    }
}
