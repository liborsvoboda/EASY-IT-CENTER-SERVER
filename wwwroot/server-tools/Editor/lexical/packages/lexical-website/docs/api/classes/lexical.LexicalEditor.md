---
id: "lexical.LexicalEditor"
title: "Class: LexicalEditor"
custom_edit_url: null
---

[lexical](../modules/lexical.md).LexicalEditor

## Properties

### constructor

• **constructor**: [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`LexicalEditor`](lexical.LexicalEditor.md)\>

#### Defined in

[packages/lexical/src/LexicalEditor.ts:563](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L563)

___

### version

▪ `Static` **version**: `undefined` \| `string`

The version with build identifiers for this editor (since 0.17.1)

#### Defined in

[packages/lexical/src/LexicalEditor.ts:566](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L566)

## Methods

### blur

▸ **blur**(): `void`

Removes focus from the editor.

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1244](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1244)

___

### dispatchCommand

▸ **dispatchCommand**\<`TCommand`\>(`type`, `payload`): `boolean`

Dispatches a command of the specified type with the specified payload.
This triggers all command listeners (set by [LexicalEditor.registerCommand](lexical.LexicalEditor.md#registercommand))
for this type, passing them the provided payload.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TCommand` | extends [`LexicalCommand`](../modules/lexical.md#lexicalcommand)\<`unknown`\> |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | `TCommand` | the type of command listeners to trigger. |
| `payload` | [`CommandPayloadType`](../modules/lexical.md#commandpayloadtype)\<`TCommand`\> | the data to pass as an argument to the command listeners. |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:998](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L998)

___

### focus

▸ **focus**(`callbackFn?`, `options?`): `void`

Focuses the editor

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackFn?` | () => `void` | A function to run after the editor is focused. |
| `options` | `EditorFocusOptions` | A bag of options |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1200](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1200)

___

### getDecorators

▸ **getDecorators**\<`T`\>(): `Record`\<`string`, `T`\>

Gets a map of all decorators in the editor.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Returns

`Record`\<`string`, `T`\>

A mapping of call decorator keys to their decorated content

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1009](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1009)

___

### getEditorState

▸ **getEditorState**(): [`EditorState`](lexical.EditorState.md)

Gets the active editor state.

#### Returns

[`EditorState`](lexical.EditorState.md)

The editor state

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1101](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1101)

___

### getElementByKey

▸ **getElementByKey**(`key`): ``null`` \| `HTMLElement`

Gets the underlying HTMLElement associated with the LexicalNode for the given key.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `key` | `string` | the key of the LexicalNode. |

#### Returns

``null`` \| `HTMLElement`

the HTMLElement rendered by the LexicalNode associated with the key.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1093](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1093)

___

### getKey

▸ **getKey**(): `string`

Gets the key of the editor

#### Returns

`string`

The editor key

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1027](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1027)

___

### getRootElement

▸ **getRootElement**(): ``null`` \| `HTMLElement`

#### Returns

``null`` \| `HTMLElement`

the current root element of the editor. If you want to register
an event listener, do it via [LexicalEditor.registerRootListener](lexical.LexicalEditor.md#registerrootlistener), since
this reference may not be stable.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1019](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1019)

___

### hasNode

▸ **hasNode**\<`T`\>(`node`): `boolean`

Used to assert that a certain node is registered, usually by plugins to ensure nodes that they
depend on have been registered.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`LexicalNode`](lexical.LexicalNode.md)\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `T` |

#### Returns

`boolean`

True if the editor has registered the provided node type, false otherwise.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:978](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L978)

___

### hasNodes

▸ **hasNodes**\<`T`\>(`nodes`): `boolean`

Used to assert that certain nodes are registered, usually by plugins to ensure nodes that they
depend on have been registered.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`LexicalNode`](lexical.LexicalNode.md)\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | `T`[] |

#### Returns

`boolean`

True if the editor has registered all of the provided node types, false otherwise.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:987](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L987)

___

### isComposing

▸ **isComposing**(): `boolean`

#### Returns

