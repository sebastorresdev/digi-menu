using DigiMenu.Api.Authentication.Endpoints;
using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Filters;
using DigiMenu.Api.Features.Empleados.Endpoints;
using DigiMenu.Api.Features.Roles.Endpoints;
using DigiMenu.Api.Features.Usuarios.Endpoints;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace DigiMenu.Api;

public static class Endpoints
{
    private static readonly OpenApiSecurityScheme securityScheme = new()
    {
        Type = SecuritySchemeType.Http,
        Name = JwtBearerDefaults.AuthenticationScheme,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Reference = new()
        {
            Type = ReferenceType.SecurityScheme,
            Id = JwtBearerDefaults.AuthenticationScheme
        }
    };

    public static void MapEndpoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("")
            .AddEndpointFilter<RequestLoggingFilter>()
            .WithOpenApi();

        // Agregar todos los endpoints aquí
        endpoints.MapAuthenticationEndpoints();
        endpoints.MapUserEndpoints();
        endpoints.MapEmpleadosEndpoints();
        endpoints.MapRolesEndpoints();
    }

    private static void MapAuthenticationEndpoints(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/auth")
            .WithTags("Authentication");
            
        endpoints.MapPublicGroup()
            .MapEndpoint<Login>();
    }

    private static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/usuarios")
            .WithTags("Usuarios");

        endpoints.MapPublicGroup()
            .MapEndpoint<ObtenerUsuarioPorId>()
            .MapEndpoint<ListarUsuarios>()
            .MapEndpoint<CrearUsuario>();

        //endpoints.MapAuthorizedGroup()
        //    .MapEndpoint<ObtenerUsuarioPorId>()
        //    .MapEndpoint<ListarUsuarios>();
    }

    private static void MapEmpleadosEndpoints(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/empleados")
            .WithTags("Empleados");

        endpoints.MapPublicGroup()
            .MapEndpoint<ListarEmpleados>()
            .MapEndpoint<ListarNombreDniEmpleados>()
            .MapEndpoint<CrearEmpleado>()
            .MapEndpoint<EditarEmpleado>()
            .MapEndpoint<EliminarEmpleado>();

        //endpoints.MapAuthorizedGroup()
        //    .MapEndpoint<ListarEmpleados>()
        //    .MapEndpoint<CrearEmpleado>();
    }

    private static void MapRolesEndpoints(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/roles")
            .WithTags("Roles");

        endpoints.MapPublicGroup()
            .MapEndpoint<ListarRoles>()
            .MapEndpoint<CrearRol>();

        //endpoints.MapAuthorizedGroup()
        //    .MapEndpoint<ListarRoles>()
        //    .MapEndpoint<CrearRol>();
    }

    private static RouteGroupBuilder MapPublicGroup(this IEndpointRouteBuilder app, string? prefix = null)
    {
        return app.MapGroup(prefix ?? string.Empty)
            .AllowAnonymous();
    }

    private static RouteGroupBuilder MapAuthorizedGroup(this IEndpointRouteBuilder app, string? prefix = null)
    {
        return app.MapGroup(prefix ?? string.Empty)
            .RequireAuthorization()
            .WithOpenApi(x => new(x)
            {
                Security = [new() { [securityScheme] = [] }],
            });
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}