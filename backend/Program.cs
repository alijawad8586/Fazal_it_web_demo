using FazalTechSolutions.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IContactMessageStore, JsonFileContactMessageStore>();

const string AngularClientPolicy = "AngularClient";
builder.Services.AddCors(options =>
{
    options.AddPolicy(AngularClientPolicy, policy =>
    {
        policy
            .WithOrigins("http://localhost:4200", "https://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(AngularClientPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
