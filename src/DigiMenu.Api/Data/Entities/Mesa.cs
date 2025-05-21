namespace DigiMenu.Api.Data.Entities;

public partial class Mesa : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Capacidad { get; set; }

    public string? Estado { get; set; }

    public int SalonId { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Salon Salon { get; set; } = null!;
}
