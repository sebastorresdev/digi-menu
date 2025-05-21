namespace DigiMenu.Api.Data.Entities;

public partial class CategoriaInsumo : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CodigoSunat { get; set; }

    public virtual ICollection<Insumo> Insumos { get; set; } = new List<Insumo>();
}
