﻿# Úvod   EIC - Dokumentace Projektu  

EasyITcenter Universální řešení serverů IT světa v  1 Globálním Balíčku
Modulární Server s možností neomezeného a přesto extermně jednoduchého vývoje všemi směry
Ideální Centrální Správa sítí, strojů, IT a všeho co si dovedete prtředstavit.
Máte Otázky? neváhejte nám zavolat
Zde je Výčet Konfigurace serveru a popis co dané volby Dělají a znamenají. 
Když si je namalujete do pavouka zjistíte že to výkrývá téměř celé IT.

# Základní Konfigurace Serveru,   
		Zde je Aktuální základní konfigurace serveru.Jsou do ní vytažené jen ty nejstěžejnější   
nastavení, protože k dispozici sich je stonásobně víckrát. 
To Vyplývá z počtu přes 100 nasazených technologií v 1 řešení parfekně vyladěných pro dokonalou práci.

---   
# Config         
**ConfigTimeTokenValidationEnabled**
- Enable Disable Bearer Token Timeout Validation Token can be valid EveryTime to using:
 
   Example for machine connection Or is Control last activity
 
   **ConfigApiTokenTimeoutMin**
- Bearer Token Timeout Setting in Minutes. Connection must be Refreshed in Interval After
 
   Timeout connection Must Login Again. It is as needed. You Can Change Key for close All
 
   connections Immediately. Timeout is good for Webpages
 
   Recomended: 15
 
   **ConfigServerStartupOnHttps**
- Setting for Server URL Services. Logically can run only one Http or Https Server has
 
   more Security Setting Politics.
 
   Recommended: true
 
   **ConfigCertificateDomain**
- Its Domain for include to Automatic Generated Certificate For Server running on HTTPS.
 
   Domain is for Your validation Certificate Domain. Can be Changed for commercial.
 
   Domain is Used for Lets Encrypt also
 
   Write with Comma separator
 
   Recommended: 127.0.0.1
 
   **ConfigCertificatePassword**
- Password will be inserted to Server Generated Certificate for HTTPS.
 
   Recommended: empty = Maximal Security Randomly generated 20 chars string
 
   **ConfigServerStartupHttpPort**
- Set Server Startup  HTTP Port on Http/HttpS/WebSocket and for All Engines, Modules, API
 
   Controler and WebPages
 
   Recommended: 5000
 
   **ConfigJwtLocalKey**
- Special Functions:Server AutoGenerated encryption Key For Securing Communication On Each
 
   Server Restart All Tokens not will be valid and the Login Reconnect is Requested. Its
 
   AntiHacker Security Rule
 
   Recommended: empty = Maximal Security Randomly generated 40 chars string
 
   **ConfigCoreServerRegisteredName**
- Server Service Name automatic figured in All IS/OS/Engines info
 
   Recommended: EASY-IT-CENTER
 
   **ConfigServerGetLetsEncrypt**
- Setting for Automatic Obtain Lets Encrypt
 
   more Security Setting Politics.
 
   Recommended: true
 
   **ConfigCertificatePath**
- Certificate file NextFrom'DATA'Path\\Filename.pfx For import External Certificate
 
   Its Path from Data Startup Folder,example "groupware.pfx" is in Data Path
 
   The Password must be inserted in ConfigCertificatePassword Settings
 
   Other for ignore this Setting set empty string ""
 
   This settings has Higest Priority before LesEncrypt enabled
 
   **ConfigLogWarnPlusToDbEnabled**
- Enable Logging Server Warn and Errors To Database
 
   **ConfigManagerEmailAddress**
- Emailová adresa do obchodních kontaktů**ConfigServerStartupHTTPAndHTTPS**
- Startup Server On HTTP and HTTPS on Defined Port 
/// Aktivuje Provoz na protokolech HTTP i HTTPS současně, 
/// pro definici HTTP jej nastavte na zapnuto a dále dle nastaveni pro HTTPS**ConfigServerStartupHttpsPort**
- Set Server Startup  HTTPS Port on Http/HttpS/WebSocket and for All Engines, Modules, API
 
   Controler and WebPages
 
   Recommended: 5001
---   
# Database         
**DatabaseInternalCachingEnabled**
- Enable Disable Entity Framework Internal Cache I recommend turning it off : from Logic,
 
   Duplicit Functionality with Database Server in complex process can generate problems
 
   Recommended: false
 
   **DatabaseInternalCacheTimeoutMin**
- Time in Minutes for Database Valid Cache Data and Refreshing Duplicit Functionality with
 
   Database Server
 
   Recommended: 30
 
   
