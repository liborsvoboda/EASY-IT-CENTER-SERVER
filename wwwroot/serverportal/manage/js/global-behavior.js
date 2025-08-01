// STARTUP Temp Variables Definitions
let pageLoader;

Gs.Behaviors.PortalStartup = function () {
    Gs.Objects.CreateToolPanel();

    Gs.Variables.getSpProcedure[1].tableName = "SolutionMixedEnumList";
    Gs.Apis.RunServerPostApi("DBProcedureService/SpProcedure/GetGenericDataListByParams", Gs.Variables.getSpProcedure, "MixedEnumList");
    Gs.Apis.RunServerGetApi("ServerPortalApi/GetApiTableDataList/PortalMenu", "PortalMenu");

    Gs.Objects.GenerateMenu();
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

Gs.Behaviors.UserChangeTranslateSetting = function () {
    Metro.storage.setItem('UserAutomaticTranslate', $("#UserAutomaticTranslate").val('checked')[0].checked);
    if ($("#UserAutomaticTranslate").val('checked')[0].checked) { Gs.Behaviors.GoogleTranslateElementInit(); } else { Gs.Behaviors.CancelTranslation(); }
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

Gs.Behaviors.CancelTranslation = function () {
    Metro.storage.setItem('UserAutomaticTranslate', false);
    $("#UserAutomaticTranslate")[0].checked = false;

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


//Menu Behaviors
Gs.Behaviors.SetLink = function (htmlContentId, content) {
    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    $("#FrameWindow").load(Metro.storage.getItem('BackendServerAddress', null) + "/" + content)
}

Gs.Behaviors.SetExternalLink = function (htmlContentId, content) {
    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML = 
        JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))[0].ShowMultiWindow == true
            ? document.getElementById("FrameWindow").innerHTML + "<div data-title='" + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + "' data-role='window' data-width='100%' data-height='600' data-draggable='true'> " : ""
    + '<iframe id="IFrameWindow" src="' + content + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';
    + JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))[0].ShowMultiWindow == true ? '</div>' : "";
}

Gs.Behaviors.SetContent = function (htmlContentId, jsContentId, cssContentId) {
    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('Menu', null)));
    Metro.storage.setItem('SelectedMenu', menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);
    document.getElementById("FrameWindow").innerHTML = 
        JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))[0].ShowMultiWindow == true
            ? document.getElementById("FrameWindow").innerHTML + "<div data-title='" + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + "' data-role='window' data-width='100%' data-height='600' data-draggable='true'> " : ""
        + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent
        + JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))[0].ShowMultiWindow == true ? "</div>" : "";

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
    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
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


