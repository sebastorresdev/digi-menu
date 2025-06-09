using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace DigiMenu.Api;

public static class ConfigureApp
{
    public static async Task Configure(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.ConfigDevelopment();
        }

        app.UseHttpsRedirection();
        app.MapEndpoints();
        app.UseExceptionHandler();
        app.UseCors("AllowFrontendDev");
        await app.EnsureDatabaseCreated();
    }

    private static async Task EnsureDatabaseCreated(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await db.Database.MigrateAsync();
    }

    private static void ConfigDevelopment(this WebApplication app)
    {
        app.MapOpenApi();

        app.MapScalarApiReference(options => options
            .AddPreferredSecuritySchemes("BasicAuth")
            .AddHttpAuthentication("BasicAuth", auth =>
            {
                auth.Username = "your-username";
                auth.Password = "your-password";
            })
        );

    }
}