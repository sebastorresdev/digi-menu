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

 Date: 20/05/2025 23:10:44
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

-- ----------------------------
-- Table structure for categoria_insumos
-- ----------------------------
DROP TABLE IF EXISTS "public"."categoria_insumos";
CREATE TABLE "public"."categoria_insumos" (
  "id" int4 NOT NULL DEFAULT nextval('categoria_insumos_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('categorias_productos_id_seq'::regclass),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of categorias_productos
-- ----------------------------

-- ----------------------------
-- Table structure for empresa
-- ----------------------------
DROP TABLE IF EXISTS "public"."empresa";
CREATE TABLE "public"."empresa" (
  "id" int4 NOT NULL DEFAULT nextval('empresa_id_seq'::regclass),
  "razon_social" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "sucursal" varchar(255) COLLATE "pg_catalog"."default",
  "direccion" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "telefono" varchar(32) COLLATE "pg_catalog"."default",
  "ruc" varchar(20) COLLATE "pg_catalog"."default",
  "pagina_web" text COLLATE "pg_catalog"."default",
  "email" varchar(255) COLLATE "pg_catalog"."default",
  "fecha_creacion" timestamptz(6) DEFAULT now()
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
  "id" int4 NOT NULL DEFAULT nextval('estaciones_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('impresoras_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('insumos_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('mesas_id_seq'::regclass),
  "nombre" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "capacidad" int4 NOT NULL,
  "estado" varchar(20) COLLATE "pg_catalog"."default",
  "salon_id" int4 NOT NULL
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
  "id" int4 NOT NULL DEFAULT nextval('pedido_detalle_pedido_detalle_id_seq'::regclass),
  "pedido_id" int4 NOT NULL,
  "producto_id" int4 NOT NULL,
  "cantidad" int4 NOT NULL,
  "observacion" text COLLATE "pg_catalog"."default",
  "estado" varchar(20) COLLATE "pg_catalog"."default"
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
  "id" int4 NOT NULL DEFAULT nextval('pedidos_id_seq'::regclass),
  "usuario_id" int4 NOT NULL,
  "mesa_id" int4 NOT NULL,
  "fecha" timestamptz(6) DEFAULT now(),
  "estado" varchar(20) COLLATE "pg_catalog"."default"
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
  "id" int4 NOT NULL DEFAULT nextval('permisos_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('productos_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('roles_id_seq'::regclass),
  "nombre" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "descripcion" varchar(255) COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of roles
-- ----------------------------

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
  "id" int4 NOT NULL DEFAULT nextval('salones_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('unidades_medida_id_seq'::regclass),
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
  "id" int4 NOT NULL DEFAULT nextval('usuarios_id_seq'::regclass),
  "nombres" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "apellidos" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "direccion" varchar(255) COLLATE "pg_catalog"."default",
  "fecha_nacimiento" timestamptz(6),
  "tipo_documento" varchar(20) COLLATE "pg_catalog"."default",
  "numero_documento" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "hash_password" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "rol_id" int4,
  "fecha_creacion" timestamptz(6) DEFAULT now(),
  "username" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO "public"."usuarios" VALUES (3, 'Sebastian David', 'Torres Chave', 'jr corregidores 147', NULL, 'DNI', '47931526', 'asdasdasdasdasd', NULL, '2025-05-20 22:56:55.792482-05', 'storres');

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
OWNED BY "public"."pedido_detalle"."id";
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
SELECT setval('"public"."roles_id_seq"', 1, false);

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
SELECT setval('"public"."usuarios_id_seq"', 3, true);

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE "public"."__EFMigrationsHistory" ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");

-- ----------------------------
-- Uniques structure for table categoria_insumos
-- ----------------------------
ALTER TABLE "public"."categoria_insumos" ADD CONSTRAINT "categoria_insumos_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Primary Key structure for table categoria_insumos
-- ----------------------------
ALTER TABLE "public"."categoria_insumos" ADD CONSTRAINT "categoria_insumos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table categorias_productos
-- ----------------------------
ALTER TABLE "public"."categorias_productos" ADD CONSTRAINT "categorias_productos_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Primary Key structure for table categorias_productos
-- ----------------------------
ALTER TABLE "public"."categorias_productos" ADD CONSTRAINT "categorias_productos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table empresa
-- ----------------------------
ALTER TABLE "public"."empresa" ADD CONSTRAINT "empresa_ruc_key" UNIQUE ("ruc");
ALTER TABLE "public"."empresa" ADD CONSTRAINT "empresa_email_key" UNIQUE ("email");

-- ----------------------------
-- Primary Key structure for table empresa
-- ----------------------------
ALTER TABLE "public"."empresa" ADD CONSTRAINT "empresa_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table estaciones
-- ----------------------------
ALTER TABLE "public"."estaciones" ADD CONSTRAINT "estaciones_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Primary Key structure for table estaciones
-- ----------------------------
ALTER TABLE "public"."estaciones" ADD CONSTRAINT "estaciones_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table impresoras
-- ----------------------------
ALTER TABLE "public"."impresoras" ADD CONSTRAINT "impresoras_ip_key" UNIQUE ("ip");

-- ----------------------------
-- Checks structure for table impresoras
-- ----------------------------
ALTER TABLE "public"."impresoras" ADD CONSTRAINT "impresoras_tipo_check" CHECK (tipo::text = ANY (ARRAY['ticket'::character varying, 'factura'::character varying]::text[]));

-- ----------------------------
-- Primary Key structure for table impresoras
-- ----------------------------
ALTER TABLE "public"."impresoras" ADD CONSTRAINT "impresoras_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table insumos
-- ----------------------------
ALTER TABLE "public"."insumos" ADD CONSTRAINT "insumos_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Primary Key structure for table insumos
-- ----------------------------
ALTER TABLE "public"."insumos" ADD CONSTRAINT "insumos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table mesas
-- ----------------------------
ALTER TABLE "public"."mesas" ADD CONSTRAINT "mesas_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Checks structure for table mesas
-- ----------------------------
ALTER TABLE "public"."mesas" ADD CONSTRAINT "mesas_estado_check" CHECK (estado::text = ANY (ARRAY['ocupada'::character varying, 'libre'::character varying, 'reservada'::character varying]::text[]));

-- ----------------------------
-- Primary Key structure for table mesas
-- ----------------------------
ALTER TABLE "public"."mesas" ADD CONSTRAINT "mesas_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Checks structure for table pedido_detalle
-- ----------------------------
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_cantidad_check" CHECK (cantidad > 0);
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_estado_check" CHECK (estado::text = ANY (ARRAY['pendiente'::character varying, 'en preparación'::character varying, 'listo'::character varying, 'servido'::character varying]::text[]));

-- ----------------------------
-- Primary Key structure for table pedido_detalle
-- ----------------------------
ALTER TABLE "public"."pedido_detalle" ADD CONSTRAINT "pedido_detalle_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Checks structure for table pedidos
-- ----------------------------
ALTER TABLE "public"."pedidos" ADD CONSTRAINT "pedidos_estado_check" CHECK (estado::text = ANY (ARRAY['pendiente'::character varying, 'en preparación'::character varying, 'servido'::character varying, 'cancelado'::character varying]::text[]));

-- ----------------------------
-- Primary Key structure for table pedidos
-- ----------------------------
ALTER TABLE "public"."pedidos" ADD CONSTRAINT "pedidos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table permisos
-- ----------------------------
ALTER TABLE "public"."permisos" ADD CONSTRAINT "permisos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table productos
-- ----------------------------
ALTER TABLE "public"."productos" ADD CONSTRAINT "productos_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table receta_productos
-- ----------------------------
ALTER TABLE "public"."receta_productos" ADD CONSTRAINT "receta_productos_pkey" PRIMARY KEY ("producto_id", "insumo_id");

-- ----------------------------
-- Primary Key structure for table roles
-- ----------------------------
ALTER TABLE "public"."roles" ADD CONSTRAINT "roles_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table roles_permisos
-- ----------------------------
ALTER TABLE "public"."roles_permisos" ADD CONSTRAINT "roles_permisos_pkey" PRIMARY KEY ("rol_id", "permiso_id");

-- ----------------------------
-- Uniques structure for table salones
-- ----------------------------
ALTER TABLE "public"."salones" ADD CONSTRAINT "salones_nombre_key" UNIQUE ("nombre");

-- ----------------------------
-- Primary Key structure for table salones
-- ----------------------------
ALTER TABLE "public"."salones" ADD CONSTRAINT "salones_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table unidades_medida
-- ----------------------------
ALTER TABLE "public"."unidades_medida" ADD CONSTRAINT "unidades_medida_nombre_key" UNIQUE ("nombre");
ALTER TABLE "public"."unidades_medida" ADD CONSTRAINT "unidades_medida_simbolo_key" UNIQUE ("simbolo");

-- ----------------------------
-- Primary Key structure for table unidades_medida
-- ----------------------------
ALTER TABLE "public"."unidades_medida" ADD CONSTRAINT "unidades_medida_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Uniques structure for table usuarios
-- ----------------------------
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_numero_documento_key" UNIQUE ("numero_documento");

-- ----------------------------
-- Checks structure for table usuarios
-- ----------------------------
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_tipo_documento_check" CHECK (tipo_documento::text = ANY (ARRAY['DNI'::character varying, 'CE'::character varying, 'PASS'::character varying]::text[]));

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
ALTER TABLE "public"."usuarios" ADD CONSTRAINT "usuarios_rol_id_fkey" FOREIGN KEY ("rol_id") REFERENCES "public"."roles" ("id") ON DELETE SET NULL ON UPDATE NO ACTION;
