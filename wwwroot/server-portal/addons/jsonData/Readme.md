# IO JSON Generator


document.getElementById("JsonEditor").innerHTML = "<iframe id=\"IFrameWindow\" src=\"" + Metro.storage.getItem("ApiOriginSuffix", null) + "server-portal/addons/jsonData/index.html" + "\" width=\"100%\" height=\"600\" frameborder=\"0\" scrolling=\"yes\" style=\"width:100%; height:100%;\"></iframe>";
inputEditor.doc.setValue('["test"]')
inputEditor.doc.getValue()

JSON.parse(JSON.stringify(decodeURI(json.contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text"))));
JSON.parse(decodeURI(document.getElementById("IFrameWindow").contentWindow.document.getElementById("copy-code").getAttribute("data-clipboard-text")));

document.getElementById("IFrameWindow").contentWindow.inputEditor.doc.getValue()
JSON.parse(document.getElementById("IFrameWindow").contentWindow.inputEditor.doc.getValue())