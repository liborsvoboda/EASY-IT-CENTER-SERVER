
//Global Javascript Library
let Gs = {
    Behaviors: {},
    Objects: {},
    Functions: {},
    Apis: {},
    Variables: {
        monacoEditorList :[],
        notifySetting :{
            notifyWidth: 300,
            notifyDuration: 1000,
            notifyAnimation: "easeOutBounce"
        },
        getSpProcedure :[
            { SpProcedure: "SpGetTableDataList" },
            { tableName: null },
            { userRole: "all" },
            { userId: null }
        ],
        setSpProcedure :[
            { SpProcedure: "SpSetTableDataRec" },
            { tableName: null },
            { userRole: "all" },
            { userId: null },
            { dataRec: null }
        ],
        UserSettingList: {
            EnableAutoTranslate: false,
            EnableShowDescription: true,
            RememberLastJson: true,
            RememberLastHandleBar: true,
        },
    }
}
window.WindowButtons = [
    {
        html: "<span class='mif-file-code' title='Show Window Code'></span>",
        cls: "warning",
        onclick: "Gs.Behaviors.ShowWindowCode()"
    },
    {
        html: "<span class='mif-help' title='Show Menu Help'></span>",
        cls: "warning",
        onclick: "Gs.Objects.InfoboxFrameCreate('HelpViewer','/serverportal/addons/md-viewer/index.html');"
    },
    {
        html: "<span class='mif-import-contacts' title='Show Function List'></span>",
        cls: "warning",
        onclick: "Gs.Objects.InfoboxTableCreate('PreviewFunctionList');"
    },
    {
        html: "<span class='mif-import-export' title='Export'></span>",
        cls: "sys-button",
        onclick: "alert('You press user button')"
    },
    {
        html: "<span class='mif-chat' title='Start Chat'></span>",
        cls: "sys-button",
        onclick: "alert('You press user button')"
    },
    {
        html: "<span class='mif-language' title='Translate'></span>",
        cls: "sys-button",
        onclick: "alert('You press user button')"
    },
    {
        html: "<span class='mif-search' title='Search'></span>",
        cls: "sys-button",
        onclick: "alert('You press user button')"
    },
    {
        html: "<span class='mif-video-camera' title='Record Video'></span>",
        cls: "sys-button",
        onclick: "alert('You press user button')"
    }
]


// CZECH DISTRIBUTION GroupWare-Solution.Eu && KlikneteZde.CZ
// STORAGE LOAD FIRST


Gs.Behaviors.ChangeSchemeTo = function (n) {
    $("#AppPanel").css({ backgroundColor: n.split("?")[1] });
    $("#portal-color-scheme").attr("href", window.location.origin + "/server-integrated/razor-pages/serverportal/metro/css/schemes/" + n.split("?")[0]);
    $("#scheme-name").html(n.split("?")[0]);
    Metro.storage.setItem('WebScheme', n.split("?")[0]);
}



//Set Default Storage Values
Metro.storage.setItem('BackendServerAddress', window.location.origin);
Metro.storage.setItem('DetectedLanguage', (navigator.language || navigator.userLanguage).substring(0, 2));
if (Metro.storage.getItem('WebScheme', null) == null) {
    Metro.storage.setItem('WebScheme', "sky-net.css");
    Gs.Behaviors.ChangeSchemeTo(Metro.storage.getItem('WebScheme', null));
} else { Gs.Behaviors.ChangeSchemeTo(Metro.storage.getItem('WebScheme', null)); }


/*Start Set Global Constants*/
Metro.storage.setItem('ApiOriginSuffix', Metro.storage.getItem('BackendServerAddress', null) + "/");
Metro.storage.setItem('DefaultPath', Metro.storage.getItem('DefaultPath', null) == null ? window.location.href : Metro.storage.getItem('DefaultPath', null));


//Start Set User Default Setting
Metro.storage.setItem('UserSettingList', Gs.Variables.UserSettingList);









