﻿# Úvod   Start -DATABASE-RULE  

Vše začíná U databáze. 
Pravidla určující MultiLogiku v 1 Balíčku.
Zde najdete Kompletní Strukturu Aktuální Databáze
a Seznam Pravidel, které je obecně dobré dodržovat

1 pravidlo: Každé slovo má Hluboký Význam

TABLE


 IF OBJECT_ID('[dbo].[WebVisitIpList]') IS NOT NULL 
 DROP TABLE [dbo].[WebVisitIpList] 
 GO
 CREATE TABLE [dbo].[WebVisitIpList] ( 
 [Id]                 INT              IDENTITY(1,1)          NOT NULL,
 [WebHostIp]          VARCHAR(50)                             NOT NULL,
 [Description]        TEXT                                        NULL,
 [WhoIsInformations]  TEXT                                        NULL,
 [TimeStamp]          DATETIME2                               NOT NULL  CONSTRAINT [DF_WebVisitIpList_TimeStamp] DEFAULT (getdate()),
 CONSTRAINT   [PK_WebVisitIpList]  PRIMARY KEY CLUSTERED    ([Id] asc) ,
 CONSTRAINT   [IX_WebVisitIpList]  UNIQUE      NONCLUSTERED ([WebHostIp] asc, [TimeStamp] asc) )
 
 