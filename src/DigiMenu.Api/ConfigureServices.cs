using DigiMenu.Api.Authentication.Services;
using DigiMenu.Api.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DigiMenu.Api;

public static class ConfigureServices
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        //builder.AddSwagger();
        builder.AddDatabase();
        builder.Services.AddValidatorsFromAssembly(typeof(ConfigureServices).Assembly);
        builder.AddJwtAuthentication();
    }

    //private static void AddSwagger(this WebApplicationBuilder builder)
    //{
    //    builder.Services.AddEndpointsApiExplorer();
    //    builder.Services.AddSwaggerGen(options =>
    //    {
    //        options.CustomSchemaIds(type => type.FullName?.Replace('+', '.'));
    //        options.InferSecuritySchemes();
    //    });
    //}

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

        builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("Jwt"));
        builder.Services.AddTransient<Jwt>();
    }
}
