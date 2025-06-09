using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Data;
using DigiMenu.Api.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DigiMenu.Api.Features.Roles.Endpoints;

public class CrearRol : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapPost("/", Handle)
        .WithSummary("Crear rol")
        .WithRequestValidation<Request>();

    public record Request(
        string Nombre,
        string? Descripcion);

    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().MaximumLength(255);
            RuleFor(x => x.Descripcion).MaximumLength(255);
        }
    }

    public record Response(
        int Id);

    public static async Task<Ok<Response>> Handle(
        Request request,
        AppDbContext database,
        CancellationToken cancellationToken)
    {
        var rol = new Rol
        {
            Nombre = request.Nombre,
            Descripcion = request.Descripcion
        };

        await database.Roles.AddAsync(rol, cancellationToken);
        await database.SaveChangesAsync(cancellationToken);
        return TypedResults.Ok(new Response(rol.Id));
    }
}
