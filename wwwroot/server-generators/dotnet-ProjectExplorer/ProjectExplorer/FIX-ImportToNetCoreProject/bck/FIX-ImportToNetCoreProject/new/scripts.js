function onBodyLoad() {

    // https://github.com/nathancahill/Split.js
    Split(['#leftPane', '#rightPane'], {
        sizes: ['504px', 'calc(100% - 504px)'],
        gutterSize: 20,
        minSize: 1,
        cursor: 'col-resize'
    });

    generateLineNumbers('ln', 200);
}

function addToolbar() {
    var editorPane = document.getElementById("sourceCode");
    if (!editorPane) {
        return;
    }

    var documentOutlineButton = document.createElement('img');
    documentOutlineButton.setAttribute('src', 'content/icons/DocumentOutline.png');
    documentOutlineButton.title = "Document Outline";
    documentOutlineButton.className = 'documentOutlineButton';
    documentOutlineButton.onclick = showDocumentOutline;
    editorPane.appendChild(documentOutlineButton);

    var projectExplorerButton = document.createElement('img');
    var projectExplorerIcon = 'content/icons/CSharpProjectExplorer.png';

    projectExplorerButton.setAttribute('src', projectExplorerIcon);
    projectExplorerButton.title = "Project Explorer";
    projectExplorerButton.className = 'projectExplorerButton';
    projectExplorerButton.onclick = function () { document.getElementById('projectExplorerLink').click(); };
    editorPane.appendChild(projectExplorerButton);

    var namespaceExplorerButton = document.createElement('img');
    namespaceExplorerButton.setAttribute('src', 'content/icons/NamespaceExplorer.png');
    namespaceExplorerButton.title = "Namespace Explorer";
    namespaceExplorerButton.className = 'namespaceExplorerButton';
    namespaceExplorerButton.onclick = showNamespaceExplorer;
    editorPane.appendChild(namespaceExplorerButton);
}

function showDocumentOutline() {
}

function showNamespaceExplorer() {
}

function generateLineNumbers(id, count) {
    if (count == 0) {
        return;
    }

    var list = [];
    for (var i = 1; i <= count; i++) {
        var line =
            "<a id=\"l" +
            i +
            "\" href=\"" +
            "/#" + 
            i +
            "\">" + i + "</a><br>";
        list.push(line);
    }

    var text = list.join("");

    document.getElementById(id).innerHTML = text;
}
