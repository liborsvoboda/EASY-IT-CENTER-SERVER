---
id: "lexical.BaseSelection"
title: "Interface: BaseSelection"
custom_edit_url: null
---

[lexical](../modules/lexical.md).BaseSelection

## Implemented by

- [`NodeSelection`](../classes/lexical.NodeSelection.md)
- [`RangeSelection`](../classes/lexical.RangeSelection.md)
- [`TableSelection`](../classes/lexical_table.TableSelection.md)

## Properties

### \_cachedNodes

• **\_cachedNodes**: ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:249](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L249)

___

### dirty

• **dirty**: `boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:250](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L250)

## Methods

### clone

▸ **clone**(): [`BaseSelection`](lexical.BaseSelection.md)

#### Returns

[`BaseSelection`](lexical.BaseSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:252](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L252)

___

### extract

▸ **extract**(): [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:253](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L253)

___

### getCachedNodes

▸ **getCachedNodes**(): ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Returns

``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:263](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L263)

___

### getNodes

▸ **getNodes**(): [`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)[]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:254](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L254)

___

### getStartEndPoints

▸ **getStartEndPoints**(): ``null`` \| [[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Returns

``null`` \| [[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:260](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L260)

___

### getTextContent

▸ **getTextContent**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:255](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L255)

___

### insertNodes

▸ **insertNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | [`LexicalNode`](../classes/lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:259](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L259)

___

### insertRawText

▸ **insertRawText**(`text`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:257](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L257)

___

### insertText

▸ **insertText**(`text`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:256](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L256)

___

### is

▸ **is**(`selection`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](lexical.BaseSelection.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:258](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L258)

___

### isBackward

▸ **isBackward**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:262](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L262)

___

### isCollapsed

▸ **isCollapsed**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:261](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L261)

___

### setCachedNodes

▸ **setCachedNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:264](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L264)
