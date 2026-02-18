---
id: "lexical_react_useLexicalTextEntity"
title: "Module: @lexical/react/useLexicalTextEntity"
custom_edit_url: null
---

## Functions

### useLexicalTextEntity

▸ **useLexicalTextEntity**\<`T`\>(`getMatch`, `targetNode`, `createNode`): `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`TextNode`](../classes/lexical.TextNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMatch` | (`text`: `string`) => ``null`` \| [`EntityMatch`](lexical_text.md#entitymatch) |
| `targetNode` | [`Klass`](lexical.md#klass)\<`T`\> |
| `createNode` | (`textNode`: [`TextNode`](../classes/lexical.TextNode.md)) => `T` |

#### Returns

`void`

#### Defined in

[packages/lexical-react/src/useLexicalTextEntity.ts:17](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/useLexicalTextEntity.ts#L17)
