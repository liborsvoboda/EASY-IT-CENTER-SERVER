

/**
* Function Generate and Show New Form Page on Portal Menu
* @function
*/
Gs.Generator.GenerateFormRequest = async function () {
    let content = `<p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Table Name and Load Table Field">Table Name</p>
    <div><input id='menuGeneratorTableName' type='text' data-role='input' ><button class="button success mb-4 shadowed" style="position: absolute;right: 0px;" onclick="Gs.Generator.GetTableSchemaList();">Load Fields</button>
    <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Select Table Fields for Form Table which will be shown">Select Table Fields</p>
    <select id="menuGeneratorTableSchema" data-role="select" data-cls-select="" data-clear-button="true" data-prepend="Select Table Fields" multiple></select>
     <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Page Name">Insert Page Name</p>
    <input id='menuGeneratorName' type='text' data-role='input' >
    <button class="button primary mb-4 shadowed" style="position: absolute;right: 0px;" onclick="Gs.Generator.GeneratePage();">Generate</button>
    <p></p>
    </div>`;
    let actions = [{
        caption: "Close", cls: "js-dialog-close success",
        onclick: function () {
            if ($("#menuGeneratorTableName").val().length > 0 && $("#menuGeneratorName").val().length > 0) {

            } else { alert("Data must be Inserted"); }
        }
    }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }];
    Gs.Objects.CreateDialogRequest("Generate new Form Page", content, actions);
}



Gs.Generator.GeneratePage = function () {
    if ($("#menuGeneratorTableName").val().length > 0 && $("#menuGeneratorName").val().length > 0) {
        let html = "";
        html = Gs.Generator.GeneratorHtmlHeader();
        html += Gs.Generator.GeneratorHtmlButtons();
        html += Gs.Generator.GeneratorHtmlTable();
        html += Gs.Generator.GeneratorHtmlForm();
        html += Gs.Generator.GeneratorHtmlEditors();
        html += Gs.Generator.GeneratorPageFooter();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].editor.getModel().setValue(html);

        let javascript = "";
        javascript = Gs.Generator.GeneratorJavascriptInit();
        javascript += Gs.Generator.GeneratorJavascriptStartUp();
        javascript += Gs.Generator.GeneratorJavascriptReloadTable();
        javascript += Gs.Generator.GeneratorJavascriptClearForm();
        javascript += Gs.Generator.GeneratorJavascriptSetEmptyEditor();
        javascript += Gs.Generator.GeneratorJavascriptSetRecId();
        javascript += Gs.Generator.GeneratorJavascriptMenuToJson();
        javascript += Gs.Generator.GeneratorJavascriptSaveMenu();
        javascript += Gs.Generator.GeneratorJavascriptDeleteSelectedMenu();
        javascript += Gs.Generator.GeneratorJavascriptCopyRecord();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].editor.getModel().setValue(javascript);

        let css = "";
        css = Gs.Generator.GeneratorCss();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].editor.getModel().setValue(css);
        Gs.Objects.ShowNotify("info", "Page was Generated");
    } else { Gs.Objects.ShowNotify("alert", "Page was Not Generated. Insert Data First"); }
}


/**
* Function Get Table Schema List
* @function
*/
Gs.Generator.GetTableSchemaList = async function () {
    await Gs.Apis.RunServerGetApi(`DatabaseService/SpGetTableSchema/${$("#menuGeneratorTableName").val()}`, "TableSchemaList", "GeneratorLoadTableSchema");
    $("#menuGeneratorName").val(Gs.Functions.AddSpaceCamelCase($("#menuGeneratorTableName").val()));
}


