// STARTUP Temp Variables Definitions
let pageLoader;

const urlParams = new URLSearchParams(window.location.search);
const StripePayed = urlParams.get('Payed');
const currentMenu = unescape(document.URL.split('#')[1]).replaceAll(/\s/g, '');


/**
 * Autop Service is for Automatic Solve Functions, and Operations on Background
 * Add Auto Solutions Here
 * Example Auto API, Prepare Data,
  * @function
 */
Gs.Behaviors.AutoService = function () {
    try {
        setTimeout(function () {
            //Auto API
            if (Gs.Variables.apiTaskList.length > 0) { Gs.Apis.RunApiManager(); }
            

            Gs.Behaviors.AutoService();
        }, 1000);
    } catch { Gs.Behaviors.AutoService(); }
}


/**
 *Portal StartUp Function
  * @function
 */
Gs.Behaviors.PortalStartup = async function () { //LOGGED

    //STARTUP
    /* Generate WebBrowserConsole */
    Gs.Objects.OpenBrowserConsole(); Metro.window.hide($("#WebBrowserConsole"));




    //STARTUP

    if (Metro.storage.getItem("ApiToken", null) != null) {
        Cookies.set("ApiToken", Metro.storage.getItem("ApiToken", null).Token);
        Gs.Variables.username = Metro.storage.getItem("ApiToken", null).Username;
        Gs.Variables.fullname = Metro.storage.getItem("ApiToken", null).Name + " " + Metro.storage.getItem("ApiToken", null).SurName;
        $("#LoginName").html(Metro.storage.getItem("ApiToken", null).Username);
        let html = `<button class="button mr-1">Profile</button>
                    <button class="button ml-1" onclick=Gs.Apis.SignOut(); >Sign out</button>`;
        $("#LoginReaction").html(html);

        await LoadFavorites();

    } else { //NOT LOGGED 
        Cookies.remove("ApiToken"); Metro.storage.delItem("ApiToken");
        Gs.Functions.GetPublicIp(); Gs.Variables.fullname = "Anonymous";
        $("#LoginName").html("Login");
        Gs.Functions.AddClass("LoginName", "ani-shuttle");
        let html = `<button class="button mr-1" onclick=Gs.Objects.ShowLoginPage(); >Login</button>
                    <button class="button ml-1" onclick=Gs.Objects.ShowRegistrationPage(); >Registration</button>`;
        $("#LoginReaction").html(html);
    }

    Gs.Objects.CreateToolPanel();


    Gs.Variables.getSpProcedure[1].tableName = "SolutionMixedEnumList";
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure)), StorageName: "SolutionMixedEnumList" } );
    Gs.Variables.getSpProcedure[1].tableName = "SolutionMonacoSuggestionList";
    Gs.Variables.getSpProcedure[2].camelCase = true;
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure)), StorageName: "MonacoSuggestionList" } );
    Gs.Variables.getSpProcedure[2].camelCase = false;
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerGetApi", ApiPath: "PortalApiTableService/GetQuestionForResponseList", StorageName: "AdminQuestionList", WindowFunction: "SetQuestionCount" } );
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerGetApi", ApiPath: "PortalApiTableService/GetApiTableDataList/PortalMenu", StorageName: "PortalMenuList", WindowFunction: "GenerateMenuList" } );
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerGetApi", ApiPath: "InformationService/GetVersion", StorageName: "ServerVersion" } );
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerGetApi", ApiPath: "InformationService/GetStripePublicKey", StorageName: "StripePublicKey", WindowFunction: "SetStripeKey" } );
    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(),  Id: Gs.Functions.RandomString(), Sequence: 0, Type: "WindowFunction", WindowFunction: "LoadOnlineToolList" } );

    //Check Stripe Payment
    if (StripePayed != null && StripePayed) {
        const url = new URL(location);
        url.searchParams.delete('Payed');
        history.replaceState(null, null, url);
        Gs.Objects.DownloadBasket();
    }

    $(document).ready(function () {
        setTimeout(function () {
            Gs.Functions.GetFunctionList();
            Gs.Behaviors.RefreshBasket();
        
            if (!Gs.Apis.IsLogged()) {
                Gs.Functions.AddClass("ShareMainButton", "disabled");
                Gs.Behaviors.LoadUserSettings();
            } else {
                Gs.Functions.RemoveClass("ShareMainButton", "disabled");
                Gs.Apis.GetUserSetting();

            }
        }, 3000);
    }); 
    
}

