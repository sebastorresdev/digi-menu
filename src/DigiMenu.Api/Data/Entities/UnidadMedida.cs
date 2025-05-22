namespace DigiMenu.Api.Data.Entities;

public partial class UnidadMedida : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Simbolo { get; set; } = null!;

    public virtual ICollection<Insumo> Insumos { get; set; } = new List<Insumo>();
}
