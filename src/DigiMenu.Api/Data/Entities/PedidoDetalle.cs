using DigiMenu.Api.Data.Enums;

namespace DigiMenu.Api.Data.Entities;

public partial class PedidoDetalle : IEntity
{
    public int Id { get; set; }

    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public string? Observacion { get; set; }

    public EstadoPedido EstadoPedido { get; set; } = EstadoPedido.Pendiente;

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