---   
# Emailer         
**EmailerSMTPSslIsEnabled**
- EmailerSMTPSslIsEnabled SSl Email Protocol for Login to External Mail Server Its
 
   Necessary for Correct running Server Internal Core Monitoring
 
   **EmailerServiceEmailAddress**
- Service email, for info about not available service from HeatchCheck Can be used for
 
   next Develop, automatic checking problems, missing data and all other Its Necessary for
 
   Correct running Server Internal Core Monitoring
 
   **EmailerSMTPServerAddress**
- SMTP Server Address for Login to External Mail Server Its Necessary for Correct running
 
   Server Internal Core Monitoring
 
   **EmailerSMTPPort**
- SMTP Port for Login to External Mail Server Its Necessary for Correct running Server
 
   Internal Core Monitoring
 
   **EmailerSMTPLoginUsername**
- SMTP UserName for Login to External Mail Server Its Necessary for Correct running Server
 
   Internal Core Monitoring
 
   **EmailerSMTPLoginPassword**
- SMTP Password for Login to External Mail Server Its Necessary for Correct running Server
 
   Internal Core Monitoring
 
   
---   
# Module         
**ModuleSwaggerApiDocEnabled**
- Special Function: Server Automatically Generate Full Documentation of API structure AND
 
   Database Model. Plus Included API Interface for Online Testing All API Methods with
 
   Authentication Its Automatic Solution for Third Party cooperation. All changes are
 
   Reflected after restart server
 
   **ModuleWebDataManagerEnabled**
- Module: AutoGenerated Database DataManager for working with Data Running only
 
   in Debug mode for simple Develop, can be modified. All changes are Reflected after
 
   restart server
 
   **ModuleHealthServiceEnabled**
- Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
 
   Over Net can Control Other Company Services Also as Central Control Point With Email
 
   Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
 
   Must be run for Metrics AddOn https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/monitor-app-health
 
   **ModuleHealthServiceRefreshIntervalSec**
- Special Function: More than 200 Server Statuses Can be monitored by HeathCheckService,
 
   Over Net can Control Other Company Services Also as Central Control Point With Email
 
   Service. For Example: Server/Memory/All DB Types/IP/HDD/Port/Api/NET/Cloud/Environment
 
   Must be run for Metrics AddOn !!! run in Release mode for Good Reading of Logs without
 
   HeathChecks Cycling info https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks https://testfully.io/blog/api-health-check-monitoring/
 
   **ModuleMdDocumentationEnabled**
- Enable Server Structure Documentation for Developers Using RootPath, - Block File
 
   Browsing Is Good for Server with Documentation only Or Use for Show WebPage and Copy
 
   "Only HTML"
 
   **ModuleDbDiagramGeneratorEnabled**
- Enable Automatic Database Diagram for Simple show Database structure with All bingings
 
   **EnableAutoShowStaticMdAsHtml**
- Zapíná Vypína Automatické zobrazení MD souboru ve Statickém úložišti jako HTML s URL bez ".md"**EnableCodeBrowser**
- Zapíná/Vypína Modul Procházení Kódů Projektů Online**ModuleDBEntitySchemaEnabled**
- Modul Zobrazení DB Entitity Schema**ModuleDBEntitySchemaPath**
- Cestana které se Schema Zobrazí, default: /DBEntitySchema**ModuleCSharpCodeBuilder**
- Zapnout Online Správu Projektu Serveru a vývoj**ModuleHealthServicePath**
- Api URL cesta Serveru na které 
 
   bude Dohledové centrum k dispozici**ModuleSwaggerApiDocPath**
- Api URL cesta Serveru na které 
 
   bude API Dokumentace a Testovací rozhraní  k dispozici**ModuleHealthServiceMessageOnChangeOnly**
- Zaznamenávat Logování/zaslání zprávy pouze při změně z OK->FAIL, jinak bude zaznamenáno v každém cyklu
---   
# Server         
**ServerProviderModeEnabled**
- Enabling Provider APIs 
 
   More Informations are Published on WepPages
 
   Are Published Core Informations With
 
   Full Solutions Info/Tools/Codes/Etc Published
 
   **ServerCorsEnabled**
- Server Filtrování Dle CORS Zapnuto**ServerCorsAllowAnyMethod**
- CORS Hlavičky HTTP Requestů příchozích na server WEB + API ,Povolit jakoukoliv Metodu**ServerCorsAllowAnyHeader**
- CORS Hlavičky HTTP Requestů příchozích na server WEB + API ,Povolit jakýkoliv Header**ServerCorsAllowCredentials**
- CORS Hlavičky HTTP Requestů příchozích na server WEB + API ,Povolit jakékoliv Pověření  - Autorizaci**ServerCorsAllowAnyOrigin**
- CORS Hlavičky HTTP Requestů příchozích
 
   na server WEB + API, 
 
   Povolit jakýkoli původ**ServerPublicUrl**
