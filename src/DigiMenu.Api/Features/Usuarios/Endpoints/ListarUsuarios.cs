using DigiMenu.Api.Common.Api;
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
        string Username,
        DateTime FechaCreacion,
        string NombreRol,
        string NombreEmpleado,
        bool Estado);

    public static async Task<List<Response>> Handle(AppDbContext database, CancellationToken cancellationToken)
    {
        return await database.Usuarios
            .AsNoTracking()
            .Select(u => new Response
            (
                u.Id,
                u.Username,
                u.FechaCreacion,
                u.Rol.Nombre,
                $"{u.Empleado.Nombres } {u.Empleado.Apellidos}",
                u.Estado
            ))
            .ToListAsync(cancellationToken);
    }
}
