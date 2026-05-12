
Gs.Objects.ShowToolPanel = function (close) {
    if (close) { Metro.bottomsheet.close($('#ToolPanel')); } else {
        if (Metro.bottomsheet.isOpen($('#ToolPanel'))) { Metro.bottomsheet.close($('#ToolPanel')); }
        else { Metro.bottomsheet.open($('#ToolPanel')); }
    }
}

//Global Tool Panel
Gs.Objects.CreateToolPanel = function () {
    let html = '<div id="ToolPanel" data-role="bottom-sheet" class="bottom-sheet pos-fixed list-list grid-style opened" style="top: 0px; left: 90%; z-index:10000;min-width: 430px;">';
    html += '<div class="c-pointer mif-cancel mif-1x icon pos-absolute fg-red" style="top:5px;right:5px;" onclick=Gs.Objects.ShowToolPanel(); ></div>';
    html += '<DIV class=d-block><DIV class="d-flex row gutters mr-4" >'
    html += '<ul data-role="materialtabs" data-expand="true" data-tabs-type="text" data-on-tab="">';
    html += '<li class="fg-black"><A href="#_toolTranslate">Translate</A> </li>';
    html += '<li class="fg-black"><A href="#_toolUserSet">User Setting</A> </li>';
    //html += '<li class="fg-black"><A href="#_toolHelp">Fast Help</A></li>';
    //html += '<li class="fg-black"><A href="#_toolImages">Images</A></li>';
    //html += '<li class="fg-black"><A href="#_toolRadio">Radio</A></li>';
    //html += '<li class="fg-black"><A href="#_toolVideo">Video</A></li>';
    html += '</ul>';
    html += '<DIV id=_toolTranslate class="d-contents" style="display: contents !important;">';
    //html += '<div class="w-100 text-left"> <audio id="radio" class="light bg-transparent" data-role="audio-player" data-src="/server-integrated/razor-pages/server-portal/media/hotel_california.mp3" data-volume=".5"></audio> </div>';
    html += '<div class="w-100 text-left" style="z-index: 1000000;"><div id="google_translate_element"></div></div>';
    html += '<div class="w-100 d-inline-flex"><div class="w-75 text-left">';
    html += '<input id="EnableAutoTranslate" type="checkbox" data-role="checkbox" data-cls-caption="fg-cyan text-bold" data-caption="Auto Translate" onchange=Gs.Behaviors.SetUserSettings(); >';
    html += '</div><div class="w-25 mt-1 text-right" style="max-width:25% !important;"><button class="button secondary mini" style="max-width:100% !important;" onclick=Gs.Behaviors.CancelTranslation(true); >Cancel Translate</button></div></div>';
    html += '</div>';

    html += '<DIV id=_toolUserSet>';
    html += '<DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" >';
    html += '<DIV class="form-group m-0 p-0" > <INPUT id=EnableShowDescription onchange=Gs.Behaviors.SetUserSettings()  style = "HEIGHT: auto" autocomplete = "off" data-role="checkbox" data-caption="Enable Show Description" > </DIV ></DIV > ';
    html += '<DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" >';
    html += '<DIV class="form-group m-0 p-0" > <INPUT id=RememberLastJson onchange=Gs.Behaviors.SetUserSettings()  style = "HEIGHT: auto" autocomplete = "off" data-role="checkbox" data-caption="Remember Last JSON" > </DIV ></DIV > ';
    html += '<DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" >';
    html += '<DIV class="form-group m-0 p-0" > <INPUT id=RememberLastHandleBar onchange=Gs.Behaviors.SetUserSettings()  style = "HEIGHT: auto" autocomplete = "off" data-role="checkbox" data-caption="Remember Last HandleBar" > </DIV ></DIV > ';
    html += '<DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" >';
    html += '<DIV class="form-group m-0 p-0" > <INPUT id=EnableScreenSaver onchange=Gs.Behaviors.SetUserSettings()  style = "HEIGHT: auto" autocomplete = "off" data-role="checkbox" data-caption="Enable ScreenSaver" > </DIV ></DIV > ';

    html += '<DIV id=_toolRadio></div>';

    html += '<DIV id=_toolVideo></div>';

    html += '</div></div>';
    //html += '<div class="d-flex w-100" title="Theme">';
    //let themes = [
    //    ["#585b5d", "darcula.css?white"], ["#AF0015", "red-alert.css?white"], ["#690012", "red-dark.css?white"], ["#0CA9F2", "sky-net.css?white"],
    //    ["#585b5d", "darcula.css?#585b5d"], ["#AF0015", "red-alert.css?#AF0015"], ["#690012", "red-dark.css?#690012"], ["#0CA9F2", "sky-net.css?#0CA9F2"]
    //];
    //themes.forEach((theme, index) => {
    //    html += '<button class="button shadowed w-50px ' + (index < 4 ? "opc-05" : "") + ' mt-1" style="background-color: ' + theme[0] + ';" onclick=Gs.Behaviors.ChangeSchemeTo(\'' + theme[1] + '\'); ></button>';
    //    if (index == 3) { html += '</div><div class="d-flex w-100" title="BackGround">'; }
    //});

    let injectToolPanel = document.createElement("div");
    injectToolPanel.innerHTML = html;
    document.body.append(injectToolPanel);
};

