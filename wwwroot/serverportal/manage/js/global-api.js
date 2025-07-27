

//Run POST Api Request FOR set and GET storageName on SET is null
function RunServerPostApi(apiPath, jsonData, storageName) {
    ShowPageLoading();
    var def = $.ajax({
        global: false, type: "POST", url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        data: JSON.stringify(jsonData)
    });

    def.fail(function (err) {
        notify.create(apiMessages.apiSaveFail, "Alert", { cls: "alert" }); notify.reset();
        HidePageLoading();
        return false;
    });

    def.done(function (apiData) {
        notify.create(apiMessages.apiSaveSuccess, "Info", { cls: "success" }); notify.reset();
        if (storageName != null) { Metro.storage.setItem(storageName, JSON.parse(JSON.stringify(apiData))); }
        HidePageLoading();
        return true;
    });
}

//Run GET Api Request 
function RunServerGetApi(apiPath, storageName) {
    ShowPageLoading();
    $.ajax({
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        type: "GET",
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        success: function (apiData) {
            if (storageName != null) { Metro.storage.setItem(storageName, JSON.parse(JSON.stringify(apiData))); }
            notify.create(apiMessages.apiLoadSuccess, "Info", { cls: "success" }); notify.reset();
            HidePageLoading();
            return true;
        },
        error: function (error) {
            Metro.storage.setItem(storageName, null);
            notify.create(apiMessages.apiLoadFail, "Alert", { cls: "alert" }); notify.reset();
            HidePageLoading();
        }
    });
}



function InvalidForm() {
    var form = $(this); form.addClass("ani-ring");
    setTimeout(function () { form.removeClass("ani-ring"); }, 1000);
}


function ValidateForm() {
    ShowPageLoading();
    var def = $.ajax({
        global: false, type: "POST", url: Metro.storage.getItem('BackendServerAddress', null) + "/AuthenticationService", dataType: 'json',
        headers: { "Authorization": "Basic " + btoa($("#usernameId").val() + ":" + $("#passwordId").val()) }
    });

    def.fail(function (data) {
        notify.create("Incorect Name or Password", "Error", { cls: "alert" }); notify.reset();
        HidePageLoading();
    });

    def.done(function (data) {
        Metro.storage.setItem("ApiToken", data);
        window.location.href = Metro.storage.getItem("DefaultPath", null); 
        HidePageLoading();
    });
}

function IsLogged() {
    return Metro.storage.getItem("ApiToken", null) == null ? false : true;
}