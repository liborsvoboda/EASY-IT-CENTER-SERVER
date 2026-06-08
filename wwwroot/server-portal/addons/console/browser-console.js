class BrowserConsole {
    constructor() {

        let conInput = document.getElementById('browser-console-input');
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
                } else {
                    
                }
                self.addConsoleLine(input, 'browser-console-input');
                try {
                    console.log(input);
                    let returnVal = eval.apply(this, [input]);
                    self.addConsoleLine(returnVal, 'return');
                } catch (e) {
                    self.handleError(e);
                }
            }
        });
        conInput.focus();

    }

    clear() {
        while (document.getElementById('browser-console-output').hasChildNodes) {
            let blah = document.getElementById('browser-console-output').lastChild;
            if (blah === null) {
                break;
            }
            document.getElementById('browser-console-output').removeChild(blah);
        }
        Metro.storage.setItem('ConsoleLogList', []);
        consoleData = Metro.storage.getItem('ConsoleLogList', null);
    }

    addConsoleLine(msg, type) {
        let output = document.getElementById('browser-console-output');
        let newLine = document.createElement('div');
        newLine.classList.add(type);
        newLine.innerText = msg;
        output.appendChild(newLine);
    }

    handleLog(msg) {
        this.addConsoleLine(msg, 'log');
    }

    handleError(msg) {
        this.addConsoleLine(msg, 'error');
    }

    openWindow() {
        let output = document.getElementById('browser-console-output');
        let data = Metro.storage.getItem('ConsoleLogList', null);
        data.forEach(item => {
            let newLine = document.createElement('div');
            newLine.classList.add(item.type);
            newLine.innerText = item.message;
            output.appendChild(newLine);
        });
    }

    htmlEscape(str) {
        return str.toString()
            .replace(/&/g, '&amp;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;');
    }

}

window.Console = new BrowserConsole();

let consoleData = Metro.storage.getItem('ConsoleLogList', null);
Console.openWindow();
GetDiffConsoleData();

function GetDiffConsoleData() {
    setTimeout(function () {
        let data = Metro.storage.getItem('ConsoleLogList', null);
        data.forEach(item => {
            let diff = consoleData.filter(obj => { return obj.id == item.id; });
            if (diff.length == 0) {
                Console.addConsoleLine(item.message, item.type);
                consoleData.push({ id: item.id, message: item.message, type: item.type });
            }
        });
        
        
        GetDiffConsoleData();
    }, 1000);
}