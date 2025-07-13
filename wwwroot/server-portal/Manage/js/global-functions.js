
function htmlDecode(input) {
    var doc = new DOMParser().parseFromString(input, "text/html");
    return doc.documentElement.textContent;
}

async function FileReaderToImageData(n) {
    const t = new FileReader; return await new Promise((t, i) => {
        const r = new FileReader; r.onloadend = () => t(r.result); r.onerror = i;
        console.log("files", JSON.parse(JSON.stringify(files)));
        r.readAsDataURL(n[0])
    })
}

function str2bytes(str) {
    var bytes = new Uint8Array(str.length);
    for (var i = 0; i < str.length; i++) {
        bytes[i] = str.charCodeAt(i);
    }
    return bytes;
}

function PreloadImage(src) {
    var img = new Image();
    img.src = src;
}

function BindYouTubePlay(img) {
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


function BindYouTubeImages() {
    preloadImage('/images/youtube-play-hover.png');
    $("a[href^='https://youtu.be/']>img").each(function () {
        if (this.complete) {
            bindYouTubePlay($(this));
        } else {
            this.onload = function () { bindYouTubePlay($(this)); }
        }
    });
}

function Video(url) {
    return '<iframe style="width:100%;min-height:585px" src="' + url + '" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>';
}


function PlayVideo(el, id) {
    var url = 'https://www.youtube.com/embed/' + id + '?autoplay=1';
    $(el).parent().html(video(url));
}


// Generate Tables
function PrintTables(tables) {
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
function PrintMarkdown(text) {
    return `<pre>${text}</pre>`;
}


// Generate TagList
function GenerateTagList(values, tagName, className) {
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


function showSource() {
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


function ShowFrameSource() {
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


function ScrollToTop() { window.scrollTo(0, 0); }
function enableScroll() { window.onscroll = function () { }; }
function disableScroll() {
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
        window.onscroll = function () { window.scrollTo(scrollLeft, scrollTop); };
}

function PrintElement(elementId) {
    try { $("#" + elementId).printElement({ pageTitle: elementId.split("_")[1] + ".html", printMode: "popup" }); } catch (t) { }
}

function DownloadHtmlElement(elementId) {
    try { var t = document.body.appendChild(document.createElement("a")); t.download = elementId + ".html"; t.href = "data:text/html;charset=utf-8," + encodeURIComponent(document.getElementById(elementId).innerHTML); t.click(); } catch (i) { }
}

async function CopyElement(elementId) {
    try { let t = document.getElementById(elementId).innerHTML; await navigator.clipboard.writeText(t); } catch (t) { }
}

function ImageFromElement(elementId) {
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

function PrintFrameElement() {
    try {
        window.frames['FrameWindow'].contentWindow.printElement({ pageTitle: "KlikneteZdeCz.html", printMode: "popup" });
    } catch (t) { }
}


function DownloadFrameHtmlElement() {
    try {
        var t = document.body.appendChild(document.createElement("a")); t.download = "KlikneteZde" + ".html"; t.href = "data:text/html;charset=utf-8," + encodeURIComponent(window.frames['FrameWindow'].contentWindow.document.body.innerHTML); t.click();
    } catch (i) { }
}

async function CopyFrameElement() {
    try {
        let t = window.frames['FrameWindow'].contentWindow.document.body.innerHTML; await navigator.clipboard.writeText(t);
    } catch (t) { }
}


function ImageFromFrameElement() {
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


function SaveToFavorites(title, url) {
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

async function LoadMetro() {
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


function UnloadMetro() {
    delete Metro;
}

function loadPage(url) {
    $.ajax({
        url: url
    }).done(function (data) {
        $('#frameWindow').html(data);
    });
}