- Veřejná URL adresa serveru použita v modulech**BrowserLinkEnabled**
- Okamžitý Rerresh při vytvoření změn na Webu, Pomůcka vývoje, Pozor muze delat problemy Je jednoduchy neni staveny na robustni systemy**DefaultStaticWebFilesFolder**
- Root Složka pro Statické soubory Webu
---   
# Services         
**ServiceServerLanguage**
- Server Language for Translating Server internal statuses
 
   Recommended: cz or en - other languages are not implemented
 
   **ServiceEnableMassEmail**
- Zapíná/Vypína API pro Hromadné odesílání Emailů. Krásná Ukázka jak API může být Rozsáhlá serverová služba.**ServiceUseDbLocalAutoupdatedDials**
- Special Function: Using Selected Tables with AutoRefresh On change as Local DataSets,
 
   For Optimize Traffic. For Example LanguageList - Static table with often reading
 
   Recommended: true - functionality must be implemented in Server Code
 
   **ServiceCoreCheckerEmailSenderActive**
- Activation / Deactivation of Email Sender For Server Core Fails Checker All Catch Write
 
   to SendEmail, In Debug mode is Written in console in Release mode is Sended email (All
 
   incorrect server statuses are monitored) Can be writen to Database - !!! Warning for
 
   infinite Cycling (DB shutdown example)
 
   Recommended: true
 
   
---   
# SubServers         
**ServerFtpSecurityEnabled**
- Zapíná/Vypíná Poninost Přihlašování. Vypnuto = 1 úložiště cotevřené pro R/W anonymní přístup. Zapnuto znamená že každý uživatel má svoji složku a je povinost přihlášení.**ModuleAutoSchedulerEnabled**
- Server Scheduler Module for Automatization Tasks
 
   
 
   <value>
 
   The serve scheduler enabled.
 
   </value>**ServerFtpEngineEnabled**
- Enable FTP File Server oppened for every connection with full rights
 
   **ServerDocsOldAutoRemoveEnabled**
- Zapíná/Vypíná Automatické Odebírání Starých Verzí Dokumentace. Vztahuje se k Názvu, v Případě Změny Názvu je nutné Starou Verzi Odebrat manuálně**GitServerEnabled**
- Zapíná Vypíná privátní Git Server
---   
# Web         
**RedirectOnPageNotFound**
- Aktivuje Presmerovani na Zadanou cestu v případě Stránka nenalezena**RedirectPath**
- Cesta na kterou se přesměruje Webová Stránka v případě 404 stránka nenalezena. Je také nastavena jako Výchozí Stránka**WebRazorPagesCompileOnRuntime**
- Provádí kompilaci Za běhu Serveru. Tzn.. Podporuje Vkládání Stránek Externě **WebSitemapFileEnabled**
- Generovaný Soubor Sitemap z Menu Portálu **WebRobotTxtFileEnabled**
- zapnout zobrazení souboru Robot.txt  , obsah se bere z nastavení Portálu**WebRSSFeedsEnabled**
- Zapnout Generování RSS fédů; z položek, novinek**WebBrowserContentEnabled**
- Enable WebPages File Browsing from server Url on Server
 
   **WebRazorPagesEngineEnabled**
- Enable Razor WebPages support engine with Correct Configuration for Automaping from
 
   folder 'ServerCorePages'
 
   **WebMvcPagesEngineEnabled**
- Enable Mvc WebPages support engine with Correct Configuration
 
   **WebLiveDataMonitorEnabled**
- Enable Server Static Folder Monitor for Data Changes
 
   And immediatelly update all Api, Endpoints, Client Browser
 
   
---   
# WebSocket         
**WebSocketGlobalNotifyPath**
- WebPortal Global Notify Path on WebSocket for 
 
   sending messages from scheduler
 
   
 
   <value>
 
   The web global socket notify path.
 
   </value>**WebSocketServerMonitorEnabled**
- Server support online multi watch Logging
 
   Its Run on Websocket and the Log Messages are
 
   sent for All opened connections for wathing
 
   on Path: ServerCoreMonitor
 
   You can enable Mass Email Api
 
   **WebSocketEngineEnabled**
- Enable WebSocket Engine with Default Example Api Controller
 
   **WebSocketTimeoutMin**
- WebSocket Timeout Connection Settings in Minutes. After timeout when not detected any
 
   communication socket is closed Set according to your need
 
   Recommended: 2
 
   **WebSocketMaxBufferSizeKb**
- Určuje Maximální  velikost WebSocket zprávy