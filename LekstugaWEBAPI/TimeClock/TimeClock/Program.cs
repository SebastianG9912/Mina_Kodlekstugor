using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1.1", new OpenApiInfo()
    {
        Title = "Clock api",
        Version = "ver 1.1"
    });
    options.SwaggerDoc("v1.2", new OpenApiInfo()
    {
        Title = "Clock api",
        Version = "ver 1.2"
    });
});

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 1);
    options.AssumeDefaultVersionWhenUnspecified = true;

    //methods for reading api versions
    //method 1:
    //options.ReportApiVersions = true;
    //choose one below:
    //options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
    //options.ApiVersionReader = new HeaderApiVersionReader("api-version");
    //method 2:
    //options.ApiVersionReader = new UrlSegmentApiVersionReader();

    options.ApiVersionReader = new QueryStringApiVersionReader("v");
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1.1/swagger.json", "first page (v1.1)");
        options.SwaggerEndpoint("/swagger/v1.2/swagger.json", "second page (v1.2)");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
