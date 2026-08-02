/**
 * Copyright (C) 2014 KO GmbH <copyright@kogmbh.com>
 *
 * @licstart
 * This file is part of WebODF.
 *
 * WebODF is free software: you can redistribute it and/or modify it
 * under the terms of the GNU Affero General Public License (GNU AGPL)
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version.
 *
 * WebODF is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with WebODF.  If not, see <http://www.gnu.org/licenses/>.
 * @licend
 *
 * @source: http://www.webodf.org/
 * @source: https://github.com/kogmbh/WebODF/
 */

/*global document, window, runtime, FileReader, alert, Uint8Array, Blob, saveAs, Wodo*/


    function fileSelectHandler(evt) {
        var reader;
        window.Files = (evt.target && evt.target.files) ||
            (evt.dataTransfer && evt.dataTransfer.files);
        function onLoadEnd() {
            if (reader.readyState === 2) {
				window.FileResult = reader.result;
                runtime.registerFile(window.File.name, reader.result);
                loadedFilename = window.File.name;
                editor.openDocumentFromUrl(loadedFilename, startEditing);
            }
        }
        if (window.Files && window.Files.length === 1) {
            if (!editor.isDocumentModified() ||
                window.confirm("There are unsaved changes to the file. Do you want to discard them?")) {
                editor.closeDocument(function() {
                    window.File = window.Files[0];
                    reader = new FileReader();
                    reader.onloadend = onLoadEnd;
                    reader.readAsArrayBuffer(File);
                });
            }
        } else {
            alert("File could not be opened in this browser.");
        }
    }



function createEditor() {
    "use strict";

    let editor = null,
        editorOptions,
        loadedFilename;

    /*jslint emptyblock: true*/
    /**
     * @return {undefined}
     */
    function startEditing() {
    }
    /*jslint emptyblock: false*/

    /**
     * extract document url from the url-fragment
     *
     * @return {?string}
     */
    function guessDocUrl() {
        let pos, docUrl = String(document.location);
        // If the URL has a fragment (#...), try to load the file it represents
        pos = docUrl.indexOf('#');
        if (pos !== -1) {
            docUrl = docUrl.substr(pos + 1);
        } else {
            docUrl = "welcome.odt";
        }
        return docUrl || null;
    }

 
	/*
    function onEditorCreated(err, e) {
        //var docUrl = guessDocUrl();

        if (err) {
            // something failed unexpectedly
            alert(err);
            return;
        }

        editor = e;
        editor.setUserData({
            fullName: "Office Editor",
            color:    "black"
        });
		
        window.addEventListener("beforeunload", function (e) {
            var confirmationMessage = "There are unsaved changes to the file.";

            if (editor.isDocumentModified()) {
                // Gecko + IE
                (e || window.event).returnValue = confirmationMessage;
                // Webkit, Safari, Chrome etc.
                return confirmationMessage;
            }
        });
		

        if (docUrl) {
            loadedFilename = docUrl;
            editor.openDocumentFromUrl(docUrl, startEditing);
        }
		
    }
	*/

    //Wodo.createTextEditor('editorContainer', editorOptions, onEditorCreated);
}
