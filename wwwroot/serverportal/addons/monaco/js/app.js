require.config({ paths: { 'vs': '/serverportal/addons/monaco/js/monaco-editor/min/vs' } });
require.config({ paths: { 'vs': '/serverportal/addons/monaco/js/monaco-editor/min/vs' } });
require(['vs/editor/editor.main'], function () {


    var fileCounter = 0;
    var editorArray = [];

    monaco.editor.defineTheme('myTheme', {
        base: 'vs-dark',
        inherit: true,
        rules: [{ background: 'EDF9FA' }],
        // colors: { 'editor.lineHighlightBackground': '#0000FF20' }
    });
    monaco.editor.setTheme('myTheme');


    function newEditor(container_id, code, language) {
        var model = monaco.editor.createModel(code, language);
        var editor = monaco.editor.create(document.getElementById(container_id), {
            model: model,
            suggest: {
                preview: true, insertMode: "replace"
            },
            automaticLayout: true, fixedOverflowWidgets: true
        });
        /*
        require(['vs/editor/editor.main'], function () {
            monaco.editor.create($("#monacoEditor"), {
                value: "script", language: 'html', theme: 'vs-dark', automaticLayout: true, fixedOverflowWidgets: true
            });
        });
        */
        editorArray.push(editor);
        return editor;
    }


    function addNewEditor(code, elementId, language) {
        var new_container = document.createElement("DIV");
        new_container.id = "container-" + fileCounter.toString(10);
        new_container.className = "monacocontainer";
        document.getElementById(elementId).appendChild(new_container);
        newEditor(new_container.id, code, language);
        fileCounter += 1;
    }

    addNewEditor(JSON.parse(JSON.stringify(Metro.storage.getItem('SelectedMenu', null))).HtmlContent ,"monacoHTML", 'html');
    addNewEditor(JSON.parse(JSON.stringify(Metro.storage.getItem('SelectedMenu', null))).JsContent, "monacoJS", 'javascript');
    addNewEditor(JSON.parse(JSON.stringify(Metro.storage.getItem('SelectedMenu', null))).CssContent, "monacoCSS", 'css');
    /*
    var languageSelected = document.querySelector('.language');    
    languageSelected.onchange = function () {
        monaco.editor.setModelLanguage(window.monaco.editor.getModels()[0], "html")
    }
    */

   
    var themeSelected = document.querySelector('.theme');    
    themeSelected.onchange = function () {
        monaco.editor.setTheme(themeSelected.value)
    }
    
    /*
    monaco.languages.registerCompletionItemProvider('myCustomLanguage', {
        provideCompletionItems: function (model, position) {
            const suggestions = [
                {
                    label: 'console',
                    kind: monaco.languages.CompletionItemKind.Function,
                    documentation: 'Logs a message to the console.',
                    insertText: 'console.log()',
                },
                {
                    label: 'setTimeout',
                    kind: monaco.languages.CompletionItemKind.Function,
                    documentation: 'Executes a function after a specified time interval.',
                    insertText: 'setTimeout(() => {\n\n}, 1000)',
                }
            ];

            return { suggestions: suggestions };
        }
    });
    */
});