using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Måste öppna säkerheten för att kunna göra anrop 
builder.Services.AddCors(options => { options.AddPolicy("corsapp", policy => 
{ policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }); });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<KapAppenDbContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ProductService, ProductService>();
builder.Services.AddScoped<StoreInventoryService, StoreInventoryService>();
builder.Services.AddScoped<StoreService, StoreService>();

var app = builder.Build();

//Måste öppna säkerheten för att kunna göra anrop utifrån
app.UseCors("corsapp");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetService<KapAppenDbContext>();
    SeedDatabase.SeedData(context);
    context.SaveChanges();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
