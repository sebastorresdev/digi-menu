using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Empleados.Endpoints;

public class ListarEmpleados : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/", Handle)
        .WithSummary("Listar Empleados");

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

    public static async Task<List<Response>> Handle(
        AppDbContext database, CancellationToken cancellationToken)
    {
        return await database.Empleados
            .AsNoTracking()
            .OrderBy(e => e.FechaCreacion)
            .Select(Empleados => new Response
            (
                Empleados.Id,
                Empleados.Nombres,
                Empleados.Apellidos,
                Empleados.Email,
                Empleados.Direccion,
                Empleados.FechaNacimiento,
                Empleados.TipoDocumento.ToString(),
                Empleados.NumeroDocumento,
                Empleados.NumeroTelefono,
                Empleados.FechaCreacion,
                Empleados.Estado
            ))
            .ToListAsync(cancellationToken);
    }
}
