---
id: "lexical_file"
title: "Module: @lexical/file"
custom_edit_url: null
---

## Interfaces

- [SerializedDocument](../interfaces/lexical_file.SerializedDocument.md)

## Functions

### editorStateFromSerializedDocument

▸ **editorStateFromSerializedDocument**(`editor`, `maybeStringifiedDocument`): [`EditorState`](../classes/lexical.EditorState.md)

Parse an EditorState from the given editor and document

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor |
| `maybeStringifiedDocument` | `string` \| [`SerializedDocument`](../interfaces/lexical_file.SerializedDocument.md) | The contents of a .lexical file (as a JSON string, or already parsed) |

#### Returns

[`EditorState`](../classes/lexical.EditorState.md)

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:54](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L54)

___

### exportFile

▸ **exportFile**(`editor`, `config?`): `void`

Generates a .lexical file to be downloaded by the browser containing the current editor state.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `config` | `Readonly`\<\{ `fileName?`: `string` ; `source?`: `string`  }\> | An object that optionally contains fileName and source. fileName defaults to the current date (as a string) and source defaults to Lexical. |

#### Returns

`void`

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:105](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L105)

___

### importFile

▸ **importFile**(`editor`): `void`

Takes a file and inputs its content into the editor state as an input field.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |

#### Returns

`void`

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L69)

___

### serializedDocumentFromEditorState

▸ **serializedDocumentFromEditorState**(`editorState`, `config?`): [`SerializedDocument`](../interfaces/lexical_file.SerializedDocument.md)

Generates a SerializedDocument from the given EditorState

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editorState` | [`EditorState`](../classes/lexical.EditorState.md) | the EditorState to serialize |
| `config` | `Readonly`\<\{ `lastSaved?`: `number` ; `source?`: `string`  }\> | An object that optionally contains source and lastSaved. source defaults to Lexical and lastSaved defaults to the current time in epoch milliseconds. |

#### Returns

[`SerializedDocument`](../interfaces/lexical_file.SerializedDocument.md)

#### Defined in

[packages/lexical-file/src/fileImportExport.ts:33](https://github.com/facebook/lexical/tree/main/packages/lexical-file/src/fileImportExport.ts#L33)
