

let GithubUrl="";


Metro.storage.setItem('BackendServerAddress', window.location.origin);
Metro.storage.setItem('DetectedLanguage', (navigator.language || navigator.userLanguage).substring(0, 2));
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', true); }
if (Metro.storage.getItem('WebScheme', null) == null) {
	Metro.storage.setItem('WebScheme', "sky-net.css");
	ChangeSchemeTo(Metro.storage.getItem('WebScheme', null));
} else { ChangeSchemeTo(Metro.storage.getItem('WebScheme', null)); }



/*Start Set Global Constants*/
Metro.storage.setItem('ApiOriginSuffix', Metro.storage.getItem('BackendServerAddress', null) + "/WebApi");
Metro.storage.setItem('DefaultPath', Metro.storage.getItem('DefaultPath', null) == null ? window.location.href : Metro.storage.getItem('DefaultPath', null));


//Start Set User Default Setting
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', false); }

function UserChangeTranslateSetting() {
    Metro.storage.setItem('UserAutomaticTranslate', $("#UserAutomaticTranslate").val('checked')[0].checked);
	if ($("#UserAutomaticTranslate").val('checked')[0].checked) { GoogleTranslateElementInit(); } else { CancelTranslation(); }
}

function ChangeSchemeTo(n) {
	$("#AppPanel").css({ backgroundColor: n.split("?")[1] });
	$("#portal-color-scheme").attr("href", window.location.origin + "/metro/css/schemes/" + n.split("?")[0]);
    $("#scheme-name").html(n.split("?")[0]);
    Metro.storage.setItem('WebScheme', n.split("?")[0]);
}

function ShowToolPanel(close) {
	$("#UserAutomaticTranslate").val('checked')[0].checked = Metro.storage.getItem('UserAutomaticTranslate', null);
	if (close) { { Metro.bottomsheet.close($('#toolPanel')); } } else {
		if (Metro.bottomsheet.isOpen($('#toolPanel'))) { Metro.bottomsheet.close($('#toolPanel')); }
		else { Metro.bottomsheet.open($('#toolPanel')); }
	}
}

function GoogleTranslateElementInit() {
    $(document).ready(function () {
        new google.translate.TranslateElement({
            pageLanguage: 'fr', //includedLanguages: 'en,cs',
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


//Translation Tool Panel TODO Set TOP
function CreateToolPanel() {
    let html = '<div id="toolPanel" data-role="bottom-sheet" class="bottom-sheet pos-fixed list-list grid-style opened" style="top: 0px; right: 0%; z-index:10000;min-width: 430px;">';
    html += '<div class="w-100 text-left"> <audio id="radio" class="light bg-transparent" data-role="audio-player" data-src="./media/hotel_california.mp3" data-volume=".5"></audio> </div>';
    html += '<div class="w-100 text-left" style="z-index: 1000000;"><div id="google_translate_element"></div></div>';
    html += '<div class="w-100 d-inline-flex"><div class="w-75 text-left">';
    html += '<input id="UserAutomaticTranslate" type="checkbox" data-role="checkbox" data-cls-caption="fg-cyan text-bold" data-caption="Auto Translate" onchange="UserChangeTranslateSetting">';
    html += '</div><div class="w-25 mt-1 text-right" style="max-width:25% !important;"><button class="button secondary mini" style="max-width:100% !important;" onclick="CancelTranslation()">Cancel Translate</button></div>';
    html += '</div>';
	return html;
}

let injectToolPanel = document.createElement("div"); 

$(document).ready(function () { 
	injectToolPanel.innerHTML = CreateToolPanel(); 
	document.body.append(injectToolPanel);
	//CreateToolPanel();
	setTimeout(()=>{ GoogleTranslateElementInit(); },3000);
});
