using Microsoft.Extensions.FileProviders;
using MyCafeBusinessLayer.DependencyResolvers.Microsoft;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var str = builder.Configuration.GetConnectionString("MyCafeDatabase");
builder.Services.AddDependencies(str);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot")),
    RequestPath = "/wwwroot"
});

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=deneme}/{id?}");

app.Run();

