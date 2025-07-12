---
id: "lexical_code"
title: "Module: @lexical/code"
custom_edit_url: null
---

## Classes

- [CodeHighlightNode](../classes/lexical_code.CodeHighlightNode.md)
- [CodeNode](../classes/lexical_code.CodeNode.md)

## Type Aliases

### SerializedCodeNode

Ƭ **SerializedCodeNode**: [`Spread`](lexical.md#spread)\<\{ `language`: `string` \| ``null`` \| `undefined`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-code/src/CodeNode.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L44)

## Variables

### CODE\_LANGUAGE\_FRIENDLY\_NAME\_MAP

• `Const` **CODE\_LANGUAGE\_FRIENDLY\_NAME\_MAP**: `Record`\<`string`, `string`\>

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L44)

___

### CODE\_LANGUAGE\_MAP

• `Const` **CODE\_LANGUAGE\_MAP**: `Record`\<`string`, `string`\>

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L64)

___

### DEFAULT\_CODE\_LANGUAGE

• `Const` **DEFAULT\_CODE\_LANGUAGE**: ``"javascript"``

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:35](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L35)

___

### PrismTokenizer

• `Const` **PrismTokenizer**: `Tokenizer`

#### Defined in

[packages/lexical-code/src/CodeHighlighter.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlighter.ts#L69)

## Functions

### $createCodeHighlightNode

▸ **$createCodeHighlightNode**(`text`, `highlightType?`): [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |
| `highlightType?` | ``null`` \| `string` |

#### Returns

[`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md)

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:214](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L214)

___

### $createCodeNode

▸ **$createCodeNode**(`language?`): [`CodeNode`](../classes/lexical_code.CodeNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `language?` | ``null`` \| `string` |

#### Returns

[`CodeNode`](../classes/lexical_code.CodeNode.md)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:343](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L343)

___

### $isCodeHighlightNode

▸ **$isCodeHighlightNode**(`node`): node is CodeHighlightNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) |

#### Returns

node is CodeHighlightNode

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:221](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L221)

___

### $isCodeNode

▸ **$isCodeNode**(`node`): node is CodeNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is CodeNode

#### Defined in

[packages/lexical-code/src/CodeNode.ts:349](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L349)

___

### getCodeLanguages

▸ **getCodeLanguages**(): `string`[]

#### Returns

`string`[]

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L86)

___

### getDefaultCodeLanguage

▸ **getDefaultCodeLanguage**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:84](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L84)

___

### getEndOfCodeInLine

▸ **getEndOfCodeInLine**(`anchor`): [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchor` | [`TabNode`](../classes/lexical.TabNode.md) \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) |

#### Returns

[`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md)

#### Defined in

[packages/lexical-code/src/CodeHighlighter.ts:193](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlighter.ts#L193)

___

### getFirstCodeNodeOfLine

▸ **getFirstCodeNodeOfLine**(`anchor`): ``null`` \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchor` | [`LineBreakNode`](../classes/lexical.LineBreakNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) |

#### Returns

``null`` \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:227](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L227)

___

### getLanguageFriendlyName

▸ **getLanguageFriendlyName**(`lang`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `lang` | `string` |

#### Returns

`string`

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:79](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L79)

___

### getLastCodeNodeOfLine

▸ **getLastCodeNodeOfLine**(`anchor`): [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchor` | [`LineBreakNode`](../classes/lexical.LineBreakNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) |

#### Returns

[`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:239](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L239)

___

### getStartOfCodeInLine

▸ **getStartOfCodeInLine**(`anchor`, `offset`): ``null`` \| \{ `node`: [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md) ; `offset`: `number`  }

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchor` | [`TabNode`](../classes/lexical.TabNode.md) \| [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) |
| `offset` | `number` |

#### Returns

``null`` \| \{ `node`: [`CodeHighlightNode`](../classes/lexical_code.CodeHighlightNode.md) \| [`TabNode`](../classes/lexical.TabNode.md) \| [`LineBreakNode`](../classes/lexical.LineBreakNode.md) ; `offset`: `number`  }

#### Defined in

[packages/lexical-code/src/CodeHighlighter.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlighter.ts#L80)

___

### normalizeCodeLang

▸ **normalizeCodeLang**(`lang`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `lang` | `string` |

#### Returns

`string`

#### Defined in

[packages/lexical-code/src/CodeHighlightNode.ts:75](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlightNode.ts#L75)

___

### registerCodeHighlighting

▸ **registerCodeHighlighting**(`editor`, `tokenizer?`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `tokenizer?` | `Tokenizer` |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-code/src/CodeHighlighter.ts:806](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeHighlighter.ts#L806)
