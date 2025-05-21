namespace DigiMenu.Api.Data.Entities;

public partial class Producto : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int CategoriaProductoId { get; set; }

    public decimal Precio { get; set; }

    public int EstacionId { get; set; }

    public virtual CategoriasProducto CategoriaProducto { get; set; } = null!;

    public virtual Estacion Estacion { get; set; } = null!;

    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();

    public virtual ICollection<RecetaProducto> RecetaProductos { get; set; } = new List<RecetaProducto>();
}
