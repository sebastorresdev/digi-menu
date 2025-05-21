﻿using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace DigiMenu.Api;

public static class ConfigureApp
{
    public static async Task Configure(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.MapEndpoints();
        app.MapScalarApiReference();
        await app.EnsureDatabaseCreated();
    }

    private static async Task EnsureDatabaseCreated(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await db.Database.MigrateAsync();
    }
}