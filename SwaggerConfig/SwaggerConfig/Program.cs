using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.OpenApi.Models;
using SwaggerConfig.Infrastructure.Filters;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    //Remove globally text/plain response
    options.OutputFormatters.RemoveType<StringOutputFormatter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.SwaggerDoc("v2", new OpenApiInfo 
    { 
        Title = "Employee api", 
        Version = "v2",
        Description = "Tutorial web api with swagger tools",
        TermsOfService = new Uri("https://github.com/mindball"),
        Contact = new OpenApiContact
        {
            Name = "Mincho Balaliev",
            Email = "clin@mail.bg",
            Url = new Uri("https://www.linkedin.com/in/minchobalaliev/")
        },
        License = new OpenApiLicense
        {
            Name = "Empl API MIT",
            Url = new Uri("https://google.com")
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

    c.OperationFilter<Consumes>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "Employee api");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
