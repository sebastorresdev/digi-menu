/*
 Navicat Premium Dump SQL

 Source Server         : Postgresql
 Source Server Type    : PostgreSQL
 Source Server Version : 170000 (170000)
 Source Host           : localhost:5432
 Source Catalog        : digi_menu
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 170000 (170000)
 File Encoding         : 65001

 Date: 12/07/2025 15:46:51
*/


-- ----------------------------
-- Sequence structure for categoria_insumos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."categoria_insumos_id_seq";
CREATE SEQUENCE "public"."categoria_insumos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for categorias_productos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."categorias_productos_id_seq";
CREATE SEQUENCE "public"."categorias_productos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for empleados_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."empleados_id_seq";
CREATE SEQUENCE "public"."empleados_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for empresa_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."empresa_id_seq";
CREATE SEQUENCE "public"."empresa_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for estaciones_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."estaciones_id_seq";
CREATE SEQUENCE "public"."estaciones_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for impresoras_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."impresoras_id_seq";
CREATE SEQUENCE "public"."impresoras_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for insumos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."insumos_id_seq";
CREATE SEQUENCE "public"."insumos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for mesas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."mesas_id_seq";
CREATE SEQUENCE "public"."mesas_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for pedido_detalle_pedido_detalle_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."pedido_detalle_pedido_detalle_id_seq";
CREATE SEQUENCE "public"."pedido_detalle_pedido_detalle_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for pedidos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."pedidos_id_seq";
CREATE SEQUENCE "public"."pedidos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for permisos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."permisos_id_seq";
CREATE SEQUENCE "public"."permisos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for productos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."productos_id_seq";
CREATE SEQUENCE "public"."productos_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for roles_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."roles_id_seq";
CREATE SEQUENCE "public"."roles_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for salones_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."salones_id_seq";
CREATE SEQUENCE "public"."salones_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for unidades_medida_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."unidades_medida_id_seq";
CREATE SEQUENCE "public"."unidades_medida_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for usuarios_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."usuarios_id_seq";
CREATE SEQUENCE "public"."usuarios_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
DROP TABLE IF EXISTS "public"."__EFMigrationsHistory";
CREATE TABLE "public"."__EFMigrationsHistory" (
  "MigrationId" varchar(150) COLLATE "pg_catalog"."default" NOT NULL,
  "ProductVersion" varchar(32) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20250526064349_InitialCreate', '9.0.5');
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20250526065347_CambiarEstadoPedidoAVarchar', '9.0.5');

-- ----------------------------
-- Table structure for categoria_insumos
-- ----------------------------
DROP TABLE IF EXISTS "public"."categoria_insumos";
CREATE TABLE "public"."categoria_insumos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "descripcion" text COLLATE "pg_catalog"."default",
  "codigo_sunat" varchar(20) COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of categoria_insumos
-- ----------------------------

-- ----------------------------
-- Table structure for categorias_productos
-- ----------------------------
DROP TABLE IF EXISTS "public"."categorias_productos";
CREATE TABLE "public"."categorias_productos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of categorias_productos
-- ----------------------------

-- ----------------------------
-- Table structure for empleados
-- ----------------------------
DROP TABLE IF EXISTS "public"."empleados";
CREATE TABLE "public"."empleados" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombres" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "apellidos" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "email" varchar(255) COLLATE "pg_catalog"."default",
  "direccion" varchar(255) COLLATE "pg_catalog"."default",
  "fecha_nacimiento" timestamptz(6),
  "tipo_documento" text COLLATE "pg_catalog"."default" NOT NULL,
  "numero_documento" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "numero_telefono" varchar(20) COLLATE "pg_catalog"."default",
  "fecha_creacion" timestamptz(6) NOT NULL DEFAULT now(),
  "estado" bool NOT NULL DEFAULT true
)
;

