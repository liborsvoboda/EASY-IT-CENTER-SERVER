// STARTUP Temp Variables Definitions
let pageLoader;


/*Start of Global Loading Indicator for All Pages*/
function hidePageLoading() { Metro.activity.close(pageLoader); }
function showPageLoading() {
    if (pageLoader != undefined) {
        if (pageLoader[0]["DATASET:UID:M4Q"] == undefined) { pageLoader = null; }
        else {
            try { Metro.activity.close(pageLoader); } catch {
                try { pageLoader.close(); } catch { pageLoader = pageLoader[0]["DATASET:UID:M4Q"].dialog; pageLoader.close(); }; pageLoader = null;
            }
        }
    }
    pageLoader = Metro.activity.open({ type: 'atom', style: 'dark', overlayClickClose: true, /*overlayColor: '#fff', overlayAlpha: 1*/ });
}

function UserChangeTranslateSetting() {
    Metro.storage.setItem('UserAutomaticTranslate', $("#UserAutomaticTranslate").val('checked')[0].checked);
    if ($("#UserAutomaticTranslate").val('checked')[0].checked) { GoogleTranslateElementInit(); } else { CancelTranslation(); }
}


function ChangeSchemeTo(n) {
    $("#AppPanel").css({ backgroundColor: n.split("?")[1] });
    $("#portal-color-scheme").attr("href", window.location.origin + "/server-integrated/razor-pages/serverportal/metro/css/schemes/" + n.split("?")[0]);
    $("#scheme-name").html(n.split("?")[0]);
    Metro.storage.setItem('WebScheme', n.split("?")[0]);
}


function ShowToolPanel(close) {
    $("#UserAutomaticTranslate").val('checked')[0].checked = Metro.storage.getItem('UserAutomaticTranslate', null);
    if (close) { Metro.bottomsheet.close($('#toolPanel')); } else {
        if (Metro.bottomsheet.isOpen($('#toolPanel'))) { Metro.bottomsheet.close($('#toolPanel')); }
        else { Metro.bottomsheet.open($('#toolPanel')); }
    }
}


function GetGoogleOptionLanguageIndex(optionValue) {
    let options = Array.from(document.getElementsByClassName("goog-te-combo")[0].options);
    return options.findIndex((opt) => opt.value == optionValue);
}

function GoogleTranslateElementInit() {
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'en', //includedLanguages: 'en,cs',
            layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
            autoDisplay: false
        }, 'google_translate_element');

        let autoTranslateSetting = Metro.storage.getItem('UserAutomaticTranslate', null) == null || Metro.storage.getItem('UserAutomaticTranslate', null) == false ? false : true;
        if (autoTranslateSetting && document.querySelector('#google_translate_element select') != null) {
            setTimeout(function () {
                let selectElement = document.querySelector('#google_translate_element select');
                selectElement.value = Metro.storage.getItem('DetectedLanguage', null);
                selectElement.dispatchEvent(new Event('change'));
            }, 1000);
        }
    });
}

function CancelTranslation() {
    Metro.storage.setItem('UserAutomaticTranslate', false);
    $("#UserAutomaticTranslate")[0].checked = false;

    setTimeout(function () {
        let selectElement = document.querySelector('#google_translate_element select');
        if (GetGoogleOptionLanguageIndex("") == 0) {
            selectElement.selectedIndex = 0; ShowToolPanel();
        } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
        selectElement.dispatchEvent(new Event('change'));
        if (selectElement.value != '') {
            setTimeout(function () {
                if (GetGoogleOptionLanguageIndex("") == 0) {
                    selectElement.selectedIndex = 0; ShowToolPanel();
                } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
                selectElement.dispatchEvent(new Event('change'));
                if (selectElement.value != '') {
                    setTimeout(function () {
                        if (GetGoogleOptionLanguageIndex("") == 0) {
                            selectElement.selectedIndex = 0; ShowToolPanel();
                        } else { selectElement.selectedIndex = GetGoogleOptionLanguageIndex("en"); }
                        selectElement.dispatchEvent(new Event('change'));
                    }, 2000);
                }
            }, 2000);
        }
    }, 1000);
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