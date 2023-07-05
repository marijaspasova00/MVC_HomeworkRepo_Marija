var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "ListOrders",
    pattern: "ListOrders",
    defaults: new { controller = "Order", action = "Index" });

app.MapControllerRoute(
    name: "Details",
    pattern: "{controller=Order}/{action=Details}/{id?}");

app.MapControllerRoute(
    name: "JsonData",
    pattern: "{controller=Order}/{action=JsonData}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
