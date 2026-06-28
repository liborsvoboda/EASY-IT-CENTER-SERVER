

/**
* Get Random String
*
* @function
* @return {string} Filtered text
*/
Gs.Functions.RandomString = function () {
    return Math.random(10) * 10000000000000000;
}


/**
* HTML entities decode
*
* @function
* @param {string} str Input text
* @return {string} Filtered text
*/
Gs.Functions.HtmlDecode = function (str) {

    var txt = document.createElement('textarea');
    txt.innerHTML = str;
    return txt.value;
}

/**
* Function Generate UUID string
* @function
* @return {string} return UUID
*/
Gs.Functions.GenerateUUID = function () { 
    let d = new Date().getTime();
    let d2 = ((typeof performance !== 'undefined') && performance.now && (performance.now() * 1000)) || 0;
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        let r = Math.random() * 16;
        if (d > 0) {
            r = (d + r) % 16 | 0;
            d = Math.floor(d / 16);
        } else {
            r = (d2 + r) % 16 | 0;
            d2 = Math.floor(d2 / 16);
        }
        return (c === 'x' ? r : (r & 0x3 | 0x8)).toString(16);
    });
}


/**
* Function Element from Page
* @function
*/
Gs.Functions.RemoveElement = function (elementId) {
    let element = document.getElementById(elementId);
    if (element != null) { element.remove(); }
}


/**
* Function Add Class to Element
* @function
* @param {string} elementId elementId
* @param {string} clasName className for adding
*/
Gs.Functions.AddClass = function (elementId,clasName) {
    $("#" + elementId).addClass(clasName); //"disabled"
}


/**
* Function Remove Class from Element
* @function
* @param {string} elementId elementId
* @param {string} clasName className for removing
*/
Gs.Functions.RemoveClass = function (elementId, clasName) {
    $("#" + elementId).removeClass(clasName); //"disabled"
}

/**
* Function Html Decode
* @function
* @param {string} input string
* @return {boolean} return string
*/
Gs.Functions.HtmlDecode = function (input) {
    let doc = new DOMParser().parseFromString(input, "text/html");
    return doc.documentElement.textContent;
}


/**
* Function FileReader to Base64 Image Data
* @function
* @param {string} n Files
* @param {string} clasName className for adding
* @return {boolean} return status
*/
Gs.Functions.FileReaderToImageData = async function (n) {
    const t = new FileReader; return await new Promise((t, i) => {
        const r = new FileReader; r.onloadend = () => t(r.result); r.onerror = i;
        console.log("files", JSON.parse(JSON.stringify(files)));
        r.readAsDataURL(n[0]);
    })
}


/**
* Function String to Byte Array
* @function
* @param {string} str string
* @return {boolean} return byte Array
*/
Gs.Functions.Str2bytes = function (str) {
    let bytes = new Uint8Array(str.length);
    for (let i = 0; i < str.length; i++) {
        bytes[i] = str.charCodeAt(i);
    }
    return bytes;
}


/**
* Function Preload IMage from Source
* @function
* @param {string} src source URL
*/
Gs.Functions.PreloadImage = function (src) {
    let img = new Image();
    img.src = src;
}

/**
* Function Bind YouTube Play
* @function
* @param {string} img elementId
*/
Gs.Functions.BindYouTubePlay = function (img) {
    let a = img.parent();
    let p = a.parent();
    if (p[0] && p[0].tagName === 'P') {
        let id = splitOnFirst(splitOnLast(a.attr('href'), '/')[1], '?')[0];
        let width = Math.floor(img[0].offsetWidth / 2 - 43);
        let height = Math.floor(img[0].offsetHeight / 2 - 31);
        let html = `<i class="youtube-play" style="width:${img[0].offsetWidth}px;height:${img[0].offsetHeight}px;background-position:${width}px ${height}px" onclick="playVideo(this,'${id}')"></i>`;
        p.prepend(html);
    }
}

/**
* Function Bind YouTebe Images
* @function
*/
Gs.Functions.BindYouTubeImages = function () {
    preloadImage('/images/youtube-play-hover.png');
    $("a[href^='https://youtu.be/']>img").each(function () {
        if (this.complete) {
            Gs.Functions.BindYouTubePlay($(this));
        } else {
            this.onload = function () { Gs.Functions.BindYouTubePlay($(this)); }
        }
    });
}


