namespace DigiMenu.Api.Data.Entities;

public partial class Salon : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Capacidad { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Mesa> Mesas { get; set; } = new List<Mesa>();
}