Gs.Objects.ShowLoginPage = function () {
    let htnlContent = '<DIV class=text-center><WINDOW><DIV class="hero hero-bg 1bg-brand-secondary add-neb"><DIV class=container><DIV class=row>';
    htnlContent += '<FORM id=loginform class="login-form bg-white fg-darkBlue p-6 mx-auto border bd-default win-shadow" method=post action=javascript: data-role="validator" data-on-validate-form="ValidateForm" data-on-error-form="InvalidForm" data-clear-invalid="2000"><SPAN class="mif-vpn-lock mif-4x place-right" style="MARGIN-TOP: -10px"></SPAN>';
    htnlContent += '<H2 class=text-light>EIC&ESB Portal</H2>'
    htnlContent += '<DIV class=form-group><INPUT id=usernameId class=input style="HEIGHT: auto" maxLength=50 data-role="input" data-validate="required" placeholder="Insert Username..." data-prepend="<span class=\'mif-envelop\'>"> </DIV>';
    htnlContent += '<DIV class=form-group><INPUT id=passwordId type=password data-role="input" data-validate="required minlength=6" placeholder="Insert Password..." data-prepend="<span class=\'mif-key\'>"> </DIV>';
    htnlContent += '<DIV class="form-group mt-10"><INPUT class=place-right type=checkbox data-role="checkbox" data-caption="Remember"><BUTTON class="button shadowed">Přihlásit</BUTTON> </DIV></FORM></DIV></DIV></DIV></WINDOW></DIV>';
    document.getElementById("FrameWindow").innerHTML = htnlContent;
}


//Blocked IP Info Panel
Gs.Objects.ShowBlockedMessage = function () {
    var html_content =
        "<h3>Blokovaná IP Adresa</h3>" +
        "<p>Vaše adrese je blokována, protože byla zjištěna podezřelá činnost...</p>" +
        "<p>Pro Odblokování nás kontaktujte Telefonicky.</p>";
    Metro.infobox.create(html_content, "alert");
}


//Unauthorized Access Info Panel
Gs.Objects.ShowUnAuthMessage = function () {
    Gs.Behaviors.SignOut();
    var html_content =
        "<h3>Neautorizovaný Přístup</h3>" +
        "<p>Pokoušíte se provést autorizovanou operaci neoprávněně,</p>" +
        "<p>nebo platnost vašeho tokenu vypršela.</p>";
    Metro.infobox.create(html_content, "alert");
}


