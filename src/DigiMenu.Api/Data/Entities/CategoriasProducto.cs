namespace DigiMenu.Api.Data.Entities;

public partial class CategoriasProducto : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
