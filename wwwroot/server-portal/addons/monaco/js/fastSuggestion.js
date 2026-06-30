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

    addNewEditor("","fastSuggestion", 'javascript');

    let languageSelected = document.getElementById("FastSugestEditorLang");    
    languageSelected.onchange = function () {
        monaco.editor.setModelLanguage(Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "fastSuggestion" })[0].model, languageSelected.value)
    }

    let themeSelected = document.getElementById("FastSugestEditorTheme");    
    themeSelected.onchange = function () {
        monaco.editor.setTheme(themeSelected.value)
    }

    let mixedenumList = Metro.storage.getItem("SolutionMixedEnumList", null);

    let selectElement = document.getElementById("FastSugestEditorLang");
    if (selectElement.options.length == 0) {
        mixedenumList.forEach(mixedEnum => {
            if (mixedEnum.ItemsGroup == "MonacoLanguageType") {
                var opt = document.createElement('option');
                opt.value = mixedEnum.SystemName;
                opt.innerHTML = mixedEnum.SystemName;
                selectElement.appendChild(opt);
            }
        });

        mixedenumList.forEach(mixedEnum => {
            if (mixedEnum.ItemsGroup == "MonacoLanguageType" && mixedEnum.Active && Metro.storage.getItem('MonacoSuggestionList', null).filter(obj => { if (obj.inheritedMonacoLanguageType == mixedEnum.SystemName) { return obj; } }).length > 0) {
                monaco.languages.registerCompletionItemProvider(mixedEnum.SystemName, {
                    provideCompletionItems: function (model, position) {
                        const suggestions = Metro.storage.getItem('MonacoSuggestionList', null).filter(obj => { if (obj.inheritedMonacoLanguageType == mixedEnum.SystemName) { return obj; } });
                        return { suggestions: suggestions };
                    }
                });
                monaco.languages.register({ id: mixedEnum.SystemName });
            }
        });
    }
});