document.addEventListener("DOMContentLoaded", () => {
    Gs.Variables.SignalR.streamChat = new signalR.HubConnectionBuilder()
        .withUrl("/StreamChat")
        .withAutomaticReconnect([0,0,10000])
        .configureLogging(signalR.LogLevel.Information)
        .build();

    Gs.Variables.SignalR.streamChat.on("ReceiveMessage", (user, message) => {
        console.log("Receive Message", user, message);
    });


    Gs.Variables.SignalR.streamChat.on("ResponseUsers", (response) => {
        let select = Metro.getPlugin("#userList", "select"); let options = []; select.data(""); let users = JSON.parse(response);
        users.forEach(user => { options.push({ val: user, title: user, selected: false }); });
        select.addOptions(options);  

        //console.log("Users", response);
    });

    // Start the connection.
    Gs.SignalR.Start();
});


Gs.SignalR.Start = async function () {
    try {
        await Gs.Variables.SignalR.streamChat.start();
        //console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(Gs.SignalR.Start, 5000);
    }
}


Gs.SignalR.SendMessage = function (user, message) {
    Gs.Variables.SignalR.streamChat.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err);
    });
}


Gs.SignalR.GetUsers = function () {
    Gs.Variables.SignalR.streamChat.invoke("RequestUsers").catch(function (err) {
        return console.error(err);
    });
}