-- ----------------------------
-- Records of empleados
-- ----------------------------
INSERT INTO "public"."empleados" VALUES (2, 'Miguel Angel', 'Zavaleta Chavez', 'mchavez@gamil.com', NULL, NULL, 'DNI', '70336727', '998783922', '2025-06-07 22:34:03.302859-05', 't');
INSERT INTO "public"."empleados" VALUES (1, 'Sebastian David', 'Torres Chavez', 'sebastorresdev@outlook.com', 'Jr Corregidores 147 - 149', '1991-08-02 00:00:00-05', 'DNI', '47931526', '948965622', '2025-05-28 00:37:14.906898-05', 't');
INSERT INTO "public"."empleados" VALUES (10, 'Flavia', 'Torres Robles', 'ftr19102020@gmail.com', 'Jr Corregidores 147 - villa fatima - rimac', '2020-10-19 00:00:00-05', 'DNI', '90224436', '948965621', '2025-06-08 03:43:55.669393-05', 't');
INSERT INTO "public"."empleados" VALUES (5, 'July Nelly', 'Torres Chavez', NULL, NULL, '1994-01-03 23:00:00-05', 'DNI', '70278923', '948965622', '2025-06-07 22:47:44.240578-05', 't');
INSERT INTO "public"."empleados" VALUES (11, 'Nelly Jacobita', 'Chavez Aspajo', NULL, NULL, '1970-04-02 00:00:00-05', 'DNI', '08098221', '987678987', '2025-06-08 03:53:34.380947-05', 't');
INSERT INTO "public"."empleados" VALUES (12, 'roel', 'gamboa ejem', NULL, NULL, '2010-02-03 00:00:00-05', 'DNI', '479316257', NULL, '2025-07-12 15:43:29.852892-05', 't');

-- ----------------------------
-- Table structure for empresa
-- ----------------------------
DROP TABLE IF EXISTS "public"."empresa";
CREATE TABLE "public"."empresa" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "razon_social" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "sucursal" varchar(255) COLLATE "pg_catalog"."default",
  "direccion" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "telefono" varchar(32) COLLATE "pg_catalog"."default",
  "ruc" varchar(20) COLLATE "pg_catalog"."default",
  "pagina_web" text COLLATE "pg_catalog"."default",
  "email" varchar(255) COLLATE "pg_catalog"."default",
  "fecha_creacion" timestamptz(6) NOT NULL DEFAULT now()
)
;

-- ----------------------------
-- Records of empresa
-- ----------------------------

-- ----------------------------
-- Table structure for estaciones
-- ----------------------------
DROP TABLE IF EXISTS "public"."estaciones";
CREATE TABLE "public"."estaciones" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of estaciones
-- ----------------------------

-- ----------------------------
-- Table structure for impresoras
-- ----------------------------
DROP TABLE IF EXISTS "public"."impresoras";
CREATE TABLE "public"."impresoras" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "ip" varchar(50) COLLATE "pg_catalog"."default",
  "puerto" varchar(10) COLLATE "pg_catalog"."default",
  "tipo" varchar(50) COLLATE "pg_catalog"."default",
  "estacion_id" int4 NOT NULL
)
;

-- ----------------------------
-- Records of impresoras
-- ----------------------------

-- ----------------------------
-- Table structure for insumos
-- ----------------------------
DROP TABLE IF EXISTS "public"."insumos";
CREATE TABLE "public"."insumos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "stock_actual" numeric(10,2) DEFAULT 0,
  "stock_minimo" numeric(10,2) DEFAULT 0,
  "precio_unitario" numeric(10,2) DEFAULT 0,
  "unidad_id" int4 NOT NULL,
  "categoria_insumo_id" int4
)
;

-- ----------------------------
-- Records of insumos
-- ----------------------------

-- ----------------------------
-- Table structure for mesas
-- ----------------------------
DROP TABLE IF EXISTS "public"."mesas";
CREATE TABLE "public"."mesas" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "capacidad" int4 NOT NULL,
  "salon_id" int4 NOT NULL,
  "estado_mesa" varchar(50) COLLATE "pg_catalog"."default" NOT NULL DEFAULT ''::character varying
)
;

-- ----------------------------
-- Records of mesas
-- ----------------------------

