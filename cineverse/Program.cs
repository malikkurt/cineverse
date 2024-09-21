using cineverse.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")+ ";TrustServerCertificate=True"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MovieDbContext>();

    var movie = new Movie()
    {
        MovieID = 0,
        Title = "Ivýr Zývýr",
        ReleaseDate = DateTime.Now,
        Director = "Ivýretti",
        Rating = 10,
        Description = "Description",
        PosterURL = "https://fma.fandom.com/wiki/Edward_Elric?file=213254+1407532169190+full.png",
        TrailerURL = "https://www.youtube.com/watch?v=v1PciHjcsAk"
    };

    context.Movies.Add(movie);
    context.SaveChanges();
}

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



