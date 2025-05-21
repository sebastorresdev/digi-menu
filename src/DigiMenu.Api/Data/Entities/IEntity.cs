namespace DigiMenu.Api.Data.Entities;

public interface IEntity
{
    int Id { get; }
}

public interface IOwnedEntity
{
    int UsuarioId { get; }
}