---
id: "lexical.EditorState"
title: "Class: EditorState"
custom_edit_url: null
---

[lexical](../modules/lexical.md).EditorState

## Constructors

### constructor

• **new EditorState**(`nodeMap`, `selection?`): [`EditorState`](lexical.EditorState.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodeMap` | [`NodeMap`](../modules/lexical.md#nodemap) |
| `selection?` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

[`EditorState`](lexical.EditorState.md)

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:104](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L104)

## Properties

### \_flushSync

• **\_flushSync**: `boolean`

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:101](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L101)

___

### \_nodeMap

• **\_nodeMap**: [`NodeMap`](../modules/lexical.md#nodemap)

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:99](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L99)

___

### \_readOnly

• **\_readOnly**: `boolean`

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:102](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L102)

___

### \_selection

• **\_selection**: ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:100](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L100)

## Methods

### clone

▸ **clone**(`selection?`): [`EditorState`](lexical.EditorState.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection?` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

[`EditorState`](lexical.EditorState.md)

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:123](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L123)

___

### isEmpty

▸ **isEmpty**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:111](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L111)

___

### read

▸ **read**\<`V`\>(`callbackFn`, `options?`): `V`

#### Type parameters

| Name |
| :------ |
| `V` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `callbackFn` | () => `V` |
| `options?` | [`EditorStateReadOptions`](../interfaces/lexical.EditorStateReadOptions.md) |

#### Returns

`V`

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:115](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L115)

___

### toJSON

▸ **toJSON**(): [`SerializedEditorState`](../interfaces/lexical.SerializedEditorState.md)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

#### Returns

[`SerializedEditorState`](../interfaces/lexical.SerializedEditorState.md)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

#### Defined in

[packages/lexical/src/LexicalEditorState.ts:132](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditorState.ts#L132)
