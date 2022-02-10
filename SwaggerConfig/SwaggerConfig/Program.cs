using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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