/**
 *Hide Page Loading
  * @function
 */
Gs.Behaviors.HidePageLoading = function () { Metro.activity.close(Gs.Variables.pageLoader); }

/**
 *Show Page Loading
  * @function
 */
Gs.Behaviors.ShowPageLoading = function () {
    if (Gs.Variables.pageLoader != undefined) {
        if (Gs.Variables.pageLoader[0]["DATASET:UID:M4Q"] == undefined) { Gs.Variables.pageLoader = null; }
        else {
            try { Metro.activity.close(Gs.Variables.pageLoader); } catch {
                try { Gs.Variables.pageLoader.close(); } catch { Gs.Variables.pageLoader = Gs.Variables.pageLoader[0]["DATASET:UID:M4Q"].dialog; Gs.Variables.pageLoader.close(); }; Gs.Variables.pageLoader = null;
            }
        }
    }
    Gs.Variables.pageLoader = Metro.activity.open({ type: 'square', style: 'color', overlayClickClose: true, /*overlayColor: '#fff', overlayAlpha: 1*/ });
}


/**
 *Get Google Option Language Index
  * @function
 */
Gs.Behaviors.GetGoogleOptionLanguageIndex = function (optionValue) {
    if (document.querySelector('#google_translate_element select') != null) {
        let options = Array.from(document.getElementsByClassName("goog-te-combo")[0].options);
        return options.findIndex((opt) => opt.value == optionValue);
    } else { return 0; }
}

/**
 *Google Translate Element Init
  * @function
 */
Gs.Behaviors.GoogleTranslateElementInit = function () {
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'en', //includedLanguages: 'en,cs',
            layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
            autoDisplay: false
        }, 'google_translate_element');

        let autoTranslateSetting = Metro.storage.getItem('UserSettingList', null).EnableAutoTranslate == null || Metro.storage.getItem('UserSettingList', null).EnableAutoTranslate == false ? false : true;
        if (autoTranslateSetting && document.querySelector('#google_translate_element select') != null) {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.value = Metro.storage.getItem('DetectedLanguage', null);
                selectElement.dispatchEvent(new Event('change'));
            }, 1000);
        }
    });
}

/**
 *Cancel Google Translation
  * @function
 */
Gs.Behaviors.CancelTranslation = async function (cancel) {
    if (cancel) {
        let userSettingList = Metro.storage.getItem('UserSettingList', null);
        let translateActive = userSettingList.EnableAutoTranslate;
        Gs.Variables.UserSettingList.EnableAutoTranslate = userSettingList.EnableAutoTranslate = false;
        Metro.storage.setItem('UserSettingList', userSettingList);
        Gs.Behaviors.ElementSetCheckBox("EnableAutoTranslate", Gs.Variables.UserSettingList.EnableAutoTranslate);
        if (translateActive && Gs.Apis.IsLogged()) {//on disabling translation Save UserSettingList
            await Gs.Apis.RunServerPostApi("PortalApiTableService/SetUserSettingList", Metro.storage.getItem("UserSettingList", null), null);
        }
    }
    if (document.querySelector('#google_translate_element select') != null) {
        setTimeout(function () {
            let selectElement = document.querySelector('#google_translate_element select');
            if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
                selectElement.selectedIndex = 0; 
            } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
            selectElement.dispatchEvent(new Event('change'));
            if (selectElement.value != '') {
                setTimeout(function () {
                    if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
                        selectElement.selectedIndex = 0; 
                    } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
                    selectElement.dispatchEvent(new Event('change'));
                    if (selectElement.value != '') {
                        setTimeout(function () {
                            if (Gs.Behaviors.GetGoogleOptionLanguageIndex("") == 0) {
                                selectElement.selectedIndex = 0; 
                            } else { selectElement.selectedIndex = Gs.Behaviors.GetGoogleOptionLanguageIndex("en"); }
                            selectElement.dispatchEvent(new Event('change'));
                        }, 2000);
                    }
                }, 2000);
            }
        }, 1000);
    }
}

