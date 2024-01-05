using BeautyHall.Api.DB.Services;
using BeautyHall.DAL.DB;
using BeautyHall.Models.Common.Interfaces;
using BeautyHall.Models.Db.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var dbContextOptions = new DbContextOptionsBuilder<BeautyHallContext>();
        dbContextOptions.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
        dbContextOptions.EnableSensitiveDataLogging();

        // Add services to the container.

        builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<BeautyHallContext>(x => x = dbContextOptions);

        builder.Services.AddScoped<IDBService, DBService>();
        builder.Services.AddScoped<IBolDbService, BolService>();

        // needed to load configuration from appsettings.json
        builder.Services.AddOptions();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
            app.UseSwagger();
            app.UseSwaggerUI();
        //}

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}