---
id: "lexical_offset"
title: "Module: @lexical/offset"
custom_edit_url: null
---

## Classes

- [OffsetView](../classes/lexical_offset.OffsetView.md)

## Functions

### $createChildrenArray

▸ **$createChildrenArray**(`element`, `nodeMap`): [`NodeKey`](lexical.md#nodekey)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ElementNode`](../classes/lexical.ElementNode.md) |
| `nodeMap` | ``null`` \| [`NodeMap`](lexical.md#nodemap) |

#### Returns

[`NodeKey`](lexical.md#nodekey)[]

#### Defined in

[packages/lexical-offset/src/index.ts:540](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L540)

___

### $createOffsetView

▸ **$createOffsetView**(`editor`, `blockOffsetSize?`, `editorState?`): [`OffsetView`](../classes/lexical_offset.OffsetView.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | `undefined` |
| `blockOffsetSize` | `number` | `1` |
| `editorState?` | ``null`` \| [`EditorState`](../classes/lexical.EditorState.md) | `undefined` |

#### Returns

[`OffsetView`](../classes/lexical_offset.OffsetView.md)

#### Defined in

[packages/lexical-offset/src/index.ts:560](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L560)

___

### createChildrenArray

▸ **createChildrenArray**(`element`, `nodeMap`): [`NodeKey`](lexical.md#nodekey)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | [`ElementNode`](../classes/lexical.ElementNode.md) |
| `nodeMap` | ``null`` \| [`NodeMap`](lexical.md#nodemap) |

#### Returns

[`NodeKey`](lexical.md#nodekey)[]

**`Deprecated`**

renamed to [$createChildrenArray](lexical_offset.md#$createchildrenarray) by @lexical/eslint-plugin rules-of-lexical

#### Defined in

[packages/lexical-offset/src/index.ts:558](https://github.com/facebook/lexical/tree/main/packages/lexical-offset/src/index.ts#L558)
