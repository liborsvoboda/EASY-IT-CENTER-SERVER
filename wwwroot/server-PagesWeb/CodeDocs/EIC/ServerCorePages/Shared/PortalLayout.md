﻿[Zpět](../../../)   

```xml  

<!DOCTYPE html>
<html lang="cs-CZ">
<head>
    @(Html.Raw(this.Model.GetManagedHeaderPreCssForLayout().ContentType))
    @(Html.Raw(this.Model.GetManagedCssFilesForLayout().ContentType))
    @(Html.Raw(this.Model.GetManagedHeaderPreScriptsForLayout().ContentType))
    @(Html.Raw(this.Model.GetManagedJsFilesForLayout().ContentType))
    @(Html.Raw(this.Model.GetManagedHeaderPostScriptsForLayout().ContentType))
</head>
@(Html.Raw(this.Model.GetManagedBodyPartForLayout().ContentType))
    @RenderBody()
@(Html.Raw(this.Model.GetManagedFooterPartForLayout().ContentType))
</html>

```  
