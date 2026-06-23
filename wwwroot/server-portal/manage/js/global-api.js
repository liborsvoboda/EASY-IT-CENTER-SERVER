
/**
* Function for Save Captured Video of User Cloud Request
* @function
* @param {string} filename Filename for Saving
*/
Gs.Apis.SaveUserCapturedVideo = async function (filename) {
    await Gs.Apis.RunServerPostApi("UserStorageService/SaveMediaFile", { Path: "Videos", Filename: filename, Content: Metro.storage.getItem("CapturedVideo", null) }, null, "ReloadUserStorage");
    Gs.Media.ClearCapturedVideo();
}

/**
* Function for Save Captured Video of Public Cloud Request
* @function
* @param {string} filename Filename for Saving
*/
Gs.Apis.SavePublicCapturedVideo = async function (filename) {
    await Gs.Apis.RunServerPostApi("PublicStorageService/SaveMediaFile", { Path: "Videos", Filename: filename, Content: Metro.storage.getItem("CapturedVideo", null) }, null, "ReloadUserStorage");
    Gs.Media.ClearCapturedVideo();
}


/**
* Function for Downloading binary file from Server
* @function
* @param {string} apiPath API path of Server
* @param {string} jsonData Post Json Data
* @param {string} filename Filename for Download File
* @param {boolean} binary Binary or Text file
* @param {string} storageName Name of LocalStorage for Saving Result
* @param {string} windowFunction Function name for call after API is done
* @return {boolean} return status
*/
Gs.Apis.DownloadApi = async function (apiPath, jsonData, filename, binary, storageName = null, windowFunction = null ) {
    //used for Downloading files
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
        data: JSON.stringify(jsonData),
        contentType: "application/json; charset=utf-8",
        //dataType: 'binary', 
        xhrFields: {
            'responseType': binary ? 'blob' : "text"
        },
        success: function (result) {
            if (storageName != null) {//SAVE to Storage
                if (result.Result != undefined && result.Result != "") {
                    Metro.storage.setItem(storageName, result.Result);
                } else if (result.Status == "UnauthorizedRequest" || result.Result == "") { Metro.storage.setItem(storageName, []); }
                else { Metro.storage.setItem(storageName, result); }
            } else { //DOWNLOAD When not saved to Storage
                let a = document.createElement('a');
                a.href = window.URL.createObjectURL(result);
                a.download = result.type == "application/x-zip-compressed" ? filename + ".zip" : filename + ".md";
                document.body.appendChild(a); a.click();
                document.body.removeChild(a);
                window.URL.revokeObjectURL(a.href);
            }

            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
        },
        error: function (err) {
            console.log(err);
            if (storageName != null) { Metro.storage.delItem(storageName); }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
            return false;
        }
    });
}


/**
* Function for call API POST Request
* @function
* @param {string} apiPath API path of Server
* @param {string} jsonData Post Json Data
* @param {string} storageName Name of LocalStorage for Saving Result
* @param {string} windowFunction Function name for call after API is done
* @return {boolean} return status
*/
Gs.Apis.RunServerPostApi = async function (apiPath, jsonData, storageName, windowFunction = null) {
    //windowFunction is Only for window.fnName() NOT window.Gs.XXX.XXX Use for Reload Table
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
        data: JSON.stringify(jsonData),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (storageName != null) {
                if (result.Result != undefined && result.Result != "") {
                    Metro.storage.setItem(storageName, result.Result);
                } else if (result.Status == "UnauthorizedRequest" || result.Result == "") { Metro.storage.setItem(storageName, []); }
                else { Metro.storage.setItem(storageName, result); }
            }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            
            if (result.Status == undefined || result.Status == "success") { Gs.Objects.ShowNotify("success", result.Result); return true; }
            else {
                if (storageName != null) { Metro.storage.setItem(storageName, []); }
                if (windowFunction != null) { window[windowFunction](); }
                Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false;
            }
        },
        error: function (err) {
            console.log(err);
            if (storageName != null) { Metro.storage.setItem(storageName, []); }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });
}


