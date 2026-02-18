---
id: "lexical_react_LexicalContentEditable"
title: "Module: @lexical/react/LexicalContentEditable"
custom_edit_url: null
---

## Type Aliases

### Props

Ƭ **Props**: `Omit`\<`ElementProps`, ``"editor"``\> & \{ `editor__DEPRECATED?`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)  } & \{ `aria-placeholder?`: `void` ; `placeholder?`: ``null``  } \| \{ `aria-placeholder`: `string` ; `placeholder`: (`isEditable`: `boolean`) => ``null`` \| `JSX.Element` \| `JSX.Element`  }

#### Defined in

[packages/lexical-react/src/LexicalContentEditable.tsx:18](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalContentEditable.tsx#L18)

## Functions

### ContentEditable

▸ **ContentEditable**(`props`): `ReactNode`

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`Props`](lexical_react_LexicalContentEditable.md#props) & `RefAttributes`\<`HTMLDivElement`\> |

#### Returns

`ReactNode`

#### Defined in

[packages/lexical-react/src/LexicalContentEditable.tsx:33](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalContentEditable.tsx#L33)
