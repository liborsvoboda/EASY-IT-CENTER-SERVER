# Monaco Editor



- Add Keybindings
````
                                    key            +  key                 function                 
    window.editor.addCommand(monaco.KeyMod.CtrlCmd | monaco.KeyCode.KeyE, loadGist);
    window.editor.addCommand(monaco.KeyMod.CtrlCmd | monaco.KeyCode.Enter, evalSelectionOrLine);
    window.editor.addCommand(monaco.KeyMod.CtrlCmd | monaco.KeyMod.Shift | monaco.KeyCode.Enter, evalBuffer);
````
