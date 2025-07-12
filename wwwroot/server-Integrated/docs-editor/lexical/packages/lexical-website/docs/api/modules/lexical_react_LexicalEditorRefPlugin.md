---
id: "lexical_react_LexicalEditorRefPlugin"
title: "Module: @lexical/react/LexicalEditorRefPlugin"
custom_edit_url: null
---

## Functions

### EditorRefPlugin

▸ **EditorRefPlugin**(`«destructured»`): ``null``

Use this plugin to access the editor instance outside of the
LexicalComposer. This can help with things like buttons or other
UI components that need to update or read EditorState but need to
be positioned outside the LexicalComposer in the React tree.

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `Object` |
| › `editorRef` | (`instance`: ``null`` \| [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => `void` \| `MutableRefObject`\<`undefined` \| ``null`` \| [`LexicalEditor`](../classes/lexical.LexicalEditor.md)\> |

#### Returns

``null``

#### Defined in

[packages/lexical-react/src/LexicalEditorRefPlugin.tsx:21](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalEditorRefPlugin.tsx#L21)
