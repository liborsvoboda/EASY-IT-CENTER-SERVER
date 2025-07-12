
//Global Notify Setting
var notify = Metro.notify; notify.setup({
    width: defaultSetting[0].notifyWidth,
    duration: defaultSetting[0].notifyDuration,
    animation: defaultSetting[0].notifyAnimation
});


//Global Tool Panel
function CreateToolPanel() {
    let html = '<div id="ToolPanel" data-role="bottom-sheet" class="bottom-sheet pos-fixed list-list grid-style opened" style="top: 0px; left: 90%; z-index:10000;min-width: 430px;">';
    html += '<div class="c-pointer mif-cancel mif-1x icon pos-absolute fg-red" style="top:5px;right:5px;" onclick=ShowToolPanel(); ></div>';
    html += '<div class="w-100 text-left"> <audio id="radio" class="light bg-transparent" data-role="audio-player" data-src="/server-integrated/razor-pages/serverportal/media/hotel_california.mp3" data-volume=".5"></audio> </div>';
    html += '<div class="w-100 text-left" style="z-index: 1000000;"><div id="google_translate_element"></div></div>';
    html += '<div class="w-100 d-inline-flex"><div class="w-75 text-left">';
    html += '<input id="UserAutomaticTranslate" type="checkbox" data-role="checkbox" data-cls-caption="fg-cyan text-bold" data-caption="Auto Translate" onchange=UserChangeTranslateSetting(); checked >';
    html += '</div><div class="w-25 mt-1 text-right" style="max-width:25% !important;"><button class="button secondary mini" style="max-width:100% !important;" onclick=CancelTranslation(); >Cancel Translate</button></div>';
    html += '</div><div class="d-flex w-100" title="Theme">';
    let themes = [
        ["#585b5d", "darcula.css?white"], ["#AF0015", "red-alert.css?white"], ["#690012", "red-dark.css?white"], ["#0CA9F2", "sky-net.css?white"],
        ["#585b5d", "darcula.css?#585b5d"], ["#AF0015", "red-alert.css?#AF0015"], ["#690012", "red-dark.css?#690012"], ["#0CA9F2", "sky-net.css?#0CA9F2"]
    ];
    themes.forEach((theme, index) => {
        html += '<button class="button shadowed w-50px ' + (index < 4 ? "opc-05" : "") + ' mt-1" style="background-color: ' + theme[0] + ';" onclick="ChangeSchemeTo(\'' + theme[1] + '\')" ></button>';
        if (index == 3) { html += '</div><div class="d-flex w-100" title="BackGround">'; }
    });

    let injectToolPanel = document.createElement("div");
    injectToolPanel.innerHTML = html;
    document.body.append(injectToolPanel);
};


//Blocked IP Info Panel
function ShowBlockedMessage() {
    var html_content =
        "<h3>Blokovaná IP Adresa</h3>" +
        "<p>Vaše adrese je blokována, protože byla zjištěna podezřelá činnost...</p>" +
        "<p>Pro Odblokování nás kontaktujte Telefonicky.</p>";
    Metro.infobox.create(html_content, "alert");
}

//Unauthorized Access Info Panel
function ShowUnAuthMessage() {
    Logout();
    var html_content =
        "<h3>Neautorizovaný Přístup</h3>" +
        "<p>Pokoušíte se provést autorizovanou operaci neoprávněně,</p>" +
        "<p>nebo platnost vašeho tokenu vypršela.</p>";
    Metro.infobox.create(html_content, "alert");
}




function generateMenu() {
    let htmlContent = '<li class="item-header">Portal MENU</li>';

    let lastGuid = null, menuItem = {};
    let menu = JSON.parse(JSON.stringify(Metro.storage.getItem('PortalMenu', null)))
    menu.forEach((mItem,index,arr) => {
       
        console.log(index, arr.length);
    
        switch (mItem.apiTableColumnName) {
            case "ParentGuid":
                menuItem.ParentGuid = mItem.value;
                break;
            case "Sequence":
                menuItem.Sequence = parseInt(mItem.value);
                break;
            case "Name":
                menuItem.Name = mItem.value;
                break;
            case "Timestamp":
                menuItem.Timestamp = new Date(mItem.value);
                break;
            case "Icon":
                menuItem.Icon = mItem.value;
                break;
            case "Type":
                menuItem.Type = mItem.value;
                break;
            case "Content":
                menuItem.Content = mItem.value;
                break;
            default:
              
        }

        

        if (lastGuid != null && (lastGuid != mItem.recGuid || index + 1 == arr.length)) {
            if (menuItem.Type == "menu") {
                htmlContent += '<li ><a href="#" class="dropdown-toggle"><span class="icon"><span class="' + menuItem.Icon + '"></span></span><span class="caption">' + menuItem.Name + '</span></a>';
                htmlContent += '<ul id = ' + menuItem.Name + ' class="navview-menu stay-open" data-role="dropdown"><li class="item-header" > ' + menuItem.Name + '</li> ';
                htmlContent += '</li>';
            }
            else if (menuItem.Type == "link") { }
            else if (menuItem.Type == "content") { }
        }

        lastGuid = mItem.recGuid;
    });

    console.log(htmlContent);


    document.getElementById("PortalMenu").innerHTML = htmlContent + document.getElementById("PortalMenu").innerHTML;


}