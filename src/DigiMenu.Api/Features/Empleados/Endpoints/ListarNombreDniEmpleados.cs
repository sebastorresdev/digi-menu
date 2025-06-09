using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Empleados.Endpoints;

public class ListarNombreDniEmpleados : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/nombre-dni", Handle)
        .WithSummary("Listar Nombre y dni de Empleados ");

    public record Response(
        int Id,
        string NombreDni);

    public static async Task<List<Response>> Handle(
        AppDbContext database, CancellationToken cancellationToken)
    {
        return await database.Empleados
            .AsNoTracking()
            .OrderBy(e => e.FechaCreacion)
            .Select(Empleados => new Response
            (
                Empleados.Id,
                $"{Empleados.Nombres} {Empleados.Apellidos} - ({Empleados.NumeroDocumento})"
            ))
            .ToListAsync(cancellationToken);
    }
}
