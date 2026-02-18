---
id: "lexical_headless"
title: "Module: @lexical/headless"
custom_edit_url: null
---

## Functions

### createHeadlessEditor

▸ **createHeadlessEditor**(`editorConfig?`): [`LexicalEditor`](../classes/lexical.LexicalEditor.md)

Generates a headless editor that allows lexical to be used without the need for a DOM, eg in Node.js.
Throws an error when unsupported methods are used.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editorConfig?` | [`CreateEditorArgs`](lexical.md#createeditorargs) | The optional lexical editor configuration. |

#### Returns

[`LexicalEditor`](../classes/lexical.LexicalEditor.md)

- The configured headless editor.

#### Defined in

[packages/lexical-headless/src/index.ts:19](https://github.com/facebook/lexical/tree/main/packages/lexical-headless/src/index.ts#L19)