function GenerateMenuList() {
    let htmlContent = "";

    let lastGuid = null, menuItem = {}, menu = [];
    let portalMenu = Metro.storage.getItem('PortalMenuList', null);

    portalMenu.forEach((mItem, index, arr) => {

        switch (mItem.apiTableColumnName) {
            case "ParentGuid":
                menuItem.ParentGuid = mItem.value;
                menuItem.RecGuid = mItem.recGuid;
                menuItem.Id = mItem.id;
                menuItem.Description = mItem.description;
                menuItem.Public = mItem.public;
                menuItem.Active = mItem.active;
                break;
            case "Sequence":
                menuItem.Sequence = parseInt(mItem.value);
                break;
            case "Name":
                menuItem.Name = mItem.value;
                break;
            case "Timestamp":
                menuItem.Timestamp = new Date(mItem.value);
                break;
            case "Icon":
                menuItem.Icon = mItem.value;
                break;
            case "InheritedMenuType":
                menuItem.InheritedMenuType = mItem.value;
                break;
            case "HtmlContent":
                menuItem.HtmlContent = mItem.value;
                menuItem.HtmlContentId = mItem.id;
                break;
            case "JsContent":
                menuItem.JsContent = mItem.value;
                menuItem.JsContentId = mItem.id;
                break;
            case "CSSContent":
                menuItem.CssContent = mItem.value;
                menuItem.CssContentId = mItem.id;
                break;
            case "MdHelp":
                menuItem.MdHelp = mItem.value;
                menuItem.MdHelpId = mItem.id;
                break;
            default:
        }

        if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
            menu.push(menuItem);
            menuItem = {};
        }

        lastGuid = mItem.recGuid;
    });
    menu.sort((a, b) => a.Sequence > b.Sequence ? 1 : -1);
    Metro.storage.setItem('PortalMenuList', menu);

    menu.forEach((mItem, index, arr) => {
        if (mItem.InheritedMenuType == "menu") {
            htmlContent += '<li id="' + mItem.Sequence + '" ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' class="drop-shadow" data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href="#" class="dropdown-toggle"><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a>';
            htmlContent += '<ul id ="' + mItem.RecGuid + '" class="navview-menu stay-open" data-role="dropdown"><li class="item-header" > ' + mItem.Name + '</li></ul>';
            htmlContent += '</li>';
        }

        if (index == arr.length - 1) { document.getElementById("PortalMenu").innerHTML = htmlContent; }
    });

    menu.forEach((mItem, index, arr) => {
        if (mItem.InheritedMenuType == "link") {
            htmlContent = '<li onclick=Gs.Behaviors.SetLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        } else if (mItem.InheritedMenuType == "externalLink") {
            htmlContent = '<li onclick=Gs.Behaviors.SetExternalLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        }

        else if (mItem.InheritedMenuType == "content") {
            htmlContent = '<li onclick=Gs.Behaviors.SetContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }

        else if (mItem.InheritedMenuType == "externalContent") {
            htmlContent = '<li onclick=Gs.Behaviors.SetExternalContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }


    });

}



Gs.Objects.ShowNotify = function (type, message) {
    try {
        var notify = Metro.notify; notify.setup({ width: Gs.Variables.notifySetting.notifyWidth, timeout: Metro.storage.getItem('NotifyShowTime', 2000), duration: Gs.Variables.notifySetting.notifyDuration, animation: Gs.Variables.notifySetting.notifyAnimation });
        if (type == 'error' || type == 'alert') { notify.create(message, "Error", { cls: "alert" }); }
        else if (type == 'success') { notify.create(message, "Success", { cls: "success" }); }
        else if (type == 'info') { notify.create(message, "Info"); }
        notify.reset();
    } catch { }
}


Gs.Objects.ShowFavoritesPanel = function (close) {
    let charms = Metro.getPlugin($("#FavoritesPanel"), 'charms');
    if (close) {
        charms.close();
    } else { charms.toggle(); }
}


Gs.Objects.ShowOnlineToolPanel = function (close) {
    let charms = Metro.getPlugin($("#OnlineToolPanel"), 'charms');
    if (close) {
        charms.close();
    } else { charms.toggle(); }
}


Gs.Objects.ShowModalMenu = function (elementId, close = false) {
    if (close || Metro.bottomsheet.isOpen("#" + elementId)) {
        Gs.Functions.AddClass(elementId, "hidden");
        Metro.bottomsheet.close("#" + elementId);
        Gs.Functions.AddClass(elementId, "hidden");
    }
    else { Metro.bottomsheet.open("#" + elementId, "grid"); Gs.Functions.RemoveClass(elementId, "hidden"); }
}


Gs.Objects.RefreshPreview = function () {
    Gs.Functions.RemoveElement("PreviewScript"); Gs.Functions.RemoveElement("PreviewStyle");
    document.getElementById("menuPreview").innerHTML = null;

    if ($("#menuType").val() == "link") {
        $("#menuPreview").load(Metro.storage.getItem('BackendServerAddress', null) + "/" + Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].model.getValue());

    } else if ($("#menuType").val() == "externalLink") {
        document.getElementById("menuPreview").innerHTML = '<iframe id="PreviewFrameWindow" src="' + Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].model.getValue() + '" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>';

    } else if ($("#menuType").val() == "content") {
        document.getElementById("menuPreview").innerHTML = Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].model.getValue();

        if (Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].model.getValue() != null) {
            let script = "<script id='PreviewScript' type='text/javascript'> " + Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].model.getValue();
            $('body').append(script);
        }
        if (Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].model.getValue() != null) {
            let style = document.createElement('style'); style.id = "PreviewStyle";
            style.innerText = Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].model.getValue();
            document.head.appendChild(style);
        }
    } else if ($("#menuType").val() == "externalContent") {

    } else if ($("#menuType").val() == "menu") {
        document.getElementById("menuPreview").innerHTML ="Menu doesnt have Content"
    }
}


//Gs.Objects.InfoboxTableCreate = function (elementId) {
//    let html = "<div class='container'><table id='MenuTable' class='table striped' data-role='table' data-pagination='true' data-show-all-pages='false' ></div>";
//    let infoBox = Metro.infobox.create(html, "", {
//        closeButton: true,
//        type: "",
//        removeOnClose: true,
//        width: "80%",
//        height: "802",
//        tag: "",
//        id: elementId
//    });
//    var table = Metro.getPlugin("#PreviewTable", "table");
//    let data=[];
//    let functionList = Metro.storage.getItem('FunctionList', null);
//    functionList.forEach(fn => { data.push([ fn.Group, fn.Label, fn.Path ]); });
//    table.setItems(data); table.reload();
//}


