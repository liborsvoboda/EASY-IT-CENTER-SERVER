using CSJsonDB;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
using EasyITCenter.DBModel;
using Google.Protobuf.Compiler;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EasyITCenter.Controllers
{


    public partial class MenuData {
        public string ParentGuid { get; set; } = null;
        public string RecGuid { get; set; } = null;
        public int Sequence { get; set; }
        public string Name { get; set; } = null;
        public string Icon { get; set; } = null;
        public string InheritedMenuType { get; set; } = null;
        public string Description { get; set; } = null;
        public bool Active { get; set; } = true;
        public string HtmlContent { get; set; } = null;
        public string JsContent { get; set; } = null;
        public string CssContent { get; set; } = null;
        public string MdHelp { get; set; } = null;
    }

    public partial class UserSetting {
        public string RecGuid { get; set; } = null;
        public bool EnableAutoTranslate { get; set; }
        public bool EnableShowDescription { get; set; }
        public bool RememberLastJson { get; set; }
        public bool RememberLastHandleBar { get; set; }
        public bool EnableScreenSaver { get; set; }
    }

    public partial class QuestionRequest {
        public string RecGuid { get; set; } = null;
        public string MenuName { get; set; }
        public string Question { get; set; }
        public string Response { get; set; } = null;
    }

    public partial class EmailTemplateRequest {
        public string RecGuid { get; set; } = null;
        public string TemplateName { get; set; }
        public string HtmlContent { get; set; }
        public string JsonContent { get; set; }
        public string Description { get; set; }
    }


    public partial class AudioNotepadRequest
    {
        public string RecGuid { get; set; } = null;
        public string Subject { get; set; }
        public string HtmlContent { get; set; }
        public string Description { get; set; }
    }



    public partial class DataTableRequest
    {
        public string RecGuid { get; set; } = null;
        public string TableName { get; set; }
        public string ColumnsDef { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
    }



    public partial class ResponseRequest {
        public int Id { get; set; }
        public string Response { get; set; }
    }


    public class CodeGeneratorRequest {
        public string RecGuid { get; set; } = null;
        public string CodeName { get; set; }
        public string Description { get; set; }
        public string JsonContent { get; set; }
        public string CodeContent { get; set; }
        public string SubCodeContent { get; set; }
    }

    public class MediaPresentationListRequest {
        public string RecGuid { get; set; } = null;
        public string PresentationName { get; set; }
        public string Description { get; set; }
        public string DataContent { get; set; }
        public string Theme { get; set; }
    }

    [Route("PortalApiTableService")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetApiTableDataList/{tablename}")]
        public async Task<string> GetApiTableDataList(string tablename) {
            List<PortalApiTableColumnDataList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                    data = new EasyITCenterContext().PortalApiTableColumnDataLists
                        .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && a.Active == true)
                        .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                }
            } 
            catch (Exception ex) {  }
                return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetPortalMenuList")]
        public async Task<string> SetPortalMenuList([FromBody] MenuData menuData) {
            EasyITCenterContext data = new EasyITCenterContext();
            try {
                
                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    if (menuData.RecGuid == null) {
                        menuData.RecGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "MdHelp", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.MdHelp, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        List<PortalApiTableColumnDataList> original = new();
                        original = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.ApiTableName == "PortalMenu" && a.RecGuid == menuData.RecGuid).ToList();
                        
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "ParentGuid").Select(a=>a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Sequence").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Name").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Icon").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "InheritedMenuType").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "HtmlContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "JsContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "CSSContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "MdHelp").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "MdHelp", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.MdHelp, Description = null, Active = menuData.Active, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    }

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 8, ErrorMessage = menuData.RecGuid });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// Universal Delete from Virtual Table
        /// </summary>
        /// <param name="recGuid"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpDelete("/PortalApiTableService/DeleteApiTableColumnDataList/{recGuid}")]
        public async Task<string> DeleteApiTableColumnDataList(string recGuid) {
            EasyITCenterContext data = new EasyITCenterContext();
            try {
                if (!String.IsNullOrWhiteSpace(recGuid)) {
                    List<PortalApiTableColumnDataList> original = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.RecGuid == recGuid).ToList();
                    if (original.Any()) {
                        PortalApiTableList checkRight = new EasyITCenterContext().PortalApiTableLists.Where(a => a.Name == original.First().ApiTableName).FirstOrDefault();

                        if (checkRight?.InheritedTableType == "PublicTable") {
                            DatabaseContextExtensions.RunTransaction(data, (trans) => {
                                data.PortalApiTableColumnDataLists.RemoveRange(original);
                                data.SaveChanges();
                                return true;
                            });
                        } else if (checkRight?.InheritedTableType == "UserTable" && HtttpContextExtension.IsLogged()) {
                            DatabaseContextExtensions.RunTransaction(data, (trans) => {
                                data.PortalApiTableColumnDataLists.RemoveRange(original);
                                data.SaveChanges();
                                return true;
                            });
                        } else if (checkRight?.InheritedTableType == "AdminTable" && (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin())) {
                            DatabaseContextExtensions.RunTransaction(data, (trans) => {
                                data.PortalApiTableColumnDataLists.RemoveRange(original);
                                data.SaveChanges();
                                return true;
                            });
                        } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
                    } else { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); }
                }
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpDelete("/PortalApiTableService/DeleteApiTableList/{id}")]
        public async Task<string> DeleteApiTableList(int id) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList> apidata = new();
            try {

                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    PortalApiTableList original = new EasyITCenterContext().PortalApiTableLists.Where(a => a.Id == id).FirstOrDefault();
                    apidata = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.ApiTableName == original.Name).ToList();

                    if (apidata.Any()) {
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.RemoveRange(apidata);
                            data.SaveChanges();
                            return true;
                        });
                    }
                    
                    DatabaseContextExtensions.RunTransaction(data, (trans) => {
                        data.PortalApiTableLists.Remove(original);
                        data.SaveChanges();
                        return true;
                    });
            

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = apidata.Count(), ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.DeniedYouAreNotAdmin.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetUserSettingList")]
        public async Task<string> SetUserSettingList([FromBody] UserSetting userSetting) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList> original = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        original = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "UserSetting" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }

                    if (original.Count == 5) {//UPDATE only
                        original.ForEach(orig => {
                            switch (orig.ApiTableColumnName) {
                                case "EnableAutoTranslate":
                                    orig.Value = userSetting.EnableAutoTranslate.ToString();
                                    break;
                                case "EnableShowDescription":
                                    orig.Value = userSetting.EnableShowDescription.ToString();
                                    break;
                                case "RememberLastJson":
                                    orig.Value = userSetting.RememberLastJson.ToString();
                                    break;
                                case "RememberLastHandleBar":
                                    orig.Value = userSetting.RememberLastHandleBar.ToString();
                                    break;
                                case "EnableScreenSaver":
                                    orig.Value = userSetting.EnableScreenSaver.ToString();
                                    break;
                            }

                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });

                    } else if (original.Any()) {//MODIFY -added NEW
                        original = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.ApiTableName == "UserSetting" && a.UserId == (int)HtttpContextExtension.GetUserId()).ToList();
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.RemoveRange(original);
                            data.SaveChanges();
                            return true;
                        });

                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableAutoTranslate", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableAutoTranslate.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableShowDescription", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableShowDescription.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "RememberLastJson", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.RememberLastJson.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "RememberLastHandleBar", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.RememberLastHandleBar.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableScreenSaver", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableScreenSaver.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {//NEW
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableAutoTranslate", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableAutoTranslate.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableShowDescription", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableShowDescription.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "RememberLastJson", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.RememberLastJson.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "RememberLastHandleBar", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.RememberLastHandleBar.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "UserSetting", ApiTableColumnName = "EnableScreenSaver", InheritedDataType = "bit", RecGuid = recGuid, Value = userSetting.EnableScreenSaver.ToString(), Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    }


                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 5, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetUserSettingList")]
        public async Task<string> GetUserSettingList() {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "UserSetting" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetQuestionList")]
        public async Task<string> SetQuestionList([FromBody] QuestionRequest questionRequest) {
            EasyITCenterContext data = new EasyITCenterContext();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    string recGuid = Guid.NewGuid().ToString().ToUpper();
                    List<PortalApiTableColumnDataList> record = new();
                    record.Add(new PortalApiTableColumnDataList() { ApiTableName = "QuestionList", ApiTableColumnName = "MenuName", InheritedDataType = "string", RecGuid = recGuid, Value = questionRequest.MenuName, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                    record.Add(new() { ApiTableName = "QuestionList", ApiTableColumnName = "Question", InheritedDataType = "string", RecGuid = recGuid, Value = questionRequest.Question, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                    record.Add(new() { ApiTableName = "QuestionList", ApiTableColumnName = "Response", InheritedDataType = "string", RecGuid = recGuid, Value = null, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                    DatabaseContextExtensions.RunTransaction(data, (trans) => {
                        data.PortalApiTableColumnDataLists.AddRange(record);
                        data.SaveChanges();
                        return true;
                    });

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = recGuid });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetQuestionResponseList")]
        public async Task<string> SetQuestionResponseList([FromBody] ResponseRequest responseRequest) {
            PortalApiTableColumnDataList data = new();
            EasyITCenterContext dbContext = new EasyITCenterContext();
            try {
                if (HtttpContextExtension.IsAdmin() || HtttpContextExtension.IsWebAdmin()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "QuestionList" && a.Id == responseRequest.Id).FirstOrDefault();
                    }

                    if (data != null) {
                        data.Value = responseRequest.Response;
                        DatabaseContextExtensions.RunTransaction(dbContext, (trans) => {
                            dbContext.PortalApiTableColumnDataLists.Update(data);
                            dbContext.SaveChanges();
                            return true;
                        });

                        return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 1, ErrorMessage = data.RecGuid });
                    } else {
                        return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
        

        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetQuestionForResponseList")]
        public async Task<string> GetQuestionForResponseList() {
            List<PortalApiTableColumnDataList> data = new();
            List<PortalApiTableColumnDataList> result = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "QuestionList" && a.ApiTableColumnName == "Response" && a.Value == null)
                            .OrderBy(a => a.Id).ToList();
                    }
                    if (data.Any()) {
                        data.ForEach(dataRec => {
                            List<PortalApiTableColumnDataList>? response = new();
                            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                                response = new EasyITCenterContext().PortalApiTableColumnDataLists
                                    .Where(a => a.RecGuid == dataRec.RecGuid)
                                    .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                            }
                            result.AddRange(response);
                        });
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(result, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            return JsonSerializer.Serialize(result, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetMyQuestionList")]
        public async Task<string> GetMyQuestionList() {
            List<PortalApiTableColumnDataList> data = new();
            List<PortalApiTableColumnDataList> result = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "QuestionList" && a.ApiTableColumnName == "MenuName" && a.UserId == (int)HtttpContextExtension.GetUserId())
                            .OrderByDescending(a => a.TimeStamp).ToList();
                    }
                    if (data.Any()) {
                        data.ForEach(dataRec => {
                            List<PortalApiTableColumnDataList>? response = new();
                            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                                response = new EasyITCenterContext().PortalApiTableColumnDataLists
                                    .Where(a => a.RecGuid == dataRec.RecGuid)
                                    .OrderBy(a => a.Id).ToList();
                            }
                            result.AddRange(response);
                        });
                    }
                } else {
                        return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(result, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            return JsonSerializer.Serialize(result, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }



        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetEmailTemplate")]
        public async Task<string> SetEmailTemplate([FromBody] EmailTemplateRequest emailTemplateRequest) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList>? original = null;
            try {
                if (HtttpContextExtension.IsLogged()) {

                    if (string.IsNullOrWhiteSpace(emailTemplateRequest.RecGuid)) {
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "EmailTemplateList", ApiTableColumnName = "TemplateName", InheritedDataType = "string", RecGuid = recGuid, Value = emailTemplateRequest.TemplateName, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "EmailTemplateList", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = recGuid, Value = emailTemplateRequest.HtmlContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "EmailTemplateList", ApiTableColumnName = "JsonContent", InheritedDataType = "string", RecGuid = recGuid, Value = emailTemplateRequest.JsonContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "EmailTemplateList", ApiTableColumnName = "Description", InheritedDataType = "string", RecGuid = recGuid, Value = emailTemplateRequest.Description, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                            original = new EasyITCenterContext().PortalApiTableColumnDataLists
                                .Where(a => a.ApiTableName == "EmailTemplateList" && a.UserId == HtttpContextExtension.GetUserId() && a.RecGuid == emailTemplateRequest.RecGuid)
                                .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                        }

                        original.ForEach(origItem => {
                            if (origItem.ApiTableColumnName == "TemplateName") { origItem.Value = emailTemplateRequest.TemplateName; }
                            else if (origItem.ApiTableColumnName == "HtmlContent") { origItem.Value = emailTemplateRequest.HtmlContent; } 
                            else if (origItem.ApiTableColumnName == "JsonContent") { origItem.Value = emailTemplateRequest.JsonContent; } 
                            else if (origItem.ApiTableColumnName == "Description") { origItem.Value = emailTemplateRequest.Description; }
                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });
                    }

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }



        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetEmailTemplateList")]
        public async Task<string> GetEmailTemplateList()
        {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "EmailTemplateList" /*&& a.UserId == HtttpContextExtension.GetUserId()*/)
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }



        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetAudioNotepad")]
        public async Task<string> GetAudioNotepad() {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                    {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "AudioNotepad" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }



        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetAudioNotepad")]
        public async Task<string> SetAudioNotepad([FromBody] AudioNotepadRequest audioNotepadRequest) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList>? original = null;
            try {
                if (HtttpContextExtension.IsLogged()) {

                    if (string.IsNullOrWhiteSpace(audioNotepadRequest.RecGuid)) {
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "AudioNotepad", ApiTableColumnName = "Subject", InheritedDataType = "string", RecGuid = recGuid, Value = audioNotepadRequest.Subject, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "AudioNotepad", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = recGuid, Value = audioNotepadRequest.HtmlContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "AudioNotepad", ApiTableColumnName = "Description", InheritedDataType = "string", RecGuid = recGuid, Value = audioNotepadRequest.Description, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                        {
                            original = new EasyITCenterContext().PortalApiTableColumnDataLists
                                .Where(a => a.ApiTableName == "AudioNotepad" && a.UserId == HtttpContextExtension.GetUserId() && a.RecGuid == audioNotepadRequest.RecGuid)
                                .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                        }


                        original.ForEach(origItem => {
                            if (origItem.ApiTableColumnName == "Subject") { origItem.Value = audioNotepadRequest.Subject; }
                            else if (origItem.ApiTableColumnName == "HtmlContent") { origItem.Value = audioNotepadRequest.HtmlContent; }
                            else if (origItem.ApiTableColumnName == "Description") { origItem.Value = audioNotepadRequest.Description; }
                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });
                    }

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }



        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetDataTableList")]
        public async Task<string> GetDataTableList() {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "DataTableList" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            } return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }



        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetDataTableList")]
        public async Task<string> SetDataTableList([FromBody] DataTableRequest dataTableRequest) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList>? original = null;
            try {
                if (HtttpContextExtension.IsLogged()) {

                    if (string.IsNullOrWhiteSpace(dataTableRequest.RecGuid)) {
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "DataTableList", ApiTableColumnName = "TableName", InheritedDataType = "string", RecGuid = recGuid, Value = dataTableRequest.TableName, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "DataTableList", ApiTableColumnName = "ColumnsDef", InheritedDataType = "string", RecGuid = recGuid, Value = dataTableRequest.ColumnsDef, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "DataTableList", ApiTableColumnName = "Data", InheritedDataType = "string", RecGuid = recGuid, Value = dataTableRequest.Data, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "DataTableList", ApiTableColumnName = "Description", InheritedDataType = "string", RecGuid = recGuid, Value = dataTableRequest.Description, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                        {
                            original = new EasyITCenterContext().PortalApiTableColumnDataLists
                                .Where(a => a.ApiTableName == "DataTableList" && a.UserId == HtttpContextExtension.GetUserId() && a.RecGuid == dataTableRequest.RecGuid)
                                .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                        }


                        original.ForEach(origItem => {
                            if (origItem.ApiTableColumnName == "TableName") {  origItem.Value = dataTableRequest.TableName; }
                            else if (origItem.ApiTableColumnName == "ColumnsDef") {  origItem.Value = dataTableRequest.ColumnsDef; }
                            else if (origItem.ApiTableColumnName == "Data") {  origItem.Value = dataTableRequest.Data; }
                            else if (origItem.ApiTableColumnName == "Description") { origItem.Value = dataTableRequest.Description; }
                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });
                    }
                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }



        /// <summary>
        /// User Get Code Generator Data List
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetCodeGeneratorList")]
        public async Task<string> GetCodeGeneratorList() {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "CodeGeneratorList" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }



        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetCodeGeneratorList")]
        public async Task<string> SetCodeGeneratorList([FromBody] CodeGeneratorRequest codeGeneratorRequest) {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList>? original = null;
            try {
                if (HtttpContextExtension.IsLogged()) {

                    if (string.IsNullOrWhiteSpace(codeGeneratorRequest.RecGuid)) {
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "CodeGeneratorList", ApiTableColumnName = "CodeName", InheritedDataType = "string", RecGuid = recGuid, Value = codeGeneratorRequest.CodeName, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "CodeGeneratorList", ApiTableColumnName = "Description", InheritedDataType = "string", RecGuid = recGuid, Value = codeGeneratorRequest.Description, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "CodeGeneratorList", ApiTableColumnName = "JsonContent", InheritedDataType = "string", RecGuid = recGuid, Value = codeGeneratorRequest.JsonContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "CodeGeneratorList", ApiTableColumnName = "CodeContent", InheritedDataType = "string", RecGuid = recGuid, Value = codeGeneratorRequest.CodeContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "CodeGeneratorList", ApiTableColumnName = "SubCodeContent", InheritedDataType = "string", RecGuid = recGuid, Value = codeGeneratorRequest.SubCodeContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                            original = new EasyITCenterContext().PortalApiTableColumnDataLists
                                .Where(a => a.ApiTableName == "CodeGeneratorList" && a.UserId == HtttpContextExtension.GetUserId() && a.RecGuid == codeGeneratorRequest.RecGuid)
                                .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                        }


                        original.ForEach(origItem => {
                            if (origItem.ApiTableColumnName == "CodeName") { origItem.Value = codeGeneratorRequest.CodeName; } 
                            else if (origItem.ApiTableColumnName == "Description") { origItem.Value = codeGeneratorRequest.Description; } 
                            else if (origItem.ApiTableColumnName == "JsonContent") { origItem.Value = codeGeneratorRequest.JsonContent; } 
                            else if (origItem.ApiTableColumnName == "CodeContent") { origItem.Value = codeGeneratorRequest.CodeContent; } 
                            else if (origItem.ApiTableColumnName == "SubCodeContent") { origItem.Value = codeGeneratorRequest.SubCodeContent; }
                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });
                    }
                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        /// <summary>
        /// User Media Presentation List
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetMediaPresentationList")]
        public async Task<string> GetMediaPresentationList() {
            List<PortalApiTableColumnDataList> data = new();
            try {
                if (HtttpContextExtension.IsLogged()) {
                    using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted })) {
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName == "MediaPresentationList" && a.UserId == HtttpContextExtension.GetUserId())
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                    }
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true, DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        /// <summary>
        /// Set User Media Presentation List
        /// </summary>
        /// <param name="mediaPresentationListRequest"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetMediaPresentationList")]
        public async Task<string> SetMediaPresentationList([FromBody] MediaPresentationListRequest mediaPresentationListRequest)
        {
            EasyITCenterContext data = new EasyITCenterContext(); List<PortalApiTableColumnDataList>? original = null;
            try {
                if (HtttpContextExtension.IsLogged()) {

                    if (string.IsNullOrWhiteSpace(mediaPresentationListRequest.RecGuid)) {
                        string recGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "PresentationName", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.PresentationName, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "Description", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.Description, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
<<<<<<< Updated upstream
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "DataContent", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.DataContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new PortalApiTableColumnDataList() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "Theme", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.Theme, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
=======
                        record.Add(new() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "DataContent", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.DataContent, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "MediaPresentationList", ApiTableColumnName = "Theme", InheritedDataType = "string", RecGuid = recGuid, Value = mediaPresentationListRequest.Theme, Description = null, Active = true, UserId = (int)HtttpContextExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes


                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                        {
                            original = new EasyITCenterContext().PortalApiTableColumnDataLists
                                .Where(a => a.ApiTableName == "MediaPresentationList" && a.UserId == HtttpContextExtension.GetUserId() && a.RecGuid == mediaPresentationListRequest.RecGuid)
                                .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                        }

                        original.ForEach(origItem => {
                            if (origItem.ApiTableColumnName == "PresentationName") { origItem.Value = mediaPresentationListRequest.PresentationName; }
                            else if (origItem.ApiTableColumnName == "Description") { origItem.Value = mediaPresentationListRequest.Description; }
<<<<<<< Updated upstream
                            else if (origItem.ApiTableColumnName == "DataContent") { origItem.Value = mediaPresentationListRequest.DataContent; } 
                            else if (origItem.ApiTableColumnName == "Theme") { origItem.Value = mediaPresentationListRequest.Theme; } 
=======
                            else if (origItem.ApiTableColumnName == "DataContent") { origItem.Value = mediaPresentationListRequest.DataContent; }
                            else if (origItem.ApiTableColumnName == "Theme") { origItem.Value = mediaPresentationListRequest.Theme; }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                        });

                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(original);
                            data.SaveChanges();
                            return true;
                        });
                    }
                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 3, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

    }
}
