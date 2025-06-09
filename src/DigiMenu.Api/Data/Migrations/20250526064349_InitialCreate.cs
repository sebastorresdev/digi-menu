using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigiMenu.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria_insumos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    codigo_sunat = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("categoria_insumos_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categorias_productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("categorias_productos_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombres = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    apellidos = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    direccion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tipo_documento = table.Column<string>(type: "text", nullable: false),
                    numero_documento = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    numero_telefono = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("empleado_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razon_social = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    sucursal = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    direccion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    telefono = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    ruc = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    pagina_web = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("empresa_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("estaciones_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permisos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("permisos_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("roles_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "salones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    capacidad = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("salones_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "unidades_medida",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    simbolo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("unidades_medida_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "impresoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ip = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    puerto = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    tipo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    estacion_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("impresoras_pkey", x => x.id);
                    table.ForeignKey(
                        name: "impresoras_estacion_id_fkey",
                        column: x => x.estacion_id,
                        principalTable: "estaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    categoria_producto_id = table.Column<int>(type: "integer", nullable: false),
                    precio = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    estacion_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("productos_pkey", x => x.id);
                    table.ForeignKey(
                        name: "productos_categoria_producto_id_fkey",
                        column: x => x.categoria_producto_id,
                        principalTable: "categorias_productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "productos_estacion_id_fkey",
                        column: x => x.estacion_id,
                        principalTable: "estaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roles_permisos",
                columns: table => new
                {
                    rol_id = table.Column<int>(type: "integer", nullable: false),
                    permiso_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("roles_permisos_pkey", x => new { x.rol_id, x.permiso_id });
                    table.ForeignKey(
                        name: "roles_permisos_permiso_id_fkey",
                        column: x => x.permiso_id,
                        principalTable: "permisos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "roles_permisos_rol_id_fkey",
                        column: x => x.rol_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    hash_password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    rol_id = table.Column<int>(type: "integer", nullable: false),
                    empleado_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usuarios_pkey", x => x.id);
                    table.ForeignKey(
                        name: "usuarios_empleado_id_fkey",
                        column: x => x.empleado_id,
                        principalTable: "empleados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuarios_rol_id_fkey",
                        column: x => x.rol_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "mesas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    capacidad = table.Column<int>(type: "integer", nullable: false),
                    estado = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    salon_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("mesas_pkey", x => x.id);
                    table.ForeignKey(
                        name: "mesas_salon_id_fkey",
                        column: x => x.salon_id,
                        principalTable: "salones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "insumos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    stock_actual = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, defaultValueSql: "0"),
                    stock_minimo = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, defaultValueSql: "0"),
                    precio_unitario = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, defaultValueSql: "0"),
                    unidad_id = table.Column<int>(type: "integer", nullable: false),
                    categoria_insumo_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("insumos_pkey", x => x.id);
                    table.ForeignKey(
                        name: "insumos_categoria_insumo_id_fkey",
                        column: x => x.categoria_insumo_id,
                        principalTable: "categoria_insumos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "insumos_unidad_id_fkey",
                        column: x => x.unidad_id,
                        principalTable: "unidades_medida",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario_id = table.Column<int>(type: "integer", nullable: false),
                    mesa_id = table.Column<int>(type: "integer", nullable: false),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    estado_pedido = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pedidos_pkey", x => x.id);
                    table.ForeignKey(
                        name: "pedidos_mesa_id_fkey",
                        column: x => x.mesa_id,
                        principalTable: "mesas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "pedidos_usuario_id_fkey",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "receta_productos",
                columns: table => new
                {
                    producto_id = table.Column<int>(type: "integer", nullable: false),
                    insumo_id = table.Column<int>(type: "integer", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("receta_productos_pkey", x => new { x.producto_id, x.insumo_id });
                    table.ForeignKey(
                        name: "receta_productos_insumo_id_fkey",
                        column: x => x.insumo_id,
                        principalTable: "insumos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "receta_productos_producto_id_fkey",
                        column: x => x.producto_id,
                        principalTable: "productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido_detalle",
                columns: table => new
                {
                    pedido_detalle_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pedido_id = table.Column<int>(type: "integer", nullable: false),
                    producto_id = table.Column<int>(type: "integer", nullable: false),
                    cantidad = table.Column<int>(type: "integer", nullable: false),
                    observacion = table.Column<string>(type: "text", nullable: true),
                    estado_pedido = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pedido_detalle_pkey", x => x.pedido_detalle_id);
                    table.ForeignKey(
                        name: "pedido_detalle_pedido_id_fkey",
                        column: x => x.pedido_id,
                        principalTable: "pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "pedido_detalle_producto_id_fkey",
                        column: x => x.producto_id,
                        principalTable: "productos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "categoria_insumos_nombre_key",
                table: "categoria_insumos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "categorias_productos_nombre_key",
                table: "categorias_productos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "empleados_email_key",
                table: "empleados",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "empleados_numero_documento_key",
                table: "empleados",
                column: "numero_documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "empresa_email_key",
                table: "empresa",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "empresa_ruc_key",
                table: "empresa",
                column: "ruc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "estaciones_nombre_key",
                table: "estaciones",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "impresoras_ip_key",
                table: "impresoras",
                column: "ip",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_impresoras_estacion_id",
                table: "impresoras",
                column: "estacion_id");

            migrationBuilder.CreateIndex(
                name: "insumos_nombre_key",
                table: "insumos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_insumos_categoria_insumo_id",
                table: "insumos",
                column: "categoria_insumo_id");

            migrationBuilder.CreateIndex(
                name: "IX_insumos_unidad_id",
                table: "insumos",
                column: "unidad_id");

            migrationBuilder.CreateIndex(
                name: "IX_mesas_salon_id",
                table: "mesas",
                column: "salon_id");

            migrationBuilder.CreateIndex(
                name: "mesas_nombre_key",
                table: "mesas",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedido_detalle_pedido_id",
                table: "pedido_detalle",
                column: "pedido_id");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_detalle_producto_id",
                table: "pedido_detalle",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_mesa_id",
                table: "pedidos",
                column: "mesa_id");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_usuario_id",
                table: "pedidos",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_categoria_producto_id",
                table: "productos",
                column: "categoria_producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_estacion_id",
                table: "productos",
                column: "estacion_id");

            migrationBuilder.CreateIndex(
                name: "IX_receta_productos_insumo_id",
                table: "receta_productos",
                column: "insumo_id");

            migrationBuilder.CreateIndex(
                name: "IX_roles_permisos_permiso_id",
                table: "roles_permisos",
                column: "permiso_id");

            migrationBuilder.CreateIndex(
                name: "salones_nombre_key",
                table: "salones",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unidades_medida_nombre_key",
                table: "unidades_medida",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unidades_medida_simbolo_key",
                table: "unidades_medida",
                column: "simbolo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_empleado_id",
                table: "usuarios",
                column: "empleado_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_rol_id",
                table: "usuarios",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "usuarios_username_key",
                table: "usuarios",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "impresoras");

            migrationBuilder.DropTable(
                name: "pedido_detalle");

            migrationBuilder.DropTable(
                name: "receta_productos");

            migrationBuilder.DropTable(
                name: "roles_permisos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "insumos");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "permisos");

            migrationBuilder.DropTable(
                name: "mesas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "categoria_insumos");

            migrationBuilder.DropTable(
                name: "unidades_medida");

            migrationBuilder.DropTable(
                name: "categorias_productos");

            migrationBuilder.DropTable(
                name: "estaciones");

            migrationBuilder.DropTable(
                name: "salones");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
