using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StripeAPI.Controllers
{
    [Route("ServerPortalApi/[controller]")]
    [ApiController]
    public class PortalApiTableService : ControllerBase
    {

        [HttpGet("/GetApiTableData/{tablename}")]
        public async Task<string> GetApiTableData(string tablename) {
            List<PortalApiTableColumnDataList> data;
            using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
            })) {
                data = new EasyITCenterContext().PortalApiTableColumnDataLists.Where(a => a.ApiTable == tablename)
                    .OrderBy(a => a.Id).ThenBy(a=>a.RecId).ToList();
            }
            return JsonSerializer.Serialize(data);
        }
    }
}
