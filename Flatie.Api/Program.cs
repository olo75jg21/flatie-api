using Flatie.Api;
using Flatie.Bll.Services;
using Flatie.Dal.Repositories;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserAppRoleRepository, UserAppRoleRepository>();

builder.Services.AddTransient<IUserAppRoleService, UserAppRoleService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection"));
});


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