using NovaModaBrecho.Models;
using NovaModaBrecho.Repository;
using NovaModaBrecho.Repository.Interfaces;
using NovaModaBrecho.Services;
using NovaModaBrecho.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Register generic repository and service implementations using open generic types.
// This allows the DI container to resolve IRepository<T> and IBaseItemService<T>
// for any specific T (e.g., Cloth, Item, Shoe) that your controllers or services might request.

// Register IRepository<T> with its implementation RepositoryImpl<T>
// Using AddScoped ensures a new instance per request, which is often suitable for data access.
builder.Services.AddScoped(typeof(IRepository<>), typeof(RepositoryImpl<>));

// Register IBaseItemService<T> with its implementation ItemService<T>
// This service likely depends on IRepository<T>, and AddScoped will ensure consistency within a request.
builder.Services.AddScoped(typeof(IBaseItemService<>), typeof(ItemService<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Keep an eye on the HTTPS port warning, but this is not the main crash.
app.UseRouting();

app.UseAuthorization();

// Assuming these are custom extension methods for static assets.
app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();