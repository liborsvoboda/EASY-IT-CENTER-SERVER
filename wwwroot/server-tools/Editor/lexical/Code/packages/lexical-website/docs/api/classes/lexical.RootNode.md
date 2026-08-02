---
id: "lexical.RootNode"
title: "Class: RootNode"
custom_edit_url: null
---

[lexical](../modules/lexical.md).RootNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`RootNode`**

## Constructors

### constructor

• **new RootNode**(): [`RootNode`](lexical.RootNode.md)

#### Returns

[`RootNode`](lexical.RootNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L37)

## Methods

### append

▸ **append**(`...nodesToAppend`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `...nodesToAppend` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`this`

#### Overrides

[ElementNode](lexical.ElementNode.md).[append](lexical.ElementNode.md#append)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L86)

___

### collapseAtStart

▸ **collapseAtStart**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:119](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L119)

___

### exportJSON

▸ **exportJSON**(): [`SerializedRootNode`](../modules/lexical.md#serializedrootnode)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedRootNode`](../modules/lexical.md#serializedrootnode)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:108](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L108)

___

### getTextContent

▸ **getTextContent**(): `string`

Returns the text content of the node. Override this for
custom nodes that should have a representation in plain text
format (for copy + paste, for example)

#### Returns

`string`

#### Overrides

[ElementNode](lexical.ElementNode.md).[getTextContent](lexical.ElementNode.md#gettextcontent)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L49)

___

### getTopLevelElementOrThrow

▸ **getTopLevelElementOrThrow**(): `never`

Returns the highest (in the EditorState tree)
non-root ancestor of this node, or throws if none is found. See [lexical!$isRootOrShadowRoot](../modules/lexical.md#$isrootorshadowroot)
for more information on which Elements comprise "roots".

#### Returns

`never`

#### Overrides

[ElementNode](lexical.ElementNode.md).[getTopLevelElementOrThrow](lexical.ElementNode.md#gettoplevelelementorthrow)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L42)

___

### insertAfter

▸ **insertAfter**(`nodeToInsert`): [`LexicalNode`](lexical.LexicalNode.md)

Inserts a node after this LexicalNode (as the next sibling).

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `nodeToInsert` | [`LexicalNode`](lexical.LexicalNode.md) | The node to insert after this one. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertAfter](lexical.ElementNode.md#insertafter)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L74)

___

### insertBefore

▸ **insertBefore**(`nodeToInsert`): [`LexicalNode`](lexical.LexicalNode.md)

Inserts a node before this LexicalNode (as the previous sibling).

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `nodeToInsert` | [`LexicalNode`](lexical.LexicalNode.md) | The node to insert before this one. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertBefore](lexical.ElementNode.md#insertbefore)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L70)

___

### remove

▸ **remove**(): `never`

Removes this LexicalNode from the EditorState. If the node isn't re-inserted
somewhere, the Lexical garbage collector will eventually clean it up.

#### Returns

`never`

#### Overrides

[ElementNode](lexical.ElementNode.md).[remove](lexical.ElementNode.md#remove)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L62)

___

### replace

▸ **replace**\<`N`\>(`node`): `never`

Replaces this LexicalNode with the provided node, optionally transferring the children
of the replaced node to the replacing node.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `N` | The node to replace this one with. |

#### Returns

`never`

#### Overrides

[ElementNode](lexical.ElementNode.md).[replace](lexical.ElementNode.md#replace)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L66)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `dom`): ``false``

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`RootNode`](lexical.RootNode.md) |
| `dom` | `HTMLElement` |

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L80)

___

### clone

▸ **clone**(): [`RootNode`](lexical.RootNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Returns

[`RootNode`](lexical.RootNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:33](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L33)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Overrides

[ElementNode](lexical.ElementNode.md).[getType](lexical.ElementNode.md#gettype-1)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:29](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L29)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`RootNode`](lexical.RootNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedRootNode`](../modules/lexical.md#serializedrootnode)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\> |

#### Returns

[`RootNode`](lexical.RootNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:99](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L99)
