---
id: "lexical_rich_text"
title: "Module: @lexical/rich-text"
custom_edit_url: null
---

## Classes

- [HeadingNode](../classes/lexical_rich_text.HeadingNode.md)
- [QuoteNode](../classes/lexical_rich_text.QuoteNode.md)

## Type Aliases

### HeadingTagType

Ƭ **HeadingTagType**: ``"h1"`` \| ``"h2"`` \| ``"h3"`` \| ``"h4"`` \| ``"h5"`` \| ``"h6"``

#### Defined in

[packages/lexical-rich-text/src/index.ts:221](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L221)

___

### SerializedHeadingNode

Ƭ **SerializedHeadingNode**: [`Spread`](lexical.md#spread)\<\{ `tag`: ``"h1"`` \| ``"h2"`` \| ``"h3"`` \| ``"h4"`` \| ``"h5"`` \| ``"h6"``  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-rich-text/src/index.ts:104](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L104)

___

### SerializedQuoteNode

Ƭ **SerializedQuoteNode**: [`SerializedElementNode`](lexical.md#serializedelementnode)

#### Defined in

[packages/lexical-rich-text/src/index.ts:115](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L115)

## Variables

### DRAG\_DROP\_PASTE

• `Const` **DRAG\_DROP\_PASTE**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`File`[]\>

#### Defined in

[packages/lexical-rich-text/src/index.ts:111](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L111)

## Functions

### $createHeadingNode

▸ **$createHeadingNode**(`headingTag`): [`HeadingNode`](../classes/lexical_rich_text.HeadingNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `headingTag` | [`HeadingTagType`](lexical_rich_text.md#headingtagtype) |

#### Returns

[`HeadingNode`](../classes/lexical_rich_text.HeadingNode.md)

#### Defined in

[packages/lexical-rich-text/src/index.ts:432](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L432)

___

### $createQuoteNode

▸ **$createQuoteNode**(): [`QuoteNode`](../classes/lexical_rich_text.QuoteNode.md)

#### Returns

[`QuoteNode`](../classes/lexical_rich_text.QuoteNode.md)

#### Defined in

[packages/lexical-rich-text/src/index.ts:211](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L211)

___

### $isHeadingNode

▸ **$isHeadingNode**(`node`): node is HeadingNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is HeadingNode

#### Defined in

[packages/lexical-rich-text/src/index.ts:436](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L436)

___

### $isQuoteNode

▸ **$isQuoteNode**(`node`): node is QuoteNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is QuoteNode

#### Defined in

[packages/lexical-rich-text/src/index.ts:215](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L215)

___

### eventFiles

▸ **eventFiles**(`event`): [`boolean`, `File`[], `boolean`]

#### Parameters

| Name | Type |
| :------ | :------ |
| `event` | `DragEvent` \| [`PasteCommandType`](lexical.md#pastecommandtype) |

#### Returns

[`boolean`, `File`[], `boolean`]

#### Defined in

[packages/lexical-rich-text/src/index.ts:486](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L486)

___

### registerRichText

▸ **registerRichText**(`editor`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-rich-text/src/index.ts:549](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L549)
