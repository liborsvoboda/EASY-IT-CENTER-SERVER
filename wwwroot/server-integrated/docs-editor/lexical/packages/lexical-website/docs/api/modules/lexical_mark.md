---
id: "lexical_mark"
title: "Module: @lexical/mark"
custom_edit_url: null
---

## Classes

- [MarkNode](../classes/lexical_mark.MarkNode.md)

## Type Aliases

### SerializedMarkNode

Ƭ **SerializedMarkNode**: [`Spread`](lexical.md#spread)\<\{ `ids`: `string`[]  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:25](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L25)

## Functions

### $createMarkNode

▸ **$createMarkNode**(`ids`): [`MarkNode`](../classes/lexical_mark.MarkNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `ids` | `string`[] |

#### Returns

[`MarkNode`](../classes/lexical_mark.MarkNode.md)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:200](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L200)

___

### $getMarkIDs

▸ **$getMarkIDs**(`node`, `offset`): ``null`` \| `string`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`TextNode`](../classes/lexical.TextNode.md) |
| `offset` | `number` |

#### Returns

``null`` \| `string`[]

#### Defined in

[packages/lexical-mark/src/index.ts:135](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/index.ts#L135)

___

### $isMarkNode

▸ **$isMarkNode**(`node`): node is MarkNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is MarkNode

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:204](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L204)

___

### $unwrapMarkNode

▸ **$unwrapMarkNode**(`node`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`MarkNode`](../classes/lexical_mark.MarkNode.md) |

#### Returns

`void`

#### Defined in

[packages/lexical-mark/src/index.ts:16](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/index.ts#L16)

___

### $wrapSelectionInMarkNode

▸ **$wrapSelectionInMarkNode**(`selection`, `isBackward`, `id`, `createNode?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) |
| `isBackward` | `boolean` |
| `id` | `string` |
| `createNode?` | (`ids`: `string`[]) => [`MarkNode`](../classes/lexical_mark.MarkNode.md) |

#### Returns

`void`

#### Defined in

[packages/lexical-mark/src/index.ts:31](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/index.ts#L31)
