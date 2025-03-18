using _2025_epita_mediatr.Features.Command.User;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add MediatR
builder.Services.AddMediatR(cfg=> cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var serviceProvider = builder.Services.BuildServiceProvider();

var validator = serviceProvider.GetRequiredService<IValidator<CreateUserCommand>>();

if (validator is null)
{
    Console.WriteLine("Validation failed");
}
else
{
    Console.WriteLine("Validation passed");
}
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




//app.MapGet("/", () => "Mediatr Example Running");

app.Run();
