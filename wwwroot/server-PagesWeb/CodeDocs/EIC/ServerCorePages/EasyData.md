﻿[Zpět](../../)   

```csharp  

@page "/easydata/{**entity}"
@* @{ Layout = "/ServerCorePages/Shared/MetroLayout.csharp"; } *@

@addTagHelper *, WebOptimizer.Core
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

@using ServerCorePages;
@using Microsoft.AspNetCore.Html;
@using EasyITCenter.DBModel;
@using EasyITCenter.ServerCoreWebPages;
@using EasyITCenter.ServerCoreStructure;
@using System.Security.Claims;
@namespace ServerCorePages
@{
    ViewData["Title"] = "DB EasyData Manager";

    bool userLogged = false;
    string token = HttpContext.Request.Cookies.FirstOrDefault(a => a.Key == "ApiToken").Value;
    ServerWebPagesToken? srvWebPagesToken = null;
    if (token != null) {
        srvWebPagesToken = CoreOperations.CheckTokenValidityFromString(token);
        if (srvWebPagesToken != null && srvWebPagesToken.IsValid) { User.AddIdentities(srvWebPagesToken.UserClaims.Identities); userLogged = true; }
    }
}


    @if (userLogged && srvWebPagesToken != null && srvWebPagesToken.UserClaims.FindFirstValue(ClaimTypes.Role.ToString()) == "admin") {
    ServerModuleAndServiceList? serverModule = ((ServerModuleAndServiceList?)HttpContext.Items.FirstOrDefault(a => a.Key.ToString() == "ServerModule").Value);

    if (serverModule != null) { Html.Raw(serverModule.CustomHtmlContent); }

    <link rel="stylesheet" href="../../ServerCoreTools/easydata/css/easydata.min.css" />
    <div class="container text-center pt-5 mb-2">
            <DIV class="info-panel">
                <div id="EasyDataContainer"></div>
            </DIV>
    </div>

    <script src="../../ServerCoreTools/easydata/js/jquery-3.6.0.min.js" type="text/javascript"></script>
    <script src="../../ServerCoreTools/easydata/js/easydata.min.js" type="text/javascript"></script>
    <script>
                window.addEventListener('load', function () {
                    new easydata.crud.EasyDataViewDispatcher().run()
                });
    </script>
    }

     
@if (!userLogged) { 
    <script type="text/javascript">
   
        ShowUnAuthMessage();
        function Logout() {
            Cookies.remove('ApiToken');
            Metro.storage.storage.clear();
            window.location.href ='/';
        }

        function ShowUnAuthMessage() {
            $("body")[0].setAttribute("onclick", "Logout();");
            var html_content =
                "<h3>Neautorizovaný Přístup</h3>" +
                "<p>Pokoušíte se provést autorizovanou operaci neoprávněně,</p>" +
                "<p>nebo platnost vašeho tokenu vypršela.</p>";
                "<p>Váš pokus Byl zaznamenám k prověření...</p>" +
            Metro.infobox.create(html_content, "alert");
        }
     </script>
}


```  



