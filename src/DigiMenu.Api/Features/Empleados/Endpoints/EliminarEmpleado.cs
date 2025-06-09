using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Common.Api.Results;
using DigiMenu.Api.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Features.Empleados.Endpoints;

public class EliminarEmpleado : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
    .MapDelete("/{id:int}", Handle)
    .WithSummary("Eliminar un empleado por ID")
    .WithRequestValidation<Request>();

    public record Request(int Id);

    public static async Task<Results<NoContent, ValidationError>> Handle(
        int id,
        AppDbContext database,
        CancellationToken cancellationToken)
    {
        var empleado = await database.Empleados.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        
        if (empleado == null)
        {
            return new ValidationError("Empleado no encontrado");
        }

        database.Empleados.Remove(empleado);
        await database.SaveChangesAsync(cancellationToken);
        return TypedResults.NoContent();
    }
}