/**
 *Scroll To Bottom
  * @function
 */
Gs.Behaviors.ScrollToBottom = function () { window.scrollTo(0, document.body.scrollHeight); }

/**
 *Scroll To Top
  * @function
 */
Gs.Behaviors.ScrollToTop = function () { window.scrollTo(0, 0); }

/**
 *Enable Scroll
  * @function
 */
Gs.Behaviors.EnableScroll = function () { window.onscroll = function () { }; }

/**
 *Disable Scroll
  * @function
 */
Gs.Behaviors.DisableScroll = function () {
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
        window.onscroll = function () { window.scrollTo(scrollLeft, scrollTop); };
}

/**
 *Set User Settings
  * @function
 */
Gs.Behaviors.SetUserSettings = async function () {
    let userSetting = JSON.parse(JSON.stringify(Metro.storage.getItem('UserSettingList', null)))
    userSetting.EnableAutoTranslate = $("#EnableAutoTranslate")[0].checked;
    userSetting.EnableShowDescription = $("#EnableShowDescription")[0].checked;
    userSetting.RememberLastHandleBar = $("#RememberLastHandleBar")[0].checked;
    userSetting.RememberLastJson = $("#RememberLastJson")[0].checked;
    userSetting.EnableScreenSaver = $("#EnableScreenSaver")[0].checked;

    Metro.storage.setItem('UserSettingList', userSetting);Gs.Variables.UserSettingList = userSetting;

    //reset UserSetting Data
    if (!Metro.storage.getItem('UserSettingList', null).RememberLastHandleBar) { Metro.storage.delItem("HandlebarCode"); }
    if (!Metro.storage.getItem('UserSettingList', null).RememberLastJson) { Metro.storage.delItem("JsonGeneratorService"); }

    //Save UserSettingList
    if (Gs.Apis.IsLogged()) {
        await Gs.Apis.RunServerPostApi("PortalApiTableService/SetUserSettingList", Metro.storage.getItem("UserSettingList", null), null);
    }

    if ($("#EnableAutoTranslate").val('checked')[0].checked) { Gs.Behaviors.GoogleTranslateElementInit(); } else { Gs.Behaviors.CancelTranslation(false); }
    if ($("#EnableScreenSaver").val('checked')[0].checked && document.getElementById("ScreenSaver") == null) {
        Gs.Variables.screensaver = new Screensaver({
            secondsInactive: 60,
            speed: 1.5,
            logo: "/server-portal/images/logo.png",
            disabledWhenUsingIframes: false,
        });
    } else if (!$("#EnableScreenSaver").val('checked')[0].checked) { Gs.Variables.screensaver = {}; Gs.Functions.RemoveElement("ScreenSaver"); }
}

/**
 *Load User Settings
  * @function
 */
Gs.Behaviors.LoadUserSettings = function () {
    Gs.Behaviors.ElementSetCheckBox("EnableAutoTranslate", Gs.Variables.UserSettingList.EnableAutoTranslate);
    Gs.Behaviors.ElementSetCheckBox("EnableShowDescription", Gs.Variables.UserSettingList.EnableShowDescription);
    Gs.Behaviors.ElementSetCheckBox("RememberLastHandleBar", Gs.Variables.UserSettingList.RememberLastHandleBar);
    Gs.Behaviors.ElementSetCheckBox("RememberLastJson", Gs.Variables.UserSettingList.RememberLastJson);
    Gs.Behaviors.ElementSetCheckBox("EnableScreenSaver", Gs.Variables.UserSettingList.EnableScreenSaver);

    //Apply Changes
    Gs.Behaviors.SetUserSettings();
}


