/*==============================================================*/
/* DBMS name:      PostgreSQL 9.x                               */
/* Created on:     22/04/2024 8:00:26                           */
/*==============================================================*/


drop index ARTICULOS_PK;

drop table ARTICULOS;

drop index ART_FAB_FK;

drop index ART_FAB2_FK;

drop index ART_FAB_PK;

drop table ART_FAB;

drop index CLIENTES_PK;

drop table CLIENTES;

drop index ART_DET_FK;

drop index PED_DET_FK;

drop table DETALLEPEDIDOS;

drop index CLI_DIR_FK;

drop table DIRECCIONES;

drop index FABRICAS_PK;

drop table FABRICAS;

drop index CLI_PED_FK;

drop index PEDIDOS_PK;

drop table PEDIDOS;

/*==============================================================*/
/* Table: ARTICULOS                                             */
/*==============================================================*/
create table ARTICULOS (
   IDART                VARCHAR(20)          not null,
   NOMBRESART           VARCHAR(50)          not null,
   PRECIOART            DECIMAL              not null,
   CANTIDADART          INT4                 not null,
   DESCRIPCIONART       VARCHAR(200)         not null,
   VENTAART             DECIMAL              not null,
   IMPUESTOART          INT2                 not null,
   constraint PK_ARTICULOS primary key (IDART)
);

/*==============================================================*/
/* Index: ARTICULOS_PK                                          */
/*==============================================================*/
create unique index ARTICULOS_PK on ARTICULOS (
IDART
);

/*==============================================================*/
/* Table: ART_FAB                                               */
/*==============================================================*/
create table ART_FAB (
   IDFAB                VARCHAR(13)          not null,
   IDART                VARCHAR(20)          not null,
   constraint PK_ART_FAB primary key (IDFAB, IDART)
);

/*==============================================================*/
/* Index: ART_FAB_PK                                            */
/*==============================================================*/
create unique index ART_FAB_PK on ART_FAB (
IDFAB,
IDART
);

/*==============================================================*/
/* Index: ART_FAB2_FK                                           */
/*==============================================================*/
create  index ART_FAB2_FK on ART_FAB (
IDART
);

/*==============================================================*/
/* Index: ART_FAB_FK                                            */
/*==============================================================*/
create  index ART_FAB_FK on ART_FAB (
IDFAB
);

/*==============================================================*/
/* Table: CLIENTES                                              */
/*==============================================================*/
create table CLIENTES (
   CEDULACLI            VARCHAR(10)          not null,
   NOMBRESCLI           VARCHAR(50)          not null,
   APELLIDOSCLI         VARCHAR(50)          not null,
   NACIMIENTOCLI        DATE                 not null,
   CREDITOCLI           DECIMAL              not null,
   SALDOPCLI            DECIMAL              not null,
   constraint PK_CLIENTES primary key (CEDULACLI)
);

/*==============================================================*/
/* Index: CLIENTES_PK                                           */
/*==============================================================*/
create unique index CLIENTES_PK on CLIENTES (
CEDULACLI
);

/*==============================================================*/
/* Table: DETALLEPEDIDOS                                        */
/*==============================================================*/
create table DETALLEPEDIDOS (
   IDPED                INT4                 null,
   IDART                VARCHAR(20)          null,
   CANTIDADDET          INT4                 not null,
   PRECIODET            DECIMAL              not null,
   DESCUENTODET         DECIMAL              not null,
   IMPUESTODET          INT2                 not null
);

/*==============================================================*/
/* Index: PED_DET_FK                                            */
/*==============================================================*/
create  index PED_DET_FK on DETALLEPEDIDOS (
IDPED
);

/*==============================================================*/
/* Index: ART_DET_FK                                            */
/*==============================================================*/
create  index ART_DET_FK on DETALLEPEDIDOS (
IDART
);

/*==============================================================*/
/* Table: DIRECCIONES                                           */
/*==============================================================*/
create table DIRECCIONES (
   CEDULACLI            VARCHAR(10)          null,
   NUMERODIR            VARCHAR(5)           not null,
   PRINCIPALDIR         VARCHAR(50)          not null,
   ECUNDARIADIR         VARCHAR(50)          not null,
   CIUDADDIR            VARCHAR(30)          not null
);

/*==============================================================*/
/* Index: CLI_DIR_FK                                            */
/*==============================================================*/
create  index CLI_DIR_FK on DIRECCIONES (
CEDULACLI
);

