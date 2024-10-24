[Zpět](../../../)   


```csharp  

@addTagHelper *, WebOptimizer.Core
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@using Microsoft.AspNetCore.Html;
@using ServerCorePages;
@using EasyITCenter.DBModel;
@using EasyITCenter.ServerCoreWebPages;
@using System.Security.Claims;
@using System.Text.RegularExpressions;
@namespace ServerCorePages
@{

    ServerModuleAndServiceList? serverModule = null; ServerModuleAndServiceList? loginModule = null; ServerWebPagesToken? webpagestoken = null;
    try { serverModule = ((ServerModuleAndServiceList?)Context.Items.FirstOrDefault(a => a.Key.ToString() == "ServerModule").Value); } catch { }
    try { loginModule = ((ServerModuleAndServiceList?)Context.Items.FirstOrDefault(a => a.Key.ToString() == "LoginModule").Value); } catch { }
    try { webpagestoken = ((ServerWebPagesToken?)Context.Items.FirstOrDefault(a => a.Key.ToString() == "ServerWebPagesToken").Value); } catch { }

}

@if (serverModule != null && serverModule.InheritedPageType == "HtmlBodyOnly" && loginModule == null && (!serverModule.RestrictedAccess || (serverModule.RestrictedAccess && webpagestoken != null && webpagestoken.IsValid && serverModule.AllowedRoles.Split(",").ToList().Contains(webpagestoken.UserClaims.FindFirstValue(ClaimTypes.Role))))) {
    <!DOCTYPE html>
    <html lang="cs-CZ">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1" />
        <meta name="charset" content="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="author" content="Libor Svoboda">
        <meta name="description" content="EasyITCenter">
        <meta name="keywords" content="System, Backend, API, EASY-DATA-Center, EASY-SYSTEM-Builder, Application, Server, IT, Solution, Help, HowTo, Javascript, HTML5, UI, Library, Web, Development, Framework">
        <link rel="shortcut icon" href="./favicon.ico" type="image/x-icon">
        <link rel="icon" href="./favicon.ico" type="image/x-icon">

        <link rel="stylesheet" href="../../metro/css/metro-icons.min.css" />
        <link rel="stylesheet" href="../../metro/css/metro-all.min.css" />
        @Html.Raw(this.Model.GetManagedCentralCssLayoutFiles().ContentType)

        <script type="text/javascript" src="../../metro/jquery/js/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../metro/addons/js/js.cookie.min.js"></script>
        <script type="text/javascript" src="../../metro/js/metro.4.5.2.min.js"></script>
        @Html.Raw(this.Model.GetManagedCentralJsLayoutFiles().ContentType)
        
        <!-- Google Translation -->
        <script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
    </head>
    <body id="body" style="background: url(../../metro/images/anime-background-images-1.jpg) center center no-repeat;background-size: cover;background-position: center;background-repeat: no-repeat;background-attachment: fixed;">
        <div class="d-block w-100 h-100">
            <main id="WebPageHTMLContent" role="main" class="pb-10 w-100 h-100" >
                @Html.Raw(serverModule.CustomHtmlContent)
                @RenderBody()
            </main>
        </div>
    </body>
    </html>
}
else if (loginModule != null && loginModule.InheritedPageType == "HtmlBodyOnly") {
    <!DOCTYPE html>
    <html lang="cs-CZ">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1" />
        <meta name="charset" content="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="author" content="Libor Svoboda">
        <meta name="description" content="EasyITCenter">
        <meta name="keywords" content="System, Backend, API, EASY-DATA-Center, EASY-SYSTEM-Builder, Application, Server, IT, Solution, Help, HowTo, Javascript, HTML5, UI, Library, Web, Development, Framework">
        <link rel="shortcut icon" href="./favicon.ico" type="image/x-icon">
        <link rel="icon" href="./favicon.ico" type="image/x-icon">

        <link rel="stylesheet" href="../../metro/css/metro-icons.min.css" />
        <link rel="stylesheet" href="../../metro/css/metro-all.min.css" />
        @Html.Raw(this.Model.GetManagedCentralCssLayoutFiles().ContentType)

        <script type="text/javascript" src="../../metro/jquery/js/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../metro/addons/js/js.cookie.min.js"></script>
        <script type="text/javascript" src="../../metro/js/metro.4.5.2.min.js"></script>
        @Html.Raw(this.Model.GetManagedCentralJsLayoutFiles().ContentType)

        <!-- Google Translation -->
        <script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
    </head>
    <body id="body" style="background: url(../../metro/images/anime-background-images-1.jpg) center center no-repeat;background-size: cover;background-position: center;background-repeat: no-repeat;background-attachment: fixed;">
        <div class="d-block w-100 h-100">
            <main id="WebPageHTMLContent" role="main" class="pb-10 w-100 h-100">
                @Html.Raw(loginModule.CustomHtmlContent)
                @RenderBody()
            </main>
        </div>
    </body>
    </html>
}
else if (loginModule != null && loginModule.InheritedPageType == "FullHtmlPage") {
    <!DOCTYPE html>
    <html lang="cs-CZ">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1" />
        <meta name="charset" content="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="author" content="Libor Svoboda">
        <meta name="description" content="EasyITCenter">
        <meta name="keywords" content="System, Backend, API, EASY-DATA-Center, EASY-SYSTEM-Builder, Application, Server, IT, Solution, Help, HowTo, Javascript, HTML5, UI, Library, Web, Development, Framework">
        <link rel="shortcut icon" href="./favicon.ico" type="image/x-icon">
        <link rel="icon" href="./favicon.ico" type="image/x-icon">
        @Html.Raw(this.Model.GetManagedCentralCssFiles().ContentType)
        @Html.Raw(this.Model.GetManagedCentralJsFiles().ContentType)
    </head>
    <body>
        @Html.Raw(loginModule?.CustomHtmlContent)
        @RenderBody()
    </body>
    </html>
}
else if (serverModule != null && serverModule.InheritedPageType == "FullHtmlPage" && loginModule == null && (!serverModule.RestrictedAccess || (serverModule.RestrictedAccess && webpagestoken != null && webpagestoken.IsValid && serverModule.AllowedRoles.Split(",").ToList().Contains(webpagestoken.UserClaims.FindFirstValue(ClaimTypes.Role))))) {
    <!DOCTYPE html>
    <html lang="cs-CZ">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1" />
        <meta name="charset" content="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="author" content="Libor Svoboda">
        <meta name="description" content="EasyITCenter">
        <meta name="keywords" content="System, Backend, API, EASY-DATA-Center, EASY-SYSTEM-Builder, Application, Server, IT, Solution, Help, HowTo, Javascript, HTML5, UI, Library, Web, Development, Framework">
        <link rel="shortcut icon" href="./favicon.ico" type="image/x-icon">
        <link rel="icon" href="./favicon.ico" type="image/x-icon">
        @Html.Raw(this.Model.GetManagedCentralCssFiles().ContentType)
        @Html.Raw(this.Model.GetManagedCentralJsFiles().ContentType)
    </head>
    <body>
        @Html.Raw(serverModule?.CustomHtmlContent)
        @RenderBody()
    </body>
    </html>
}
else { //Using by Static Tool or unspecified
    <!DOCTYPE html>
    <html lang="cs-CZ">
    <head>
        @Html.Raw(this.Model.GetManagedCentralCssFiles().ContentType)
        @Html.Raw(this.Model.GetManagedCentralJsFiles().ContentType)
    </head>
    <body>
        @Html.Raw(serverModule?.CustomHtmlContent)
        @RenderBody()
    </body>
    </html>
}


```  

