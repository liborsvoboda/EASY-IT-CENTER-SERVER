using CSJsonDB;
using DocumentFormat.OpenXml.Office2010.Excel;
using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tensorflow;
using Tweetinvi.Core.DTO;
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

        [AllowAnonymous]
        [HttpGet("/ServerPortalApi/GetApiTableDataList/{tablename}")]
        public async Task<string> GetApiTableDataList(string tablename) {
            List<PortalApiTableColumnDataList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {

                    if (!ServerApiServiceExtension.IsLogged()) {
                        data = await new EasyITCenterContext().PortalApiTableColumnDataLists
                            .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && a.Public == true && a.Active == true)
                            .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToListAsync();
                    } else {
                        data = await new EasyITCenterContext().PortalApiTableColumnDataLists
                       .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && ( a.Public == true || ( a.UserPrefix == ServerApiServiceExtension.GetUserPrefix() && a.Public == false)) && a.Active == true)
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

                    if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                        data = await new EasyITCenterContext().PortalApiTableLists.OrderBy(a => a.Name).ToListAsync();
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

                    if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                        data = await new EasyITCenterContext().PortalApiTableColumnLists
                       .Where(a => a.ApiTableName.ToLower() == tablename.ToLower())
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
        public async Task<string> GetApiTableColumnList([FromBody] MenuData menuData) {
            EasyITCenterContext data = new EasyITCenterContext(); ;
            try {
                
                if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                    if (menuData.RecGuid == null) {
                        menuData.RecGuid = Guid.NewGuid().ToString();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        data.PortalApiTableColumnDataLists.AddRange(record);

                    } else {
                        List<PortalApiTableColumnDataList> original = new();
                        original = await new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.RecGuid == menuData.RecGuid).ToListAsync();
                        

                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "ParentGuid").Select(a=>a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Sequence").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Name").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Icon").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "InheritedMenuType").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "HtmlContent").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "JsContent").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "CSSContent").Select(a => a.Id).FirstOrDefault(), UserPrefix = ServerApiServiceExtension.GetUserPrefix(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Public = menuData.Public, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        data.PortalApiTableColumnDataLists.UpdateRange(record);
                    }
                    data.SaveChangesAsync();

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 8, ErrorMessage = menuData.RecGuid });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

    }
}
