

/**
* Function Generate and Show New Form Page on Portal Menu
* @function
*/
async function GenerateFormRequest () {
    let content = `<p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Table Name and Load Table Field">Table Name</p>
    <div><input id='menuGeneratorTableName' type='text' data-role='input' ><button class="button success mb-4 shadowed" style="position: absolute;right: 0px;" onclick="async function GetTableSchemaList();">Load Fields</button>
    <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Select Table Fields for Form Table which will be shown">Select Table Fields</p>
    <select id="menuGeneratorTableSchema" data-role="select" data-cls-select="" data-clear-button="true" data-prepend="Select Table Fields" multiple></select>
     <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Page Name">Insert Page Name</p>
    <input id='menuGeneratorName' type='text' data-role='input' >
    <button class="button primary mb-4 shadowed" style="position: absolute;right: 0px;" onclick="async function GeneratePage();">Generate</button>
    <p></p>
    </div>`;
    let actions = [{
        caption: "Close", cls: "js-dialog-close success",
        onclick: function () {
            if ($("#menuGeneratorTableName").val().length > 0 && $("#menuGeneratorName").val().length > 0) {

            } else { alert("Data must be Inserted"); }
        }
    }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }];
    CreateDialogRequest("Generate new Form Page", content, actions);
}



function GeneratePage () {
    if ($("#menuGeneratorTableName").val().length > 0 && $("#menuGeneratorName").val().length > 0) {
        let html = "";
        html += GeneratorHtmlHeader();
        html += GeneratorHtmlButtons();
        html += GeneratorHtmlTable();
        html += GeneratorHtmlForm();
        html += GeneratorHtmlEditors();
        html += GeneratorPageFooter();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].editor.getModel().setValue(html);

        let javascript = "";
        javascript += GeneratorJavascriptInit();
        javascript += GeneratorJavascriptStartUp();
        javascript += GeneratorJavascriptReloadTable();
        javascript += GeneratorJavascriptClearForm();
        javascript += GeneratorJavascriptSetEmptyEditor();
        javascript += GeneratorJavascriptSetRecId();
        javascript += GeneratorJavascriptMenuToJson();
        javascript += GeneratorJavascriptSaveMenu();
        javascript += GeneratorJavascriptDeleteSelectedMenu();
        javascript += GeneratorJavascriptCopyRecord();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].editor.getModel().setValue(javascript);

        let css = "";
        css += GeneratorCss();
        Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].editor.getModel().setValue(css);
        ShowNotify("info", "Page was Generated");
    } else { ShowNotify("alert", "Page was Not Generated. Insert Data First"); }
}


/**
* Function Get Table Schema List
* @function
*/
async function GetTableSchemaList () {
    await Gs.Apis.RunServerGetApi(`DatabaseService/SpGetTableSchema/${$("#menuGeneratorTableName").val()}`, "TableSchemaList", "GeneratorLoadTableSchema");
    $("#menuGeneratorName").val(AddSpaceCamelCase($("#menuGeneratorTableName").val()));
}


