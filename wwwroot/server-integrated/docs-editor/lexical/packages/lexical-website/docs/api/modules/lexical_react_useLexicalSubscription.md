---
id: "lexical_react_useLexicalSubscription"
title: "Module: @lexical/react/useLexicalSubscription"
custom_edit_url: null
---

## References

### useLexicalSubscription

Re-exports [useLexicalSubscription](lexical_react_useLexicalSubscription.md#uselexicalsubscription-1)

## Type Aliases

### LexicalSubscription

Ƭ **LexicalSubscription**\<`T`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `initialValueFn` | () => `T` |
| `subscribe` | (`callback`: (`value`: `T`) => `void`) => () => `void` |

#### Defined in

[packages/lexical-react/src/useLexicalSubscription.tsx:15](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/useLexicalSubscription.tsx#L15)

## Functions

### useLexicalSubscription

▸ **useLexicalSubscription**\<`T`\>(`subscription`): `T`

Shortcut to Lexical subscriptions when values are used for render.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `subscription` | (`editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => [`LexicalSubscription`](lexical_react_useLexicalSubscription.md#lexicalsubscription)\<`T`\> | The function to create the [LexicalSubscription](lexical_react_useLexicalSubscription.md#lexicalsubscription). This function's identity must be stable (e.g. defined at module scope or with useCallback). |

#### Returns

`T`

#### Defined in

[packages/lexical-react/src/useLexicalSubscription.tsx:24](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/useLexicalSubscription.tsx#L24)