/**
* Function Before Set Selected Portal Menu
* @function
* @param {number}     num Id of HtmlContent saved in Storage.
*/
Gs.Behaviors.BeforeSetMenu = function (htmlContentId) {
    Gs.Variables.monacoEditorList = [];

    //SET UserSetting
    Gs.Behaviors.LoadUserSettings();

    //RESET here storage tables from Portal Menu
    Metro.storage.delItem('ApiTableList');
    Metro.storage.delItem("ServerStartUpScriptList");
    Metro.storage.delItem("FtpServerStatus");
    Metro.storage.delItem("SchedulerServerStatus");   
    Metro.storage.delItem("MyQuestionList");
    Metro.storage.delItem("QuestionForResponseList");
    Metro.storage.delItem("SolutionCodeLibraryList"); 
    //Metro.storage.delItem("SolutionMixedEnumList");
    Metro.storage.delItem("SelectedEditor");
    Metro.storage.delItem("PortalApiTableList");
    Metro.storage.delItem("EmailTemplateList");
    Metro.storage.delItem("RunAdminQueryResultList");
    Metro.storage.delItem("AudioNotepadList");
    Metro.storage.delItem("DataTableList");
    Metro.storage.delItem("CodeGeneratorList");
    Metro.storage.delItem("ToolsCounterList");
    Metro.storage.delItem("StorageFolderList");
    Metro.storage.delItem("ServerStorageVersionList");
    Metro.storage.delItem("BlogList");

    Metro.storage.delItem("SelectedMenu");
    Metro.storage.delItem("SelectedEditor");
    Metro.storage.delItem("OpenExcelFile");
    Metro.storage.delItem("OpenWordFile");
    Metro.storage.delItem("OpenPowerPointFile");
    Metro.storage.delItem("RevealPreview");
    Metro.storage.delItem("RevealPreviewData");
    Metro.storage.delItem("SearchResultFileList");


    Gs.Functions.RemoveElement("InheritScript"); Gs.Functions.RemoveElement("InheritStyle");
    let menu = Metro.storage.getItem('PortalMenuList', null);
    return menu;
}


/**
* Set Link Menu Function from Selected Menu
* @function
* @param {number}     num Id of HtmlContent saved in Storage.
* @param {string}     HtmlContent saved in Storage.
*/
Gs.Behaviors.SetLink = function (htmlContentId, content) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    let portalMenuList = Metro.storage.getItem("PortalMenuList");
    Metro.storage.setItem("SelectedMenu", portalMenuList.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    $("#FrameWindow").load(Metro.storage.getItem('ApiOriginSuffix', null) + content);
}

/**
* Set External Link Menu Function from Selected Menu
* @function
* @param {number}     num Id of HtmlContent saved in Storage.
* @param {string}     HtmlContent saved in Storage.
*/
Gs.Behaviors.SetExternalLink = function (htmlContentId, content) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    let portalMenuList = Metro.storage.getItem("PortalMenuList");
    Metro.storage.setItem("SelectedMenu", portalMenuList.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML = 
    '<div id=MainWindow data-role="window" data-custom-buttons="WindowButtons" data-icon="<span class=\'' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Icon + '\'></spam>" data-title="' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + '" class="h-100" data-btn-close="false" data-btn-min="false" data-btn-max="false" data-width="100%" data-height="800" data-draggable="false" >'
    + '<iframe id="IFrameWindow" src="' + content + '" width="100%" height="700" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe></div>';
}

/**
* Set Html Content Menu Function from Selected Menu
* @function
* @param {number}     num Id of HtmlContent saved in Storage.
* @param {number}     num Id of JsContent saved in Storage.
* @param {number}     num Id of CssContent saved in Storage.
*/
Gs.Behaviors.SetContent = function (htmlContentId, jsContentId, cssContentId) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    let portalMenuList = Metro.storage.getItem("PortalMenuList");
    Metro.storage.setItem("SelectedMenu", portalMenuList.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML =
         '<div id=MainWindow data-role="window" data-custom-buttons="WindowButtons" data-icon="<span class=\'' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Icon + '\'></spam>" data-title="' + menu.filter(obj => { return obj.HtmlContentId == htmlContentId })[0].Name + '" data-btn-close="false" class="h-100" data-btn-min="false" data-btn-max="false" data-width="100%" data-height="800" data-draggable="false" >'
         + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent + "</div>";

    if (menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent != null) {
        let script = "<script id='InheritScript' charset='utf-8' type='text/javascript'> " + menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent + " </script>";
        $('body').append(script);
    }
    if (menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent != null) {
        let style = document.createElement('style'); style.id = "InheritStyle"; style.rel = 'stylesheet';
        style.innerText = menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent;
        document.head.appendChild(style);
    }
    
}

