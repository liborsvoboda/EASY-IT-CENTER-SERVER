


Gs.Apis.RunServerPostApi = async function (apiPath, jsonData, storageName, windowFunction = null) {
    //Window function is Only window.fnName() NOT window.Gs.Apis.XXX Use for Reload Table
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
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


Gs.Apis.RunServerGetApi = async function (apiPath, storageName, windowFunction = null) {
    //Window function is Only window.fnName() NOT window.Gs.Apis.XXX Use for Reload Table
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
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


Gs.Apis.RunServerDeleteApi = async function (apiPath, windowFunction = null) {
    //Window function is Only window.fnName() NOT window.Gs.Apis.XXX Use for Reload Table
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
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else { Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false; }
        },
        error: function (err) {
            if (windowFunction != null) { window[windowFunction](); }
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
            Cookies.set('ApiToken', result.Token);
            Metro.storage.setItem("ApiToken", result);
            Gs.Behaviors.HidePageLoading();
            window.location.href = Metro.storage.getItem("DefaultPath", null);
            return true;
        },
        error: function (err) {
            Cookies.remove('ApiToken');
            Metro.storage.delItem("ApiToken");
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });

}


Gs.Apis.GetUserSetting = function () {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "GET",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/PortalApiTableService/GetUserSettingList",
        async: true,
        cache: false,
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            result.forEach(userSetting => {
                if (userSetting.apiTableColumnName == "EnableAutoTranslate") { Gs.Variables.UserSettingList.EnableAutoTranslate = JSON.parse(userSetting.value.toLowerCase()); }
                if (userSetting.apiTableColumnName == "EnableShowDescription") { Gs.Variables.UserSettingList.EnableShowDescription = JSON.parse(userSetting.value.toLowerCase()); }
                if (userSetting.apiTableColumnName == "RememberLastHandleBar") { Gs.Variables.UserSettingList.RememberLastHandleBar = JSON.parse(userSetting.value.toLowerCase()); }
                if (userSetting.apiTableColumnName == "RememberLastJson") { Gs.Variables.UserSettingList.RememberLastJson = JSON.parse(userSetting.value.toLowerCase()); }
                if (userSetting.apiTableColumnName == "EnableScreenSaver") { Gs.Variables.UserSettingList.EnableScreenSaver = JSON.parse(userSetting.value.toLowerCase()); }
            });
            Metro.storage.setItem("UserSettingList", Gs.Variables.UserSettingList);
            
            Gs.Behaviors.LoadUserSettings();
            Gs.Behaviors.HidePageLoading();
            return true;
        },
        error: function (err) {
            Metro.storage.delItem("UserSettingList");
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err); return false;
        }
    });
}


Gs.Apis.SetUserSetting = function () {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/PortalApiTableService/SetUserSettingList",
        async: true,
        cache: false,
        headers: JSON.parse(JSON.stringify(Metro.storage.getItem("ApiToken", null))) != null ? { 'Content-type': 'application/json charset=UTF-8', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : { 'Content-type': 'application/json' },
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(Metro.storage.getItem("UserSettingList", null)),
        dataType: "json",
        success: function (result) {
            Gs.Behaviors.HidePageLoading();
            return true;
        },
        error: function (err) {
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err);
            return false;
        }
    });
}

Gs.Apis.IsLogged = function () {
    if (Cookies.get('ApiToken') == undefined || Cookies.get('ApiToken') == null) { return false } else { return true};
}


Gs.Apis.SignOut = function () {
    Cookies.remove('ApiToken');
    Metro.storage.delItem('ApiToken');
    window.location.href = Metro.storage.getItem("DefaultPath", null);
}