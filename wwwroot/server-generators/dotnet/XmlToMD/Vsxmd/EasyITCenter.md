<a name='assembly'></a>
# EasyITCenter

## Contents

- [AdminApiGeneratorMdBookService](#T-EasyITCenter-Controllers-AdminApiGeneratorMdBookService 'EasyITCenter.Controllers.AdminApiGeneratorMdBookService')
  - [GenerateInteliMDBook(requestData)](#M-EasyITCenter-Controllers-AdminApiGeneratorMdBookService-GenerateInteliMDBook-EasyITCenter-Controllers-MDDocBookGenerator- 'EasyITCenter.Controllers.AdminApiGeneratorMdBookService.GenerateInteliMDBook(EasyITCenter.Controllers.MDDocBookGenerator)')
  - [GenerateMDDocBook(webFilesRequest)](#M-EasyITCenter-Controllers-AdminApiGeneratorMdBookService-GenerateMDDocBook-EasyITCenter-Controllers-MDDocBookGeneratorRequest- 'EasyITCenter.Controllers.AdminApiGeneratorMdBookService.GenerateMDDocBook(EasyITCenter.Controllers.MDDocBookGeneratorRequest)')
- [AdministrationService](#T-EasyITCenter-Controllers-AdministrationService 'EasyITCenter.Controllers.AdministrationService')
  - [FtpServerStart()](#M-EasyITCenter-Controllers-AdministrationService-FtpServerStart 'EasyITCenter.Controllers.AdministrationService.FtpServerStart')
  - [FtpServerStatus()](#M-EasyITCenter-Controllers-AdministrationService-FtpServerStatus 'EasyITCenter.Controllers.AdministrationService.FtpServerStatus')
  - [FtpServerStop()](#M-EasyITCenter-Controllers-AdministrationService-FtpServerStop 'EasyITCenter.Controllers.AdministrationService.FtpServerStop')
  - [ServerRestart()](#M-EasyITCenter-Controllers-AdministrationService-ServerRestart 'EasyITCenter.Controllers.AdministrationService.ServerRestart')
  - [ServerSchedulerStart()](#M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStart 'EasyITCenter.Controllers.AdministrationService.ServerSchedulerStart')
  - [ServerSchedulerStatus()](#M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStatus 'EasyITCenter.Controllers.AdministrationService.ServerSchedulerStatus')
  - [ServerSchedulerStop()](#M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStop 'EasyITCenter.Controllers.AdministrationService.ServerSchedulerStop')
- [AuthenticateResponse](#T-EasyITCenter-DBModel-AuthenticateResponse 'EasyITCenter.DBModel.AuthenticateResponse')
- [AuthenticationService](#T-EasyITCenter-Controllers-AuthenticationService 'EasyITCenter.Controllers.AuthenticationService')
  - [Authenticate(username,password)](#M-EasyITCenter-Controllers-AuthenticationService-Authenticate-System-String,System-String- 'EasyITCenter.Controllers.AuthenticationService.Authenticate(System.String,System.String)')
  - [RefreshUserToken(username,token)](#M-EasyITCenter-Controllers-AuthenticationService-RefreshUserToken-System-String,EasyITCenter-DBModel-AuthenticateResponse- 'EasyITCenter.Controllers.AuthenticationService.RefreshUserToken(System.String,EasyITCenter.DBModel.AuthenticateResponse)')
  - [TokenLifetimeValidator(notBefore,expires,token,params)](#M-EasyITCenter-Controllers-AuthenticationService-TokenLifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters- 'EasyITCenter.Controllers.AuthenticationService.TokenLifetimeValidator(System.Nullable{System.DateTime},System.Nullable{System.DateTime},Microsoft.IdentityModel.Tokens.SecurityToken,Microsoft.IdentityModel.Tokens.TokenValidationParameters)')
- [AutoGenConnectionString](#T-EasyITCenter-WebClasses-AutoGenConnectionString 'EasyITCenter.WebClasses.AutoGenConnectionString')
- [AutoGenRequest](#T-EasyITCenter-WebClasses-AutoGenRequest 'EasyITCenter.WebClasses.AutoGenRequest')
- [AutoScheduledJob](#T-EasyITCenter-Services-AutoScheduledJob 'EasyITCenter.Services.AutoScheduledJob')
- [BackendCheckService](#T-EasyITCenter-Controllers-BackendCheckService 'EasyITCenter.Controllers.BackendCheckService')
  - [GetBackendCheckApi()](#M-EasyITCenter-Controllers-BackendCheckService-GetBackendCheckApi 'EasyITCenter.Controllers.BackendCheckService.GetBackendCheckApi')
- [CarouselImage](#T-EasyITCenter-WebClasses-CarouselImage 'EasyITCenter.WebClasses.CarouselImage')
- [CarouselVideo](#T-EasyITCenter-WebClasses-CarouselVideo 'EasyITCenter.WebClasses.CarouselVideo')
- [CoreOperations](#T-EasyITCenter-ServerCoreStructure-CoreOperations 'EasyITCenter.ServerCoreStructure.CoreOperations')
  - [CallGetApiUrl(url)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-CallGetApiUrl-System-String- 'EasyITCenter.ServerCoreStructure.CoreOperations.CallGetApiUrl(System.String)')
  - [ChechUrlRequestValidOrAuthorized(context)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-ChechUrlRequestValidOrAuthorized-Microsoft-AspNetCore-Http-HttpContext- 'EasyITCenter.ServerCoreStructure.CoreOperations.ChechUrlRequestValidOrAuthorized(Microsoft.AspNetCore.Http.HttpContext)')
  - [CheckTokenValidityFromString(tokenString)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-CheckTokenValidityFromString-System-String- 'EasyITCenter.ServerCoreStructure.CoreOperations.CheckTokenValidityFromString(System.String)')
  - [GetSelfSignedCertificate(password)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-GetSelfSignedCertificate-System-String- 'EasyITCenter.ServerCoreStructure.CoreOperations.GetSelfSignedCertificate(System.String)')
  - [GetSelfSignedCertificateFromFile()](#M-EasyITCenter-ServerCoreStructure-CoreOperations-GetSelfSignedCertificateFromFile-System-String- 'EasyITCenter.ServerCoreStructure.CoreOperations.GetSelfSignedCertificateFromFile(System.String)')
  - [GetServerRegisteredRoutesList(patchForCheck,updateList)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-GetServerRegisteredRoutesList-System-String,System-Boolean- 'EasyITCenter.ServerCoreStructure.CoreOperations.GetServerRegisteredRoutesList(System.String,System.Boolean)')
  - [SendEmail(mailRequest,sendImmediately)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-SendEmail-EasyITCenter-Controllers-SendMailRequest,System-Boolean- 'EasyITCenter.ServerCoreStructure.CoreOperations.SendEmail(EasyITCenter.Controllers.SendMailRequest,System.Boolean)')
  - [SendMassEmail(mailRequests)](#M-EasyITCenter-ServerCoreStructure-CoreOperations-SendMassEmail-System-Collections-Generic-List{EasyITCenter-Controllers-SendMailRequest}- 'EasyITCenter.ServerCoreStructure.CoreOperations.SendMassEmail(System.Collections.Generic.List{EasyITCenter.Controllers.SendMailRequest})')
  - [ValidAndGetTokenParameters()](#M-EasyITCenter-ServerCoreStructure-CoreOperations-ValidAndGetTokenParameters 'EasyITCenter.ServerCoreStructure.CoreOperations.ValidAndGetTokenParameters')
- [CustomFtpUser](#T-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser')
  - [#ctor(name)](#M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-#ctor-System-String- 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.#ctor(System.String)')
  - [Name](#P-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-Name 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.Name')
  - [IsInGroup()](#M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-IsInGroup-System-String- 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser.IsInGroup(System.String)')
- [CustomMessageList](#T-EasyITCenter-DBModel-CustomMessageList 'EasyITCenter.DBModel.CustomMessageList')
- [DBConn](#T-EasyITCenter-ServerCoreStructure-DBConn 'EasyITCenter.ServerCoreStructure.DBConn')
  - [DatabaseConnectionString](#P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseConnectionString 'EasyITCenter.ServerCoreStructure.DBConn.DatabaseConnectionString')
  - [DatabaseInternalCacheTimeoutMin](#P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseInternalCacheTimeoutMin 'EasyITCenter.ServerCoreStructure.DBConn.DatabaseInternalCacheTimeoutMin')
  - [DatabaseInternalCachingEnabled](#P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseInternalCachingEnabled 'EasyITCenter.ServerCoreStructure.DBConn.DatabaseInternalCachingEnabled')
  - [DatabaseLogWarnToDbEnabled](#P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseLogWarnToDbEnabled 'EasyITCenter.ServerCoreStructure.DBConn.DatabaseLogWarnToDbEnabled')
  - [DatabaseMigrationEnabled](#P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseMigrationEnabled 'EasyITCenter.ServerCoreStructure.DBConn.DatabaseMigrationEnabled')
- [DBResult](#T-EasyITCenter-DBModel-DBResult 'EasyITCenter.DBModel.DBResult')
- [DBWebApiResponses](#T-EasyITCenter-WebClasses-DBWebApiResponses 'EasyITCenter.WebClasses.DBWebApiResponses')
- [DataOperations](#T-EasyITCenter-ServerCoreStructure-DataOperations 'EasyITCenter.ServerCoreStructure.DataOperations')
  - [ConvertDataTableToXml(dataTable,tablename)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertDataTableToXml-System-Data-DataTable,System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.ConvertDataTableToXml(System.Data.DataTable,System.String)')
  - [ConvertDictionaryListToJson(keyList)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertDictionaryListToJson-System-Collections-Generic-Dictionary{System-String,System-String}- 'EasyITCenter.ServerCoreStructure.DataOperations.ConvertDictionaryListToJson(System.Collections.Generic.Dictionary{System.String,System.String})')
  - [ConvertGenericClassToStandard\`\`1(data)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertGenericClassToStandard``1-``0- 'EasyITCenter.ServerCoreStructure.DataOperations.ConvertGenericClassToStandard``1(``0)')
  - [ConvertTableToClassListByType(dt,classType)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertTableToClassListByType-System-Data-DataTable,System-Type- 'EasyITCenter.ServerCoreStructure.DataOperations.ConvertTableToClassListByType(System.Data.DataTable,System.Type)')
  - [CreateObjectTypeByTypeName(className)](#M-EasyITCenter-ServerCoreStructure-DataOperations-CreateObjectTypeByTypeName-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.CreateObjectTypeByTypeName(System.String)')
  - [FirstCharToLowerCase(str)](#M-EasyITCenter-ServerCoreStructure-DataOperations-FirstCharToLowerCase-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.FirstCharToLowerCase(System.String)')
  - [GenericConvertTableToClassList\`\`1(dt)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GenericConvertTableToClassList``1-System-Data-DataTable- 'EasyITCenter.ServerCoreStructure.DataOperations.GenericConvertTableToClassList``1(System.Data.DataTable)')
  - [GenericToEnum\`\`1(value)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GenericToEnum``1-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.GenericToEnum``1(System.String)')
  - [GetByteArrayFrom64Encode(strContent)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GetByteArrayFrom64Encode-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.GetByteArrayFrom64Encode(System.String)')
  - [GetErrMsg(exception,msgCount)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GetErrMsg-System-Exception,System-Int32- 'EasyITCenter.ServerCoreStructure.DataOperations.GetErrMsg(System.Exception,System.Int32)')
  - [GetHandleBarPartialVariable(template)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GetHandleBarPartialVariable-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.GetHandleBarPartialVariable(System.String)')
  - [GetUserApiErrMessage(exception,msgCount)](#M-EasyITCenter-ServerCoreStructure-DataOperations-GetUserApiErrMessage-System-Exception,System-Int32- 'EasyITCenter.ServerCoreStructure.DataOperations.GetUserApiErrMessage(System.Exception,System.Int32)')
  - [IsValidEmail(email)](#M-EasyITCenter-ServerCoreStructure-DataOperations-IsValidEmail-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.IsValidEmail(System.String)')
  - [MarkDownLineEndSpacesResolve(input)](#M-EasyITCenter-ServerCoreStructure-DataOperations-MarkDownLineEndSpacesResolve-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.MarkDownLineEndSpacesResolve(System.String)')
  - [NullSetInExtensionFields\`\`1()](#M-EasyITCenter-ServerCoreStructure-DataOperations-NullSetInExtensionFields``1-``0@- 'EasyITCenter.ServerCoreStructure.DataOperations.NullSetInExtensionFields``1(``0@)')
  - [ObjectToJson(obj)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ObjectToJson-System-Object- 'EasyITCenter.ServerCoreStructure.DataOperations.ObjectToJson(System.Object)')
  - [ParseEnum\`\`1(value)](#M-EasyITCenter-ServerCoreStructure-DataOperations-ParseEnum``1-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.ParseEnum``1(System.String)')
  - [RandomString(length)](#M-EasyITCenter-ServerCoreStructure-DataOperations-RandomString-System-Int32- 'EasyITCenter.ServerCoreStructure.DataOperations.RandomString(System.Int32)')
  - [RemoveDiacritism(Text)](#M-EasyITCenter-ServerCoreStructure-DataOperations-RemoveDiacritism-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.RemoveDiacritism(System.String)')
  - [RemoveWhitespace(input)](#M-EasyITCenter-ServerCoreStructure-DataOperations-RemoveWhitespace-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.RemoveWhitespace(System.String)')
  - [StringToUTF8(text)](#M-EasyITCenter-ServerCoreStructure-DataOperations-StringToUTF8-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.StringToUTF8(System.String)')
  - [UnicodeToUTF8(strFrom)](#M-EasyITCenter-ServerCoreStructure-DataOperations-UnicodeToUTF8-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.UnicodeToUTF8(System.String)')
  - [Utf8toUnicode(utf8String)](#M-EasyITCenter-ServerCoreStructure-DataOperations-Utf8toUnicode-System-String- 'EasyITCenter.ServerCoreStructure.DataOperations.Utf8toUnicode(System.String)')
- [DatabaseContextExtensions](#T-EasyITCenter-Controllers-DatabaseContextExtensions 'EasyITCenter.Controllers.DatabaseContextExtensions')
  - [WriteVisit(ipAddress,userId,userName)](#M-EasyITCenter-Controllers-DatabaseContextExtensions-WriteVisit-System-String,System-Int32,System-String- 'EasyITCenter.Controllers.DatabaseContextExtensions.WriteVisit(System.String,System.Int32,System.String)')
  - [WriteWebVisit(ipAddress)](#M-EasyITCenter-Controllers-DatabaseContextExtensions-WriteWebVisit-System-String- 'EasyITCenter.Controllers.DatabaseContextExtensions.WriteWebVisit(System.String)')
- [DatabaseService](#T-EasyITCenter-Controllers-DatabaseService 'EasyITCenter.Controllers.DatabaseService')
  - [GetSystemOperationsList(dataset)](#M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsList-System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}- 'EasyITCenter.Controllers.DatabaseService.GetSystemOperationsList(System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}})')
  - [GetSystemOperationsList(procedureName)](#M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsList-System-String- 'EasyITCenter.Controllers.DatabaseService.GetSystemOperationsList(System.String)')
  - [GetSystemOperationsListJson(procedureName)](#M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsListJson-System-String- 'EasyITCenter.Controllers.DatabaseService.GetSystemOperationsListJson(System.String)')
  - [RunAdminQuery(query)](#M-EasyITCenter-Controllers-DatabaseService-RunAdminQuery-System-String- 'EasyITCenter.Controllers.DatabaseService.RunAdminQuery(System.String)')
  - [SetGenericDataListByParams(dataset)](#M-EasyITCenter-Controllers-DatabaseService-SetGenericDataListByParams-System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}- 'EasyITCenter.Controllers.DatabaseService.SetGenericDataListByParams(System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}})')
  - [SpGetProcedureParams(procedureName)](#M-EasyITCenter-Controllers-DatabaseService-SpGetProcedureParams-System-String- 'EasyITCenter.Controllers.DatabaseService.SpGetProcedureParams(System.String)')
  - [SpGetSystemPageList()](#M-EasyITCenter-Controllers-DatabaseService-SpGetSystemPageList 'EasyITCenter.Controllers.DatabaseService.SpGetSystemPageList')
  - [SpGetTableList()](#M-EasyITCenter-Controllers-DatabaseService-SpGetTableList 'EasyITCenter.Controllers.DatabaseService.SpGetTableList')
  - [SpGetTableSchema()](#M-EasyITCenter-Controllers-DatabaseService-SpGetTableSchema-System-String- 'EasyITCenter.Controllers.DatabaseService.SpGetTableSchema(System.String)')
  - [SpGetUserMenuList()](#M-EasyITCenter-Controllers-DatabaseService-SpGetUserMenuList 'EasyITCenter.Controllers.DatabaseService.SpGetUserMenuList')
- [DbOperations](#T-EasyITCenter-ServerCoreStructure-DbOperations 'EasyITCenter.ServerCoreStructure.DbOperations')
  - [CheckDBServerApiRule(serverPath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRule-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDBServerApiRule(System.String)')
  - [CheckDBServerApiRuleOffline(serverPath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRuleOffline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDBServerApiRuleOffline(System.String)')
  - [CheckDBServerApiRuleOnline(serverPath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRuleOnline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDBServerApiRuleOnline(System.String)')
  - [CheckDefinedWebPageExists(modulePath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageExists-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDefinedWebPageExists(System.String)')
  - [CheckDefinedWebPageOffline(modulePath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageOffline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDefinedWebPageOffline(System.String)')
  - [CheckDefinedWebPageOnline(modulePath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageOnline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.CheckDefinedWebPageOnline(System.String)')
  - [DBTranslate(word,language)](#M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslate-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.DBTranslate(System.String,System.String)')
  - [DBTranslateOffline(word,language)](#M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslateOffline-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.DBTranslateOffline(System.String,System.String)')
  - [DBTranslateOnline(word,language)](#M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslateOnline-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.DBTranslateOnline(System.String,System.String)')
  - [GetServerApiSecurityOffline(modulePath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetServerApiSecurityOffline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetServerApiSecurityOffline(System.String)')
  - [GetServerApiSecurityOnline(modulePath)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetServerApiSecurityOnline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetServerApiSecurityOnline(System.String)')
  - [GetWebGlobalPageBlockLists(pagePartType)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockLists-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebGlobalPageBlockLists(System.String)')
  - [GetWebGlobalPageBlockListsOffline(pagePartType)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockListsOffline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebGlobalPageBlockListsOffline(System.String)')
  - [GetWebGlobalPageBlockListsOnline(pagePartType)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockListsOnline-System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebGlobalPageBlockListsOnline(System.String)')
  - [GetWebPortalJsCssScripts(specType,fileName)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScripts-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebPortalJsCssScripts(System.String,System.String)')
  - [GetWebPortalJsCssScriptsOffline(specType,fileName)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScriptsOffline-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebPortalJsCssScriptsOffline(System.String,System.String)')
  - [GetWebPortalJsCssScriptsOnline(specType,fileName)](#M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScriptsOnline-System-String,System-String- 'EasyITCenter.ServerCoreStructure.DbOperations.GetWebPortalJsCssScriptsOnline(System.String,System.String)')
  - [LoadOrRefreshStaticDbDials(onlyThis)](#M-EasyITCenter-ServerCoreStructure-DbOperations-LoadOrRefreshStaticDbDials-System-Nullable{EasyITCenter-ServerCoreStructure-ServerLocalDbDialsTypes}- 'EasyITCenter.ServerCoreStructure.DbOperations.LoadOrRefreshStaticDbDials(System.Nullable{EasyITCenter.ServerCoreStructure.ServerLocalDbDialsTypes})')
- [DownloadService](#T-EasyITCenter-Controllers-DownloadService 'EasyITCenter.Controllers.DownloadService')
  - [DownloadHtmlPage(url)](#M-EasyITCenter-Controllers-DownloadService-DownloadHtmlPage-System-String- 'EasyITCenter.Controllers.DownloadService.DownloadHtmlPage(System.String)')
- [EICServer](#T-EasyITCenter-EICServer 'EasyITCenter.EICServer')
  - [SrvDBConn](#F-EasyITCenter-EICServer-SrvDBConn 'EasyITCenter.EICServer.SrvDBConn')
  - [SrvRuntime](#F-EasyITCenter-EICServer-SrvRuntime 'EasyITCenter.EICServer.SrvRuntime')
  - [BuildWebHost(args)](#M-EasyITCenter-EICServer-BuildWebHost-System-String[]- 'EasyITCenter.EICServer.BuildWebHost(System.String[])')
  - [CheckLicense()](#M-EasyITCenter-EICServer-CheckLicense 'EasyITCenter.EICServer.CheckLicense')
  - [LoadConfigurationFromFile()](#M-EasyITCenter-EICServer-LoadConfigurationFromFile 'EasyITCenter.EICServer.LoadConfigurationFromFile')
  - [Main(args)](#M-EasyITCenter-EICServer-Main-System-String[]- 'EasyITCenter.EICServer.Main(System.String[])')
  - [RestartServer()](#M-EasyITCenter-EICServer-RestartServer 'EasyITCenter.EICServer.RestartServer')
  - [StartServer()](#M-EasyITCenter-EICServer-StartServer 'EasyITCenter.EICServer.StartServer')
- [EasyITCenterContext](#T-EasyITCenter-Controllers-EasyITCenterContext 'EasyITCenter.Controllers.EasyITCenterContext')
- [EmailService](#T-EasyITCenter-Controllers-EmailService 'EasyITCenter.Controllers.EmailService')
- [ExpertDocApi](#T-EasyITCenter-Controllers-ExpertDocApi 'EasyITCenter.Controllers.ExpertDocApi')
  - [GetDocumentationGroupedList(id)](#M-EasyITCenter-Controllers-ExpertDocApi-GetDocumentationGroupedList 'EasyITCenter.Controllers.ExpertDocApi.GetDocumentationGroupedList')
  - [GetDocumentationGroupedList(id)](#M-EasyITCenter-Controllers-ExpertDocApi-GetDocumentationGroupedList-System-Int32- 'EasyITCenter.Controllers.ExpertDocApi.GetDocumentationGroupedList(System.Int32)')
- [ExportService](#T-EasyITCenter-Controllers-ExportService 'EasyITCenter.Controllers.ExportService')
  - [ExportStaticSystemPortal()](#M-EasyITCenter-Controllers-ExportService-ExportStaticSystemPortal 'EasyITCenter.Controllers.ExportService.ExportStaticSystemPortal')
  - [ExportXamlCz()](#M-EasyITCenter-Controllers-ExportService-ExportXamlCz 'EasyITCenter.Controllers.ExportService.ExportXamlCz')
  - [ExportXamlEn()](#M-EasyITCenter-Controllers-ExportService-ExportXamlEn 'EasyITCenter.Controllers.ExportService.ExportXamlEn')
  - [GetDgmlDatabaseSchema()](#M-EasyITCenter-Controllers-ExportService-GetDgmlDatabaseSchema 'EasyITCenter.Controllers.ExportService.GetDgmlDatabaseSchema')
  - [GetSqlDatabaseSchema()](#M-EasyITCenter-Controllers-ExportService-GetSqlDatabaseSchema 'EasyITCenter.Controllers.ExportService.GetSqlDatabaseSchema')
- [FileMinifyService](#T-EasyITCenter-ControllersExtensions-FileMinifyService 'EasyITCenter.ControllersExtensions.FileMinifyService')
  - [MinifyAndReturn(filelist)](#M-EasyITCenter-ControllersExtensions-FileMinifyService-MinifyAndReturn-EasyITCenter-ControllersExtensions-WebFileList- 'EasyITCenter.ControllersExtensions.FileMinifyService.MinifyAndReturn(EasyITCenter.ControllersExtensions.WebFileList)')
  - [MinifyAndSaveMinToPath(filelist)](#M-EasyITCenter-ControllersExtensions-FileMinifyService-MinifyAndSaveMinToPath-EasyITCenter-ControllersExtensions-WebFileList- 'EasyITCenter.ControllersExtensions.FileMinifyService.MinifyAndSaveMinToPath(EasyITCenter.ControllersExtensions.WebFileList)')
- [FileOperations](#T-EasyITCenter-ServerCoreStructure-FileOperations 'EasyITCenter.ServerCoreStructure.FileOperations')
  - [ByteArrayToFile(fileName,byteArray)](#M-EasyITCenter-ServerCoreStructure-FileOperations-ByteArrayToFile-System-String,System-Byte[]- 'EasyITCenter.ServerCoreStructure.FileOperations.ByteArrayToFile(System.String,System.Byte[])')
  - [CheckDirectory(directory)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CheckDirectory-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CheckDirectory(System.String)')
  - [CheckFile(file)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CheckFile-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CheckFile(System.String)')
  - [ClearFolder(FolderName)](#M-EasyITCenter-ServerCoreStructure-FileOperations-ClearFolder-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.ClearFolder(System.String)')
  - [ConvertSystemFilePathFromUrl(webpath)](#M-EasyITCenter-ServerCoreStructure-FileOperations-ConvertSystemFilePathFromUrl-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.ConvertSystemFilePathFromUrl(System.String)')
  - [CopyDirectory(directory)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CopyDirectory-System-String,System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CopyDirectory(System.String,System.String)')
  - [CopyFile(from,to)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CopyFile-System-String,System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CopyFile(System.String,System.String)')
  - [CopyFiles(sourcePath,destinationPath)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CopyFiles-System-String,System-String,System-Boolean- 'EasyITCenter.ServerCoreStructure.FileOperations.CopyFiles(System.String,System.String,System.Boolean)')
  - [CreateDirectory(directory)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CreateDirectory-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CreateDirectory(System.String)')
  - [CreateFile(file)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CreateFile-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.CreateFile(System.String)')
  - [CreatePath(path,clearIfExist)](#M-EasyITCenter-ServerCoreStructure-FileOperations-CreatePath-System-String,System-Boolean- 'EasyITCenter.ServerCoreStructure.FileOperations.CreatePath(System.String,System.Boolean)')
  - [DeleteDirectory(directory)](#M-EasyITCenter-ServerCoreStructure-FileOperations-DeleteDirectory-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.DeleteDirectory(System.String)')
  - [DeleteFile(file)](#M-EasyITCenter-ServerCoreStructure-FileOperations-DeleteFile-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.DeleteFile(System.String)')
  - [FileDetectEncoding(FileName)](#M-EasyITCenter-ServerCoreStructure-FileOperations-FileDetectEncoding-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.FileDetectEncoding(System.String)')
  - [GetLastFolderFromPath(fullPath)](#M-EasyITCenter-ServerCoreStructure-FileOperations-GetLastFolderFromPath-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.GetLastFolderFromPath(System.String)')
  - [GetPathFiles(sourcePath,fileMask,searchOption)](#M-EasyITCenter-ServerCoreStructure-FileOperations-GetPathFiles-System-String,System-String,System-IO-SearchOption- 'EasyITCenter.ServerCoreStructure.FileOperations.GetPathFiles(System.String,System.String,System.IO.SearchOption)')
  - [MoveDirectory(sourcePath,targetPath)](#M-EasyITCenter-ServerCoreStructure-FileOperations-MoveDirectory-System-String,System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.MoveDirectory(System.String,System.String)')
  - [MoveFile(from,to)](#M-EasyITCenter-ServerCoreStructure-FileOperations-MoveFile-System-String,System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.MoveFile(System.String,System.String)')
  - [ReadBinaryFile(fileName)](#M-EasyITCenter-ServerCoreStructure-FileOperations-ReadBinaryFile-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.ReadBinaryFile(System.String)')
  - [ReadTextFile(fileName)](#M-EasyITCenter-ServerCoreStructure-FileOperations-ReadTextFile-System-String- 'EasyITCenter.ServerCoreStructure.FileOperations.ReadTextFile(System.String)')
  - [WriteToFile(file,content,rewrite)](#M-EasyITCenter-ServerCoreStructure-FileOperations-WriteToFile-System-String,System-String,System-Boolean- 'EasyITCenter.ServerCoreStructure.FileOperations.WriteToFile(System.String,System.String,System.Boolean)')
- [GenericApiServiceAsync\`2](#T-EasyITCenter-Services-GenericApiServiceAsync`2 'EasyITCenter.Services.GenericApiServiceAsync`2')
- [GenericDataList](#T-EasyITCenter-DBModel-GenericDataList 'EasyITCenter.DBModel.GenericDataList')
- [GenericTable](#T-EasyITCenter-DBModel-GenericTable 'EasyITCenter.DBModel.GenericTable')
- [GithubService](#T-EasyITCenter-Controllers-GithubService 'EasyITCenter.Controllers.GithubService')
  - [DownloadGitHubRepoReadme(downloadRequest)](#M-EasyITCenter-Controllers-GithubService-DownloadGitHubRepoReadme-EasyITCenter-Controllers-GithubDownloadRequest- 'EasyITCenter.Controllers.GithubService.DownloadGitHubRepoReadme(EasyITCenter.Controllers.GithubDownloadRequest)')
  - [DownloadGitRepo(repoUrl)](#M-EasyITCenter-Controllers-GithubService-DownloadGitRepo-EasyITCenter-Controllers-GithubDownloadRequest- 'EasyITCenter.Controllers.GithubService.DownloadGitRepo(EasyITCenter.Controllers.GithubDownloadRequest)')
  - [GetGitHubReposList(searchRequest)](#M-EasyITCenter-Controllers-GithubService-GetGitHubReposList-EasyITCenter-Controllers-GithubSearchRequest- 'EasyITCenter.Controllers.GithubService.GetGitHubReposList(EasyITCenter.Controllers.GithubSearchRequest)')
- [HandleBarsService](#T-EasyITCenter-Controllers-HandleBarsService 'EasyITCenter.Controllers.HandleBarsService')
  - [GetTemplateCode(codegenRequest)](#M-EasyITCenter-Controllers-HandleBarsService-GetTemplateCode-EasyITCenter-Controllers-DataToTemplateRequest- 'EasyITCenter.Controllers.HandleBarsService.GetTemplateCode(EasyITCenter.Controllers.DataToTemplateRequest)')
- [HealthCheckActionService](#T-EasyITCenter-Services-HealthCheckActionService 'EasyITCenter.Services.HealthCheckActionService')
  - [PublishAsync(report,cancellationToken)](#M-EasyITCenter-Services-HealthCheckActionService-PublishAsync-Microsoft-Extensions-Diagnostics-HealthChecks-HealthReport,System-Threading-CancellationToken- 'EasyITCenter.Services.HealthCheckActionService.PublishAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport,System.Threading.CancellationToken)')
- [HostedFtpServer](#T-EasyITCenter-ServerCoreServers-HostedFtpServer 'EasyITCenter.ServerCoreServers.HostedFtpServer')
  - [#ctor(ftpServerHost)](#M-EasyITCenter-ServerCoreServers-HostedFtpServer-#ctor-FubarDev-FtpServer-IFtpServerHost- 'EasyITCenter.ServerCoreServers.HostedFtpServer.#ctor(FubarDev.FtpServer.IFtpServerHost)')
  - [StartAsync()](#M-EasyITCenter-ServerCoreServers-HostedFtpServer-StartAsync-System-Threading-CancellationToken- 'EasyITCenter.ServerCoreServers.HostedFtpServer.StartAsync(System.Threading.CancellationToken)')
  - [StopAsync()](#M-EasyITCenter-ServerCoreServers-HostedFtpServer-StopAsync-System-Threading-CancellationToken- 'EasyITCenter.ServerCoreServers.HostedFtpServer.StopAsync(System.Threading.CancellationToken)')
- [HostedFtpServerMembershipProvider](#T-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider')
  - [ValidateUser(username,password)](#M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUser-System-String,System-String- 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.ValidateUser(System.String,System.String)')
  - [ValidateUserAsync(username,password)](#M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUserAsync-System-String,System-String- 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.ValidateUserAsync(System.String,System.String)')
- [HtttpContextExtension](#T-EasyITCenter-ServerCoreStructure-HtttpContextExtension 'EasyITCenter.ServerCoreStructure.HtttpContextExtension')
  - [GetUserEmail()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserEmail 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.GetUserEmail')
  - [GetUserId()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserId 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.GetUserId')
  - [GetUserName()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserName 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.GetUserName')
  - [GetUserRole()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserRole 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.GetUserRole')
  - [IsAdmin()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsAdmin 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsAdmin')
  - [IsLogged()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsLogged 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsLogged')
  - [IsServerRequest()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsServerRequest 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsServerRequest')
  - [IsSystemUser()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsSystemUser 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsSystemUser')
  - [IsWebAdmin()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsWebAdmin 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsWebAdmin')
  - [IsWebUser()](#M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsWebUser 'EasyITCenter.ServerCoreStructure.HtttpContextExtension.IsWebUser')
- [IServerCycleTaskService](#T-EasyITCenter-Services-IServerCycleTaskService 'EasyITCenter.Services.IServerCycleTaskService')
- [JsonArray](#T-EasyITCenter-ServerCoreStructure-JsonArray 'EasyITCenter.ServerCoreStructure.JsonArray')
  - [#ctor()](#M-EasyITCenter-ServerCoreStructure-JsonArray-#ctor 'EasyITCenter.ServerCoreStructure.JsonArray.#ctor')
  - [#ctor(capacity)](#M-EasyITCenter-ServerCoreStructure-JsonArray-#ctor-System-Int32- 'EasyITCenter.ServerCoreStructure.JsonArray.#ctor(System.Int32)')
  - [ToString()](#M-EasyITCenter-ServerCoreStructure-JsonArray-ToString 'EasyITCenter.ServerCoreStructure.JsonArray.ToString')
- [JsonGeneratorService](#T-EasyITCenter-Controllers-JsonGeneratorService 'EasyITCenter.Controllers.JsonGeneratorService')
  - [GetFancyGuestMDFiles()](#M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyGuestMDFiles 'EasyITCenter.Controllers.JsonGeneratorService.GetFancyGuestMDFiles')
  - [GetFancyTreeCodeLibrary()](#M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyTreeCodeLibrary 'EasyITCenter.Controllers.JsonGeneratorService.GetFancyTreeCodeLibrary')
  - [GetFancyTreeJsonData(jsonDataRequest)](#M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyTreeJsonData-EasyITCenter-Controllers-FancyTreeJsonDataRequest- 'EasyITCenter.Controllers.JsonGeneratorService.GetFancyTreeJsonData(EasyITCenter.Controllers.FancyTreeJsonDataRequest)')
  - [GetFancyUserMDFiles()](#M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyUserMDFiles 'EasyITCenter.Controllers.JsonGeneratorService.GetFancyUserMDFiles')
- [JsonObject](#T-EasyITCenter-ServerCoreStructure-JsonObject 'EasyITCenter.ServerCoreStructure.JsonObject')
  - [#ctor()](#M-EasyITCenter-ServerCoreStructure-JsonObject-#ctor 'EasyITCenter.ServerCoreStructure.JsonObject.#ctor')
  - [#ctor(comparer)](#M-EasyITCenter-ServerCoreStructure-JsonObject-#ctor-System-Collections-Generic-IEqualityComparer{System-String}- 'EasyITCenter.ServerCoreStructure.JsonObject.#ctor(System.Collections.Generic.IEqualityComparer{System.String})')
  - [_members](#F-EasyITCenter-ServerCoreStructure-JsonObject-_members 'EasyITCenter.ServerCoreStructure.JsonObject._members')
  - [Count](#P-EasyITCenter-ServerCoreStructure-JsonObject-Count 'EasyITCenter.ServerCoreStructure.JsonObject.Count')
  - [IsReadOnly](#P-EasyITCenter-ServerCoreStructure-JsonObject-IsReadOnly 'EasyITCenter.ServerCoreStructure.JsonObject.IsReadOnly')
  - [Item](#P-EasyITCenter-ServerCoreStructure-JsonObject-Item-System-Int32- 'EasyITCenter.ServerCoreStructure.JsonObject.Item(System.Int32)')
  - [Item](#P-EasyITCenter-ServerCoreStructure-JsonObject-Item-System-String- 'EasyITCenter.ServerCoreStructure.JsonObject.Item(System.String)')
  - [Keys](#P-EasyITCenter-ServerCoreStructure-JsonObject-Keys 'EasyITCenter.ServerCoreStructure.JsonObject.Keys')
  - [Values](#P-EasyITCenter-ServerCoreStructure-JsonObject-Values 'EasyITCenter.ServerCoreStructure.JsonObject.Values')
  - [Add(key,value)](#M-EasyITCenter-ServerCoreStructure-JsonObject-Add-System-String,System-Object- 'EasyITCenter.ServerCoreStructure.JsonObject.Add(System.String,System.Object)')
  - [Add(item)](#M-EasyITCenter-ServerCoreStructure-JsonObject-Add-System-Collections-Generic-KeyValuePair{System-String,System-Object}- 'EasyITCenter.ServerCoreStructure.JsonObject.Add(System.Collections.Generic.KeyValuePair{System.String,System.Object})')
  - [Clear()](#M-EasyITCenter-ServerCoreStructure-JsonObject-Clear 'EasyITCenter.ServerCoreStructure.JsonObject.Clear')
  - [Contains(item)](#M-EasyITCenter-ServerCoreStructure-JsonObject-Contains-System-Collections-Generic-KeyValuePair{System-String,System-Object}- 'EasyITCenter.ServerCoreStructure.JsonObject.Contains(System.Collections.Generic.KeyValuePair{System.String,System.Object})')
  - [ContainsKey(key)](#M-EasyITCenter-ServerCoreStructure-JsonObject-ContainsKey-System-String- 'EasyITCenter.ServerCoreStructure.JsonObject.ContainsKey(System.String)')
  - [CopyTo(array,arrayIndex)](#M-EasyITCenter-ServerCoreStructure-JsonObject-CopyTo-System-Collections-Generic-KeyValuePair{System-String,System-Object}[],System-Int32- 'EasyITCenter.ServerCoreStructure.JsonObject.CopyTo(System.Collections.Generic.KeyValuePair{System.String,System.Object}[],System.Int32)')
  - [GetEnumerator()](#M-EasyITCenter-ServerCoreStructure-JsonObject-GetEnumerator 'EasyITCenter.ServerCoreStructure.JsonObject.GetEnumerator')
  - [Remove(key)](#M-EasyITCenter-ServerCoreStructure-JsonObject-Remove-System-String- 'EasyITCenter.ServerCoreStructure.JsonObject.Remove(System.String)')
  - [Remove(item)](#M-EasyITCenter-ServerCoreStructure-JsonObject-Remove-System-Collections-Generic-KeyValuePair{System-String,System-Object}- 'EasyITCenter.ServerCoreStructure.JsonObject.Remove(System.Collections.Generic.KeyValuePair{System.String,System.Object})')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-EasyITCenter-ServerCoreStructure-JsonObject-System#Collections#IEnumerable#GetEnumerator 'EasyITCenter.ServerCoreStructure.JsonObject.System#Collections#IEnumerable#GetEnumerator')
  - [ToString()](#M-EasyITCenter-ServerCoreStructure-JsonObject-ToString 'EasyITCenter.ServerCoreStructure.JsonObject.ToString')
  - [TryGetValue(key,value)](#M-EasyITCenter-ServerCoreStructure-JsonObject-TryGetValue-System-String,System-Object@- 'EasyITCenter.ServerCoreStructure.JsonObject.TryGetValue(System.String,System.Object@)')
- [MDDocBookGenerator](#T-EasyITCenter-Controllers-MDDocBookGenerator 'EasyITCenter.Controllers.MDDocBookGenerator')
- [MDGeneratorCreateIndexRequest](#T-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-MDGeneratorCreateIndexRequest 'EasyITCenter.Controllers.ServerApiGeneratorServerIndexService.MDGeneratorCreateIndexRequest')
- [MimeTypes](#T-EasyITCenter-MimeTypes 'EasyITCenter.MimeTypes')
  - [FallbackMimeType](#P-EasyITCenter-MimeTypes-FallbackMimeType 'EasyITCenter.MimeTypes.FallbackMimeType')
  - [GetMimeType(fileName)](#M-EasyITCenter-MimeTypes-GetMimeType-System-String- 'EasyITCenter.MimeTypes.GetMimeType(System.String)')
  - [GetMimeTypeExtensions(mimeType)](#M-EasyITCenter-MimeTypes-GetMimeTypeExtensions-System-String- 'EasyITCenter.MimeTypes.GetMimeTypeExtensions(System.String)')
  - [TryGetMimeType(fileName,mimeType)](#M-EasyITCenter-MimeTypes-TryGetMimeType-System-String,System-String@- 'EasyITCenter.MimeTypes.TryGetMimeType(System.String,System.String@)')
- [NetOperations](#T-EasyITCenter-ServerCoreStructure-NetOperations 'EasyITCenter.ServerCoreStructure.NetOperations')
  - [GetSoapDataFromURL()](#M-EasyITCenter-ServerCoreStructure-NetOperations-GetSoapDataFromURL-System-String,System-String,System-String- 'EasyITCenter.ServerCoreStructure.NetOperations.GetSoapDataFromURL(System.String,System.String,System.String)')
- [ProcessOperations](#T-EasyITCenter-ServerCoreStructure-ProcessOperations 'EasyITCenter.ServerCoreStructure.ProcessOperations')
  - [RunPowerShellProcess(script)](#M-EasyITCenter-ServerCoreStructure-ProcessOperations-RunPowerShellProcess-EasyITCenter-Controllers-RunProcessRequest- 'EasyITCenter.ServerCoreStructure.ProcessOperations.RunPowerShellProcess(EasyITCenter.Controllers.RunProcessRequest)')
  - [ServerProcessFinishedAsync(sender,e)](#M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessFinishedAsync-System-Object,System-EventArgs- 'EasyITCenter.ServerCoreStructure.ProcessOperations.ServerProcessFinishedAsync(System.Object,System.EventArgs)')
  - [ServerProcessKill(processName)](#M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessKill-System-Int32- 'EasyITCenter.ServerCoreStructure.ProcessOperations.ServerProcessKill(System.Int32)')
  - [ServerProcessStartAsync(processDefinition)](#M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessStartAsync-EasyITCenter-Controllers-RunProcessRequest- 'EasyITCenter.ServerCoreStructure.ProcessOperations.ServerProcessStartAsync(EasyITCenter.Controllers.RunProcessRequest)')
- [ProcessService](#T-EasyITCenter-Controllers-ProcessService 'EasyITCenter.Controllers.ProcessService')
  - [StartProcessScript(processRequest)](#M-EasyITCenter-Controllers-ProcessService-StartProcessScript-EasyITCenter-Controllers-RunProcessRequest- 'EasyITCenter.Controllers.ProcessService.StartProcessScript(EasyITCenter.Controllers.RunProcessRequest)')
- [RSSLoad](#T-EasyITCenter-Controllers-RSSLoad 'EasyITCenter.Controllers.RSSLoad')
  - [GetRssFeed(rssUrl)](#M-EasyITCenter-Controllers-RSSLoad-GetRssFeed-System-String- 'EasyITCenter.Controllers.RSSLoad.GetRssFeed(System.String)')
- [ResultMessage](#T-EasyITCenter-DBModel-ResultMessage 'EasyITCenter.DBModel.ResultMessage')
- [RobotsController](#T-EasyITCenter-Controllers-RobotsController 'EasyITCenter.Controllers.RobotsController')
- [RootPerUserAccountDirectory](#T-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory 'EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory')
  - [#ctor(options,logger)](#M-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory-#ctor-Microsoft-Extensions-Options-IOptions{FubarDev-FtpServer-AccountManagement-Directories-RootPerUser-RootPerUserAccountDirectoryQueryOptions},Microsoft-Extensions-Logging-ILogger{EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory}- 'EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory.#ctor(Microsoft.Extensions.Options.IOptions{FubarDev.FtpServer.AccountManagement.Directories.RootPerUser.RootPerUserAccountDirectoryQueryOptions},Microsoft.Extensions.Logging.ILogger{EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory})')
  - [GetDirectories()](#M-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory-GetDirectories-FubarDev-FtpServer-IAccountInformation- 'EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory.GetDirectories(FubarDev.FtpServer.IAccountInformation)')
- [RouteLayoutTypes](#T-EasyITCenter-ServerCoreStructure-RouteLayoutTypes 'EasyITCenter.ServerCoreStructure.RouteLayoutTypes')
- [RoutingActionTypes](#T-EasyITCenter-ServerCoreStructure-RoutingActionTypes 'EasyITCenter.ServerCoreStructure.RoutingActionTypes')
- [RssService](#T-EasyITCenter-Controllers-RssService 'EasyITCenter.Controllers.RssService')
- [RunProcessRequest](#T-EasyITCenter-Controllers-RunProcessRequest 'EasyITCenter.Controllers.RunProcessRequest')
- [SendMailRequest](#T-EasyITCenter-Controllers-SendMailRequest 'EasyITCenter.Controllers.SendMailRequest')
- [ServerApiGeneratorServerIndexService](#T-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService 'EasyITCenter.Controllers.ServerApiGeneratorServerIndexService')
  - [ConfigureHtmlInfoHeader(request)](#M-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-ConfigureHtmlInfoHeader-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-WebUrlRequest- 'EasyITCenter.Controllers.ServerApiGeneratorServerIndexService.ConfigureHtmlInfoHeader(EasyITCenter.Controllers.ServerApiGeneratorServerIndexService.WebUrlRequest)')
- [ServerConfigurationServices](#T-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices')
  - [ConfigureAutoMinify(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureAutoMinify-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureAutoMinify(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureControllers(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureControllers(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureCookie(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureCookie(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDatabaseContext(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureDatabaseContext(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDefaultAuthentication(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDefaultAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureDefaultAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureFTPServer(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureFTPServer-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureFTPServer(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLetsEncrypt(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLetsEncrypt-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureLetsEncrypt(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLogging(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureLogging(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureScoped(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureScoped-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureScoped(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureServerManagement(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerManagement-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureServerManagement(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureServerWebPages(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerWebPages-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureServerWebPages(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureSingletons(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureSingletons-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureSingletons(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureThirdPartyApi(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureThirdPartyApi(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureTransient(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureTransient-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureTransient(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureUserFluentEmailing(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureUserFluentEmailing-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureUserFluentEmailing(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureWebSocketLoggerMonitor(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureWebSocketLoggerMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerConfigurationServices.ConfigureWebSocketLoggerMonitor(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerCoreAutoScheduler](#T-EasyITCenter-Services-ServerCoreAutoScheduler 'EasyITCenter.Services.ServerCoreAutoScheduler')
- [ServerCorePostFileRotatorApi](#T-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi 'EasyITCenter.ControllersExtensions.ServerCorePostFileRotatorApi')
  - [GetApiFileRotator(filename)](#M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-GetApiFileRotator-System-String- 'EasyITCenter.ControllersExtensions.ServerCorePostFileRotatorApi.GetApiFileRotator(System.String)')
  - [PostApiFileRotator()](#M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-PostApiFileRotator-System-Collections-Generic-List{Microsoft-AspNetCore-Http-IFormFile}- 'EasyITCenter.ControllersExtensions.ServerCorePostFileRotatorApi.PostApiFileRotator(System.Collections.Generic.List{Microsoft.AspNetCore.Http.IFormFile})')
  - [PutApiFileRotator()](#M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-PutApiFileRotator-System-Collections-Generic-List{Microsoft-AspNetCore-Http-IFormFile}- 'EasyITCenter.ControllersExtensions.ServerCorePostFileRotatorApi.PutApiFileRotator(System.Collections.Generic.List{Microsoft.AspNetCore.Http.IFormFile})')
- [ServerCoreWebToolsGenApi](#T-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi')
  - [GenerateCarouselGallery(imageList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateCarouselGallery-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateCarouselGallery(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateCarouselVideoGallery(videoList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateCarouselVideoGallery-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateCarouselVideoGallery(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateEasyGallery(imageList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateEasyGallery-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateEasyGallery(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateImageBook(imageList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateImageBook-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateImageBook(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateMdToMdBook(fileList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateMdToMdBook-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateMdToMdBook(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateMedialPresentation(imageList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateMedialPresentation-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateMedialPresentation(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateVideoPlayList(videoList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateVideoPlayList-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateVideoPlayList(EasyITCenter.WebClasses.UploadGeneratorFiles)')
  - [GenerateXmlToMd(fileList)](#M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateXmlToMd-EasyITCenter-WebClasses-UploadGeneratorFiles- 'EasyITCenter.ControllersExtensions.ServerCoreWebToolsGenApi.GenerateXmlToMd(EasyITCenter.WebClasses.UploadGeneratorFiles)')
- [ServerCycleTaskList](#T-EasyITCenter-Services-ServerCycleTaskList 'EasyITCenter.Services.ServerCycleTaskList')
- [ServerCycleTaskListHealthCheck](#T-EasyITCenter-Services-ServerCycleTaskListHealthCheck 'EasyITCenter.Services.ServerCycleTaskListHealthCheck')
- [ServerCycleTaskMiddleware](#T-EasyITCenter-Services-ServerCycleTaskMiddleware 'EasyITCenter.Services.ServerCycleTaskMiddleware')
- [ServerCycleTaskProcess](#T-EasyITCenter-Services-ServerCycleTaskProcess 'EasyITCenter.Services.ServerCycleTaskProcess')
- [ServerDocApi](#T-EasyITCenter-Controllers-ServerDocApi 'EasyITCenter.Controllers.ServerDocApi')
  - [GenerateMdBook()](#M-EasyITCenter-Controllers-ServerDocApi-GenerateMdBook 'EasyITCenter.Controllers.ServerDocApi.GenerateMdBook')
- [ServerEnablingServices](#T-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices')
  - [EnableAutoMinify(app)](#M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableAutoMinify-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices.EnableAutoMinify(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableCors()](#M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices.EnableCors(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableEndpoints()](#M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices.EnableEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableLogging()](#M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices.EnableLogging(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableWebSocket(app)](#M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerEnablingServices.EnableWebSocket(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerLocalDbDialsTypes](#T-EasyITCenter-ServerCoreStructure-ServerLocalDbDialsTypes 'EasyITCenter.ServerCoreStructure.ServerLocalDbDialsTypes')
- [ServerModules](#T-EasyITCenter-ServerCoreConfiguration-ServerModules 'EasyITCenter.ServerCoreConfiguration.ServerModules')
  - [ConfigureDBEntitySchema(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureDBEntitySchema-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureDBEntitySchema(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureDocumentation(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureDocumentation-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureDocumentation(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureHealthCheck(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureHealthCheck(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureLiveDataMonitor(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureLiveDataMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureLiveDataMonitor(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureMarkdownAsHtmlFiles(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureMarkdownAsHtmlFiles-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureMarkdownAsHtmlFiles(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureReportDesigner(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureReportDesigner-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureReportDesigner(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureScheduler(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureScheduler-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureScheduler(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
  - [ConfigureSwagger(services)](#M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@- 'EasyITCenter.ServerCoreConfiguration.ServerModules.ConfigureSwagger(Microsoft.Extensions.DependencyInjection.IServiceCollection@)')
- [ServerModulesEnabling](#T-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling')
  - [EnableDBEntitySchema()](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDBEntitySchema-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableDBEntitySchema(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableDocumentation()](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDocumentation-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableDocumentation(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableLiveDataMonitor()](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableLiveDataMonitor-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableLiveDataMonitor(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableMarkdownAsHtmlFiles(app)](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableMarkdownAsHtmlFiles-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableMarkdownAsHtmlFiles(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableReportDesigner(app)](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableReportDesigner-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableReportDesigner(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
  - [EnableSwagger()](#M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@- 'EasyITCenter.ServerCoreConfiguration.ServerModulesEnabling.EnableSwagger(Microsoft.AspNetCore.Builder.IApplicationBuilder@)')
- [ServerStatusTypes](#T-EasyITCenter-ServerCoreStructure-ServerStatusTypes 'EasyITCenter.ServerCoreStructure.ServerStatusTypes')
- [ServerWebPagesToken](#T-EasyITCenter-WebClasses-ServerWebPagesToken 'EasyITCenter.WebClasses.ServerWebPagesToken')
- [ServerWebProviderGetOnlyApi](#T-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi 'EasyITCenter.Controllers.ServerWebProviderGetOnlyApi')
  - [GetManagedCssJsScriptList()](#M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetManagedCssJsScriptList 'EasyITCenter.Controllers.ServerWebProviderGetOnlyApi.GetManagedCssJsScriptList')
  - [GetSolutionToolList()](#M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetSolutionToolList 'EasyITCenter.Controllers.ServerWebProviderGetOnlyApi.GetSolutionToolList')
  - [GetTemplateWebMenuList()](#M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetTemplateWebMenuList 'EasyITCenter.Controllers.ServerWebProviderGetOnlyApi.GetTemplateWebMenuList')
- [ServerWebSockeMonitorService](#T-EasyITCenter-Services-ServerWebSockeMonitorService 'EasyITCenter.Services.ServerWebSockeMonitorService')
- [SetReportFilter](#T-EasyITCenter-DBModel-SetReportFilter 'EasyITCenter.DBModel.SetReportFilter')
- [SimpleJson](#T-AutoResxTranslator-SimpleJson 'AutoResxTranslator.SimpleJson')
  - [DeserializeObject(json)](#M-AutoResxTranslator-SimpleJson-DeserializeObject-System-String- 'AutoResxTranslator.SimpleJson.DeserializeObject(System.String)')
  - [IsNumeric()](#M-AutoResxTranslator-SimpleJson-IsNumeric-System-Object- 'AutoResxTranslator.SimpleJson.IsNumeric(System.Object)')
  - [SerializeObject(json,jsonSerializerStrategy)](#M-AutoResxTranslator-SimpleJson-SerializeObject-System-Object,AutoResxTranslator-IJsonSerializerStrategy- 'AutoResxTranslator.SimpleJson.SerializeObject(System.Object,AutoResxTranslator.IJsonSerializerStrategy)')
  - [TryDeserializeObject(json,obj)](#M-AutoResxTranslator-SimpleJson-TryDeserializeObject-System-String,System-Object@- 'AutoResxTranslator.SimpleJson.TryDeserializeObject(System.String,System.Object@)')
- [SitemapController](#T-EasyITCenter-Controllers-SitemapController 'EasyITCenter.Controllers.SitemapController')
  - [Index()](#M-EasyITCenter-Controllers-SitemapController-Index 'EasyITCenter.Controllers.SitemapController.Index')
  - [WebDocPortals()](#M-EasyITCenter-Controllers-SitemapController-WebDocPortals 'EasyITCenter.Controllers.SitemapController.WebDocPortals')
  - [WebPortal()](#M-EasyITCenter-Controllers-SitemapController-WebPortal 'EasyITCenter.Controllers.SitemapController.WebPortal')
- [SomeRSSProvider](#T-EasyITCenter-Controllers-SomeRSSProvider 'EasyITCenter.Controllers.SomeRSSProvider')
- [SrvOStype](#T-EasyITCenter-ServerCoreStructure-CoreOperations-SrvOStype 'EasyITCenter.ServerCoreStructure.CoreOperations.SrvOStype')
- [SrvRuntime](#T-EasyITCenter-ServerCoreStructure-SrvRuntime 'EasyITCenter.ServerCoreStructure.SrvRuntime')
- [Startup](#T-EasyITCenter-Startup 'EasyITCenter.Startup')
  - [Configure(app,serverLifetime)](#M-EasyITCenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Hosting-IHostApplicationLifetime,Microsoft-AspNetCore-Mvc-Infrastructure-IActionDescriptorCollectionProvider- 'EasyITCenter.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.Extensions.Hosting.IHostApplicationLifetime,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)')
  - [ConfigureServices(services)](#M-EasyITCenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'EasyITCenter.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ServerOnStarted()](#M-EasyITCenter-Startup-ServerOnStarted 'EasyITCenter.Startup.ServerOnStarted')
- [StatusPageService](#T-EasyITCenter-Controllers-StatusPageService 'EasyITCenter.Controllers.StatusPageService')
  - [Index()](#M-EasyITCenter-Controllers-StatusPageService-Index 'EasyITCenter.Controllers.StatusPageService.Index')
  - [NonExistPage()](#M-EasyITCenter-Controllers-StatusPageService-NonExistPage 'EasyITCenter.Controllers.StatusPageService.NonExistPage')
- [SupportGenFileTypes](#T-EasyITCenter-ServerCoreStructure-SupportGenFileTypes 'EasyITCenter.ServerCoreStructure.SupportGenFileTypes')
- [SystemBuilderOnlinePreviewApi](#T-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi 'EasyITCenter.Controllers.SystemBuilderOnlinePreviewApi')
  - [GetWebBuilderCodePreview()](#M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderCodePreview-System-Int32- 'EasyITCenter.Controllers.SystemBuilderOnlinePreviewApi.GetWebBuilderCodePreview(System.Int32)')
  - [GetWebBuilderGlobalBodyBlockPreview(id)](#M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderGlobalBodyBlockPreview-System-Int32- 'EasyITCenter.Controllers.SystemBuilderOnlinePreviewApi.GetWebBuilderGlobalBodyBlockPreview(System.Int32)')
  - [GetWebBuilderMenuPreview(id)](#M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderMenuPreview-System-Int32- 'EasyITCenter.Controllers.SystemBuilderOnlinePreviewApi.GetWebBuilderMenuPreview(System.Int32)')
- [SystemModulesModel](#T-ServerCorePages-SystemModulesModel 'ServerCorePages.SystemModulesModel')
  - [GetManagedCentralCssFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedCentralCssFiles 'ServerCorePages.SystemModulesModel.GetManagedCentralCssFiles')
  - [GetManagedCentralCssLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedCentralCssLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedCentralCssLayoutFiles')
  - [GetManagedCentralJsFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedCentralJsFiles 'ServerCorePages.SystemModulesModel.GetManagedCentralJsFiles')
  - [GetManagedCentralJsLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedCentralJsLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedCentralJsLayoutFiles')
  - [GetManagedGlobalCssFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedGlobalCssFiles 'ServerCorePages.SystemModulesModel.GetManagedGlobalCssFiles')
  - [GetManagedGlobalCssLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedGlobalCssLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedGlobalCssLayoutFiles')
  - [GetManagedGlobalJsFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedGlobalJsFiles 'ServerCorePages.SystemModulesModel.GetManagedGlobalJsFiles')
  - [GetManagedGlobalJsLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedGlobalJsLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedGlobalJsLayoutFiles')
  - [GetManagedMultiLangCssFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedMultiLangCssFiles 'ServerCorePages.SystemModulesModel.GetManagedMultiLangCssFiles')
  - [GetManagedMultiLangCssLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedMultiLangCssLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedMultiLangCssLayoutFiles')
  - [GetManagedMultiLangJsFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedMultiLangJsFiles 'ServerCorePages.SystemModulesModel.GetManagedMultiLangJsFiles')
  - [GetManagedMultiLangJsLayoutFiles()](#M-ServerCorePages-SystemModulesModel-GetManagedMultiLangJsLayoutFiles 'ServerCorePages.SystemModulesModel.GetManagedMultiLangJsLayoutFiles')
  - [OnGet()](#M-ServerCorePages-SystemModulesModel-OnGet 'ServerCorePages.SystemModulesModel.OnGet')
- [SystemPortalModel](#T-ServerCorePages-SystemPortalModel 'ServerCorePages.SystemPortalModel')
  - [GetManagedBodyPartForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedBodyPartForLayout 'ServerCorePages.SystemPortalModel.GetManagedBodyPartForLayout')
  - [GetManagedCssFilesForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedCssFilesForLayout 'ServerCorePages.SystemPortalModel.GetManagedCssFilesForLayout')
  - [GetManagedFooterPartForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedFooterPartForLayout 'ServerCorePages.SystemPortalModel.GetManagedFooterPartForLayout')
  - [GetManagedHeaderPostScriptsForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedHeaderPostScriptsForLayout 'ServerCorePages.SystemPortalModel.GetManagedHeaderPostScriptsForLayout')
  - [GetManagedHeaderPreCssForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedHeaderPreCssForLayout 'ServerCorePages.SystemPortalModel.GetManagedHeaderPreCssForLayout')
  - [GetManagedHeaderPreScriptsForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedHeaderPreScriptsForLayout 'ServerCorePages.SystemPortalModel.GetManagedHeaderPreScriptsForLayout')
  - [GetManagedJsFilesForLayout()](#M-ServerCorePages-SystemPortalModel-GetManagedJsFilesForLayout 'ServerCorePages.SystemPortalModel.GetManagedJsFilesForLayout')
  - [OnGet()](#M-ServerCorePages-SystemPortalModel-OnGet 'ServerCorePages.SystemPortalModel.OnGet')
- [SystemPortalOperations](#T-EasyITCenter-ServerCoreStructure-SystemPortalOperations 'EasyITCenter.ServerCoreStructure.SystemPortalOperations')
  - [DeleteWebSourceFile(hostingEnvironment,record)](#M-EasyITCenter-ServerCoreStructure-SystemPortalOperations-DeleteWebSourceFile-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@,EasyITCenter-DBModel-WebCoreFileList@- 'EasyITCenter.ServerCoreStructure.SystemPortalOperations.DeleteWebSourceFile(Microsoft.AspNetCore.Hosting.IWebHostEnvironment@,EasyITCenter.DBModel.WebCoreFileList@)')
  - [SaveWebSourceFile(hostingEnvironment,record)](#M-EasyITCenter-ServerCoreStructure-SystemPortalOperations-SaveWebSourceFile-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@,EasyITCenter-DBModel-WebCoreFileList@- 'EasyITCenter.ServerCoreStructure.SystemPortalOperations.SaveWebSourceFile(Microsoft.AspNetCore.Hosting.IWebHostEnvironment@,EasyITCenter.DBModel.WebCoreFileList@)')
- [SystemStdAuthGenericProviderApi\`3](#T-EasyITCenter-Controllers-SystemStdAuthGenericProviderApi`3 'EasyITCenter.Controllers.SystemStdAuthGenericProviderApi`3')
- [SystemStdFreeGenericProviderApi\`3](#T-EasyITCenter-Controllers-SystemStdFreeGenericProviderApi`3 'EasyITCenter.Controllers.SystemStdFreeGenericProviderApi`3')
- [UploadFileData](#T-EasyITCenter-WebClasses-UploadFileData 'EasyITCenter.WebClasses.UploadFileData')
- [UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles')
- [UserConfig](#T-EasyITCenter-WebClasses-UserConfig 'EasyITCenter.WebClasses.UserConfig')
- [UserStorageOperations](#T-EasyITCenter-ServerCoreStructure-UserStorageOperations 'EasyITCenter.ServerCoreStructure.UserStorageOperations')
  - [CreateUserStorage(username)](#M-EasyITCenter-ServerCoreStructure-UserStorageOperations-CreateUserStorage-System-String- 'EasyITCenter.ServerCoreStructure.UserStorageOperations.CreateUserStorage(System.String)')
  - [GetUserDirectories(userRootPath,path)](#M-EasyITCenter-ServerCoreStructure-UserStorageOperations-GetUserDirectories-System-String,System-String- 'EasyITCenter.ServerCoreStructure.UserStorageOperations.GetUserDirectories(System.String,System.String)')
  - [GetUserFiles(path)](#M-EasyITCenter-ServerCoreStructure-UserStorageOperations-GetUserFiles-System-String- 'EasyITCenter.ServerCoreStructure.UserStorageOperations.GetUserFiles(System.String)')
- [UserStorageService](#T-EasyITCenter-Controllers-UserStorageService 'EasyITCenter.Controllers.UserStorageService')
  - [ClearUserFolder(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-ClearUserFolder-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.ClearUserFolder(EasyITCenter.Controllers.UserStorageContent)')
  - [CopyUserFile(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-CopyUserFile-EasyITCenter-Controllers-UserStorageRenameDir- 'EasyITCenter.Controllers.UserStorageService.CopyUserFile(EasyITCenter.Controllers.UserStorageRenameDir)')
  - [CopyUserFolder(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-CopyUserFolder-EasyITCenter-Controllers-UserStorageRenameDir- 'EasyITCenter.Controllers.UserStorageService.CopyUserFolder(EasyITCenter.Controllers.UserStorageRenameDir)')
  - [CreateUserFile(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-CreateUserFile-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.CreateUserFile(EasyITCenter.Controllers.UserStorageContent)')
  - [CreateUserFolder(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-CreateUserFolder-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.CreateUserFolder(EasyITCenter.Controllers.UserStorageContent)')
  - [DeleteUserFile(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-DeleteUserFile-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.DeleteUserFile(EasyITCenter.Controllers.UserStorageContent)')
  - [DeleteUserFolder(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-DeleteUserFolder-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.DeleteUserFolder(EasyITCenter.Controllers.UserStorageContent)')
  - [DownloadUserFile(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-DownloadUserFile-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.DownloadUserFile(EasyITCenter.Controllers.UserStorageContent)')
  - [DownloadUserFolder(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-DownloadUserFolder-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.DownloadUserFolder(EasyITCenter.Controllers.UserStorageContent)')
  - [GetSunImageList()](#M-EasyITCenter-Controllers-UserStorageService-GetSunImageList 'EasyITCenter.Controllers.UserStorageService.GetSunImageList')
  - [GetUserStorage()](#M-EasyITCenter-Controllers-UserStorageService-GetUserStorage 'EasyITCenter.Controllers.UserStorageService.GetUserStorage')
  - [MoveUserFile(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-MoveUserFile-EasyITCenter-Controllers-UserStorageRenameDir- 'EasyITCenter.Controllers.UserStorageService.MoveUserFile(EasyITCenter.Controllers.UserStorageRenameDir)')
  - [MoveUserFolder(userStorageRenameDir)](#M-EasyITCenter-Controllers-UserStorageService-MoveUserFolder-EasyITCenter-Controllers-UserStorageRenameDir- 'EasyITCenter.Controllers.UserStorageService.MoveUserFolder(EasyITCenter.Controllers.UserStorageRenameDir)')
  - [SetUserTextFile(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-SetUserTextFile-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.SetUserTextFile(EasyITCenter.Controllers.UserStorageContent)')
  - [UploadUserFiles(userStorageContent)](#M-EasyITCenter-Controllers-UserStorageService-UploadUserFiles-EasyITCenter-Controllers-UserStorageContent- 'EasyITCenter.Controllers.UserStorageService.UploadUserFiles(EasyITCenter.Controllers.UserStorageContent)')
- [ViewerReportFileModel](#T-ServerCorePages-ViewerReportFileModel 'ServerCorePages.ViewerReportFileModel')
- [WebGlobalMessageModuleApi](#T-EasyITCenter-Controllers-WebGlobalMessageModuleApi 'EasyITCenter.Controllers.WebGlobalMessageModuleApi')
  - [SaveNewsletterPreview()](#M-EasyITCenter-Controllers-WebGlobalMessageModuleApi-SaveNewsletterPreview-System-Object- 'EasyITCenter.Controllers.WebGlobalMessageModuleApi.SaveNewsletterPreview(System.Object)')
- [WebMessage](#T-EasyITCenter-WebClasses-WebMessage 'EasyITCenter.WebClasses.WebMessage')
- [WebPagesAdminGroupMenuListApi](#T-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi 'EasyITCenter.Controllers.WebPagesAdminGroupMenuListApi')
  - [DeleteWebGroupMenuList(id)](#M-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi-DeleteWebGroupMenuList-System-String- 'EasyITCenter.Controllers.WebPagesAdminGroupMenuListApi.DeleteWebGroupMenuList(System.String)')
  - [InsertOrUpdateGroupWebMenuList(record)](#M-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi-InsertOrUpdateGroupWebMenuList-EasyITCenter-WebClasses-WebSettingList1- 'EasyITCenter.Controllers.WebPagesAdminGroupMenuListApi.InsertOrUpdateGroupWebMenuList(EasyITCenter.WebClasses.WebSettingList1)')
- [WebPagesSystemDataGetOnlyApi](#T-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi 'EasyITCenter.Controllers.WebPagesSystemDataGetOnlyApi')
  - [GetDeveloperNewsList(rec)](#M-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi-GetDeveloperNewsList 'EasyITCenter.Controllers.WebPagesSystemDataGetOnlyApi.GetDeveloperNewsList')
  - [GetMottoList()](#M-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi-GetMottoList 'EasyITCenter.Controllers.WebPagesSystemDataGetOnlyApi.GetMottoList')
- [WebPagesSystemToolsApi](#T-EasyITCenter-Controllers-WebPagesSystemToolsApi 'EasyITCenter.Controllers.WebPagesSystemToolsApi')
  - [SaveNewMinifiedFile(rec)](#M-EasyITCenter-Controllers-WebPagesSystemToolsApi-SaveNewMinifiedFile-EasyITCenter-Controllers-MinifiedFile- 'EasyITCenter.Controllers.WebPagesSystemToolsApi.SaveNewMinifiedFile(EasyITCenter.Controllers.MinifiedFile)')
- [WebSocketLocation](#T-EasyITCenter-Managers-WebSocketLocation 'EasyITCenter.Managers.WebSocketLocation')
- [WebSocketLogger](#T-EasyITCenter-Services-WebSocketLogger 'EasyITCenter.Services.WebSocketLogger')
  - [Log\`\`1(logLevel,eventId,state,exception,formatter)](#M-EasyITCenter-Services-WebSocketLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}- 'EasyITCenter.Services.WebSocketLogger.Log``1(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,``0,System.Exception,System.Func{``0,System.Exception,System.String})')
- [WebSocketManager](#T-EasyITCenter-Managers-WebSocketManager 'EasyITCenter.Managers.WebSocketManager')
  - [AddSocketConnectionToCentralList(newWebSocket,socketAPIPath)](#M-EasyITCenter-Managers-WebSocketManager-AddSocketConnectionToCentralList-System-Net-WebSockets-WebSocket,System-String- 'EasyITCenter.Managers.WebSocketManager.AddSocketConnectionToCentralList(System.Net.WebSockets.WebSocket,System.String)')
  - [DisposeSocketConnectionsWithTimeOut()](#M-EasyITCenter-Managers-WebSocketManager-DisposeSocketConnectionsWithTimeOut 'EasyITCenter.Managers.WebSocketManager.DisposeSocketConnectionsWithTimeOut')
  - [ListenClientWebSocketMessages(webSocket,socketAPIPath)](#M-EasyITCenter-Managers-WebSocketManager-ListenClientWebSocketMessages-System-Net-WebSockets-WebSocket,System-String- 'EasyITCenter.Managers.WebSocketManager.ListenClientWebSocketMessages(System.Net.WebSockets.WebSocket,System.String)')
  - [SendMessageAndUpdateWebSocketsInSpecificPath(socketAPIPath,message)](#M-EasyITCenter-Managers-WebSocketManager-SendMessageAndUpdateWebSocketsInSpecificPath-System-String,System-String- 'EasyITCenter.Managers.WebSocketManager.SendMessageAndUpdateWebSocketsInSpecificPath(System.String,System.String)')
  - [SendMessageToClientSocket(webSocket,message)](#M-EasyITCenter-Managers-WebSocketManager-SendMessageToClientSocket-System-Net-WebSockets-WebSocket,System-String- 'EasyITCenter.Managers.WebSocketManager.SendMessageToClientSocket(System.Net.WebSockets.WebSocket,System.String)')
- [WebSocketService](#T-EasyITCenter-Controllers-WebSocketService 'EasyITCenter.Controllers.WebSocketService')
  - [Get()](#M-EasyITCenter-Controllers-WebSocketService-Get 'EasyITCenter.Controllers.WebSocketService.Get')
  - [GetBySocketAPIPath(id)](#M-EasyITCenter-Controllers-WebSocketService-GetBySocketAPIPath-System-String- 'EasyITCenter.Controllers.WebSocketService.GetBySocketAPIPath(System.String)')

<a name='T-EasyITCenter-Controllers-AdminApiGeneratorMdBookService'></a>
## AdminApiGeneratorMdBookService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-AdminApiGeneratorMdBookService-GenerateInteliMDBook-EasyITCenter-Controllers-MDDocBookGenerator-'></a>
### GenerateInteliMDBook(requestData) `method`

##### Summary

Generate/Update Inteli MDBook WebPage 
in Pathname for MD all MD files,
Update Only Work with "MdInteliBook" subfolder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestData | [EasyITCenter.Controllers.MDDocBookGenerator](#T-EasyITCenter-Controllers-MDDocBookGenerator 'EasyITCenter.Controllers.MDDocBookGenerator') |  |

<a name='M-EasyITCenter-Controllers-AdminApiGeneratorMdBookService-GenerateMDDocBook-EasyITCenter-Controllers-MDDocBookGeneratorRequest-'></a>
### GenerateMDDocBook(webFilesRequest) `method`

##### Summary

Summary MDBook Generator Request,
Generate Central Index MD Book on Existing folder structure,
Generate Fulltext MDBook Library and clean Processed Structure,
Link All File Types, Images and Video Are Shown,
CentralIndexOnly = generate Docs with Link all All Files or by LinkedFileTypeOnly setting,
MdBookLibrary = Generate FullSearch MdBookLibrary -HtmlFiles are converted to MD,
, For MD book are html files converted to MD,
ProcessRootPathOnly = only files in selected path will be processed,
OverwriteExisting = Rewrite Output File if Exist,
CleanProcessed = Delete the processed files,
LinkedFileTypeOnly = Extension,
SetLinkFileExtension = set the extension, for All or default do empty, other html,md,png
example html if is set Linked File only, other md file will be used,
Mining INFO FROM: "html", "js", "css", "cs", "xaml", "sql","json", "bat", "sh", "cmd",

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webFilesRequest | [EasyITCenter.Controllers.MDDocBookGeneratorRequest](#T-EasyITCenter-Controllers-MDDocBookGeneratorRequest 'EasyITCenter.Controllers.MDDocBookGeneratorRequest') |  |

<a name='T-EasyITCenter-Controllers-AdministrationService'></a>
## AdministrationService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Services Remote Control

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-EasyITCenter-Controllers-AdministrationService-FtpServerStart'></a>
### FtpServerStart() `method`

##### Summary

FtpServerStart Api

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-FtpServerStatus'></a>
### FtpServerStatus() `method`

##### Summary

FTP Server Status

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-FtpServerStop'></a>
### FtpServerStop() `method`

##### Summary

FtpServerStop Api

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-ServerRestart'></a>
### ServerRestart() `method`

##### Summary

Core Server Restart Control Api

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStart'></a>
### ServerSchedulerStart() `method`

##### Summary

Scheduler Server Controls

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStatus'></a>
### ServerSchedulerStatus() `method`

##### Summary

Scheduler Server Start

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-AdministrationService-ServerSchedulerStop'></a>
### ServerSchedulerStop() `method`

##### Summary

Scheduler Server Stop

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-DBModel-AuthenticateResponse'></a>
## AuthenticateResponse `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

The authenticate response.

<a name='T-EasyITCenter-Controllers-AuthenticationService'></a>
## AuthenticationService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-AuthenticationService-Authenticate-System-String,System-String-'></a>
### Authenticate(username,password) `method`

##### Summary

API Authenticated and Generate Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-AuthenticationService-RefreshUserToken-System-String,EasyITCenter-DBModel-AuthenticateResponse-'></a>
### RefreshUserToken(username,token) `method`

##### Summary

API Refresh User Token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| token | [EasyITCenter.DBModel.AuthenticateResponse](#T-EasyITCenter-DBModel-AuthenticateResponse 'EasyITCenter.DBModel.AuthenticateResponse') |  |

<a name='M-EasyITCenter-Controllers-AuthenticationService-TokenLifetimeValidator-System-Nullable{System-DateTime},System-Nullable{System-DateTime},Microsoft-IdentityModel-Tokens-SecurityToken,Microsoft-IdentityModel-Tokens-TokenValidationParameters-'></a>
### TokenLifetimeValidator(notBefore,expires,token,params) `method`

##### Summary

API Token LifeTime Validator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| notBefore | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| expires | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| token | [Microsoft.IdentityModel.Tokens.SecurityToken](#T-Microsoft-IdentityModel-Tokens-SecurityToken 'Microsoft.IdentityModel.Tokens.SecurityToken') |  |
| params | [Microsoft.IdentityModel.Tokens.TokenValidationParameters](#T-Microsoft-IdentityModel-Tokens-TokenValidationParameters 'Microsoft.IdentityModel.Tokens.TokenValidationParameters') |  |

<a name='T-EasyITCenter-WebClasses-AutoGenConnectionString'></a>
## AutoGenConnectionString `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Custom Class For Check ConnectionString

<a name='T-EasyITCenter-WebClasses-AutoGenRequest'></a>
## AutoGenRequest `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Custom Class For Server Generator Request Monitoring

<a name='T-EasyITCenter-Services-AutoScheduledJob'></a>
## AutoScheduledJob `type`

##### Namespace

EasyITCenter.Services

##### Summary

Autoscheduler Process Scheduled Task 
definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [T:EasyITCenter.Services.AutoScheduledJob](#T-T-EasyITCenter-Services-AutoScheduledJob 'T:EasyITCenter.Services.AutoScheduledJob') |  |

<a name='T-EasyITCenter-Controllers-BackendCheckService'></a>
## BackendCheckService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Simple Api for Checking Avaiability

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-EasyITCenter-Controllers-BackendCheckService-GetBackendCheckApi'></a>
### GetBackendCheckApi() `method`

##### Summary

Gets the backend check API.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-WebClasses-CarouselImage'></a>
## CarouselImage `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Generator Carousel Image Class

<a name='T-EasyITCenter-WebClasses-CarouselVideo'></a>
## CarouselVideo `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Generator Carousel Video Class

<a name='T-EasyITCenter-ServerCoreStructure-CoreOperations'></a>
## CoreOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Specific Server Core Operations Library

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-CallGetApiUrl-System-String-'></a>
### CallGetApiUrl(url) `method`

##### Summary

Calls the GET API URL with string Response

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL. |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-ChechUrlRequestValidOrAuthorized-Microsoft-AspNetCore-Http-HttpContext-'></a>
### ChechUrlRequestValidOrAuthorized(context) `method`

##### Summary

Selection Layout Between Static File / MarkDown / Or Portal
Resolve Routing Logic Layout Selection

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') |  |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-CheckTokenValidityFromString-System-String-'></a>
### CheckTokenValidityFromString(tokenString) `method`

##### Summary

Token Validator Extension For Server WebPages

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token string. |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-GetSelfSignedCertificate-System-String-'></a>
### GetSelfSignedCertificate(password) `method`

##### Summary

Gets the self signed certificate For API Security HTTPS.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-GetSelfSignedCertificateFromFile-System-String-'></a>
### GetSelfSignedCertificateFromFile() `method`

##### Summary

Set Imported Certificate from file on Server for Https File must has Valid path from
Startup Data Path

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-GetServerRegisteredRoutesList-System-String,System-Boolean-'></a>
### GetServerRegisteredRoutesList(patchForCheck,updateList) `method`

##### Summary

Scan Registered Routes List
You Can Check Pfysical API Path
Data are stored in ServerRuntimeData.ServerRegisteredRoutesList

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patchForCheck | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| updateList | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-SendEmail-EasyITCenter-Controllers-SendMailRequest,System-Boolean-'></a>
### SendEmail(mailRequest,sendImmediately) `method`

##### Summary

System Mailer sending Emails To service email with detected fail for analyze and
corrections on the Way provide better services every time !!! This You can implement
everywhere, !!! In Debug mode is written to Console, in Release will be sent email Empty
Sender And Recipients set email for Service Recipient

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mailRequest | [EasyITCenter.Controllers.SendMailRequest](#T-EasyITCenter-Controllers-SendMailRequest 'EasyITCenter.Controllers.SendMailRequest') |  |
| sendImmediately | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-SendMassEmail-System-Collections-Generic-List{EasyITCenter-Controllers-SendMailRequest}-'></a>
### SendMassEmail(mailRequests) `method`

##### Summary

Sends the mass mail.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mailRequests | [System.Collections.Generic.List{EasyITCenter.Controllers.SendMailRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{EasyITCenter.Controllers.SendMailRequest}') | The mail requests. |

<a name='M-EasyITCenter-ServerCoreStructure-CoreOperations-ValidAndGetTokenParameters'></a>
### ValidAndGetTokenParameters() `method`

##### Summary

Server Token Validation Parameters definition For Api is Used if is ON/Off for Api is On everyTime

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser'></a>
## CustomFtpUser `type`

##### Namespace

EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider

##### Summary

Custom FTP user implementation

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [CustomFtpUser](#T-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser 'EasyITCenter.ServerCoreServers.HostedFtpServerMembershipProvider.CustomFtpUser') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user name |

<a name='P-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-Name'></a>
### Name `property`

##### Summary

*Inherit from parent.*

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-CustomFtpUser-IsInGroup-System-String-'></a>
### IsInGroup() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-DBModel-CustomMessageList'></a>
## CustomMessageList `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

Custom Definition for Returning List with One Record from Operation Stored Procedures

<a name='T-EasyITCenter-ServerCoreStructure-DBConn'></a>
## DBConn `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Database Connection string

<a name='P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseConnectionString'></a>
### DatabaseConnectionString `property`

##### Summary

Server Database Connection string for Full Service of Database
Migration/Api/Check/Unlimited Develop !!!Warning: Check this connection for
Read/Write/Exec is enabled In Config File Must Be Only This Paramneter

<a name='P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseInternalCacheTimeoutMin'></a>
### DatabaseInternalCacheTimeoutMin `property`

##### Summary

Time in Minutes for Database Valid Cache Data and Refreshing Duplicit Functionality with
Database Server
Recommended: 30

<a name='P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseInternalCachingEnabled'></a>
### DatabaseInternalCachingEnabled `property`

##### Summary

Enable Disable Entity Framework Internal Cache I recommend turning it off : from Logic,
Duplicit Functionality with Database Server in complex process can generate problems
Recommended: false

<a name='P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseLogWarnToDbEnabled'></a>
### DatabaseLogWarnToDbEnabled `property`

##### Summary

Enable Logging Server Warn and Errors To Database

<a name='P-EasyITCenter-ServerCoreStructure-DBConn-DatabaseMigrationEnabled'></a>
### DatabaseMigrationEnabled `property`

##### Summary

Enable Disable Database Migration Process on Starrtup

<a name='T-EasyITCenter-DBModel-DBResult'></a>
## DBResult `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

Database response types definition

<a name='T-EasyITCenter-WebClasses-DBWebApiResponses'></a>
## DBWebApiResponses `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

WebApi Responses

<a name='T-EasyITCenter-ServerCoreStructure-DataOperations'></a>
## DataOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Data Formating and similar Operations Library

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertDataTableToXml-System-Data-DataTable,System-String-'></a>
### ConvertDataTableToXml(dataTable,tablename) `method`

##### Summary

Converts the data table to xml.

##### Returns

A XElement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataTable | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The data table. |
| tablename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The tablename. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertDictionaryListToJson-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### ConvertDictionaryListToJson(keyList) `method`

##### Summary

Convert Dictionary string,string To Json Suportted Values Bool, Int, String

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyList | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertGenericClassToStandard``1-``0-'></a>
### ConvertGenericClassToStandard\`\`1(data) `method`

##### Summary

Convert Generic Tabla To Standard Table For Use Standard System Fields

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ConvertTableToClassListByType-System-Data-DataTable,System-Type-'></a>
### ConvertTableToClassListByType(dt,classType) `method`

##### Summary

Convert Data Table To DataList of Type

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') |  |
| classType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-CreateObjectTypeByTypeName-System-String-'></a>
### CreateObjectTypeByTypeName(className) `method`

##### Summary

Create Object Type By Type Name
Its need For Generic APi For Full Database Support

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| className | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-FirstCharToLowerCase-System-String-'></a>
### FirstCharToLowerCase(str) `method`

##### Summary

Change First Character of String

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GenericConvertTableToClassList``1-System-Data-DataTable-'></a>
### GenericConvertTableToClassList\`\`1(dt) `method`

##### Summary

Generic Convert Data Table To DataList

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The dt. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GenericToEnum``1-System-String-'></a>
### GenericToEnum\`\`1(value) `method`

##### Summary

Convert String to Generic Enum

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GetByteArrayFrom64Encode-System-String-'></a>
### GetByteArrayFrom64Encode(strContent) `method`

##### Summary

Separate ByteArray from 64 encode file For inserted file types

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| strContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Content of the string. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GetErrMsg-System-Exception,System-Int32-'></a>
### GetErrMsg(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For System Save to Database For Simple Solving Problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GetHandleBarPartialVariable-System-String-'></a>
### GetHandleBarPartialVariable(template) `method`

##### Summary

Get HandleBar Partial Variable

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| template | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-GetUserApiErrMessage-System-Exception,System-Int32-'></a>
### GetUserApiErrMessage(exception,msgCount) `method`

##### Summary

Mined-ed Error Message For Answer in API Error Response with detailed info about problem

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-IsValidEmail-System-String-'></a>
### IsValidEmail(email) `method`

##### Summary

Determines whether [is valid email] [the specified email].

##### Returns

`true` if [is valid email] [the specified email]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The email. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-MarkDownLineEndSpacesResolve-System-String-'></a>
### MarkDownLineEndSpacesResolve(input) `method`

##### Summary

MarkDown Global Resolve End Spaces Characters On Insert/Update API CALS of Managing

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-NullSetInExtensionFields``1-``0@-'></a>
### NullSetInExtensionFields\`\`1() `method`

##### Summary

!!! SYSTEM RULE: ClassList with joining fields names must be nullable before API
operation !!! ClassName must contain: "Extended" WORD Extension field in Class - Dataset
must be set as null before Database Operation else is joining to other dataset is valid
and can be blocked by fail key Its Check Extended in ClassName - SYSTEM RULE

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ObjectToJson-System-Object-'></a>
### ObjectToJson(obj) `method`

##### Summary

Object To Json Serializer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-ParseEnum``1-System-String-'></a>
### ParseEnum\`\`1(value) `method`

##### Summary

Convert String To Enum

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-RandomString-System-Int32-'></a>
### RandomString(length) `method`

##### Summary

Randoms the string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-RemoveDiacritism-System-String-'></a>
### RemoveDiacritism(Text) `method`

##### Summary

Remove Diactritics

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-RemoveWhitespace-System-String-'></a>
### RemoveWhitespace(input) `method`

##### Summary

Removes the whitespace from the String.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-StringToUTF8-System-String-'></a>
### StringToUTF8(text) `method`

##### Summary

Convert String to UTF8

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-UnicodeToUTF8-System-String-'></a>
### UnicodeToUTF8(strFrom) `method`

##### Summary

Unicodes to ut f8.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| strFrom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string from. |

<a name='M-EasyITCenter-ServerCoreStructure-DataOperations-Utf8toUnicode-System-String-'></a>
### Utf8toUnicode(utf8String) `method`

##### Summary

Convert UTF8 to UNICODE

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utf8String | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITCenter-Controllers-DatabaseContextExtensions'></a>
## DatabaseContextExtensions `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Database Context Extensions for All Types Procedures For Retun Data in procedure can be
Simple SELECT * XXX and you Create Same Class for returned DataSet

<a name='M-EasyITCenter-Controllers-DatabaseContextExtensions-WriteVisit-System-String,System-Int32,System-String-'></a>
### WriteVisit(ipAddress,userId,userName) `method`

##### Summary

Trigger User Login History

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ipAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| userId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-DatabaseContextExtensions-WriteWebVisit-System-String-'></a>
### WriteWebVisit(ipAddress) `method`

##### Summary

Trigger Web IP Hosts History List
TODO MOVE to app.use AS Agenda Definition

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ipAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITCenter-Controllers-DatabaseService'></a>
## DatabaseService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Stored Procedures Central Library With Return Dynamic DataList

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsList-System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}-'></a>
### GetSystemOperationsList(dataset) `method`

##### Summary

Generic Procedure Return Full DB Over Params 
SpProcedure, tableName, userRole, userId 
in List Dictionary string,string
Can Provide All Procedure Datatypes

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataset | [System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsList-System-String-'></a>
### GetSystemOperationsList(procedureName) `method`

##### Summary

Return String Message

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| procedureName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-GetSystemOperationsListJson-System-String-'></a>
### GetSystemOperationsListJson(procedureName) `method`

##### Summary

Return File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| procedureName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-RunAdminQuery-System-String-'></a>
### RunAdminQuery(query) `method`

##### Summary

Run Admin Query with returned DataTable

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-SetGenericDataListByParams-System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}-'></a>
### SetGenericDataListByParams(dataset) `method`

##### Summary

Insert, Update, Delete Procerure For Any Table
Delete Must be only 1 Column Id
NUll values must be removed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataset | [System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-SpGetProcedureParams-System-String-'></a>
### SpGetProcedureParams(procedureName) `method`

##### Summary

Get DB Procedure param List Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| procedureName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Controllers-DatabaseService-SpGetSystemPageList'></a>
### SpGetSystemPageList() `method`

##### Summary

Gets Form Agendas Pages List For System Menu Definition.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-DatabaseService-SpGetTableList'></a>
### SpGetTableList() `method`

##### Summary

Gets Table List for Reporting

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-DatabaseService-SpGetTableSchema-System-String-'></a>
### SpGetTableSchema() `method`

##### Summary

Gets Table List for Reporting
TODO takova bude genericka procedura

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-DatabaseService-SpGetUserMenuList'></a>
### SpGetUserMenuList() `method`

##### Summary

Api For Logged User with Menu Datalist

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-DbOperations'></a>
## DbOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

All Server Definitions of Database Operation method

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRule-System-String-'></a>
### CheckDBServerApiRule(serverPath) `method`

##### Summary

Default Operation For Set Ignoring App.Use Paths
For MVC Tools, Static Webs And Content

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRuleOffline-System-String-'></a>
### CheckDBServerApiRuleOffline(serverPath) `method`

##### Summary

Get Ignored Static Web Or MVC Too Path In App.Use
For Continue Loading of Defined Layout or Static Web
Offline LocalDB Operation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDBServerApiRuleOnline-System-String-'></a>
### CheckDBServerApiRuleOnline(serverPath) `method`

##### Summary

Get Ignored Static Web Or MVC Too Path In App.Use
For Continue Loading of Defined Layout or Static Web
Online LocalDB Operation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageExists-System-String-'></a>
### CheckDefinedWebPageExists(modulePath) `method`

##### Summary

Default Operation for Call CHEckModuleExist
 Over Local Tables Functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modulePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageOffline-System-String-'></a>
### CheckDefinedWebPageOffline(modulePath) `method`

##### Summary

Get Check ServerModule from OneTime Load Server List

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modulePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-CheckDefinedWebPageOnline-System-String-'></a>
### CheckDefinedWebPageOnline(modulePath) `method`

##### Summary

Get Check ServerModule from DB

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modulePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslate-System-String,System-String-'></a>
### DBTranslate(word,language) `method`

##### Summary

Default Operation for Call Translation
 Over Local Tables Functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslateOffline-System-String,System-String-'></a>
### DBTranslateOffline(word,language) `method`

##### Summary

Database LanuageList for Off-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-DBTranslateOnline-System-String,System-String-'></a>
### DBTranslateOnline(word,language) `method`

##### Summary

Database LanuageList for On-line Using Definitions

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetServerApiSecurityOffline-System-String-'></a>
### GetServerApiSecurityOffline(modulePath) `method`

##### Summary

Get Standard Api Security Definition Offline Method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modulePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetServerApiSecurityOnline-System-String-'></a>
### GetServerApiSecurityOnline(modulePath) `method`

##### Summary

Get Standard Api Security Definition Online Method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modulePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockLists-System-String-'></a>
### GetWebGlobalPageBlockLists(pagePartType) `method`

##### Summary

Default Operation For Generate Web Portal
Over Local Tables Functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagePartType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockListsOffline-System-String-'></a>
### GetWebGlobalPageBlockListsOffline(pagePartType) `method`

##### Summary

Get WebGlobalPageBlockList Offline Method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagePartType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebGlobalPageBlockListsOnline-System-String-'></a>
### GetWebGlobalPageBlockListsOnline(pagePartType) `method`

##### Summary

Get WebGlobalPageBlockList OnLine Method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagePartType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScripts-System-String,System-String-'></a>
### GetWebPortalJsCssScripts(specType,fileName) `method`

##### Summary

Default Operation For Working Wihth 
Portal Scripts From Local Tables.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| specType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScriptsOffline-System-String,System-String-'></a>
### GetWebPortalJsCssScriptsOffline(specType,fileName) `method`

##### Summary

Default Operation For Working Wihth 
Portal Scripts From Local Tables Offline

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| specType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-GetWebPortalJsCssScriptsOnline-System-String,System-String-'></a>
### GetWebPortalJsCssScriptsOnline(specType,fileName) `method`

##### Summary

Default Operation For Working Wihth 
Portal Scripts From Local Tables. Online

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| specType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-DbOperations-LoadOrRefreshStaticDbDials-System-Nullable{EasyITCenter-ServerCoreStructure-ServerLocalDbDialsTypes}-'></a>
### LoadOrRefreshStaticDbDials(onlyThis) `method`

##### Summary

Method for All Server Defined Table for Local Using As Off line AutoUpdated Tables

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyThis | [System.Nullable{EasyITCenter.ServerCoreStructure.ServerLocalDbDialsTypes}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{EasyITCenter.ServerCoreStructure.ServerLocalDbDialsTypes}') |  |

<a name='T-EasyITCenter-Controllers-DownloadService'></a>
## DownloadService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-DownloadService-DownloadHtmlPage-System-String-'></a>
### DownloadHtmlPage(url) `method`

##### Summary

Html From URL Downloader Return InnerHtml

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITCenter-EICServer'></a>
## EICServer `type`

##### Namespace

EasyITCenter

##### Summary

Server Main Definition Starting Point Of Project

<a name='F-EasyITCenter-EICServer-SrvDBConn'></a>
### SrvDBConn `constants`

##### Summary

Initialize DB Connection from config File

<a name='F-EasyITCenter-EICServer-SrvRuntime'></a>
### SrvRuntime `constants`

##### Summary

Startup Server Initialization Server Runtime Data

<a name='M-EasyITCenter-EICServer-BuildWebHost-System-String[]-'></a>
### BuildWebHost(args) `method`

##### Summary

Final Preparing Server HostBuilder Definition

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-EasyITCenter-EICServer-CheckLicense'></a>
### CheckLicense() `method`

##### Summary

Checking Valid License on StartUp

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-EICServer-LoadConfigurationFromFile'></a>
### LoadConfigurationFromFile() `method`

##### Summary

Server Core: Load Configuration From Config File In Startup Folder/Data/config.json
For Linux is Loaded from server FOLder/Data/config.json
For Windows sysDrive://ProgramData/EasyITCenter/config.json
its Alone Different Setting FOR More Platforms

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-EICServer-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

Server Startup Process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-EasyITCenter-EICServer-RestartServer'></a>
### RestartServer() `method`

##### Summary

Server Restart Controller

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-EICServer-StartServer'></a>
### StartServer() `method`

##### Summary

Server Start Controller

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Controllers-EasyITCenterContext'></a>
## EasyITCenterContext `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Main Database Settings Here is Included ScaffoldContext which is connected via Visual
Studio Tool Here can Be added customization which are not on the server Here is Extended the
Context with Insert News Functionality Customizing and implement Settings for Automatic
Adopted Database Schema for Unlimited Working and Operations For Specifics API schemas
https://www.codeproject.com/Articles/5321286/Executing-Raw-SQL-Queries-using-Entity-Framework-C

<a name='T-EasyITCenter-Controllers-EmailService'></a>
## EmailService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Email sender Api for logged Communication

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EasyITCenter-Controllers-ExpertDocApi'></a>
## ExpertDocApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-ExpertDocApi-GetDocumentationGroupedList'></a>
### GetDocumentationGroupedList(id) `method`

##### Summary

ExpertDocManager Group Documentation Request Api

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [M:EasyITCenter.Controllers.ExpertDocApi.GetDocumentationGroupedList](#T-M-EasyITCenter-Controllers-ExpertDocApi-GetDocumentationGroupedList 'M:EasyITCenter.Controllers.ExpertDocApi.GetDocumentationGroupedList') | The identifier. |

<a name='M-EasyITCenter-Controllers-ExpertDocApi-GetDocumentationGroupedList-System-Int32-'></a>
### GetDocumentationGroupedList(id) `method`

##### Summary

ExpertDocManager Group Documentation Request Api

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier. |

<a name='T-EasyITCenter-Controllers-ExportService'></a>
## ExportService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-ExportService-ExportStaticSystemPortal'></a>
### ExportStaticSystemPortal() `method`

##### Summary

Minimal Export of Page for Running
on every Web servers Without Needs anythink

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ExportService-ExportXamlCz'></a>
### ExportXamlCz() `method`

##### Summary

Update Translation Table By All Tables and Field Names For Export Offline Language
Dictionary CZ for System

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ExportService-ExportXamlEn'></a>
### ExportXamlEn() `method`

##### Summary

Update Translation Table By All Tables and Field Names For Export Offline Language
Dictionary EN for System

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ExportService-GetDgmlDatabaseSchema'></a>
### GetDgmlDatabaseSchema() `method`

##### Summary

Database Dgml Schema

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ExportService-GetSqlDatabaseSchema'></a>
### GetSqlDatabaseSchema() `method`

##### Summary

Get Full DataBase SQL Script

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ControllersExtensions-FileMinifyService'></a>
## FileMinifyService `type`

##### Namespace

EasyITCenter.ControllersExtensions

##### Summary

Server Root Controller

<a name='M-EasyITCenter-ControllersExtensions-FileMinifyService-MinifyAndReturn-EasyITCenter-ControllersExtensions-WebFileList-'></a>
### MinifyAndReturn(filelist) `method`

##### Summary

Minify FileList and Return Back Without Rename

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filelist | [EasyITCenter.ControllersExtensions.WebFileList](#T-EasyITCenter-ControllersExtensions-WebFileList 'EasyITCenter.ControllersExtensions.WebFileList') |  |

<a name='M-EasyITCenter-ControllersExtensions-FileMinifyService-MinifyAndSaveMinToPath-EasyITCenter-ControllersExtensions-WebFileList-'></a>
### MinifyAndSaveMinToPath(filelist) `method`

##### Summary

Minifi FileList And Save As Minify to FilePath

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filelist | [EasyITCenter.ControllersExtensions.WebFileList](#T-EasyITCenter-ControllersExtensions-WebFileList 'EasyITCenter.ControllersExtensions.WebFileList') |  |

<a name='T-EasyITCenter-ServerCoreStructure-FileOperations'></a>
## FileOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-ByteArrayToFile-System-String,System-Byte[]-'></a>
### ByteArrayToFile(fileName,byteArray) `method`

##### Summary

Write ByteArray to File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |
| byteArray | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The byte array. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CheckDirectory-System-String-'></a>
### CheckDirectory(directory) `method`

##### Summary

Checks the directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CheckFile-System-String-'></a>
### CheckFile(file) `method`

##### Summary

Checks the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-ClearFolder-System-String-'></a>
### ClearFolder(FolderName) `method`

##### Summary

Full Clear Folder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FolderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the folder. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-ConvertSystemFilePathFromUrl-System-String-'></a>
### ConvertSystemFilePathFromUrl(webpath) `method`

##### Summary

Return Full File path to the operating system default slashes.
!!! USE as + With Path Combine Path.Combine(yourpath) + ConvertSystemFilePathFromUrl(string webpath);

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webpath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CopyDirectory-System-String,System-String-'></a>
### CopyDirectory(directory) `method`

##### Summary

Copy Full directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CopyFile-System-String,System-String-'></a>
### CopyFile(from,to) `method`

##### Summary

/

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | From. |
| to | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CopyFiles-System-String,System-String,System-Boolean-'></a>
### CopyFiles(sourcePath,destinationPath) `method`

##### Summary

Prepared Method for Files Copy

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| destinationPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CreateDirectory-System-String-'></a>
### CreateDirectory(directory) `method`

##### Summary

Creates the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CreateFile-System-String-'></a>
### CreateFile(file) `method`

##### Summary

Prepared Method for Create empty file
Create All directories in Path

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-CreatePath-System-String,System-Boolean-'></a>
### CreatePath(path,clearIfExist) `method`

##### Summary

Creates the path recursively.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| clearIfExist | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-DeleteDirectory-System-String-'></a>
### DeleteDirectory(directory) `method`

##### Summary

Deletes the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-DeleteFile-System-String-'></a>
### DeleteFile(file) `method`

##### Summary

Deletes the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-FileDetectEncoding-System-String-'></a>
### FileDetectEncoding(FileName) `method`

##### Summary

Prepared Method for Get Information of File encoding UTF8,WIN1250,etc

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-GetLastFolderFromPath-System-String-'></a>
### GetLastFolderFromPath(fullPath) `method`

##### Summary

Fild Last Lath from Path By Directory Separator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-GetPathFiles-System-String,System-String,System-IO-SearchOption-'></a>
### GetPathFiles(sourcePath,fileMask,searchOption) `method`

##### Summary

Get Folder Files from Direct Folder
or FULL Structure by fileMask

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileMask | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| searchOption | [System.IO.SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-MoveDirectory-System-String,System-String-'></a>
### MoveDirectory(sourcePath,targetPath) `method`

##### Summary

Move Directory Content
from Source to Destination Folder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-MoveFile-System-String,System-String-'></a>
### MoveFile(from,to) `method`

##### Summary

Move file From source to destination

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| to | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-ReadBinaryFile-System-String-'></a>
### ReadBinaryFile(fileName) `method`

##### Summary

Reads the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-ReadTextFile-System-String-'></a>
### ReadTextFile(fileName) `method`

##### Summary

Read File As string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-FileOperations-WriteToFile-System-String,System-String,System-Boolean-'></a>
### WriteToFile(file,content,rewrite) `method`

##### Summary

Write String to File Used for JsonSaving
If rewrite file is false, content is append

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| rewrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITCenter-Services-GenericApiServiceAsync`2'></a>
## GenericApiServiceAsync\`2 `type`

##### Namespace

EasyITCenter.Services

##### Summary

Generic Repository implementing generic interface 
Takes two generic parameters DbContext and
model class type

##### Generic Types

| Name | Description |
| ---- | ----------- |
| DbEntity |  |
| Tentity |  |

<a name='T-EasyITCenter-DBModel-GenericDataList'></a>
## GenericDataList `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

Custom Definition for Returning string List from Stored Procedures Named Data = ColumnName
in the Data string Can be Any Object

<a name='T-EasyITCenter-DBModel-GenericTable'></a>
## GenericTable `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

Generic Table Standard Fieds Public Class For Get Informations By System

<a name='T-EasyITCenter-Controllers-GithubService'></a>
## GithubService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-GithubService-DownloadGitHubRepoReadme-EasyITCenter-Controllers-GithubDownloadRequest-'></a>
### DownloadGitHubRepoReadme(downloadRequest) `method`

##### Summary

Get Readme For Selected Repository

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| downloadRequest | [EasyITCenter.Controllers.GithubDownloadRequest](#T-EasyITCenter-Controllers-GithubDownloadRequest 'EasyITCenter.Controllers.GithubDownloadRequest') |  |

<a name='M-EasyITCenter-Controllers-GithubService-DownloadGitRepo-EasyITCenter-Controllers-GithubDownloadRequest-'></a>
### DownloadGitRepo(repoUrl) `method`

##### Summary

Download Full GitHub Repository For Developing

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repoUrl | [EasyITCenter.Controllers.GithubDownloadRequest](#T-EasyITCenter-Controllers-GithubDownloadRequest 'EasyITCenter.Controllers.GithubDownloadRequest') |  |

<a name='M-EasyITCenter-Controllers-GithubService-GetGitHubReposList-EasyITCenter-Controllers-GithubSearchRequest-'></a>
### GetGitHubReposList(searchRequest) `method`

##### Summary

Search in GitHub Repos By Value and Language

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchRequest | [EasyITCenter.Controllers.GithubSearchRequest](#T-EasyITCenter-Controllers-GithubSearchRequest 'EasyITCenter.Controllers.GithubSearchRequest') |  |

<a name='T-EasyITCenter-Controllers-HandleBarsService'></a>
## HandleBarsService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-HandleBarsService-GetTemplateCode-EasyITCenter-Controllers-DataToTemplateRequest-'></a>
### GetTemplateCode(codegenRequest) `method`

##### Summary

Generate HTML code from Template and JSON Data set,

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| codegenRequest | [EasyITCenter.Controllers.DataToTemplateRequest](#T-EasyITCenter-Controllers-DataToTemplateRequest 'EasyITCenter.Controllers.DataToTemplateRequest') |  |

<a name='T-EasyITCenter-Services-HealthCheckActionService'></a>
## HealthCheckActionService `type`

##### Namespace

EasyITCenter.Services

##### Summary

HeathCheck Handler For Sending Information About Fails

<a name='M-EasyITCenter-Services-HealthCheckActionService-PublishAsync-Microsoft-Extensions-Diagnostics-HealthChecks-HealthReport,System-Threading-CancellationToken-'></a>
### PublishAsync(report,cancellationToken) `method`

##### Summary

Heath Check Action Service FOR Bad Statuses of Control Result

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| report | [Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport](#T-Microsoft-Extensions-Diagnostics-HealthChecks-HealthReport 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthReport') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='T-EasyITCenter-ServerCoreServers-HostedFtpServer'></a>
## HostedFtpServer `type`

##### Namespace

EasyITCenter.ServerCoreServers

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServer-#ctor-FubarDev-FtpServer-IFtpServerHost-'></a>
### #ctor(ftpServerHost) `constructor`

##### Summary

Initializes a new instance of the [HostedFtpServer](#T-EasyITCenter-ServerCoreServers-HostedFtpServer 'EasyITCenter.ServerCoreServers.HostedFtpServer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ftpServerHost | [FubarDev.FtpServer.IFtpServerHost](#T-FubarDev-FtpServer-IFtpServerHost 'FubarDev.FtpServer.IFtpServerHost') | The FTP server host that gets wrapped as a hosted service. |

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServer-StartAsync-System-Threading-CancellationToken-'></a>
### StartAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServer-StopAsync-System-Threading-CancellationToken-'></a>
### StopAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider'></a>
## HostedFtpServerMembershipProvider `type`

##### Namespace

EasyITCenter.ServerCoreServers

##### Summary

Custom membership provider for Authentication Validation Actual is Set by UserName and
Password in Database

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUser-System-String,System-String-'></a>
### ValidateUser(username,password) `method`

##### Summary

FTP User Validation Its for Open FTP and User Validation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='M-EasyITCenter-ServerCoreServers-HostedFtpServerMembershipProvider-ValidateUserAsync-System-String,System-String-'></a>
### ValidateUserAsync(username,password) `method`

##### Summary

FTP User Validation Async Its for Open FTP and User Validation

##### Returns

The result of the validation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user name. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password. |

<a name='T-EasyITCenter-ServerCoreStructure-HtttpContextExtension'></a>
## HtttpContextExtension `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Server Communication Extensions for Controlling Data Implmented FullUserTokenData For More
Info Modify Auth Claims And Add Get Info Here

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserEmail'></a>
### GetUserEmail() `method`

##### Summary

Get User Email

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserId'></a>
### GetUserId() `method`

##### Summary

Get UserId

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserName'></a>
### GetUserName() `method`

##### Summary

Get UserName

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-GetUserRole'></a>
### GetUserRole() `method`

##### Summary

Get UserRole

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsAdmin'></a>
### IsAdmin() `method`

##### Summary

Extension for check Admin Role

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsLogged'></a>
### IsLogged() `method`

##### Summary

Check HTTP if is the Request is Logged

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsServerRequest'></a>
### IsServerRequest() `method`

##### Summary

Extension for Request IP Address
Used by Data Areas Security

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsSystemUser'></a>
### IsSystemUser() `method`

##### Summary

Extension for check user Role

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsWebAdmin'></a>
### IsWebAdmin() `method`

##### Summary

Extension for check webAdmin Role

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-HtttpContextExtension-IsWebUser'></a>
### IsWebUser() `method`

##### Summary

Extension for check webUser Role

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Services-IServerCycleTaskService'></a>
## IServerCycleTaskService `type`

##### Namespace

EasyITCenter.Services

##### Summary

Hosted Service Interface defintion

<a name='T-EasyITCenter-ServerCoreStructure-JsonArray'></a>
## JsonArray `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Represents the json array.

<a name='M-EasyITCenter-ServerCoreStructure-JsonArray-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [JsonArray](#T-EasyITCenter-ServerCoreStructure-JsonArray 'EasyITCenter.ServerCoreStructure.JsonArray') class.

##### Parameters

This constructor has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonArray-#ctor-System-Int32-'></a>
### #ctor(capacity) `constructor`

##### Summary

Initializes a new instance of the [JsonArray](#T-EasyITCenter-ServerCoreStructure-JsonArray 'EasyITCenter.ServerCoreStructure.JsonArray') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| capacity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The capacity of the json array. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonArray-ToString'></a>
### ToString() `method`

##### Summary

The json representation of the array.

##### Returns

The json representation of the array.

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Controllers-JsonGeneratorService'></a>
## JsonGeneratorService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyGuestMDFiles'></a>
### GetFancyGuestMDFiles() `method`

##### Summary

Get Guest Md Files

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyTreeCodeLibrary'></a>
### GetFancyTreeCodeLibrary() `method`

##### Summary

FancyTree Code Library Browser Data

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyTreeJsonData-EasyITCenter-Controllers-FancyTreeJsonDataRequest-'></a>
### GetFancyTreeJsonData(jsonDataRequest) `method`

##### Summary

Must set path with path\\path or path/path
FileMask *.*, *.html, index.html

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonDataRequest | [EasyITCenter.Controllers.FancyTreeJsonDataRequest](#T-EasyITCenter-Controllers-FancyTreeJsonDataRequest 'EasyITCenter.Controllers.FancyTreeJsonDataRequest') |  |

<a name='M-EasyITCenter-Controllers-JsonGeneratorService-GetFancyUserMDFiles'></a>
### GetFancyUserMDFiles() `method`

##### Summary

Get User Md Files

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-JsonObject'></a>
## JsonObject `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Represents the json object.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of [JsonObject](#T-EasyITCenter-ServerCoreStructure-JsonObject 'EasyITCenter.ServerCoreStructure.JsonObject').

##### Parameters

This constructor has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-#ctor-System-Collections-Generic-IEqualityComparer{System-String}-'></a>
### #ctor(comparer) `constructor`

##### Summary

Initializes a new instance of [JsonObject](#T-EasyITCenter-ServerCoreStructure-JsonObject 'EasyITCenter.ServerCoreStructure.JsonObject').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comparer | [System.Collections.Generic.IEqualityComparer{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{System.String}') | The [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') implementation to use when comparing keys, or null to use the default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1') for the type of the key. |

<a name='F-EasyITCenter-ServerCoreStructure-JsonObject-_members'></a>
### _members `constants`

##### Summary

The internal member dictionary.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-Count'></a>
### Count `property`

##### Summary

Gets the count.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-IsReadOnly'></a>
### IsReadOnly `property`

##### Summary

Gets a value indicating whether this instance is read only.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets the [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') at the specified index.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-Item-System-String-'></a>
### Item `property`

##### Summary

Gets or sets the [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') with the specified key.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-Keys'></a>
### Keys `property`

##### Summary

Gets the keys.

<a name='P-EasyITCenter-ServerCoreStructure-JsonObject-Values'></a>
### Values `property`

##### Summary

Gets the values.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Add-System-String,System-Object-'></a>
### Add(key,value) `method`

##### Summary

Adds the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Add-System-Collections-Generic-KeyValuePair{System-String,System-Object}-'></a>
### Add(item) `method`

##### Summary

Adds the specified item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Collections.Generic.KeyValuePair{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair 'System.Collections.Generic.KeyValuePair{System.String,System.Object}') | The item. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Clear'></a>
### Clear() `method`

##### Summary

Clears this instance.

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Contains-System-Collections-Generic-KeyValuePair{System-String,System-Object}-'></a>
### Contains(item) `method`

##### Summary

Determines whether [contains] [the specified item].

##### Returns

`true` if [contains] [the specified item]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Collections.Generic.KeyValuePair{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair 'System.Collections.Generic.KeyValuePair{System.String,System.Object}') | The item. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-ContainsKey-System-String-'></a>
### ContainsKey(key) `method`

##### Summary

Determines whether the specified key contains key.

##### Returns

`true` if the specified key contains key; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-CopyTo-System-Collections-Generic-KeyValuePair{System-String,System-Object}[],System-Int32-'></a>
### CopyTo(array,arrayIndex) `method`

##### Summary

Copies to.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Collections.Generic.KeyValuePair{System.String,System.Object}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair 'System.Collections.Generic.KeyValuePair{System.String,System.Object}[]') | The array. |
| arrayIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Index of the array. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Gets the enumerator.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Remove-System-String-'></a>
### Remove(key) `method`

##### Summary

Removes the specified key.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-Remove-System-Collections-Generic-KeyValuePair{System-String,System-Object}-'></a>
### Remove(item) `method`

##### Summary

Removes the specified item.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Collections.Generic.KeyValuePair{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair 'System.Collections.Generic.KeyValuePair{System.String,System.Object}') | The item. |

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through a collection.

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') object that can be used to iterate through the collection.

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-ToString'></a>
### ToString() `method`

##### Summary

Returns a json [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the current [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').

##### Returns

A json [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the current [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreStructure-JsonObject-TryGetValue-System-String,System-Object@-'></a>
### TryGetValue(key,value) `method`

##### Summary

Tries the get value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key. |
| value | [System.Object@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object@ 'System.Object@') | The value. |

<a name='T-EasyITCenter-Controllers-MDDocBookGenerator'></a>
## MDDocBookGenerator `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Pathname of Request, UpdateOnly without

<a name='T-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-MDGeneratorCreateIndexRequest'></a>
## MDGeneratorCreateIndexRequest `type`

##### Namespace

EasyITCenter.Controllers.ServerApiGeneratorServerIndexService

##### Summary

WebFile Generators Request Dataset

<a name='T-EasyITCenter-MimeTypes'></a>
## MimeTypes `type`

##### Namespace

EasyITCenter

##### Summary

Provides utilities for mapping file names and extensions to MIME-types.

<a name='P-EasyITCenter-MimeTypes-FallbackMimeType'></a>
### FallbackMimeType `property`

##### Summary

The fallback MIME-type. Defaults to `application/octet-stream`.

<a name='M-EasyITCenter-MimeTypes-GetMimeType-System-String-'></a>
### GetMimeType(fileName) `method`

##### Summary

Gets the MIME-type for the given file name,
or [FallbackMimeType](#P-EasyITCenter-MimeTypes-FallbackMimeType 'EasyITCenter.MimeTypes.FallbackMimeType') if a mapping doesn't exist.

##### Returns

The MIME-type for the given file name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file. |

<a name='M-EasyITCenter-MimeTypes-GetMimeTypeExtensions-System-String-'></a>
### GetMimeTypeExtensions(mimeType) `method`

##### Summary

Attempts to fetch all available file extensions for a MIME-type.

##### Returns

All available extensions for the given MIME-type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mimeType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the MIME-type |

<a name='M-EasyITCenter-MimeTypes-TryGetMimeType-System-String,System-String@-'></a>
### TryGetMimeType(fileName,mimeType) `method`

##### Summary

Tries to get the MIME-type for the given file name.

##### Returns

`true` if a MIME-type was found, `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file. |
| mimeType | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | The MIME-type for the given file name. |

<a name='T-EasyITCenter-ServerCoreStructure-NetOperations'></a>
## NetOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Network Operations Library
Work With Files/Services From Url etc.

<a name='M-EasyITCenter-ServerCoreStructure-NetOperations-GetSoapDataFromURL-System-String,System-String,System-String-'></a>
### GetSoapDataFromURL() `method`

##### Summary

used Nuget: SoapHttpClient from https://github.com/pmorelli92/SoapHttpClient
nsUrl = ns definition URL, wsdlUrl = WSDL URL, operation = Operation Name from WSDL Definition
Example: GetSOAPData("http://webservice.riro.rinkai/","https://www.rinkai.eu/riro/WebService10Interface?wsdl","GetVersion10")

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-ProcessOperations'></a>
## ProcessOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Server Process Operations
PowerShell, System Commands, Scripts Processing
Used *.cmd, *.bat, *.ps1, *.sh 
Linux/Windows has same filename,
File Extension has Auto Change *.sh and *.cmd

<a name='M-EasyITCenter-ServerCoreStructure-ProcessOperations-RunPowerShellProcess-EasyITCenter-Controllers-RunProcessRequest-'></a>
### RunPowerShellProcess(script) `method`

##### Summary

https://stackoverflow.com/questions/2035193/how-to-run-a-powershell-script
PowerShell Script Runner

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| script | [EasyITCenter.Controllers.RunProcessRequest](#T-EasyITCenter-Controllers-RunProcessRequest 'EasyITCenter.Controllers.RunProcessRequest') |  |

<a name='M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessFinishedAsync-System-Object,System-EventArgs-'></a>
### ServerProcessFinishedAsync(sender,e) `method`

##### Summary

Server Process Manager Remove Finished Process

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessKill-System-Int32-'></a>
### ServerProcessKill(processName) `method`

##### Summary

Server Kill Running Process

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processName | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITCenter-ServerCoreStructure-ProcessOperations-ServerProcessStartAsync-EasyITCenter-Controllers-RunProcessRequest-'></a>
### ServerProcessStartAsync(processDefinition) `method`

##### Summary

https://stackoverflow.com/questions/2035193/how-to-run-a-powershell-script
SHELL FROM CMD:   Powershell.exe -File C:\Install\script.ps1

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processDefinition | [EasyITCenter.Controllers.RunProcessRequest](#T-EasyITCenter-Controllers-RunProcessRequest 'EasyITCenter.Controllers.RunProcessRequest') | The process definition. |

<a name='T-EasyITCenter-Controllers-ProcessService'></a>
## ProcessService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-ProcessService-StartProcessScript-EasyITCenter-Controllers-RunProcessRequest-'></a>
### StartProcessScript(processRequest) `method`

##### Summary

wwwroot is replaced with full path

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processRequest | [EasyITCenter.Controllers.RunProcessRequest](#T-EasyITCenter-Controllers-RunProcessRequest 'EasyITCenter.Controllers.RunProcessRequest') |  |

<a name='T-EasyITCenter-Controllers-RSSLoad'></a>
## RSSLoad `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-RSSLoad-GetRssFeed-System-String-'></a>
### GetRssFeed(rssUrl) `method`

##### Summary

Load RSS Feed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rssUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITCenter-DBModel-ResultMessage'></a>
## ResultMessage `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

The DB result message.

<a name='T-EasyITCenter-Controllers-RobotsController'></a>
## RobotsController `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

robots.txt routing

##### See Also

- [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller')

<a name='T-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory'></a>
## RootPerUserAccountDirectory `type`

##### Namespace

EasyITCenter.ServerCoreServers

<a name='M-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory-#ctor-Microsoft-Extensions-Options-IOptions{FubarDev-FtpServer-AccountManagement-Directories-RootPerUser-RootPerUserAccountDirectoryQueryOptions},Microsoft-Extensions-Logging-ILogger{EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory}-'></a>
### #ctor(options,logger) `constructor`

##### Summary

Initializes a new instance of the [RootPerUserAccountDirectoryQuery](#T-FubarDev-FtpServer-AccountManagement-Directories-RootPerUser-RootPerUserAccountDirectoryQuery 'FubarDev.FtpServer.AccountManagement.Directories.RootPerUser.RootPerUserAccountDirectoryQuery') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.Extensions.Options.IOptions{FubarDev.FtpServer.AccountManagement.Directories.RootPerUser.RootPerUserAccountDirectoryQueryOptions}](#T-Microsoft-Extensions-Options-IOptions{FubarDev-FtpServer-AccountManagement-Directories-RootPerUser-RootPerUserAccountDirectoryQueryOptions} 'Microsoft.Extensions.Options.IOptions{FubarDev.FtpServer.AccountManagement.Directories.RootPerUser.RootPerUserAccountDirectoryQueryOptions}') | The options. |
| logger | [Microsoft.Extensions.Logging.ILogger{EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory}](#T-Microsoft-Extensions-Logging-ILogger{EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory} 'Microsoft.Extensions.Logging.ILogger{EasyITCenter.ServerCoreServers.RootPerUserAccountDirectory}') | The logger. |

<a name='M-EasyITCenter-ServerCoreServers-RootPerUserAccountDirectory-GetDirectories-FubarDev-FtpServer-IAccountInformation-'></a>
### GetDirectories() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-RouteLayoutTypes'></a>
## RouteLayoutTypes `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Request Types For Selected correct Layout

<a name='T-EasyITCenter-ServerCoreStructure-RoutingActionTypes'></a>
## RoutingActionTypes `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Routing Command statuses for Control 
Routing and Layout Logic

<a name='T-EasyITCenter-Controllers-RssService'></a>
## RssService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Restart Api for Remote Control

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EasyITCenter-Controllers-RunProcessRequest'></a>
## RunProcessRequest `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Process class for running external prrocesses

<a name='T-EasyITCenter-Controllers-SendMailRequest'></a>
## SendMailRequest `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Class Definition for Server Emailer In List of this claas you can use Mass Emailer

<a name='T-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService'></a>
## ServerApiGeneratorServerIndexService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Index Files Generators

<a name='M-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-ConfigureHtmlInfoHeader-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-WebUrlRequest-'></a>
### ConfigureHtmlInfoHeader(request) `method`

##### Summary

Documentation https://ogp.me/
Tool For Extend Loaded Html By Add Custom Metadata by Format OpenGraph
TODO Implement Inserting Metadata or How To Use
Its Description Content as Metadata for Facebokk etc

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [EasyITCenter.Controllers.ServerApiGeneratorServerIndexService.WebUrlRequest](#T-EasyITCenter-Controllers-ServerApiGeneratorServerIndexService-WebUrlRequest 'EasyITCenter.Controllers.ServerApiGeneratorServerIndexService.WebUrlRequest') |  |

<a name='T-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices'></a>
## ServerConfigurationServices `type`

##### Namespace

EasyITCenter.ServerCoreConfiguration

##### Summary

Server Core Configuration Settings of Security, Communications, Technologies, Modules Rules,
Rights, Conditions, Formats, Services, Logging, etc..

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureAutoMinify-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureAutoMinify(services) `method`

##### Summary

Configure AutoMinify Js,Css

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureControllers-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureControllers(services) `method`

##### Summary

Server Core: Configure Server Controllers
options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = [ValidateNever]
in Class options.Serialize Settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
= [JsonIgnore] in Class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureCookie-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureCookie(services) `method`

##### Summary

Server Core: Configure Cookie Politics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDatabaseContext-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDatabaseContext(services) `method`

##### Summary

Server Core: Configure Custom Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureDefaultAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDefaultAuthentication(services) `method`

##### Summary

Server Core: Configure Server Authentication Support
Default Basic/JWT Authentication /Expiration BY 
Main EasyITCenter Database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureFTPServer-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureFTPServer(services) `method`

##### Summary

Custom Secure FTP Server

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLetsEncrypt-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLetsEncrypt(services) `method`

##### Summary

Server core: Configures LetsEncrypt using. Certificate will be saved in DataPath

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureLogging-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLogging(services) `method`

##### Summary

Server Core: Configure Server Logging

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureScoped-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureScoped(services) `method`

##### Summary

Server Core: Configure Custom Core Services

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerManagement-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureServerManagement(services) `method`

##### Summary

Server Core: Configure Hosted Service to Runtime Core For Access to Root Functionalities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureServerWebPages-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureServerWebPages(services) `method`

##### Summary

Configures the MVC server pages on Server format "cshtml"

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureSingletons-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureSingletons(services) `method`

##### Summary

Server Core: Configures the singletons. 
Its Register Custom Listeners For Actions

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureThirdPartyApi-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureThirdPartyApi(services) `method`

##### Summary

Server Core: Configure Clients for work with third party API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureTransient-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureTransient(services) `method`

##### Summary

Server Core: Configures the Transient.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureUserFluentEmailing-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureUserFluentEmailing(services) `method`

##### Summary

Server Portal Emailing with Template and History
https://github.com/lukencode/FluentEmail

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerConfigurationServices-ConfigureWebSocketLoggerMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureWebSocketLoggerMonitor(services) `method`

##### Summary

Server core: Configures the WebSocket logger monitor. 
For multi monitoring and for
Example Possibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='T-EasyITCenter-Services-ServerCoreAutoScheduler'></a>
## ServerCoreAutoScheduler `type`

##### Namespace

EasyITCenter.Services

##### Summary

Server AutoSchedule Planner

<a name='T-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi'></a>
## ServerCorePostFileRotatorApi `type`

##### Namespace

EasyITCenter.ControllersExtensions

##### Summary

Server Root Controller

<a name='M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-GetApiFileRotator-System-String-'></a>
### GetApiFileRotator(filename) `method`

##### Summary

WebApi ContentTool SubmitRotator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-PostApiFileRotator-System-Collections-Generic-List{Microsoft-AspNetCore-Http-IFormFile}-'></a>
### PostApiFileRotator() `method`

##### Summary

WebApi ConentTool WebBuilder File Responser

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ControllersExtensions-ServerCorePostFileRotatorApi-PutApiFileRotator-System-Collections-Generic-List{Microsoft-AspNetCore-Http-IFormFile}-'></a>
### PutApiFileRotator() `method`

##### Summary

WebApi ConentTool WebBuilder File Responser

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi'></a>
## ServerCoreWebToolsGenApi `type`

##### Namespace

EasyITCenter.ControllersExtensions

##### Summary

Server Root Controller

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateCarouselGallery-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateCarouselGallery(imageList) `method`

##### Summary

Image Carousel Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateCarouselVideoGallery-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateCarouselVideoGallery(videoList) `method`

##### Summary

Video Carousel Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| videoList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateEasyGallery-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateEasyGallery(imageList) `method`

##### Summary

Easy Image Gallery Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateImageBook-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateImageBook(imageList) `method`

##### Summary

ImageBook Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateMdToMdBook-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateMdToMdBook(fileList) `method`

##### Summary

MdToMdBook Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateMedialPresentation-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateMedialPresentation(imageList) `method`

##### Summary

MedialPresentation from Images Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateVideoPlayList-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateVideoPlayList(videoList) `method`

##### Summary

Video Player + PlayList Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| videoList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='M-EasyITCenter-ControllersExtensions-ServerCoreWebToolsGenApi-GenerateXmlToMd-EasyITCenter-WebClasses-UploadGeneratorFiles-'></a>
### GenerateXmlToMd(fileList) `method`

##### Summary

XmlToMD Generator

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileList | [EasyITCenter.WebClasses.UploadGeneratorFiles](#T-EasyITCenter-WebClasses-UploadGeneratorFiles 'EasyITCenter.WebClasses.UploadGeneratorFiles') | The image list. |

<a name='T-EasyITCenter-Services-ServerCycleTaskList'></a>
## ServerCycleTaskList `type`

##### Namespace

EasyITCenter.Services

##### Summary

HeathCheck Server Cycling Services 
Can be used for Auto Operations
Corrections/Processes/Update/Regenerate/Etc

<a name='T-EasyITCenter-Services-ServerCycleTaskListHealthCheck'></a>
## ServerCycleTaskListHealthCheck `type`

##### Namespace

EasyITCenter.Services

##### Summary

Registering to HeathCheck View

<a name='T-EasyITCenter-Services-ServerCycleTaskMiddleware'></a>
## ServerCycleTaskMiddleware `type`

##### Namespace

EasyITCenter.Services

##### Summary

ServerCycleTaskMiddleware Reference Definition

<a name='T-EasyITCenter-Services-ServerCycleTaskProcess'></a>
## ServerCycleTaskProcess `type`

##### Namespace

EasyITCenter.Services

##### Summary

Task Context Definition

<a name='T-EasyITCenter-Controllers-ServerDocApi'></a>
## ServerDocApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-ServerDocApi-GenerateMdBook'></a>
### GenerateMdBook() `method`

##### Summary

Server Inteligent Documentation Generator Api StratupPath is WebFolder On Development is
need WebRootPath WegbRootPath is Development Folder

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices'></a>
## ServerEnablingServices `type`

##### Namespace

EasyITCenter.ServerCoreConfiguration

##### Summary

Server Core Enabling Settings of Security, API Communications, Technologies, Modules,Rules,
Rights, Rules, Rights, Conditions, Cors, Cookies, Formats, Services, Logging, etc..

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableAutoMinify-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableAutoMinify(app) `method`

##### Summary

Enable Automatic Js,Css Minification

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableCors-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableCors() `method`

##### Summary

Server Cors Configuration

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableEndpoints-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableEndpoints() `method`

##### Summary

Server Endpoints Configuration

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableLogging-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableLogging() `method`

##### Summary

Enable Server Logging in Debug Mode

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerEnablingServices-EnableWebSocket-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableWebSocket(app) `method`

##### Summary

Server WebSocket Configuration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='T-EasyITCenter-ServerCoreStructure-ServerLocalDbDialsTypes'></a>
## ServerLocalDbDialsTypes `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Special Functions: Definition of Selected tables for Optimal Using to Data nature Its saves
traffic, increases availability and for Example implemented Language is in Develop Auto Fill
Table when is First Using Its can be used for more Dials

<a name='T-EasyITCenter-ServerCoreConfiguration-ServerModules'></a>
## ServerModules `type`

##### Namespace

EasyITCenter.ServerCoreConfiguration

##### Summary

Configure Server Ad-dons and Modules

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureDBEntitySchema-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDBEntitySchema(services) `method`

##### Summary

Module Entity Schema Design Generator

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureDocumentation-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureDocumentation(services) `method`

##### Summary

Server Module: Generated Developer Documentation for Developers Documentation contain
full Server Structure for extremely simple developing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureHealthCheck-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureHealthCheck(services) `method`

##### Summary

Server Module: Automatic DB Data Manager for work with data directly Extreme
Posibilities https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureLiveDataMonitor-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureLiveDataMonitor(services) `method`

##### Summary

Server Module: Generated Developer Documentation for Developers Documentation contain
full Server Structure for extremely simple developing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureMarkdownAsHtmlFiles-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureMarkdownAsHtmlFiles(services) `method`

##### Summary

Server Module: Configure Automatic MDtoHtml Files Show in WebPages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureReportDesigner-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureReportDesigner(services) `method`

##### Summary

Server Module: Configure Report Designer Module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureScheduler-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureScheduler(services) `method`

##### Summary

Server Module: Configures the Scheduler Module.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') | The services. |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModules-ConfigureSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection@-'></a>
### ConfigureSwagger(services) `method`

##### Summary

Server Module: Swagger Api Doc Generator And Online Tester Configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection@](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection@ 'Microsoft.Extensions.DependencyInjection.IServiceCollection@') |  |

<a name='T-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling'></a>
## ServerModulesEnabling `type`

##### Namespace

EasyITCenter.ServerCoreConfiguration

##### Summary

Enable Configured Server Ad-dons and Modules

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDBEntitySchema-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableDBEntitySchema() `method`

##### Summary

Server Module: Enable DBEntitySchema Web Page

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableDocumentation-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableDocumentation() `method`

##### Summary

Server Module: Enable Generated Developer Documentation

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableLiveDataMonitor-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableLiveDataMonitor() `method`

##### Summary

Server Module: Enable Live Data Monitor

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableMarkdownAsHtmlFiles-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableMarkdownAsHtmlFiles(app) `method`

##### Summary

Server Module: Enable Automatic MDtoHtml Files Show in WebPages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableReportDesigner-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableReportDesigner(app) `method`

##### Summary

Enable Report Designer Module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder@](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder@ 'Microsoft.AspNetCore.Builder.IApplicationBuilder@') |  |

<a name='M-EasyITCenter-ServerCoreConfiguration-ServerModulesEnabling-EnableSwagger-Microsoft-AspNetCore-Builder-IApplicationBuilder@-'></a>
### EnableSwagger() `method`

##### Summary

https://github.com/swagger-api/swagger-codegen
Server Module: Enable Swagger Api Doc Generator And Online Tester

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-ServerStatusTypes'></a>
## ServerStatusTypes `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Server and Hosted Services Runtime Statuses

<a name='T-EasyITCenter-WebClasses-ServerWebPagesToken'></a>
## ServerWebPagesToken `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Server WebPages Communication Token Definition for Security content And Load Allowed Content

<a name='T-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi'></a>
## ServerWebProviderGetOnlyApi `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Root Controller

<a name='M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetManagedCssJsScriptList'></a>
### GetManagedCssJsScriptList() `method`

##### Summary

Provider: For Show EASY Script Codes on WebPages

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetSolutionToolList'></a>
### GetSolutionToolList() `method`

##### Summary

Provider Its for Show Tools on WebPages

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-ServerWebProviderGetOnlyApi-GetTemplateWebMenuList'></a>
### GetTemplateWebMenuList() `method`

##### Summary

Provider: For Show EASY Menu Codes on WebPages

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Services-ServerWebSockeMonitorService'></a>
## ServerWebSockeMonitorService `type`

##### Namespace

EasyITCenter.Services

##### Summary

!!! Implemented Server Core WebSocket System LogProvider Stream This Is Special Serice For
Remote Monitoring On More Devices in OneTime

##### See Also

- [Microsoft.Extensions.Logging.ILoggerProvider](#T-Microsoft-Extensions-Logging-ILoggerProvider 'Microsoft.Extensions.Logging.ILoggerProvider')

<a name='T-EasyITCenter-DBModel-SetReportFilter'></a>
## SetReportFilter `type`

##### Namespace

EasyITCenter.DBModel

##### Summary

Database Model Extension Definitions Its API Filter, Extended Classes, Translation, etc

<a name='T-AutoResxTranslator-SimpleJson'></a>
## SimpleJson `type`

##### Namespace

AutoResxTranslator

##### Summary

This class encodes and decodes JSON strings.
Spec. details, see http://www.json.org/

JSON uses Arrays and Objects. These correspond here to the datatypes JsonArray(IList<object>) and JsonObject(IDictionary<string,object>).
All numbers are parsed to doubles.

<a name='M-AutoResxTranslator-SimpleJson-DeserializeObject-System-String-'></a>
### DeserializeObject(json) `method`

##### Summary

Parses the string json into a value

##### Returns

An IList<object>, a IDictionary<string,object>, a double, a string, null, true, or false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A JSON string. |

<a name='M-AutoResxTranslator-SimpleJson-IsNumeric-System-Object-'></a>
### IsNumeric() `method`

##### Summary

Determines if a given object is numeric in any way
(can be integer, double, null, etc).

##### Parameters

This method has no parameters.

<a name='M-AutoResxTranslator-SimpleJson-SerializeObject-System-Object,AutoResxTranslator-IJsonSerializerStrategy-'></a>
### SerializeObject(json,jsonSerializerStrategy) `method`

##### Summary

Converts a IDictionary<string,object> / IList<object> object into a JSON string

##### Returns

A JSON encoded string, or null if object 'json' is not serializable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | A IDictionary<string,object> / IList<object> |
| jsonSerializerStrategy | [AutoResxTranslator.IJsonSerializerStrategy](#T-AutoResxTranslator-IJsonSerializerStrategy 'AutoResxTranslator.IJsonSerializerStrategy') | Serializer strategy to use |

<a name='M-AutoResxTranslator-SimpleJson-TryDeserializeObject-System-String,System-Object@-'></a>
### TryDeserializeObject(json,obj) `method`

##### Summary

Try parsing the json string into a value.

##### Returns

Returns true if successfull otherwise false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A JSON string. |
| obj | [System.Object@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object@ 'System.Object@') | The object. |

<a name='T-EasyITCenter-Controllers-SitemapController'></a>
## SitemapController `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Sitemap.xml Routing

##### See Also

- [Microsoft.AspNetCore.Mvc.Controller](#T-Microsoft-AspNetCore-Mvc-Controller 'Microsoft.AspNetCore.Mvc.Controller')

<a name='M-EasyITCenter-Controllers-SitemapController-Index'></a>
### Index() `method`

##### Summary

SiteMap File Generator

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-SitemapController-WebDocPortals'></a>
### WebDocPortals() `method`

##### Summary

Web Portals

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-SitemapController-WebPortal'></a>
### WebPortal() `method`

##### Summary

Static Web Portal

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Controllers-SomeRSSProvider'></a>
## SomeRSSProvider `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

RSS Provider

<a name='T-EasyITCenter-ServerCoreStructure-CoreOperations-SrvOStype'></a>
## SrvOStype `type`

##### Namespace

EasyITCenter.ServerCoreStructure.CoreOperations

##### Summary

Extension For Checking Operation System of Server Running

<a name='T-EasyITCenter-ServerCoreStructure-SrvRuntime'></a>
## SrvRuntime `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

The server runtime data.

<a name='T-EasyITCenter-Startup'></a>
## Startup `type`

##### Namespace

EasyITCenter

##### Summary

Server Startup Definitions

<a name='M-EasyITCenter-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-Extensions-Hosting-IHostApplicationLifetime,Microsoft-AspNetCore-Mvc-Infrastructure-IActionDescriptorCollectionProvider-'></a>
### Configure(app,serverLifetime) `method`

##### Summary

Server Core: Main Enabling of Server Services, Technologies, Modules, etc..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| serverLifetime | [Microsoft.Extensions.Hosting.IHostApplicationLifetime](#T-Microsoft-Extensions-Hosting-IHostApplicationLifetime 'Microsoft.Extensions.Hosting.IHostApplicationLifetime') |  |

<a name='M-EasyITCenter-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(services) `method`

##### Summary

Server Core: Main Configure of Server Services, Technologies, Modules, etc..

##### Returns

void.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-EasyITCenter-Startup-ServerOnStarted'></a>
### ServerOnStarted() `method`

##### Summary

Server Core Enabling Disabling Hosted Services

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Controllers-StatusPageService'></a>
## StatusPageService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server Routing Rulles

<a name='M-EasyITCenter-Controllers-StatusPageService-Index'></a>
### Index() `method`

##### Summary

StartUp Web Redirection

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-StatusPageService-NonExistPage'></a>
### NonExistPage() `method`

##### Summary

TODO měli jste na mysli: seznam adres serveru - všech jsou zabezpečené

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-SupportGenFileTypes'></a>
## SupportGenFileTypes `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Supported Generating File Types Over Generators
Index Only Support All File Types You can

<a name='T-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi'></a>
## SystemBuilderOnlinePreviewApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderCodePreview-System-Int32-'></a>
### GetWebBuilderCodePreview() `method`

##### Summary

SYSTEM WebBuilder Code Library Preview Api

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderGlobalBodyBlockPreview-System-Int32-'></a>
### GetWebBuilderGlobalBodyBlockPreview(id) `method`

##### Summary

SYSTEM WebBUilder Global Page Body Block Preview API

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier. |

<a name='M-EasyITCenter-Controllers-SystemBuilderOnlinePreviewApi-GetWebBuilderMenuPreview-System-Int32-'></a>
### GetWebBuilderMenuPreview(id) `method`

##### Summary

SYSTEM WebBuilder Menu Preview Api

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier. |

<a name='T-ServerCorePages-SystemModulesModel'></a>
## SystemModulesModel `type`

##### Namespace

ServerCorePages

##### Summary

Default Page for Every Web Request Here are defined
Main Pages Sections THIs Page Is Alone For

<a name='M-ServerCorePages-SystemModulesModel-GetManagedCentralCssFiles'></a>
### GetManagedCentralCssFiles() `method`

##### Summary

Central CSS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedCentralCssLayoutFiles'></a>
### GetManagedCentralCssLayoutFiles() `method`

##### Summary

Central CSS Stylisation Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedCentralJsFiles'></a>
### GetManagedCentralJsFiles() `method`

##### Summary

Central JS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedCentralJsLayoutFiles'></a>
### GetManagedCentralJsLayoutFiles() `method`

##### Summary

Central JS Library Files Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedGlobalCssFiles'></a>
### GetManagedGlobalCssFiles() `method`

##### Summary

Global CSS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedGlobalCssLayoutFiles'></a>
### GetManagedGlobalCssLayoutFiles() `method`

##### Summary

Global CSS Stylisation Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedGlobalJsFiles'></a>
### GetManagedGlobalJsFiles() `method`

##### Summary

Global JS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedGlobalJsLayoutFiles'></a>
### GetManagedGlobalJsLayoutFiles() `method`

##### Summary

Global JS Library Files Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedMultiLangCssFiles'></a>
### GetManagedMultiLangCssFiles() `method`

##### Summary

MultiLang CSS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedMultiLangCssLayoutFiles'></a>
### GetManagedMultiLangCssLayoutFiles() `method`

##### Summary

MultiLang CSS Stylisation Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedMultiLangJsFiles'></a>
### GetManagedMultiLangJsFiles() `method`

##### Summary

MultiLang JS Library Files List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-GetManagedMultiLangJsLayoutFiles'></a>
### GetManagedMultiLangJsLayoutFiles() `method`

##### Summary

MultiLang JS Library Files Template Controler

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemModulesModel-OnGet'></a>
### OnGet() `method`

##### Summary

Checking Cookie TOKEN FROM Metro for User/UserRole checking on Server Side This Is Use
For User Checking In Razor/MVC Server Web Pages This is Use For User Role and his Rights
If is Logged Checking Has Loaded User Claims with Full Token Info

##### Parameters

This method has no parameters.

<a name='T-ServerCorePages-SystemPortalModel'></a>
## SystemPortalModel `type`

##### Namespace

ServerCorePages

##### Summary

Default Page for Every Web Request Here are defined
Main Pages Sections THIs Page Is Alone For

<a name='M-ServerCorePages-SystemPortalModel-GetManagedBodyPartForLayout'></a>
### GetManagedBodyPartForLayout() `method`

##### Summary

Get Allowed Global Body HTML Code Its HTML Content Computed by Guest/webuser/admin
Rights From DB Table WebGlobalBodyBlockList

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedCssFilesForLayout'></a>
### GetManagedCssFilesForLayout() `method`

##### Summary

Generation Css Script Section In Server Pages

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedFooterPartForLayout'></a>
### GetManagedFooterPartForLayout() `method`

##### Summary

Get Allowed Global Footer HTML Code Its HTML Content Computed by Guest/webuser/admin
Rights From DB Table WebGlobalBodyBlockList

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedHeaderPostScriptsForLayout'></a>
### GetManagedHeaderPostScriptsForLayout() `method`

##### Summary

Gets HeaderPostScripts the managed header pre CSS for layout.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedHeaderPreCssForLayout'></a>
### GetManagedHeaderPreCssForLayout() `method`

##### Summary

Gets HeaderPreCss the managed header pre CSS for layout.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedHeaderPreScriptsForLayout'></a>
### GetManagedHeaderPreScriptsForLayout() `method`

##### Summary

Gets HeaderPreCss the managed header pre CSS for layout.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-GetManagedJsFilesForLayout'></a>
### GetManagedJsFilesForLayout() `method`

##### Summary

Generation JS Script Section In Server Pages

##### Returns



##### Parameters

This method has no parameters.

<a name='M-ServerCorePages-SystemPortalModel-OnGet'></a>
### OnGet() `method`

##### Summary

Checking Cookie TOKEN FROM Metro for User/UserRole checking on Server Side This Is Use
For User Checking In Razor/MVC Server Web Pages This is Use For User Role and his Rights
If is Logged Checking Has Loaded User Claims with Full Token Info

##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-ServerCoreStructure-SystemPortalOperations'></a>
## SystemPortalOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

Server Web Helpers for EASY working Here are extension for Database Model, WebSocket

<a name='M-EasyITCenter-ServerCoreStructure-SystemPortalOperations-DeleteWebSourceFile-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@,EasyITCenter-DBModel-WebCoreFileList@-'></a>
### DeleteWebSourceFile(hostingEnvironment,record) `method`

##### Summary

Delete Managed Web Source Files from Dev and Startup Folders Delete Minified and Full Script

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment@](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@ 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment@') | The hosting environment. |
| record | [EasyITCenter.DBModel.WebCoreFileList@](#T-EasyITCenter-DBModel-WebCoreFileList@ 'EasyITCenter.DBModel.WebCoreFileList@') | The record. |

<a name='M-EasyITCenter-ServerCoreStructure-SystemPortalOperations-SaveWebSourceFile-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@,EasyITCenter-DBModel-WebCoreFileList@-'></a>
### SaveWebSourceFile(hostingEnvironment,record) `method`

##### Summary

Saving Modified Managed Web Source Files to Dev and Startup Folders Used For JS,CSS Files

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment@](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment@ 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment@') | The hosting environment. |
| record | [EasyITCenter.DBModel.WebCoreFileList@](#T-EasyITCenter-DBModel-WebCoreFileList@ 'EasyITCenter.DBModel.WebCoreFileList@') | The record. |

<a name='T-EasyITCenter-Controllers-SystemStdAuthGenericProviderApi`3'></a>
## SystemStdAuthGenericProviderApi\`3 `type`

##### Namespace

EasyITCenter.Controllers

##### Summary



##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EasyITCenter-Controllers-SystemStdFreeGenericProviderApi`3'></a>
## SystemStdFreeGenericProviderApi\`3 `type`

##### Namespace

EasyITCenter.Controllers

##### Summary



##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='T-EasyITCenter-WebClasses-UploadFileData'></a>
## UploadFileData `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Generator File Class structure

<a name='T-EasyITCenter-WebClasses-UploadGeneratorFiles'></a>
## UploadGeneratorFiles `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Generator Uploading files for Generators

<a name='T-EasyITCenter-WebClasses-UserConfig'></a>
## UserConfig `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Custom Class For UserConfig over Server Web Pages

<a name='T-EasyITCenter-ServerCoreStructure-UserStorageOperations'></a>
## UserStorageOperations `type`

##### Namespace

EasyITCenter.ServerCoreStructure

##### Summary

User Storage Operations

<a name='M-EasyITCenter-ServerCoreStructure-UserStorageOperations-CreateUserStorage-System-String-'></a>
### CreateUserStorage(username) `method`

##### Summary

Create User Storage Directory on Authenticated User Login

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-UserStorageOperations-GetUserDirectories-System-String,System-String-'></a>
### GetUserDirectories(userRootPath,path) `method`

##### Summary

Get User Storage Directories

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userRootPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-ServerCoreStructure-UserStorageOperations-GetUserFiles-System-String-'></a>
### GetUserFiles(path) `method`

##### Summary

Get User Storage Files

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITCenter-Controllers-UserStorageService'></a>
## UserStorageService `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-UserStorageService-ClearUserFolder-EasyITCenter-Controllers-UserStorageContent-'></a>
### ClearUserFolder(userStorageContent) `method`

##### Summary

Clear User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-CopyUserFile-EasyITCenter-Controllers-UserStorageRenameDir-'></a>
### CopyUserFile(userStorageRenameDir) `method`

##### Summary

Copy User Storage File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageRenameDir](#T-EasyITCenter-Controllers-UserStorageRenameDir 'EasyITCenter.Controllers.UserStorageRenameDir') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-CopyUserFolder-EasyITCenter-Controllers-UserStorageRenameDir-'></a>
### CopyUserFolder(userStorageRenameDir) `method`

##### Summary

Copy User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageRenameDir](#T-EasyITCenter-Controllers-UserStorageRenameDir 'EasyITCenter.Controllers.UserStorageRenameDir') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-CreateUserFile-EasyITCenter-Controllers-UserStorageContent-'></a>
### CreateUserFile(userStorageContent) `method`

##### Summary

Create User Storage File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-CreateUserFolder-EasyITCenter-Controllers-UserStorageContent-'></a>
### CreateUserFolder(userStorageContent) `method`

##### Summary

Create User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-DeleteUserFile-EasyITCenter-Controllers-UserStorageContent-'></a>
### DeleteUserFile(userStorageContent) `method`

##### Summary

Delete User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-DeleteUserFolder-EasyITCenter-Controllers-UserStorageContent-'></a>
### DeleteUserFolder(userStorageContent) `method`

##### Summary

Delete User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-DownloadUserFile-EasyITCenter-Controllers-UserStorageContent-'></a>
### DownloadUserFile(userStorageRenameDir) `method`

##### Summary

Download User Storage File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-DownloadUserFolder-EasyITCenter-Controllers-UserStorageContent-'></a>
### DownloadUserFolder(userStorageRenameDir) `method`

##### Summary

Download User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-GetSunImageList'></a>
### GetSunImageList() `method`

##### Summary

User Storage SUNEditor Galery List

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-UserStorageService-GetUserStorage'></a>
### GetUserStorage() `method`

##### Summary

Get User Storage Structure

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-UserStorageService-MoveUserFile-EasyITCenter-Controllers-UserStorageRenameDir-'></a>
### MoveUserFile(userStorageRenameDir) `method`

##### Summary

Rename User Storage File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageRenameDir](#T-EasyITCenter-Controllers-UserStorageRenameDir 'EasyITCenter.Controllers.UserStorageRenameDir') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-MoveUserFolder-EasyITCenter-Controllers-UserStorageRenameDir-'></a>
### MoveUserFolder(userStorageRenameDir) `method`

##### Summary

Rename User Storage Folder

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageRenameDir | [EasyITCenter.Controllers.UserStorageRenameDir](#T-EasyITCenter-Controllers-UserStorageRenameDir 'EasyITCenter.Controllers.UserStorageRenameDir') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-SetUserTextFile-EasyITCenter-Controllers-UserStorageContent-'></a>
### SetUserTextFile(userStorageContent) `method`

##### Summary

Save User Storage File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='M-EasyITCenter-Controllers-UserStorageService-UploadUserFiles-EasyITCenter-Controllers-UserStorageContent-'></a>
### UploadUserFiles(userStorageContent) `method`

##### Summary

Upload User Storage Files

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userStorageContent | [EasyITCenter.Controllers.UserStorageContent](#T-EasyITCenter-Controllers-UserStorageContent 'EasyITCenter.Controllers.UserStorageContent') |  |

<a name='T-ServerCorePages-ViewerReportFileModel'></a>
## ViewerReportFileModel `type`

##### Namespace

ServerCorePages

##### Summary

Fast Report Webový Prohlížeč Reportů 
V případě že je zadána Cesta nástroje Zobrazí Ukázky
Cesta Nástroje: /ServerCoreTools/ViewerReportFile

<a name='T-EasyITCenter-Controllers-WebGlobalMessageModuleApi'></a>
## WebGlobalMessageModuleApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-WebGlobalMessageModuleApi-SaveNewsletterPreview-System-Object-'></a>
### SaveNewsletterPreview() `method`

##### Summary

Message Module NewsLetter Preview API
Saving To index.html

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-WebClasses-WebMessage'></a>
## WebMessage `type`

##### Namespace

EasyITCenter.WebClasses

##### Summary

Custom WebMessage Class For Server Web Pages

<a name='T-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi'></a>
## WebPagesAdminGroupMenuListApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi-DeleteWebGroupMenuList-System-String-'></a>
### DeleteWebGroupMenuList(id) `method`

##### Summary

WebAdmin API

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier. |

<a name='M-EasyITCenter-Controllers-WebPagesAdminGroupMenuListApi-InsertOrUpdateGroupWebMenuList-EasyITCenter-WebClasses-WebSettingList1-'></a>
### InsertOrUpdateGroupWebMenuList(record) `method`

##### Summary

WebAdmin API

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [EasyITCenter.WebClasses.WebSettingList1](#T-EasyITCenter-WebClasses-WebSettingList1 'EasyITCenter.WebClasses.WebSettingList1') | The record. |

<a name='T-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi'></a>
## WebPagesSystemDataGetOnlyApi `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

Server WebPages Controller

<a name='M-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi-GetDeveloperNewsList'></a>
### GetDeveloperNewsList(rec) `method`

##### Summary

Web Developer News Info Api

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rec | [M:EasyITCenter.Controllers.WebPagesSystemDataGetOnlyApi.GetDeveloperNewsList](#T-M-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi-GetDeveloperNewsList 'M:EasyITCenter.Controllers.WebPagesSystemDataGetOnlyApi.GetDeveloperNewsList') | The record. |

<a name='M-EasyITCenter-Controllers-WebPagesSystemDataGetOnlyApi-GetMottoList'></a>
### GetMottoList() `method`

##### Summary

MottoList API for Web Portal

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITCenter-Controllers-WebPagesSystemToolsApi'></a>
## WebPagesSystemToolsApi `type`

##### Namespace

EasyITCenter.Controllers

<a name='M-EasyITCenter-Controllers-WebPagesSystemToolsApi-SaveNewMinifiedFile-EasyITCenter-Controllers-MinifiedFile-'></a>
### SaveNewMinifiedFile(rec) `method`

##### Summary

Saving Minified File API Allowed Only In Savig Time Api 
Is Hidden Its Called Back From external minifier Tool

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rec | [EasyITCenter.Controllers.MinifiedFile](#T-EasyITCenter-Controllers-MinifiedFile 'EasyITCenter.Controllers.MinifiedFile') | The record. |

<a name='T-EasyITCenter-Managers-WebSocketLocation'></a>
## WebSocketLocation `type`

##### Namespace

EasyITCenter.Managers

##### Summary

WebSocket Extension Definition For Simple Central Control All Connection By Connection Path
and Timeout

<a name='T-EasyITCenter-Services-WebSocketLogger'></a>
## WebSocketLogger `type`

##### Namespace

EasyITCenter.Services

##### Summary

Server Core WebSocket System Logger Interface

##### See Also

- [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger')

<a name='M-EasyITCenter-Services-WebSocketLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}-'></a>
### Log\`\`1(logLevel,eventId,state,exception,formatter) `method`

##### Summary

Used to log the entry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [Microsoft.Extensions.Logging.LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') | An instance of [LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel'). |
| eventId | [Microsoft.Extensions.Logging.EventId](#T-Microsoft-Extensions-Logging-EventId 'Microsoft.Extensions.Logging.EventId') | The event's ID. An instance of [EventId](#T-Microsoft-Extensions-Logging-EventId 'Microsoft.Extensions.Logging.EventId'). |
| state | [\`\`0](#T-``0 '``0') | The event's state. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The event's exception. An instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |
| formatter | [System.Func{\`\`0,System.Exception,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Exception,System.String}') | A delegate that formats |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TState |  |

<a name='T-EasyITCenter-Managers-WebSocketManager'></a>
## WebSocketManager `type`

##### Namespace

EasyITCenter.Managers

##### Summary

Server Web Helpers for EASY working Here are extension for Database Model, WebSocket

<a name='M-EasyITCenter-Managers-WebSocketManager-AddSocketConnectionToCentralList-System-Net-WebSockets-WebSocket,System-String-'></a>
### AddSocketConnectionToCentralList(newWebSocket,socketAPIPath) `method`

##### Summary

Add WeSocket Connection To Central List

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newWebSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') | The new web socket. |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The socket path. |

<a name='M-EasyITCenter-Managers-WebSocketManager-DisposeSocketConnectionsWithTimeOut'></a>
### DisposeSocketConnectionsWithTimeOut() `method`

##### Summary

!! Global Method for Simple Using WebSockets WebSocket Disposed - Cleaning monitored
Sockets from Central List. Are Closed and Disposed Only with Timeout or with closed Connection

##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Managers-WebSocketManager-ListenClientWebSocketMessages-System-Net-WebSockets-WebSocket,System-String-'></a>
### ListenClientWebSocketMessages(webSocket,socketAPIPath) `method`

##### Summary

Register Listening Client WebSocket Communication Ist for Receive messages from Client

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') |  |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITCenter-Managers-WebSocketManager-SendMessageAndUpdateWebSocketsInSpecificPath-System-String,System-String-'></a>
### SendMessageAndUpdateWebSocketsInSpecificPath(socketAPIPath,message) `method`

##### Summary

Sends the message and update web sockets in specific path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| socketAPIPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The socket API path. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-EasyITCenter-Managers-WebSocketManager-SendMessageToClientSocket-System-Net-WebSockets-WebSocket,System-String-'></a>
### SendMessageToClientSocket(webSocket,message) `method`

##### Summary

Sends the message to client WebSocket. This Is Used by
"SendMessageAndUpdateWebSocketsInSpecificPath" For Update Information on All Connections
in Same WebSocket Path Its Solution FOR Terminals, Group Communications, etc.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webSocket | [System.Net.WebSockets.WebSocket](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.WebSockets.WebSocket 'System.Net.WebSockets.WebSocket') | The web socket. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='T-EasyITCenter-Controllers-WebSocketService'></a>
## WebSocketService `type`

##### Namespace

EasyITCenter.Controllers

##### Summary

WEBSocket Template still not used Ideal for Terminal Panels, chat, controlling services

<a name='M-EasyITCenter-Controllers-WebSocketService-Get'></a>
### Get() `method`

##### Summary

WebSocket Registration Connection API Example

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITCenter-Controllers-WebSocketService-GetBySocketAPIPath-System-String-'></a>
### GetBySocketAPIPath(id) `method`

##### Summary

Universal WebSocket API Definitions for Connection Paths and Registering To Server
Central List ow WebSocket Connections

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
