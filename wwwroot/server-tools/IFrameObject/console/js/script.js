class Console {
    constructor() {

        let socket = new WebSocket(`${document.location.protocol === "https:" ? "wss" : "ws"}://${document.location.hostname}:${document.location.port}/WebSocketService/ServerCoreMonitor`);
        let conInput = document.getElementById('browserconsoleinput');
        let self = this;
        self.consoleBackbuffer = [];
        conInput.addEventListener('keydown', function(e) {
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
                    let returnVal = eval.apply(this, [input]);
                    self.addConsoleLine(returnVal, 'return');
                } catch (e) {
                    self.handleError(e);
                }
            }
        });
        conInput.focus();

        socket.onmessage = function (event) {
            self.addConsoleLine(event.data, 'log_console');
        };
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