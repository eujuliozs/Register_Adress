using Microsoft.EntityFrameworkCore;
using Register_with_address.Data;
using Register_with_address.Models.Service;

namespace Register_with_address
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<register_and_addressContext>(options => options.UseMySql("server=localhost;port=3306;user=root;password=1234;database=register_and_address", ServerVersion.Parse("8.0.30-mysql")));
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<PessoaSerivce>();
            builder.Services.AddScoped<IEndereçoService, EndereçoService>();

            builder.Services.AddHttpClient("ViaCepApi" , c =>
            {
                c.BaseAddress = new Uri(builder.Configuration["API:ViaCepApi"]);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}