/**
* Function Generate Page Header
* @function
*/
Gs.Generator.GeneratorHtmlHeader = function() {
    let html = `<HTML><HEAD><META content=text/html;utf-8 http-equiv=content-type>`;

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            html += ``;
        }
    });
    html +=`</HEAD>
<BODY>
<DIV class="text-center mb-4 pb-5">
    <WINDOW>
        <DIV id=TogglePanelBackground class=panel style="MIN-HEIGHT: 700px">
            <FORM class=form1 action=javascript: data-role="validator" data-on-error="formIsValid = false;" autocomplete="off" data-interactive-check="true" data-on-submit="formIsValid = true;">
                <DIV class=d-block>
                    <DIV class="d-flex row gutters mr-4">
                        <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-6 pl-5 pt-5 mb-0">
                            <UL data-role="tabs" data-on-tab="" data-tabs-type="text" data-expand="true">
                                <LI class="fg-black "><A href="#_menuList">${$("#menuGeneratorName").val()}</A></LI>
                                <LI class="fg-black "><A href="#_menuForm">Form</A></LI>`
                                tableSchemaList.forEach(schema => {
                                    if (schema.data.toLowerCase() == "codecontent" ||schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
                                        html += `
                                        <LI class="fg-black "><A href="#_menuCodeEditor">Code Content</A></LI>`;
                                    }
                                    if (schema.data.toLowerCase() == "mdcontent") {
                                        html += `
                                        <LI class="fg-black "><A href="#_menuMdEditor">MarkDown Content</A></LI>`;
                                    }
                                    if (schema.data.toLowerCase() == "jsoncontent") {
                                        html += `
                                        <LI class="fg-black "><A href="#_menuJsonEditor">JSON Content</A></LI>`;
                                    }
                                });
                    html += `</UL>
                       </DIV>`;
    return html;

}


/**
* Function Generate Page Buttons
* @function
*/
Gs.Generator.GeneratorHtmlButtons = function () {
    let html = `
    <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
        <DIV class=text-right>
            <BUTTON id="copyButton" class="button primary outline shadowed" type=button onclick=CopyRecord();  >Copy</BUTTON>
            <BUTTON class="button warning outline shadowed" type=reset onclick=ClearForm(); >Clear Form</BUTTON>
            <BUTTON onclick="saveNewRec= false;SaveMenu();" class="button success outline shadowed" type=submit>Save</BUTTON>
            <BUTTON id="deleteButton" class="button alert outline mt-5 shadowed" type=button onclick=DeleteSelectedMenu();  >Delete</BUTTON>
    </DIV></DIV>`;


    return html;
}


/**
* Function Generate Page Table
* @function
*/
Gs.Generator.GeneratorHtmlTable = function () {
    let html = `
    <DIV id="_menuList" style="width:100%;">
        <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
        <DIV class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <TABLE id=menuTable class="table striped table-border text-left mt-4" data-role="table" data-use-current-slice="true" data-on-check-click="SetRecId()" data-check-type="radio" data-check-style="1" data-check="true" data-show-all-pages="false" data-pagination="true" data-rows="30" data-show-activity="true" data-cls-component="mt-10">
                <THEAD><TR>
                    <TH data-sortable="true">Id</TH>
                    <TH data-sortable="true">Name</TH>
                    <TH data-sortable="true">Active</TH>
                    </TR></THEAD>
                <TBODY></TBODY>
            </TABLE>
     </DIV></DIV></DIV>`;

    return html;
}


