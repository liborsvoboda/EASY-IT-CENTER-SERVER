﻿using ColorCode.Compilation.Languages;
using DocumentFormat.OpenXml.ExtendedProperties;
using EasyITCenter.DBModel;
using IdentityModel.OidcClient;
using System.Data;

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// All Server Definitions of Database Operation method
    /// </summary>
    public class DbOperations {


        #region Definition for Startup And Reload Tables

        /// <summary>
        /// Method for All Server Defined Table for Local Using As Off line AutoUpdated Tables
        /// </summary>
        /// <param name="onlyThis"></param>
        public static void LoadOrRefreshStaticDbDials(ServerLocalDbDialsTypes? onlyThis = null) {
            if (SrvConfig.ServiceUseDbLocalAutoupdatedDials) {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted })) {
                    foreach (ServerLocalDbDialsTypes dbTable in (ServerLocalDbDialsTypes[])Enum.GetValues(typeof(ServerLocalDbDialsTypes))) {
                        switch (onlyThis != null ? onlyThis.ToString() : dbTable.ToString()) {
                            case "SystemTranslationLists":
                                List<SystemTranslationList>? stlDataLL = new EasyITCenterContext().SystemTranslationLists.ToList();
                                int stlIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == stlDataLL.GetType());
                                if (stlIndexLL >= 0) SrvRuntime.LocalDBTableList[stlIndexLL] = stlDataLL; else SrvRuntime.LocalDBTableList.Add(stlDataLL);
                                break;
                            case "ServerModuleAndServiceLists":
                                List<ServerModuleAndServiceList>? smlDataLL = new EasyITCenterContext().ServerModuleAndServiceLists.ToList();
                                int smlIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == smlDataLL.GetType());
                                if (smlIndexLL >= 0) SrvRuntime.LocalDBTableList[smlIndexLL] = smlDataLL; else SrvRuntime.LocalDBTableList.Add(smlDataLL);
                                break;
                            case "WebCoreFileLists":
                                List<WebCoreFileList>? wcDataLL = new EasyITCenterContext().WebCoreFileLists.ToList();
                                int wcIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == wcDataLL.GetType());
                                if (wcIndexLL >= 0) SrvRuntime.LocalDBTableList[wcIndexLL] = wcDataLL; else SrvRuntime.LocalDBTableList.Add(wcDataLL);
                                break;
                            case "WebGlobalPageBlockLists":
                                List<WebGlobalPageBlockList>? wgDataLL = new EasyITCenterContext().WebGlobalPageBlockLists.ToList();
                                int wgIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == wgDataLL.GetType());
                                if (wgIndexLL >= 0) SrvRuntime.LocalDBTableList[wgIndexLL] = wgDataLL; else SrvRuntime.LocalDBTableList.Add(wgDataLL);
                                break;
                            case "ServerStaticOrMvcDefPathLists":
                                List<ServerStaticOrMvcDefPathList>? ssmDataLL = new EasyITCenterContext().ServerStaticOrMvcDefPathLists.ToList();
                                int ssmIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == ssmDataLL.GetType());
                                if (ssmIndexLL >= 0) SrvRuntime.LocalDBTableList[ssmIndexLL] = ssmDataLL; else SrvRuntime.LocalDBTableList.Add(ssmDataLL);
                                break;
                            case "ServerApiSecurityLists":
                                List<ServerApiSecurityList>? sasDataLL = new EasyITCenterContext().ServerApiSecurityLists.ToList();
                                int sasIndexLL = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == sasDataLL.GetType());
                                if (sasIndexLL >= 0) SrvRuntime.LocalDBTableList[sasIndexLL] = sasDataLL; else SrvRuntime.LocalDBTableList.Add(sasDataLL);
                                break;

                            default: break;
                        }
                        if (onlyThis != null) break;
                    }
                }
            }
        }

        #endregion Definition for Startup And Reload Tables

        #region Public definitions for standard using

        /// <summary>
        /// Default Operation for Call Translation
        ///  Over Local Tables Functionality
        /// </summary>
        /// <param name="word">    </param>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string DBTranslate(string word, string? language = null) {
            if (string.IsNullOrEmpty(language)) { language = SrvConfig.ServiceServerLanguage; }
            return !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? DBTranslateOffline(word, language) : DBTranslateOnline(word, language);
        }


        /// <summary>
        /// Default Operation for Call CHEckModuleExist
        ///  Over Local Tables Functionality
        /// </summary>
        /// <param name="modulePath"></param>
        /// <returns></returns>
        public static ServerModuleAndServiceList? CheckDefinedWebPageExists(string modulePath) {
            return  !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? CheckDefinedWebPageOffline(modulePath) : CheckDefinedWebPageOnline(modulePath);
        }


        /// <summary>
        /// Default Operation For Set Ignoring App.Use Paths
        /// For MVC Tools, Static Webs And Content
        /// </summary>
        /// <param name="serverPath"></param>
        /// <returns></returns>
        public static List<ServerStaticOrMvcDefPathList>? CheckDBServerApiRule(string serverPath) {
            return !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? CheckDBServerApiRuleOffline(serverPath) : CheckDBServerApiRuleOnline(serverPath);
        }



        /// <summary>
        /// Default Operation For Working Wihth 
        /// Portal Scripts From Local Tables.
        /// </summary>
        /// <param name="specType"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<WebCoreFileList>? GetWebPortalJsCssScripts(string specType, string? fileName) {
            return !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? GetWebPortalJsCssScriptsOffline(specType, fileName) : GetWebPortalJsCssScriptsOnline(specType, fileName);
        }


        public static ServerApiSecurityList? GetServerApiSecurity(string apiPath) {
            return  !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? GetServerApiSecurityOffline(apiPath) : GetServerApiSecurityOnline(apiPath);
        }

        /// <summary>
        /// Default Operation For Generate Web Portal
        /// Over Local Tables Functionality
        /// </summary>
        /// <param name="pagePartType"></param>
        /// <returns></returns>
        public static List<WebGlobalPageBlockList>? GetWebGlobalPageBlockLists(string pagePartType) {
            return !SrvConfig.ServiceUseDbLocalAutoupdatedDials ? GetWebGlobalPageBlockListsOffline(pagePartType) : GetWebGlobalPageBlockListsOnline(pagePartType);
        }

        #endregion Public definitions for standard using

        #region Private or On-line/Off-line Definitions


        /// <summary>
        /// Get Standard Api Security Definition Offline Method
        /// </summary>
        /// <param name="modulePath"></param>
        /// <returns></returns>
        private static ServerApiSecurityList? GetServerApiSecurityOffline(string apiPath) {
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<ServerApiSecurityList>().GetType());

            return ((List<ServerApiSecurityList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.UrlSubPath?.ToLower() == apiPath.ToLower() && a.Active).FirstOrDefault();
        }

        /// <summary>
        /// Get Standard Api Security Definition Online Method
        /// </summary>
        /// <param name="modulePath"></param>
        /// <returns></returns>
        private static ServerApiSecurityList? GetServerApiSecurityOnline(string apiPath) {
            return new EasyITCenterContext().ServerApiSecurityLists.Where(a => a.UrlSubPath.ToLower() == apiPath.ToLower() && a.Active).FirstOrDefault();
        }


        /// <summary>
        /// Get WebGlobalPageBlockList Offline Method
        /// </summary>
        /// <param name="pagePartType"></param>
        /// <returns></returns>
        private static List<WebGlobalPageBlockList>? GetWebGlobalPageBlockListsOffline(string pagePartType) {
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<WebGlobalPageBlockList>().GetType());
            return ((List<WebGlobalPageBlockList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.Active && a.PagePartType.ToLower() == pagePartType.ToLower()).ToList();
        }



        /// <summary>
        ///  Get WebGlobalPageBlockList OnLine Method
        /// </summary>
        /// <param name="pagePartType"></param>
        /// <returns></returns>
        private static List<WebGlobalPageBlockList>? GetWebGlobalPageBlockListsOnline(string pagePartType) {
            return new EasyITCenterContext().WebGlobalPageBlockLists.Where(a => a.Active && a.PagePartType.ToLower() == pagePartType.ToLower()).ToList();
        }


        /// <summary>
        /// Default Operation For Working Wihth 
        /// Portal Scripts From Local Tables Offline
        /// </summary>
        /// <param name="specType"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static List<WebCoreFileList>? GetWebPortalJsCssScriptsOffline(string specType, string? fileName) {
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<WebCoreFileList>().GetType());

            if (fileName == null && specType.ToLower() == ".css") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.css") && a.Active).ToList();
            } else if(fileName == null && specType.ToLower() == ".js") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.js") && a.Active).ToList();
            } else if(specType.ToLower() == ".css") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.css") && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            } else if (specType.ToLower() == ".js") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.js") && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            } else if (specType.ToLower() == "cssfiles") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.SpecificationType.ToLower() == specType.ToLower() && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            } else if (specType.ToLower() == "jsfiles") {
                return ((List<WebCoreFileList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.SpecificationType.ToLower() == specType.ToLower() && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            }
            return new List<WebCoreFileList>();
        }




        /// <summary>
        /// Default Operation For Working Wihth 
        /// Portal Scripts From Local Tables. Online
        /// </summary>
        /// <param name="specType"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static List<WebCoreFileList>? GetWebPortalJsCssScriptsOnline(string specType, string? fileName) {
            if (fileName == null && specType.ToLower() == ".css") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.css") && a.Active).ToList();
            }
            else if (fileName == null && specType.ToLower() == ".js") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.js") && a.Active).ToList();
            }
            else if (specType.ToLower() == ".css") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.css") && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            }
            else if (specType.ToLower() == ".js") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => (a.SpecificationType.ToLower() == specType.ToLower() || a.SpecificationType.ToLower() == ".min.js") && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            }
            else if (specType.ToLower() == "cssfiles") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => a.SpecificationType.ToLower() == specType.ToLower() && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            }
            else if (specType.ToLower() == "jsfiles") {
                return new EasyITCenterContext().WebCoreFileLists.Where(a => a.SpecificationType.ToLower() == specType.ToLower() && a.FileName.StartsWith(fileName.ToLower()) && a.Active).ToList();
            }
            return new List<WebCoreFileList>();
        }


        /// <summary>
        /// Get Check ServerModule from OneTime Load Server List
        /// </summary>
        /// <param name="modulePath"></param>
        /// <returns></returns>
        private static ServerModuleAndServiceList? CheckDefinedWebPageOffline(string modulePath) {
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<ServerModuleAndServiceList>().GetType());

            return ((List<ServerModuleAndServiceList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.UrlSubPath?.ToLower() == modulePath.ToLower() && a.Active).FirstOrDefault();
        }



        /// <summary>
        /// Get Check ServerModule from DB 
        /// </summary>
        /// <param name="modulePath"></param>
        /// <returns></returns>
        private static ServerModuleAndServiceList? CheckDefinedWebPageOnline(string modulePath) {
            return new EasyITCenterContext().ServerModuleAndServiceLists.Where(a => a.UrlSubPath.ToLower() == modulePath.ToLower() && a.Active).FirstOrDefault();
        }



        /// <summary>
        /// Get Ignored Static Web Or MVC Too Path In App.Use
        /// For Continue Loading of Defined Layout or Static Web
        /// Offline LocalDB Operation
        /// </summary>
        /// <param name="serverPath"></param>
        /// <returns></returns>
        private static List<ServerStaticOrMvcDefPathList>? CheckDBServerApiRuleOffline(string serverPath) {
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<ServerStaticOrMvcDefPathList>().GetType());
            serverPath = (serverPath.StartsWith("/") ? serverPath.Substring(1).ToLower() : serverPath.ToLower());

            return ((List<ServerStaticOrMvcDefPathList>)SrvRuntime.LocalDBTableList[index]).Where(a => serverPath.StartsWith(a.WebRootSubPath.ToLower()) && a.IsStaticOrMvcDefOnly && a.Active).ToList();
        }



        /// <summary>
        /// Get Ignored Static Web Or MVC Too Path In App.Use
        /// For Continue Loading of Defined Layout or Static Web
        /// Online LocalDB Operation
        /// </summary>
        /// <param name="serverPath"></param>
        /// <returns></returns>
        private static List<ServerStaticOrMvcDefPathList>? CheckDBServerApiRuleOnline(string serverPath) {
            serverPath = (serverPath.StartsWith("/") ? serverPath.Substring(1).ToLower() : serverPath.ToLower());
            return new EasyITCenterContext().ServerStaticOrMvcDefPathLists.Where(a => serverPath.StartsWith(a.WebRootSubPath.ToLower()) && a.IsStaticOrMvcDefOnly && a.Active).ToList();
        }



        /// <summary>
        /// Database LanuageList for Off-line Using Definitions
        /// </summary>
        /// <param name="word">    </param>
        /// <param name="language"></param>
        /// <returns></returns>
        private static string DBTranslateOffline(string word, string? language = null) {
            if (string.IsNullOrEmpty(language)) { language = SrvConfig.ServiceServerLanguage; }
            string result;
            int index = SrvRuntime.LocalDBTableList.FindIndex(a => a.GetType() == new List<SystemTranslationList>().GetType());

            //Check Exist AND Insert New
            try {
                if (!((List<SystemTranslationList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.SystemName.ToLower() == word.ToLower()).Any()) {
                    result = word;
                    //SystemTranslationList newWord = new() { SystemName = word, DescriptionCz = "", DescriptionEn = "", UserId = 1 };
                    //new EasyITCenterContext().SystemTranslationLists.Add(newWord).Context.SaveChanges();
                    LoadOrRefreshStaticDbDials(ServerLocalDbDialsTypes.SystemTranslationLists);
                    return result;
                }
            } catch { }

            //Return From List
            if (language == "cz") result = ((List<SystemTranslationList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.SystemName.ToLower() == word.ToLower()).Select(a => a.DescriptionCz).FirstOrDefault();
            else result = ((List<SystemTranslationList>)SrvRuntime.LocalDBTableList[index]).Where(a => a.SystemName.ToLower() == word.ToLower()).Select(a => a.DescriptionEn).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(result)) { result = word; }
            return result;
        }

        /// <summary>
        /// Database LanuageList for On-line Using Definitions
        /// </summary>
        /// <param name="word">    </param>
        /// <param name="language"></param>
        /// <returns></returns>
        private static string DBTranslateOnline(string word, string? language = null) {
            if (string.IsNullOrEmpty(language)) { language = SrvConfig.ServiceServerLanguage; }
            string result;

            //Check Exist AND Insert New
            try {
                if (!new EasyITCenterContext().SystemTranslationLists.Where(a => a.SystemName.ToLower() == word.ToLower()).Any()) {
                    result = word;
                    SystemTranslationList newWord = new() { SystemName = word, DescriptionCz = "", DescriptionEn = "", UserId = 1 };
                    new EasyITCenterContext().SystemTranslationLists.Add(newWord).Context.SaveChanges();
                    return result;
                }
            } catch { }

            //Return From List
            if (language == "cz") result = new EasyITCenterContext().SystemTranslationLists.Where(a => a.SystemName.ToLower() == word.ToLower()).Select(a => a.DescriptionCz).FirstOrDefault();
            else result = new EasyITCenterContext().SystemTranslationLists.Where(a => a.SystemName.ToLower() == word.ToLower()).Select(a => a.DescriptionEn).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(result)) { result = word; }
            return result;
        }

        #endregion Private or On-line/Off-line Definitions

    }
}