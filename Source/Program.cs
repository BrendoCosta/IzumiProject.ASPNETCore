using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddApiVersioning(config =>
{
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.ReportApiVersions = true;
    config.AssumeDefaultVersionWhenUnspecified = true;
});

builder.Services.AddVersionedApiExplorer(config =>
{
    config.GroupNameFormat = "'v'VVV";
    config.SubstituteApiVersionInUrl = true;
});

builder.Services.AddDbContext<Izumi.Database.TestContext>(options => options.UseSqlite(builder.Configuration["ConnectionStrings:SQLiteDatabase"]));

var app = builder.Build();

app.MapControllers();

app.Run();