Gs.Objects.InfoboxFrameCreate = function (elementId,url) {
    let infoBox = Metro.infobox.create("<iframe id='" + elementId + "' src='" + url + "'  width='100%' height='880' frameborder='0' scrolling='yes' style='width: 100%; height: 780px;' ></iframe>", "", {
        closeButton: true,
        type: "",
        removeOnClose: true,
        width: "80%",
        height: "800",
        tag: "",
        id: elementId
    });
    infoBox[0].id = elementId;
}


Gs.Objects.InfoboxObjectCreate = function (elementId, html, width = "80%", height = "800", closeButton = true) {
    let infoBox = Metro.infobox.create(html, "", {
        closeButton: closeButton,
        type: "",
        removeOnClose: true,
        width: width,
        height: height,
        tag: "",
        id: elementId
    });
    infoBox[0].id = elementId;
}


Gs.Objects.WindowIframeCreate = function (title, url, lastWindow = false) {
    if (lastWindow) { ( url = document.getElementById("IFrameWindow") != null ? document.getElementById("IFrameWindow").src : "/") }
    let custwindow = Metro.window.create({
        cls: "p-0", title: title, clsCaption: 'bg-orange',
        btnMin: true, btnMax: true, shadow: true,
        draggable: true, resizable: true,
        width:"100%", height:"100%",
        place: 'center',
        clsWindow: "supertop",
        icon: "<span class='mif-hour-glass'></spam>",
        onCaptionDblClick: function () { },
        btnClose: true,
        content: "<iframe id=WindowFrame src='" + url + "' width='100%' height='800' frameborder='0' scrolling='yes' style='width: 100%; height: 100 %;'></iframe>"
    });
    //custwindow[0].id = elementId;
}


Gs.Objects.WindowHtmlCreate = function (elementId, title, html) {
    let custwindow = Metro.window.create({
        cls: "p-0", title: title, clsCaption: 'bg-orange',
        btnMin: true, btnMax: true, shadow: true,
        draggable: true, resizable: true,
        width: "100%", height: "100%",
        place: 'center',
        clsWindow: "supertop",
        icon: "<span class='mif-hour-glass'></spam>",
        onCaptionDblClick: function () { },
        btnClose: true,
        content: html
    });
    custwindow[0].id = elementId;
}


Gs.Objects.OpenInExternalWindow = function (title, url, lastWindow = false) {
    if (lastWindow) { (url = document.getElementById("IFrameWindow") != null ? document.getElementById("IFrameWindow").src : "/") }
    window.open(url, '_blank');
}


Gs.Objects.GetMyQuestionList = async function () {
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetMyQuestionList", "MyQuestionList");
    
    setTimeout(function () {
        let myQuestionList = []; let group = null; menuItem = {};
        let origQuestionList = Metro.storage.getItem('MyQuestionList', null);
        
        origQuestionList.forEach((item, index, arr) => {
            switch (item.apiTableColumnName) {
                case "MenuName":
                    menuItem.recGuid = item.recGuid;
                    menuItem.MenuName = item.value;
                    break;
                case "Question":
                    menuItem.Question = item.value;
                    break;
                case "Response":
                    menuItem.Response = item.value;
                    break;
            }
            if (group != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != item.recGuid)) {
                myQuestionList.push(menuItem);
                menuItem = {};
            }
            group = item.recGuid;
        });

        let scriptCode = "";
        let html = '<div data-role="accordion" data-active-heading-class="bg-cyan fg-white" data-active-content-class="fg-cyan" class="pt-5" >';
        myQuestionList.forEach((item, index, arr) => {
            html += '<div class="frame"><div class="heading">' + item.MenuName + '</div>';
            html += '<div class="content"><div class="p-2 fg-green">Question: ' + item.Question + '</div><div class="p-2">Response:<div id="codeEditor' + index + '"></div></div></div>';
            html += '</div>';
            scriptCode += '$("#codeEditor' + index + '").summernote({ tabsize: 2, height: 150, maxHeight: 150, lang: "cs-CZ", toolbar: [] }); $("#codeEditor' + index + '").summernote("codeview.activate"); $("#codeEditor' + index + '").summernote("code", ' + decodeURI(item.Response) + ');';
        });
        html += '</div>';

        Gs.Objects.InfoboxObjectCreate("myQuestionList", html);
        Gs.Functions.loadJS("InjectedScript", scriptCode);
    }, 5000);
}


