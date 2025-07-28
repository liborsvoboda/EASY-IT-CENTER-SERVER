
Gs.Objects.ShowToolPanel = function (close) {
    $("#UserAutomaticTranslate").val('checked')[0].checked = Metro.storage.getItem('UserAutomaticTranslate', null);
    if (close) { Metro.bottomsheet.close($('#ToolPanel')); } else {
        if (Metro.bottomsheet.isOpen($('#ToolPanel'))) { Metro.bottomsheet.close($('#ToolPanel')); }
        else { Metro.bottomsheet.open($('#ToolPanel')); }
    }
}


//Global Tool Panel
Gs.Objects.CreateToolPanel = function () {
    let html = '<div id="ToolPanel" data-role="bottom-sheet" class="bottom-sheet pos-fixed list-list grid-style opened" style="top: 0px; left: 90%; z-index:10000;min-width: 430px;">';
    html += '<div class="c-pointer mif-cancel mif-1x icon pos-absolute fg-red" style="top:5px;right:5px;" onclick=Gs.Objects.ShowToolPanel(); ></div>';
    //html += '<div class="w-100 text-left"> <audio id="radio" class="light bg-transparent" data-role="audio-player" data-src="/server-integrated/razor-pages/serverportal/media/hotel_california.mp3" data-volume=".5"></audio> </div>';
    html += '<div class="w-100 text-left" style="z-index: 1000000;"><div id="google_translate_element"></div></div>';
    html += '<div class="w-100 d-inline-flex"><div class="w-75 text-left">';
    html += '<input id="UserAutomaticTranslate" type="checkbox" data-role="checkbox" data-cls-caption="fg-cyan text-bold" data-caption="Auto Translate" onchange=Gs.Behaviors.UserChangeTranslateSetting(); checked >';
    html += '</div><div class="w-25 mt-1 text-right" style="max-width:25% !important;"><button class="button secondary mini" style="max-width:100% !important;" onclick=Gs.Behaviors.CancelTranslation(); >Cancel Translate</button></div>';
    html += '</div><div class="d-flex w-100" title="Theme">';
    let themes = [
        ["#585b5d", "darcula.css?white"], ["#AF0015", "red-alert.css?white"], ["#690012", "red-dark.css?white"], ["#0CA9F2", "sky-net.css?white"],
        ["#585b5d", "darcula.css?#585b5d"], ["#AF0015", "red-alert.css?#AF0015"], ["#690012", "red-dark.css?#690012"], ["#0CA9F2", "sky-net.css?#0CA9F2"]
    ];
    themes.forEach((theme, index) => {
        html += '<button class="button shadowed w-50px ' + (index < 4 ? "opc-05" : "") + ' mt-1" style="background-color: ' + theme[0] + ';" onclick=Gs.Behaviors.ChangeSchemeTo(\'' + theme[1] + '\'); ></button>';
        if (index == 3) { html += '</div><div class="d-flex w-100" title="BackGround">'; }
    });

    let injectToolPanel = document.createElement("div");
    injectToolPanel.innerHTML = html;
    document.body.append(injectToolPanel);
};


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
    Logout();
    var html_content =
        "<h3>Neautorizovaný Přístup</h3>" +
        "<p>Pokoušíte se provést autorizovanou operaci neoprávněně,</p>" +
        "<p>nebo platnost vašeho tokenu vypršela.</p>";
    Metro.infobox.create(html_content, "alert");
}




Gs.Objects.GenerateMenu = function () {
    let htmlContent = "";// '<li class="item-header">Portal MENU</li>';

    let lastGuid = null, menuItem = {}, portalMenu = [];
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('PortalMenu', null)));
 
    menu.forEach((mItem, index, arr) => {

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
            default:
        }

        if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
            portalMenu.push(menuItem);
            menuItem = {};
        }

        lastGuid = mItem.recGuid;
    });
    portalMenu.sort((a, b) => a.Sequence > b.Sequence ? 1 : -1);
    Metro.storage.setItem('Menu', portalMenu);

    portalMenu.forEach((mItem, index, arr) => {
        if (mItem.InheritedMenuType == "menu") {
            htmlContent += '<li id= ' + mItem.Sequence + ' ><a href="#" class="dropdown-toggle"><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a>';
            htmlContent += '<ul id = ' + mItem.RecGuid + ' class="navview-menu stay-open" data-role="dropdown"><li class="item-header" > ' + mItem.Name + '</li></ul>';
            htmlContent += '</li>';
        }
        document.getElementById("PortalMenu").innerHTML = htmlContent;
    });
    
    portalMenu.forEach((mItem, index, arr) => {
        if (mItem.InheritedMenuType == "link") {
            htmlContent = '<li onclick=Gs.Behaviors.SetLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        } else if (mItem.InheritedMenuType == "externalLink") {
            htmlContent = '<li onclick=Gs.Behaviors.SetExternalLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        }

        else if (mItem.InheritedMenuType == "content") {
            htmlContent = '<li onclick=Gs.Behaviors.SetContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }

        else if (mItem.InheritedMenuType == "externalContent") {
            htmlContent = '<li onclick=Gs.Behaviors.SetExternalContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }
    });
}



Gs.Objects.ShowLoginPage = function () {
    let htnlContent = '<DIV class=text-center><WINDOW><DIV class="hero hero-bg 1bg-brand-secondary add-neb"><DIV class=container><DIV class=row>';
    htnlContent += '<FORM id=loginform class="login-form bg-white fg-darkBlue p-6 mx-auto border bd-default win-shadow" method=post action=javascript: data-role="validator" data-on-validate-form="ValidateForm" data-on-error-form="InvalidForm" data-clear-invalid="2000"><SPAN class="mif-vpn-lock mif-4x place-right" style="MARGIN-TOP: -10px"></SPAN>';
    htnlContent += '<H2 class=text-light>EIC&ESB Portal</H2>'
    htnlContent += '<DIV class=form-group><INPUT id=usernameId class=input style="HEIGHT: auto" maxLength=50 data-role="input" data-validate="required" placeholder="Insert Username..." data-prepend="<span class=\'mif-envelop\'>"> </DIV>';
    htnlContent += '<DIV class=form-group><INPUT id=passwordId type=password data-role="input" data-validate="required minlength=6" placeholder="Insert Password..." data-prepend="<span class=\'mif-key\'>"> </DIV>';
    htnlContent += '<DIV class="form-group mt-10"><INPUT class=place-right type=checkbox data-role="checkbox" data-caption="Remember"><BUTTON class="button shadowed">Přihlásit</BUTTON> </DIV></FORM></DIV></DIV></DIV></WINDOW></DIV>';
    document.getElementById("FrameWindow").innerHTML = htnlContent;
}


Gs.Objects.ShowNotify = Metro.notify; Gs.Objects.ShowNotify.setup({
    width: Gs.Variables.defaultSetting[0].notifyWidth,
    duration: Gs.Variables.defaultSetting[0].notifyDuration,
    animation: Gs.Variables.defaultSetting[0].notifyAnimation
});

Gs.Objects.ShowMessagePanel = function (close) {
    charms = Metro.getPlugin($("#charmPanel"), 'charms');
    if (close) {
        charms.close();
    } else { charms.toggle(); }
}