using DigiMenu.Api.Data.Enums;

namespace DigiMenu.Api.Data.Entities;

public partial class Pedido : IEntity
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int MesaId { get; set; }

    public DateTime Fecha { get; set; }

    public EstadoPedido EstadoPedido { get; set; } = EstadoPedido.Pendiente;

    public virtual Mesa Mesa { get; set; } = null!;

    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();

    public virtual Usuario Usuario { get; set; } = null!;
}
