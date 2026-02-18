---
id: "lexical_yjs"
title: "Module: @lexical/yjs"
custom_edit_url: null
---

## Interfaces

- [Provider](../interfaces/lexical_yjs.Provider.md)

## Type Aliases

### Binding

Ƭ **Binding**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `clientID` | `number` |
| `collabNodeMap` | `Map`\<[`NodeKey`](lexical.md#nodekey), `CollabElementNode` \| `CollabTextNode` \| `CollabDecoratorNode` \| `CollabLineBreakNode`\> |
| `cursors` | `Map`\<[`ClientID`](lexical_yjs.md#clientid), `Cursor`\> |
| `cursorsContainer` | ``null`` \| `HTMLElement` |
| `doc` | `Doc` |
| `docMap` | `Map`\<`string`, `Doc`\> |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `excludedProperties` | [`ExcludedProperties`](lexical_yjs.md#excludedproperties) |
| `id` | `string` |
| `nodeProperties` | `Map`\<`string`, `string`[]\> |
| `root` | `CollabElementNode` |

#### Defined in

[packages/lexical-yjs/src/Bindings.ts:25](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/Bindings.ts#L25)

___

### ClientID

Ƭ **ClientID**: `number`

#### Defined in

[packages/lexical-yjs/src/Bindings.ts:24](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/Bindings.ts#L24)

___

### Delta

Ƭ **Delta**: [`Operation`](lexical_yjs.md#operation)[]

#### Defined in

[packages/lexical-yjs/src/index.ts:55](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L55)

___

### ExcludedProperties

Ƭ **ExcludedProperties**: `Map`\<[`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\>, `Set`\<`string`\>\>

#### Defined in

[packages/lexical-yjs/src/Bindings.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/Bindings.ts#L44)

___

### Operation

Ƭ **Operation**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `attributes` | \{ `__type`: `string`  } |
| `attributes.__type` | `string` |
| `insert` | `string` \| `Record`\<`string`, `unknown`\> |

#### Defined in

[packages/lexical-yjs/src/index.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L49)

___

### ProviderAwareness

Ƭ **ProviderAwareness**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `getLocalState` | () => [`UserState`](lexical_yjs.md#userstate) \| ``null`` |
| `getStates` | () => `Map`\<`number`, [`UserState`](lexical_yjs.md#userstate)\> |
| `off` | (`type`: ``"update"``, `cb`: () => `void`) => `void` |
| `on` | (`type`: ``"update"``, `cb`: () => `void`) => `void` |
| `setLocalState` | (`arg0`: [`UserState`](lexical_yjs.md#userstate)) => `void` |

#### Defined in

[packages/lexical-yjs/src/index.ts:29](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L29)

___

### UserState

Ƭ **UserState**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `anchorPos` | ``null`` \| `RelativePosition` |
| `awarenessData` | `object` |
| `color` | `string` |
| `focusPos` | ``null`` \| `RelativePosition` |
| `focusing` | `boolean` |
| `name` | `string` |

#### Defined in

[packages/lexical-yjs/src/index.ts:16](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L16)

___

### YjsEvent

Ƭ **YjsEvent**: `Record`\<`string`, `unknown`\>

#### Defined in

[packages/lexical-yjs/src/index.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L57)

___

### YjsNode

Ƭ **YjsNode**: `Record`\<`string`, `unknown`\>

#### Defined in

[packages/lexical-yjs/src/index.ts:56](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L56)

## Variables

### CONNECTED\_COMMAND

• `Const` **CONNECTED\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical-yjs/src/index.ts:24](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L24)

___

### TOGGLE\_CONNECT\_COMMAND

• `Const` **TOGGLE\_CONNECT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical-yjs/src/index.ts:26](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L26)

## Functions

### createBinding

▸ **createBinding**(`editor`, `provider`, `id`, `doc`, `docMap`, `excludedProperties?`): [`Binding`](lexical_yjs.md#binding)

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |
| `id` | `string` |
| `doc` | `undefined` \| ``null`` \| `Doc` |
| `docMap` | `Map`\<`string`, `Doc`\> |
| `excludedProperties?` | [`ExcludedProperties`](lexical_yjs.md#excludedproperties) |

#### Returns

[`Binding`](lexical_yjs.md#binding)

#### Defined in

[packages/lexical-yjs/src/Bindings.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/Bindings.ts#L46)

___

### createUndoManager

▸ **createUndoManager**(`binding`, `root`): `UndoManager`

#### Parameters

| Name | Type |
| :------ | :------ |
| `binding` | [`Binding`](lexical_yjs.md#binding) |
| `root` | `YXmlText` |

#### Returns

`UndoManager`

#### Defined in

[packages/lexical-yjs/src/index.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L62)

___

### initLocalState

▸ **initLocalState**(`provider`, `name`, `color`, `focusing`, `awarenessData`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |
| `name` | `string` |
| `color` | `string` |
| `focusing` | `boolean` |
| `awarenessData` | `object` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:71](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L71)

___

### setLocalStateFocus

▸ **setLocalStateFocus**(`provider`, `name`, `color`, `focusing`, `awarenessData`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |
| `name` | `string` |
| `color` | `string` |
| `focusing` | `boolean` |
| `awarenessData` | `object` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/index.ts:88](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/index.ts#L88)

___

### syncCursorPositions

▸ **syncCursorPositions**(`binding`, `provider`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `binding` | [`Binding`](lexical_yjs.md#binding) |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/SyncCursors.ts:399](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/SyncCursors.ts#L399)

___

### syncLexicalUpdateToYjs

▸ **syncLexicalUpdateToYjs**(`binding`, `provider`, `prevEditorState`, `currEditorState`, `dirtyElements`, `dirtyLeaves`, `normalizedNodes`, `tags`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `binding` | [`Binding`](lexical_yjs.md#binding) |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |
| `prevEditorState` | [`EditorState`](../classes/lexical.EditorState.md) |
| `currEditorState` | [`EditorState`](../classes/lexical.EditorState.md) |
| `dirtyElements` | `Map`\<`string`, `boolean`\> |
| `dirtyLeaves` | `Set`\<`string`\> |
| `normalizedNodes` | `Set`\<`string`\> |
| `tags` | `Set`\<`string`\> |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/SyncEditorStates.ts:194](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/SyncEditorStates.ts#L194)

___

### syncYjsChangesToLexical

▸ **syncYjsChangesToLexical**(`binding`, `provider`, `events`, `isFromUndoManger`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `binding` | [`Binding`](lexical_yjs.md#binding) |
| `provider` | [`Provider`](../interfaces/lexical_yjs.Provider.md) |
| `events` | `YEvent`\<`YText`\>[] |
| `isFromUndoManger` | `boolean` |

#### Returns

`void`

#### Defined in

[packages/lexical-yjs/src/SyncEditorStates.ts:81](https://github.com/facebook/lexical/tree/main/packages/lexical-yjs/src/SyncEditorStates.ts#L81)
