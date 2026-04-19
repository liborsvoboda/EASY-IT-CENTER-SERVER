---
id: "lexical_devtools_core"
title: "Module: @lexical/devtools-core"
custom_edit_url: null
---

## Type Aliases

### CustomPrintNodeFn

Ƭ **CustomPrintNodeFn**: (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md), `obfuscateText?`: `boolean`) => `string`

#### Type declaration

▸ (`node`, `obfuscateText?`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |
| `obfuscateText?` | `boolean` |

##### Returns

`string`

#### Defined in

[packages/lexical-devtools-core/src/generateContent.ts:35](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/generateContent.ts#L35)

___

### LexicalCommandLog

Ƭ **LexicalCommandLog**: `ReadonlyArray`\<\{ `index`: `number`  } & [`LexicalCommand`](lexical.md#lexicalcommand)\<`unknown`\> & \{ `payload`: `unknown`  }\>

#### Defined in

[packages/lexical-devtools-core/src/useLexicalCommandsLog.ts:14](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/useLexicalCommandsLog.ts#L14)

## Functions

### TreeView

▸ **TreeView**(`props`): `ReactNode`

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | \{ `editorState`: [`EditorState`](../classes/lexical.EditorState.md) ; `generateContent`: (`exportDOM`: `boolean`) => `Promise`\<`string`\> ; `setEditorReadOnly`: (`isReadonly`: `boolean`) => `void` ; `setEditorState`: (`state`: [`EditorState`](../classes/lexical.EditorState.md), `options?`: [`EditorSetOptions`](lexical.md#editorsetoptions)) => `void` ; `timeTravelButtonClassName`: `string` ; `timeTravelPanelButtonClassName`: `string` ; `timeTravelPanelClassName`: `string` ; `timeTravelPanelSliderClassName`: `string` ; `treeTypeButtonClassName`: `string` ; `viewClassName`: `string`  } & `RefAttributes`\<`HTMLPreElement`\> |

#### Returns

`ReactNode`

#### Defined in

[packages/lexical-devtools-core/src/TreeView.tsx:16](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/TreeView.tsx#L16)

___

### generateContent

▸ **generateContent**(`editor`, `commandsLog`, `exportDOM`, `customPrintNode?`, `obfuscateText?`): `string`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | `undefined` |
| `commandsLog` | [`LexicalCommandLog`](lexical_devtools_core.md#lexicalcommandlog) | `undefined` |
| `exportDOM` | `boolean` | `undefined` |
| `customPrintNode?` | [`CustomPrintNodeFn`](lexical_devtools_core.md#customprintnodefn) | `undefined` |
| `obfuscateText` | `boolean` | `false` |

#### Returns

`string`

#### Defined in

[packages/lexical-devtools-core/src/generateContent.ts:93](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/generateContent.ts#L93)

___

### registerLexicalCommandLogger

▸ **registerLexicalCommandLogger**(`editor`, `setLoggedCommands`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `setLoggedCommands` | (`v`: (`oldValue`: [`LexicalCommandLog`](lexical_devtools_core.md#lexicalcommandlog)) => [`LexicalCommandLog`](lexical_devtools_core.md#lexicalcommandlog)) => `void` |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-devtools-core/src/useLexicalCommandsLog.ts:18](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/useLexicalCommandsLog.ts#L18)

___

### useLexicalCommandsLog

▸ **useLexicalCommandsLog**(`editor`): [`LexicalCommandLog`](lexical_devtools_core.md#lexicalcommandlog)

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

#### Returns

[`LexicalCommandLog`](lexical_devtools_core.md#lexicalcommandlog)

#### Defined in

[packages/lexical-devtools-core/src/useLexicalCommandsLog.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical-devtools-core/src/useLexicalCommandsLog.ts#L57)
