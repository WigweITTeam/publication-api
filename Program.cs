using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PublicationApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PublicationApiContext>(options =>
//options.UseNpgsql(builder.Configuration.GetConnectionString("PublicationApiContext") ?? throw new InvalidOperationException("Connection string 'PublicationApiContext' not found.")));
options.UseSqlServer(builder.Configuration.GetConnectionString("PublicationApiContext") ?? throw new InvalidOperationException("Connection string 'PublicationApiContext' not found.")));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Apply pending migrations
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PublicationApiContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
