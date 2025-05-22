using DigiMenu.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendDev",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")  // tu app Angular
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddOpenApi();
builder.AddServices();

var app = builder.Build();

app.UseCors("AllowFrontendDev");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

await app.Configure();

app.Run();