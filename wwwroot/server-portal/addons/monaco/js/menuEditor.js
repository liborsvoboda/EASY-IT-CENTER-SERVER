require.config({ paths: { 'vs': '/server-portal/addons/monaco/js/monaco-editor/min/vs' } });
require(['vs/editor/editor.main'], function () {

    let fileCounter = 0;

    monaco.editor.defineTheme('myTheme', {
        base: 'vs-dark',
        inherit: true,
        rules: [{ background: 'EDF9FA' }],
        // colors: { 'editor.lineHighlightBackground': '#0000FF20' }
    });
    monaco.editor.setTheme('myTheme');


    function newEditor(elementId, container_id, code, language) {
        let model = monaco.editor.createModel (code, language);
        let editor = monaco.editor.create(document.getElementById(container_id), {
            model: model,
            suggest: {
                preview: true, insertMode: "replace"
            },
            automaticLayout: true, fixedOverflowWidgets: true,
            //language: language,
        });
        
        Gs.Variables.monacoEditorList.push({ elementId: elementId, editor: editor, model: model });
        return editor;
    }


    function addNewEditor(code, elementId, language) {
        var new_container = document.createElement("DIV");
        new_container.id = "container-" + fileCounter.toString(10);
        new_container.className = "monacocontainer";
        document.getElementById(elementId).appendChild(new_container);
        newEditor(elementId,new_container.id, code, language);
        fileCounter += 1;
    }

    addNewEditor("" ,"monacoHTML", 'html');
    addNewEditor("", "monacoJS", 'javascript');
    addNewEditor("", "monacoCSS", 'css');

    //THEME Selector
    let themeSelect = document.createElement("SELECT");
    themeSelect.setAttribute("id", "EditorThemeSelector");
    themeSelect.style['position'] = 'absolute';
    themeSelect.style['z-index'] = '2000';
    themeSelect.style["top"] = "20px";
    themeSelect.style["right"] = "30px";

    let option = document.createElement("option"); option.setAttribute("value", "vs-dark");option.innerHTML = "vs-dark";themeSelect.appendChild(option);
    let option1 = document.createElement("option"); option1.setAttribute("value", "vs"); option1.innerHTML = "vs"; themeSelect.appendChild(option1);
    let option2 = document.createElement("option"); option2.setAttribute("value", "hc-black"); option2.innerHTML = "hc-black"; themeSelect.appendChild(option2);
    document.getElementById("EditorSelection").appendChild(themeSelect);

    var themeSelected = document.getElementById('EditorThemeSelector');
    themeSelected.onchange = function () {
        monaco.editor.setTheme(themeSelected.value);
    }

    //LANGUAGE SELECTOR
    let languageSelect = document.createElement("SELECT");
    languageSelect.setAttribute("id", "EditorLanguageSelector");
    languageSelect.style['position'] = 'absolute';
    languageSelect.style['z-index'] = '2000';
    languageSelect.style["top"] = "50px";
    languageSelect.style["right"] = "30px";
    document.getElementById("EditorSelection").appendChild(languageSelect);

    let sharedMonacoLanguageList = Metro.storage.getItem("SharedMonacoLanguageList", null);

    let languageElement = document.getElementById('EditorLanguageSelector');
    if (languageElement.options.length == 0) {
        sharedMonacoLanguageList.forEach(language => {
            if (language.Active && !language.Custom) {
                let opt = document.createElement('option');
                opt.value = language.Language;opt.innerHTML = language.Language;
                languageElement.appendChild(opt);

            } else if (language.Active && language.Custom) {
                let opt = document.createElement('option');
                opt.value = language.Language; opt.innerHTML = language.Language;
                languageElement.appendChild(opt);

                monaco.languages.registerCompletionItemProvider(language.Language, {
                    provideCompletionItems: function (model, position) {
                        const suggestions = Metro.storage.getItem('SharedMonacoSuggestionList', null).filter(obj => { if (obj.monacoLanguageListLanguage == language.Language) { return obj; } });
                        return { suggestions: suggestions };
                    }
                });
                monaco.languages.register({ id: language.Language });
            }
        });
    }

     languageElement.onchange = function () {
         monaco.editor.setModelLanguage(Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoHTML" })[0].model, languageElement.value)
         monaco.editor.setModelLanguage(Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoJS" })[0].model, languageElement.value)
         monaco.editor.setModelLanguage(Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "monacoCSS" })[0].model, languageElement.value)
     }

   
    

    

    /*
    monaco.languages.registerCompletionItemProvider('metro4', {
        provideCompletionItems: function (model, position) {
            const suggestions = [
                {
                    label: 'console',
                    kind: monaco.languages.CompletionItemKind.Function,
                    documentation: 'Logs a message to the console.',
                    insertText: 'console.log("data",)',
                },
                {
                    label: 'setTimeout',
                    kind: monaco.languages.CompletionItemKind.Function,
                    documentation: 'Executes a function after a specified time interval.',
                    insertText: 'setTimeout(() => {\n\n}, 1000)',
                },
                {
                    label: 'metro',
                    kind: 1,
                    documentation: 'Executes a function after a specified time interval.',
                    insertText: 'setTimeout(() => {\n\n}, 1000)',
                }
            ];

            return { suggestions: suggestions };
        }
    });
    */


 
});