/**
* Function Video to Iframe
* @function
* @return {string} return iframe
*/
Gs.Functions.Video = function (url) {
    return '<iframe style="width:100%;min-height:585px" src="' + url + '" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>';
}

/**
* Function Play Video in IFrame
* @function
* @param {string} el elementId
* @param {string} id video Id
*/
Gs.Functions.PlayVideo = function (el, id) {
    let url = 'https://www.youtube.com/embed/' + id + '?autoplay=1';
    $(el).parent().html(Gs.Functions.Video(url));
}


/**
* Function PrintTables
* @function
* @param {string} tables table List
* @return {boolean} return Html Table
*/
Gs.Functions.PrintTables = function (tables) {
    let html = "<thead><tr><th>Table List</th></tr></thead>";
    const rows = tables.map(function (table) {
        return `<tr>
            <td>
                <button class="sqlime-link" data-action="showTable" data-arg="${table}">
                    ${table}
                </button>
            </td>
        </tr>`;
    });
    html += "<tbody>" + rows.join("\n") + "</tbody>";
    return `<table>${html}</table>`;
}


/**
* Function Print MarkDown for insert string to Markdown Tag
* @function
* @param {string} text string
* @return {boolean} return markdown tag
*/
Gs.Functions.PrintMarkdown = function (text) {
    return `<pre>${text}</pre>`;
}


/**
* Function Add Values to Tag with Class
* @function
* @param {string} values values
* @param {string} tagName tagName
* @param {string} className className
* @return {boolean} return tags
*/
Gs.Functions.GenerateTagList = function (values, tagName, className) {
    if (values.length === 0) {
        return "";
    }
    const open = "<" + tagName + " class='" + className + "' >";
    const close = "</" + tagName + ">";
    return open + values.join(close + open) + close;
}

/**
* Function ShowSource Show New Window wiht SourceCode
* @function
*/
Gs.Functions.ShowSource = function () {
    var source = "<html>";
    source += document.getElementsByTagName('html')[0].innerHTML;
    source += "</html>";
    source = source.replace(/</g, "&lt;").replace(/>/g, "&gt;");
    source = "<pre>" + source + "</pre>";
    sourceWindow = window.open('', 'Sorce code', 'height=800,width=1000,scrollbars=1,resizable=1');
    sourceWindow.document.write(source);
    sourceWindow.document.close();
    if (window.focus) sourceWindow.focus();
}

/**
* Function ShowFrameSource Window with Sorce Code from Iframe
* @function
*/
Gs.Functions.ShowFrameSource = function () {
    var source = "<html>";
    source += document.getElementById('IFrameWindow').contentWindow.document.body.innerHTML;
    source += "</html>";
    source = source.replace(/</g, "&lt;").replace(/>/g, "&gt;");
    source = "<pre>" + source + "</pre>";
    sourceWindow = window.open('', 'Sorce code', 'height=800,width=1000,scrollbars=1,resizable=1');
    sourceWindow.document.write(source);
    sourceWindow.document.close();
    if (window.focus) sourceWindow.focus();
}

/**
* Function ShowWindowFrameSource to new Window with Source Code
* @function
*/
Gs.Functions.ShowWindowFrameSource = function () {
    var source = "<html>";
    source += document.getElementById('WindowFrame').contentWindow.document.body.innerHTML;
    source += "</html>";
    source = source.replace(/</g, "&lt;").replace(/>/g, "&gt;");
    source = "<pre>" + source + "</pre>";
    sourceWindow = window.open('', 'Sorce code', 'height=800,width=1000,scrollbars=1,resizable=1');
    sourceWindow.document.write(source);
    sourceWindow.document.close();
    if (window.focus) sourceWindow.focus();
}


