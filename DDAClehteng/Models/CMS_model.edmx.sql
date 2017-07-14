
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/07/2017 15:56:46
-- Generated from EDMX file: c:\users\fish\documents\visual studio 2015\Projects\DDAClehteng\DDAClehteng\Models\CMS_model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DDAC_Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ShipViews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShipViews];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ShipViews'
CREATE TABLE [dbo].[ShipViews] (
    [Ship_Id] int IDENTITY(1,1) NOT NULL,
    [Ship_Place] nvarchar(max)  NOT NULL,
    [Ship_Depart] datetime  NOT NULL,
    [Ship_Arrived] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Ship_Id] in table 'ShipViews'
ALTER TABLE [dbo].[ShipViews]
ADD CONSTRAINT [PK_ShipViews]
    PRIMARY KEY CLUSTERED ([Ship_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------