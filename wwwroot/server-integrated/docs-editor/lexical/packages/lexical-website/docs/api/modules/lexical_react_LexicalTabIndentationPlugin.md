---
id: "lexical_react_LexicalTabIndentationPlugin"
title: "Module: @lexical/react/LexicalTabIndentationPlugin"
custom_edit_url: null
---

## Functions

### TabIndentationPlugin

▸ **TabIndentationPlugin**(): ``null``

This plugin adds the ability to indent content using the tab key. Generally, we don't
recommend using this plugin as it could negatively affect acessibility for keyboard
users, causing focus to become trapped within the editor.

#### Returns

``null``

#### Defined in

[packages/lexical-react/src/LexicalTabIndentationPlugin.tsx:86](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTabIndentationPlugin.tsx#L86)

___

### registerTabIndentation

▸ **registerTabIndentation**(`editor`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-react/src/LexicalTabIndentationPlugin.tsx:60](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTabIndentationPlugin.tsx#L60)
