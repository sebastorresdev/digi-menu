using DigiMenu.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public virtual DbSet<CategoriaInsumo> CategoriaInsumos { get; set; }

    public virtual DbSet<CategoriasProducto> CategoriasProductos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estacion> Estaciones { get; set; }

    public virtual DbSet<Impresora> Impresoras { get; set; }

    public virtual DbSet<Insumo> Insumos { get; set; }

    public virtual DbSet<Mesa> Mesas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoDetalle> PedidoDetalles { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<RecetaProducto> RecetaProductos { get; set; }

    public virtual DbSet<Rol> Roles { get; set; }

    public virtual DbSet<Salon> Salones { get; set; }

    public virtual DbSet<UnidadMedida> UnidadesMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaInsumo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categoria_insumos_pkey");

            entity.ToTable("categoria_insumos");

            entity.HasIndex(e => e.Nombre, "categoria_insumos_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoSunat)
                .HasMaxLength(20)
                .HasColumnName("codigo_sunat");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CategoriasProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorias_productos_pkey");

            entity.ToTable("categorias_productos");

            entity.HasIndex(e => e.Nombre, "categorias_productos_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("empresa_pkey");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.Email, "empresa_email_key").IsUnique();

            entity.HasIndex(e => e.Ruc, "empresa_ruc_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.PaginaWeb).HasColumnName("pagina_web");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(255)
                .HasColumnName("razon_social");
            entity.Property(e => e.Ruc)
                .HasMaxLength(20)
                .HasColumnName("ruc");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(255)
                .HasColumnName("sucursal");
            entity.Property(e => e.Telefono)
                .HasMaxLength(32)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Estacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("estaciones_pkey");

            entity.ToTable("estaciones");

            entity.HasIndex(e => e.Nombre, "estaciones_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Impresora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("impresoras_pkey");

            entity.ToTable("impresoras");

            entity.HasIndex(e => e.Ip, "impresoras_ip_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstacionId).HasColumnName("estacion_id");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("ip");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Puerto)
                .HasMaxLength(10)
                .HasColumnName("puerto");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");

            entity.HasOne(d => d.Estacion).WithMany(p => p.Impresoras)
                .HasForeignKey(d => d.EstacionId)
                .HasConstraintName("impresoras_estacion_id_fkey");
        });

        modelBuilder.Entity<Insumo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("insumos_pkey");

            entity.ToTable("insumos");

            entity.HasIndex(e => e.Nombre, "insumos_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoriaInsumoId).HasColumnName("categoria_insumo_id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("precio_unitario");
            entity.Property(e => e.StockActual)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("stock_actual");
            entity.Property(e => e.StockMinimo)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("stock_minimo");
            entity.Property(e => e.UnidadId).HasColumnName("unidad_id");

            entity.HasOne(d => d.CategoriaInsumo).WithMany(p => p.Insumos)
                .HasForeignKey(d => d.CategoriaInsumoId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("insumos_categoria_insumo_id_fkey");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Insumos)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("insumos_unidad_id_fkey");
        });

        modelBuilder.Entity<Mesa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mesas_pkey");

            entity.ToTable("mesas");

            entity.HasIndex(e => e.Nombre, "mesas_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .HasColumnName("nombre");
            entity.Property(e => e.SalonId).HasColumnName("salon_id");

            entity.HasOne(d => d.Salon).WithMany(p => p.Mesas)
                .HasForeignKey(d => d.SalonId)
                .HasConstraintName("mesas_salon_id_fkey");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pedidos_pkey");

            entity.ToTable("pedidos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha");
            entity.Property(e => e.MesaId).HasColumnName("mesa_id");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Mesa).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.MesaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_mesa_id_fkey");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedidos_usuario_id_fkey");
        });

        modelBuilder.Entity<PedidoDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pedido_detalle_pkey");

            entity.ToTable("pedido_detalle");

            entity.Property(e => e.Id).HasColumnName("pedido_detalle_id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Observacion).HasColumnName("observacion");
            entity.Property(e => e.PedidoId).HasColumnName("pedido_id");
            entity.Property(e => e.ProductoId).HasColumnName("producto_id");

            entity.HasOne(d => d.Pedido).WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("pedido_detalle_pedido_id_fkey");

            entity.HasOne(d => d.Producto).WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pedido_detalle_producto_id_fkey");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("permisos_pkey");

            entity.ToTable("permisos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productos_pkey");

            entity.ToTable("productos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoriaProductoId).HasColumnName("categoria_producto_id");
            entity.Property(e => e.EstacionId).HasColumnName("estacion_id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasPrecision(10, 2)
                .HasColumnName("precio");

            entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaProductoId)
                .HasConstraintName("productos_categoria_producto_id_fkey");

            entity.HasOne(d => d.Estacion).WithMany(p => p.Productos)
                .HasForeignKey(d => d.EstacionId)
                .HasConstraintName("productos_estacion_id_fkey");
        });

        modelBuilder.Entity<RecetaProducto>(entity =>
        {
            entity.HasKey(e => new { e.ProductoId, e.InsumoId }).HasName("receta_productos_pkey");

            entity.ToTable("receta_productos");

            entity.Property(e => e.ProductoId).HasColumnName("producto_id");
            entity.Property(e => e.InsumoId).HasColumnName("insumo_id");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");

            entity.HasOne(d => d.Insumo).WithMany(p => p.RecetaProductos)
                .HasForeignKey(d => d.InsumoId)
                .HasConstraintName("receta_productos_insumo_id_fkey");

            entity.HasOne(d => d.Producto).WithMany(p => p.RecetaProductos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("receta_productos_producto_id_fkey");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");

            entity.HasMany(d => d.Permisos).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RolesPermiso",
                    r => r.HasOne<Permiso>().WithMany()
                        .HasForeignKey("PermisoId")
                        .HasConstraintName("roles_permisos_permiso_id_fkey"),
                    l => l.HasOne<Rol>().WithMany()
                        .HasForeignKey("RolId")
                        .HasConstraintName("roles_permisos_rol_id_fkey"),
                    j =>
                    {
                        j.HasKey("RolId", "PermisoId").HasName("roles_permisos_pkey");
                        j.ToTable("roles_permisos");
                        j.IndexerProperty<int>("RolId").HasColumnName("rol_id");
                        j.IndexerProperty<int>("PermisoId").HasColumnName("permiso_id");
                    });
        });

        modelBuilder.Entity<Salon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("salones_pkey");

            entity.ToTable("salones");

            entity.HasIndex(e => e.Nombre, "salones_nombre_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UnidadMedida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("unidades_medida_pkey");

            entity.ToTable("unidades_medida");

            entity.HasIndex(e => e.Nombre, "unidades_medida_nombre_key").IsUnique();

            entity.HasIndex(e => e.Simbolo, "unidades_medida_simbolo_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Simbolo)
                .HasMaxLength(10)
                .HasColumnName("simbolo");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("usuarios_pkey");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.NumeroDocumento, "usuarios_numero_documento_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(255)
                .HasColumnName("apellidos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.HashPassword)
                .HasMaxLength(255)
                .HasColumnName("hash_password");
            entity.Property(e => e.Nombres)
                .HasMaxLength(255)
                .HasColumnName("nombres");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .HasColumnName("numero_documento");
            entity.Property(e => e.RolId).HasColumnName("rol_id");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(20)
                .HasColumnName("tipo_documento");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("usuarios_rol_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
