---
id: "lexical_link"
title: "Module: @lexical/link"
custom_edit_url: null
---

## Classes

- [AutoLinkNode](../classes/lexical_link.AutoLinkNode.md)
- [LinkNode](../classes/lexical_link.LinkNode.md)

## Type Aliases

### AutoLinkAttributes

Ƭ **AutoLinkAttributes**: `Partial`\<[`Spread`](lexical.md#spread)\<[`LinkAttributes`](lexical_link.md#linkattributes), \{ `isUnlinked?`: `boolean`  }\>\>

#### Defined in

[packages/lexical-link/src/index.ts:38](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L38)

___

### LinkAttributes

Ƭ **LinkAttributes**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `rel?` | ``null`` \| `string` |
| `target?` | ``null`` \| `string` |
| `title?` | ``null`` \| `string` |

#### Defined in

[packages/lexical-link/src/index.ts:32](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L32)

___

### SerializedAutoLinkNode

Ƭ **SerializedAutoLinkNode**: [`Spread`](lexical.md#spread)\<\{ `isUnlinked`: `boolean`  }, [`SerializedLinkNode`](lexical_link.md#serializedlinknode)\>

#### Defined in

[packages/lexical-link/src/index.ts:330](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L330)

___

### SerializedLinkNode

Ƭ **SerializedLinkNode**: [`Spread`](lexical.md#spread)\<\{ `url`: `string`  }, [`Spread`](lexical.md#spread)\<[`LinkAttributes`](lexical_link.md#linkattributes), [`SerializedElementNode`](lexical.md#serializedelementnode)\>\>

#### Defined in

[packages/lexical-link/src/index.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L42)

## Variables

### TOGGLE\_LINK\_COMMAND

• `Const` **TOGGLE\_LINK\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`string` \| \{ `url`: `string`  } & [`LinkAttributes`](lexical_link.md#linkattributes) \| ``null``\>

#### Defined in

[packages/lexical-link/src/index.ts:472](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L472)

## Functions

### $createAutoLinkNode

▸ **$createAutoLinkNode**(`url`, `attributes?`): [`AutoLinkNode`](../classes/lexical_link.AutoLinkNode.md)

Takes a URL and creates an AutoLinkNode. AutoLinkNodes are generally automatically generated
during typing, which is especially useful when a button to generate a LinkNode is not practical.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `url` | `string` | The URL the LinkNode should direct to. |
| `attributes?` | `Partial`\<[`Spread`](lexical.md#spread)\<[`LinkAttributes`](lexical_link.md#linkattributes), \{ `isUnlinked?`: `boolean`  }\>\> | Optional HTML a tag attributes. \{ target, rel, title \} |

#### Returns

[`AutoLinkNode`](../classes/lexical_link.AutoLinkNode.md)

The LinkNode.

#### Defined in

[packages/lexical-link/src/index.ts:454](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L454)

___

### $createLinkNode

▸ **$createLinkNode**(`url`, `attributes?`): [`LinkNode`](../classes/lexical_link.LinkNode.md)

Takes a URL and creates a LinkNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `url` | `string` | The URL the LinkNode should direct to. |
| `attributes?` | [`LinkAttributes`](lexical_link.md#linkattributes) | Optional HTML a tag attributes \{ target, rel, title \} |

#### Returns

[`LinkNode`](../classes/lexical_link.LinkNode.md)

The LinkNode.

#### Defined in

[packages/lexical-link/src/index.ts:312](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L312)

___

### $isAutoLinkNode

▸ **$isAutoLinkNode**(`node`): node is AutoLinkNode

Determines if node is an AutoLinkNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to be checked. |

#### Returns

node is AutoLinkNode

true if node is an AutoLinkNode, false otherwise.

#### Defined in

[packages/lexical-link/src/index.ts:466](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L466)

___

### $isLinkNode

▸ **$isLinkNode**(`node`): node is LinkNode

Determines if node is a LinkNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to be checked. |

#### Returns

node is LinkNode

true if node is a LinkNode, false otherwise.

#### Defined in

[packages/lexical-link/src/index.ts:324](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L324)

___

### $toggleLink

▸ **$toggleLink**(`url`, `attributes?`): `void`

Generates or updates a LinkNode. It can also delete a LinkNode if the URL is null,
but saves any children and brings them up to the parent node.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `url` | ``null`` \| `string` | The URL the link directs to. |
| `attributes` | [`LinkAttributes`](lexical_link.md#linkattributes) | Optional HTML a tag attributes. \{ target, rel, title \} |

#### Returns

`void`

#### Defined in

[packages/lexical-link/src/index.ts:482](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L482)

___

### toggleLink

▸ **toggleLink**(`url`, `attributes?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | ``null`` \| `string` |
| `attributes` | [`LinkAttributes`](lexical_link.md#linkattributes) |

#### Returns

`void`

**`Deprecated`**

renamed to [$toggleLink](lexical_link.md#$togglelink) by @lexical/eslint-plugin rules-of-lexical

#### Defined in

[packages/lexical-link/src/index.ts:599](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L599)