/**
* Function for call API PUT Request
* @function
* @param {string} apiPath API path of Server
* @param {string} jsonData Post Json Data
* @param {string} storageName Name of LocalStorage for Saving Result
* @param {string} windowFunction Function name for call after API is done
* @return {boolean} return status
*/
Gs.Apis.RunServerPutApi = async function (apiPath, jsonData, storageName, windowFunction = null) {
    //windowFunction is Only for window.fnName() NOT window.Gs.XXX.XXX Use for Reload Table
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "PUT",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
        data: JSON.stringify(jsonData),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (storageName != null) {
                if (result.Result != undefined && result.Result != "") {
                    Metro.storage.setItem(storageName, result.Result);
                } else if (result.Status == "UnauthorizedRequest" || result.Result == "") { Metro.storage.setItem(storageName, []); }
                else { Metro.storage.setItem(storageName, result); }
            }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { Gs.Objects.ShowNotify("success", result.Result); return true; }
            else {
                if (storageName != null) { Metro.storage.setItem(storageName, []); }
                if (windowFunction != null) { window[windowFunction](); }
                Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false;
            }
        },
        error: function (err) {
            console.log(err);
            if (storageName != null) { Metro.storage.setItem(storageName, []); }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });
}


/**
* Function for call API GET Request
* @function
* @param {string} apiPath API path of Server
* @param {string} storageName Name of LocalStorage for Saving Result
* @param {string} windowFunction Function name for call after API is done
* @return {boolean} return status
*/
Gs.Apis.RunServerGetApi = async function (apiPath, storageName, windowFunction = null) {
    //windowFunction is Only for window.fnName() NOT window.Gs.XXX.XXX Use for Reload Table
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "GET",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (storageName != null) {
                if (result.Result != undefined && result.Result != "") {
                    Metro.storage.setItem(storageName, result.Result);
                } else if (result.Status == "UnauthorizedRequest" || result.Result == "") { Metro.storage.setItem(storageName, []); }
                else { Metro.storage.setItem(storageName, result); }
            }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { return true; }
            else {
                if (storageName != null) { Metro.storage.setItem(storageName, []); }
                if (windowFunction != null) { window[windowFunction](); }
                Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false;
            }
        },
        error: function (err) {
            console.log(err);
            if (storageName != null) { Metro.storage.setItem(storageName, []); }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });
}


/**
* Function for call API DELETE Request
* @function
* @param {string} apiPath API path of Server
* @param {string} windowFunction Function name for call after API is done
* @return {boolean} return status
*/
Gs.Apis.RunServerDeleteApi = async function (apiPath, windowFunction = null) {
    //windowFunction is Only for window.fnName() NOT window.Gs.XXX.XXX Use for Reload Table
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "DELETE",
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath,
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { Gs.Objects.ShowNotify("success", result.Result); return true; }
            else {
                if (windowFunction != null) { window[windowFunction](); }
                Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false;
            }
        },
        error: function (err) {
            console.log(err);
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });
}


/**
* Function with API of Portal User Setting
* @function
* @return {boolean} return status
*/Gs.Apis.GetUserSetting = function () {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "GET",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/PortalApiTableService/GetUserSettingList",
        async: true,
        cache: false,
        headers: Metro.storage.getItem("ApiToken", null) != null ? { 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null).Token } : "",
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
            console.log(err);
            Metro.storage.delItem("UserSettingList");
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });
}


/**
* Function of Status if User is Logged or NOT
* @function
* @return {boolean} return status
*/
Gs.Apis.IsLogged = function () {
    if (Cookies.get('ApiToken') == undefined || Cookies.get('ApiToken') == null) { return false } else { return true};
}


/**
* Function for SignOut of Logged User
* @function
*/
Gs.Apis.SignOut = function () {
    Cookies.remove('ApiToken');
    Metro.storage.delItem('ApiToken');
    window.location.href = Metro.storage.getItem("DefaultPath", null);
}