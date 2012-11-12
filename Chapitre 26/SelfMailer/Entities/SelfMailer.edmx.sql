
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/24/2012 17:01:34
-- Generated from EDMX file: C:\Projects\E1\SelfMailer\Entities\SelfMailer.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SelfMailer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MailServerSender_MailServer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MailServerSender] DROP CONSTRAINT [FK_MailServerSender_MailServer];
GO
IF OBJECT_ID(N'[dbo].[FK_MailServerSender_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MailServerSender] DROP CONSTRAINT [FK_MailServerSender_Sender];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MailServers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MailServers];
GO
IF OBJECT_ID(N'[dbo].[Senders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Senders];
GO
IF OBJECT_ID(N'[dbo].[MailServerSender]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MailServerSender];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MailServers'
CREATE TABLE [dbo].[MailServers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Host] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password_Value] nvarchar(max)  NOT NULL,
    [Password_AllowSave] bit  NOT NULL
);
GO

-- Creating table 'Senders'
CREATE TABLE [dbo].[Senders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MailServerSender'
CREATE TABLE [dbo].[MailServerSender] (
    [MailServer_ID] int  NOT NULL,
    [Sender_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'MailServers'
ALTER TABLE [dbo].[MailServers]
ADD CONSTRAINT [PK_MailServers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Senders'
ALTER TABLE [dbo].[Senders]
ADD CONSTRAINT [PK_Senders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [MailServer_ID], [Sender_ID] in table 'MailServerSender'
ALTER TABLE [dbo].[MailServerSender]
ADD CONSTRAINT [PK_MailServerSender]
    PRIMARY KEY NONCLUSTERED ([MailServer_ID], [Sender_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MailServer_ID] in table 'MailServerSender'
ALTER TABLE [dbo].[MailServerSender]
ADD CONSTRAINT [FK_MailServerSender_MailServer]
    FOREIGN KEY ([MailServer_ID])
    REFERENCES [dbo].[MailServers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sender_ID] in table 'MailServerSender'
ALTER TABLE [dbo].[MailServerSender]
ADD CONSTRAINT [FK_MailServerSender_Sender]
    FOREIGN KEY ([Sender_ID])
    REFERENCES [dbo].[Senders]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MailServerSender_Sender'
CREATE INDEX [IX_FK_MailServerSender_Sender]
ON [dbo].[MailServerSender]
    ([Sender_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------