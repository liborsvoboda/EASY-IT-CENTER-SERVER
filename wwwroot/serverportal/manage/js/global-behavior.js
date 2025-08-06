// STARTUP Temp Variables Definitions
let pageLoader;

Gs.Behaviors.PortalStartup =async function () {
    Gs.Objects.CreateToolPanel();

    Gs.Variables.getSpProcedure[1].tableName = "SolutionMixedEnumList";
    await Gs.Apis.RunServerPostApi("DBProcedureService/SpProcedure/GetGenericDataListByParams", Gs.Variables.getSpProcedure, "MixedEnumList");
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetApiTableDataList/PortalMenu", "PortalMenu");

    Gs.Objects.GenerateMenu();
    Gs.Behaviors.LoadUserSettings();
}


/*Start of Global Loading Indicator for All Pages*/
Gs.Behaviors.HidePageLoading = function () { Metro.activity.close(pageLoader); }
Gs.Behaviors.ShowPageLoading = function () {
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








Gs.Behaviors.GetGoogleOptionLanguageIndex = function (optionValue) {
    let options = Array.from(document.getElementsByClassName("goog-te-combo")[0].options);
    return options.findIndex((opt) => opt.value == optionValue);
}

Gs.Behaviors.GoogleTranslateElementInit = function () {
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'en', //includedLanguages: 'en,cs',
            layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
            autoDisplay: false
        }, 'google_translate_element');

        let autoTranslateSetting = JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null))).EnableAutoTranslate == null || JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null))).EnableAutoTranslate == false ? false : true;
        if (autoTranslateSetting && document.querySelector('#google_translate_element select') != null) {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.value = Metro.storage.getItem('DetectedLanguage', null);
                selectElement.dispatchEvent(new Event('change'));
            }, 1000);
        }
    });
}

Gs.Behaviors.CancelTranslation = function () {
    let userSetting = JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)));
    userSetting.EnableAutoTranslate = false;
    $("#EnableAutoTranslate")[0].checked = userSetting.EnableAutoTranslate;
    Metro.storage.setItem('UserSettingList', userSetting);
    

    setTimeout(function () {
        let selectElement = document.querySelector('#google_translate_element select');
        if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
            selectElement.selectedIndex = 0; Gs.Objects.ShowToolPanel();
        } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
        selectElement.dispatchEvent(new Event('change'));
        if (selectElement.value != '') {
            setTimeout(function () {
                if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
                    selectElement.selectedIndex = 0; Gs.Objects.ShowToolPanel();
                } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
                selectElement.dispatchEvent(new Event('change'));
                if (selectElement.value != '') {
                    setTimeout(function () {
                        if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
                            selectElement.selectedIndex = 0; Gs.Objects.ShowToolPanel();
                        } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
                        selectElement.dispatchEvent(new Event('change'));
                    }, 2000);
                }
            }, 2000);
        }
    }, 1000);
}


Gs.Behaviors.ScrollToTop = function () { window.scrollTo(0, 0); }
Gs.Behaviors.EnableScroll = function () { window.onscroll = function () { }; }
Gs.Behaviors.DisableScroll = function () {
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
        window.onscroll = function () { window.scrollTo(scrollLeft, scrollTop); };
}


Gs.Behaviors.LoadUserSettings = function () {
    Gs.Behaviors.ElementSetCheckBox("#EnableAutoTranslate", Gs.Variables.UserSettingList.EnableAutoTranslate);
    Gs.Behaviors.ElementSetCheckBox("#EnableShowDescription", Gs.Variables.UserSettingList.EnableShowDescription);
    Gs.Behaviors.ElementSetCheckBox("#RememberLastHandleBar", Gs.Variables.UserSettingList.RememberLastHandleBar);
    Gs.Behaviors.ElementSetCheckBox("#RememberLastJson", Gs.Variables.UserSettingList.RememberLastJson);
}


Gs.Behaviors.BeforeSetMenu = function (htmlContentId) {
    Gs.Variables.monacoEditorList = [];

    //set 
    Gs.Behaviors.LoadUserSettings();
    //and reset menu data
    if (!Metro.storage.getItem('UserSettingList', null).RememberLastHandleBar) { Metro.storage.delItem("HandlebarCode"); }
    if (!Metro.storage.getItem('UserSettingList', null).RememberLastJson) { Metro.storage.delItem("JsonGeneratorService"); }
    Metro.storage.delItem("SelectedMenuId");
    Metro.storage.delItem('ApiTableList');
    Metro.storage.delItem("SelectedMenu");
    

    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);
    return menu;
}


