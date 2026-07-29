let viewer = document.getElementById('viewer');
let workBook = null;
let excelGrid = null;
let activeSheet = '';
let sheets = [];
let excelButtons = null;
let buttons = [];

let sourceFile = Metro.storage.getItem("OpenExcelFile",null);
//let queryString = window.location.search;
//let urlParams = new URLSearchParams(queryString);
//let sourceFile = urlParams.get('file');

/*
let myFile = null;
const dataTransfer = new DataTransfer();
let input = document.getElementById('SourceFile');

fetch(sourceFile).then(r => r.blob()).then(data => {
    myFile = new File([data], sourceFile);
    dataTransfer.items.add(myFile);
    input.files = dataTransfer.files;
});
*/

let options = {
    tableName: 'TableData',
    worksheetName: 'Export Table'
};

function doExport(params) {
    var options = {
        tableName: 'TableData',
        worksheetName: 'Export Table'
    };

    $.extend(true, options, params);

    $('#menuTable').tableExport(options);
}


function getFile(e) {
    fetch(sourceFile).then(r => r.blob()).then(data => {
        var reader = new FileReader();
        reader.onload = function (evt) {
            showExcel(reader.result);
        }
        reader.readAsBinaryString(data);
    });
}


function showSheet (el) {
    let buttons = document.querySelectorAll('button');
    buttons.forEach(button => {
        button.classList.remove('active');
    })
    el.classList.add('active');
    let workSheet = workBook.Sheets[el.innerText];
    excelGrid.innerHTML = XLSX.utils.sheet_to_html(workSheet);
    activeSheet = el.innerText;
}

function clearAll () {
    viewer.innerHTML = "";
    workBook = null;
    excelGrid = null;
    sheets = [];
    excelButtons = null;
    buttons = [];
}

function showExcel(data) {
    clearAll();
    workBook = XLSX.read(data, { type: 'binary' });
    sheets = workBook.SheetNames;
    workBook.SheetNames.forEach(function (sheetName) {
        let headers = [];
        let sheet = workBook.Sheets[sheetName];
        let range = XLSX.utils.decode_range(sheet['!ref']);
        let C = range.s.r;
        let R = range.s.r;
        for (C = range.s.c; C <= range.e.c; ++C) {
            let cell = sheet[XLSX.utils.encode_cell({ c: C, r: R })]
            let hdr = 'NIPUN';
            if (cell && cell.t) {
                hdr = XLSX.utils.format_cell(cell);
            }
            headers.push(hdr);
        }
        // For each sheets, convert to json.
        let roa = XLSX.utils.sheet_to_json(workBook.Sheets[sheetName])
        if (roa.length > 0) {
            roa.forEach(function (row) {
                headers.forEach(function (hd) {
                    if (row[hd] === undefined) {
                        row[hd] = '';
                    }
                })
            })
        }
    })
    excelGrid = document.createElement('table');
    excelGrid.id = "menuTable"; 
    excelGrid.classList.add('table');
    excelGrid.classList.add('table-bordered');
    excelGrid.classList.add('table-responsive');
    excelGrid.classList.add('excel-table');
    excelButtons = document.createElement('div');
    excelButtons.classList.add('excelButtons');
    for (let i = 0; i < sheets.length; i++) {
        let button = document.createElement('button');
        button.classList.add('sheetBtn');
        button.innerText = sheets[i];
        button.addEventListener('click', (e) => {
            showSheet(e.target);
        })
        excelButtons.appendChild(button);
        buttons.push(button);
    }
    let container = document.createElement('div')
    container.classList.add('excel-container');
    container.appendChild(excelGrid);
    viewer.innerHTML = "";
    viewer.appendChild(container);
    viewer.appendChild(excelButtons);
    // self.excelGrid = canvasDatagrid({
    //   parentNode: document.getElementById('pdf-viewer'),
    //   data: []
    // })
    // self.excelGrid.style.width = '100%'
    // self.excelGrid.style.height = '100%'

    // self.excelGrid.style.gridBackgroundColor = 'white'
    // self.excelGrid.style.cellFont = '14px sans-serif'
    showSheet(buttons[0]);
}