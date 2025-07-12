---
id: "lexical.Point"
title: "Class: Point"
custom_edit_url: null
---

[lexical](../modules/lexical.md).Point

## Constructors

### constructor

• **new Point**(`key`, `offset`, `type`): [`Point`](lexical.Point.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `offset` | `number` |
| `type` | ``"element"`` \| ``"text"`` |

#### Returns

[`Point`](lexical.Point.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:97](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L97)

## Properties

### \_selection

• **\_selection**: ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:95](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L95)

___

### key

• **key**: `string`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:92](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L92)

___

### offset

• **offset**: `number`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:93](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L93)

___

### type

• **type**: ``"element"`` \| ``"text"``

#### Defined in

[packages/lexical/src/LexicalSelection.ts:94](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L94)

## Methods

### getNode

▸ **getNode**(): [`LexicalNode`](lexical.LexicalNode.md)

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:132](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L132)

___

### is

▸ **is**(`point`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `point` | [`PointType`](../modules/lexical.md#pointtype) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:104](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L104)

___

### isBefore

▸ **isBefore**(`b`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `b` | [`PointType`](../modules/lexical.md#pointtype) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:112](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L112)

___

### set

▸ **set**(`key`, `offset`, `type`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `offset` | `number` |
| `type` | ``"element"`` \| ``"text"`` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:141](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L141)
