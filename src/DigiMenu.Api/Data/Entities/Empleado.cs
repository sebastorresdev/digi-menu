using DigiMenu.Api.Data.Enums;

namespace DigiMenu.Api.Data.Entities;

public partial class Empleado : IEntity
{
    public int Id { get; set; }
    
    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;
    
    public string? Email { get; set; }
    
    public string? Direccion { get; set; }
    
    public DateTime? FechaNacimiento { get; set; }
    
    public TipoDocumento TipoDocumento { get; set; }
    
    public string NumeroDocumento { get; set; } = null!;
    
    public string? NumeroTelefono { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Estado { get; set; } = true;

    public virtual Usuario? Usuario { get; set; }
}
