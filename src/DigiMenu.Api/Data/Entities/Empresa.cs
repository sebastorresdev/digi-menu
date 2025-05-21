namespace DigiMenu.Api.Data.Entities;
public partial class Empresa : IEntity
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Sucursal { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Ruc { get; set; }

    public string? PaginaWeb { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