Gs.Objects.ShowRegistrationPage = function () {
    let htnlContent = '<DIV class=text-center><window><DIV class="hero hero-bg 1bg-brand-secondary add-neb"><DIV class=container><DIV class=row>';
    htnlContent += '<form class="bg-white p-4 login-form bg-white fg-darkBlue p-6 mx-auto border bd-default win-shadow" action="javascript:" data-role="validator" data-on-validate-form="ValidateRegForm" data-clear-invalid="2000" data-on-error-form="InvalidForm" >';
    htnlContent += '<img src="/server-portal/images/p-120x120.png" class="place-right mt-4-minus mr-5-minus"><h1 class="mb-0">Register</h1><div class="text-muted mb-4">Register to EIC & ESB Portal</div>'
    htnlContent += '<div class="form-group"><input id="firstName" type="text" data-role="input" placeholder="First name" data-append="<span class=\'mif-user\'>" data-validate="required"><span class="invalid_feedback">Please enter a valid First Name</span></div>';
    htnlContent += '<div class="form-group"><input id="surname" type="text" data-role="input" placeholder="Surname" data-append="<span class=\'mif-user\'>" data-validate="required"><span class="invalid_feedback">Please enter a Surname</span></div>';
    htnlContent += '<div class="form-group"><input id="userName" type="text" data-role="input" placeholder="UserName" data-append="<span class=\'mif-user\'>" data-validate="required"><span class="invalid_feedback">Please enter a UserName</span></div>';
    htnlContent += '<div class="form-group"><input id="email" type="text" data-role="input" placeholder="Email" data-append="<span class=\'mif-envelop\'>" data-validate="required"><span class="invalid_feedback">Please enter a valid Email Address</span></div>';
    htnlContent += '<div class="form-group"><input id="password" type="password" data-role="input" placeholder="Password" data-append="<span class=\'mif-key\'>" data-validate="required" name="password"><span class="invalid_feedback">Please enter a Password</span>';
    htnlContent += '<input class="mt-4" type="password" data-role="input" placeholder="Retype password" data-append="<span class=\'mif-checkmark\'>" data-validate="required equals=password"><span class="invalid_feedback">Please enter a Password</span></div>';
    htnlContent += '<div class="form-group d-flex flex-align-center flex-justify-between"><input type="checkbox" data-role="checkbox" data-caption="I agree to the <a href=\'#\'>terms</a>"><button class="button primary">Register</button></div>';
    htnlContent += '</form></div></div></div></window></div>';
    document.getElementById("FrameWindow").innerHTML = htnlContent;
}


Gs.Objects.ShowExportDialog = function (title) {
    Metro.dialog.create({
        title: title,
        content: "<div>Export Table Data id=menuTable to File</div>",
        closeButton: true,
        removeOnClose: true,
        actions: [
            {
                caption: "CSV",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'csv' }); }
            },
            {
                caption: "TXT",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'txt' }); }
            },
            {
                caption: "JSON",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'json', escape: 'true' }); }
            },
            {
                caption: "XLS",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'excel' }); }
            },
            {
                caption: "DOC",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'doc' }); }
            },
            {
                caption: "PDF",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.ExportTable({ type: 'pdf', jspdf: { orientation: 'l', margins: { right: 10, left: 10, top: 40, bottom: 40 }, autotable: { extendWidth: true } } }); }
            }
        ]
    });
}


Gs.Objects.CreateDialogRequest =async function (title, content, actions) {
    Metro.dialog.create({
        title: title,
        content: content,
        closeButton: true,
        removeOnClose: true,
        actions: actions,
        clsDialog: "supertop"
    });
}


Gs.Objects.ShowPrintExport = function () {
    Metro.dialog.create({
        title: "Print & Export",
        content: "<div>Print & Export Opened Page</div>",
        closeButton: true,
        removeOnClose: true,
        closeAction: true,
        actions: [
            {
                caption: "Download Html",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.PrintOrExportWindow("Download");  }
            },
            {
                caption: "Download Image",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.PrintOrExportWindow("Image"); }
            },
            {
                caption: "Download Pdf",
                cls: "js-dialog-close success",
                onclick: function () { Gs.Functions.PrintOrExportWindow("Pdf"); }
            },
            //{
            //    caption: "Copy to Buffer",
            //    cls: "js-dialog-close success",
            //    onclick: function () { Gs.Functions.PrintOrExportWindow("Copy"); }
            //}
        ]
    });
}


Gs.Objects.OpenBasket = function () {
    let html = '<h1>Basket</h1><ul class="items-list">';
    let dataBasket = Metro.storage.getItem("BasketPriceList", null);
    let price = 0; let productName = "";

    dataBasket.forEach(item => {
        price += item.Price; productName += item.Title + ";";
        html += `<li><img class='avatar' src='/server-portal/images/logo.png' ><span class='h7' style="margin-left:60px;">${item.Title}</span><span class="second-label">${item.Price} ${item.Currency}</span><span onclick='Gs.Behaviors.RemoveItemBasket("${item.Title}")' class="second-action mif-cancel mif-3x fg-red"></span></li>`;
    }); html += `</ul><p></p><div><button class='button warning shadowed' onclick='Gs.Behaviors.RunStripe("${price}","${productName}")' ><img src='/server-portal/images/stripe.png'>STRIPE PAY</button></div>`;

    Gs.Objects.InfoboxObjectCreate("BasketForm", html);
}