/**
* Function Generate Page Form
* @function
*/
Gs.Generator.GeneratorHtmlForm = function () {

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);

    let html = `
    <DIV id="_menuForm" style="width:100%;">
    <DIV class="d-flex row gutters ml-5 mr-5 mb-5 border">
    `;

    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "tablename") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${Gs.Functions.AddSpaceCamelCase(schema.data)}">
                    </select>
            </DIV></DIV>`;
        }
        else if (schema.data.toLowerCase().startsWith("inherited")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${Gs.Functions.AddSpaceCamelCase(schema.data)}">
                    </select>
            </DIV></DIV>`;
        }
        // Ignored Fields
        else if (schema.data.toLowerCase() == "id" || schema.data.toLowerCase() == "timestamp" || schema.data.toLowerCase() == "userid"
            || schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent"
            || schema.data.toLowerCase() == "csscontent" || schema.data.toLowerCase() == "jsoncontent" || schema.data.toLowerCase() == "mdcontent"
            || schema.data.toLowerCase() == "autoversion") {
            html += ``;
        }
        else if (schema.data.toLowerCase() == "description") {
            html += `
            <DIV class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                <DIV class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                    <DIV class="form-group text-left">
                        <p>Description</p>
                        <div id="menu${schema.data}"></div>
            </DIV></DIV></DIV>
            `;
        } else if (schema.data.toLowerCase() == "accessrole" || schema.data.toLowerCase() == "accessuser") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${Gs.Functions.AddSpaceCamelCase(schema.data)}" multiple>
                    </select>
            </DIV></DIV>`;
        } else if (schema.data.toLowerCase() == "sequence") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-step="10" data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-black'></span>" data-minus-icon="<span class='mif-minus fg-black'></span>" >
            </DIV></DIV>`;
        }
        else if (schema.dataType.toLowerCase() == "decimal") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-black'></span>" data-minus-icon="<span class='mif-minus fg-black'></span>" >
            </DIV></DIV>`;
        }
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("date")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="calendarpicker" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')}>
            </DIV></DIV>`;
        }
        //else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("datetime")) {
        //    html += `
        //    <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
        //        <DIV class="form-group">
        //        <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
        //            <input id="menu${schema.data}"  type="text" data-role="spinner" data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
        //    </DIV></DIV>`;
        //}
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("time")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" data-role="timepicker" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')}>
            </DIV></DIV>`;
        }
        else if (schema.dataType.toLowerCase() == "int") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}"  type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
            </DIV></DIV>`;
        }
        else if (schema.dataType.toLowerCase() == "varchar") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
                <DIV class="form-group">
                    <INPUT id="menu${schema.data}" style="HEIGHT: auto" data-role="input" ${(schema.dataNull == 'YES' ? 'data-validate="required"' :'')} data-validate="required" autocomplete="off" data-label="${Gs.Functions.AddSpaceCamelCase(schema.data)}">
            </DIV></DIV>
            `;
        }
        else if (schema.dataType.toLowerCase() == "bit") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
                <DIV class="form-group pt-5">
                    <INPUT id="menu${schema.data}" style="HEIGHT: auto" autocomplete="off" data-role="checkbox" data-caption="${Gs.Functions.AddSpaceCamelCase(schema.data)}">
            </DIV></DIV>
            `;
        }
    });


    html += `</DIV></DIV>`;
    return html;
}


/**
* Function Generate Page Editors
* @function
*/
Gs.Generator.GeneratorHtmlEditors = function () {
    let html = ``;
    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "codecontent" ||schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            html +=`<DIV id="_menuCodeEditor" style="width:100%;">
                        <div id="monacoPreview" style='top: -50px;' ></div>

                            <select id="CodeContentEditorTheme" class="theme" style='position: absolute;z-index: 2000;top: 0px;right: 20px;'>
                                <option>vs-dark</option>
                                <option>vs</option>
                                <option>hc-black</option>
                            </select>
                            <select id="CodeContentEditorLang" class="language" style='position: absolute;z-index: 2000;top: 30px;right: 20px;'>
                            </select>
                        </DIV>
                     </div>`;
        }
        if (schema.data.toLowerCase() == "jsoncontent") {
            html += `<div id="_menuJsonEditor" class="w-100">
                        <div style="overflow:auto;width:100%; height:800px;">
                            <iframe id="JsonEditor" src="/server-tools/Editor/jsonData/index.html" width="100%" height="600" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>
                        </div>
                    </div>`;
        }
        if (schema.data.toLowerCase() == "mdcontent") {
            html += `<div id="_menuMdEditor" class="w-100">
                        <div style="overflow:auto;width:100%; height:700px;">
                            <iframe id="HelpEditor" src="/server-tools/Editor/markdown/index.html" width="100%" height="700" frameborder="0" scrolling="yes" style="width:100%; height:100%;"></iframe>
                        </div>
                    </div>`;
        }
    });
    return html;
}


