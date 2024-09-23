let pageLoader;


function ScrollToTop() { window.scrollTo(0, 0); }
function enableScroll() { window.onscroll = function () { }; }
function disableScroll() {
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
        window.onscroll = function () { window.scrollTo(scrollLeft, scrollTop); };
}

function hidePageLoading() { Metro.activity.close(pageLoader); }
function showPageLoading() {
    if (pageLoader != undefined) {
        if (pageLoader[0]["DATASET:UID:M4Q"] == undefined) { pageLoader = null; }
        else {
            try { Metro.activity.close(pageLoader); } catch {
                try { pageLoader.close(); } catch { pageLoader = pageLoader[0]["DATASET:UID:M4Q"].dialog; pageLoader.close(); }; pageLoader = null;
            }
        }
    }
    pageLoader = Metro.activity.open({ type: 'atom', style: 'dark', overlayClickClose: true, /*overlayColor: '#fff', overlayAlpha: 1*/ });
}



function googleTranslateElementInit() {

    Metro.storage.setItem('DetectedLanguage', (navigator.language || navigator.userLanguage).substring(0, 2));
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'cs', //includedLanguages: 'en,cs',
            layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
            autoDisplay: false
        }, 'google_translate_element');

    
        setTimeout(function () {
            let selectElement = document.querySelector('#google_translate_element select');
            selectElement.value = Metro.storage.getItem('DetectedLanguage', null);
            selectElement.dispatchEvent(new Event('change'));
        }, 1000);


        /*
        let userTranslateSetting = Metro.storage.getItem('UserAutomaticTranslate', null) != null && Metro.storage.getItem('UserAutomaticTranslate', null) ? true : false;
        if (userTranslateSetting && document.querySelector('#google_translate_element select') != null) {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.value = "nemam";
                selectElement.dispatchEvent(new Event('change'));
            }, 1000);
        }*/


    });
}

function CancelTranslation() {
    setTimeout(function () {
        let selectElement = document.querySelector('#google_translate_element select');
        selectElement.selectedIndex = 1;
        selectElement.dispatchEvent(new Event('change'));
        if (selectElement.value != '') {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.selectedIndex = 0;
                selectElement.dispatchEvent(new Event('change'));
                if (selectElement.value != '') {
                    setTimeout(function () {
                        let selectElement = document.querySelector('#google_translate_element select');
                        selectElement.selectedIndex = 0;
                        selectElement.dispatchEvent(new Event('change'));
                    }, 2000);
                }
            }, 2000);
        }
    }, 1000);
}

function loadPage(url) {
    $.ajax({
        url: url
    }).done(function (data) {
        $('#frameWindow').html(data);
    });
}

//function calcHeight(iframeElement) {
//    var the_height = iframeElement.contentWindow.document.body.scrollHeight;
//    iframeElement.height = the_height;
//}

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

//Get Messages
/*
async function GetMessages() {
    showPageLoading();
    let response = await fetch(Metro.storage.getItem('ApiOriginSuffix', null) + '/WebPages/GetMessageList', {
        method: 'GET', headers: {
            'Content-type': 'application/json'
        }
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
*/

function ShowMessagePanel(close) {
    OpenCharm(0);
    charms = Metro.getPlugin($("#charmPanel"), 'charms');
    if (close) {
        charms.close();
    } else { charms.toggle(); }
}

let LastMovedCharm = 0;
function OpenCharm(index) {

   
    if (!Metro.charms.isOpen("#Metro" + index + "Charm") && index > 0) {
        Metro.charms.toggle("#Metro" + index + "Charm");
    } else {
        Metro.charms.close("#Metro2Charm");
        Metro.charms.close("#Metro3Charm");
        Metro.charms.close("#Metro4Charm");
        Metro.charms.close("#Metro5Charm");
        Metro.charms.close("#Metro6Charm");
        Metro.charms.close("#Metro7Charm");
        Metro.charms.close("#Metro8Charm");
        Metro.charms.close("#Metro9Charm");
        Metro.charms.close("#Metro10Charm");
        Metro.charms.close("#Metro11Charm");
        Metro.charms.close("#Metro12Charm");
        Metro.charms.close("#Metro13Charm");
        Metro.charms.close("#Metro14Charm");
        Metro.charms.close("#Metro15Charm");
        Metro.charms.close("#Metro16Charm");
        Metro.charms.close("#Metro17Charm");
        Metro.charms.close("#Metro18Charm");
        Metro.charms.close("#Metro19Charm");
        Metro.charms.close("#Metro20Charm");


        if (LastMovedCharm != index) { Metro.charms.toggle("#Metro" + index + "Charm"); }
    } LastMovedCharm = index;
}

//Get NewsList
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