/**
* Set Html Iframe Content Menu Function from Selected Menu
* @function
* @param {number}     num Id of HtmlContent saved in Storage.
* @param {number}     num Id of JsContent saved in Storage.
* @param {number}     num Id of CssContent saved in Storage.
*/
Gs.Behaviors.SetExternalContent = function (htmlContentId, jsContentId, cssContentId) {
    let menu = Gs.Behaviors.BeforeSetMenu(htmlContentId);

    let portalMenuList = Metro.storage.getItem("PortalMenuList");
    Metro.storage.setItem("SelectedMenu", portalMenuList.filter(obj => { return obj.HtmlContentId == htmlContentId })[0]);

    document.getElementById("FrameWindow").innerHTML =
    '<iframe id="IFrameWindow" src="' + menu.filter(menuItem => { return menuItem.HtmlContentId == htmlContentId })[0].HtmlContent + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';

    if (menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent != null) {
        let script = "<script id='InheritScript' charset='utf-8' type='text/javascript'> " + menu.filter(menuItem => { return menuItem.JsContentId == jsContentId })[0].JsContent + " </script>";
        $("#IFrameWindow").contents().find("body").append(script);
    }
    if (menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent != null) {
        let style = document.createElement('style'); style.id = "InheritStyle"; style.rel = 'stylesheet';
        style.innerText = menu.filter(menuItem => { return menuItem.CssContentId == cssContentId })[0].CssContent;
        let iframeHead = document.getElementById('IFrameWindow').contentWindow.document.head;
        iframeHead.appendChild(style);
    }
}

/**
* Function for Expand or Collapse of collapse Objects
* @function
* @param {number}     num Element Id for Expand or Collapse.
*/
Gs.Behaviors.ElementExpand = function (elementId) {
    try {
        let el = Metro.getPlugin('#' + elementId, 'collapse');
        let elStatus = el.isCollapsed();
        if (elStatus) { el.expand(); } else { el.collapsed(); }
    } catch { }
}

/**
* Function for Show or Hide of Objects
* @function
* @param {number}     num Element Id for Show or Hide.
* @param {boolean}    bool Optional ShowOnly
*/
Gs.Behaviors.ElementShowHide = function (elementId, showOnly = false) {
    try {
        let el = Metro.get$el('#' + elementId);
        if (showOnly) { el.show(); }
        else if (el.style("display") == "none") { el.show(); } else { el.hide(); }
    } catch { }
}

/**
* Set Element CheckBox to Value
* @function
* @param {number}     num Element Id for Set Value.
* @param {boolean}    bool CheckBox Value
*/
Gs.Behaviors.ElementSetCheckBox = function (elementId, val) {
    try {
        $('#' + elementId).val('checked')[0].checked = JSON.parse((val.toString().toLowerCase()));
    } catch { }
}

/**
* Object InfoBox Open / Close Function
* @function
* @param {number}     num Element Id for Open / Close InfoBox.
*/
Gs.Behaviors.InfoBoxOpenClose = function (elementId) {
    try {
        if (Metro.infobox.isOpen('#' + elementId)) { Metro.infobox.close('#' + elementId); }
        else { Metro.infobox.open('#' + elementId); }
    } catch { }
}

/**
* Show Html Window Source Code in Modal Window
* @function
*/
Gs.Behaviors.ShowWindowCode = function () {
    if (document.getElementById("IFrameWindow") == null) {
        Gs.Functions.ShowSource();
    } else { Gs.Functions.ShowFrameSource(); }
}

/**
* Show IFrame Window Source Code in Modal Window
* @function
*/
Gs.Behaviors.ShowWindowFrameWindowCode = function () {
    Gs.Functions.ShowWindowFrameSource();
}

