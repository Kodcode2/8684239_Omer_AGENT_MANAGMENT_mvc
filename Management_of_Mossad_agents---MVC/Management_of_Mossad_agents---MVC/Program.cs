using Management_of_Mossad_agents___MVC.Controllers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient<HomeController>();
builder.Services.AddHttpClient<TargetsController>();
builder.Services.AddHttpClient<MissionsController>();
builder.Services.AddHttpClient<OverviewController>();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
