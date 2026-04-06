

using System.IO.Compression;

namespace EasyITCenter.Controllers {


    [AllowAnonymous]
    [Route("ConversionService")]
    [ApiController]
    public class ConversionService : Controller
    {

        public class XlsxToHtmlRequest
        {
            public string XlsxSourcePath { get; set; }
            public string HtmlTargetPath { get; set; }
        }


        [Authorize]
        [HttpPost("/ConversionService/XlsxToHtml")]
        [Consumes("application/json")]
        public async Task<string> XlsxToHtml([FromBody] XlsxToHtmlRequest xlsxToHtmlRequest)
        {
            try
            {
                XlsxToHtmlConverter.Converter.Convert(Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), xlsxToHtmlRequest.XlsxSourcePath), Path.Combine(SrvRuntime.SrvUserPath, HttpContextExtension.GetUserName(), xlsxToHtmlRequest.HtmlTargetPath));
                return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.success.ToString(), RecordCount = 0, ErrorMessage = string.Empty }); ;
            } catch (Exception ex) { return JsonSerializer.Serialize(new ResultMessage() { Status = DBResult.error.ToString(), RecordCount = 0, ErrorMessage = DataOperations.GetUserApiErrMessage(ex) }); } 
        
        }
    }
}