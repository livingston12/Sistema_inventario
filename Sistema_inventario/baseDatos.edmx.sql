
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2017 08:47:01
-- Generated from EDMX file: C:\Users\lreynoso\Documents\Visual Studio 2015\Projects\Sistema_inventario2\Sistema_inventario\Sistema_inventario\baseDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sistema_inventario];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__detalle_c__IdRep__47DBAE45]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_compra] DROP CONSTRAINT [FK__detalle_c__IdRep__47DBAE45];
GO
IF OBJECT_ID(N'[dbo].[fk_Compra_Proveedor1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[compra] DROP CONSTRAINT [fk_Compra_Proveedor1];
GO
IF OBJECT_ID(N'[dbo].[fk_Detalle_Compra_Compra1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_compra] DROP CONSTRAINT [fk_Detalle_Compra_Compra1];
GO
IF OBJECT_ID(N'[dbo].[fk_Detalle_Compra_Producto1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_compra] DROP CONSTRAINT [fk_Detalle_Compra_Producto1];
GO
IF OBJECT_ID(N'[dbo].[FK_IdCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[producto] DROP CONSTRAINT [FK_IdCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_IdCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [FK_IdCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_IdProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_venta] DROP CONSTRAINT [FK_IdProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_IdReporte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_venta] DROP CONSTRAINT [FK_IdReporte];
GO
IF OBJECT_ID(N'[dbo].[FK_IdUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[venta] DROP CONSTRAINT [FK_IdUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_IdVenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[detalle_venta] DROP CONSTRAINT [FK_IdVenta];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categoria];
GO
IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO
IF OBJECT_ID(N'[dbo].[compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[compra];
GO
IF OBJECT_ID(N'[dbo].[detalle_compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[detalle_compra];
GO
IF OBJECT_ID(N'[dbo].[detalle_venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[detalle_venta];
GO
IF OBJECT_ID(N'[dbo].[producto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[producto];
GO
IF OBJECT_ID(N'[dbo].[proveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[proveedor];
GO
IF OBJECT_ID(N'[dbo].[reporte]', 'U') IS NOT NULL
    DROP TABLE [dbo].[reporte];
GO
IF OBJECT_ID(N'[dbo].[usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usuarios];
GO
IF OBJECT_ID(N'[dbo].[venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[venta];
GO
IF OBJECT_ID(N'[sistemaModelStoreContainer].[vw_compras]', 'U') IS NOT NULL
    DROP TABLE [sistemaModelStoreContainer].[vw_compras];
GO
IF OBJECT_ID(N'[sistemaModelStoreContainer].[vw_ventas]', 'U') IS NOT NULL
    DROP TABLE [sistemaModelStoreContainer].[vw_ventas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'categoria'
CREATE TABLE [dbo].[categoria] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(45)  NULL
);
GO

-- Creating table 'cliente'
CREATE TABLE [dbo].[cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Apellido] varchar(50)  NOT NULL,
    [DUI] varchar(25)  NOT NULL,
    [Direccion] varchar(50)  NULL,
    [Telefono] varchar(15)  NULL,
    [NIT] varchar(25)  NOT NULL,
    [Correo] varchar(25)  NULL
);
GO

-- Creating table 'compra'
CREATE TABLE [dbo].[compra] (
    [IdCompra] int IDENTITY(1,1) NOT NULL,
    [Precio_Compra] decimal(18,2)  NULL,
    [Precio_Venta] decimal(18,2)  NULL,
    [Fecha_Compra] varchar(45)  NULL,
    [Proveedor_IdProveedor] int  NULL
);
GO

-- Creating table 'detalle_compra'
CREATE TABLE [dbo].[detalle_compra] (
    [IdDetalle_Compra] int  NOT NULL,
    [IdProducto] int  NOT NULL,
    [IdCompra] int  NOT NULL,
    [precio_venta] decimal(18,2)  NULL,
    [precio_compra] decimal(18,2)  NULL,
    [IdReporte] int  NOT NULL
);
GO

-- Creating table 'detalle_venta'
CREATE TABLE [dbo].[detalle_venta] (
    [IdDetalle_Venta] int IDENTITY(1,1) NOT NULL,
    [IdVenta] int  NOT NULL,
    [Cantidad] int  NULL,
    [Precio_Unitario] decimal(18,0)  NULL,
    [IdReporte] int  NOT NULL,
    [Descuento] int  NULL,
    [IdProducto] int  NOT NULL
);
GO

-- Creating table 'producto'
CREATE TABLE [dbo].[producto] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(45)  NOT NULL,
    [Descripcion] varchar(45)  NOT NULL,
    [Stock] int  NOT NULL,
    [IdCategoria] int  NULL,
    [IdProveedor] int  NULL,
    [PrecioUnitario] decimal(18,2)  NULL
);
GO

-- Creating table 'proveedor'
CREATE TABLE [dbo].[proveedor] (
    [IdProveedor] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(45)  NOT NULL,
    [Numero_Documento] varchar(15)  NULL,
    [Direccion] varchar(45)  NULL,
    [Telefono] varchar(15)  NULL,
    [Email] varchar(25)  NULL
);
GO

-- Creating table 'reporte'
CREATE TABLE [dbo].[reporte] (
    [IdReporte] int  NOT NULL,
    [Tipo_Documento] varchar(45)  NULL
);
GO

-- Creating table 'usuarios'
CREATE TABLE [dbo].[usuarios] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(45)  NOT NULL,
    [Apellido] varchar(45)  NOT NULL,
    [Direccion] varchar(45)  NOT NULL,
    [FechaNac] varchar(45)  NULL,
    [Telefono] varchar(15)  NULL,
    [Usuario] varchar(45)  NOT NULL,
    [Password] varchar(45)  NOT NULL,
    [Cargo] varchar(45)  NOT NULL
);
GO

-- Creating table 'venta'
CREATE TABLE [dbo].[venta] (
    [IdVenta] int IDENTITY(1,1) NOT NULL,
    [IdCliente] int  NULL,
    [IdUsuario] int  NULL,
    [Numero_Documento] int  NULL,
    [Tipo_Documento] varchar(45)  NULL,
    [Fecha_Venta] varchar(20)  NULL
);
GO

-- Creating table 'vw_compras'
CREATE VIEW dbo.vw_compras
AS
SELECT        dbo.compra.IdCompra AS codigo_compra, dbo.compra.Fecha_Compra, dbo.proveedor.Nombre AS proveedor, dbo.detalle_compra.precio_venta, 
                         dbo.detalle_compra.precio_compra, dbo.producto.Nombre AS producto, dbo.producto.Descripcion, dbo.categoria.Nombre AS categoria
FROM            dbo.compra INNER JOIN
                         dbo.detalle_compra ON dbo.compra.IdCompra = dbo.detalle_compra.IdCompra INNER JOIN
                         dbo.proveedor ON dbo.compra.Proveedor_IdProveedor = dbo.proveedor.IdProveedor INNER JOIN
                         dbo.producto ON dbo.detalle_compra.IdProducto = dbo.producto.IdProducto INNER JOIN
                         dbo.categoria ON dbo.producto.IdCategoria = dbo.categoria.IdCategoria

GO


-- Creating table 'vw_ventas'
CREATE VIEW dbo.vw_compras
AS
SELECT        dbo.venta.IdVenta AS codigo_venta, dbo.reporte.Tipo_Documento AS tipo_pago, dbo.producto.Nombre AS producto, dbo.producto.Descripcion, 
                         dbo.cliente.Nombre + ' ' + dbo.cliente.Apellido AS cliente, dbo.usuarios.Nombre + ' ' + dbo.usuarios.Apellido AS vendedor, 
                         dbo.detalle_venta.Precio_Unitario AS precio, CAST(dbo.detalle_venta.Descuento AS VARCHAR(10)) + '%' AS descuento, dbo.detalle_venta.Cantidad, 
                         dbo.detalle_venta.Cantidad * dbo.detalle_venta.Precio_Unitario AS total, dbo.venta.Fecha_Venta
FROM            dbo.detalle_venta INNER JOIN
                         dbo.venta ON dbo.detalle_venta.IdVenta = dbo.venta.IdVenta INNER JOIN
                         dbo.reporte ON dbo.detalle_venta.IdReporte = dbo.reporte.IdReporte INNER JOIN
                         dbo.producto ON dbo.detalle_venta.IdProducto = dbo.producto.IdProducto INNER JOIN
                         dbo.cliente ON dbo.venta.IdCliente = dbo.cliente.IdCliente INNER JOIN
                         dbo.usuarios ON dbo.venta.IdUsuario = dbo.usuarios.IdUsuario
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCategoria] in table 'categoria'
ALTER TABLE [dbo].[categoria]
ADD CONSTRAINT [PK_categoria]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdCliente] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [PK_cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdCompra] in table 'compra'
ALTER TABLE [dbo].[compra]
ADD CONSTRAINT [PK_compra]
    PRIMARY KEY CLUSTERED ([IdCompra] ASC);
GO

-- Creating primary key on [IdDetalle_Compra] in table 'detalle_compra'
ALTER TABLE [dbo].[detalle_compra]
ADD CONSTRAINT [PK_detalle_compra]
    PRIMARY KEY CLUSTERED ([IdDetalle_Compra] ASC);
GO

-- Creating primary key on [IdDetalle_Venta] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [PK_detalle_venta]
    PRIMARY KEY CLUSTERED ([IdDetalle_Venta] ASC);
GO

-- Creating primary key on [IdProducto] in table 'producto'
ALTER TABLE [dbo].[producto]
ADD CONSTRAINT [PK_producto]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdProveedor] in table 'proveedor'
ALTER TABLE [dbo].[proveedor]
ADD CONSTRAINT [PK_proveedor]
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC);
GO

-- Creating primary key on [IdReporte] in table 'reporte'
ALTER TABLE [dbo].[reporte]
ADD CONSTRAINT [PK_reporte]
    PRIMARY KEY CLUSTERED ([IdReporte] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'usuarios'
ALTER TABLE [dbo].[usuarios]
ADD CONSTRAINT [PK_usuarios]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdVenta] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [PK_venta]
    PRIMARY KEY CLUSTERED ([IdVenta] ASC);
GO

-- Creating primary key on [codigo_compra], [proveedor], [producto], [Descripcion] in table 'vw_compras'
ALTER TABLE [dbo].[vw_compras]
ADD CONSTRAINT [PK_vw_compras]
    PRIMARY KEY CLUSTERED ([codigo_compra], [proveedor], [producto], [Descripcion] ASC);
GO

-- Creating primary key on [codigo_venta], [producto], [Descripcion], [Cliente], [vendedor] in table 'vw_ventas'
ALTER TABLE [dbo].[vw_ventas]
ADD CONSTRAINT [PK_vw_ventas]
    PRIMARY KEY CLUSTERED ([codigo_venta], [producto], [Descripcion], [Cliente], [vendedor] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdCategoria] in table 'producto'
ALTER TABLE [dbo].[producto]
ADD CONSTRAINT [FK_IdCategoria]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [dbo].[categoria]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdCategoria'
CREATE INDEX [IX_FK_IdCategoria]
ON [dbo].[producto]
    ([IdCategoria]);
GO

-- Creating foreign key on [IdCliente] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [FK_IdCliente]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdCliente'
CREATE INDEX [IX_FK_IdCliente]
ON [dbo].[venta]
    ([IdCliente]);
GO

-- Creating foreign key on [Proveedor_IdProveedor] in table 'compra'
ALTER TABLE [dbo].[compra]
ADD CONSTRAINT [fk_Compra_Proveedor1]
    FOREIGN KEY ([Proveedor_IdProveedor])
    REFERENCES [dbo].[proveedor]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Compra_Proveedor1'
CREATE INDEX [IX_fk_Compra_Proveedor1]
ON [dbo].[compra]
    ([Proveedor_IdProveedor]);
GO

-- Creating foreign key on [IdCompra] in table 'detalle_compra'
ALTER TABLE [dbo].[detalle_compra]
ADD CONSTRAINT [fk_Detalle_Compra_Compra1]
    FOREIGN KEY ([IdCompra])
    REFERENCES [dbo].[compra]
        ([IdCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Detalle_Compra_Compra1'
CREATE INDEX [IX_fk_Detalle_Compra_Compra1]
ON [dbo].[detalle_compra]
    ([IdCompra]);
GO

-- Creating foreign key on [IdProducto] in table 'detalle_compra'
ALTER TABLE [dbo].[detalle_compra]
ADD CONSTRAINT [fk_Detalle_Compra_Producto1]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Detalle_Compra_Producto1'
CREATE INDEX [IX_fk_Detalle_Compra_Producto1]
ON [dbo].[detalle_compra]
    ([IdProducto]);
GO

-- Creating foreign key on [IdProducto] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [FK_IdProducto]
    FOREIGN KEY ([IdProducto])
    REFERENCES [dbo].[producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdProducto'
CREATE INDEX [IX_FK_IdProducto]
ON [dbo].[detalle_venta]
    ([IdProducto]);
GO

-- Creating foreign key on [IdReporte] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [FK_IdReporte]
    FOREIGN KEY ([IdReporte])
    REFERENCES [dbo].[reporte]
        ([IdReporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdReporte'
CREATE INDEX [IX_FK_IdReporte]
ON [dbo].[detalle_venta]
    ([IdReporte]);
GO

-- Creating foreign key on [IdVenta] in table 'detalle_venta'
ALTER TABLE [dbo].[detalle_venta]
ADD CONSTRAINT [FK_IdVenta]
    FOREIGN KEY ([IdVenta])
    REFERENCES [dbo].[venta]
        ([IdVenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdVenta'
CREATE INDEX [IX_FK_IdVenta]
ON [dbo].[detalle_venta]
    ([IdVenta]);
GO

-- Creating foreign key on [IdUsuario] in table 'venta'
ALTER TABLE [dbo].[venta]
ADD CONSTRAINT [FK_IdUsuario]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdUsuario'
CREATE INDEX [IX_FK_IdUsuario]
ON [dbo].[venta]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdReporte] in table 'detalle_compra'
ALTER TABLE [dbo].[detalle_compra]
ADD CONSTRAINT [FK__detalle_c__IdRep__47DBAE45]
    FOREIGN KEY ([IdReporte])
    REFERENCES [dbo].[reporte]
        ([IdReporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__detalle_c__IdRep__47DBAE45'
CREATE INDEX [IX_FK__detalle_c__IdRep__47DBAE45]
ON [dbo].[detalle_compra]
    ([IdReporte]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------