/**
* Function Generate Page Header
* @function
*/
function GeneratorHtmlHeader() {
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
function GeneratorHtmlButtons () {
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
function GeneratorHtmlTable () {
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
function GeneratorHtmlForm () {

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
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${AddSpaceCamelCase(schema.data)}">
                    </select>
            </DIV></DIV>`;
        }
        else if (schema.data.toLowerCase().startsWith("inherited")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${AddSpaceCamelCase(schema.data)}">
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

        } else if (schema.data.toLowerCase().indexOf("accessrole") > -1 || schema.data.toLowerCase().indexOf("accessuser") > -1) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${AddSpaceCamelCase(schema.data)}" multiple>
                    </select>
            </DIV></DIV
            `;

        } else if (schema.data.toLowerCase() == "sequence") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-step="10" data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-black'></span>" data-minus-icon="<span class='mif-minus fg-black'></span>" >
            </DIV></DIV>
            `;

        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <select id="menu${schema.data}" data-role="select" data-use-placeholder="true" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-placeholder="${AddSpaceCamelCase(schema.data)}" multiple>
                    </select>
            </DIV></DIV>
            `;

        } else if (schema.dataType.toLowerCase() == "decimal") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-black'></span>" data-minus-icon="<span class='mif-minus fg-black'></span>" >
            </DIV></DIV>
            `;
        }
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("date")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="calendarpicker" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')}>
            </DIV></DIV>
            `;
        }
        //else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("datetime")) {
        //    html += `
        //    <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
        //        <DIV class="form-group">
        //        <p>${AddSpaceCamelCase(schema.data)}</p>
        //            <input id="menu${schema.data}"  type="text" data-role="spinner" data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
        //    </DIV></DIV>`;
        //}
        else if (schema.dataType.toLowerCase() == "datetime" && schema.data.toLowerCase().endsWith("time")) {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" data-role="timepicker" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')}>
            </DIV></DIV>
            `;
        }
        else if (schema.dataType.toLowerCase() == "int") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}"  type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
            </DIV></DIV>
            `;
        }
        else if (schema.dataType.toLowerCase() == "varchar") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
                <DIV class="form-group">
                    <INPUT id="menu${schema.data}" style="HEIGHT: auto" data-role="input" ${(schema.dataNull == 'YES' ? 'data-validate="required"' :'')} data-validate="required" autocomplete="off" data-label="${AddSpaceCamelCase(schema.data)}">
            </DIV></DIV>
            `;
        }
        else if (schema.dataType.toLowerCase() == "bit") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
                <DIV class="form-group pt-5">
                    <INPUT id="menu${schema.data}" style="HEIGHT: auto" autocomplete="off" data-role="checkbox" data-caption="${AddSpaceCamelCase(schema.data)}">
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
function GeneratorHtmlEditors () {
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
function GeneratorPageFooter () {
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
function GeneratorCss () {
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
function GeneratorJavascriptInit () {
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
function GeneratorJavascriptStartUp () {
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
        if (schema.data.toLowerCase().indexOf("accessrole") > -1) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure)); jsonData[1].tableName = "SolutionUserRoleList";
                    Gs.Variables.apiTaskList.push({ UUID: GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionUserRoleList" } );
                `;

        } else if (schema.data.toLowerCase().indexOf("accessuser") > -1) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "SolutionUserList";
                Gs.Variables.apiTaskList.push({ UUID: GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionUserList" } );
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "SolutionMixedEnumList";
                Gs.Variables.apiTaskList.push({ UUID:GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "SolutionMixedEnumList" } );
            `;
        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "${schema.data.split("List")[0]}List";
                Gs.Variables.apiTaskList.push({ UUID:GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "${schema.data.split("List")[0]}List" } );
            `;
        }
    });

    javascript += `jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
                Gs.Variables.apiTaskList.push({ UUID:GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/GetGenericDataListByParams", JsonData: jsonData, StorageName: "${$("#menuGeneratorTableName").val() }", WindowFunction: "ReloadTable" } );


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
function GeneratorJavascriptReloadTable () {
    let select = Metro.getPlugin("#menuGeneratorTableSchema", "select"); 
    
    let javascript = `
    
    function ReloadTable(){
        let data = [];
        AddClass("deleteButton", "disabled");
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
function GeneratorJavascriptClearForm () {
    let javascript = `
    function ClearForm(){
        AddClass("deleteButton","disabled");
        AddClass("copyButton","disabled");
        copyRecord = false;

        var table = Metro.getPlugin("#menuTable", "table");
        table.clearSelected();
        let select= null;let options = [];
    `;
    let inheritedIndex = 0;let listIndex = 0;

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase().indexOf("accessrole") > -1) {
            javascript += `
            select = Metro.getPlugin("#menuAccessRole", "select");options = [];select.data("");
            let userRoleList = Metro.storage.getItem('SolutionUserRoleList', null);
            userRoleList.forEach(role => {
                options.push({ val: role.SystemName, title: role.SystemName, selected: false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("accessuser") > -1) {
            javascript += `
            select = Metro.getPlugin("#menuAccessUser", "select");options = [];select.data("");
            let userList = Metro.storage.getItem('SolutionUserList', null);
            userList.forEach(user => {
                options.push({ val: user.Id, title: user.UserName, selected: false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            inheritedIndex++;
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let mixedEnumList${inheritedIndex} = Metro.storage.getItem('SolutionMixedEnumList', null);
            mixedEnumList${inheritedIndex}.forEach(data => {
                if(data.ItemsGroup == "${schema.data.split("Inherited")[1]}"){
                    options.push({ val: data.SystemName, title: data.SystemName, selected: false });
                }
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            listIndex++;
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let dataList${listIndex} = Metro.storage.getItem("${schema.data.split("List")[0]}List", null);
            dataList${listIndex}.forEach(data => {
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
function GeneratorJavascriptSetEmptyEditor () {
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
function GeneratorJavascriptSetRecId () {
    let javascript = `
    function SetRecId() {
        var table = Metro.getPlugin("#menuTable", "table");
        let tableData = Metro.storage.getItem("${$("#menuGeneratorTableName").val()}", null);
        let selectedRec = tableData.filter(menu => { return menu.Id != undefined ? menu.Id == table.getSelectedItems()[0][0] : menu.Guid == table.getSelectedItems()[0][0] ; })[0];
    `;
    let inheritedIndex = 0; let listIndex = 0;

    let tableSchemaList = Metro.storage.getItem('TableSchemaList', null);
    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "autoversion") {


        } else if (schema.data.toLowerCase().indexOf("accessrole") > -1) {
            javascript += `
            select = Metro.getPlugin("#menuAccessRole", "select");options = [];select.data("");
            let userRoleList = Metro.storage.getItem('SolutionUserRoleList', null);
            userRoleList.forEach(role => {
                options.push({ val: role.SystemName, title: role.SystemName, selected: selectedRec.AccessRole.indexOf(role.SystemName) > -1 ? true : false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("accessuser") > -1) {
            javascript += `
            select = Metro.getPlugin("#menuAccessUser", "select");options = [];select.data("");
            let userList = Metro.storage.getItem('SolutionUserList', null);
            userList.forEach(user => {
                options.push({ val: user.Id, title: user.UserName, selected: selectedRec.AccessUser.indexOf(user.Id) > -1 ? true : false });
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            inheritedIndex++;
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let mixedEnumList${inheritedIndex} = Metro.storage.getItem('SolutionMixedEnumList', null);
            mixedEnumList${inheritedIndex}.forEach(data => {
                if(data.ItemsGroup == "${schema.data.split("Inherited")[1]}"){
                    options.push({ val: data.SystemName, title: user.SystemName, selected: selectedRec.${schema.data} == data.SystemName ? true : false });
                }
            });select.addOptions(options);
            `;

        } else if (schema.data.toLowerCase().indexOf("list") > -1) {
            listIndex++;
            javascript += `
            select = Metro.getPlugin("#menu${schema.data}", "select");options = [];select.data("");
            let dataList${listIndex} = Metro.storage.getItem("${schema.data.split("List")[0]}List", null);
            dataList${listIndex}.forEach(data => {
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
    RemoveClass("deleteButton","disabled");
    RemoveClass("copyButton","disabled");

    }`;

    return javascript;
}


/**
* Function Generate Javascript Page MenuToJson
* @function
*/
function GeneratorJavascriptMenuToJson () {
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
            ${CamelCaseString(schema.data) + ": selectedTableRec." + schema.data},
            `;
        } else if (schema.data.toLowerCase() == "description") {
            javascript += `Description: $("#menuDescription").summernote("code"),
            `;
        } else if (schema.data.toLowerCase().startsWith("inherited")) {
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        } else if (schema.dataType == "bit") {
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val('checked')[0].checked,
            `;
        } else if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `${CamelCaseString(schema.data)}: Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.getValue(),
            `;

        } else if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `${CamelCaseString(schema.data)}: $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown(),
            `;

        } else if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `${CamelCaseString(schema.data)}: document.getElementById("JsonEditor").contentWindow.inputEditor.doc.getValue(),
            `;
        } else {
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
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
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
            `;
        } else if (schema.dataType == "bit") {
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val('checked')[0].checked,
            `;
        } else if (schema.data.toLowerCase() == "codecontent" || schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
            javascript += `${CamelCaseString(schema.data)}: Gs.Variables.monacoEditorList.filter(obj=>{return obj.elementId == "monacoPreview"})[0].model.getValue(),
            `;

        } else if (schema.data.toLowerCase() == "mdcontent") {
            javascript += `${CamelCaseString(schema.data)}: $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown(),
            `;

        } else if (schema.data.toLowerCase() == "jsoncontent") {
            javascript += `${CamelCaseString(schema.data)}: document.getElementById("JsonEditor").contentWindow.inputEditor.doc.getValue(),
            `;
        } else {
            javascript += `${CamelCaseString(schema.data)}: $("#menu${schema.data}").val(),
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
function GeneratorJavascriptSaveMenu () {
    let javascript = `
    async function SaveMenu() {
        let jsonData = null;let dataForm = {};

        if (formIsValid) {
            dataForm = MenuToJson();
            if (copyRecord){ delete dataForm.Id; }

            jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));
            jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
            jsonData[1].dataRec = JSON.stringify(dataForm);
            Gs.Variables.apiTaskList.push({ UUID: GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/SetGenericDataListByParams", JsonData: jsonData, WindowFunction: "StartUp" } );
        }
    }
    `;
    return javascript;
}



/**
* Function Generate Javascript Page Delete
* @function
*/
function GeneratorJavascriptDeleteSelectedMenu () {
    let javascript = `
    async function DeleteSelectedMenu() {
        let table = Metro.getPlugin("#menuTable", "table");

        jsonData = JSON.parse(JSON.stringify(Gs.Variables.getSpProcedure));
        jsonData[1].tableName = "${$("#menuGeneratorTableName").val()}";
        jsonData[1].dataRec = JSON.stringify({ Id : table.getSelectedItems()[0][0]});;
        Gs.Variables.apiTaskList.push({ UUID: GenerateUUID(), Id: RandomString(), Sequence: 0, Type: "RunServerPostApi", ApiPath: "DatabaseService/SpProcedure/SetGenericDataListByParams", JsonData: jsonData, WindowFunction: "StartUp" } );
    }
    `;
    return javascript;
}


/**
* Function Generate Javascript Page Copy Record
* @function
*/
function GeneratorJavascriptCopyRecord () {
    let javascript = `
    async function CopyRecord() {
        copyRecord = true;
        AddClass("copyButton","disabled");
    }
    `;
    return javascript;
}