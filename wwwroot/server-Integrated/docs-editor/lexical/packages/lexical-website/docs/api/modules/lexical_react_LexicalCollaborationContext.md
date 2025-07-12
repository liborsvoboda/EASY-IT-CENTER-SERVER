---
id: "lexical_react_LexicalCollaborationContext"
title: "Module: @lexical/react/LexicalCollaborationContext"
custom_edit_url: null
---

## Type Aliases

### CollaborationContextType

Ƭ **CollaborationContextType**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `clientID` | `number` |
| `color` | `string` |
| `isCollabActive` | `boolean` |
| `name` | `string` |
| `yjsDocMap` | `Map`\<`string`, `Doc`\> |

#### Defined in

[packages/lexical-react/src/LexicalCollaborationContext.ts:13](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalCollaborationContext.ts#L13)

## Variables

### CollaborationContext

• `Const` **CollaborationContext**: `Context`\<[`CollaborationContextType`](lexical_react_LexicalCollaborationContext.md#collaborationcontexttype)\>

#### Defined in

[packages/lexical-react/src/LexicalCollaborationContext.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalCollaborationContext.ts#L41)

## Functions

### useCollaborationContext

▸ **useCollaborationContext**(`username?`, `color?`): [`CollaborationContextType`](lexical_react_LexicalCollaborationContext.md#collaborationcontexttype)

#### Parameters

| Name | Type |
| :------ | :------ |
| `username?` | `string` |
| `color?` | `string` |

#### Returns

[`CollaborationContextType`](lexical_react_LexicalCollaborationContext.md#collaborationcontexttype)

#### Defined in

[packages/lexical-react/src/LexicalCollaborationContext.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalCollaborationContext.ts#L49)
