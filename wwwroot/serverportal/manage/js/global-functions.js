
Gs.Functions.GenerateUUID = function () { 
    var d = new Date().getTime();
    var d2 = ((typeof performance !== 'undefined') && performance.now && (performance.now() * 1000)) || 0;
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16;
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

Gs.Functions.RemoveElement = function (elementId) {
    let element = document.getElementById(elementId);
    if (element != null) { element.remove(); }
}


Gs.Functions.AddClass = function (elementId,clasName) {
    $("#deleteButton").addClass(clasName); //"disabled"
}

Gs.Functions.RemoveClass = function (elementId, clasName) {
    $("#deleteButton").removeClass(clasName); //"disabled"
}

Gs.Functions.HtmlDecode = function (input) {
    var doc = new DOMParser().parseFromString(input, "text/html");
    return doc.documentElement.textContent;
}

Gs.Functions.FileReaderToImageData = async function (n) {
    const t = new FileReader; return await new Promise((t, i) => {
        const r = new FileReader; r.onloadend = () => t(r.result); r.onerror = i;
        console.log("files", JSON.parse(JSON.stringify(files)));
        r.readAsDataURL(n[0])
    })
}

Gs.Functions.Str2bytes = function (str) {
    var bytes = new Uint8Array(str.length);
    for (var i = 0; i < str.length; i++) {
        bytes[i] = str.charCodeAt(i);
    }
    return bytes;
}

Gs.Functions.PreloadImage = function (src) {
    var img = new Image();
    img.src = src;
}

Gs.Functions.BindYouTubePlay = function (img) {
    var a = img.parent();
    var p = a.parent();
    if (p[0] && p[0].tagName === 'P') {
        var id = splitOnFirst(splitOnLast(a.attr('href'), '/')[1], '?')[0];
        var width = Math.floor(img[0].offsetWidth / 2 - 43);
        var height = Math.floor(img[0].offsetHeight / 2 - 31);
        var html = `<i class="youtube-play" style="width:${img[0].offsetWidth}px;height:${img[0].offsetHeight}px;background-position:${width}px ${height}px" onclick="playVideo(this,'${id}')"></i>`;
        p.prepend(html);
    }
}


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

Gs.Functions.Video = function (url) {
    return '<iframe style="width:100%;min-height:585px" src="' + url + '" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>';
}


Gs.Functions.PlayVideo = function (el, id) {
    var url = 'https://www.youtube.com/embed/' + id + '?autoplay=1';
    $(el).parent().html(video(url));
}


// Generate Tables
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


// Code to MarkDown 
Gs.Functions.PrintMarkdown = function (text) {
    return `<pre>${text}</pre>`;
}


// Generate TagList
Gs.Functions.GenerateTagList = function (values, tagName, className) {
    if (values.length === 0) {
        return "";
    }
    const open = "<" + tagName + " class='" + className + "' >";
    const close = "</" + tagName + ">";
    return open + values.join(close + open) + close;
}



//Function for  Mermaid Data to Graphics Conversion
//async function Mermaid() { try { await mermaid.run({ nodes: document.querySelectorAll('.class-mermaid'), }); } catch (err) { } }

//Function for Highlighting Code Segments
//function HighlightCode() { document.querySelectorAll('div.code').forEach(el => { hljs.highlightElement(el); }); }


Gs.Functions.ShowSource = function () {
    var source = "<html>";
    source += document.getElementsByTagName('html')[0].innerHTML;
    source += "</html>";
    source = source.replace(/</g, "&lt;").replace(/>/g, "&gt;");
    source = "<pre>" + source + "</pre>";
    sourceWindow = window.open('', 'Source of page', 'height=800,width=800,scrollbars=1,resizable=1');
    sourceWindow.document.write(source);
    sourceWindow.document.close();
    if (window.focus) sourceWindow.focus();
}


Gs.Functions.ShowFrameSource = function () {
    var source = "<html>";
    source += window.frames['FrameWindow'].contentWindow.document.body.innerHTML;
    source += "</html>";
    source = source.replace(/</g, "&lt;").replace(/>/g, "&gt;");
    source = "<pre>" + source + "</pre>";
    sourceWindow = window.open('', 'Interaktnivní Kód', 'height=800,width=800,scrollbars=1,resizable=1');
    sourceWindow.document.write(source);
    sourceWindow.document.close();
    if (window.focus) sourceWindow.focus();
}


Gs.Functions.PrintElement = function (elementId) {
    try { $("#" + elementId).printElement({ pageTitle: elementId.split("_")[1] + ".html", printMode: "popup" }); } catch (t) { }
}

Gs.Functions.DownloadHtmlElement = function (elementId) {
    try { var t = document.body.appendChild(document.createElement("a")); t.download = elementId + ".html"; t.href = "data:text/html;charset=utf-8," + encodeURIComponent(document.getElementById(elementId).innerHTML); t.click(); } catch (i) { }
}

Gs.Functions.CopyElement = async function (elementId) {
    try { let t = document.getElementById(elementId).innerHTML; await navigator.clipboard.writeText(t); } catch (t) { }
}

Gs.Functions.ImageFromElement = function (elementId) {
    try {
        $("document").ready(function () {
            html2canvas($("#" + elementId), {
                onrendered: function (t) {
                    $("#previewImage").append(t);
                    var r = t.toDataURL("image/png"), u = r.replace(/^data:image\/png/, "data:application/octet-stream"), i = document.body.appendChild(document.createElement("a")); i.download = elementId + ".png"; i.href = u; i.click()
                }
            })
        })
    } catch (t) { }
}

Gs.Functions.PrintFrameElement = function () {
    try {
        window.frames['FrameWindow'].contentWindow.printElement({ pageTitle: "KlikneteZdeCz.html", printMode: "popup" });
    } catch (t) { }
}


Gs.Functions.DownloadFrameHtmlElement = function () {
    try {
        var t = document.body.appendChild(document.createElement("a")); t.download = "KlikneteZde" + ".html"; t.href = "data:text/html;charset=utf-8," + encodeURIComponent(window.frames['FrameWindow'].contentWindow.document.body.innerHTML); t.click();
    } catch (i) { }
}

Gs.Functions.CopyFrameElement = async function () {
    try {
        let t = window.frames['FrameWindow'].contentWindow.document.body.innerHTML; await navigator.clipboard.writeText(t);
    } catch (t) { }
}


Gs.Functions.ImageFromFrameElement = function () {
    try {
        $("document").ready(function () {
            html2canvas(window.frames['FrameWindow'].contentWindow.document.body, {
                onrendered: function (t) {
                    $("#previewImage").append(t);
                    var r = t.toDataURL("image/png"), u = r.replace(/^data:image\/png/, "data:application/octet-stream"), i = document.body.appendChild(document.createElement("a")); i.download = "KlikneteZdeCz.png"; i.href = u; i.click();
                }
            });
        });
    } catch (t) { }
}


Gs.Functions.SaveToFavorites = function (title, url) {
    if (window.sidebar) {
        // Firefox
        window.sidebar.addPanel(title, url, '');
    }
    else if (window.opera && window.print) {
        // Opera
        var elem = document.createElement('a');
        elem.setAttribute('href', url);
        elem.setAttribute('title', title);
        elem.setAttribute('rel', 'sidebar');
        elem.click(); //this.title=document.title;
    }
    else if (document.all) {
        // ie
        window.external.AddFavorite(url, title);
    }
}

Gs.Functions.LoadMetro = async function () {
    const pathCss = './metro/css/metro-all.min.css';
    const pathThemeCss = './metro/css/schemes/sky-net.css';
    const pathJs = './metro/js/metro.4.5.2.min.js?v=4.5.2';

    const dataCss = await fetch(pathCss).then((r) => r.text());
    const dataThemeCss = await fetch(pathThemeCss).then((r) => r.text());

    const myFont = new FontFace('metro', "url('./metro/mif/metro.svg') format('svg'), url('./metro/mif/metro.woff') format('woff'), url('./metro/mif/metro.ttf') format('truetype')");
    await myFont.load(); document.fonts.add(myFont);

    const dataJs = await fetch(pathJs).then((r) => r.text())

    const style = document.createElement("style")
    style.textContent = dataCss
    document.querySelector("head").appendChild(style)

    style.textContent = dataThemeCss
    document.querySelector("head").appendChild(style)

    new Function(dataJs)();
    Metro.init();
    Metro.toast.create("Metro 4 did loaded successful!", { showTop: true, clsToast: "success" });
    //$("#a1").accordion()
}


Gs.Functions.UnloadMetro = function () {
    delete Metro;
}

Gs.Functions.LoadPage = function (elementId,url) {
    $.ajax({
        url: url
    }).done(function (data) {
        $('#' + elementId).html(data);
    });
}