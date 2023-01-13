using Microsoft.EntityFrameworkCore;
using Zacks_sample_application.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDeckRepository, DeckRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ZacksSampleApplicationDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:ZacksSampleApplicationDbContextConnection"]);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
