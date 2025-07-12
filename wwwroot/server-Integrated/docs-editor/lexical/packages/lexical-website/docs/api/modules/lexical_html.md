---
id: "lexical_html"
title: "Module: @lexical/html"
custom_edit_url: null
---

## Functions

### $generateHtmlFromNodes

▸ **$generateHtmlFromNodes**(`editor`, `selection?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `selection?` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

`string`

#### Defined in

[packages/lexical-html/src/index.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-html/src/index.ts#L66)

___

### $generateNodesFromDOM

▸ **$generateNodesFromDOM**(`editor`, `dom`): [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

How you parse your html string to get a document is left up to you. In the browser you can use the native
DOMParser API to generate a document (see clipboard.ts), but to use in a headless environment you can use JSDom
or an equivalent library and pass in the document here.

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `dom` | `Document` |

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Defined in

[packages/lexical-html/src/index.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-html/src/index.ts#L40)
