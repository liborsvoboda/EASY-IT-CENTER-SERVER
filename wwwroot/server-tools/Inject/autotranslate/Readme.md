# Injection Autotranslate to WebPages

- Injected Jquery + Metro4 + Google Translator + Mermaid
- Injected Mermaid
- Generated Control Panel for Enable/Disable Autotranslate
- Its Injection Phylosophy, Each new Extension can be Injected
- to Razor Templates and this is EASY installation of NEWS


**Its Easy Extension**   

````
<script>
    let pageLoader = null;

    localStorage.setItem('DetectedLanguage', (navigator.language || navigator.userLanguage).substring(0, 2));
    async function Mermaid() { 
        try { 
            await mermaid.run({ nodes: document.querySelectorAll('.class-mermaid'), }); } 
        catch (err) { }
        try { 
            await mermaid.run({ nodes: document.querySelectorAll('.mermaid'), }); } 
        catch (err) { }
    }
    ShowPageLoading();

    var pres = document.querySelectorAll("pre>code"); pres = document.querySelectorAll("code");
    for (var i = 0; i < pres.length; i++) { hljs.highlightBlock(pres[i]); }
    window.highlightJsBadge();
    $(document).ready(function () {
        $("#docLoader").hide();
        setTimeout(() => { 
            googleTranslateElementInit(); 
            Mermaid();
            HidePageLoading();
        }, 3000);
    });

    function injectFile(type,src) {
        return new Promise(function (resolve, reject) {
            let link = document.createElement(type);
		    if (type == "link"){link.href = src;link.rel = 'stylesheet';} 
		    else if(type == "script") {link.src = src;link.type="text/javascript";} 
            link.onload = () => resolve(link);
            link.onerror = () => reject(new Error(`Style load error for ${src}`));
            document.head.append(link);
        });
    }


    let injectToolPanel = document.createElement("div"); 
    injectToolPanel.innerHTML ='<div id="google_translate_element" style="position: fixed;bottom: 0px;left: 40%;"></div>';
    document.body.append(injectToolPanel);
    injectFile("script","https://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit");


    function GoogleTranslateElementInit() {
        $(document).ready(function () {
            new google.translate.TranslateElement({
                pageLanguage: '', //includedLanguages: 'en,cs',
                layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL,
                autoDisplay: false
            }, 'google_translate_element');

            if (document.querySelector('#google_translate_element select') != null) {
                setTimeout(function () {
                    let selectElement = document.querySelector('#google_translate_element select');
                    selectElement.value = localStorage.getItem('DetectedLanguage');
                    selectElement.dispatchEvent(new Event('change'));
                }, 1000);
            }
        });
    }


    function CancelTranslation() {
        setTimeout(function () {
            let selectElement = document.querySelector('#google_translate_element select');
            selectElement.selectedIndex = 1;
            selectElement.dispatchEvent(new Event('change'));
            if (selectElement.value != '') {
                setTimeout(function () {
                    let selectElement = document.querySelector('#google_translate_element select');
                    selectElement.selectedIndex = 0;
                    selectElement.dispatchEvent(new Event('change'));
                    if (selectElement.value != '') {
                        setTimeout(function () {
                            let selectElement = document.querySelector('#google_translate_element select');
                            selectElement.selectedIndex = 0;
                            selectElement.dispatchEvent(new Event('change'));
                        }, 2000);
                    }
                }, 2000);
            }
        }, 1000);
    }


    function HidePageLoading() { Metro.activity.close(pageLoader); }
    function ShowPageLoading() {
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
````