Gs.Objects.DownloadBasket = function () {
    let basketData = Metro.storage.getItem('BasketPriceList', null);
    basketData.forEach((item, index) => {  basketData[index].Price = 0; });
    Metro.storage.setItem('BasketPriceList', basketData);

    let html = '<h1>Basket</h1><ul class="items-list">';
    let dataBasket = Metro.storage.getItem("BasketPriceList", null);
    let price = 0; let productName = "";

    dataBasket.forEach(item => {
        price += 0; productName += item.Title + ";";
        html += `<li><img class='avatar' src='/server-portal/images/logo.png' ><span class='h7' style="margin-left:60px;">${item.Title}</span><span class="second-label">${item.Price} ${item.Currency}</span><span onclick='Gs.Apis.DownloadApi("DashboardService/DownloadLibraryFolder", { Path: "${item.Path.replaceAll('\\', '\\\\')}" }, "${item.Title}", true);Gs.Behaviors.DownloadedBasket("${item.Title}");' class="second-action mif-download mif-3x fg-green"></span></li>`;
    }); html += `</ul>`;

    Gs.Objects.InfoboxObjectCreate("BasketForm", html);
    Gs.Behaviors.RefreshBasket();
}



Gs.Objects.OpenChat = async function () {
    if ($("#ChatPanel").html() == undefined) {

        let html = `<div class="row"><span class="h3">${Gs.Variables.username}: Chat</span><button onclick="Gs.Behaviors.ClearChat()" class="button ml-10 warning shadowed">Clear Chat</button></div><div class="row">`;
        html += `<div id="ChatWindow" data-role="chat" data-width="400" data-height="600" class="" data-on-send=Gs.Socket.SendChatMessage data-cls-send-button="bg-green" data-name="${Gs.Variables.username}" data-title="Portal Chat with All Users" data-cls-chat="bg-olive" style="position: absolute;right: 20px;" `;
        html += ` data-random-color="true" data-welcome="Welcome to EIC & ESDB Portal chat" data-cls-message-left="default" data-cls-message-right="bg-cyan fg-white bd-cyan" data-readonly="false" ></div>`;
        html += `</div>`;
        Gs.Objects.InfoboxObjectCreate("ChatPanel", html, width = "470", height = "700");

        setTimeout(function () {
            let chatMessageList = Metro.storage.getItem("ChatMessageList", null);
            let chatWindow = Metro.getPlugin("#ChatWindow", "chat");
            chatMessageList.forEach(message => {
                chatWindow.add(message);
            });
            $("#ChatMessageCount").html("0");
        }, 100);
    }
}




Gs.Objects.OpenShareWindow = async function (selectedUser = null) {
    if ($("#SharePanel").html() == undefined) {
         
        let html = `<div class="row ml-3"><span class="h3">${Gs.Variables.username}: Share Window Chat</span><select id="userList" data-role="select" data-on-change="Gs.Functions.ShareUserSelected" data-cls-select="ml-10 w-25" data-clear-button="true" data-add-empty-value="true" data-prepend="Select User" data-empty-value="" ></select>`
        html += `<button id="ShareButton" onclick="Gs.Media.StartShareCaptureScreen()" class="button pos-absolute success shadowed disabled" style="right:140px;">Start Share Window</button><button onclick="Gs.Behaviors.ShareClearChat()" class="button pos-absolute warning shadowed" style="right:30px;">Clear Chat</button></div>`;
        html += `<div class="row ml-3"><video id="videoPreview" autoplay style="width: 730px;height: 600px;background-color: lightgray;"></video><div id="ShareChatWindow" data-role="chat" data-width="400" data-height="600" class="" data-on-send="Gs.SignalR.SendStreamChatMessage" data-cls-send-button="bg-green" data-name="${Gs.Variables.username}" data-title="Portal Chat with Selected User" data-cls-chat="bg-olive" style="position: absolute;right: 20px;" `;
        html += ` data-random-color="true" data-cls-message-left="default" data-cls-message-right="bg-cyan fg-white bd-cyan" data-readonly="false" ></div>`;
        html += `</div>`;
        Gs.Objects.WindowHtmlCreate("SharePanel","Share Desktop & Chat", html);

        setTimeout(function () {
            Gs.SignalR.GetUsers();

            let chatMessageList = Metro.storage.getItem("ShareChatMessageList", null);
            let chatWindow = Metro.getPlugin("#ShareChatWindow", "chat");
            chatMessageList.forEach(message => {
                chatWindow.add(message);
            });
            $("#ShareChatMessageCount").html("0");
        }, 100);
    }
}


