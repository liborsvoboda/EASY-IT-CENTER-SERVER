

//Run POST Api Request FOR set and GET storageName on SET is null
Gs.Apis.RunServerPostApi =async function (apiPath, jsonData, storageName) {
    Gs.Behaviors.ShowPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'POST', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        body: JSON.stringify(jsonData)
    }); let result = await response.json();
    if (storageName != null) { Metro.storage.setItem(storageName, result); }
    Gs.Behaviors.HidePageLoading();

    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.apiSaveFail); return false; }
}

//Run GET Api Request 
Gs.Apis.RunServerGetApi = async function (apiPath, storageName) {
    Gs.Behaviors.ShowPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'GET', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (storageName != null) { Metro.storage.setItem(storageName, result); }
    Gs.Behaviors.HidePageLoading();
    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.apiLoadFail); return false; }
}


//Run DELETE Api REquest
Gs.Apis.RunServerDeleteApi = async function (apiPath) {
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, {
        method: 'DELETE', headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == undefined || result.Status == "success") { return true; }
    else { Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.apiDeleteFail); return false; }
}


function InvalidForm() {
    var form = $(this); form.addClass("ani-ring");
    setTimeout(function () { form.removeClass("ani-ring"); }, 1000);
}


function ValidateForm() {
    Gs.Behaviors.ShowPageLoading();
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
}


Gs.Apis.IsLogged = function () {
    return Metro.storage.getItem("ApiToken", null) == null ? false : true;
}