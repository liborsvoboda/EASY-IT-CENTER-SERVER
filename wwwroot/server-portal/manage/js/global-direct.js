/**
* Functions for Using after API Call is finished
*/

/**
* Invalid Login Form
* @function
* @param {string} str Input text
* @return {string} Filtered text
*/
function InvalidForm() {
    var form = $(this); form.addClass("ani-ring");
    setTimeout(function () { form.removeClass("ani-ring"); }, 1000);
}


/**
* Validate Login Form
* @function
* @return {boolean} Validation Status
*/
function ValidateForm() {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/AuthenticationService",
        async: true,
        cache: false,
        headers: { "Authorization": "Basic " + btoa($("#usernameId").val() + ":" + $("#passwordId").val()) },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            Cookies.set('ApiToken', result.Token);
            Metro.storage.setItem("ApiToken", result);
            Gs.Behaviors.HidePageLoading();
            window.location.href = Metro.storage.getItem("DefaultPath", null);
            return true;
        },
        error: function (err) {
            console.log(err);
            Cookies.remove('ApiToken');
            Metro.storage.delItem("ApiToken");
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });

}


/**
* Validate Registration Form
* @function
* @return {boolean} Validation status
*/
function ValidateRegForm() {
    Gs.Behaviors.ShowPageLoading();
    $.ajax({
        global: false,
        type: "POST",
        url: Metro.storage.getItem('BackendServerAddress', null) + "/RegistrationService/Registration",
        async: true,
        cache: false,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify({ FirstName: $("#firstName").val(), Surname: $("#surname").val(), Username: $("#userName").val(), EmailAddress: $("#email").val(), Password: $("#password").val() }),
        success: function (result) {
            if (result.Status != "success") { Gs.Objects.ShowNotify("alert", result.ErrorMessage); }
            else { Gs.Objects.ShowNotify("success", result.Status); }
            Gs.Behaviors.HidePageLoading();
            return true;
        },
        error: function (err) {
            console.log(err);
            Gs.Behaviors.HidePageLoading();
            Gs.Objects.ShowNotify("alert", err.statusText); return false;
        }
    });

}


/**
* Set Stripe Public Key
* @function
*/
function SetStripeKey() {
    Gs.Variables.stripe = Stripe(Metro.storage.getItem("StripePublicKey", null));
}


/**
* Function for  Mermaid Data to Graphics Conversion
* @function
*/
async function Mermaid() { try { await mermaid.run({ nodes: document.querySelectorAll('.class-mermaid'), }); } catch (err) { } }


/**
* Function for Highlighting Code Segments
* @function
*/
function HighlightCode() {
    //hljs.highlightAll()
    document.querySelectorAll('div.code').forEach(el => { hljs.highlightElement(el); });
}


/**
* Refresh Portal Menu List with Run Generate Menu List After done
* @function
*/
async function RefreshPortalMenuList() {
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetApiTableDataList/PortalMenu", "PortalMenuList", "GenerateMenuList");
}


/**
* Function Set Question Count for Admin
* @function
*/
function SetQuestionCount() {
    let myQuestionList = []; let group = null; menuItem = {}; let data = [];
    let origQuestionList = Metro.storage.getItem('AdminQuestionList', null);

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
                menuItem.Id = item.id;
                menuItem.Response = item.value;
                break;
        }
        if (group != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != item.recGuid)) {
            myQuestionList.push(menuItem);
            menuItem = {};
        }
        group = item.recGuid;
    });
    Metro.storage.setItem('AdminQuestionList', myQuestionList);
    $("#QuestionCount").html(myQuestionList.length.toString());
}


