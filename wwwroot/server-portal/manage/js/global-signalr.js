document.addEventListener("DOMContentLoaded", () => {
    Gs.Variables.SignalR.streamChat = new signalR.HubConnectionBuilder()
        .withUrl("/StreamChat")
        //.configureLogging(signalR.LogLevel.Information)
        .build();


    Gs.Variables.SignalR.streamChat.onclose(Gs.SignalR.Start());


    Gs.Variables.SignalR.streamChat.on("ReceiveStreamChat", (user, message) => {
        if (message.targetWindow = "ShareReceivePanel") {
            Gs.Objects.OpenShareReceive();
            setTimeout(function () { $("#StreamAdmin").html(user); }, 100);
        } else { Gs.Objects.OpenShareWindow(); }

        message = JSON.parse(message).message;
        message.position = "left";
        message.avatar = message.name == "127.0.0.1" ? "/server-portal/images/anonymous.jpg" : message.avatar;

        let chatMessageList = Metro.storage.getItem("ShareChatMessageList", null);
        if (chatMessageList.filter(obj => { return obj.id == message.id }).length == 0) {
            chatMessageList.push(message);
        }
        Metro.storage.setItem("ShareChatMessageList", chatMessageList);

        let chatWindow = Metro.getPlugin("#ShareChatWindow", "chat");
        if (chatWindow != undefined) {
            chatWindow.add(message);
            $("#ShareChatMessageCount").html("0");
        } else {
            $("#ShareChatMessageCount").html((parseInt($("#ShareChatMessageCount").html()) + 1).toString());
        }
        //console.log("Receive Stream", user, JSON.parse(message));
    });


    Gs.Variables.SignalR.streamChat.on("ReceiveStream", (user, message) => {
        Gs.Objects.OpenShareReceive();
        setTimeout(function () { $("#StreamAdmin").html(user); }, 100);

        document.getElementById("imagePreview").src = JSON.parse(message).image;
        //console.log("Receive Stream", user, JSON.parse(message));
    });


    Gs.Variables.SignalR.streamChat.on("ResponseUsers", (response) => {
        let select = Metro.getPlugin("#userList", "select");
        if (select != undefined) {
            let options = []; select.data(""); let users = JSON.parse(response);
            users.forEach(user => { if (Gs.Variables.username != user) { options.push({ val: user, title: user, selected: false }); } });
            select.addOptions(options);
            //console.log("Users", response);
        }
    });

    Gs.SignalR.Start();
    setTimeout(function () { Gs.SignalR.GetUsers(); }, 1000);
});


Gs.SignalR.Start = async function () {
    try {
        if (Gs.Variables.SignalR.streamChat.state == signalR.HubConnectionState.Disconnected) { await Gs.Variables.SignalR.streamChat.start(); }
    } catch (err) {
        console.log(err, Gs.Variables.SignalR.streamChat.state);
        if (Gs.Variables.SignalR.streamChat.state == signalR.HubConnectionState.Disconnected) { setTimeout(Gs.SignalR.Start, 1000); }
    }
}


Gs.SignalR.GetUsers =async function () {
    if (Gs.Variables.SignalR.streamChat.state == signalR.HubConnectionState.Disconnected) { await Gs.Variables.SignalR.streamChat.start(); }
    if (Gs.Variables.SignalR.streamChat.state === signalR.HubConnectionState.Connected) {
        Gs.Variables.SignalR.streamChat.invoke("RequestUsers").catch(function (err) {
            return console.error(err);
        });
    }
}


Gs.SignalR.StartVideoStream = async function (stopStreaming) {
    try {
        if (Gs.Variables.SignalR.streamChat.state === signalR.HubConnectionState.Disconnected) { await Gs.Variables.SignalR.streamChat.start(); }

        let select = Metro.getPlugin("#userList", "select");
        let image = Gs.Media.GetVideoFrame("videoPreview");
        let message = JSON.stringify({ image: image, message: "" });

      
        if (Gs.Variables.SignalR.streamChat.state === signalR.HubConnectionState.Connected) {
            Gs.Variables.SignalR.streamChat.invoke("SendMessageToUser", select.val(), message).catch(function (err) {
                return console.error(err);
            });
        }

        if (!stopStreaming) {
            setTimeout(function () {
                Gs.SignalR.StartVideoStream(Gs.Variables.SignalR.stopStreaming);
            },2000);
        }
    } catch (err) {
        console.log(err);
    }
}


Gs.SignalR.SendStreamChatMessage = async function (message) {
    if (Gs.Variables.SignalR.streamChat.state === signalR.HubConnectionState.Disconnected) { await Gs.Variables.SignalR.streamChat.start(); }

    let chatMessageList = Metro.storage.getItem("ShareChatMessageList", null);
    chatMessageList.push(message);
    Metro.storage.setItem("ShareChatMessageList", chatMessageList);

    let targetUser;
    if ($("#SharePanel").html() != undefined) {
        let select = Metro.getPlugin("#userList", "select");
        targetUser = select.val();
        message.TargetUser = targetUser;
        message.CallUser = Gs.Variables.username;
        message.targetWindow = "ShareReceivePanel";
    } else if ($("#ShareReceivePanel").html() != undefined) {
        targetUser = $("#StreamAdmin").html();
        message.TargetUser = targetUser;
        message.CallUser = Gs.Variables.username;
        message.targetWindow = "SharePanel";
    }


    message = JSON.stringify({ message: message });
    Gs.Variables.SignalR.streamChat.invoke("SendChatMessageToUser", targetUser, message).catch(function (err) {
        return console.error(err);
    });
}
