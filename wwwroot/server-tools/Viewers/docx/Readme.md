# Microsoft Office DocX Document Viewer

- Microsoft Office DocX Document Viewer
- Here is Initialization, Set Document and Exporting to Other Formats



````
let sourceFile = Metro.storage.getItem("OpenWordFile", null);
        let currentDocument = null;
        const docxOptions = Object.assign(docx.defaultOptions, {
            debug: false,
            experimental: true,
            hideWrapperOnPrint: true
        });

        const container = document.querySelector("#document-container");
        setTimeout(function () { $("body > label > span.button")[0].style["display"] = "none"; }, 100);
        let wordFile = null;


        function GetFile(e) {
            fetch(sourceFile).then(r => r.blob()).then(data => { wordFile = new File([data], "name"); RenderDocx(data); });
        }


        async function RenderDocx(file) {
            currentDocument = file;
            if (!currentDocument) { return; }
            let docxBlob = preprocessTiff(currentDocument);
            let res = await docx.renderAsync(docxBlob, container, null, docxOptions)
            renderThumbnails(container, document.querySelector("#thumbnails-container"));

        }


        async function ExportToHtml() {
            const file = await showSaveFilePicker({ types: [{ description: "HTML File", accept: { "text/html": [".html"] } }] });
            const stream = await file.createWritable();
            await stream.write(container.innerHTML);
            await stream.close();
        }


        async function ExportToXsl() {
            let file = await showSaveFilePicker({ types: [{ description: "XML File", accept: { "application/xml": [".xml"] } }] });
            require("docx2xsl")(wordFile)
                .then(async xsl => {
                    console.log("Xsl", xsl);
                    let stream = await file.createWritable();
                    await stream.write(xsl.data);
                    await stream.close();
                }).catch(e => { console.log(e); })
        }
````