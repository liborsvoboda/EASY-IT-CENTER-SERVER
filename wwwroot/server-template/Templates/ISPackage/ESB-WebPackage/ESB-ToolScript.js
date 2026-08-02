

//INSERT JQUERY TO ANY WEB TOOL
//INSERT THIS FUNCTION FOR SAME USING WITH ANY TOOL WITH LOGIN I/O
//TEST EVERY TIME, CAN BE PROBLEM WITH WORK DATA IMMEDIATELY - SETTIMEOUT IS REQURED
//WRITE TO HEADER PART OFF TOOL



/*  Testing IO TOOL First - Example
 setTimeout(()=>{
    editor.html.set("test");
    editor.html.get();
 },1000);
*/

//TODO DOWNLOAD and CREATE LOCAL GALLERY with json GENERATOR 


//ESB Services Definitions
let ESBserver = "http://localhost:9000";
let ESBapiPaths = [
    { "systemLanguage": "/SystemApi/GetSystemLanguage" },
]



//GLOBAL METHODS FOR AUTOUSE BY WEBVIEW2
//Cyclic SetData Function to EDITOR
function SetData(inputValue) {
	 try {
		setTimeout(() => { editorInstance.setContents(inputValue); },1000);
    } catch (err) {
        SetData(inputValue);
		return false;
    }
    return true;
}

function GetData() {
    try {
        return editorInstance.getContents();
    } catch (err) {
		console.log("Get Data from Editor False");
        return `Get Data from Editor Exception: ${err}`;
    }
}



//Its Call Automatically with Openning Tool
//for non exist Config in Tool,
//Set Empty - non Error Method


//COMMAND FOR TOOL DIRECT CALL FOR LANGUAGE CODE
//GetDataFromESBhosting(ESBapiPaths["systemLanguage"]);


//CUSTOM METHOD for SETTING LANGUAGE CODE 
function SetLanguage() {
    try {
        let esbLang = GetDataFromESBhosting(ESBapiPaths.filter(obj => { return obj.systemLanguage)[0].systemLanguage});

        //HERE YOU write Command for set Languga in Tool;
    } catch (err) {
        //TODO write to DB LOG 
        return `SetLanguage Exception ${err} on: ${window.location.href}`;
    }
}




//Helpers Methods

async function GetDataFromESBhosting(apiPath) {
    try {
        let test = await fetch(window.location.origin + apiPath)
            .then(response => {
                if (!response.ok) { throw new Error('Network response was not ok'); }
                return response.json();
            }).then(data => { return data; });
    } catch (err) {
        //TODO write to DB LOG 
        return `SetLanguage Exception ${err} on: ${apiPath}`;
    }
}


function CalcFullPageHeight() {
    return window.innerHeight;
}