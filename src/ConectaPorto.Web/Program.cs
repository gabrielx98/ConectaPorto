

using AspNetCoreHero.ToastNotification;
using ConectaPorto.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddNotyf(x => {
    x.DurationInSeconds = 10;
    x.IsDismissable = true;
    x.Position = NotyfPosition.TopRight;
});
RegisterServices.Register(builder.Services);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
//app.UseMvc();
app.UseCookiePolicy();

app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/");

app.Run();
