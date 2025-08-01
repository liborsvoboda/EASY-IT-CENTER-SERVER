

//Run POST Api Request FOR set and GET storageName on SET is null
Gs.Apis.RunServerPostApi = function (apiPath, jsonData, storageName) {
    Gs.Behaviors.ShowPageLoading();
    var def = $.ajax({
        global: false, type: "POST", url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        data: JSON.stringify(jsonData)
    });

    def.fail(function (err) {
        Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.apiSaveFail);
        Gs.Behaviors.HidePageLoading();
        return false;
    });

    def.done(function (apiData) {
        Gs.Objects.ShowNotify("success", Gs.Variables.apiMessages.apiSaveSuccess);
        if (storageName != null) { Metro.storage.setItem(storageName, JSON.parse(JSON.stringify(apiData))); }
        Gs.Behaviors.HidePageLoading();
        return true;
    });
}

//Run GET Api Request 
Gs.Apis.RunServerGetApi = function (apiPath, storageName) {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        type: "GET",
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        success: function (apiData) {
            if (storageName != null) { Metro.storage.setItem(storageName, JSON.parse(JSON.stringify(apiData))); }
            Gs.Objects.ShowNotify("success", Gs.Variables.apiMessages.apiLoadSuccess);
            Gs.Behaviors.HidePageLoading();
            return true;
        },
        error: function (error) {
            Metro.storage.setItem(storageName, null);
            Gs.Objects.ShowNotify("alert", Gs.Variables.apiMessages.apiLoadFail);
            Gs.Behaviors.HidePageLoading();
        }
    });
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
        Metro.storage.setItem("ApiToken", data);
        window.location.href = Metro.storage.getItem("DefaultPath", null); 
        Gs.Behaviors.HidePageLoading();
    });
}


Gs.Apis.IsLogged = function () {
    return Metro.storage.getItem("ApiToken", null) == null ? false : true;
}