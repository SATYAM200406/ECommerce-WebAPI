using Microsoft.EntityFrameworkCore;
using MySecondWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShopContext>(options =>
{
options.UseInMemoryDatabase("Shop");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<ShopContext>();
//    await db.Database.EnsureCreatedAsync();
//}


//app.MapGet("/Products", async (ShopContext _context) =>
//{
//    return await _context.Products.ToArrayAsync();
//});

//app.MapGet("/Products/{id}", async (int id, ShopContext _context) =>
//{
//    var product = await _context.Products.FindAsync(id);
//    if (product == null)
//    {
//        return Results.NotFound();
//    }
//    return Results.Ok(product);
//});
app.Run();
