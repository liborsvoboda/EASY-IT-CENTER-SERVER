﻿# Úvod   Start -DATABASE-RULE  

Vše začíná U databáze. 
Pravidla určující MultiLogiku v 1 Balíčku.
Zde najdete Kompletní Strukturu Aktuální Databáze
a Seznam Pravidel, které je obecně dobré dodržovat

1 pravidlo: Každé slovo má Hluboký Význam

TABLE


 IF OBJECT_ID('[dbo].[SolutionSchedulerProcessList]') IS NOT NULL 
 DROP TABLE [dbo].[SolutionSchedulerProcessList] 
 GO
 CREATE TABLE [dbo].[SolutionSchedulerProcessList] ( 
 [Id]                INT              IDENTITY(1,1)          NOT NULL,
 [ScheduledTaskId]   INT                                     NOT NULL,
 [ProcessData]       TEXT                                        NULL,
 [ProcessLog]        TEXT                                        NULL,
 [ProcessCrashed]    BIT                                     NOT NULL,
 [ProcessCompleted]  BIT                                     NOT NULL,
 [TimeStamp]         DATETIME2                               NOT NULL  CONSTRAINT [DF_SolutionSchedulerProcessList_TimeStamp] DEFAULT (getdate()),
 CONSTRAINT   [PK_SolutionSchedulerProcessList]  PRIMARY KEY CLUSTERED    ([Id] asc) ,
 CONSTRAINT [FK_SolutionSchedulerProcessList_SolutionSchedulerList] FOREIGN KEY ([ScheduledTaskId]) REFERENCES [dbo].[SolutionSchedulerList] (Id)  ON DELETE CASCADE )
 
 