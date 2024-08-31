//Global API library 
 
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