/**
* Refresh and set Basket Value
* @function
*/
Gs.Behaviors.RefreshBasket = function () {
    let basketPrice = 0; let basketData = Metro.storage.getItem('BasketPriceList', null);
    basketData.forEach(item => {
        basketPrice += item.Price;
    });
    $("#BasketPrice").html(`${basketPrice} Kč`);
}

/**
* Remove Item from Basket
* @function
* @param {string}     Basket Title Item
*/
Gs.Behaviors.RemoveItemBasket = function (basketTitle) {
    $("#BasketForm").remove();
    let dataBasket = Metro.storage.getItem("BasketPriceList", null);
    dataBasket.forEach((item, index) => {
        if (item.Title == basketTitle) { dataBasket.splice(index, 1); }
    });
    Metro.storage.setItem("BasketPriceList", dataBasket);
    Gs.Behaviors.RefreshBasket();
    Gs.Objects.OpenBasket();
}

/**
* Init Stripe Credit Card Payment
* @function
* @param {number}     num Basket Price
* @param {string}     Basket Product Name
*/
Gs.Behaviors.InitStripe = async function (price, productName) {
    const fetchClientSecret = async () => {
        const response = await fetch("/StripeService/CreateCheckoutSession", {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ Price: price, ProductName: productName })
        });
        const { clientSecret } = await response.json();
        return clientSecret;
    };
    const checkout = await Gs.Variables.stripe.initEmbeddedCheckout({
        fetchClientSecret,
    });
    checkout.mount('#checkoutStripe');
    document.querySelector("body > div.overlay").remove()
}

/**
* Start Stripe Credit Card Payment
* @function
* @param {number}     num Basket Price
* @param {string}     Basket Product Name
*/
Gs.Behaviors.RunStripe = function (price, productName) {

    $("#BasketForm").remove();
    $("#FrameWindow").html("<div id='checkoutStripe'>");
    Gs.Behaviors.InitStripe(price, productName);
}



/**
* Download Payed Basket Product
* @function
* @param {string}     Basket Product Name
*/
Gs.Behaviors.DownloadedBasket = function (basketTitle) {
    $("#BasketForm").remove();
    let dataBasket = Metro.storage.getItem("BasketPriceList", null);
    dataBasket.forEach((item, index) => {
        if (item.Title == basketTitle) { dataBasket.splice(index, 1); }
    });
    Metro.storage.setItem("BasketPriceList", dataBasket);
    Gs.Objects.DownloadBasket();
}


/**
* Clear Chat Message Window
* @function
*/
Gs.Behaviors.ClearChat = function () { 
    Metro.storage.setItem("ChatMessageList", []);
    $("#ChatPanel").remove();
    Gs.Objects.OpenChat();
}

/**
* Clear Share Chat Message Window
* @function
*/
Gs.Behaviors.ShareClearChat = function () {
    Metro.storage.setItem("ShareChatMessageList", []);
    $("#SharePanel").remove();
    Gs.Objects.OpenShareWindow();
}

/**
* Clear Share Receiver Chat Message Window
* @function
*/
Gs.Behaviors.ShareReceiveClearChat = function () {
    let targetUser = $("#StreamAdmin").html();
    Metro.storage.setItem("ShareChatMessageList", []);
    $("#ShareReceivePanel").remove();
    Gs.Objects.OpenShareReceive();
    setTimeout(function () { $("#StreamAdmin").html(targetUser) }, 100);
}


/**
* Cycle Time Mechanism for Correct SET of EDITORS  Load Data To Tool in 1 Sec Cycle
* @function
* @param {string} tool tool Name from Program Code
*/
Gs.Behaviors.LoadDataToTool = function (tool) {
    try {
        setTimeout(() => {
            switch (tool) {
                case "FastHelpEditor":
                    $('#HelpFastEditor')[0].contentWindow.mdEditor.setMarkdown(Metro.storage.getItem("SelectedMenu", null).MdContent);
                    break;
                default:
            }
        }, 1000);
    } catch { Gs.Behaviors.LoadDataToTool(tool) }
}