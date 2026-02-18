---
id: "lexical_offset.OffsetView"
title: "Class: OffsetView"
custom_edit_url: null
---

[@lexical/offset](../modules/lexical_offset.md).OffsetView

## Constructors

### constructor

• **new OffsetView**(`offsetMap`, `firstNode`, `blockOffsetSize?`): [`OffsetView`](lexical_offset.OffsetView.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `offsetMap` | `OffsetMap` | `undefined` |
| `firstNode` | ``null`` \| `OffsetNode` | `undefined` |
| `blockOffsetSize` | `number` | `1` |

#### Returns

[`OffsetView`](lexical_offset.OffsetView.md)

#### Defined in

[packages/lexical-offset/src/index.ts:65](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L65)

## Properties

### \_blockOffsetSize

• **\_blockOffsetSize**: `number`

#### Defined in

[packages/lexical-offset/src/index.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L63)

___

### \_firstNode

• **\_firstNode**: ``null`` \| `OffsetNode`

#### Defined in

[packages/lexical-offset/src/index.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L62)

___

### \_offsetMap

• **\_offsetMap**: `OffsetMap`

#### Defined in

[packages/lexical-offset/src/index.ts:61](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L61)

## Methods

### createSelectionFromOffsets

▸ **createSelectionFromOffsets**(`originalStart`, `originalEnd`, `diffOffsetView?`): ``null`` \| [`RangeSelection`](lexical.RangeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `originalStart` | `number` |
| `originalEnd` | `number` |
| `diffOffsetView?` | [`OffsetView`](lexical_offset.OffsetView.md) |

#### Returns

``null`` \| [`RangeSelection`](lexical.RangeSelection.md)

#### Defined in

[packages/lexical-offset/src/index.ts:75](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L75)

___

### getOffsetsFromSelection

▸ **getOffsetsFromSelection**(`selection`): [`number`, `number`]

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) |

#### Returns

[`number`, `number`]

#### Defined in

[packages/lexical-offset/src/index.ts:189](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L189)
