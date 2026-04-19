---
id: "lexical_hashtag"
title: "Module: @lexical/hashtag"
custom_edit_url: null
---

## Classes

- [HashtagNode](../classes/lexical_hashtag.HashtagNode.md)

## Functions

### $createHashtagNode

▸ **$createHashtagNode**(`text?`): [`HashtagNode`](../classes/lexical_hashtag.HashtagNode.md)

Generates a HashtagNode, which is a string following the format of a # followed by some text, eg. #lexical.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `text` | `string` | `''` | The text used inside the HashtagNode. |

#### Returns

[`HashtagNode`](../classes/lexical_hashtag.HashtagNode.md)

- The HashtagNode with the embedded text.

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L69)

___

### $isHashtagNode

▸ **$isHashtagNode**(`node`): node is HashtagNode

Determines if node is a HashtagNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to be checked. |

#### Returns

node is HashtagNode

true if node is a HashtagNode, false otherwise.

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:78](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L78)