Gs.Objects.OpenShareReceive = async function () {
    if ($("#ShareReceivePanel").html() == undefined) {

        let html = `<div class="row"><span class="h3">${Gs.Variables.username}: Share Window Chat</span><span class="h5 ml-10">connected with</span><div id="StreamAdmin" class="ml-10 h3"></div>`
        html += `<button onclick="Gs.Behaviors.ShareReceiveClearChat()" class="button pos-absolute warning shadowed" style="right:30px;">Clear Chat</button></div><div class="row">`;
        html += `<image id="imagePreview" style="width: 730px;height: 600px;background-color: lightgray;"></image><div id="ShareChatWindow" data-role="chat" data-width="400" data-height="600" class="" data-on-send="Gs.SignalR.SendStreamChatMessage" data-cls-send-button="bg-green" data-name="${Gs.Variables.username}" data-title="Portal Chat with Selected User" data-cls-chat="bg-olive" style="position: absolute;right: 20px;" `;
        html += ` data-random-color="true" data-cls-message-left="default" data-cls-message-right="bg-cyan fg-white bd-cyan" data-readonly="false" ></div>`;
        html += `</div>`;
        Gs.Objects.InfoboxObjectCreate("ShareReceivePanel", html, width = "1200", height = "700", true);

        setTimeout(function () {
            let chatMessageList = Metro.storage.getItem("ShareChatMessageList", null);
            let chatWindow = Metro.getPlugin("#ShareChatWindow", "chat");
            chatMessageList.forEach(message => {
                chatWindow.add(message);
            });
            $("#ShareChatMessageCount").html("0");
        }, 100);
    }
}


Gs.Objects.AddSuggest = async function () {

    let html = `
    <BUTTON onclick="Gs.Functions.AddSuggestionSave();" class="button success c-pointer outline shadowed" style="position:absolute; top:20px;left:40px;z-index:2500;">Save Suggestion</BUTTON>
    <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
        <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12" style="z-index:2000;" >
            <DIV class="form-group pt-5">
                <select id="menuInheritedMonacoLanguageType" data-role="select" data-use-placeholder="true" data-placeholder="Language Type">
                </select>
            </DIV>
        </DIV>
        <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" style="z-index:2000;" >
            <DIV class="form-group pt-5">
                <INPUT id="menuLabel" style="HEIGHT: auto" data-role="input" data-validate="required" autocomplete="off" data-label="Label" />
            </DIV>
        </DIV>
        <DIV id=_menuCodeContent class="w-100" style="max-height: 650px;overflow: hidden;">
            <div id="fastSuggestion" style="top: -50px;" ></div >
            <select id=FastSugestEditorTheme class="theme" style="position: absolute;z-index: 2000;top: 50px;right: 0px;">
                <option>vs-dark</option>
                <option>vs</option>
                <option>hc-black</option>
            </select>
            <select id=FastSugestEditorLang class="language" style="position: absolute;z-index: 2000;top: 80px;right: 0px;"></select>
        </DIV >
    </DIV >`;
    Gs.Objects.InfoboxObjectCreate("AddSuggest", html, width = "1000", height = "800");

    setTimeout(async function () {
        Gs.Variables.monacoEditorList.splice(Gs.Variables.monacoEditorList.findIndex(p => p.elementId == "fastSuggestion"), 1);
        let dataJs = await fetch(`/server-portal/addons/monaco/js/fastSuggestion.js`).then((r) => r.text());
        new Function(dataJs)();

        $("#menuLabel").val("");
        let select = Metro.getPlugin("#menuInheritedMonacoLanguageType", "select"); let options = []; select.data("");
        let mixedenumList = Metro.storage.getItem("MixedEnumList", null);
        mixedenumList.forEach(mixedEnum => {
            if (mixedEnum.ItemsGroup == "MonacoLanguageType" && mixedEnum.Active) {
                options.push({ val: mixedEnum.Name, title: mixedEnum.Name, selected: false });
            }
        });
        select.addOptions(options);
    }, 1000);
}


Gs.Objects.EditHelpMenu = function () {
    let html = `
    <BUTTON onclick="Gs.Functions.SaveMenuHelp();" class="button success c-pointer outline shadowed" style="position:absolute; top:57px;right:60px;z-index:2500;">Save Menu Help</BUTTON>
    <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
        <DIV id=_menuCodeContent class="w-100" style="max-height: 650px;overflow: hidden;">
            <iframe id="HelpFastEditor" src="/server-portal/addons/markdown/index.html" width="100%" height="700" frameborder="0" scrolling="yes" style="width:100%; height:900px;"></iframe>
        </DIV >
    </DIV >`;
    Gs.Objects.InfoboxObjectCreate("EditHelpMenu", html, width = "1000", height = "800");

    setTimeout(async function () {
        $('#HelpFastEditor')[0].contentWindow.mdEditor.setMarkdown(Metro.storage.getItem("SelectedMenu", null).MdHelp);
    }, 1000);

}


