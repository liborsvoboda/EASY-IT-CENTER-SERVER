// STARTUP Temp Variables Definitions
let pageLoader;

function PortalStartup() {
    CreateToolPanel();

    getSpProcedure[1].tableName = "SolutionMixedEnumList";
    RunServerPostApi(false, "DBProcedureService/SpProcedure/GetGenericDataListByParams", getSpProcedure, "MixedEnumList");
    RunServerGetApi(false, "ServerPortalApi/GetApiTableDataList/PortalMenu", "PortalMenu");
   
    GenerateMenu();
}


/*Start of Global Loading Indicator for All Pages*/
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

function UserChangeTranslateSetting() {
    Metro.storage.setItem('UserAutomaticTranslate', $("#UserAutomaticTranslate").val('checked')[0].checked);
    if ($("#UserAutomaticTranslate").val('checked')[0].checked) { GoogleTranslateElementInit(); } else { CancelTranslation(); }
}


function ChangeSchemeTo(n) {
    $("#AppPanel").css({ backgroundColor: n.split("?")[1] });
    $("#portal-color-scheme").attr("href", window.location.origin + "/server-integrated/razor-pages/serverportal/metro/css/schemes/" + n.split("?")[0]);
    $("#scheme-name").html(n.split("?")[0]);
    Metro.storage.setItem('WebScheme', n.split("?")[0]);
}


function ShowToolPanel(close) {
    $("#UserAutomaticTranslate").val('checked')[0].checked = Metro.storage.getItem('UserAutomaticTranslate', null);
    if (close) { Metro.bottomsheet.close($('#ToolPanel')); } else {
        if (Metro.bottomsheet.isOpen($('#ToolPanel'))) { Metro.bottomsheet.close($('#ToolPanel')); }
        else { Metro.bottomsheet.open($('#ToolPanel')); }
    }
}


function GetGoogleOptionLanguageIndex(optionValue) {
    let options = Array.from(document.getElementsByClassName("goog-te-combo")[0].options);
    return options.findIndex((opt) => opt.value == optionValue);
}

function GoogleTranslateElementInit() {
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'en', //includedLanguages: 'en,cs',
            layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
            autoDisplay: false
        }, 'google_translate_element');

        let autoTranslateSetting = Metro.storage.getItem('UserAutomaticTranslate', null) == null || Metro.storage.getItem('UserAutomaticTranslate', null) == false ? false : true;
        if (autoTranslateSetting && document.querySelector('#google_translate_element select') != null) {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.value = Metro.storage.getItem('DetectedLanguage', null);
                selectElement.dispatchEvent(new Event('change'));
            }, 1000);
        }
    });
}

function CancelTranslation() {
    Metro.storage.setItem('UserAutomaticTranslate', false);
    $("#UserAutomaticTranslate")[0].checked = false;

    setTimeout(function () {
        let selectElement = document.querySelector('#google_translate_element select');
        if (GetGoogleOptionLanguageIndex("") == 0) {
            selectElement.selectedIndex = 0; ShowToolPanel();
        } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
        selectElement.dispatchEvent(new Event('change'));
        if (selectElement.value != '') {
            setTimeout(function () {
                if (GetGoogleOptionLanguageIndex("") == 0) {
                    selectElement.selectedIndex = 0; ShowToolPanel();
                } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
                selectElement.dispatchEvent(new Event('change'));
                if (selectElement.value != '') {
                    setTimeout(function () {
                        if (GetGoogleOptionLanguageIndex("") == 0) {
                            selectElement.selectedIndex = 0; ShowToolPanel();
                        } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
                        selectElement.dispatchEvent(new Event('change'));
                    }, 2000);
                }
            }, 2000);
        }
    }, 1000);
}




function ScrollToTop() { window.scrollTo(0, 0); }
function enableScroll() { window.onscroll = function () { }; }
function disableScroll() {
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
        window.onscroll = function () { window.scrollTo(scrollLeft, scrollTop); };
}



function SetLink(htmlContentId, content) {
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    $("#FrameWindow").load(Metro.storage.getItem('BackendServerAddress', null) + "/" + content)
}

function SetExternalLink(htmlContentId, content) {
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML = '<iframe id="IFrameWindow" src="' + Metro.storage.getItem('BackendServerAddress', null) + "/" + content + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';
}

function SetContent(htmlContentId, jsContentId, cssContentId) {
    removeElement("InheritScript"); removeElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);
    document.getElementById("FrameWindow").innerHTML = menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent;

    if (menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent != null) {
        let script = "<script id='InheritScript' charset='utf-8' type='text/javascript'> " + menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent + " </script>";
        $('body').append(script);
    }
    if (menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent != null) {
        let style = document.createElement('style'); style.id = "InheritStyle";
        style.innerText = menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent;
        document.head.appendChild(style);
    }
    
}

//TODO to IFRAME
function SetExternalContent(htmlContentId, jsContentId, cssContentId) {
    removeElement("InheritScript"); removeElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML = '<iframe id="IFrameWindow" src="' + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';

    if (menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent != null) {
        let script = "<script id='InheritScript' charset='utf-8' type='text/javascript'> " + menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent + " </script>";
        $("#IFrameWindow").contents().find("body").append(script)
    }
    if (menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent != null) {
        let style = document.createElement('style'); style.id = "InheritStyle";
        style.innerText = menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent;
        let iframeHead = document.getElementById('IFrameWindow').contentWindow.document.head;
        iframeHead.appendChild(style);
    }
}


function ShowMessagePanel(close) {
    charms = Metro.getPlugin($("#charmPanel"), 'charms');
    if (close) {
        charms.close();
    } else { charms.toggle(); }
}