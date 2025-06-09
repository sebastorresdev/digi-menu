using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Common.Api.Results;
using DigiMenu.Api.Data;
using DigiMenu.Api.Data.Entities;
using DigiMenu.Api.Data.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Empleados.Endpoints;

public class CrearEmpleado : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapPost("/", Handle)
        .WithSummary("Crear un nuevo empleado")
        .WithRequestValidation<Request>();

    public record Request(
        string Nombres,
        string Apellidos,
        string? Email,
        string? Direccion,
        DateTime? FechaNacimiento,
        string TipoDocumento,
        string NumeroDocumento,
        string? NumeroTelefono);

    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Nombres).NotEmpty().MaximumLength(255);
            RuleFor(x => x.Apellidos).NotEmpty().MaximumLength(255);
            RuleFor(x => x.Email).EmailAddress().MaximumLength(255).When(x => !string.IsNullOrWhiteSpace(x.Email));
            RuleFor(x => x.Direccion).MaximumLength(255).When(x => !string.IsNullOrWhiteSpace(x.Direccion));
            RuleFor(x => x.FechaNacimiento).LessThan(DateTime.Now).When(x => x.FechaNacimiento.HasValue);
            RuleFor(x => x.TipoDocumento).NotEmpty().MaximumLength(50);
            RuleFor(x => x.NumeroDocumento).NotEmpty().MaximumLength(20);
            RuleFor(x => x.NumeroTelefono).MaximumLength(20).When(x => !string.IsNullOrWhiteSpace(x.NumeroTelefono));
        }
    }

    public record Response(
        int Id,
        string Nombres,
        string Apellidos,
        string? Email,
        string? Direccion,
        DateTime? FechaNacimiento,
        string TipoDocumento,
        string NumeroDocumento,
        string? NumeroTelefono,
        DateTime FechaCreacion,
        bool Estado);

    public static async Task<Results<Ok<Response>, ValidationError>> Handle(
        Request request,
        AppDbContext database,
        CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(request.Email))
        {
            var existeEmail = await database.Empleados
                .AnyAsync(e => e.Email == request.Email, cancellationToken);

            if (existeEmail)
                return new ValidationError("El email ya está registrado.");
        }

        var existeDocumento = await database.Empleados
            .AnyAsync(e => e.NumeroDocumento == request.NumeroDocumento, cancellationToken);

        if (existeDocumento)
            return new ValidationError("El número de documento ya está registrado.");

        if (!Enum.TryParse<TipoDocumento>(request.TipoDocumento, out var tipoDocumento))
            return new ValidationError("Tipo de documento inválido.");

        var empleado = new Empleado
        {
            Nombres = request.Nombres.Trim(),
            Apellidos = request.Apellidos.Trim(),
            Email = string.IsNullOrWhiteSpace(request.Email) ? null : request.Email.Trim(),
            Direccion = string.IsNullOrWhiteSpace(request.Direccion) ? null : request.Direccion.Trim(),
            FechaNacimiento = request.FechaNacimiento,
            TipoDocumento = tipoDocumento,
            NumeroDocumento = request.NumeroDocumento.Trim(),
            NumeroTelefono = string.IsNullOrWhiteSpace(request.NumeroTelefono) ? null : request.NumeroTelefono.Trim()
        };

        await database.Empleados.AddAsync(empleado, cancellationToken);
        
        await database.SaveChangesAsync(cancellationToken);

        return TypedResults.Ok(new Response(
            empleado.Id,
            empleado.Nombres,
            empleado.Apellidos,
            empleado.Email,
            empleado.Direccion,
            empleado.FechaNacimiento,
            empleado.TipoDocumento.ToString(),
            empleado.NumeroDocumento,
            empleado.NumeroTelefono,
            empleado.FechaCreacion,
            empleado.Estado
            ));
    }
}
