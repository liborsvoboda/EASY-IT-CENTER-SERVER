---
id: "lexical.NodeSelection"
title: "Class: NodeSelection"
custom_edit_url: null
---

[lexical](../modules/lexical.md).NodeSelection

## Implements

- [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

## Constructors

### constructor

• **new NodeSelection**(`objects`): [`NodeSelection`](lexical.NodeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `objects` | `Set`\<`string`\> |

#### Returns

[`NodeSelection`](lexical.NodeSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:272](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L272)

## Properties

### \_cachedNodes

• **\_cachedNodes**: ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[_cachedNodes](../interfaces/lexical.BaseSelection.md#_cachednodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:269](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L269)

___

### \_nodes

• **\_nodes**: `Set`\<`string`\>

#### Defined in

[packages/lexical/src/LexicalSelection.ts:268](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L268)

___

### dirty

• **dirty**: `boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[dirty](../interfaces/lexical.BaseSelection.md#dirty)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:270](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L270)

## Methods

### add

▸ **add**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:307](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L307)

___

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:319](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L319)

___

### clone

▸ **clone**(): [`NodeSelection`](lexical.NodeSelection.md)

#### Returns

[`NodeSelection`](lexical.NodeSelection.md)

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[clone](../interfaces/lexical.BaseSelection.md#clone)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:329](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L329)

___

### delete

▸ **delete**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:313](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L313)

___

### extract

▸ **extract**(): [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[extract](../interfaces/lexical.BaseSelection.md#extract)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:333](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L333)

___

### getCachedNodes

▸ **getCachedNodes**(): ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getCachedNodes](../interfaces/lexical.BaseSelection.md#getcachednodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:278](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L278)

___

### getNodes

▸ **getNodes**(): [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getNodes](../interfaces/lexical.BaseSelection.md#getnodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:364](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L364)

___

### getStartEndPoints

▸ **getStartEndPoints**(): ``null``

#### Returns

``null``

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getStartEndPoints](../interfaces/lexical.BaseSelection.md#getstartendpoints)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:303](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L303)

___

### getTextContent

▸ **getTextContent**(): `string`

#### Returns

`string`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getTextContent](../interfaces/lexical.BaseSelection.md#gettextcontent)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:383](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L383)

___

### has

▸ **has**(`key`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:325](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L325)

___

### insertNodes

▸ **insertNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertNodes](../interfaces/lexical.BaseSelection.md#insertnodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:345](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L345)

___

### insertRawText

▸ **insertRawText**(`text`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertRawText](../interfaces/lexical.BaseSelection.md#insertrawtext)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:337](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L337)

___

### insertText

▸ **insertText**(): `void`

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertText](../interfaces/lexical.BaseSelection.md#inserttext)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:341](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L341)

___

### is

▸ **is**(`selection`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

`boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[is](../interfaces/lexical.BaseSelection.md#is)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:286](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L286)

___

### isBackward

▸ **isBackward**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[isBackward](../interfaces/lexical.BaseSelection.md#isbackward)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:299](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L299)

___

### isCollapsed

▸ **isCollapsed**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[isCollapsed](../interfaces/lexical.BaseSelection.md#iscollapsed)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:295](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L295)

___

### setCachedNodes

▸ **setCachedNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[setCachedNodes](../interfaces/lexical.BaseSelection.md#setcachednodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:282](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L282)
