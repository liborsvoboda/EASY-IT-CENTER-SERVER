﻿# Úvod   Start -DATABASE-RULE  

Vše začíná U databáze. 
Pravidla určující MultiLogiku v 1 Balíčku.
Zde najdete Kompletní Strukturu Aktuální Databáze
a Seznam Pravidel, které je obecně dobré dodržovat

1 pravidlo: Každé slovo má Hluboký Význam

TABLE


 IF OBJECT_ID('[dbo].[LicSrvLicenseActivationFailList]') IS NOT NULL 
 DROP TABLE [dbo].[LicSrvLicenseActivationFailList] 
 GO
 CREATE TABLE [dbo].[LicSrvLicenseActivationFailList] ( 
 [Id]          INT              IDENTITY(1,1)          NOT NULL,
 [IpAddress]   VARCHAR(50)                             NOT NULL,
 [UnlockCode]  VARCHAR(50)                                 NULL,
 [PartNumber]  VARCHAR(50)                                 NULL,
 [TimeStamp]   DATETIME2                               NOT NULL  CONSTRAINT [DF_LicenceActivationFailList_TimeStamp] DEFAULT (getdate()),
 CONSTRAINT   [PK_LicenseActivationFailList]  PRIMARY KEY CLUSTERED    ([Id] asc) )
 
 
 GO
 
 CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_PartNumber] 
    ON [dbo].[LicSrvLicenseActivationFailList] ([PartNumber] asc)
 CREATE NONCLUSTERED INDEX [IX_LicenseActivationFailList_IpAddress] 
    ON [dbo].[LicSrvLicenseActivationFailList] ([IpAddress] asc)