/**
* Function Generate Menu List of Portal
* @function
* @param {boolean} ignoreUrl ignore URL Option
*/
function GenerateMenuList(ignoreUrl = false) {
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
                menuItem.AccessRoleWrite = mItem.accessRoleWrite != null ? mItem.accessRoleWrite.split(",") : "";
                menuItem.AccessUserWrite = mItem.accessUserWrite != null ? mItem.accessUserWrite.split(",") : "";
                menuItem.AccessRoleRead = mItem.accessRoleRead != null ? mItem.accessRoleRead.split(",") : "";
                menuItem.AccessUserRead = mItem.accessUserRead != null ? mItem.accessUserRead.split(",") : "";
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
            case "MdContent":
                menuItem.MdContent = mItem.value;
                menuItem.MdContentId = mItem.id;
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
            htmlContent = '<li id="' + mItem.Name.replaceAll(/\s/g, '') +'" onclick=Gs.Behaviors.SetLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        } else if (mItem.InheritedMenuType == "externalLink") {
            htmlContent = '<li id="' + mItem.Name.replaceAll(/\s/g, '') +'" onclick=Gs.Behaviors.SetExternalLink(' + mItem.HtmlContentId + ',"' + mItem.HtmlContent + '"); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;

        }

        else if (mItem.InheritedMenuType == "content") {
            htmlContent = '<li id="' + mItem.Name.replaceAll(/\s/g, '') +'" onclick=Gs.Behaviors.SetContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }

        else if (mItem.InheritedMenuType == "externalContent") {
            htmlContent = '<li id="' + mItem.Name.replaceAll(/\s/g, '') +'" onclick=Gs.Behaviors.SetExternalContent(' + mItem.HtmlContentId + ',' + mItem.JsContentId + ',' + mItem.CssContentId + '); ' + (Metro.storage.getItem('UserSettingList', null).EnableShowDescription && mItem.Description != null && mItem.Description.length > 0 ? ' data-role="hint" data-hint-text="' + mItem.Description + '"' : "''") + ' ><a href= "#' + mItem.Name + '" ><span class="icon"><span class="' + mItem.Icon + '"></span></span><span class="caption">' + mItem.Name + '</span></a></li >';
            document.getElementById(mItem.ParentGuid).innerHTML = document.getElementById(mItem.ParentGuid).innerHTML + htmlContent;
        }


    });

    try {
        //Load Menu from Selected URL
        if (currentMenu != undefined && !ignoreUrl) { $(`#${currentMenu}`).click(); }
    } catch { }
}


/**
* function Edit Blog Menu generate full Blog Page
* @function
* @param {string} search Search text in Blog
*/
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


/**
* Function Load Favorites API
* @function
*/
async function LoadFavorites() {
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetFavoritesList", "FavoritesList", "GenerateFavorites");
}


