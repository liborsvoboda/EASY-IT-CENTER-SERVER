

/*
Gs.Apis.RunServerPostApi =async function (apiPath, jsonData, storageName) {
    Gs.Behaviors.ShowPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'POST', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        body: JSON.stringify(jsonData)
    }); let result = await response.json();
    if (storageName != null) { Metro.storage.setItem(storageName, result); }
    Gs.Behaviors.HidePageLoading();

    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", result.Status + " " + Gs.Variables.apiMessages.apiSaveFail); return false; }
}


Gs.Apis.RunServerGetApi = async function (apiPath, storageName) {
    Gs.Behaviors.ShowPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'GET', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (storageName != null) { Metro.storage.setItem(storageName, result); }
    Gs.Behaviors.HidePageLoading();
    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", result.Status + " " + Gs.Variables.apiMessages.apiLoadFail); return false; }
}



Gs.Apis.RunServerDeleteApi = async function (apiPath) {
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'DELETE', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", result.Status + " " + Gs.Variables.apiMessages.apiDeleteFail); return false; }
}


*/

Gs.Apis.RunServerPostApi = async function (apiPath, jsonData, storageName) {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        data: JSON.stringify(jsonData),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (storageName != null) {
                if (result.Result != undefined) {
                    Metro.storage.setItem(storageName, result.Result);
                } else { Metro.storage.setItem(storageName, result); }
            }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


Gs.Apis.RunServerGetApi = async function (apiPath, storageName) {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "GET",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (storageName != null) {
                if (result.Result != undefined) {
                    Metro.storage.setItem(storageName, result.Result);
                } else { Metro.storage.setItem(storageName, result); }
            }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


Gs.Apis.RunServerDeleteApi = async function (apiPath) {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "DELETE",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


function InvalidForm() {
    var form = $(this); form.addClass("ani-ring");
    setTimeout(function () { form.removeClass("ani-ring"); }, 1000);
}


function ValidateForm() {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/AuthenticationService",
        async: true,
        cache: false,
        headers: { "Authorization": "Basic " + btoa($("#usernameId").val() + ":" + $("#passwordId").val()) },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            Gs.Behaviors.HidePageLoading();
            Cookies.set('ApiToken', result.Token);
            Metro.storage.setItem("ApiToken", result);
            window.location.href = Metro.storage.getItem("DefaultPath", null);
        },
        error: function (err) {
            Gs.Behaviors.HidePageLoading();
            Cookies.set('ApiToken', null);
            Metro.storage.setItem("ApiToken", null);
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });

    /*
    var def = $.ajax({
        global: false, type: "POST", url: Metro.storage.getItem('BackendServerAddress', null) + "/AuthenticationService", dataType: 'json',
        headers: { "Authorization": "Basic " + btoa($("#usernameId").val() + ":" + $("#passwordId").val()) }
    });

    def.fail(function (data) {
        Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.incorectLogin);
        Gs.Behaviors.HidePageLoading();
    });

    def.done(function (data) {
        Cookies.set('ApiToken', data.Token);
        Metro.storage.setItem("ApiToken", data);
        window.location.href = Metro.storage.getItem("DefaultPath", null); 
        Gs.Behaviors.HidePageLoading();
    });
    */

}


Gs.Apis.IsLogged = function () {
    return Metro.storage.getItem("ApiToken", null) == null ? false : true;
}