/**
* Function Generate Close Page Footer
* @function
*/
Gs.Generator.GeneratorPageFooter = function () {
    let html = `
        </DIV></DIV>
        </FORM></DIV></WINDOW>

        <DIV class=mb-10></DIV>
        </DIV></BODY></HTML>
    `;
    return html;
}


/**
* Function Generate Css for Page
* @function
*/
Gs.Generator.GeneratorCss = function () {
    let css = ``;
    css += `
    .monaco-editor {
	    min-width: 100%;
	    width: 100%;
	    min-height: 100%;
    }
    .monacocontainer {
        min-height: 100%;
        text-align: left;
    }`;
    return css;

}


/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptInit = function () {
    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "description") { }
    });
    let javascript = `
    //Declarations
    formIsValid = false;
    copyRecord = false;
    `;

    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "description") {
            javascript += `
            //Startup Actions
            `;
        }
    });

    let select = Metro.getPlugin("#menuGeneratorTableSchema", "select");

    javascript += `const tableHeaders = [`;
    select.val().forEach(header => {
        javascript += `{ "type": "data", "title": "${header}", "name": "${header}", "sortable": true, "format": "string", "show": true, },`;
    });
    javascript += `]

    //Startup Actions
    $(document).ready(function () { StartUp(); });
    `;
    return javascript;
}



/**
* Function Generate Javascript Page StartUp
* @function
*/
Gs.Generator.GeneratorJavascriptStartUp = function () {
    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);

    let javascript = `
    async function StartUp() {

        $('#menuDescription').summernote({tabsize: 2,height: 150, maxHeight: 150,
            lang: 'cs-CZ',
            placeholder: 'write Description...',
            toolbar: [['style', ['style']],['font', ['bold', 'underline', 'clear']],['fontname', ['fontname']],
                ['fontsize', ['fontsize']],['color', ['color']],['para', ['ul', 'ol', 'paragraph']],['table', ['table']],
                ['insert', ['link', 'picture', 'video']],['view', ['fullscreen', 'codeview', 'undo', 'redo', 'help']]]
        });
    `;
    
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `
                if(Gs.Variables.monacoEditorList.findIndex(item => item.elementId === 'monacoPreview') != -1) {
                    Gs.Variables.monacoEditorList.splice(Gs.Variables.monacoEditorList.findIndex(item => item.elementId === 'monacoPreview'),1);
                    let dataJs = await fetch("/server-portal/addons/monaco/js/codePreview.js").then((r) => r.text())
                    new Function(dataJs)();
                } else {
                    let dataJs = await fetch("/server-portal/addons/monaco/js/codePreview.js").then((r) => r.text())
                    new Function(dataJs)();
                }
            `;
        }
    });

    javascript +=`
        let jsonData = null;
        `;

    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "acessrole") {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure)); jsonData[1].tableName = "SolutionUserRoleList";
                    Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionUserRoleList" } );
                `;

        } else if (schema.data.toLowerCase() == "acessuser") {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "SolutionUserList";
                Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionUserList" } );
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "SolutionMixedEnumList";
                Gs.Variables.apiTaskList.push({ UUID:Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionMixedEnumList" } );
            `;
        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "${schema.data.split("List")[0]}List";
                Gs.Variables.apiTaskList.push({ UUID:Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "${schema.data.split("List")[0]}List" } );
            `;
        }
    });

    javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
                Gs.Variables.apiTaskList.push({ UUID:Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "${$("#menuGeneratorTableName").val() }", WindowFunction: "ReloadTable" } );


                let table = Metro.getPlugin("#menuTable", "table");
                table.heads = tableHeaders[0];

}
`;
    return javascript;
}



