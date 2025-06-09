namespace DigiMenu.Api.Data.Entities;

public partial class Usuario : IEntity
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string HashPassword { get; set; } = null!;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Estado { get; set; } = true;

    public int RolId { get; set; }

    public int EmpleadoId { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Rol Rol { get; set; } = null!;
    
    public virtual Empleado Empleado { get; set; } = null!;
}
