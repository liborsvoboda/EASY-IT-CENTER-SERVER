# ![logo](doc/logo.png?raw=true) Fancytree
https://wwwendt.de/tech/fancytree/demo/index.html#sample-3rd-ui-contextmenu.html
https://fasgh.govt.kr/7

[![Wiki](https://github.com/mar10/fancytree/wiki)](https://github.com/mar10/fancytree/wiki)
[![GitHub version](https://badge.fury.io/gh/mar10%2Ffancytree.svg)](https://github.com/mar10/fancytree/releases/latest)
[![Build Status](https://travis-ci.org/mar10/fancytree.svg?branch=master)](https://travis-ci.org/mar10/fancytree)
[![npm](https://img.shields.io/npm/dm/jquery.fancytree.svg)](https://www.npmjs.com/package/jquery.fancytree)
[![jsDelivr](https://data.jsdelivr.com/v1/package/npm/jquery.fancytree/badge)](https://www.jsdelivr.com/package/npm/jquery.fancytree)
[![code style: prettier](https://img.shields.io/badge/code_style-prettier-ff69b4.svg?style=flat-square)](https://github.com/prettier/prettier)
[![StackOverflow: fancytree](https://img.shields.io/badge/StackOverflow-fancytree-blue.svg)](https://stackoverflow.com/questions/tagged/fancytree)

<!--
[![Selenium Test Status](https://saucelabs.com/buildstatus/sauce-fancytree)](https://saucelabs.com/u/sauce-fancytree)
-->

Fancytree (sequel of [DynaTree 1.x](https://code.google.com/p/dynatree/)) is a
JavaScript tree view / tree grid plugin with support for keyboard, inline editing,
filtering, checkboxes, drag'n'drop, and lazy loading.

[ ![sample](doc/teaser2.png?raw=true) ](https://wwWendt.de/tech/fancytree/demo "Live demo")


### Status

[![GitHub version](https://badge.fury.io/gh/mar10%2Ffancytree.svg)](https://github.com/mar10/fancytree/releases/latest)
See the [change log](https://github.com/mar10/fancytree/blob/master/CHANGELOG.md)
for details.


### Get Started

  * [Try the live demo](https://wwWendt.de/tech/fancytree/demo).
  * [Read the documentation](https://github.com/mar10/fancytree/wiki).
  * [Check the Q&A forum](https://groups.google.com/forum/#!forum/fancytree) or
    [Stackoverflow](http://stackoverflow.com/questions/tagged/fancytree) if you have questions.
  * Play with [jsFiddle](http://jsfiddle.net/mar10/KcxRd/),
    [CodePen](https://codepen.io/mar10/pen/WMWrbq),
    or [Plunker](http://plnkr.co/edit/8sdy3r?p=preview).
  * [Contribute](https://github.com/mar10/fancytree/wiki/HowtoContribute)


### ES6 Quickstart

```js
import $ from "jquery";

import 'jquery.fancytree/dist/skin-lion/ui.fancytree.less';  // CSS or LESS

import {createTree} from 'jquery.fancytree';

import 'jquery.fancytree/dist/modules/jquery.fancytree.edit';
import 'jquery.fancytree/dist/modules/jquery.fancytree.filter';

const tree = createTree('#tree', {
  extensions: ['edit', 'filter'],
  source: {...},
  ...
});
// Note: Loading and initialization may be asynchronous, so the nodes may not be accessible yet.
```

See [module loader support](https://github.com/mar10/fancytree/wiki#use-a-module-loader) and
[API docs](https://wwWendt.de/tech/fancytree/doc/jsdoc/Fancytree_Static.html#createTree).


### Credits

Thanks to all [contributors](https://github.com/mar10/fancytree/contributors).

<!--
### Browser Status Matrix

[![Selenium Test Status](https://saucelabs.com/browser-matrix/sauce-fancytree.svg)](https://saucelabs.com/u/sauce-fancytree)
-->


# Example of Init TreeBrowser
- HTML
````
<body>
	<div class="row w-100 h-100 d-inline-flex">
		<div id="tree" class="h-100" style="width: 350px; overflow-y: auto;"></div>
		<div id="FrameWindow" class="h-100 row" height="100%" frameborder="0" scrolling="yes" style="width: calc(100% - 350px); height: 100%; position: relative;">
			<div id="monacoPreview" class='row' style="height: 100%; width: 100%; position: fixed; display: block !important; "></div>
		</div>

		<select class="theme" style='position: absolute;left: 90%;z-index: 2000;top: 5px;right: 0px;'>
			<option>vs-dark</option>
			<option>vs</option>
			<option>hc-black</option>
		</select>

		<select class="language" style='position: absolute;left: 90%;z-index: 2000;top: 30px;right: 0px;'></select>
	</div>
</body>
````

- Javascript
````
$(function () {
			$("#tree").fancytree({
				checkbox: false,
				source: Metro.storage.getItem('FunctionList', null),
				activate: function (event, data) {
                    Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoPreview" })[0].editor.getModel().setValue(data.node.key);
				},
				checkbox: function (event, data) {
					return data.node.isFolder() ? false : false;
				}
			});
		});
````

# Example of Reload TreeBrowser
-Javascript
````
function ReloadUserStorage() {
            SetEditor("");
            $('#DataTree').fancytree('option', 'source', { url: "/UserStorageService/GetUserStorage" });
        }
````

# Example of Search in Tree
- Javascript
````
function SetSearchResult() {
            let fileList = Metro.storage.getItem("SearchResultFileList", null);
            $("#DataTree").fancytree("getRootNode").tree.clear();
            $("#DataTree").fancytree("getRootNode").addChildren(fileList);
        }
````


# Example of TreeBrowser Folder and File Menu

- Javascript Function
````
function InitiateTree() {
            $("#DataTree").fancytree({
                extensions: ["contextMenu"],
                checkbox: false,
                quicksearch: true,
                source: {
                    url: "/UserStorageService/GetUserStorage"
                },
                activate: function (event, data) {
                    //console.log("activate", event, data, data.node.data.extension);

                    //Show Text Files ServerParam["TextFilesExtensionList"]
                    if (["js", "html", "css", "txt", "xml", "bat", "cmd", "sql", "yml", "service"].includes(data.node.data.extension)) {
                        SetEditor("Monaco");
                        if (Metro.storage.getItem("SelectedEditor", null) == null || Metro.storage.getItem("SelectedEditor", null) == "Monaco") {
                            Gs.Variables.monacoEditorList.filter(obj => {
                                return obj.elementId == "userFilesPreview"
                            })[0].editor.getModel().setValue(data.node.key);
                        } else if (Metro.storage.getItem("SelectedEditor", null) == "TinyMCE") {
                            tinymce.get('TinyMCE').setContent(data.node.key);
                        } else if (Metro.storage.getItem("SelectedEditor", null) == "Froala") {
                            EditorInit.html.set(data.node.key);
                        } else if (Metro.storage.getItem("SelectedEditor", null) == "SUNEdit") {
                            EditorInit.setContents(data.node.key);
                        } else if (Metro.storage.getItem("SelectedEditor", null) == "Summer") {
                            $(`#SummerEditor`).summernote(`code`, data.node.key);
                        }

                    } else if (["md", "markdown"].includes(data.node.data.extension)) {
                        SetEditor("MDEditor");
                    } else if (["json", "json_"].includes(data.node.data.extension)) {
                        SetEditor("JSONEditor");
                    } else if (["jpg", "jpeg", "png", "tiff", "bmp", "gif", "svg"].includes(data.node.data.extension)) {
                        SetEditor("Image");
                    } else if (["mp4", "avi", "mov", "mpeg"].includes(data.node.data.extension)) {
                        SetEditor("Video");
                    } else if (["mp3"].includes(data.node.data.extension)) {
                        SetEditor("Audio");
                    } else if (["stl"].includes(data.node.data.extension)) {
                        SetEditor("STLviewer");
                    } else if (["pdf"].includes(data.node.data.extension)) {
                        SetEditor("PDFviewer");
                    } else if (["xls", "xlsx"].includes(data.node.data.extension)) {
                        SetEditor("XLSEditor");
                    } else if (["doc", "docx"].includes(data.node.data.extension)) {
                        SetEditor("DOCEditor");
                    } else if (["odt", "ods", "odp" ].includes(data.node.data.extension)) {
                        SetEditor("OfficeEditor");
                    } else if (["pptx"].includes(data.node.data.extension)) {
                        SetEditor("PPTXEditor");
                    } else {
                        SetEditor("Other");
                    }
                },
                checkbox: function (event, data) {
                    return data.node.isFolder() ? false : false;
                },
                contextMenu: {
                    autoFocus: true,
                    menu: function (node) {
                        if (node.folder && !node.data.path.startsWith("Downloads") && !node.data.path.startsWith("Videos") && !node.data.path.startsWith("Images") && !node.data.path.startsWith("Audio") && !node.data.path.startsWith("Help") && !node.data.path.startsWith("Generators") && !node.data.path.startsWith("Databases")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep1": "---------",
                                "replaceInFiles": { "name": "Replace in Files", "icon": "add" },
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },

                                "sep3": "---------",
                            };
                        } else if (node.folder && node.data.path.startsWith("Databases")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep1": "---------",
                                "replaceInFiles": { "name": "Replace in Files", "icon": "add" },
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",
                                "mssqlToMysql": { "name": "MSSQL DB to MYSQL script", "icon": "add" },

                            };
                        } else if (node.folder && node.data.path.startsWith("Generators")) {
                            return {
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep1": "---------",
                                "xmlToMarkdown": { "name": "Xml To Markdown", "icon": "add" },
                                "mdFilesToWebBook": { "name": "Md Files To WebBook", "icon": "add" },
                                "dllToMdWebDocs": { "name": "Dll To Md Web Docs", "icon": "add" },
                                "sep2": "---------",
                                "rotateGallery": { "name": "Images to Rotate Gallery", "icon": "add" },
                            };
                        } else if (node.folder && node.data.path.startsWith("Help")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep1": "---------",
                                "replaceInFiles": { "name": "Replace in Files", "icon": "add" },
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",
                                "generateSummary": { "name": "Generate Summary.md", "icon": "add" },
                            };
                        } else if (node.folder && node.data.path.startsWith("Audio")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep1": "---------",
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",
                                "recordAudio": { "name": "Record Audio", "icon": "add" },
                            };
                        } else if (node.folder && node.data.path.startsWith("Images")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep0": "---------",
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",
                                "takeSnapshot": { "name": "Take SnapShot", "icon": "add" },
                            };
                        } else if (node.folder && node.data.path.startsWith("Downloads")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep0": "---------",
                                "downloadHtmlFromUrl": { "name": "Get Html From Url", "icon": "add" },
                                "downloadMdFromUrl": { "name": "Get MD From Url", "icon": "add" },
                                "downloadPdfFromUrl": { "name": "Get Pdf From Url", "icon": "add" },
                                "downloadImageFromUrl": { "name": "Get Image From Url", "icon": "add" },
                                "sep1": "---------",
                                "replaceInFiles": { "name": "Replace in Files", "icon": "add" },
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",

                            };
                        } else if (node.folder && node.data.path.startsWith("Videos")) {
                            return {
                                "createFolder": { "name": "Create Folder", "icon": "add" },
                                "moveFolder": { "name": "Move to Folder", "icon": "edit" },
                                "copyFolder": { "name": "Copy to Folder", "icon": "copy" },
                                "clearFolder": { "name": "Clear Folder", "icon": "delete" },
                                "deleteFolder": { "name": "Delete Folder", "icon": "quit" },
                                "sep1": "---------",
                                "searchInFiles": { "name": "Search in Files", "icon": "paste" },
                                "downloadFolder": { "name": "Download Folder (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "createFile": { "name": "Create File", "icon": "add" },
                                "uploadFiles": { "name": "Upload Files", "icon": "add" },
                                "sep3": "---------",
                                "recordDesktop": { "name": "Record Desktop", "icon": "add" },
                                "recordCamera": { "name": "Record Camera", "icon": "add" },
                            };
                        } else if (!node.folder && node.data.path.toLowerCase().endsWith(".xml")) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "copyToUserStorage": { "name": "Copy to User Storage", "icon": "add" },
                                "sep1": "---------",
                                "openInNewWindow": { "name": "Open in New Window", "icon": "paste" },
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && (node.data.path.toLowerCase().endsWith(".html") || node.data.path.toLowerCase().endsWith(".htm") || node.data.path.toLowerCase().endsWith(".shtml"))) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "openInNewWindow": { "name": "Open in New Window", "icon": "paste" },
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "convertToMd": { "name": "Convert To Md", "icon": "add" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && (node.data.path.toLowerCase().endsWith(".md") || node.data.path.toLowerCase().endsWith(".markdown")) ) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "convertToHtml": { "name": "Convert Md To Html", "icon": "add" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && node.data.path.toLowerCase().endsWith(".zip")) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "unpackArchive": { "name": "Unpack Archive", "icon": "add" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && (node.data.path.toLowerCase().endsWith(".js") || node.data.path.toLowerCase().endsWith(".css"))) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "minifyFile": { "name": "Create Minified", "icon": "add" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && (node.data.path.toLowerCase().endsWith(".png") || node.data.path.toLowerCase().endsWith(".jpeg") || node.data.path.toLowerCase().endsWith(".jpg") || node.data.path.toLowerCase().endsWith(".tiff") || node.data.path.toLowerCase().endsWith(".bmp") || node.data.path.toLowerCase().endsWith(".svg"))) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "sep2": "---------",
                                "MiniPaint": { "name": "Edit in MiniPaint", "icon": "paste" },
                                "ImageEditor": { "name": "Edit in Image Editor", "icon": "paste" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder && node.data.path.toLowerCase().endsWith(".xlsx")) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "convertXlsxToHtml": { "name": "Convert to Html", "icon": "paste" },
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        } else if (!node.folder) {
                            return {
                                "saveFile": { "name": "Save File", "icon": "paste" },
                                "saveAssFile": { "name": "Save Ass File", "icon": "paste" },
                                "moveFile": { "name": "Move to Folder\\File", "icon": "paste" },
                                "copyFile": { "name": "Copy to Folder\\File", "icon": "copy" },
                                "deleteFile": { "name": "Delete File", "icon": "delete" },
                                "sep1": "---------",
                                "downloadFile": { "name": "Download File (Zip)", "icon": "paste" },
                                "showFileUrl": { "name": "Show File Url", "icon": "add" },
                            };
                        }
                    },
                    actions: async function (node, action, options) {
                        if (action == "showFileUrl") {
                            alert(window.location.origin + $('#DataTree').fancytree("getActiveNode").key);

                        } else if (action == "xmlToMarkdown") {
                            await Gs.Apis.RunServerGetApi("GeneratorService/XmlToMarkdown", null, "ReloadUserStorage");

                        } else if (action == "rotateGallery") {
                            await Gs.Apis.RunServerGetApi("GeneratorService/RotateGallery", null, "ReloadUserStorage");

                        } else if (action == "mssqlToMysql") {
                            await Gs.Apis.RunServerGetApi("ConversionService/MssqlToMysql", null, "ReloadUserStorage");

                        } else if (action == "mdFilesToWebBook") {
                            await Gs.Apis.RunServerGetApi("GeneratorService/MdFilesToWebBook", null, "ReloadUserStorage");

                        } else if (action == "dllToMdWebDocs") {
                            let content = "<div><input id='DllFilename' type='text' data-role='input' data-prepend='Dll Filename:' ></div>";
                            let actions = [{
                                caption: "Generate", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#DllFilename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("GeneratorService/XmlToMdWebDocs", { DllFilename: $("#DllFilename").val() }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Generate MD web from Dll", content, actions);

                        } else if (action == "convertXlsxToHtml") {
                            await Gs.Apis.RunServerPostApi("ConversionService/XlsxToHtml", { XlsxSourcePath: node.data.path, HtmlTargetPath: node.data.path.toLowerCase().replace(".xlsx", ".html") }, null, "ReloadUserStorage");

                        } else if (action == "searchInFiles") {
                            let content = "<div><input id='SearchInput' type='text' data-role='input' data-prepend='Search Text' ></div>";
                            let actions = [{
                                caption: "Search", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#SearchInput").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/SearchInFiles", { SearchInput: $("#SearchInput").val(), DataPath: node.data.path }, "SearchResultFileList", "SetSearchResult");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Search In Files", content, actions);

                        } else if (action == "minifyFile") {
                            await Gs.Apis.RunServerPostApi("FileMinifyService/MinifyAndSaveMinToPath", { WebRootPath: node.key }, null, "ReloadUserStorage");

                        } else if (action == "replaceInFiles") {
                            let content = "<div><input id='FileMask' type='text' data-role='input' data-prepend='FileMask: *.*' ><textarea id='SourceContent' data-role='textarea' data-default-value='Find string'></textarea><textarea id='TargetContent' data-role='textarea' data-default-value='Replace string'></textarea><INPUT id='RootDirOnly' style='HEIGHT: auto' autocomplete='off' data-role='checkbox' data-caption='Root Directory Only'></div>";
                            let actions = [{
                                caption: "Replace", cls: "js-dialog-close success",
                                onclick: async function () {
                                    await Gs.Apis.RunServerPostApi("UserStorageService/ReplaceInFiles", { FileMask: $("#FileMask").val(), SourceContent: $("#SourceContent").val(), TargetContent: $("#TargetContent").val(), WebRootPath: node.data.path, RootDirectoryOnly: $("#RootDirOnly").val('checked')[0].checked }, null, "ReloadUserStorage");
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Replace In Files", content, actions);

                        } else if (action == "openInNewWindow") {
                            let path = Metro.storage.getItem('ApiOriginSuffix', null);
                            let username = Metro.storage.getItem('ApiToken', null).Username;
                            window.open(path + `server-users/${username}/` + node.data.path);

                        } else if (action == "recordAudio") {
                            let content = "<div><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ><BUTTON class='button success outline shadowed' onclick=Gs.Media.StartRecordAudio(); >Start</BUTTON><BUTTON onclick ='Gs.Media.StopRecordAudio()' class='button warning outline shadowed'> Stop</BUTTON></div>";
                            let actions = [{
                                caption: "Save Audio File", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#Filename").val().length > 0) {
                                        let filename = $("#Filename").val();
                                        let blob = await fetch(Metro.storage.getItem("CapturedAudio", null)).then(r => r.blob());
                                        let reader = new FileReader();
                                        reader.onload = async function () {
                                            var dataURL = reader.result; localStorage.setItem(":CapturedAudio", dataURL);
                                            await Gs.Apis.RunServerPostApi("UserStorageService/SaveMediaFile", { Path: "Audio", Filename: filename, Content: localStorage.getItem(":CapturedAudio", null) }, null, "ReloadUserStorage");
                                            Gs.Media.ClearCapturedAudio();
                                        }
                                        //reader.readAsArrayBuffer(blob);
                                        reader.readAsDataURL(blob);
                                        //reader.readAsText(blob);
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Save Audio File", content, actions);

                        } else if (action == "takeSnapshot") {
                            let content = "<div><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Take SnapShot", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#Filename").val().length > 0) {
                                        await Gs.Media.CaptureToImage();
                                        await Gs.Apis.RunServerPostApi("UserStorageService/SaveMediaFile", { Path: "Images", Filename: $("#Filename").val(), Content: Metro.storage.getItem("CapturedImage", null) }, null, "ReloadUserStorage");
                                        Gs.Media.ClearCapturedImage();
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Take SnapShot", content, actions);

                        } else if (action == "recordDesktop") {
                            let content = "<div><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Start Record Desktop", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#Filename").val().length > 0) {
                                        Gs.Media.StartUserCaptureScreen($("#Filename").val());
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, {
                                caption: "Cancel", cls: "js-dialog-close alert", onclick: function () {

                                }
                            }]
                            Gs.Objects.CreateDialogRequest("Record Desktop", content, actions);

                        } else if (action == "recordCamera") {
                            let content = "<div><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ><video id='videoPreview' autoplay style='width:430px;'></video><BUTTON class='button success outline shadowed' onclick=Gs.Media.StartCaptureCamera(); >Start</BUTTON><BUTTON onclick ='Gs.Variables.media.mediaRecorder.stop();Gs.Variables.media.mediaStream.getTracks().forEach(track=>{ track.stop()})' class='button warning outline shadowed'> Stop</BUTTON></div>";
                            let actions = [{
                                caption: "Save Video", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/SaveMediaFile", { Path: "Videos", Filename: $("#Filename").val(), Content: Metro.storage.getItem("CapturedVideo", null) }, null, "ReloadUserStorage");
                                        Gs.Media.ClearCapturedVideo();
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, {
                                caption: "Cancel", cls: "js-dialog-close alert", onclick: function () {

                                }
                            }]
                            Gs.Objects.CreateDialogRequest("Record Camera", content, actions);

                        } else if (action == "unpackArchive") {
                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='TargetFolder' type='text' data-role='input' data-prepend='Target Folder:' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Unpack Archive", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#TargetFolder").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/UnpackArchive", { TargetFolder: $("#TargetFolder").val(), FilePath: node.data.path }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Unpack Archive", content, actions);

                        } else if (action == "MiniPaint") {
                            SetEditor("MiniPaint");

                        } else if (action == "ImageEditor") {
                            SetEditor("ImageEditor");

                        } else if (action == "convertToMd") {
                            $.ajax({ url: $('#DataTree').fancytree("getActiveNode").key }).done(async function (data) {
                                let markdown = mdream.htmlToMarkdown(data);
                                await Gs.Apis.RunServerPostApi("UserStorageService/SaveMarkdownFile", { Content: markdown, Filename: node.title.split(".")[0] }, null, "ReloadUserStorage");
                            });
                        } else if (action == "convertToHtml") {
                            $.ajax({ url: $('#DataTree').fancytree("getActiveNode").key }).done(async function (data) {
                                Markdown2HTML();
                                let markdown = md2html(data);
                                await Gs.Apis.RunServerPostApi("UserStorageService/SaveHtmlFile", { Content: markdown, Filename: node.title.split(".")[0] }, null, "ReloadUserStorage");
                            });
                        } else if (action == "downloadHtmlFromUrl") {
                            let content = "<div><input id='UrlPath' type='text' data-role='input' data-prepend='Url:' ><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Download HTML from URL", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#UrlPath").val().length > 0 && $("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/DownloadHtmlFromUrl", { Url: $("#UrlPath").val(), Filename: $("#Filename").val() }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Download HTML from URL", content, actions);

                        } else if (action == "downloadMdFromUrl") {
                            let content = "<div><input id='UrlPath' type='text' data-role='input' data-prepend='Url:' ><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Download MarkDown from URL", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#UrlPath").val().length > 0 && $("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/DownloadMdFromUrl", { Url: $("#UrlPath").val(), Filename: $("#Filename").val() }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Download MarkDown from URL", content, actions);

                        } else if (action == "downloadPdfFromUrl") {
                            let content = "<div><input id='UrlPath' type='text' data-role='input' data-prepend='Url:' ><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Download PDF from URL", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#UrlPath").val().length > 0 && $("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/DownloadPdfFromUrl", { Url: $("#UrlPath").val(), Filename: $("#Filename").val() }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Download PDF ScreenShot from URL", content, actions);

                        } else if (action == "downloadImageFromUrl") {
                            let content = "<div><input id='UrlPath' type='text' data-role='input' data-prepend='Url:' ><input id='Filename' type='text' data-role='input' data-prepend='Filename:' ></div>";
                            let actions = [{
                                caption: "Download PNG from URL", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#UrlPath").val().length > 0 && $("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/DownloadImageFromUrl", { Url: $("#UrlPath").val(), Filename: $("#Filename").val() }, null, "ReloadUserStorage");
                                    } else { alert("Data must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Download PNG Image ScreenShot from URL", content, actions);

                        } else if (action == "generateSummary") {
                            await Gs.Apis.RunServerPostApi("SummaryService/GenerateUserSummaryFile", { MdFilesPath: $('#DataTree').fancytree("getActiveNode").data.path }, null, "ReloadUserStorage");

                        } else if (action == "createFolder") {
                            let content = "<div><input id='FolderName' type='text' data-role='input' data-prepend='Folder Name:' ></div>";
                            let actions = [{
                                caption: "Create Folder", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FolderName").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/CreateUserFolder", { Path: $('#DataTree').fancytree("getActiveNode").data.path + "\\" + $("#FolderName").val() }, null, "ReloadUserStorage");
                                    } else { alert("Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Create Folder", content, actions);

                        } else if (action == "moveFolder") {
                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FolderName' type='text' data-role='input' data-prepend='Target Folder Name: ' value="${targetPath}\\"></div>`;

                            let actions = [{
                                caption: "Move Folder", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FolderName").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/MoveUserFolder", { SourcePath: $('#DataTree').fancytree("getActiveNode").data.path, TargetPath: $("#FolderName").val() }, null, "ReloadUserStorage");
                                    } else { alert("Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Move Folder", content, actions);

                        } else if (action == "copyFolder") {
                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FolderName' type='text' data-role='input' data-prepend='Target Folder Name: ' value="${targetPath}\\"></div>`;
                            let actions = [{
                                caption: "Copy Folder", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FolderName").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/CopyUserFolder", { SourcePath: $('#DataTree').fancytree("getActiveNode").data.path, TargetPath: $("#FolderName").val() }, null, "ReloadUserStorage");
                                    } else { alert("Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Copy Folder", content, actions);

                        } else if (action == "downloadFolder") {
                            Gs.Apis.DownloadApi("UserStorageService/DownloadUserFolder", { Path: $('#DataTree').fancytree("getActiveNode").data.path }, $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), true);

                        } else if (action == "clearFolder") {
                            let content = "<div>Do you want to Clear selected Folder? " + $('#DataTree').fancytree("getActiveNode").data.path + "</div>";
                            let actions = [{
                                caption: "Clear Folder", cls: "js-dialog-close success",
                                onclick: async function () {
                                    await Gs.Apis.RunServerPostApi("UserStorageService/ClearUserFolder", { Path: $('#DataTree').fancytree("getActiveNode").data.path }, null, "ReloadUserStorage");
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Clear Folder", content, actions);

                        } else if (action == "deleteFolder") {
                            let content = "<div>Do you want to Delete selected Folder? " + $('#DataTree').fancytree("getActiveNode").data.path + "</div>";
                            let actions = [{
                                caption: "Delete Folder", cls: "js-dialog-close success",
                                onclick: async function () {
                                    await Gs.Apis.RunServerPostApi("UserStorageService/DeleteUserFolder", { Path: $('#DataTree').fancytree("getActiveNode").data.path }, null, "ReloadUserStorage");
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Delete Folder", content, actions);

                        } else if (action == "createFile") {
                            let content = "<div><input id='Filename' type='text' data-role='input' data-prepend='Write FileName: ' ></div>";
                            let actions = [{
                                caption: "Create File", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#Filename").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/CreateUserFile", { Path: $('#DataTree').fancytree("getActiveNode").data.path, Filename: $("#Filename").val() }, null, "ReloadUserStorage");
                                    } else { alert("FileName must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Create File", content, actions);

                        } else if (action == "uploadFiles") {
                            let content = "<div><input id='Files' type='file' data-role='file' data-mode='drop' multiple data-on-select='LoadFiles()' ></div>";
                            let actions = [{
                                caption: "Upload Files", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if (document.getElementById("Files").files.length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/UploadUserFiles", { Path: $('#DataTree').fancytree("getActiveNode").data.path, Files: Files }, null, "ReloadUserStorage");
                                    } else { alert("Files must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Upload Files", content, actions);

                        } else if (action == "saveFile" && Metro.storage.getItem("SelectedEditor", null) != "MiniPaint" && Metro.storage.getItem("SelectedEditor", null) != "ImageEditor" && Metro.storage.getItem("SelectedEditor", null) != "OfficeEditor") { //console.log("extension", $('#DataTree').fancytree("getActiveNode").data.extension);
                            Gs.Apis.RunServerPostApi("UserStorageService/SetUserTextFile", {
                                Path: $('#DataTree').fancytree("getActiveNode").data.path,
                                Content: Metro.storage.getItem("SelectedEditor", null) == null || Metro.storage.getItem("SelectedEditor", null) == "Monaco" || Metro.storage.getItem("SelectedEditor", null) == "Other" ?
                                    Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "userFilesPreview" })[0].model.getValue() :
                                    Metro.storage.getItem("SelectedEditor", null) == "TinyMCE" ? tinyMCE.getContent('TinyMCE') :
                                        Metro.storage.getItem("SelectedEditor", null) == "Froala" ? EditorInit.html.get() :
                                            Metro.storage.getItem("SelectedEditor", null) == "SUNEdit" ? EditorInit.getContents() :
                                                Metro.storage.getItem("SelectedEditor", null) == "Summer" ? $(`#SummerEditor`).summernote(`code`) :
                                                    Metro.storage.getItem("SelectedEditor", null) == "MDEditor" ? $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown() :
                                                        Metro.storage.getItem("SelectedEditor", null) == "JSONEditor" ?
                                                            $("#DataFrameWindow")[0].contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text") == 'null' ?
                                                                document.querySelector("#DataFrameWindow").contentWindow.inputEditor.getValue() : $("#DataFrameWindow")[0].contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text")
                                                            : ""
                            }, null);

                        } else if (action == "saveFile" && Metro.storage.getItem("SelectedEditor", null) == "MiniPaint") {
                            html2canvas($('#DataFrameWindow')[0].contentWindow.document.querySelector("#canvas_minipaint")).then(async canvas => {
                                let target = new Image(); target.src = canvas.toDataURL("image." + $('#DataTree').fancytree("getActiveNode").data.path.split(".").pop()); Files = [];
                                Files.push({ Filename: $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), Content: target.src });
                                await Gs.Apis.RunServerPostApi("UserStorageService/UploadUserFiles", { Path: $('#DataTree').fancytree("getActiveNode").data.path.replace($('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), ""), Files: Files }, null);
                            });

                        } else if (action == "saveFile" && Metro.storage.getItem("SelectedEditor", null) == "ImageEditor") {
                            Files = [];
                            Files.push({ Filename: $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), Content: $("#DataFrameWindow")[0].contentWindow.ImageEditor.getCurrentImgData().imageData.imageBase64 });
                            await Gs.Apis.RunServerPostApi("UserStorageService/UploadUserFiles", { Path: $('#DataTree').fancytree("getActiveNode").data.path.replace($('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), ""), Files: Files }, null);

                        } else if (action == "saveFile" && Metro.storage.getItem("SelectedEditor", null) == "OfficeEditor") {
                            Files = [];
                            $("#DataFrameWindow")[0].contentWindow.editorOptions.saveAssCallback();
                            SaveOpenOffice();

                        } else if (action == "saveAssFile" && Metro.storage.getItem("SelectedEditor", null) != "MiniPaint" && Metro.storage.getItem("SelectedEditor", null) != "ImageEditor" && Metro.storage.getItem("SelectedEditor", null) != "OfficeEditor") { //console.log("extension", $('#DataTree').fancytree("getActiveNode").data.extension);

                            let contentData = {
                                Path: $('#DataTree').fancytree("getActiveNode").data.path,
                                Content: Metro.storage.getItem("SelectedEditor", null) == null || Metro.storage.getItem("SelectedEditor", null) == "Monaco" || Metro.storage.getItem("SelectedEditor", null) == "Other" ?
                                    Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "userFilesPreview" })[0].model.getValue() :
                                    Metro.storage.getItem("SelectedEditor", null) == "TinyMCE" ? tinyMCE.getContent('TinyMCE') :
                                        Metro.storage.getItem("SelectedEditor", null) == "Froala" ? EditorInit.html.get() :
                                            Metro.storage.getItem("SelectedEditor", null) == "SUNEdit" ? EditorInit.getContents() :
                                                Metro.storage.getItem("SelectedEditor", null) == "Summer" ? $(`#SummerEditor`).summernote(`code`) :
                                                    Metro.storage.getItem("SelectedEditor", null) == "MDEditor" ? $('#HelpEditor')[0].contentWindow.mdEditor.getMarkdown() :
                                                        Metro.storage.getItem("SelectedEditor", null) == "JSONEditor" ?
                                                            $("#DataFrameWindow")[0].contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text") == 'null' ?
                                                                document.querySelector("#DataFrameWindow").contentWindow.inputEditor.getValue() : $("#DataFrameWindow")[0].contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text")
                                                            : ""
                            };

                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Save File Ass", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        Gs.Apis.RunServerPostApi("UserStorageService/SetUserTextFile", contentData, null);
                                    } else { alert("File Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Save File Ass", content, actions);

                        } else if (action == "saveAssFile" && Metro.storage.getItem("SelectedEditor", null) == "MiniPaint") {

                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Save File Ass", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        html2canvas($('#DataFrameWindow')[0].contentWindow.document.querySelector("#canvas_minipaint")).then(async canvas => {
                                            let target = new Image(); target.src = canvas.toDataURL("image." + $('#DataTree').fancytree("getActiveNode").data.path.split(".").pop()); Files = [];
                                            Files.push({ Filename: $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), Content: target.src });
                                            await Gs.Apis.RunServerPostApi("UserStorageService/UploadUserFiles", { Path: $('#DataTree').fancytree("getActiveNode").data.path.replace($('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), ""), Files: Files }, null);
                                        });
                                    } else { alert("File Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Save File Ass", content, actions);

                        } else if (action == "saveAssFile" && Metro.storage.getItem("SelectedEditor", null) == "ImageEditor") {

                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Save File Ass", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        Files = [];
                                        Files.push({ Filename: $("#FileName").val(), Content: $("#DataFrameWindow")[0].contentWindow.ImageEditor.getCurrentImgData().imageData.imageBase64 });
                                        await Gs.Apis.RunServerPostApi("UserStorageService/UploadUserFiles", { Path: $('#DataTree').fancytree("getActiveNode").data.path.replace($('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), ""), Files: Files }, null);
                                    } else { alert("File Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Save File Ass", content, actions);

                        } else if (action == "saveAssFile" && Metro.storage.getItem("SelectedEditor", null) == "OfficeEditor") {

                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Save File Ass", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        Files = [];
                                        $("#DataFrameWindow")[0].contentWindow.editorOptions.saveAssCallback();
                                        SaveOpenOffice($("#FileName").val());
                                    } else { alert("File Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Save File Ass", content, actions);

                        } else if (action == "moveFile") {
                            let content = "<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' ></div>";
                            let actions = [{
                                caption: "Move File", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/MoveUserFile", { SourcePath: $('#DataTree').fancytree("getActiveNode").data.path, TargetPath: $("#FileName").val() }, null, "ReloadUserStorage");
                                    } else { alert("FileName must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Move File", content, actions);

                        } else if (action == "copyFile") {
                            let targetPath = node.data.path.replace(node.title, "");
                            let content = `<div><input id='FileName' type='text' data-role='input' data-prepend='Target Folder\\File Name: ' value="${targetPath}" ></div>`;
                            let actions = [{
                                caption: "Copy File", cls: "js-dialog-close success",
                                onclick: async function () {
                                    if ($("#FileName").val().length > 0) {
                                        await Gs.Apis.RunServerPostApi("UserStorageService/CopyUserFile", { SourcePath: $('#DataTree').fancytree("getActiveNode").data.path, TargetPath: $("#FileName").val() }, null, "ReloadUserStorage");
                                    } else { alert("Name must be Inserted"); }
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Copy File", content, actions);

                        } else if (action == "deleteFile") {
                            let content = "<div>Do you want to Delete selected File? " + $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop() + "</div>";
                            let actions = [{
                                caption: "Delete File", cls: "js-dialog-close success",
                                onclick: async function () {
                                    await Gs.Apis.RunServerPostApi("UserStorageService/DeleteUserFile", { Path: $('#DataTree').fancytree("getActiveNode").data.path }, null, "ReloadUserStorage");
                                }
                            }, { caption: "Cancel", cls: "js-dialog-close alert", onclick: function () { } }]
                            Gs.Objects.CreateDialogRequest("Delete File", content, actions);

                        } else if (action == "downloadFile") {
                            Gs.Apis.DownloadApi("UserStorageService/DownloadUserFile", { Path: $('#DataTree').fancytree("getActiveNode").data.path }, $('#DataTree').fancytree("getActiveNode").data.path.split("\\").pop(), true);
                        }
                    }
                },
            });
        }
````