/**
* Function Generate Javascript Page ReloadTable
* @function
*/
Gs.Generator.GeneratorJavascriptReloadTable = function () {
    let select = Metro.getPlugin("#menuGeneratorTableSchema", "select"); 
    
    let javascript = `
    
    function ReloadTable(){
        let data = [];
        Gs.Functions.AddClass("deleteButton", "disabled");
        let tableData = Metro.storage.getItem("${$("#menuGeneratorTableName").val()}", null);
        tableData.forEach(item => { data.push([ 
            `;
    select.val().forEach(header => {
        javascript += `item.${header},`;
    });
    javascript += `
        ]); });
        let table = Metro.getPlugin("#menuTable", "table");
        table.clear();table.clearSelected();table.setItems(data); table.reload();
        ClearForm();
    }
    `;
    return javascript;
}



/**
* Function Generate Javascript Page ClearForm
* @function
*/
Gs.Generator.GeneratorJavascriptClearForm = function () {
    let javascript = `
    function ClearForm(){
        Gs.Functions.AddClass("deleteButton","disabled");
        Gs.Functions.AddClass("copyButton","disabled");
        copyRecord = false;

        var table = Metro.getPlugin("#menuTable", "table");
        table.clearSelected();
        let select= null;let options = [];
    `;

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase() == "acessrole") {
            javascript += `
            select = Metro.getPlugin("#menuacessRole", "select");options = [];select.data("");
            let userRoleList = Metro.storage.getItem('SolutionUserRoleList', null);
            userRoleList.forEach(role => {
                options.push({ val: role.SystemName, title: role.SystemName, selected: false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase() == "acessuser") {
            javascript += `
            select = Metro.getPlugin("#menuacessUser", "select");options = [];select.data("");
            let userList = Metro.storage.getItem('SolutionUserList', null);
            userList.forEach(user => {
                options.push({ val: user.Id, title: user.UserName, selected: false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let mixedEnumList = Metro.storage.getItem('SolutionMixedEnumList', null);
            mixedEnumList.forEach(data => {
                if(data.ItemsGroup == "${schema.data.split("Inherited")[1]}"){
                    options.push({ val: data.SystemName, title: user.SystemName, selected: false });
                }
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let dataList = Metro.storage.getItem("${schema.data.split("List")[0]}List", null);
            dataList.forEach(data => {
                options.push({ val: data.${schema.data.split("List")[1]}, title: data.${schema.data.split("List")[1]}, selected: false });
            });select.addOptions(options);
            `;
        } else if (schema.data.toLowerCase() == "description") {
            javascript += `$("#menuDescription").summernote("code", "");
            `;

        } else if (schema.dataType.toLowerCase() == "decimal" || schema.dataType.toLowerCase() == "int") {
            javascript += `$("#menu${schema.data}").val("");
            `;
        }
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("date")) {
            javascript += `$("#menu${schema.data}").val("");
            `;
        }
        //else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("datetime")) {
        //javascript += `
        //    $("#menu${schema.data}").val("");
        //    `;
        //}
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("time")) {
            javascript += `$("#menu${schema.data}").val("");
            `;
        }
        else if (schema.dataType.toLowerCase() == "varchar") {
            javascript += `$("#menu${schema.data}").val("");
            `;
        }
        else if (schema.dataType.toLowerCase() == "bit") {
            javascript += `$("#menu${schema.data}").val('checked')[0].checked = false;
            `;
        }
    });

    javascript +=`
        SetEmptyEditor();
    }
    `;
    return javascript;
}


/**
* Function Generate Javascript Page EmptyEditor
* @function
*/
Gs.Generator.GeneratorJavascriptSetEmptyEditor = function () {
    let javascript = `
    function SetEmptyEditor() {
        setTimeout(function() {
            try{
                `;
    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `
                Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.setValue("");
            `;
        }
        if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `
                $('#HelpEditor')[0].contentWindow.mdEditor.setMarkdown(" ");
            `;
        }
        if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `
                document.getElementById("JsonEditor").contentWindow.inputEditor.doc.setValue([]);
            `;
        }
    });
    javascript +=`
            } catch { SetEmptyEditor(); }
        },1000);
    }
    `;

    return javascript;
}



