using Microsoft.EntityFrameworkCore;
using TriangleDocker.dataBasa;
using TriangleDocker.Models.graphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBcontent>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddGraphQL().AddQueryType<Queries>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.UseEndpoints(endpoint => {
    endpoint.MapControllers();
    //endpoint.MapGraphQL("/graphql");
});

app.Run();

