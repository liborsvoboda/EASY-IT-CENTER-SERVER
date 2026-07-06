

/**
* Function Generate and Show New Form Page on Portal Menu
* @function
*/
Gs.Generator.GenerateFormRequest = async function () {
    let content = `<p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Table Name and Load Table Field">Table Name</p>
    <div><input id='menuGeneratorTableName' type='text' data-role='input' ><button class="button success mb-4" style="position: absolute;right: 0px;" onclick="Gs.Generator.GetTableSchemaList();">Load Fields</button>
    <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Select Table Fields for Form Table which will be shown">Select Table Fields</p>
    <select id="menuGeneratorTableSchema" data-role="select" data-cls-select="" data-clear-button="true" data-prepend="Select Table Fields" multiple></select>
     <p data-role="hint" data-hint-position="top" data-cls-hint="supertop" data-hint-text="Insert Page Name">Insert Page Name</p>
    <input id='menuGeneratorName' type='text' data-role='input' >
    </div>`;
    let actions = [{
        caption: "Generate", cls: "js-dialog-close success",
        onclick: async function () {
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
                Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].editor.getModel().setValue(javascript);

                let css = "";
                css = Gs.Generator.GeneratorCss();
                Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].editor.getModel().setValue(css);
            } else { alert("Data must be Inserted"); }
        }
    }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }];
    Gs.Objects.CreateDialogRequest("Generate new Form Page", content, actions);
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
                                <LI class="fg-black "><A href="#_menuList">${$("#menuGeneratorName").val()}</A>
                                <LI class="fg-black "><A href="#_menuForm">Form</A>`
                                tableSchemaList.forEach(schema => {
                                    if (schema.data.toLowerCase() == "codecontent" ||schema.data.toLowerCase() == "htmlcontent" || schema.data.toLowerCase() == "jscontent" || schema.data.toLowerCase() == "csscontent") {
                                        html += `<LI class="fg-black "><A href="#_menuCodeEditor">Code Content</A>`;
                                    }
                                    if (schema.data.toLowerCase() == "mdcontent") {
                                        html += `<LI class="fg-black "><A href="#_menuMdEditor">MarkDown Content</A>`;
                                    }
                                    if (schema.data.toLowerCase() == "jsoncontent") {
                                        html += `<LI class="fg-black "><A href="#_menuJsonEditor">JSON Content</A>`;
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
            ) {
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
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-step="10" data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
            </DIV></DIV>`;
        }
        else if (schema.dataType.toLowerCase() == "decimal") {
            html += `
            <DIV class="col-xl-6 col-lg-6 col-md-6 col-sm-6 pt-8 col-12">
                <DIV class="form-group">
                <p>${Gs.Functions.AddSpaceCamelCase(schema.data)}</p>
                    <input id="menu${schema.data}" type="text" data-role="spinner" ${(schema.dataNull == 'YES' ? 'data-validate="required"' : '')} data-default-value="0.00" data-plus-icon="<span class='mif-plus fg-white'></span>" data-minus-icon="<span class='mif-minus fg-white'></span>" >
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
            <DIV class="col-xl-4 col-lg-4 col-md-4 col-sm-4 col-12">
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
    `;

    tableSchemaList.forEach(schema => {
        if (schema.data.toLowerCase() == "description") {
            javascript += `
            //Startup Actions
            $('#menuDescription').summernote({tabsize: 2,height: 150, maxHeight: 150,
                lang: 'cs-CZ',
                placeholder: 'write Description...',
                toolbar: [['style', ['style']],['font', ['bold', 'underline', 'clear']],['fontname', ['fontname']],
                    ['fontsize', ['fontsize']],['color', ['color']],['para', ['ul', 'ol', 'paragraph']],['table', ['table']],
                    ['insert', ['link', 'picture', 'video']],['view', ['fullscreen', 'codeview', 'undo', 'redo', 'help']]]
            });
            `;
        }
    });

    javascript += `
    //Startup Actions
    $(document).ready(function () { StartUp(); });
    `;
    return javascript;
}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptStartUp = function () {




}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptReloadTable = function () {




}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptClearForm = function () {




}


/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptSetEmptyEditor = function () {




}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptSetRecId = function () {




}


/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptMenuToJson = function () {




}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptSaveMenu = function () {




}



/**
* Function Generate Javascript Page Init
* @function
*/
Gs.Generator.GeneratorJavascriptDeleteSelectedMenu = function () {




}