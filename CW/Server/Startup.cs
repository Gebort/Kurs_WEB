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
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")) // ����������� Microsoft SQL Server
            );


            services.AddIdentity<User, IdentityRole>( // ������������ �������� Identity �� ���������� �����������
                config => {
                    config.SignIn.RequireConfirmedEmail = false;
                    config.Password.RequiredLength = 4;
                    config.Password.RequireNonAlphanumeric = false;
                    config.Password.RequireUppercase = false;
                    config.Password.RequireLowercase = false;
                }
                ).AddEntityFrameworkStores<ApplicationContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<User, ApplicationContext>(); // ������������ ����������� �� API

            services.AddAuthentication() // �������� ��������������
                .AddIdentityServerJwt(); // ������������ JWT-�����������

            services.AddControllers(); // �������� �����������
            services.AddRazorPages(); // �������� �������� Razor Pages
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage(); // ������������ �������� ����������
                app.UseMigrationsEndPoint(); 
                app.UseWebAssemblyDebugging();
            } else {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // �������� ���������������
            app.UseBlazorFrameworkFiles(); // ������������ Blazor WASM
            app.UseStaticFiles(); // ���������������� ����������� �����

            app.UseRouting(); // ������������ ������� �������������

            app.UseIdentityServer(); // ����������� IdentityServer 4
            app.UseAuthentication(); // ��������� ��������������
            app.UseAuthorization(); // ��������� �����������

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages(); // ����������� �������� RazorPages
                endpoints.MapControllers(); // ����������� ����������� MVC
                endpoints.MapFallbackToFile("index.html"); // � ������ ������ �������������� �� �������� index.html
            });
        }
    }
}
