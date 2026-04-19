---
id: "lexical_markdown"
title: "Module: @lexical/markdown"
custom_edit_url: null
---

## Type Aliases

### ElementTransformer

Ƭ **ElementTransformer**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `dependencies` | [`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\>[] |
| `export` | (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md), `traverseChildren`: (`node`: [`ElementNode`](../classes/lexical.ElementNode.md)) => `string`) => `string` \| ``null`` |
| `regExp` | `RegExp` |
| `replace` | (`parentNode`: [`ElementNode`](../classes/lexical.ElementNode.md), `children`: [`LexicalNode`](../classes/lexical.LexicalNode.md)[], `match`: `string`[], `isImport`: `boolean`) => `void` |
| `type` | ``"element"`` |

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L46)

___

### TextFormatTransformer

Ƭ **TextFormatTransformer**: `Readonly`\<\{ `format`: `ReadonlyArray`\<[`TextFormatType`](lexical.md#textformattype)\> ; `intraword?`: `boolean` ; `tag`: `string` ; `type`: ``"text-format"``  }\>

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L63)

___

### TextMatchTransformer

Ƭ **TextMatchTransformer**: `Readonly`\<\{ `dependencies`: [`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\>[] ; `export`: (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md), `exportChildren`: (`node`: [`ElementNode`](../classes/lexical.ElementNode.md)) => `string`, `exportFormat`: (`node`: [`TextNode`](../classes/lexical.TextNode.md), `textContent`: `string`) => `string`) => `string` \| ``null`` ; `importRegExp`: `RegExp` ; `regExp`: `RegExp` ; `replace`: (`node`: [`TextNode`](../classes/lexical.TextNode.md), `match`: `RegExpMatchArray`) => `void` ; `trigger`: `string` ; `type`: ``"text-match"``  }\>

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L70)

___

### Transformer

Ƭ **Transformer**: [`ElementTransformer`](lexical_markdown.md#elementtransformer) \| [`TextFormatTransformer`](lexical_markdown.md#textformattransformer) \| [`TextMatchTransformer`](lexical_markdown.md#textmatchtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L41)

## Variables

### BOLD\_ITALIC\_STAR

• `Const` **BOLD\_ITALIC\_STAR**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:308](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L308)

___

### BOLD\_ITALIC\_UNDERSCORE

• `Const` **BOLD\_ITALIC\_UNDERSCORE**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:314](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L314)

___

### BOLD\_STAR

• `Const` **BOLD\_STAR**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:321](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L321)

___

### BOLD\_UNDERSCORE

• `Const` **BOLD\_UNDERSCORE**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:327](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L327)

___

### CHECK\_LIST

• `Const` **CHECK\_LIST**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:276](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L276)

___

### CODE

• `Const` **CODE**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:244](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L244)

___

### ELEMENT\_TRANSFORMERS

• `Const` **ELEMENT\_TRANSFORMERS**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)[]

#### Defined in

[packages/lexical-markdown/src/index.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L39)

___

### HEADING

• `Const` **HEADING**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:190](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L190)

___

### HIGHLIGHT

• `Const` **HIGHLIGHT**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:302](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L302)

___

### INLINE\_CODE

• `Const` **INLINE\_CODE**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:296](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L296)

___

### ITALIC\_STAR

• `Const` **ITALIC\_STAR**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:340](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L340)

___

### ITALIC\_UNDERSCORE

• `Const` **ITALIC\_UNDERSCORE**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:346](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L346)

___

### LINK

• `Const` **LINK**: [`TextMatchTransformer`](lexical_markdown.md#textmatchtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:357](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L357)

___

### ORDERED\_LIST

• `Const` **ORDERED\_LIST**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:286](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L286)

___

### QUOTE

• `Const` **QUOTE**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:207](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L207)

___

### STRIKETHROUGH

• `Const` **STRIKETHROUGH**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:334](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L334)

___

### TEXT\_FORMAT\_TRANSFORMERS

• `Const` **TEXT\_FORMAT\_TRANSFORMERS**: [`TextFormatTransformer`](lexical_markdown.md#textformattransformer)[]

#### Defined in

[packages/lexical-markdown/src/index.ts:51](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L51)

___

### TEXT\_MATCH\_TRANSFORMERS

• `Const` **TEXT\_MATCH\_TRANSFORMERS**: [`TextMatchTransformer`](lexical_markdown.md#textmatchtransformer)[]

#### Defined in

[packages/lexical-markdown/src/index.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L63)

___

### TRANSFORMERS

• `Const` **TRANSFORMERS**: [`Transformer`](lexical_markdown.md#transformer)[]

#### Defined in

[packages/lexical-markdown/src/index.ts:65](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L65)

___

### UNORDERED\_LIST

• `Const` **UNORDERED\_LIST**: [`ElementTransformer`](lexical_markdown.md#elementtransformer)

#### Defined in

[packages/lexical-markdown/src/MarkdownTransformers.ts:266](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownTransformers.ts#L266)

## Functions

### $convertFromMarkdownString

▸ **$convertFromMarkdownString**(`markdown`, `transformers?`, `node?`, `shouldPreserveNewLines?`): `void`

Renders markdown from a string. The selection is moved to the start after the operation.

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `markdown` | `string` | `undefined` |
| `transformers` | [`Transformer`](lexical_markdown.md#transformer)[] | `TRANSFORMERS` |
| `node?` | [`ElementNode`](../classes/lexical.ElementNode.md) | `undefined` |
| `shouldPreserveNewLines` | `boolean` | `false` |

#### Returns

`void`

#### Defined in

[packages/lexical-markdown/src/index.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L74)

___

### $convertToMarkdownString

▸ **$convertToMarkdownString**(`transformers?`, `node?`, `shouldPreserveNewLines?`): `string`

Renders string from markdown. The selection is moved to the start after the operation.

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `transformers` | [`Transformer`](lexical_markdown.md#transformer)[] | `TRANSFORMERS` |
| `node?` | [`ElementNode`](../classes/lexical.ElementNode.md) | `undefined` |
| `shouldPreserveNewLines` | `boolean` | `false` |

#### Returns

`string`

#### Defined in

[packages/lexical-markdown/src/index.ts:90](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/index.ts#L90)

___

### registerMarkdownShortcuts

▸ **registerMarkdownShortcuts**(`editor`, `transformers?`): () => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | `undefined` |
| `transformers` | [`Transformer`](lexical_markdown.md#transformer)[] | `TRANSFORMERS` |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-markdown/src/MarkdownShortcuts.ts:323](https://github.com/facebook/lexical/tree/main/packages/lexical-markdown/src/MarkdownShortcuts.ts#L323)