-- ----------------------------
-- Table structure for pedido_detalle
-- ----------------------------
DROP TABLE IF EXISTS "public"."pedido_detalle";
CREATE TABLE "public"."pedido_detalle" (
  "pedido_detalle_id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "pedido_id" int4 NOT NULL,
  "producto_id" int4 NOT NULL,
  "cantidad" int4 NOT NULL,
  "observacion" text COLLATE "pg_catalog"."default",
  "estado_pedido" varchar(50) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of pedido_detalle
-- ----------------------------

-- ----------------------------
-- Table structure for pedidos
-- ----------------------------
DROP TABLE IF EXISTS "public"."pedidos";
CREATE TABLE "public"."pedidos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "usuario_id" int4 NOT NULL,
  "mesa_id" int4 NOT NULL,
  "fecha" timestamptz(6) NOT NULL DEFAULT now(),
  "estado_pedido" varchar(50) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of pedidos
-- ----------------------------

-- ----------------------------
-- Table structure for permisos
-- ----------------------------
DROP TABLE IF EXISTS "public"."permisos";
CREATE TABLE "public"."permisos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of permisos
-- ----------------------------

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE IF EXISTS "public"."productos";
CREATE TABLE "public"."productos" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "categoria_producto_id" int4 NOT NULL,
  "precio" numeric(10,2) NOT NULL,
  "estacion_id" int4 NOT NULL
)
;

-- ----------------------------
-- Records of productos
-- ----------------------------

-- ----------------------------
-- Table structure for receta_productos
-- ----------------------------
DROP TABLE IF EXISTS "public"."receta_productos";
CREATE TABLE "public"."receta_productos" (
  "producto_id" int4 NOT NULL,
  "insumo_id" int4 NOT NULL,
  "cantidad" numeric(10,2) NOT NULL
)
;

-- ----------------------------
-- Records of receta_productos
-- ----------------------------

-- ----------------------------
-- Table structure for roles
-- ----------------------------
DROP TABLE IF EXISTS "public"."roles";
CREATE TABLE "public"."roles" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "descripcion" varchar(255) COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of roles
-- ----------------------------
INSERT INTO "public"."roles" VALUES (1, 'Administrador', NULL);
INSERT INTO "public"."roles" VALUES (2, 'Cocina', NULL);
INSERT INTO "public"."roles" VALUES (3, 'Mozo', NULL);

-- ----------------------------
-- Table structure for roles_permisos
-- ----------------------------
DROP TABLE IF EXISTS "public"."roles_permisos";
CREATE TABLE "public"."roles_permisos" (
  "rol_id" int4 NOT NULL,
  "permiso_id" int4 NOT NULL
)
;

-- ----------------------------
-- Records of roles_permisos
-- ----------------------------

-- ----------------------------
-- Table structure for salones
-- ----------------------------
DROP TABLE IF EXISTS "public"."salones";
CREATE TABLE "public"."salones" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "capacidad" int4,
  "estado" bool DEFAULT true
)
;

-- ----------------------------
-- Records of salones
-- ----------------------------

-- ----------------------------
-- Table structure for unidades_medida
-- ----------------------------
DROP TABLE IF EXISTS "public"."unidades_medida";
CREATE TABLE "public"."unidades_medida" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "nombre" varchar(100) COLLATE "pg_catalog"."default" NOT NULL,
  "simbolo" varchar(10) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of unidades_medida
