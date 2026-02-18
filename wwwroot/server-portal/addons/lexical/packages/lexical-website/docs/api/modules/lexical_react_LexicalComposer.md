---
id: "lexical_react_LexicalComposer"
title: "Module: @lexical/react/LexicalComposer"
custom_edit_url: null
---

## Type Aliases

### InitialConfigType

Ƭ **InitialConfigType**: `Readonly`\<\{ `editable?`: `boolean` ; `editorState?`: [`InitialEditorStateType`](lexical_react_LexicalComposer.md#initialeditorstatetype) ; `editor__DEPRECATED?`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md) \| ``null`` ; `html?`: [`HTMLConfig`](lexical.md#htmlconfig) ; `namespace`: `string` ; `nodes?`: `ReadonlyArray`\<[`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\> \| [`LexicalNodeReplacement`](lexical.md#lexicalnodereplacement)\> ; `onError`: (`error`: `Error`, `editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => `void` ; `theme?`: [`EditorThemeClasses`](lexical.md#editorthemeclasses)  }\>

#### Defined in

[packages/lexical-react/src/LexicalComposer.tsx:41](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposer.tsx#L41)

___

### InitialEditorStateType

Ƭ **InitialEditorStateType**: ``null`` \| `string` \| [`EditorState`](../classes/lexical.EditorState.md) \| (`editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => `void`

#### Defined in

[packages/lexical-react/src/LexicalComposer.tsx:35](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposer.tsx#L35)

## Functions

### LexicalComposer

▸ **LexicalComposer**(`«destructured»`): `JSX.Element`

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `Props` |

#### Returns

`JSX.Element`

#### Defined in

[packages/lexical-react/src/LexicalComposer.tsx:56](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposer.tsx#L56)
