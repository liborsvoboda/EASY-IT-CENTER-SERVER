
/**
* Function for Collective run APIS and Start function on APIs done
* ////{ UUID, Api: [Id = RandomString,Sequence = 0 - XXXX number same for Serial API, Other for Paraler API, Processing = true/false, Processed = true/false, Type: ApiName + WindowFunction,
next Same as Definition with UpperCase First Character//ApiPath, JsonData, Filename, Binary, StorageName = null, WindowFunction = null ] }
* @function
*/
Gs.Apis.RunApiManager = function () {
    let lastUUID = ""; 
    Gs.Variables.apiTaskList.forEach(function(api, index, arr) {
        let processing = false; let sequence = 0; let prewSequence = 0;

        //FORMAT CORRECT API FLOW
        if (api.UUID == undefined) { api.UUID = Gs.Functions.GenerateUUID(); }

        //Clean Processed
        if (api.Processed != undefined && api.Processed) { api.Processing = false; }
        if (api.Processed) {
            Gs.Variables.apiTaskList = arr.filter(obj => { return obj.Id != api.Id });
            if (arr[index - 1] != undefined && arr[index - 1].UUID != undefined) { lastUUID = arr[index - 1].UUID; } else { lastUUID = ""; }
        }


        if (api.UUID != lastUUID) {
           
            //FORMAT CORRECT API FLOW
            if (api.Id == undefined) { api.Id = Gs.Functions.RandomString(); }
            if (api.Processing == undefined) { api.Processing = false; }
            if (api.Processed == undefined) { api.Processed = false; }
            if (api.Sequence == undefined) { api.Sequence = 0; }
            if (api.ApiPath == undefined) { api.ApiPath = null; }
            if (api.JsonData == undefined) { api.JsonData = []; }
            if (api.Filename == undefined) { api.Filename = null; }
            if (api.Binary == undefined) { api.Binary = false; }
            if (api.StorageName == undefined) { api.StorageName = null; }
            if (api.WindowFunction == undefined) { api.WindowFunction = null; }

            //Check Previous
            if (index == 0) { prewSequence = 0; } else { prewSequence = arr[index - 1].Sequence; }
            if (api.Processed) { sequence = api.Sequence; }

            //Process API
            if (!api.Processed && !processing && !api.Processing && (arr[index].Sequence == prewSequence || arr[index].Sequence > sequence)) {
                try {
                    switch (api.Type) {
                        case "DownloadApi":
                            //(apiPath, jsonData, filename, binary, storageName = null, windowFunction = null )
                            arr[index].Processing = true;
                            Gs.Apis.DownloadApi(api.ApiPath, api.JsonData, api.Filename, api.Binary, api.StorageName, api.WindowFunction, api.Id);
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        case "RunServerPostApi":
                            //(apiPath, jsonData, storageName = null, windowFunction = null )
                            arr[index].Processing = true;
                            Gs.Apis.RunServerPostApi(api.ApiPath, api.JsonData, api.StorageName, api.WindowFunction, api.Id);
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        case "RunServerPutApi":
                            //(apiPath, jsonData, storageName = null, windowFunction = null )
                            arr[index].Processing = true;
                            Gs.Apis.RunServerPutApi(api.ApiPath, api.JsonData, api.StorageName, api.WindowFunction, api.Id);
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        case "RunServerGetApi":
                            //(apiPath, storageName = null, windowFunction = null )
                            arr[index].Processing = true;
                            Gs.Apis.RunServerGetApi(api.ApiPath, api.StorageName, api.WindowFunction, api.Id);
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        case "RunServerDeleteApi":
                            //(apiPath, windowFunction = null )
                            arr[index].Processing = true;
                            Gs.Apis.RunServerDeleteApi(api.ApiPath, api.WindowFunction, api.Id);
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        case "WindowFunction":
                            arr[index].Processing = false;
                            arr[index].Processed = true;
                            try {
                                window[api.WindowFunction]();
                            } catch { }
                            if (arr.length > (index - 1) && arr[index + 1] != undefined && arr[index + 1].Sequence > arr[index].Sequence) { throw new Error("Break ForEach"); }
                            break;
                        default:
                    }
                } catch (e) { }
            }
            processing = arr[index].Processing;
        }
        lastUUID = arr[index].UUID;
    });
}


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
Gs.Apis.DownloadApi = async function (apiPath, jsonData, filename, binary, storageName = null, windowFunction = null, Id = null) {
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
Gs.Apis.RunServerPostApi = async function (apiPath, jsonData, storageName, windowFunction = null, Id = null) {
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
Gs.Apis.RunServerPutApi = async function (apiPath, jsonData, storageName, windowFunction = null, Id = null) {
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }

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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
Gs.Apis.RunServerGetApi = async function (apiPath, storageName, windowFunction = null, Id = null) {
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
Gs.Apis.RunServerDeleteApi = async function (apiPath, windowFunction = null, Id = null) {
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
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
            if (windowFunction != null) { window[windowFunction](); }
            Gs.Behaviors.HidePageLoading();

            if (result.Status == undefined || result.Status == "success") { Gs.Objects.ShowNotify("success", result.Result); return true; }
            else {
                if (windowFunction != null) { window[windowFunction](); }
                Gs.Objects.ShowNotify("alert", result.Status + " " + result.ErrorMessage); return false;
            }
        },
        error: function (err) {
            if (Id != null) { Gs.Variables.apiTaskList.filter(obj => { return obj.Id == Id })[0].Processed = true; }
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
        url: Metro.storage.getItem('ApiOriginSuffix', null) + "PortalApiTableService/GetUserSettingList",
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