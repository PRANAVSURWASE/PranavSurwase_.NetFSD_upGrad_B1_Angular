namespace Assignment_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            var app = builder.Build();

            // Middleware pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession(); 

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=Login}/{id?}");

            app.MapControllerRoute(
    name: "profile",
    pattern: "profile",
    defaults: new { controller = "User", action = "Profile" }
);

            app.MapControllerRoute(
                name: "login",
                pattern: "login",
                defaults: new { controller = "User", action = "Login" }
            );

            app.MapControllerRoute(
                name: "register",
                pattern: "register",
                defaults: new { controller = "User", action = "Register" }
            );

            app.Run();
        }
    }
}