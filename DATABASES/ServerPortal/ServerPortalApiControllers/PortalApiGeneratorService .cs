using EasyITCenter.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StripeAPI.Controllers
{
    [Route("ServerPortalApi")]
    [ApiController]
    public class PortalApiGeneratorService : ControllerBase
    {

        //[AllowAnonymous]
        //[Authorize]
        [HttpGet("/ServerPortalApi/GetGeneratorTemplateList")]
        public async Task<string> GetGeneratorTemplateList() {
            List<PortalGeneratorTemplateList> data = new();
            try {
                using (new TransactionScope(TransactionScopeOption.Required, new TransactionOptions {
                    IsolationLevel = IsolationLevel.ReadUncommitted //with NO LOCK
                })) {

                    if (!ServerApiServiceExtension.IsLogged()) {

                        data = await new EasyITCenterContext().PortalGeneratorTemplateLists
                            .Where(a => a.UserPrefix == null && a.Public == true && a.Active == true)
                            .OrderBy(a => a.InheritedTemplateType).ThenBy(a => a.Name).ToListAsync();

                    } else {
                        data = await new EasyITCenterContext().PortalGeneratorTemplateLists
                       .Where(a => ( a.UserPrefix == null || a.UserPrefix == ServerApiServiceExtension.GetUserPrefix() ) && a.Active == true)
                       .OrderBy(a => a.InheritedTemplateType).ThenBy(a => a.Name).ToListAsync();

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
