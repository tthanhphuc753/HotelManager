
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2023 20:48:10
-- Generated from EDMX file: C:\Games\GAME\HOTELMANAGER\New folder\DataLayer\HOTEL.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HotelManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DATPHONG_KHACHHANG]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HOADON] DROP CONSTRAINT [FK_DATPHONG_KHACHHANG];
GO
IF OBJECT_ID(N'[dbo].[FK_DATPHONG_PHONG]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HOADON] DROP CONSTRAINT [FK_DATPHONG_PHONG];
GO
IF OBJECT_ID(N'[dbo].[FK_PHONG_LOAIPHONG]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHONG] DROP CONSTRAINT [FK_PHONG_LOAIPHONG];
GO
IF OBJECT_ID(N'[dbo].[FK_PHONG_TANG]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHONG] DROP CONSTRAINT [FK_PHONG_TANG];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[HOADON]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HOADON];
GO
IF OBJECT_ID(N'[dbo].[KHACHHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KHACHHANG];
GO
IF OBJECT_ID(N'[dbo].[LOAIPHONG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LOAIPHONG];
GO
IF OBJECT_ID(N'[dbo].[PHONG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHONG];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TAIKHOAN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TAIKHOAN];
GO
IF OBJECT_ID(N'[dbo].[TANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TANG];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'HOADONs'
CREATE TABLE [dbo].[HOADONs] (
    [IDhoadon] int IDENTITY(1,1) NOT NULL,
    [IDkhachhang] int  NULL,
    [IDphong] int  NULL,
    [Ngaydat] datetime  NULL,
    [Ngaytra] datetime  NULL,
    [Songayo] int  NULL,
    [Tongtien] decimal(18,0)  NULL,
    [Trangthai] bit  NOT NULL
);
GO

-- Creating table 'KHACHHANGs'
CREATE TABLE [dbo].[KHACHHANGs] (
    [IDKhachhang] int IDENTITY(1,1) NOT NULL,
    [Tenkhachhang] nvarchar(50)  NOT NULL,
    [CCCD_CMND] nchar(12)  NOT NULL,
    [Loaikhach] bit  NOT NULL
);
GO

-- Creating table 'LOAIPHONGs'
CREATE TABLE [dbo].[LOAIPHONGs] (
    [IDloaiphong] nchar(10)  NOT NULL,
    [Giatien] decimal(18,0)  NULL,
    [Songuoimax] int  NULL
);
GO

-- Creating table 'PHONGs'
CREATE TABLE [dbo].[PHONGs] (
    [IDphong] int IDENTITY(1,1) NOT NULL,
    [Tenphong] nvarchar(50)  NULL,
    [IDtang] int  NOT NULL,
    [Trangthai] bit  NULL,
    [IDloaiphong] nchar(10)  NOT NULL
);
GO

-- Creating table 'TAIKHOANs'
CREATE TABLE [dbo].[TAIKHOANs] (
    [Username] nvarchar(50)  NOT NULL,
    [Password] int  NOT NULL,
    [Chucvu] int  NULL
);
GO

-- Creating table 'TANGs'
CREATE TABLE [dbo].[TANGs] (
    [IDtang] int IDENTITY(1,1) NOT NULL,
    [Tentang] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [IDhoadon] in table 'HOADONs'
ALTER TABLE [dbo].[HOADONs]
ADD CONSTRAINT [PK_HOADONs]
    PRIMARY KEY CLUSTERED ([IDhoadon] ASC);
GO

-- Creating primary key on [IDKhachhang] in table 'KHACHHANGs'
ALTER TABLE [dbo].[KHACHHANGs]
ADD CONSTRAINT [PK_KHACHHANGs]
    PRIMARY KEY CLUSTERED ([IDKhachhang] ASC);
GO

-- Creating primary key on [IDloaiphong] in table 'LOAIPHONGs'
ALTER TABLE [dbo].[LOAIPHONGs]
ADD CONSTRAINT [PK_LOAIPHONGs]
    PRIMARY KEY CLUSTERED ([IDloaiphong] ASC);
GO

-- Creating primary key on [IDphong] in table 'PHONGs'
ALTER TABLE [dbo].[PHONGs]
ADD CONSTRAINT [PK_PHONGs]
    PRIMARY KEY CLUSTERED ([IDphong] ASC);
GO

-- Creating primary key on [Username] in table 'TAIKHOANs'
ALTER TABLE [dbo].[TAIKHOANs]
ADD CONSTRAINT [PK_TAIKHOANs]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- Creating primary key on [IDtang] in table 'TANGs'
ALTER TABLE [dbo].[TANGs]
ADD CONSTRAINT [PK_TANGs]
    PRIMARY KEY CLUSTERED ([IDtang] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDkhachhang] in table 'HOADONs'
ALTER TABLE [dbo].[HOADONs]
ADD CONSTRAINT [FK_DATPHONG_KHACHHANG]
    FOREIGN KEY ([IDkhachhang])
    REFERENCES [dbo].[KHACHHANGs]
        ([IDKhachhang])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DATPHONG_KHACHHANG'
CREATE INDEX [IX_FK_DATPHONG_KHACHHANG]
ON [dbo].[HOADONs]
    ([IDkhachhang]);
GO

-- Creating foreign key on [IDphong] in table 'HOADONs'
ALTER TABLE [dbo].[HOADONs]
ADD CONSTRAINT [FK_DATPHONG_PHONG]
    FOREIGN KEY ([IDphong])
    REFERENCES [dbo].[PHONGs]
        ([IDphong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DATPHONG_PHONG'
CREATE INDEX [IX_FK_DATPHONG_PHONG]
ON [dbo].[HOADONs]
    ([IDphong]);
GO

-- Creating foreign key on [IDloaiphong] in table 'PHONGs'
ALTER TABLE [dbo].[PHONGs]
ADD CONSTRAINT [FK_PHONG_LOAIPHONG]
    FOREIGN KEY ([IDloaiphong])
    REFERENCES [dbo].[LOAIPHONGs]
        ([IDloaiphong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PHONG_LOAIPHONG'
CREATE INDEX [IX_FK_PHONG_LOAIPHONG]
ON [dbo].[PHONGs]
    ([IDloaiphong]);
GO

-- Creating foreign key on [IDtang] in table 'PHONGs'
ALTER TABLE [dbo].[PHONGs]
ADD CONSTRAINT [FK_PHONG_TANG]
    FOREIGN KEY ([IDtang])
    REFERENCES [dbo].[TANGs]
        ([IDtang])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PHONG_TANG'
CREATE INDEX [IX_FK_PHONG_TANG]
ON [dbo].[PHONGs]
    ([IDtang]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------