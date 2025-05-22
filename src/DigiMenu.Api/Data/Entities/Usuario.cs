namespace DigiMenu.Api.Data.Entities;

public partial class Usuario : IEntity
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? Direccion { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string HashPassword { get; set; } = null!;

    public int? RolId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool Estado { get; set; } = true;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Rol? Rol { get; set; }
}
