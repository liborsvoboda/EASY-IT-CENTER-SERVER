// METRO ENGINE Easy Interactive Solution For SYSTEMS, WEBS, PORTALS, ETC....
// https://docs.metroui.org.ua/intro.html

//Global Javascript Library
let Gs = {
    Behaviors: {},
    Objects: {},
    Functions: {},
    Apis: {},
    Variables: {
        monacoEditorList :[],
        apiMessages :[{
            apiSaveSuccess: "Saving Data was Saved Sucessfully",
            apiSaveFail: "Saving Data was Failed",
            apiLoadSuccess: "Saving Data was Saved Sucessfully",
            apiLoadFail: "Saving Data was Failed"
        }],
        defaultSetting :[{
            notifyWidth: 300,
            notifyDuration: 1000,
            notifyAnimation: "easeOutBounce"
        }],
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
        ]
    }
}



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
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', false); }
if (Metro.storage.getItem('WebScheme', null) == null) {
    Metro.storage.setItem('WebScheme', "sky-net.css");
    Gs.Behaviors.ChangeSchemeTo(Metro.storage.getItem('WebScheme', null));
} else { Gs.Behaviors.ChangeSchemeTo(Metro.storage.getItem('WebScheme', null)); }


/*Start Set Global Constants*/
Metro.storage.setItem('ApiOriginSuffix', Metro.storage.getItem('BackendServerAddress', null) + "/");
Metro.storage.setItem('DefaultPath', Metro.storage.getItem('DefaultPath', null) == null ? window.location.href : Metro.storage.getItem('DefaultPath', null));


//Start Set User Default Setting
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', false); }









