---
id: "lexical_file.SerializedDocument"
title: "Interface: SerializedDocument"
custom_edit_url: null
---

[@lexical/file](../modules/lexical_file.md).SerializedDocument

## Properties

### editorState

• **editorState**: [`SerializedEditorState`](lexical.SerializedEditorState.md)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

The serialized editorState produced by editorState.toJSON()

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:17](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L17)

___

### lastSaved

• **lastSaved**: `number`

The time this document was created in epoch milliseconds (Date.now())

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:19](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L19)

___

### source

• **source**: `string`

The source of the document, defaults to Lexical

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:21](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L21)

___

### version

• **version**: `string`

The version of Lexical that produced this document

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L23)