Gs.Objects.OpenBlogMenu = async function () {
    $("#EditBlogMenu").remove();
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetBlogList", "BlogList", "EditBlogMenu");
}

function EditBlogMenu(search = null) {

    let html = `
    <BUTTON onclick="Gs.Functions.SaveBlog();" class="button success c-pointer outline shadowed" style="position:absolute; top:20px;right:200px;z-index:2500;">Save Contribution</BUTTON>
    <BUTTON onclick="Gs.Functions.SearchBlog();" class="button warning c-pointer outline shadowed" style="position:absolute; top:20px;right:120px;z-index:2500;">Search</BUTTON>
    <BUTTON onclick="Gs.Functions.ResetBlog();" class="button alert c-pointer outline shadowed" style="position:absolute; top:20px;right:50px;z-index:2500;">Reset</BUTTON>
    <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
        <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12" >
            <DIV class="form-group">
                <p>Portal Menu</p>
                <select id="menuBlogName" data-role="select" data-use-placeholder="true" data-placeholder="Language Type">
                </select>
            </DIV>
        </DIV>
        <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12" >
            <DIV class="form-group pt-7">
                <INPUT id="menuSearch" style="HEIGHT: auto" data-role="input" data-search-button="true" autocomplete="off" data-label="Search" />
            </DIV>
        </DIV>
        <DIV class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <DIV class="form-group"><div id="menuBlogContent"></div>
        </DIV>
        <DIV class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <DIV id="MenuBlog" style="height: 300px;max-height: 300px;overflow: auto;">
            </DIV>
        </DIV>
    </DIV >`;
    Gs.Objects.InfoboxObjectCreate("EditBlogMenu", html, width = "1200", height = "800");

    setTimeout(async function () {
        $('#menuBlogContent').summernote({
            tabsize: 2, height: 150, maxHeight: 150,
            lang: 'cs-CZ',
            placeholder: 'write Contribution...',
            toolbar: [['style', ['style']], ['font', ['bold', 'underline', 'clear']], ['fontname', ['fontname']],
            ['fontsize', ['fontsize']], ['color', ['color']], ['para', ['ul', 'ol', 'paragraph']], ['table', ['table']],
            ['insert', ['link', 'picture', 'video']], ['view', ['fullscreen', 'codeview', 'undo', 'redo', 'help']]]
        });

        let select = Metro.getPlugin("#menuBlogName", "select"); let options = []; select.data("");
        let portalMenuList = Metro.storage.getItem("PortalMenuList", null);
        portalMenuList.sort((a, b) => a.Name > b.Name ? 1 : -1);
        portalMenuList.forEach(item => {
            options.push({ val: item.Name, title: item.Name, selected: false });
        });
        select.addOptions(options);
        
        let blogList = [];
        if (Metro.storage.getItem("BlogList", null)[0].Menu == undefined) {
            let lastGuid = null, menuItem = {};
            let portalMenu = Metro.storage.getItem('BlogList', null);
            portalMenu.forEach((mItem, index, arr) => {

                switch (mItem.apiTableColumnName) {
                    case "MenuName":
                        menuItem.Menu = mItem.value;
                        menuItem.RecGuid = mItem.recGuid;
                        break;
                    case "HtmlContent":
                        menuItem.HtmlContent = mItem.value;
                        break;
                    default:
                }

                if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
                    blogList.push(menuItem);
                    menuItem = {};
                }

                lastGuid = mItem.recGuid;
            });
            blogList.sort((a, b) => a.Menu > b.Menu ? 1 : -1);
            Metro.storage.setItem('BlogList', blogList);
        }

        blogList = Metro.storage.getItem('BlogList', null);
        let menuName = null;
        let html = `<div data-role="accordion" data-one-frame="true" data-show-active="true">`;
        blogList.forEach(blog => {
            if (menuName == null || menuName != blog.Menu) {
                if (menuName != null) { html += `</ul></div></div>`; }
                html += `<div class="frame"><div class="heading">${blog.Menu}</div><div class="content"><ul class="step-list">`;
            }
            if (search == null || (search != null && blog.HtmlContent.toLowerCase().indexOf(search.toLowerCase()) > -1)) { html += `<li>${blog.HtmlContent}</li>`; }
            menuName = blog.Menu;
        });
        html += `</ul></div></div></div>`;
        $("#MenuBlog").html(html);
    
    }, 1000);
}



Gs.Objects.ShowOnlineTools = function () {
    if (Metro.charms.isOpen("#OnlineToolPanel")) { Metro.charms.close("#OnlineToolPanel"); }
    else { Metro.charms.open("#OnlineToolPanel"); }
}