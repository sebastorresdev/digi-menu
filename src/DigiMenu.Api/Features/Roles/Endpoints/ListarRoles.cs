using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Roles.Endpoints;

public class ListarRoles : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/", Handle)
        .WithSummary("Listar roles");

    public record Response(
        int Id,
        string Nombre,
        string? Descripcion);

    public static async Task<List<Response>> Handle(AppDbContext database, CancellationToken cancellationToken)
    {
        return await database.Roles
            .AsNoTracking()
            .Select(r => new Response
            (
                r.Id,
                r.Nombre,
                r.Descripcion
            ))
            .ToListAsync(cancellationToken);
    }
}