/**
* Function Generate Favorites Icons to Menu after API
* @function
*/
function GenerateFavorites() {
    let lastGuid = null, menuItem = {}, menu = [];
    let favoritesList = Metro.storage.getItem('FavoritesList', null);

    favoritesList.forEach((mItem, index, arr) => {

        switch (mItem.apiTableColumnName) {
            case "MenuGroup":
                menuItem.MenuGroup = mItem.value;
                menuItem.RecGuid = mItem.recGuid;
                menuItem.Id = mItem.id;
                menuItem.Description = mItem.description;
                break;
            case "MenuName":
                menuItem.MenuName = mItem.value;
                break;
            case "MenuIcon":
                menuItem.MenuIcon = mItem.value;
            case "MenuNewWindow":
                menuItem.MenuNewWindow = mItem.value;
                break;
                break;
            case "MenuUrl":
                menuItem.MenuUrl = mItem.value;
                break;
            default:
        }

        if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
            menu.push(menuItem);
            menuItem = {};
        }

        lastGuid = mItem.recGuid;
    });
    menu.sort((a, b) => a.MenuName > b.MenuName ? 1 : -1);
    Metro.storage.setItem('FavoritesList', menu);

    let menuWeb = "", menuGithub = "", menuServer = "";
    menu.forEach(favorite => {
        let cmd = favorite.MenuNewWindow.toLowerCase() == "false" ? `Gs.Objects.WindowIframeCreate('${favorite.MenuName}','${favorite.MenuUrl}')` : `window.open('${favorite.MenuUrl}')`;

        if (favorite.MenuGroup == "Web") {
            menuWeb += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveFavorite('${favorite.MenuName}','${favorite.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${favorite.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${favorite.Description}</p>
                        </div>
                    </div>`;
        } else if (favorite.MenuGroup == "Github") {
            menuGithub += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveFavorite('${favorite.MenuName}','${favorite.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${favorite.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${favorite.Description}</p>
                        </div>
                    </div>`;
        } else if (favorite.MenuGroup == "Server") {
            menuServer += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveFavorite('${favorite.MenuName}','${favorite.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${favorite.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${favorite.Description}</p>
                        </div>
                    </div>`;
        }

    });
    $("#WebMenu").html(menuWeb); $("#GithubMenu").html(menuGithub); $("#ServerMenu").html(menuServer);
}

/**
* Function Load Online Tool List
* @function
*/
async function LoadOnlineToolList() {
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetOnlineToolList", "OnlineToolList", "GenerateOnlineToolList");
}


/**
* Function Generate Online Tool List to Menu After API
* @function
*/
function GenerateOnlineToolList() {
    let lastGuid = null, menuItem = {}, menu = [];
    let onlineToolList = Metro.storage.getItem('OnlineToolList', null);

    onlineToolList.forEach((mItem, index, arr) => {

        switch (mItem.apiTableColumnName) {
            case "MenuGroup":
                menuItem.MenuGroup = mItem.value;
                menuItem.RecGuid = mItem.recGuid;
                menuItem.Id = mItem.id;
                menuItem.Description = mItem.description;
                break;
            case "MenuName":
                menuItem.MenuName = mItem.value;
                break;
            case "MenuIcon":
                menuItem.MenuIcon = mItem.value;
            case "MenuNewWindow":
                menuItem.MenuNewWindow = mItem.value;
                break;
                break;
            case "MenuUrl":
                menuItem.MenuUrl = mItem.value;
                break;
            default:
        }

        if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
            menu.push(menuItem);
            menuItem = {};
        }

        lastGuid = mItem.recGuid;
    });
    menu.sort((a, b) => a.MenuName > b.MenuName ? 1 : -1);
    Metro.storage.setItem('OnlineToolList', menu);

    let menuOnline = "", menuData = "", menuDeveloper = "";
    menu.forEach(online => {
        let cmd = online.MenuNewWindow.toLowerCase() == "false" ? `Gs.Objects.WindowIframeCreate('${online.MenuName}','${online.MenuUrl}')` : `window.open('${online.MenuUrl}')`;

        if (online.MenuGroup == "Online Tool") {
            menuOnline += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveOnlineTool('${online.MenuName}','${online.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${online.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${online.Description}</p>
                        </div>
                    </div>`;
        } else if (online.MenuGroup == "Data Tool") {
            menuData += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveOnlineTool('${online.MenuName}','${online.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${online.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${online.Description}</p>
                        </div>
                    </div>`;
        } else if (online.MenuGroup == "Developer") {
            menuDeveloper += `<div data-role="tile" class="m-1 shadowed" data-size="small" data-effect="hover-slide-up">
                        <span class="mif-cancel pos-absolute fg-red" style="right:0px;z-index: 2000;" onclick="Gs.Objects.RemoveOnlineTool('${online.MenuName}','${online.RecGuid}')"></span>
                        <div class="slide-front" onclick="${cmd}">
                            
                            <span class="row p-2" style="font-size: 12px;">${online.MenuName}</span>
                        </div>
                        <div class="slide-back d-flex flex-justify-center flex-align-center p-4 op-mauve" style="font-size: 10px;" onclick="${cmd}">
                            <p class="text-center"> ${online.Description}</p>
                        </div>
                    </div>`;
        }

    });
    $("#OnlineMenu").html(menuOnline); $("#DataMenu").html(menuData); $("#DeveloperMenu").html(menuDeveloper);
}


/**
* Function Load Search Window API
* @function
*/
async function LoadSearchWindow() {
    if ($("#SearchWindow").html != undefined) { Metro.window.close("#SearchWindow"); }
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetWebSearchList", "WebSearchList", "GenerateWebSearchList");
}

/**
* Function Generate Web Search List for Search Window
* @function
*/
function GenerateWebSearchList() {
    let lastGuid = null, menuItem = {}, menu = [];
    let webSearchList = Metro.storage.getItem('WebSearchList', null);

    webSearchList.forEach((mItem, index, arr) => {

        switch (mItem.apiTableColumnName) {
            case "MenuName":
                menuItem.MenuName = mItem.value;
                menuItem.RecGuid = mItem.recGuid;
                menuItem.Description = mItem.description;
                break;
            case "MenuNewWindow":
                menuItem.MenuNewWindow = mItem.value;
                break;
            case "MenuUrl":
                menuItem.MenuUrl = mItem.value;
                break;
            default:
        }

        if (lastGuid != null && (arr[index + 1] == undefined || arr[index + 1].recGuid != mItem.recGuid)) {
            menu.push(menuItem);
            menuItem = {};
        }

        lastGuid = mItem.recGuid;
    });
    menu.sort((a, b) => a.MenuName > b.MenuName ? 1 : -1);
    Metro.storage.setItem('WebSearchList', menu);

    let html = `<button class="button success pos-absolute mb-4" style="z-index: 2000;right: 200px;" onclick="Gs.Objects.AddWebSearchList()"><span class="mif-plus mif-3x"></span>Add Web Search</button>
    <button class="button alert pos-absolute mb-4" style="z-index: 2000;right: 0px;" onclick="Gs.Objects.GenerateRemoveWebSearchList()"><span class="mif-minus mif-3x"></span>Remove Web Search</button>
    <ul data-role="tabs" data-expand="true">`;
    menu.forEach(search => {
        if (search.MenuNewWindow.toLowerCase() == "false") { html += `<li><a href="#menu${search.MenuName.replace(/\s/g, "")}">${search.MenuName}</a></li>`; }
    });
    html += `</ul><div class="border bd-default no-border-top p-2" style="height: calc(100% - 100px);">`;
    menu.forEach((search, index) => {
        if (search.MenuNewWindow.toLowerCase() == "false") {
            html += `<div id="menu${search.MenuName.replace(/\s/g, "")}" style="overflow-y: auto;height: 100%;">
                <iframe src="${search.MenuUrl}" width="100%" height="100%" frameborder="0" scrolling="yes" style="width:100%; height:100%;position: fixed;"></iframe></div>`;
        } else { window.open(`${search.MenuUrl}`); }
    });
    html += `</div>`;

    Gs.Objects.WindowHtmlCreate("SearchWindow", "Global Search", html);
}


/**
* Function Load Notes List API
* @function
*/
async function LoadNotesList() {
    await Gs.Apis.RunServerGetApi("PortalApiTableService/GetNotesList", "NotesList", "OpenNotesList");
}


/**
* Function Open Notes List for Generate Notes Window
* @function
*/
function OpenNotesList() {
    let html = `
    <BUTTON onclick="Gs.Functions.SaveNotesList();" class="button success c-pointer outline shadowed" style="position:absolute; top:22px;right:60px;z-index:2500;">Save Notes</BUTTON>
    <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
        <DIV id=_menuCodeContent class="w-100" style="max-height: 750px;overflow: hidden;">
            <iframe id="NotesListEditor" src="/server-tools/Editor/markdown/index.html" width="100%" height="700" frameborder="0" scrolling="yes" style="width:100%; height:900px;"></iframe>
        </DIV >
    </DIV >`;

    Gs.Objects.InfoboxObjectCreate("EditNotesList", html, width = "100%", height = "800");

    setTimeout(async function () {
        $('#NotesListEditor')[0].contentWindow.mdEditor.setMarkdown(Metro.storage.getItem("NotesList", null)[0] != undefined ? Metro.storage.getItem("NotesList", null)[0].value : " ");
    }, 1000);
}