-- ----------------------------

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS "public"."usuarios";
CREATE TABLE "public"."usuarios" (
  "id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1
),
  "username" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "hash_password" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "fecha_creacion" timestamptz(6) NOT NULL DEFAULT now(),
  "estado" bool NOT NULL DEFAULT true,
  "rol_id" int4 NOT NULL,
  "empleado_id" int4 NOT NULL
)
;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO "public"."usuarios" VALUES (4, 'storres', '69E4A7FAF53035ACD4C9642C8F2AF198D25CF6B1E1A4724CBD218E53A258D440-27845F6CA0AF4864B474ECA7D1033EAF', '2025-05-28 00:40:14.071073-05', 't', 1, 1);
INSERT INTO "public"."usuarios" VALUES (8, 'jtorres', '227BC522480CE52EE1252449F1EA17959C2B53827285BF5831F14AC93D5991C7-0BE5EB722C4D1D71C4357A46F409EA92', '2025-06-07 22:50:13.662809-05', 't', 2, 5);
INSERT INTO "public"."usuarios" VALUES (11, 'mchavez', '04E455E9DEA9C8524B18E1105AAF254AD427C8AF5BD649C2B3405DD7271615F8-A61A21DF0F8EF546E33546B399E1C2E3', '2025-06-08 21:04:03.758405-05', 't', 1, 2);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."categoria_insumos_id_seq"
OWNED BY "public"."categoria_insumos"."id";
SELECT setval('"public"."categoria_insumos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."categorias_productos_id_seq"
OWNED BY "public"."categorias_productos"."id";
SELECT setval('"public"."categorias_productos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."empleados_id_seq"
OWNED BY "public"."empleados"."id";
SELECT setval('"public"."empleados_id_seq"', 12, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."empresa_id_seq"
OWNED BY "public"."empresa"."id";
SELECT setval('"public"."empresa_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."estaciones_id_seq"
OWNED BY "public"."estaciones"."id";
SELECT setval('"public"."estaciones_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."impresoras_id_seq"
OWNED BY "public"."impresoras"."id";
SELECT setval('"public"."impresoras_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."insumos_id_seq"
OWNED BY "public"."insumos"."id";
SELECT setval('"public"."insumos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."mesas_id_seq"
OWNED BY "public"."mesas"."id";
SELECT setval('"public"."mesas_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."pedido_detalle_pedido_detalle_id_seq"
OWNED BY "public"."pedido_detalle"."pedido_detalle_id";
SELECT setval('"public"."pedido_detalle_pedido_detalle_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."pedidos_id_seq"
OWNED BY "public"."pedidos"."id";
SELECT setval('"public"."pedidos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."permisos_id_seq"
OWNED BY "public"."permisos"."id";
SELECT setval('"public"."permisos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."productos_id_seq"
OWNED BY "public"."productos"."id";
SELECT setval('"public"."productos_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."roles_id_seq"
OWNED BY "public"."roles"."id";
SELECT setval('"public"."roles_id_seq"', 3, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."salones_id_seq"
OWNED BY "public"."salones"."id";
SELECT setval('"public"."salones_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."unidades_medida_id_seq"
OWNED BY "public"."unidades_medida"."id";
SELECT setval('"public"."unidades_medida_id_seq"', 1, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."usuarios_id_seq"
OWNED BY "public"."usuarios"."id";
SELECT setval('"public"."usuarios_id_seq"', 11, true);

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE "public"."__EFMigrationsHistory" ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");

-- ----------------------------
-- Auto increment value for categoria_insumos
-- ----------------------------
SELECT setval('"public"."categoria_insumos_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table categoria_insumos
-- ----------------------------
CREATE UNIQUE INDEX "categoria_insumos_nombre_key" ON "public"."categoria_insumos" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table categoria_insumos
-- ----------------------------
ALTER TABLE "public"."categoria_insumos" ADD CONSTRAINT "categoria_insumos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for categorias_productos
-- ----------------------------
SELECT setval('"public"."categorias_productos_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table categorias_productos
-- ----------------------------
CREATE UNIQUE INDEX "categorias_productos_nombre_key" ON "public"."categorias_productos" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table categorias_productos
-- ----------------------------
ALTER TABLE "public"."categorias_productos" ADD CONSTRAINT "categorias_productos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for empleados
-- ----------------------------
SELECT setval('"public"."empleados_id_seq"', 12, true);

-- ----------------------------
-- Indexes structure for table empleados
-- ----------------------------
CREATE UNIQUE INDEX "empleados_email_key" ON "public"."empleados" USING btree (
  "email" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "empleados_numero_documento_key" ON "public"."empleados" USING btree (
  "numero_documento" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table empleados
-- ----------------------------
ALTER TABLE "public"."empleados" ADD CONSTRAINT "empleado_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for empresa
-- ----------------------------
SELECT setval('"public"."empresa_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table empresa
-- ----------------------------
CREATE UNIQUE INDEX "empresa_email_key" ON "public"."empresa" USING btree (
  "email" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "empresa_ruc_key" ON "public"."empresa" USING btree (
  "ruc" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table empresa
-- ----------------------------
ALTER TABLE "public"."empresa" ADD CONSTRAINT "empresa_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for estaciones
-- ----------------------------
SELECT setval('"public"."estaciones_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table estaciones
-- ----------------------------
CREATE UNIQUE INDEX "estaciones_nombre_key" ON "public"."estaciones" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table estaciones
-- ----------------------------
ALTER TABLE "public"."estaciones" ADD CONSTRAINT "estaciones_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for impresoras
-- ----------------------------
SELECT setval('"public"."impresoras_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table impresoras
-- ----------------------------
CREATE INDEX "IX_impresoras_estacion_id" ON "public"."impresoras" USING btree (
  "estacion_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "impresoras_ip_key" ON "public"."impresoras" USING btree (
  "ip" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table impresoras
-- ----------------------------
ALTER TABLE "public"."impresoras" ADD CONSTRAINT "impresoras_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for insumos
-- ----------------------------
SELECT setval('"public"."insumos_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table insumos
-- ----------------------------
CREATE INDEX "IX_insumos_categoria_insumo_id" ON "public"."insumos" USING btree (
  "categoria_insumo_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_insumos_unidad_id" ON "public"."insumos" USING btree (
  "unidad_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "insumos_nombre_key" ON "public"."insumos" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table insumos
-- ----------------------------
ALTER TABLE "public"."insumos" ADD CONSTRAINT "insumos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for mesas
-- ----------------------------
SELECT setval('"public"."mesas_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table mesas
-- ----------------------------
CREATE INDEX "IX_mesas_salon_id" ON "public"."mesas" USING btree (
  "salon_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "mesas_nombre_key" ON "public"."mesas" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table mesas
-- ----------------------------
ALTER TABLE "public"."mesas" ADD CONSTRAINT "mesas_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for pedido_detalle
-- ----------------------------
SELECT setval('"public"."pedido_detalle_pedido_detalle_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table pedido_detalle
-- ----------------------------
CREATE INDEX "IX_pedido_detalle_pedido_id" ON "public"."pedido_detalle" USING btree (
  "pedido_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_pedido_detalle_producto_id" ON "public"."pedido_detalle" USING btree (
  "producto_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table pedido_detalle
-- ----------------------------
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_pkey" PRIMARY KEY ("pedido_detalle_id");

-- ----------------------------
-- Auto increment value for pedidos
-- ----------------------------
SELECT setval('"public"."pedidos_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table pedidos
-- ----------------------------
CREATE INDEX "IX_pedidos_mesa_id" ON "public"."pedidos" USING btree (
  "mesa_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_pedidos_usuario_id" ON "public"."pedidos" USING btree (
  "usuario_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table pedidos
-- ----------------------------
ALTER TABLE "public"."pedidos" ADD CONSTRAINT "pedidos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for permisos
-- ----------------------------
SELECT setval('"public"."permisos_id_seq"', 1, false);

-- ----------------------------
-- Primary Key structure for table permisos
-- ----------------------------
ALTER TABLE "public"."permisos" ADD CONSTRAINT "permisos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for productos
-- ----------------------------
SELECT setval('"public"."productos_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table productos
-- ----------------------------
CREATE INDEX "IX_productos_categoria_producto_id" ON "public"."productos" USING btree (
  "categoria_producto_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_productos_estacion_id" ON "public"."productos" USING btree (
  "estacion_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table productos
-- ----------------------------
ALTER TABLE "public"."productos" ADD CONSTRAINT "productos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Indexes structure for table receta_productos
-- ----------------------------
CREATE INDEX "IX_receta_productos_insumo_id" ON "public"."receta_productos" USING btree (
  "insumo_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table receta_productos
-- ----------------------------
ALTER TABLE "public"."receta_productos" ADD CONSTRAINT "receta_productos_pkey" PRIMARY KEY ("producto_id", "insumo_id");

-- ----------------------------
-- Auto increment value for roles
-- ----------------------------
SELECT setval('"public"."roles_id_seq"', 3, true);

-- ----------------------------
-- Primary Key structure for table roles
-- ----------------------------
ALTER TABLE "public"."roles" ADD CONSTRAINT "roles_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Indexes structure for table roles_permisos
-- ----------------------------
CREATE INDEX "IX_roles_permisos_permiso_id" ON "public"."roles_permisos" USING btree (
  "permiso_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table roles_permisos
-- ----------------------------
ALTER TABLE "public"."roles_permisos" ADD CONSTRAINT "roles_permisos_pkey" PRIMARY KEY ("rol_id", "permiso_id");

-- ----------------------------
-- Auto increment value for salones
-- ----------------------------
SELECT setval('"public"."salones_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table salones
-- ----------------------------
CREATE UNIQUE INDEX "salones_nombre_key" ON "public"."salones" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table salones
-- ----------------------------
ALTER TABLE "public"."salones" ADD CONSTRAINT "salones_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for unidades_medida
-- ----------------------------
SELECT setval('"public"."unidades_medida_id_seq"', 1, false);

-- ----------------------------
-- Indexes structure for table unidades_medida
-- ----------------------------
CREATE UNIQUE INDEX "unidades_medida_nombre_key" ON "public"."unidades_medida" USING btree (
  "nombre" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "unidades_medida_simbolo_key" ON "public"."unidades_medida" USING btree (
  "simbolo" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table unidades_medida
-- ----------------------------
ALTER TABLE "public"."unidades_medida" ADD CONSTRAINT "unidades_medida_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Auto increment value for usuarios
-- ----------------------------
SELECT setval('"public"."usuarios_id_seq"', 11, true);

-- ----------------------------
-- Indexes structure for table usuarios
-- ----------------------------
CREATE UNIQUE INDEX "IX_usuarios_empleado_id" ON "public"."usuarios" USING btree (
  "empleado_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_usuarios_rol_id" ON "public"."usuarios" USING btree (
  "rol_id" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "usuarios_username_key" ON "public"."usuarios" USING btree (
  "username" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table usuarios
-- ----------------------------
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Foreign Keys structure for table impresoras
-- ----------------------------
ALTER TABLE "public"."impresoras" ADD CONSTRAINT "impresoras_estacion_id_fkey" FOREIGN KEY ("estacion_id") REFERENCES "public"."estaciones" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table insumos
-- ----------------------------
ALTER TABLE "public"."insumos" ADD CONSTRAINT "insumos_categoria_insumo_id_fkey" FOREIGN KEY ("categoria_insumo_id") REFERENCES "public"."categoria_insumos" ("id") ON DELETE SET NULL ON UPDATE NO ACTION;
ALTER TABLE "public"."insumos" ADD CONSTRAINT "insumos_unidad_id_fkey" FOREIGN KEY ("unidad_id") REFERENCES "public"."unidades_medida" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table mesas
-- ----------------------------
ALTER TABLE "public"."mesas" ADD CONSTRAINT "mesas_salon_id_fkey" FOREIGN KEY ("salon_id") REFERENCES "public"."salones" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table pedido_detalle
-- ----------------------------
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_pedido_id_fkey" FOREIGN KEY ("pedido_id") REFERENCES "public"."pedidos" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_producto_id_fkey" FOREIGN KEY ("producto_id") REFERENCES "public"."productos" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table pedidos
-- ----------------------------
ALTER TABLE "public"."pedidos" ADD CONSTRAINT "pedidos_mesa_id_fkey" FOREIGN KEY ("mesa_id") REFERENCES "public"."mesas" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."pedidos" ADD CONSTRAINT "pedidos_usuario_id_fkey" FOREIGN KEY ("usuario_id") REFERENCES "public"."usuarios" ("id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table productos
-- ----------------------------
ALTER TABLE "public"."productos" ADD CONSTRAINT "productos_categoria_producto_id_fkey" FOREIGN KEY ("categoria_producto_id") REFERENCES "public"."categorias_productos" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."productos" ADD CONSTRAINT "productos_estacion_id_fkey" FOREIGN KEY ("estacion_id") REFERENCES "public"."estaciones" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table receta_productos
-- ----------------------------
ALTER TABLE "public"."receta_productos" ADD CONSTRAINT "receta_productos_insumo_id_fkey" FOREIGN KEY ("insumo_id") REFERENCES "public"."insumos" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."receta_productos" ADD CONSTRAINT "receta_productos_producto_id_fkey" FOREIGN KEY ("producto_id") REFERENCES "public"."productos" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table roles_permisos
-- ----------------------------
ALTER TABLE "public"."roles_permisos" ADD CONSTRAINT "roles_permisos_permiso_id_fkey" FOREIGN KEY ("permiso_id") REFERENCES "public"."permisos" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."roles_permisos" ADD CONSTRAINT "roles_permisos_rol_id_fkey" FOREIGN KEY ("rol_id") REFERENCES "public"."roles" ("id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table usuarios
-- ----------------------------
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_empleado_id_fkey" FOREIGN KEY ("empleado_id") REFERENCES "public"."empleados" ("id") ON DELETE RESTRICT ON UPDATE NO ACTION;
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_rol_id_fkey" FOREIGN KEY ("rol_id") REFERENCES "public"."roles" ("id") ON DELETE SET NULL ON UPDATE NO ACTION;
