using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StripeAPI.Controllers
{
    [Route("ServerPortalApi")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        [HttpGet("/ServerPortalApi/GetApiTableData/{tablename}")]
        public async Task<string> GetApiTableData(string tablename) {
            List<PortalApiTableColumnDataList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.ApiTable == tablename)
                    .Include(a => a.ApiTableColumn)
                    .OrderBy(a => a.RecId).ThenBy(a=>a.Id).ToList();
            }
            return JsonSerializer.Serialize(data);
        }
    }
}