/*==============================================================*/
/* Table: FABRICAS                                              */
/*==============================================================*/
create table FABRICAS (
   IDFAB                VARCHAR(13)          not null,
   NOMBRESFAB           VARCHAR(50)          not null,
   TELEFONOFAB          VARCHAR(10)          not null,
   DIRECCIONFAB         VARCHAR(50)          not null,
   CIUDADFAB            VARCHAR(30)          not null,
   MAILFAB              VARCHAR(50)          null,
   constraint PK_FABRICAS primary key (IDFAB)
);

/*==============================================================*/
/* Index: FABRICAS_PK                                           */
/*==============================================================*/
create unique index FABRICAS_PK on FABRICAS (
IDFAB
);

/*==============================================================*/
/* Table: PEDIDOS                                               */
/*==============================================================*/
create table PEDIDOS (
   IDPED                SERIAL               not null,
   CEDULACLI            VARCHAR(10)          null,
   DIRECCIONPED         VARCHAR(50)          not null,
   FECHAPED             DATE                 not null,
   SUBTOTALPED          DECIMAL              not null,
   DESCUENTOPED         DECIMAL              not null,
   IMPUESTOPED          DECIMAL              not null,
   TOTALPED             DECIMAL              not null,
   constraint PK_PEDIDOS primary key (IDPED)
);

/*==============================================================*/
/* Index: PEDIDOS_PK                                            */
/*==============================================================*/
create unique index PEDIDOS_PK on PEDIDOS (
IDPED
);

/*==============================================================*/
/* Index: CLI_PED_FK                                            */
/*==============================================================*/
create  index CLI_PED_FK on PEDIDOS (
CEDULACLI
);

alter table ART_FAB
   add constraint FK_ART_FAB_ART_FAB2_ARTICULO foreign key (IDART)
      references ARTICULOS (IDART)
      on delete restrict on update restrict;

alter table ART_FAB
   add constraint FK_ART_FAB_FAB_ART_FABRICAS foreign key (IDFAB)
      references FABRICAS (IDFAB)
      on delete restrict on update restrict;

alter table DETALLEPEDIDOS
   add constraint FK_DETALLEP_ART_DET_ARTICULO foreign key (IDART)
      references ARTICULOS (IDART)
      on delete restrict on update restrict;

alter table DETALLEPEDIDOS
   add constraint FK_DETALLEP_PED_DET_PEDIDOS foreign key (IDPED)
      references PEDIDOS (IDPED)
      on delete restrict on update restrict;

alter table DIRECCIONES
   add constraint FK_DIRECCIO_CLI_DIR_CLIENTES foreign key (CEDULACLI)
      references CLIENTES (CEDULACLI)
      on delete restrict on update restrict;

alter table PEDIDOS
   add constraint FK_PEDIDOS_CLI_PED_CLIENTES foreign key (CEDULACLI)
      references CLIENTES (CEDULACLI)
      on delete restrict on update restrict;

SELECT 
    e.nombresemp, 
    e.apellidosemp, 
    c.detallecar, 
    COUNT(f.codigofac) AS cantidad_facturas
FROM 
    empleados AS e
INNER JOIN 
    cargos AS c ON e.idcar = c.idcar
INNER JOIN 
    facturas AS f ON e.cedulaemp = f.cedulaemp
GROUP BY 
    e.cedulaemp, e.nombresemp, e.apellidosemp, c.detallecar; SELECT e.nombresemp, e.apellidosemp, COUNT(h.cedulahij) AS numero_hijos_menores
FROM empleados AS e
LEFT JOIN hijos AS h ON e.cedulaemp = h.cedulaemp
GROUP BY e.nombresemp, e.apellidosemp; SELECT e.nombresemp, e.apellidosemp, EXTRACT(MONTH FROM rp.fecharol) AS mes_pago
FROM empleados AS e
INNER JOIN roles AS rp ON e.cedulaemp = rp.cedulaemp
GROUP BY e.cedulaemp, e.nombresemp, e.apellidosemp, EXTRACT(MONTH FROM rp.fecharol); SELECT e.nombresemp, e.apellidosemp, h.cedulahij, h.otros_datos  -- Replace 'otros_datos' with desired child information
FROM empleados AS e
LEFT JOIN hijos AS h ON e.cedulaemp = h.cedulaemp
WHERE h.cedulahij IN (
  SELECT h2.cedulahij
  FROM hijos AS h2
  WHERE h2.fecha_nacimiento > DATE_SUB(CURDATE(), INTERVAL 18 YEAR)  -- Adjust age limit as needed
)
GROUP BY e.nombresemp, e.apellidosemp, h.cedulahij, h.otros_datos;