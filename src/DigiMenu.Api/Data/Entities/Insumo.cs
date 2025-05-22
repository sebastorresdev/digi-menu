namespace DigiMenu.Api.Data.Entities;

public partial class Insumo : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal? StockActual { get; set; }

    public decimal? StockMinimo { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public int UnidadId { get; set; }

    public int? CategoriaInsumoId { get; set; }

    public virtual CategoriaInsumo? CategoriaInsumo { get; set; }

    public virtual ICollection<RecetaProducto> RecetaProductos { get; set; } = new List<RecetaProducto>();

    public virtual UnidadMedida Unidad { get; set; } = null!;
}
