using CSJsonDB;
using DocumentFormat.OpenXml.Office2010.Excel;
using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tensorflow;
using Tweetinvi.Core.DTO;
using Tweetinvi.Core.Events;

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



    [Route("PortalApiTableService")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        [AllowAnonymous]
        [HttpGet("/PortalApiTableService/GetApiTableDataList/{tablename}")]
        public async Task<string> GetApiTableDataList(string tablename) {
            List<PortalApiTableColumnDataList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {
                    data = new EasyITCenterContext().PortalApiTableColumnDataLists
                        .Where(a => a.ApiTableName.ToLower() == tablename.ToLower() && a.Active == true)
                        .OrderBy(a => a.RecGuid).ThenBy(a => a.Id).ToList();
                }
            } 
            catch (Exception ex) {  }
                return JsonSerializer.Serialize(data, new JsonSerializerOptions() { 
                ReferenceHandler = ReferenceHandler.IgnoreCycles, 
                WriteIndented = true, 
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase, 
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }


        [AllowAnonymous]
        [HttpPost("/PortalApiTableService/SetApiTableColumnDataList")]
        public async Task<string> SetApiTableColumnDataList([FromBody] MenuData menuData) {
            EasyITCenterContext data = new EasyITCenterContext();
            try {
                
                if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {
                    if (menuData.RecGuid == null) {
                        menuData.RecGuid = Guid.NewGuid().ToString().ToUpper();
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { ApiTableName = "PortalMenu", ApiTableColumnName = "MdHelp", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.MdHelp, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.AddRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    } else {
                        List<PortalApiTableColumnDataList> original = new();
                        original = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.RecGuid == menuData.RecGuid).ToList();
                        
                        List<PortalApiTableColumnDataList> record = new();
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "ParentGuid").Select(a=>a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "ParentGuid", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.ParentGuid, Description = menuData.Description, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Sequence").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Sequence", InheritedDataType = "int", RecGuid = menuData.RecGuid, Value = menuData.Sequence.ToString(), Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Name").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Name", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Name, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "Icon").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "Icon", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.Icon, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "InheritedMenuType").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "InheritedMenuType", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.InheritedMenuType, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "HtmlContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "HtmlContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.HtmlContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "JsContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "JsContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.JsContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "CSSContent").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "CSSContent", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.CssContent, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        record.Add(new() { Id = (int)original.Where(a => a.ApiTableColumnName == "MdHelp").Select(a => a.Id).FirstOrDefault(), ApiTableName = "PortalMenu", ApiTableColumnName = "MdHelp", InheritedDataType = "string", RecGuid = menuData.RecGuid, Value = menuData.MdHelp, Description = null, Active = menuData.Active, UserId = (int)ServerApiServiceExtension.GetUserId(), TimeStamp = DateTimeOffset.Now.DateTime });
                        
                        DatabaseContextExtensions.RunTransaction(data, (trans) => {
                            data.PortalApiTableColumnDataLists.UpdateRange(record);
                            data.SaveChanges();
                            return true;
                        });
                    }

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 8, ErrorMessage = menuData.RecGuid });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }


        [AllowAnonymous]
        [HttpDelete("/PortalApiTableService/DeleteApiTableColumnDataList/{recGuid}")]
        public async Task<string> DeleteApiTableColumnDataList(string recGuid) {
            EasyITCenterContext data = new EasyITCenterContext();
            try {

                if (ServerApiServiceExtension.IsAdmin() || ServerApiServiceExtension.IsWebAdmin()) {

                    List<PortalApiTableColumnDataList> original = new();
                    original = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.RecGuid == recGuid).ToList();

                    DatabaseContextExtensions.RunTransaction(data, (trans) => {
                        data.PortalApiTableColumnDataLists.DeleteRangeByKey(original);
                        data.SaveChanges();
                        return true;
                    });

                    return JsonSerializer.Serialize(new ResultMessage() { InsertedId = 0, Status = DBResult.success.ToString(), RecordCount = 8, ErrorMessage = string.Empty });
                } else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.UnauthorizedRequest.ToString(), RecordCount = 0, ErrorMessage = string.Empty });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

    }
}
