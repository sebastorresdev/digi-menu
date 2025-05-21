namespace DigiMenu.Api.Data.Entities;
public partial class Impresora : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Ip { get; set; }

    public string? Puerto { get; set; }

    public string? Tipo { get; set; }

    public int EstacionId { get; set; }

    public virtual Estacion Estacion { get; set; } = null!;
}
