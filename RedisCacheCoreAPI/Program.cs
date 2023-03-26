using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Services.Iservices;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<Context>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ConnextionStr")));
builder.Services.AddScoped<IMemberService, MemberServices>();
builder.Services.AddScoped<ICacheService, CacheServices>();
var app = builder.Build();

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

