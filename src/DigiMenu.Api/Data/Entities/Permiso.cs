namespace DigiMenu.Api.Data.Entities;

public partial class Permiso : IEntity
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Rol> Roles { get; set; } = new List<Rol>();
}