/**
* Function Generate Javascript Page SetRecId
* @function
*/
Gs.Generator.GeneratorJavascriptSetRecId = function () {
    let javascript = `
    function SetRecId() {
        var table = Metro.getPlugin("#menuTable", "table");
        let tableData = Metro.storage.getItem("${$("#menuGeneratorTableName").val()}", null);
        let selectedRec = tableData.filter(menu => { return menu.Id != undefined ? menu.Id == table.getSelectedItems()[0][0] : menu.Guid == table.getSelectedItems()[0][0] ; })[0];
    `;

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase() == "acessrole") {
            javascript += `
            select = Metro.getPlugin("#menuacessRole", "select");options = [];select.data("");
            let userRoleList = Metro.storage.getItem('SolutionUserRoleList', null);
            userRoleList.forEach(role => {
                options.push({ val: role.SystemName, title: role.SystemName, selected: selectedRec.AccessRole.indexOf(role.SystemName) > -1 ? true : false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase() == "acessuser") {
            javascript += `
            select = Metro.getPlugin("#menuacessUser", "select");options = [];select.data("");
            let userList = Metro.storage.getItem('SolutionUserList', null);
            userList.forEach(user => {
                options.push({ val: user.Id, title: user.UserName, selected: selectedRec.AccessUser.indexOf(user.Id) > -1 ? true : false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let mixedEnumList = Metro.storage.getItem('SolutionMixedEnumList', null);
            mixedEnumList.forEach(data => {
                if(data.ItemsGroup == "${schema.data.split("Inherited")[1]}"){
                    options.push({ val: data.SystemName, title: user.SystemName, selected: selectedRec.${schema.data} == data.SystemName ? true : false });
                }
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let dataList = Metro.storage.getItem("${schema.data.split("List")[0]}List", null);
            dataList.forEach(data => {
                options.push({ val: data.${schema.data.split("List")[1]}, title: data.${schema.data.split("List")[1]}, selected: selectedRec.${schema.data} == data.${schema.data.split("List")[1]} ? true : false });
            });select.addOptions(options);
            `;
        } else if (schema.data.toLowerCase() == "description") {
            javascript += `$("#menuDescription").summernote("code", selectedRec.Description);
            `;

        } else if (schema.data.toLowerCase() == "id" || schema.data.toLowerCase() == "userid" || schema.data.toLowerCase() == "timestamp") {


        } else if (schema.dataType.toLowerCase() == "decimal" || schema.dataType.toLowerCase() == "int") {
            javascript += `$("#menu${schema.data}").val(selectedRec.${schema.data});
            `;
        }
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("date")) {
            javascript += `$("#menu${schema.data}").val(selectedRec.${schema.data});
            `;
        }
        //else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("datetime")) {
        //javascript += `
        //    $("#menu${schema.data}").val("");
        //    `;
        //}
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("time")) {
            javascript += `$("#menu${schema.data}").val(selectedRec.${schema.data});
            `;
        }
        else if (schema.dataType.toLowerCase() == "varchar") {
            javascript += `$("#menu${schema.data}").val(selectedRec.${schema.data});
            `;
        }
        else if (schema.dataType.toLowerCase() == "bit") {
            javascript += `$("#menu${schema.data}").val('checked')[0].checked = selectedRec.${schema.data};
            `;

        } else if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.setValue(selectedRec.${schema.data});
            `;

        } else if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `$('#HelpEditor')[0].contentWindow.mdEditor.setMarkdown(selectedRec.${schema.data});
            `;

        } else if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `document.getElementById("JsonEditor").contentWindow.inputEditor.doc.setValue(selectedRec.${schema.data});
            `;
        }
    });
    javascript += `
    Gs.Functions.RemoveClass("deleteButton","disabled");
    Gs.Functions.RemoveClass("copyButton","disabled");

    }`;

    return javascript;
}


/**
* Function Generate Javascript Page MenuToJson
* @function
*/
Gs.Generator.GeneratorJavascriptMenuToJson = function () {
    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);

    let javascript = `
     function MenuToJson() {
        let table = Metro.getPlugin("#menuTable", "table");
        let tableData = Metro.storage.getItem("${$("#menuGeneratorTableName").val()}", null);
        let userId = Metro.storage.getItem("ApiToken", null) != null ? Metro.storage.getItem("ApiToken", null).Id : null;

        if(table.getSelectedItems()[0] != undefined) {
            let selectedTableRec = tableData.filter(item => { return item.Id != undefined ? item.Id == table.getSelectedItems()[0][0] : item.Guid == table.getSelectedItems()[0][0]; })[0];

            return {
                `;
    
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase() == "id" || schema.data.toLowerCase() == "guid") {
            javascript += `
            ${Gs.Functions.CamelCaseString(schema.data) + ": selectedTableRec." + schema.data},
            `;
        } else if (schema.data.toLowerCase() == "description") {
            javascript += `Description: $("#menuDescription").summernote("code"),
            `;
        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        } else if (schema.dataType == "bit") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val('checked')[0].checked,
            `;
        } else if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.getValue(),
            `;

        } else if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown(),
            `;

        } else if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: document.getElementById("JsonEditor").contentWindow.inputEditor.doc.getValue(),
            `;
        } else {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        }
    });
    javascript += `UserId: userId
            }
        } else {
            return {
                `;
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase() == "id" || schema.data.toLowerCase() == "guid") {
            javascript += ``;
        } else if (schema.data.toLowerCase() == "description") {
            javascript += `Description: $("#menuDescription").summernote("code"),
            `;
        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        } else if (schema.dataType == "bit") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val('checked')[0].checked,
            `;
        } else if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.getValue(),
            `;

        } else if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown(),
            `;

        } else if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: document.getElementById("JsonEditor").contentWindow.inputEditor.doc.getValue(),
            `;
        } else {
            javascript += `${Gs.Functions.CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        }

    });
    javascript +=`UserId: userId
            }
        }
    }
    `;

    return javascript;
}



/**
* Function Generate Javascript Page Save
* @function
*/
Gs.Generator.GeneratorJavascriptSaveMenu = function () {
    let javascript = `
    async function SaveMenu() {
        let jsonData = null;let dataForm = {};

        if (formIsValid) {
            dataForm = MenuToJson();
            if (copyRecord){ delete dataForm.Id; }

            jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));
            jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
            jsonData[1].dataRec = JSON.stringify(dataForm);
            Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/SetGenericDataListByParams", JsonData: jsonData, WindowFunction: "StartUp" } );
        }
    }
    `;
    return javascript;
}



/**
* Function Generate Javascript Page Delete
* @function
*/
Gs.Generator.GeneratorJavascriptDeleteSelectedMenu = function () {
    let javascript = `
    async function DeleteSelectedMenu() {
        let table = Metro.getPlugin("#menuTable", "table");

        jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));
        jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
        jsonData[1].dataRec = JSON.stringify({ Id : table.getSelectedItems()[0][0]});;
        Gs.Variables.apiTaskList.push({ UUID: Gs.Functions.GenerateUUID(), Id: Gs.Functions.RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/SetGenericDataListByParams", JsonData: jsonData, WindowFunction: "StartUp" } );
    }
    `;
    return javascript;
}


/**
* Function Generate Javascript Page Copy Record
* @function
*/
Gs.Generator.GeneratorJavascriptCopyRecord = function () {
    let javascript = `
    async function CopyRecord() {
        copyRecord = true;
        Gs.Functions.AddClass("copyButton","disabled");
    }
    `;
    return javascript;
}