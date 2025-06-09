using DigiMenu.Api.Authentication.Services;
using DigiMenu.Api.Common.Api.Exceptions;
using DigiMenu.Api.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DigiMenu.Api;

public static class ConfigureServices
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.AddDatabase();
        builder.Services.AddValidatorsFromAssembly(typeof(ConfigureServices).Assembly);
        builder.AddJwtAuthentication();
        builder.AddCross();
        builder.AddMyExceptionHandler();
        builder.AddScalarApi();
    }

    private static void AddDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
        });
    }

    private static void AddJwtAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication().AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                IssuerSigningKey = Jwt.SecurityKey(builder.Configuration["Jwt:Key"]!),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ClockSkew = TimeSpan.Zero
            };
        });
        builder.Services.AddAuthorization();

        builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

        builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("Jwt"));
        builder.Services.AddTransient<Jwt>();
    }

    private static void AddCross(this WebApplicationBuilder builder)
    {
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
    }

    private static void AddScalarApi(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer((document, context, _) =>
            {
                document.Info = new()
                {
                    Title = "Digi Menu Api",
                    Version = "v1",
                    Description = """
                Modern API for managing product catalogs.
                Supports JSON and XML responses.
                Rate limited to 1000 requests per hour.
                """,
                    Contact = new()
                    {
                        Name = "API Support",
                        Email = "sebasdtc@outlook.com"
                    }
                };
                return Task.CompletedTask;
            });
        });
    }

    private static void AddMyExceptionHandler(this WebApplicationBuilder builder)
    {
        builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
        builder.Services.AddProblemDetails();
    }
}
