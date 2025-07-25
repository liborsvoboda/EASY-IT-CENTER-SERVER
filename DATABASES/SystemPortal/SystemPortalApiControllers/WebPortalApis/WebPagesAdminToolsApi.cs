﻿using Microsoft.EntityFrameworkCore;
using ServerCorePages;

namespace EasyITCenter.Controllers {

    [ApiController]
    [Route("WebApi/WebPages")]
     //[ApiExplorerSettings(IgnoreApi = true)]
    public class WebPagesAdminToolsApi : ControllerBase {

    

        [HttpGet("/WebApi/WebPages/GetWebMenuList")]
        public async Task<string> GetWebMenuList() {
            try {
                //if (CommunicationController.IsAdmin()) {
                List<WebMenuList> data;
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted
                })) {
                    data = new EasyITCenterContext().WebMenuLists.Include(a => a.Group).OrderBy(a => a.Name).ToList();
                }

                return JsonSerializer.Serialize(data, new JsonSerializerOptions() {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles,
                    WriteIndented = true,
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetErrMsg(ex) }); }
        }

        [Authorize]
        [HttpPost("/WebApi/WebPages/SetMenuList")]
        [Consumes("application/json")]
        public async Task<string> InsertOrUpdateWebMenuList([FromBody] WebSettingList1 record) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    string authId = User.FindFirst(ClaimTypes.PrimarySid.ToString()).Value;
                    string clientIPAddr = null;
                    int RecId = int.Parse(record.Settings.FirstOrDefault(a => a.Key == "Id").Value);
                    if (HttpContext.Connection.RemoteIpAddress != null) { clientIPAddr = Dns.GetHostEntry(HttpContext.Connection.RemoteIpAddress).AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString(); }

                    WebMenuList webMenu = new WebMenuList() {
                        Id = RecId,
                        GroupId = int.Parse(record.Settings.FirstOrDefault(a => a.Key == "GroupId").Value),
                        Sequence = int.Parse(record.Settings.FirstOrDefault(a => a.Key == "Sequence").Value),
                        Name = record.Settings.FirstOrDefault(a => a.Key == "Name").Value,
                        MenuClass = record.Settings.FirstOrDefault(a => a.Key == "MenuClass").Value,
                        Description = record.Settings.FirstOrDefault(a => a.Key == "Description").Value,
                        HtmlContent = record.Settings.FirstOrDefault(a => a.Key == "HtmlContent").Value,
                        UserIpaddress = clientIPAddr,
                        UserId = int.Parse(authId),
                        UserMenu = bool.Parse(record.Settings.FirstOrDefault(a => a.Key == "UserMenu").Value),
                        AdminMenu = bool.Parse(record.Settings.FirstOrDefault(a => a.Key == "AdminMenu").Value),
                        Active = bool.Parse(record.Settings.FirstOrDefault(a => a.Key == "Active").Value),
                        TimeStamp = DateTimeOffset.Now.DateTime
                    };

                    int result = 0;
                    if (RecId == 0) {
                        var data = new EasyITCenterContext().WebMenuLists.Add(webMenu);
                        result = await data.Context.SaveChangesAsync();
                    }
                    else {
                        var data = new EasyITCenterContext().WebMenuLists.Update(webMenu);
                        result = await data.Context.SaveChangesAsync();
                    }

                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = webMenu.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("YouDoesNotHaveRights") });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }

        [Authorize]
        [HttpDelete("/WebApi/WebPages/DeleteWebMenuList/{id}")]
        [Consumes("application/json")]
        public async Task<string> DeleteWebMenuList(string id) {
            try {
                if (ServerApiServiceExtension.IsAdmin()) {
                    if (!int.TryParse(id, out int Ids)) return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = "Id is not set" });

                    WebMenuList record = new() { Id = int.Parse(id) };

                    var data = new EasyITCenterContext().WebMenuLists.Remove(record);
                    int result = await data.Context.SaveChangesAsync();

                    if (result > 0) return JsonSerializer.Serialize(new ResultMessage() { InsertedId = record.Id, Status = DBResult.success.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                    else return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = result, ErrorMessage = string.Empty });
                }
                else {
                    return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DbOperations.DBTranslate("YouDoesNotHaveRights") });
                }
            } catch (Exception ex) {
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) });
            }
        }
    }
}