//Menu Behaviors
Gs.Behaviors.SetLink = function (htmlContentId, content) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    $("#FrameWindow").load(Metro.storage.getItem('ApiOriginSuffix', null) + content)
}


Gs.Behaviors.SetExternalLink = function (htmlContentId, content) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    document.getElementById("FrameWindow").innerHTML = '<div id=MainWindow data-role="window" data-custom-buttons="WindowButtons" data-icon="<span class=\'' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Icon + '\'></spam>" data-title="' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + '" class="h-100" data-btn-close="false" data-btn-min="false" data-btn-max="false" data-width="100%" data-height="800" data-draggable="false" >'
    + '<iframe id="IFrameWindow" src="' + content + '" width="100%" height="700" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe></div>';
}


Gs.Behaviors.SetContent = function (htmlContentId, jsContentId, cssContentId) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    document.getElementById("FrameWindow").innerHTML =
        '<div id=MainWindow data-role="window" data-custom-buttons="WindowButtons" data-icon="<span class=\'' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Icon + '\'></spam>" data-title="' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + '" data-btn-close="false" class="h-100" data-btn-min="false" data-btn-max="false" data-width="100%" data-height="800" data-draggable="false" >'
         + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent;

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
Gs.Behaviors.SetExternalContent = function (htmlContentId, jsContentId, cssContentId) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    document.getElementById("FrameWindow").innerHTML = '<iframe id="IFrameWindow" src="' + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';

    if (menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent != null) {
        let script = "<script id='InheritScript' charset='utf-8' type='text/javascript'> " + menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent + " </script>";
        $("#IFrameWindow").contents().find("body").append(script);
    }
    if (menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent != null) {
        let style = document.createElement('style'); style.id = "InheritStyle";
        style.innerText = menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent;
        let iframeHead = document.getElementById('IFrameWindow').contentWindow.document.head;
        iframeHead.appendChild(style);
    }
}


Gs.Behaviors.ElementExpand = function (elementId) {
    try {
        let el = Metro.getPlugin('#' + elementId, 'collapse');
        let elStatus = el.isCollapsed();
        if (elStatus) { el.expand(); } else { el.collapsed(); }
    } catch { }
}


Gs.Behaviors.ElementShowHide = function (elementId, showOnly = false) {
    try {
        let el = Metro.get$el('#' + elementId);
        if (showOnly) { el.show(); }
        else if (el.style("display") == "none") { el.show(); } else { el.hide(); }
    } catch { }
}


Gs.Behaviors.ElementSetCheckBox = function (elementId, val) {
    try {
        $('#' + elementId).val('checked')[0].checked = JSON.parse((val.toString().toLowerCase()));
    } catch { }
}


Gs.Behaviors.ElementSetActive = function (elementId) {
    try {
        $('#' + elementId).addClass(" active ");
    } catch { }
}


Gs.Behaviors.ElementAddClass = function (elementId,className) {
    try {
        $('#' + elementId).addClass(" " + className + " ");
    } catch { }
}

Gs.Behaviors.ElementRemoveClass = function (elementId, className) {
    try {
        $('#' + elementId).removeClass(className);
    } catch { }
}

Gs.Behaviors.InfoBoxOpenClose = function (elementId) {
    try {
        if (Metro.infobox.isOpen('#' + elementId)) { Metro.infobox.close('#' + elementId); }
        else { Metro.infobox.open('#' + elementId); }
    } catch { }
}


Gs.Behaviors.SetUserSettings = function () {
    let userSetting = JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))
    userSetting.EnableAutoTranslate = $("#EnableAutoTranslate").val('checked')[0].checked;
    userSetting.EnableShowDescription = $("#UserSetEnableShowDesc")[0].checked;
    userSetting.RememberLastHandleBar = $("#RememberLastHandleBar")[0].checked;
    userSetting.RememberLastJson = $("#RememberLastJson")[0].checked;


    Metro.storage.setItem('UserSettingList', userSetting);
    if ($("#EnableAutoTranslate").val('checked')[0].checked) { Gs.Behaviors.GoogleTranslateElementInit(); } else { Gs.Behaviors.CancelTranslation(); }
}


Gs.Behaviors.SignOut = function () {
    Metro.storage.delItem('ApiToken');
    Cookies.set('ApiToken', null);
    window.location.href = Metro.storage.getItem("DefaultPath", null);
}


Gs.Behaviors.ShowWindowCode = function () {
    if (document.getElementById("IFrameWindow") == null) {
        Gs.Functions.ShowSource();
    } else { Gs.Functions.ShowFrameSource(); }



}
