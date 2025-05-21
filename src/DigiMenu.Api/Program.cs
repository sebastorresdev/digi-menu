using DigiMenu.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

await app.Configure();

app.Run();