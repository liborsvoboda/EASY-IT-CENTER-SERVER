

/**
* Function SetInterval 30 sec for WebSocketRefresh
* @function
*/
Gs.Socket.PingInterval = setInterval(() => {
    Gs.Socket.SendChatMessageWS(1000, JSON.stringify({}));
}, 30000);


/**
* Function SendChat Message Web Socket
* @function
* @param {string} interval interval in milisecond
* @param {string} message webSocket message
*/
Gs.Socket.SendChatMessageWS = function (interval, message = null) {
    if (Gs.Variables.Socket.chatSocket.readyState === 1) {

        if (message != null) {
            //SEND MESSAGE
            Gs.Variables.Socket.chatSocket.send(JSON.stringify(message));
            Gs.Variables.Socket.chatSocket.close();
        }
        Gs.Variables.Socket.chatSocket = new WebSocket(`${Metro.storage.getItem('ApiOriginSuffix', null).replace("http:", "ws:").replace("https:", "wss:")}WebSocketService/chat`)
        Gs.Socket.SetReceivingChat();
    
        
    } else {
        setTimeout(function () {
            Gs.Socket.SendChatMessageWS(interval, message);
        }, interval);
    }
};


/**
* Function Set Receiving Chat Message to Chat
* @function
*/
Gs.Socket.SetReceivingChat = function () {

    //RECEIVE MESSAGE
    Gs.Variables.Socket.chatSocket.addEventListener("message", (event) => {
        event.data = event.data.replaceAll("\u0000", "");
        let message = Gs.Functions.WhatIsIt(event.data) == "String" && event.data.length > 0 ? JSON.parse(event.data) : {};

        //ONLY OTHER MESSAGES
        if (Gs.Functions.WhatIsIt(event.data) == "String" && message.id != undefined && message.id != Gs.Variables.chatmessage.id) {

            message.position = "left";
            message.avatar = message.name == "Anonymous" ? "/server-portal/images/anonymous.jpg" : message.avatar;

            let chatMessageList = Metro.storage.getItem("ChatMessageList", null);
            if (chatMessageList.filter(obj => { return obj.id == message.id }).length == 0) {
                chatMessageList.push(message);
            }
            Metro.storage.setItem("ChatMessageList", chatMessageList);

            let chatWindow = Metro.getPlugin("#ChatWindow", "chat");
            if (chatWindow != undefined) {
                chatWindow.add(message);
                $("#ChatMessageCount").html("0");
            } else { $("#ChatMessageCount").html((parseInt($("#ChatMessageCount").html()) + 1).toString()); }
        }
    });

}


/**
* Function SendChat Message 
* @function
* @param {string} message message
*/
Gs.Socket.SendChatMessage = function (message) {
    let chatMessageList = Metro.storage.getItem("ChatMessageList", null);
    Gs.Variables.chatmessage = message;
    chatMessageList.push(message);
    Metro.storage.setItem("ChatMessageList", chatMessageList);
    Gs.Socket.SendChatMessageWS(1000, message);
}



