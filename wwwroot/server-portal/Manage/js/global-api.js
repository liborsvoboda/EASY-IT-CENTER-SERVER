
let ApiList = [
	
];


//Run POST Api Request 
function RunServerPostApi(authRequired, apiPath, jsonData) {
    showPageLoading();
    var def = $.ajax({
        global: false, type: "POST", url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        headers: authRequired ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null) } : { 'Content-type': 'application/json' },
        data: JSON.stringify(jsonData)
    });

    def.fail(function (err) {
        notify.create(apiMessages.apiSaveFail, "Alert", { cls: "alert" }); notify.reset();
        hidePageLoading();
        return false;
    });

    def.done(function (data) {
        notify.create(apiMessages.apiSaveSuccess, "Info", { cls: "success" }); notify.reset();
        hidePageLoading();
        return true;
    });
}

//Run GET Api Request 
function RunServerGetApi(authRequired, apiPath, storageName) {
    showPageLoading();
    $.ajax({
        url: Metro.storage.getItem('ApiOriginSuffix', null) + apiPath, dataType: 'json',
        type: "GET",
        headers: authRequired ? { 'Content-type': 'application/json', 'Authorization': 'Bearer ' + Metro.storage.getItem('ApiToken', null) } : { 'Content-type': 'application/json' },
        success: function (apiData) {
            Metro.storage.setItem(storageName, JSON.parse(JSON.stringify(apiData)));
            notify.create(apiMessages.apiLoadSuccess, "Info", { cls: "success" }); notify.reset();
            hidePageLoading();
            return true;
        },
        error: function (error) {
            Metro.storage.setItem(storageName, null);
            notify.create(apiMessages.apiLoadFail, "Alert", { cls: "alert" }); notify.reset();
            hidePageLoading();
        }
    });
}

