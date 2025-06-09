using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Data;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Usuarios.Endpoints;

public class ObtenerUsuarioPorId : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/{id:int}", Handle)
        .WithSummary("Obtener usuario por Id")
        .WithRequestValidation<Request>();

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
        string Username,
        DateTime FechaCreacion,
        string RolName);


    public static async Task<Results<Ok<Response>, NotFound>> Handle(
        [AsParameters] Request request,
        AppDbContext database,
        CancellationToken cancellationToken)
    {
        var usuario = await database.Usuarios
            .AsNoTracking()
            .Where(x => x.Id == request.Id)
            .Select(x => new Response(
                x.Id,
                x.Username,
                x.FechaCreacion,
                x.Rol.Nombre
            ))
            .SingleOrDefaultAsync(cancellationToken);

        return usuario is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(usuario);
    }
}
