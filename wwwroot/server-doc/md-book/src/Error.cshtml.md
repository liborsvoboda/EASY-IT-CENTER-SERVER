﻿# Úvod   EIC-CanceledRazorBuild  

Ukázka Kódu portálu v Technologii Razor/MVC s nutností provést Builde a nasazení na Web
Tvorba portálu byla pouhý měsíc, Ale od Tohoto způsobu VÝVOJE je upuštěno
ve prospěch ONLINE okamžité Aplikace Editory
IMPORTED FILE

ď»ż@page 
@model ServerCorePages.ErrorModel
@{
    ViewData["Title"] = "Error";
}

<h1 class="text-danger">Error.</h1>
<h2 class="text-danger">An error occurred while processing your request.</h2>

@if (Model.ShowRequestId)
{
    <p>
        <strong>Request ID:</strong> <code>@Model.RequestId</code>
    </p>
}

<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>