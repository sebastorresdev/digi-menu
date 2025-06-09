using DigiMenu.Api.Authentication.Services;
using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Common.Api.Results;
using DigiMenu.Api.Data;
using DigiMenu.Api.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Usuarios.Endpoints;

public class CrearUsuario : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapPost("/", Handle)
        .WithSummary("Crear usuarios")
        .WithRequestValidation<Request>();

    public record Request(
        string Username,
        string Password,
        string RepetirPassword,
        int RolId,
        int EmpleadoId);

    public record Response(
        int Id,
        string Username,
        DateTime FechaCreacion,
        string NombreRol,
        string NombreEmpleado,
        bool Estado);
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Password).NotEmpty().MaximumLength(100);
            RuleFor(x => x.RepetirPassword).NotEmpty().MaximumLength(100);
            RuleFor(x => x.RolId).GreaterThan(0);
            RuleFor(x => x.EmpleadoId).GreaterThan(0);
        }
    }

    private static async Task<Results<Ok<Response>, ValidationError>> Handle(
        Request request,
        AppDbContext database,
        IPasswordHasher passwordHasher,
        Jwt jwt,
        CancellationToken cancellationToken)
    {
        if(request.Password != request.RepetirPassword)
            return new ValidationError("Passwords do not match");

        var usernameExists = await database.Usuarios
            .AnyAsync(x => x.Username == request.Username, cancellationToken);

        if (usernameExists)
            return new ValidationError("El nombre de usuario ya está en uso");

        var empleadoHasUser = await database.Usuarios
            .AnyAsync(x => x.EmpleadoId == request.EmpleadoId, cancellationToken);

        if (empleadoHasUser)
            return new ValidationError("El empleado ya tiene asignado un usuario");

        // TODO: Hash password
        var hashPassword = passwordHasher.Hash(request.Password);

        var user = new Usuario
        {
            Username = request.Username,
            HashPassword = hashPassword,
            RolId = request.RolId,
            EmpleadoId = request.EmpleadoId
        };

        await database.Usuarios.AddAsync(user, cancellationToken);
        await database.SaveChangesAsync(cancellationToken);

        var response = new Response
            (
                user.Id,
                user.Username,
                user.FechaCreacion,
                user.Rol.Nombre,
                $"{user.Empleado.Nombres} {user.Empleado.Apellidos}",
                user.Estado
            );
        return TypedResults.Ok(response);
    }
}