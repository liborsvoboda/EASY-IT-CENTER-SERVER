


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
