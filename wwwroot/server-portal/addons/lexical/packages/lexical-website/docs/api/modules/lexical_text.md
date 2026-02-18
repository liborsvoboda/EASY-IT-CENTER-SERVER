---
id: "lexical_text"
title: "Module: @lexical/text"
custom_edit_url: null
---

## Type Aliases

### EntityMatch

Ƭ **EntityMatch**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `end` | `number` |
| `start` | `number` |

#### Defined in

[packages/lexical-text/src/registerLexicalTextEntity.ts:19](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/registerLexicalTextEntity.ts#L19)

___

### TextNodeWithOffset

Ƭ **TextNodeWithOffset**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `node` | [`TextNode`](../classes/lexical.TextNode.md) |
| `offset` | `number` |

#### Defined in

[packages/lexical-text/src/index.ts:11](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/index.ts#L11)

## Functions

### $canShowPlaceholder

▸ **$canShowPlaceholder**(`isComposing`): `boolean`

Determines if the input should show the placeholder. If anything is in
in the root the placeholder should not be shown.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isComposing` | `boolean` | Is the editor in composition mode due to an active Input Method Editor? |

#### Returns

`boolean`

true if the input should show the placeholder, false otherwise.

#### Defined in

[packages/lexical-text/src/canShowPlaceholder.ts:24](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/canShowPlaceholder.ts#L24)

___

### $canShowPlaceholderCurry

▸ **$canShowPlaceholderCurry**(`isEditorComposing`): () => `boolean`

Returns a function that executes [$canShowPlaceholder](lexical_text.md#$canshowplaceholder)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isEditorComposing` | `boolean` | Is the editor in composition mode due to an active Input Method Editor? |

#### Returns

`fn`

A function that executes $canShowPlaceholder with arguments.

▸ (): `boolean`

##### Returns

`boolean`

#### Defined in

[packages/lexical-text/src/canShowPlaceholder.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/canShowPlaceholder.ts#L74)

___

### $findTextIntersectionFromCharacters

▸ **$findTextIntersectionFromCharacters**(`root`, `targetCharacters`): ``null`` \| \{ `node`: [`TextNode`](../classes/lexical.TextNode.md) ; `offset`: `number`  }

Finds a TextNode with a size larger than targetCharacters and returns
the node along with the remaining length of the text.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `root` | [`RootNode`](../classes/lexical.RootNode.md) | The RootNode. |
| `targetCharacters` | `number` | The number of characters whose TextNode must be larger than. |

#### Returns

``null`` \| \{ `node`: [`TextNode`](../classes/lexical.TextNode.md) ; `offset`: `number`  }

The TextNode and the intersections offset, or null if no TextNode is found.

#### Defined in

[packages/lexical-text/src/findTextIntersectionFromCharacters.ts:17](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/findTextIntersectionFromCharacters.ts#L17)

___

### $isRootTextContentEmpty

▸ **$isRootTextContentEmpty**(`isEditorComposing`, `trim?`): `boolean`

Determines if the root has any text content and can trim any whitespace if it does.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `isEditorComposing` | `boolean` | `undefined` | Is the editor in composition mode due to an active Input Method Editor? |
| `trim` | `boolean` | `true` | Should the root text have its whitespaced trimmed? Defaults to true. |

#### Returns

`boolean`

true if text content is empty, false if there is text or isEditorComposing is true.

#### Defined in

[packages/lexical-text/src/isRootTextContentEmpty.ts:16](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/isRootTextContentEmpty.ts#L16)

___

### $isRootTextContentEmptyCurry

▸ **$isRootTextContentEmptyCurry**(`isEditorComposing`, `trim?`): () => `boolean`

Returns a function that executes [$isRootTextContentEmpty](lexical_text.md#$isroottextcontentempty)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isEditorComposing` | `boolean` | Is the editor in composition mode due to an active Input Method Editor? |
| `trim?` | `boolean` | Should the root text have its whitespaced trimmed? Defaults to true. |

#### Returns

`fn`

A function that executes $isRootTextContentEmpty based on arguments.

▸ (): `boolean`

##### Returns

`boolean`

#### Defined in

[packages/lexical-text/src/isRootTextContentEmpty.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/isRootTextContentEmpty.ts#L39)

___

### $rootTextContent

▸ **$rootTextContent**(): `string`

Returns the root's text content.

#### Returns

`string`

The root's text content.

#### Defined in

[packages/lexical-text/src/rootTextContent.ts:14](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/rootTextContent.ts#L14)

___

### registerLexicalTextEntity

▸ **registerLexicalTextEntity**\<`T`\>(`editor`, `getMatch`, `targetNode`, `createNode`): () => `void`[]

Returns a tuple that can be rested (...) into mergeRegister to clean up
node transforms listeners that transforms text into another node, eg. a HashtagNode.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`TextNode`](../classes/lexical.TextNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `getMatch` | (`text`: `string`) => ``null`` \| [`EntityMatch`](lexical_text.md#entitymatch) | Finds a matching string that satisfies a regex expression. |
| `targetNode` | [`Klass`](lexical.md#klass)\<`T`\> | The node type that contains text to match with. eg. HashtagNode |
| `createNode` | (`textNode`: [`TextNode`](../classes/lexical.TextNode.md)) => `T` | A function that creates a new node to contain the matched text. eg createHashtagNode |

#### Returns

() => `void`[]

An array containing the plain text and reverse node transform listeners.

**`Example`**

```ts
  useEffect(() => {
   return mergeRegister(
     ...registerLexicalTextEntity(editor, getMatch, targetNode, createNode),
   );
 }, [createNode, editor, getMatch, targetNode]);
```
Where targetNode is the type of node containing the text you want to transform (like a text input),
then getMatch uses a regex to find a matching text and creates the proper node to include the matching text.

#### Defined in

[packages/lexical-text/src/registerLexicalTextEntity.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-text/src/registerLexicalTextEntity.ts#L40)
