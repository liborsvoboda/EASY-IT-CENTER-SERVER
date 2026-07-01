let socket = new WebSocket(`${document.location.protocol === "https:" ? "wss" : "ws"}://${document.location.hostname}:${document.location.port}/WebSocketService/Process`);

socket.onmessage = function (event) {
    let message = JSON.parse(event.data);
    con.addConsoleLine(message.Message, message.Type == "error" ? 'error_console' : 'warn_console');
};

class Console {
    constructor() {
       
        let conInput = document.getElementById('browserconsoleinput');
        let self = this;
        self.consoleBackbuffer = [];

        conInput.addEventListener('keydown', function (e) {
            if (13 === e.keyCode) {
                let input = conInput.value;
                self.consoleBackbuffer.push(input);
                conInput.value = "";
                if (input.toLowerCase() === 'clear') {
                    self.clear();
                    return;
                }
                self.addConsoleLine(input, 'browserconsoleinput');
                try {
                    con.SendChatMessageWS(1000, JSON.stringify({ Console: true , Message: input }));
                    self.addConsoleLine(input, 'return');
                } catch (e) {
                }
            }
        });
        conInput.focus();
    }

    PingInterval = setInterval(() => {
       con.SendChatMessageWS(1000, JSON.stringify({}));
    }, 30000);

    SendChatMessageWS = function (interval, message = null) {
        if (socket.readyState === 1) {

            if (message != null) {
                //SEND MESSAGE
                socket.send(message);
                socket.close();
            }
            socket = new WebSocket(`${Metro.storage.getItem('ApiOriginSuffix', null).replace("http:", "ws:").replace("https:", "wss:")}WebSocketService/Process`)
            socket.onmessage = function (event) {
                let message = JSON.parse(event.data);
                con.addConsoleLine(message.Message, message.Type == "error" ? 'error_console' : 'info_console');
            };

        } else {
            setTimeout(function () {
                con.SendChatMessageWS(interval, message);
            }, interval);
        }
    }  


    clear() {
        while(document.getElementById('browser-console-output').hasChildNodes) {
            let blah = document.getElementById('browser-console-output').lastChild;
            if (blah === null) {
                break;
            }
            document.getElementById('browser-console-output').removeChild(blah);
        }
    }

    addConsoleLine(msg, type) {
        let output = document.getElementById('browser-console-output');
        let newLine = document.createElement('div');
        newLine.classList.add(type);
        newLine.innerText = msg;
        output.appendChild(newLine);
    }

    htmlEscape(str) {
        return str.toString()
            .replace(/&/g, '&amp;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;');
    }

    ScrollToBottom = function () { window.scrollTo(0, document.body.scrollHeight); }
}

const con = new Console();