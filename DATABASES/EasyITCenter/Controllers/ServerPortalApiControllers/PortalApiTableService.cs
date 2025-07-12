using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StripeAPI.Controllers
{
    [Route("ServerPortalApi")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        //[AllowAnonymous]
        //[Authorize]
        [HttpGet("/ServerPortalApi/GetApiTableData/{tablename}")]
        public async Task<string> GetApiTableData(string tablename) {
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



    }
}
