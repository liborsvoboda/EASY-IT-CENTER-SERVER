// METRO ENGINE Easy Interactive Solution For SYSTEMS, WEBS, PORTALS, ETC....
// https://docs.metroui.org.ua/intro.html

// CZECH DISTRIBUTION GroupWare-Solution.Eu && KlikneteZde.CZ
// STORAGE LOAD FIRST

let apiMessages = [{
     apiSaveSuccess: "Saving Data was Saved Sucessfully" ,
     apiSaveFail: "Saving Data was Failed" ,
     apiLoadSuccess: "Saving Data was Saved Sucessfully" ,
     apiLoadFail: "Saving Data was Failed" 
}];

let defaultSetting = [{
     notifyWidth: 300 ,
     notifyDuration: 1000 ,
     notifyAnimation: "easeOutBounce" 
}];


//Global Notify Setting
let notify = Metro.notify; notify.setup({
    width: defaultSetting[0].notifyWidth,
    duration: defaultSetting[0].notifyDuration,
    animation: defaultSetting[0].notifyAnimation
});

let getSpProcedure = {
    "SpProcedure": "SpGetTableDataList",
    "tableName": null,
    "userRole": "all",
    "userId": null
}

let setSpProcedure = {
    "SpProcedure": "SpSetTableDataRec",
    "tableName": null,
    "userRole": "all",
    "userId": null,
    "dataRec": null
}


//Set Default Storage Values
Metro.storage.setItem('BackendServerAddress', window.location.origin);
Metro.storage.setItem('DetectedLanguage', (navigator.language || navigator.userLanguage).substring(0, 2));
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', false); }
if (Metro.storage.getItem('WebScheme', null) == null) {
    Metro.storage.setItem('WebScheme', "sky-net.css");
    ChangeSchemeTo(Metro.storage.getItem('WebScheme', null));
} else { ChangeSchemeTo(Metro.storage.getItem('WebScheme', null)); }


/*Start Set Global Constants*/
Metro.storage.setItem('ApiOriginSuffix', Metro.storage.getItem('BackendServerAddress', null) + "/");
Metro.storage.setItem('DefaultPath', Metro.storage.getItem('DefaultPath', null) == null ? window.location.href : Metro.storage.getItem('DefaultPath', null));


//Start Set User Default Setting
if (Metro.storage.getItem('UserAutomaticTranslate', null) == null) { Metro.storage.setItem('UserAutomaticTranslate', false); }









