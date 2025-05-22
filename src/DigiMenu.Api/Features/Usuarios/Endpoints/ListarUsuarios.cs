using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Common.Api.Requests;
using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Usuarios.Endpoints;

public class ListarUsuarios : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/", Handle)
        .WithSummary("Listar usuarios");

    public record Response(
        int Id,
        string Nombres,
        string Apellidos,
        string? Direccion,
        DateTime? FechaNacimiento,
        DateTime? FechaCreacion,
        string Username,
        string NumeroDocumento,
        string TipoDocumento,
        bool Estado
        );

    public static async Task<List<Response>> Handle(AppDbContext database, CancellationToken cancellationToken)
    {
        return await database.Usuarios
            .Select(u => new Response
            (
                u.Id,
                u.Nombres,
                u.Apellidos,
                u.Direccion,
                u.FechaNacimiento,
                u.FechaCreacion,
                u.Username,
                u.NumeroDocumento,
                u.TipoDocumento,
                u.Estado
            ))
            .ToListAsync(cancellationToken);
    }
}