/**
* Function PrintOrExportWindow for function of Openned Window
* @function
*/
Gs.Functions.PrintOrExportWindow = function (command) {
    switch (command) {
        case "Print":
            Gs.Functions.PrintWindowElement();
            break;
        case "Download":
            Gs.Functions.DownloadWindowElement(); 
            break;
        case "Image":
            Gs.Functions.ImageFromWindowElement();
            break;
        case "Copy":
            Gs.Functions.CopyWindowElement(); 
            break;
        case "Pdf":
            Gs.Functions.HtmlToPdfElement();
            break;
    }
}


/**
* Function HtmlToPdfElement Download Pdf from HTML
* @function
* @param {string} elementId elementId
*/
Gs.Functions.HtmlToPdfElement = function (elementId) {
    let iFrameExist = document.querySelector("#IFrameWindow") != null;
    let dataFrameExist = document.querySelector("#IFrameWindow") != null ? document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow") : null != null;
    if (!dataFrameExist && elementId == "FrameWindow" && iFrameExist) { elementId = "IFrameWindow"; }
    else if (dataFrameExist) { elementId = "DataFrameWindow"; } else { elementId = "FrameWindow"; }

    if (elementId == "IFrameWindow") {
        pdfMake.createPdf({ content: htmlToPdfmake(document.querySelector("#IFrameWindow").contentWindow.document.body.innerHTML) }).download('Html2Pdf.pdf');
    } else if (elementId == "FrameWindow") {
        pdfMake.createPdf({ content: htmlToPdfmake(document.getElementById("FrameWindow").innerHTML) }).download('Html2Pdf.pdf');

    } else {
        pdfMake.createPdf({ content: htmlToPdfmake(document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow").contentWindow.document.body.innerHTML) }).download('Html2Pdf.pdf');
    }
}

/**
* Function Print Window Element
* @function
* @param {string} elementId elementId
*/
Gs.Functions.PrintWindowElement = function (elementId) {
    try {
        let iFrameExist = document.querySelector("#IFrameWindow") != null;
        let dataFrameExist = document.querySelector("#IFrameWindow") != null ? document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow") : null != null;
        if (!dataFrameExist && elementId == "FrameWindow" && iFrameExist) { elementId = "IFrameWindow"; }
        else if (dataFrameExist) { elementId = "DataFrameWindow"; } else { elementId = "FrameWindow"; }

        if (elementId == "FrameWindow") {
            let divElements = document.getElementById(elementId).innerHTML;
            let oldPage = document.body.innerHTML;
            document.body.innerHTML =
                "<html><head>" + document.getElementsByTagName('head')[0].innerHTML + "</head><body>" + divElements + "</body>";
            window.print();
            document.body.innerHTML = oldPage;
        } else if (elementId == "IFrameWindow") { document.querySelector(`#${elementId}`).contentWindow.print(); }
        else { document.querySelector("#IFrameWindow").contentWindow.document.querySelector("#DataFrameWindow").contentWindow.print(); }
    } catch (t) { }
}


/**
* Function Download HTML Window Element
* @function
* @param {string} elementId elementId
*/
Gs.Functions.DownloadWindowElement = function (elementId) {
    try {
        let iFrameExist = document.querySelector("#IFrameWindow") != null;
        let dataFrameExist = document.querySelector("#IFrameWindow") != null ? document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow") : null != null;
        if (!dataFrameExist && elementId == "FrameWindow" && iFrameExist) { elementId = "IFrameWindow"; }
        else if (dataFrameExist) { elementId = "DataFrameWindow"; } else { elementId = "FrameWindow"; }

        if (elementId == "IFrameWindow") {
            let t = document.body.appendChild(document.createElement("a"));
            t.download = "KlikneteZde" + ".html";
            t.href = "data:text/html;charset=utf-8," + encodeURIComponent(document.querySelector("#IFrameWindow").contentWindow.document.body.innerHTML);
            t.click();
        } else if (elementId == "FrameWindow") {
            let t = document.body.appendChild(document.createElement("a"));
            t.download = elementId + ".html";
            t.href = "data:text/html;charset=utf-8," + encodeURIComponent(document.querySelector("#FrameWindow").innerHTML);
            t.click();
        } else {
            let t = document.body.appendChild(document.createElement("a"));
            t.download = elementId + ".html";
            t.href = "data:text/html;charset=utf-8," + encodeURIComponent(document.querySelector("#IFrameWindow").contentWindow.document.querySelector("#DataFrameWindow").contentDocument.body.innerHTML);
            t.click();
        }
    } catch (i) { }
}

/**
* Function CopyWindowElement to buffer
* @function
*/
Gs.Functions.CopyWindowElement = async function () {
    try {
        let iFrameExist = document.querySelector("#IFrameWindow") != null;
        let dataFrameExist = document.querySelector("#IFrameWindow") != null ? document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow") : null != null;
        if (!dataFrameExist && elementId == "FrameWindow" && iFrameExist) { elementId = "IFrameWindow"; }
        else if (dataFrameExist) { elementId = "DataFrameWindow"; } else { elementId = "FrameWindow"; }


        if (elementId == "IFrameWindow") {
            let aux = document.createElement("input");
            aux.setAttribute("value", document.querySelector("#IFrameWindow").contentWindow.document.body.innerHTML);
            document.body.appendChild(aux);
            aux.select();
            document.execCommand("copy",false);
            document.body.removeChild(aux);

            let t = document.querySelector("#IFrameWindow").contentWindow.document.body.innerHTML;
            await navigator.clipboard.writeText(t);
        } else if (elementId == "FrameWindow") {
                let aux = document.createElement("input");
                aux.setAttribute("value", document.getElementById("FrameWindow").innerHTML);
                document.body.appendChild(aux);
                aux.select();
            document.execCommand("copy", false);
                document.body.removeChild(aux);
            let t = document.getElementById(elementId).innerHTML;
            await navigator.clipboard.writeText(t);
        } else {
            let aux = document.createElement("input");
            aux.setAttribute("value", document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow").contentWindow.document.body.innerHTML);
            document.body.appendChild(aux);
            aux.select();
            document.execCommand("copy",false);
            document.body.removeChild(aux);

            let t = document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow").contentWindow.document.body.innerHTML;
            await navigator.clipboard.writeText(t);
        }
    } catch (t) { }
}

/**
* Function Download Image from Window Element
* @function
*/
Gs.Functions.ImageFromWindowElement = function () {
    try {
        let iFrameExist = document.querySelector("#IFrameWindow") != null;
        let dataFrameExist = document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow") != null;
        if (!dataFrameExist && elementId == "FrameWindow" && iFrameExist) { elementId = "IFrameWindow"; }
        else if (dataFrameExist) { elementId = "DataFrameWindow"; } else { elementId = "FrameWindow"; }


        if (elementId == "FrameWindow") {
            $("document").ready(function () {
                html2canvas($("#" + elementId), {
                    onrendered: function (t) {
                        $("#previewImage").append(t);
                        var r = t.toDataURL("image/png"), u = r.replace(/^data:image\/png/, "data:application/octet-stream"), i = document.body.appendChild(document.createElement("a"));
                        i.download = elementId + ".png";
                        i.href = u; i.click()
                    }
                })
            })
        } else if (elementId == "IFrameWindow") {
            $("document").ready(function () {
                html2canvas(document.querySelector("#IFrameWindow").contentWindow.document.body, {
                    onrendered: function (t) {
                        $("#previewImage").append(t);
                        var r = t.toDataURL("image/png"), u = r.replace(/^data:image\/png/, "data:application/octet-stream"), i = document.body.appendChild(document.createElement("a"));
                        i.download = "KlikneteZdeCz.png";
                        i.href = u; i.click();
                    }
                });
            });
        } else {
            $("document").ready(function () {
                html2canvas(document.querySelector("#IFrameWindow").contentWindow.window.document.querySelector("#DataFrameWindow").contentWindow.document.body, {
                    onrendered: function (t) {
                        $("#previewImage").append(t);
                        var r = t.toDataURL("image/png"), u = r.replace(/^data:image\/png/, "data:application/octet-stream"), i = document.body.appendChild(document.createElement("a"));
                        i.download = "KlikneteZdeCz.png";
                        i.href = u; i.click();
                    }
                });
            });
        }
    } catch (t) { }
}

/**
* Function Save Url to Browser
* @function
*/
Gs.Functions.SaveBrowserLink = function () {
    document.execCommand("createLink", false, window.location.origin);
}

/**
* Function Add Web Page to Favories
* @function
*/
Gs.Functions.SaveToFavorites = function (title, url) {
    if (window.sidebar) { // Firefox
        window.sidebar.addPanel(title, url, '');
    }
    else if (window.opera && window.print) { // Opera
        var elem = document.createElement('a');
        elem.setAttribute('href', url);
        elem.setAttribute('title', title);
        elem.setAttribute('rel', 'sidebar');
        elem.click();
    }
    else if (document.all) { // ie
        window.external.AddFavorite(url, title);
    } else {
        let createBookmark = browser.bookmarks.create({
            title: "KlikneteZde.Cz",
            url: "https://KlikneteZde.Cz",
        });
    }
}


/**
* Function Load Metro Framework
* @function
*/
Gs.Functions.LoadMetro = async function () {
    const pathCss = './metro/css/metro-all.min.css';
    const pathThemeCss = './metro/css/schemes/sky-net.css';
    const pathJs = './metro/js/metro.4.5.2.min.js?v=4.5.2';

    const dataCss = await fetch(pathCss).then((r) => r.text());
    const dataThemeCss = await fetch(pathThemeCss).then((r) => r.text());

    const myFont = new FontFace('metro', "url('./metro/mif/metro.svg') format('svg'), url('./metro/mif/metro.woff') format('woff'), url('./metro/mif/metro.ttf') format('truetype')");
    await myFont.load(); document.fonts.add(myFont);
    const dataJs = await fetch(pathJs).then((r) => r.text());
    const style = document.createElement("style");
    style.textContent = dataCss;
    document.querySelector("head").appendChild(style);
    style.textContent = dataThemeCss;
    document.querySelector("head").appendChild(style);

    new Function(dataJs)();
    Metro.init();
    Metro.toast.create("Metro 4 did loaded successful!", { showTop: true, clsToast: "success" });
}

/**
* Function Unload Metro Framework
* @function
*/
Gs.Functions.UnloadMetro = function () {
    //delete Metro;
}

/**
* Function Load Html Page to Element
* @function
* @param {string} elementId elementId
* @param {string} url url
*/
Gs.Functions.LoadHtmlPage = function (elementId,url) {
    $.ajax({
        url: url
    }).done(function (data) {
        $('#' + elementId).html(data);
    });
}

/**
* Function Load HTML content from URL
* @function
* @param {string} elementId elementId
* @param {string} url url
* @return {boolean} return status
*/
Gs.Functions.LoadHtmlContent = function (elementId, url) {
    $.ajax({
        url: url
    }).done(function (data) {
        return data;
    });
}

/**
* Function load URL Html Page to Iframe in Element
* @function
* @param {string} elementId elementId
* @param {string} url url of Iframe
*/
Gs.Functions.LoadHtmlPageToFrame = function (elementId, url, openWindow = false) {
    if (openWindow) { window.open(url, '_blank'); } else {
        let frame = '<div id=MainWindow data-role="window" data-custom-buttons="WindowButtons" data-btn-close="false" class="h-100" data-btn-min="false" data-btn-max="false" data-width="100%" data-height="800" data-draggable="false" >'
            + '<iframe id="IFrameWindow" src="' + url + '" width="100%" height="700" frameborder="0" scrolling="yes" style="width: 100%; height: 100%;" ></iframe>';
        $('#' + elementId).html(frame);
    }
  
}

/**
* Function Get Function List of WebPages
* @function
*/
Gs.Functions.GetFunctionList = function () {
    let functionList = [];
    for (var p in Gs.Media) { if (typeof Gs.Media[p] === "function") { functionList.push({ title: `Gs.Media.${p}()`, folder: false, checkbox: false, key: Gs.Media[p].toString() }); } }
    for (var p in Gs.Functions) { if (typeof Gs.Functions[p] === "function") { functionList.push({ title: `Gs.Functions.${p}()`, folder: false, checkbox: false, key: Gs.Functions[p].toString() }); } }
    for (var p in Gs.Behaviors) { if (typeof Gs.Behaviors[p] === "function") { functionList.push({ title: `Gs.Behaviors.${p}()`, folder: false, checkbox: false, key: Gs.Behaviors[p].toString() }); } }
    for (var p in Gs.Objects) { if (typeof Gs.Objects[p] === "function") { functionList.push({ title: `Gs.Objects.${p}()`, folder: false, checkbox: false, key: Gs.Objects[p].toString() }); } }
    for (var p in Gs.Apis) { if (typeof Gs.Apis[p] === "function") { functionList.push({ title: `Gs.Apis.${p}()`, folder: false, checkbox: false, key: Gs.Apis[p].toString() }); } }
    for (var p in Gs.Socket) { if (typeof Gs.Socket[p] === "function") { functionList.push({ title: `Gs.Socket.${p}()`, folder: false, checkbox: false, key: Gs.Socket[p].toString() }); } }
    for (var p in Gs.SignalR) { if (typeof Gs.SignalR[p] === "function") { functionList.push({ title: `Gs.SignalR.${p}()`, folder: false, checkbox: false, key: Gs.SignalR[p].toString() }); } }
    
    Metro.storage.setItem('FunctionList', functionList.sort((a, b) => (a.title > b.title) * 2 - 1));
}

/**
* Function load CSS code as WEbPage Style
* @function
* @param {string} elementId elementId
* @param {string} code className for adding
*/
Gs.Functions.loadCSS = function (elementId, code) {
    if (code) {
        Gs.Functions.RemoveElement(elementId);
        var style = document.createElement("style");
        style.setAttribute("id", elementId);
        style.innerHTML = code;
        document.head.appendChild(style);
    }
};

/**
* Function load Javascript as Script Code
* @function
* @param {string} elementId elementId
* @param {string} code script code
*/
Gs.Functions.loadJS = function (elementId, code) {
    if (code) {
        Gs.Functions.RemoveElement(elementId);
        var script = document.createElement("script");
        script.setAttribute("id", elementId);
        script.innerHTML = code;
        document.body.appendChild(script);
    }
};

/**
* Function Export Table MenuTable to Specific Format
* @function
* @param {string} params params
*/
Gs.Functions.ExportTable = function (params) {
    var options = {
        tableName: 'TableData',
        worksheetName: 'Export Table'
    };
    $.extend(true, options, params);
    if (document.getElementById("IFrameWindow") == null) { $('#menuTable').tableExport(options); }
    else {
        $('#menuTable').tableExport(options);
    }
}

/**
* Function Blob to Base64 Image
* @function
* @param {string} blob blob
* @return {string} return Base64 string
*/
Gs.Functions.BlobToBase64Image = function (blob) {
    let blobUrl = URL.createObjectURL(blob);

    return new Promise((resolve, reject) => {
        let img = new Image();
        img.onload = () => resolve(img);
        img.onerror = err => reject(err);
        img.src = blobUrl;
    }).then(img => {
        URL.revokeObjectURL(blobUrl);
        let [w, h] = [img.width, img.height]
        let aspectRatio = w / h
        let factor = Math.max(w, h) / 256
        w = w / factor
        h = h / factor
        let canvas = document.createElement("canvas");
        canvas.width = w;
        canvas.height = h;
        let ctx = canvas.getContext("2d");
        ctx.drawImage(img, 0, 0);
        return canvas.toDataURL();
    })
} 

/**
* Function Blob to Image
* @function
* @param {string} blob blob data
* @return {bytes} return status
*/
Gs.Functions.BlobToImageData = function (blob) {
    let blobUrl = URL.createObjectURL(blob);

    return new Promise((resolve, reject) => {
        let img = new Image();
        img.onload = () => resolve(img);
        img.onerror = err => reject(err);
        img.src = blobUrl;
    }).then(img => {
        URL.revokeObjectURL(blobUrl);
        let [w, h] = [img.width, img.height]
        let aspectRatio = w / h
        let factor = Math.max(w, h) / 256
        w = w / factor
        h = h / factor

        let canvas = document.createElement("canvas");
        canvas.width = w;
        canvas.height = h;
        let ctx = canvas.getContext("2d");
        ctx.drawImage(img, 0, 0);

        return ctx.getImageData(0, 0, w, h);
    })
}

/**
* Function Image Data to Blob
* @function
* @param {string} imageData image data
* @return {bytes} return blob
*/
Gs.Functions.ImageDataToBlob = function (imageData) {
    let w = imageData.width;
    let h = imageData.height;
    let canvas = document.createElement("canvas");
    canvas.width = w;
    canvas.height = h;
    let ctx = canvas.getContext("2d");
    ctx.putImageData(imageData, 0, 0, w, h); 

    return new Promise((resolve, reject) => {
        canvas.toBlob(resolve); 
    })
}

/**
* Function Object from Url to Blob
* @function
* @param {string} url url
* @return {bytes} return blob
*/
Gs.Functions.ObjectURLToBlob = function (url) {
    return new Promise(async (resolve, reject) => {
        try {
            let blob = await fetch(url)
            resolve(blob)
        } catch (err) {
            reject(err)
        }
    })
}


/**
* Function Blob to Base64
* @function
* @param {string} blob blob
* @return {string} return base64
*/
Gs.Functions.BlobToBase64 = function (blob) {
    let result = new Promise((resolve, _) => {
        const reader = new FileReader();
        reader.onloadend = () => resolve(reader.result);
        reader.readAsDataURL(blob);
    });
    return result;
}


/**
* Function Blob to URL Object
* @function
* @param {string} blob blob
* @return {string} return url
*/
Gs.Functions.BlobToObjectURL = function (blob) {
    return new Promise((resolve, reject) => {
        try {
            resolve(URL.createObjectURL(blob))
        } catch (err) {
            reject(err)
        }
    })
}


/**
* Function Color HEX to RGB Array
* @function
* @param {string} hex hex color
* @return {Array} return array
*/
Gs.Functions.ColorHexToRgbArr = function (hex) {
    return ['0x' + hex[1] + hex[2] | 0, '0x' + hex[3] + hex[4] | 0, '0x' + hex[5] + hex[6] | 0];
}

/**
* Function Color Hex to RGB
* @function
* @param {string} hex hex color
* @return {string} return rgb string
*/
Gs.Functions.ColorHexToRgb = function (hex) {
    const r = parseInt(hex.slice(1, 3), 16);
    const g = parseInt(hex.slice(3, 5), 16);
    const b = parseInt(hex.slice(5, 7), 16);
    return r.toString() + "," + g.toString() + "," + b.toString() ;
}


/**
* Function Color RGB to HEX
* @function
* @param {string} colorArray RGB Array
* @return {boolean} return HEX color
*/
Gs.Functions.ColorRgbToHex = function rgbToHex(colorArray) {
    let r = colorArray[0]; let g = colorArray[1]; let b = colorArray[2];
    return "#" + (1 << 24 | r << 16 | g << 8 | b).toString(16).slice(1);
}

/**
* Function What Is It object type
* @function
* @param {string} data object
* @return {boolean} return object type
*/
Gs.Functions.WhatIsIt = function (data) {
    if (data === null) {
        return "null";
    }
    if (data === undefined) {
        return "undefined";
    }
    if (data === "") {
        return "String";
    }
    if (data.constructor.name === "function") {
        return "Function";
    }
    if (data.constructor.name === "String") {
        return "String";
    }
    if (data.length != undefined) {
        return "Array";
    }
    if (typeof(data) === 'object') {
        return "Object";
    }
    {
        return "don't know";
    }
}


/**
* Function Load URL Image as String
* @function
* @param {string} url url
* @return {string} return base64
*/
Gs.Functions.LoadUrlImageAsString = async function (url) {
    return await fetch(url)
        .then(response => response.blob())
        .then(blob => {
            return new Promise((resolve, reject) => {
                const reader = new FileReader();
                reader.onload = () => resolve(reader.result);
                reader.onerror = (error) => reject('Error: ', error);
                reader.readAsDataURL(blob);
            });
        });
}

/**
* Function AddSuggestion Save New Suggestion
* @function
*/
Gs.Functions.AddSuggestionSave = async function () {
    let jsonData = {
        InheritedMonacoLanguageType: $("#menuInheritedMonacoLanguageType").val(),
        Label: $("#menuLabel").val(),
        Documentation: "",
        Kind: 1,
        InsertText: Gs.Variables.monacoEditorList.filter(obj => { return obj.elementId == "fastSuggestion" })[0].model.getValue(),
        MdContent: $('#FastHelpEditor')[0].contentWindow.mdEditor.getMarkdown(),
        UserId: Metro.storage.getItem("ApiToken", null) != null ? Metro.storage.getItem("ApiToken", null).Id : null
    }
    await Gs.Apis.RunServerPutApi("EasyITCenterSolutionMonacoLanguageList", jsonData, null);
    setTimeout(async function () {
        Gs.Variables.getSpProcedure[1].tableName = "SolutionMonacoSuggestionList";
        Gs.Variables.getSpProcedure[2].camelCase = true;
        await Gs.Apis.RunServerPostApi("DatabaseService/SpProcedure/GetGenericDataListByParams", Gs.Variables.getSpProcedure, "MonacoSuggestionList");
        Gs.Variables.getSpProcedure[2].camelCase = false;
    }, 5000);
    $("#AddSuggest").remove();
}

/**
* Function Save new Menu Help 
* @function
*/
Gs.Functions.SaveMenuHelp = async function () {
    let data = Metro.storage.getItem("SelectedMenu", null);
    data.MdContent = $('#HelpFastEditor')[0].contentWindow.mdEditor.getMarkdown();
    Metro.storage.setItem("SelectedMenu", data);

    let jsonData = {
        Id: data.MdContentId,
        RecGuid: data.RecGuid,
        Value: data.MdContent
    };

    $("#EditHelpMenu").remove();
    await Gs.Apis.RunServerPostApi("PortalApiTableService/SetMdMenuHelp", jsonData, null, "RefreshPortalMenuList");
}


/**
* Function Reset Blog to Default
* @function
*/
Gs.Functions.ResetBlog = function () {
    $("#EditBlogMenu").remove();
    EditBlogMenu();
}

/**
* Function Search Blog 
* @function
*/
Gs.Functions.SearchBlog = function () {
    let search = $("#menuSearch").val();
    $("#EditBlogMenu").remove();
    EditBlogMenu(search);
}

/**
* Function Save new Blog Message
* @function
*/
Gs.Functions.SaveBlog = async function () {
    let jsonData = {
        MenuName: $("#menuBlogName").val(),
        HtmlContent: $("#menuBlogContent").summernote('code')
    };
    if (jsonData.HtmlContent != "<p><br></p>") {
        await Gs.Apis.RunServerPostApi("PortalApiTableService/SetBlogList", jsonData, null);
        $("#EditBlogMenu").remove();
    }
}


/**
* Function Set Username as Public IP
* @function
*/
Gs.Functions.GetPublicIp = function () {
    $.get("https://ipinfo.io", function (response) {
        Gs.Variables.username = response.ip;
    }, "jsonp");
}


/**
* Function Share User Selected Enable/Disable Start Sharing
* @function
*/
Gs.Functions.ShareUserSelected = function () {
    let select = Metro.getPlugin("#userList", "select");
    if (select.val() == "") {
        Gs.Functions.AddClass("ShareButton", "disabled");
    } else {
        Gs.Functions.RemoveClass("ShareButton", "disabled");
    }
}



/**
* Function Html Escape encoded string to Normal
* @function
* @param {string} str string
* @return {string} return string
*/
Gs.Functions.HtmlEscape = function(str) {
    return str.toString()
        .replace(/&/g, '&amp;')
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;');
}


/**
* Function Save Updated Notes List
* @function
*/
Gs.Functions.SaveNotesList = async function () {
    let notes = Metro.storage.getItem('NotesList', null);

    let jsonData = {
        Notes: $('#NotesListEditor')[0].contentWindow.mdEditor.getMarkdown(),
        RecGuid: notes[0] != undefined ? notes[0].recGuid : null
    };

    $("#EditNotesList").remove();
    await Gs.Apis.RunServerPostApi("PortalApiTableService/SetNotesList", jsonData, null, "LoadNotesList");
}


