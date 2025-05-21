namespace DigiMenu.Api.Data.Entities;
public partial class Estacion : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Impresora> Impresoras { get; set; } = new List<Impresora>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
