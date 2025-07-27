using CSJsonDB;
using DocumentFormat.OpenXml.Office2010.Excel;
using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tweetinvi.Core.Events;

namespace StripeAPI.Controllers
{

    public partial class MenuData {
        public string ParentGuid { get; set; } = null;
        public string RecGuid { get; set; } = null;
        public int Sequence { get; set; }
        public string Name { get; set; } = null;
        public string Icon { get; set; } = null;
        public string InheritedMenuType { get; set; } = null;
        public string Description { get; set; } = null;
        public bool Public { get; set; } = true;
        public bool Active { get; set; } = true;
        public string HtmlContent { get; set; } = null;
        public string JsContent { get; set; } = null;
        public string CssContent { get; set; } = null;
    }



    [Route("ServerPortalApi")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        //[AllowAnonymous]
        //[Authorize]
        [HttpGet("/ServerPortalApi/GetApiTableDataList/{tablename}")]
        public async Task<string> GetApiTableDataList(string tablename) {
            List<PortalApiTableColumnDataList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {

                    if (!ServerApiServiceExtension.IsLogged()) {

                        data = await new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && a.UserPrefix == null && a.Public == true && a.Active == true)
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToListAsync();

                    } else {
                        data = await new EasyITCenterContext().PortalApiTableColumnDataLists
                       .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && ( a.UserPrefix == null || a.UserPrefix == ServerApiServiceExtension.GetUserPrefix() ) && a.Active == true)
                       .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToListAsync();

                    }
                }
            } 
            catch (Exception ex) {  }
                return JsonSerializer.Serialize(data, new JsonSerializerOptions() { 
                ReferenceHandler = ReferenceHandler.IgnoreCycles, 
                WriteIndented = true, 
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, 
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        [Authorize]
        [HttpGet("/ServerPortalApi/GetApiTableList")]
        public async Task<string> GetApiTableList() {
            List<PortalApiTableList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {

                    if (!ServerApiServiceExtension.IsLogged()) {
                        data = await new EasyITCenterContext().PortalApiTableLists
                       .Where(a => ( a.UserPrefix == null && ServerApiServiceExtension.IsAdmin()) || a.UserPrefix == ServerApiServiceExtension.GetUserPrefix() )
                       .OrderBy(a => a.Name).ToListAsync();

                    }
                }
            } catch (Exception ex) { }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }


        [Authorize]
        [HttpGet("/ServerPortalApi/GetApiTableColumnList")]
        public async Task<string> GetApiTableColumnList(string tablename) {
            List<PortalApiTableColumnList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {

                    if (!ServerApiServiceExtension.IsLogged()) {
                        data = await new EasyITCenterContext().PortalApiTableColumnLists
                       .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && ( a.UserPrefix == null && ServerApiServiceExtension.IsAdmin() ) || a.UserPrefix == ServerApiServiceExtension.GetUserPrefix())
                       .OrderBy(a => a.Name).ToListAsync();

                    }
                }
            } catch (Exception ex) { }
            return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }


        [Authorize]
        [HttpPost("/ServerPortalApi/SetApiTableColumnDataList")]
        public async Task<string> GetApiTableColumnList(MenuData menuData) {
            EntityEntry<PortalApiTableColumnDataList>? data = null;
            try {
                
                if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                    if (menuData.RecGuid == null) {
                        menuData.RecGuid = new Guid().ToString();
                        PortalApiTableColumnDataList record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Add(record);
                    } else {
                        PortalApiTableColumnDataList record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                        record = new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime };
                        data = new EasyITCenterContext().PortalApiTableColumnDataLists.Update(record);
                    }
                    int result = await data.Context.SaveChangesAsync();

                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

    }
}
