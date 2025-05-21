using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Data;
using DigiMenu.Api.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Usuarios.Endpoints;

public class GetUsuarioById : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/{id:int}", Handle)
        .WithSummary("Get usuario by Id")
        .WithRequestValidation<Request>()
        .WithEnsureEntityExists<Usuario, Request>(x => x.Id);

    public record Request(int Id);
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }

    public record Response(
        int Id,
        string Nombres,
        string Apellidos,
        string? Direccion,
        DateTime? FechaCreacion,
        string Username
        );

    public static async Task<Results<Ok<Response>, NotFound>> Handle(
        [AsParameters] Request request, 
        AppDbContext database, 
        CancellationToken cancellationToken)
    {
        var usuario = await database.Usuarios
            .Where(x => x.Id == request.Id)
            .Select(x => new Response(
                x.Id,
                x.Nombres,
                x.Apellidos,
                x.Direccion,
                x.FechaCreacion,
                x.Username
            ))
            .SingleOrDefaultAsync(cancellationToken);

        return usuario is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(usuario);
    }

}
