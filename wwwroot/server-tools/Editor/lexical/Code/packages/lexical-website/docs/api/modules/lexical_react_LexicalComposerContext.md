---
id: "lexical_react_LexicalComposerContext"
title: "Module: @lexical/react/LexicalComposerContext"
custom_edit_url: null
---

## Type Aliases

### LexicalComposerContextType

Ƭ **LexicalComposerContextType**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `getTheme` | () => [`EditorThemeClasses`](lexical.md#editorthemeclasses) \| ``null`` \| `undefined` |

#### Defined in

[packages/lexical-react/src/LexicalComposerContext.ts:14](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposerContext.ts#L14)

___

### LexicalComposerContextWithEditor

Ƭ **LexicalComposerContextWithEditor**: [[`LexicalEditor`](../classes/lexical.LexicalEditor.md), [`LexicalComposerContextType`](lexical_react_LexicalComposerContext.md#lexicalcomposercontexttype)]

#### Defined in

[packages/lexical-react/src/LexicalComposerContext.ts:18](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposerContext.ts#L18)

## Variables

### LexicalComposerContext

• `Const` **LexicalComposerContext**: `React.Context`\<[`LexicalComposerContextWithEditor`](lexical_react_LexicalComposerContext.md#lexicalcomposercontextwitheditor) \| ``null`` \| `undefined`\>

#### Defined in

[packages/lexical-react/src/LexicalComposerContext.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposerContext.ts#L23)

## Functions

### createLexicalComposerContext

▸ **createLexicalComposerContext**(`parent`, `theme`): [`LexicalComposerContextType`](lexical_react_LexicalComposerContext.md#lexicalcomposercontexttype)

#### Parameters

| Name | Type |
| :------ | :------ |
| `parent` | `undefined` \| ``null`` \| [`LexicalComposerContextWithEditor`](lexical_react_LexicalComposerContext.md#lexicalcomposercontextwitheditor) |
| `theme` | `undefined` \| ``null`` \| [`EditorThemeClasses`](lexical.md#editorthemeclasses) |

#### Returns

[`LexicalComposerContextType`](lexical_react_LexicalComposerContext.md#lexicalcomposercontexttype)

#### Defined in

[packages/lexical-react/src/LexicalComposerContext.ts:29](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposerContext.ts#L29)

___

### useLexicalComposerContext

▸ **useLexicalComposerContext**(): [`LexicalComposerContextWithEditor`](lexical_react_LexicalComposerContext.md#lexicalcomposercontextwitheditor)

#### Returns

[`LexicalComposerContextWithEditor`](lexical_react_LexicalComposerContext.md#lexicalcomposercontextwitheditor)

#### Defined in

[packages/lexical-react/src/LexicalComposerContext.ts:52](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalComposerContext.ts#L52)
