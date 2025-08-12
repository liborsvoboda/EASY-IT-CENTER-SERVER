//Web Login for Users API
async function FloatingLogin() {
    window.showPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiRootUrl', null) + '/Guest/WebLogin', {
        method: 'POST',
        headers: { 'Authorization': 'Basic ' + btoa($("#FloatingLoginEmail").val() + ":" + $("#FloatingLoginPassword").val()), 'Content-type': 'application/json' },
        body: JSON.stringify({ language: Metro.storage.getItem('WebPagesLanguage', null) })
    }); let result = await response.json();

    window.hidePageLoading();
    if (result.message) { ShowNotify('error', result.message); }
    else {
        $("#FloatingLoginForm").hide();
        Metro.storage.setItem('Token', result.Token); Metro.storage.setItem('LoggedUser', result);
        window.watchGlobalVariables.modalLogin = true;
    }
}


//Send Discussion Contribution API
async function SendDiscussionContribution() {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/MessageModule/SetDiscussionContribution', {
        method: 'POST', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' },
        body: JSON.stringify({ ParentId: $("#newDiscussionSelectionList").val(), Subject: $("#newDiscussionTitle").val(), Message: $("#newDiscussionSummernote").summernote('code'), Language: Metro.storage.getItem('WebPagesLanguage', null) })
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchGlobalVariables.reloadDiscussionForum = true; }
    window.hidePageLoading();
}


//Send Private Message Answer API
async function SendPrivateMessageAnswer(parentId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/MessageModule/SetPrivateMessageAnswer', {
        method: 'POST', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' },
        body: JSON.stringify({ ParentId: parentId, Message: $("#messageSummernote_" + parentId).summernote('code'), Language: Metro.storage.getItem('WebPagesLanguage', null) })
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchGlobalVariables.reloadPrivateMessage = true; }
    window.hidePageLoading();
}


//Archive Private Message Tree API
async function ArchivePrivateMessage(messageId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/MessageModule/ArchivePrivateMessage/' + messageId + "/" + Metro.storage.getItem('WebPagesLanguage', null), {
        method: 'GET', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchGlobalVariables.reloadPrivateMessage = true; }
    window.hidePageLoading();
}


//Set As Readed Specific Private Message API
async function SetShownPrivateMessage(messageId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/MessageModule/SetShownPrivateMessage/' + messageId + "/" + Metro.storage.getItem('WebPagesLanguage', null), {
        method: 'GET', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchGlobalVariables.reloadPrivateMessage = true; }
    window.hidePageLoading();
}


//Set Comment Status API 
async function setCommentStatus(commentId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/Advertiser/SetCommentStatus/' + commentId + '/' + Metro.storage.getItem('WebPagesLanguage', null), {
        method: 'GET', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchAdvertisementVariables.reloadAdvertisement = true; }
    window.hidePageLoading();
};


//Delete Comment Status API 
async function deleteComment(commentId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/Advertiser/DeleteComment/' + commentId + '/' + Metro.storage.getItem('WebPagesLanguage', null), {
        method: 'GET', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchAdvertisementVariables.reloadAdvertisement = true; }
    window.hidePageLoading();
};


//Delete Advertiser UnAvailable Room Setting API 
async function deleteUnavailableRoom(recId) {
    window.showPageLoading();
    let response = await fetch(
        Metro.storage.getItem('ApiRootUrl', null) + '/Advertiser/DeleteUnavailableRoom/' + recId + '/' + Metro.storage.getItem('WebPagesLanguage', null), {
        method: 'GET', headers: { 'Authorization': 'Bearer ' + Metro.storage.getItem('Token', null), 'Content-type': 'application/json' }
    }); let result = await response.json();
    if (result.Status == "error") {
        ShowNotify('error', result.ErrorMessage);
    } else { window.watchAdvertisementVariables.reloadUnavailable = true; }
    window.hidePageLoading();
};


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



function Test() {
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

 
async function SendMessage() {
    showPageLoading();

    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + '/WebPages/InsertMessage', {
        method: 'POST', headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json',
        },
        body: JSON.stringify({ message: $("#NewMessage").val() })

    });
    let result = await response.json();
    if (result.status == "error") {
        var notify = Metro.notify; notify.setup({ width: 300, duration: 1000, animation: 'easeOutBounce' });
        notify.create("Sending Messages Failed", "Alert", { cls: "alert" }); notify.reset();
        hidePageLoading();
    } else {
        var notify = Metro.notify; notify.setup({ width: 300, duration: 1000, animation: 'easeOutBounce' });
        notify.create("Děkuji za Zprávu", "Info", { cls: "success" }); notify.reset();
        $("#NewMessage").val(null);
        hidePageLoading();
        GetMessages();
    }
}

async function GetMessages() {
    showPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + '/WebPages/GetMessageList', {
        method: 'GET', headers: { 'Content-type': 'application/json'}
    });
    let result = await response.json();
    if (result.status == "error") {
        var notify = Metro.notify; notify.setup({ width: 300, duration: 1000, animation: 'easeOutBounce' });
        notify.create("Downloading Messages Failed", "Alert", { cls: "alert" }); notify.reset();
        hidePageLoading();
    } else {
        data = JSON.parse(JSON.stringify(result));

        let messageData = "";
        data.forEach(message => {
            messageData += "<div class=\"card image-header\"><div class=\"card-content p-2 op-lightBrown-low\"><p class=\"fg-black\">" + message.Name + "</p>" + JSON.stringify(message.Description) + "</div></div>";
        });
        $("#MessageBox").html(messageData);
        hidePageLoading();
    }
}

function GetNewsList() {
    if (Metro.storage.getItem('NewsList', null) == null) {
        showPageLoading();
        $.ajax({
            url: Metro.storage.getItem('ApiOriginSuffix', null) + '/WebPages/GetNewsList', dataType: 'json',
            type: "GET",
            headers: { 'Content-type': 'application/json' },
            success: function (data) {
                data = JSON.parse(JSON.stringify(data));
                Metro.storage.setItem('NewsList', data);
                let messageData = "";
                data.forEach(message => {
                    messageData += "<div class=\"card image-header\"><div class=\"card-content p-2\"><p class=\"fg-black\"><b>" + new Date(message.timeStamp).toLocaleDateString() + "</b> " + message.title + "</p>" + message.description + "</div></div>";
                });
                $("#NewsListBox").html(messageData);
                Metro.infobox.open('#NewsInfoBox');
                hidePageLoading();
            },
            error: function (error) {
                var notify = Metro.notify; notify.setup({ width: 300, duration: 1000, animation: 'easeOutBounce' });
                notify.create("Downloading Messages Failed", "Alert", { cls: "alert" }); notify.reset();
                hidePageLoading();
            }
        });
    } else {
        let data = Metro.storage.getItem('NewsList', null);
        let messageData = "";
        data.forEach(message => {
            messageData += "<div class=\"card image-header\"><div class=\"card-content p-2\"><p class=\"fg-black\"><b>" + new Date(message.timeStamp).toLocaleDateString() + "</b> " + message.title + "</p>" + message.description + "</div></div>";
        });
        $("#NewsListBox").html(messageData);
        Metro.infobox.open('#NewsInfoBox');
    }
}