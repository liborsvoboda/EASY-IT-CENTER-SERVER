﻿# Úvod   Start -DATABASE-RULE  

Vše začíná U databáze. 
Pravidla určující MultiLogiku v 1 Balíčku.
Zde najdete Kompletní Strukturu Aktuální Databáze
a Seznam Pravidel, které je obecně dobré dodržovat

1 pravidlo: Každé slovo má Hluboký Význam

TABLE


 IF OBJECT_ID('[dbo].[ProdGuidPartList]') IS NOT NULL 
 DROP TABLE [dbo].[ProdGuidPartList] 
 GO
 CREATE TABLE [dbo].[ProdGuidPartList] ( 
 [Id]         INT              IDENTITY(1,1)          NOT NULL,
 [WorkPlace]  INT                                     NOT NULL,
 [Number]     VARCHAR(50)                             NOT NULL,
 [Name]       VARCHAR(100)                                NULL,
 [UserId]     INT                                     NOT NULL,
 [Timestamp]  DATETIME2                               NOT NULL,
 CONSTRAINT   [PK_ProdGuidPartList]  PRIMARY KEY CLUSTERED    ([Id] asc) ,
 CONSTRAINT   [IX_ProdGuidPartList]  UNIQUE      NONCLUSTERED ([WorkPlace] asc, [Number] asc) ,
 CONSTRAINT [FK_ProdGuidPartList_UserList] FOREIGN KEY ([UserId]) REFERENCES [dbo].[SolutionUserList] (Id) )
 
 