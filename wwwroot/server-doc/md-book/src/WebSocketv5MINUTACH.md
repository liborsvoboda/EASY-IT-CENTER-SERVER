﻿# Úvod   EIC+ESB Sdílené WEB Řešení VŠECH   

Jeden Vývoj Webové Aplikace, kterou vytvoříte LEHCE zkopírováním Příkladů z Tisíců 
Připravených Šablon a ukázek, a VÝSLEDKEM je SYSTÉM + WEB + PORTAL.  
K tomu Všemu máte připravené NÁSTROJE pro okamžitou kontrolu a testování,
LINKY na přímé nápovědy, Knihovny, Ukázek, kódů popisů a interaktivních aplikací
ž JIŽ NYNÍ je toho zbytečně moc. DOPORUČUJI UŽÍT JEN METRO a PÁR DOPLŇKŮ.
A to vše v ŘEŠENÍ kde je v plánu NÁPADY a ukázky SDÍLET, navzájem si POMÁHAT
To vše z dílny JEDINÉ OSOBY zapálené do IT jako NIKDO. 
Ukázka HTML implementace WebSocketu.
Server má Implementovaný Manager, Přibyde k Němu AGENDA
a bude PŘIPRAVENÝ K ČINNOSTEM O JAKÝCH SE VÁM ANI NESNILO


# HTML Soubor s plnou implementac9 WebSocket

```html

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
    <style>
        table {
            border: 0
        }

        .commslog-data {
            font-family: Consolas, Courier New, Courier, monospace;
        }

        .commslog-server {
            background-color: red;
            color: white
        }

        .commslog-client {
            background-color: green;
            color: white
        }
    </style>
</head>
<body>
    <h1>WebSocket Sample Application</h1>
    <p id="stateLabel">Ready to connect...</p>
    <div>
        <label for="connectionUrl">WebSocket Server URL:</label>
        <input id="connectionUrl" />
        <button id="connectButton" type="submit">Connect</button>
    </div>
    <p></p>
    <div>
        <label for="sendMessage">Message to send:</label>
        <input id="sendMessage" disabled />
        <button id="sendButton" type="submit" disabled>Send</button>
        <button id="closeButton" disabled>Close Socket</button>
    </div>

    <h2>Communication Log</h2>
    <table style="width: 800px">
        <thead>
            <tr>
                <td style="width: 100px">From</td>
                <td style="width: 100px">To</td>
                <td>Data</td>
            </tr>
        </thead>
        <tbody id="commsLog">
        </tbody>
    </table>

    <script>
        var connectionUrl = document.getElementById("connectionUrl");
        var connectButton = document.getElementById("connectButton");
        var stateLabel = document.getElementById("stateLabel");
        var sendMessage = document.getElementById("sendMessage");
        var sendButton = document.getElementById("sendButton");
        var commsLog = document.getElementById("commsLog");
        var closeButton = document.getElementById("closeButton");
        var socket;

        var scheme = document.location.protocol === "https:" ? "wss" : "ws";
        var port = document.location.port ? (":" + document.location.port) : "";

        connectionUrl.value = scheme + "://" + document.location.hostname + port + "/ws" ;

        function updateState() {
            function disable() {
                sendMessage.disabled = true;
                sendButton.disabled = true;
                closeButton.disabled = true;
            }
            function enable() {
                sendMessage.disabled = false;
                sendButton.disabled = false;
                closeButton.disabled = false;
            }

            connectionUrl.disabled = true;
            connectButton.disabled = true;

            if (!socket) {
                disable();
            } else {
                switch (socket.readyState) {
                    case WebSocket.CLOSED:
                        stateLabel.innerHTML = "Closed";
                        disable();
                        connectionUrl.disabled = false;
                        connectButton.disabled = false;
                        break;
                    case WebSocket.CLOSING:
                        stateLabel.innerHTML = "Closing...";
                        disable();
                        break;
                    case WebSocket.CONNECTING:
                        stateLabel.innerHTML = "Connecting...";
                        disable();
                        break;
                    case WebSocket.OPEN:
                        stateLabel.innerHTML = "Open";
                        enable();
                        break;
                    default:
                        stateLabel.innerHTML = "Unknown WebSocket State: " + htmlEscape(socket.readyState);
                        disable();
                        break;
                }
            }
        }

        closeButton.onclick = function () {
            if (!socket || socket.readyState !== WebSocket.OPEN) {
                alert("socket not connected");
            }
            socket.close(1000, "Closing from client");
        };

        sendButton.onclick = function () {
            if (!socket || socket.readyState !== WebSocket.OPEN) {
                alert("socket not connected");
            }
            var data = sendMessage.value;
            socket.send(data);
            commsLog.innerHTML += '<tr>' +
                '<td class="commslog-client">Client</td>' +
                '<td class="commslog-server">Server</td>' +
                '<td class="commslog-data">' + htmlEscape(data) + '</td></tr>';
        };

        connectButton.onclick = function() {
            stateLabel.innerHTML = "Connecting";
            socket = new WebSocket(connectionUrl.value);
            socket.onopen = function (event) {
                updateState();
                commsLog.innerHTML += '<tr>' +
                    '<td colspan="3" class="commslog-data">Connection opened</td>' +
                '</tr>';
            };
            socket.onclose = function (event) {
                updateState();
                commsLog.innerHTML += '<tr>' +
                    '<td colspan="3" class="commslog-data">Connection closed. Code: ' + htmlEscape(event.code) + '. Reason: ' + htmlEscape(event.reason) + '</td>' +
                '</tr>';
            };
            socket.onerror = updateState;
            socket.onmessage = function (event) {
                commsLog.innerHTML += '<tr>' +
                    '<td class="commslog-server">Server</td>' +
                    '<td class="commslog-client">Client</td>' +
                    '<td class="commslog-data">' + htmlEscape(event.data) + '</td></tr>';
            };
        };

        function htmlEscape(str) {
            return str.toString()
                .replace(/&/g, '&amp;')
                .replace(/"/g, '&quot;')
                .replace(/'/g, '&#39;')
                .replace(/</g, '&lt;')
                .replace(/>/g, '&gt;');
        }
    </script>
</body>
</html>


```