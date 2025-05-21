namespace DigiMenu.Api.Data.Entities;
public partial class RecetaProducto
{
    public int ProductoId { get; set; }

    public int InsumoId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual Insumo Insumo { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
