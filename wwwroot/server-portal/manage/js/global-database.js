/**
* Create or Open Database
* 
* 
*/
//Gs.Variables.database = indexedDB.open("EICserverPortal", 4);

Gs.Variables.database.onupgradeneeded = (event) => {
    Gs.Variables.dbData = event.target.result;
    Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore("PortalMenuList", { keyPath: "Id", });
    Gs.Variables.ixDbInit = true;
}

Gs.Variables.database.onsuccess = (event) => {
    Gs.Variables.dbData = event.target.result;
    Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore("PortalMenuList", { keyPath: "Id", });
    Gs.Variables.ixDbInit = true;
}


/**
* Save Data to Indexed Database
* 
* 
*/
Gs.Database.SaveData = async function (storageName, jsonData, clearTable = true) {
    let upgrade = false; 
    // Create the schema
    Gs.Variables.database.onupgradeneeded = (event) => {
        upgrade = true;
        Gs.Variables.dbData = event.target.result;

        //Create Table
        if (!Gs.Variables.database.contains(storageName)) {

            //if (jsonData.find(e => e.Name === 'Id')) {
            Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore(storageName, { keyPath: 'Id', autoIncrement: true });
            //} else { Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore(storageName, { autoIncrement: true }); }
            //Gs.Variables.dbIndex = store.createIndex("NameIndex", ["name.last", "name.first"]);
        }

        if (clearTable) { 
            //ClearTable
            Gs.Variables.dbTransaction = open.result.transaction(storageName, "readwrite");
            Gs.Variables.dbStore = tx.objectStore(storageName);
            let res = Gs.Variables.dbStore.clear();

            request.onsuccess = () => { }
            request.onerror = (err) => { console.error("Error clearing table:", err); }
        }
    }


    if (!upgrade) {
        //if (jsonData.find(e => e.Name === 'Id')) {
        Gs.Variables.dbData = Gs.Variables.database.result.transaction(["test"], "readwrite");
        Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore(storageName, { keyPath: 'Id', autoIncrement: true });
        //} else { Gs.Variables.dbStore = Gs.Variables.dbData.createObjectStore(storageName, { autoIncrement: true }); }
    } else {


        // Start a new transaction
        let db = open.result;
        Gs.Variables.dbTransaction = open.result.transaction(storageName, "readwrite");
        Gs.Variables.dbStore = Gs.Variables.dbTransaction.objectStore(storageName);
        Gs.Variables.dbIndex = store.index("Id");

        Gs.Variables.dbStore.put(jsonData);

        Gs.Variables.dbTransaction.oncomplete = function () {
            Gs.Variables.dbData.close();
        };

        Gs.Variables.dbTransaction.onerror = (event) => {
            console.error("IndexedDB Transaction", event);
        };
    }

    // Query the data
    //let getJohn = store.get(12345);
    //let getBob = index.get(["Smith", "Bob"]);

    //getJohn.onsuccess = function () {
    //    console.log(getJohn.result.name.first);  // => "John"
    //};


    // Close the db when the transaction is done
   
    
}


/**
* Load Data to Indexed Database
* 
* 
*/
Gs.Database.LoadData = function (storageName) {
    Gs.Variables.dbTransaction = open.result.transaction(storageName, IDBTransaction.READ_ONLY);
    Gs.Variables.dbStore = Gs.Variables.dbTransaction.objectStore(storageName);
    let dbData = store.getAll();

    dbData.onsuccess = function () {
        return dbData.result;
    }
}



/**
* Load Data from IndexedDB By Id Key
* 
* 
*/
Gs.Database.LoadById = function (storageName, id) {
    Gs.Variables.dbTransaction = open.result.transaction(storageName, IDBTransaction.READ_ONLY);
    Gs.Variables.dbStore = Gs.Variables.dbTransaction.objectStore(storageName);
    let dbData = store.getAll();

    dbData.onsuccess = function () {
        return dbData.result;
    }
}


/**
* Delete Data from IndexedDB by StorageName
* 
* 
*/
Gs.Database.Delete = function (storageName) {
    Gs.Variables.dbTransaction = open.result.transaction(storageName, IDBTransaction.READ_ONLY);
    Gs.Variables.dbStore = Gs.Variables.dbTransaction.objectStore(storageName);
    let dbData = db.deleteObjectStore(storageName);

    dbData.onsuccess = function () {
        return dbData.result;
    }
}