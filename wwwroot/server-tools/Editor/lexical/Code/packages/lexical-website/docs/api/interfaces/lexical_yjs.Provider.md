---
id: "lexical_yjs.Provider"
title: "Interface: Provider"
custom_edit_url: null
---

[@lexical/yjs](../modules/lexical_yjs.md).Provider

## Properties

### awareness

• **awareness**: [`ProviderAwareness`](../modules/lexical_yjs.md#providerawareness)

#### Defined in

[packages/lexical-yjs/src/index.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L37)

## Methods

### connect

▸ **connect**(): `void` \| `Promise`\<`void`\>

#### Returns

`void` \| `Promise`\<`void`\>

#### Defined in

[packages/lexical-yjs/src/index.ts:38](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L38)

___

### disconnect

▸ **disconnect**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L39)

___

### off

▸ **off**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"sync"`` |
| `cb` | (`isSynced`: `boolean`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L40)

▸ **off**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"update"`` |
| `cb` | (`arg0`: `unknown`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L41)

▸ **off**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"status"`` |
| `cb` | (`arg0`: \{ `status`: `string`  }) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L42)

▸ **off**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"reload"`` |
| `cb` | (`doc`: `Doc`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L43)

___

### on

▸ **on**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"sync"`` |
| `cb` | (`isSynced`: `boolean`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L44)

▸ **on**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"status"`` |
| `cb` | (`arg0`: \{ `status`: `string`  }) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L45)

▸ **on**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"update"`` |
| `cb` | (`arg0`: `unknown`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L46)

▸ **on**(`type`, `cb`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"reload"`` |
| `cb` | (`doc`: `Doc`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:47](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L47)