`boolean`

true if the editor is currently in "composition" mode due to receiving input
through an IME, or 3P extension, for example. Returns false otherwise.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:694](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L694)

___

### isEditable

▸ **isEditable**(): `boolean`

Returns true if the editor is editable, false otherwise.

#### Returns

`boolean`

True if the editor is editable, false otherwise.

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1261](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1261)

___

### parseEditorState

▸ **parseEditorState**(`maybeStringifiedEditorState`, `updateFn?`): [`EditorState`](lexical.EditorState.md)

Parses a SerializedEditorState (usually produced by [EditorState.toJSON](lexical.EditorState.md#tojson)) and returns
and EditorState object that can be, for example, passed to [LexicalEditor.setEditorState](lexical.LexicalEditor.md#seteditorstate). Typically,
deserialization from JSON stored in a database uses this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `maybeStringifiedEditorState` | `string` \| [`SerializedEditorState`](../interfaces/lexical.SerializedEditorState.md)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\> |
| `updateFn?` | () => `void` |

#### Returns

[`EditorState`](lexical.EditorState.md)

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1151](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1151)

___

### read

▸ **read**\<`T`\>(`callbackFn`): `T`

Executes a read of the editor's state, with the
editor context available (useful for exporting and read-only DOM
operations). Much like update, but prevents any mutation of the
editor's state. Any pending updates will be flushed immediately before
the read.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callbackFn` | () => `T` | A function that has access to read-only editor state. |

#### Returns

`T`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1170](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1170)

___

### registerCommand

▸ **registerCommand**\<`P`\>(`command`, `listener`, `priority`): () => `void`

Registers a listener that will trigger anytime the provided command
is dispatched, subject to priority. Listeners that run at a higher priority can "intercept"
commands and prevent them from propagating to other handlers by returning true.

Listeners registered at the same priority level will run deterministically in the order of registration.

#### Type parameters

| Name |
| :------ |
| `P` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `command` | [`LexicalCommand`](../modules/lexical.md#lexicalcommand)\<`P`\> | the command that will trigger the callback. |
| `listener` | [`CommandListener`](../modules/lexical.md#commandlistener)\<`P`\> | the function that will execute when the command is dispatched. |
| `priority` | [`CommandListenerPriority`](../modules/lexical.md#commandlistenerpriority) | the relative priority of the listener. 0 \| 1 \| 2 \| 3 \| 4 |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:790](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L790)

___

### registerDecoratorListener

▸ **registerDecoratorListener**\<`T`\>(`listener`): () => `void`

Registers a listener for when the editor's decorator object changes. The decorator object contains
all DecoratorNode keys -> their decorated value. This is primarily used with external UI frameworks.

Will trigger the provided callback each time the editor transitions between these states until the
teardown function is called.

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | `DecoratorListener`\<`T`\> |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:734](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L734)

___

### registerEditableListener

▸ **registerEditableListener**(`listener`): () => `void`

Registers a listener for for when the editor changes between editable and non-editable states.
Will trigger the provided callback each time the editor transitions between these states until the
teardown function is called.

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | [`EditableListener`](../modules/lexical.md#editablelistener) |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:718](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L718)

___

### registerMutationListener

▸ **registerMutationListener**(`klass`, `listener`, `options?`): () => `void`

Registers a listener that will run when a Lexical node of the provided class is
mutated. The listener will receive a list of nodes along with the type of mutation
that was performed on each: created, destroyed, or updated.

One common use case for this is to attach DOM event listeners to the underlying DOM nodes as Lexical nodes are created.
[LexicalEditor.getElementByKey](lexical.LexicalEditor.md#getelementbykey) can be used for this.

If any existing nodes are in the DOM, and skipInitialization is not true, the listener
will be called immediately with an updateTag of 'registerMutationListener' where all
nodes have the 'created' NodeMutation. This can be controlled with the skipInitialization option
(default is currently true for backwards compatibility in 0.16.x but will change to false in 0.17.0).

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `klass` | [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`LexicalNode`](lexical.LexicalNode.md)\> | The class of the node that you want to listen to mutations on. |
| `listener` | [`MutationListener`](../modules/lexical.md#mutationlistener) | The logic you want to run when the node is mutated. |
| `options?` | `MutationListenerOptions` | see MutationListenerOptions |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:854](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L854)

___

### registerNodeTransform

▸ **registerNodeTransform**\<`T`\>(`klass`, `listener`): () => `void`

Registers a listener that will run when a Lexical node of the provided class is
marked dirty during an update. The listener will continue to run as long as the node
is marked dirty. There are no guarantees around the order of transform execution!

Watch out for infinite loops. See [Node Transforms](https://lexical.dev/docs/concepts/transforms)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `klass` | [`Klass`](../modules/lexical.md#klass)\<`T`\> | The class of the node that you want to run transforms on. |
| `listener` | [`Transform`](../modules/lexical.md#transform)\<`T`\> | The logic you want to run when the node is updated. |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:949](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L949)

___

### registerRootListener

▸ **registerRootListener**(`listener`): () => `void`

Registers a listener for when the editor's root DOM element (the content editable
Lexical attaches to) changes. This is primarily used to attach event listeners to the root
 element. The root listener function is executed directly upon registration and then on
any subsequent update.

Will trigger the provided callback each time the editor transitions between these states until the
teardown function is called.

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | `RootListener` |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:769](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L769)

___

### registerTextContentListener

▸ **registerTextContentListener**(`listener`): () => `void`

Registers a listener for when Lexical commits an update to the DOM and the text content of
the editor changes from the previous state of the editor. If the text content is the
same between updates, no notifications to the listeners will happen.

Will trigger the provided callback each time the editor transitions between these states until the
teardown function is called.

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | `TextContentListener` |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:751](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L751)

___

### registerUpdateListener

▸ **registerUpdateListener**(`listener`): () => `void`

Registers a listener for Editor update event. Will trigger the provided callback
each time the editor goes through an update (via [LexicalEditor.update](lexical.LexicalEditor.md#update)) until the
teardown function is called.

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | `UpdateListener` |

#### Returns

`fn`

a teardown function that can be used to cleanup the listener.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:704](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L704)

___

### setEditable

▸ **setEditable**(`editable`): `void`

Sets the editable property of the editor. When false, the
editor will not listen for user events on the underling contenteditable.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editable` | `boolean` | the value to set the editable mode to. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1269](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1269)

___

### setEditorState

▸ **setEditorState**(`editorState`, `options?`): `void`

Imperatively set the EditorState. Triggers reconciliation like an update.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editorState` | [`EditorState`](lexical.EditorState.md) | the state to set the editor |
| `options?` | [`EditorSetOptions`](../modules/lexical.md#editorsetoptions) | options for the update. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1110](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1110)

___

### setRootElement

▸ **setRootElement**(`nextRootElement`): `void`

Imperatively set the root contenteditable element that Lexical listens
for events on.

#### Parameters

| Name | Type |
| :------ | :------ |
| `nextRootElement` | ``null`` \| `HTMLElement` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1035](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1035)

___

### toJSON

▸ **toJSON**(): [`SerializedEditor`](../modules/lexical.md#serializededitor)

Returns a JSON-serializable javascript object NOT a JSON string.
You still must call JSON.stringify (or something else) to turn the
state into a string you can transfer over the wire and store in a database.

See [LexicalNode.exportJSON](lexical.LexicalNode.md#exportjson)

#### Returns

[`SerializedEditor`](../modules/lexical.md#serializededitor)

A JSON-serializable javascript object

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1284](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1284)

___

### update

▸ **update**(`updateFn`, `options?`): `void`

Executes an update to the editor state. The updateFn callback is the ONLY place
where Lexical editor state can be safely mutated.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `updateFn` | () => `void` | A function that has access to writable editor state. |
| `options?` | [`EditorUpdateOptions`](../modules/lexical.md#editorupdateoptions) | A bag of options to control the behavior of the update. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:1189](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L1189)
