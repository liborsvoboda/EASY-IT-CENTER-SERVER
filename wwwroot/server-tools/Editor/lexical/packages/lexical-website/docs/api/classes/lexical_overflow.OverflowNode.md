---
id: "lexical_overflow.OverflowNode"
title: "Class: OverflowNode"
custom_edit_url: null
---

[@lexical/overflow](../modules/lexical_overflow.md).OverflowNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`OverflowNode`**

## Constructors

### constructor

• **new OverflowNode**(`key?`): [`OverflowNode`](lexical_overflow.OverflowNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`OverflowNode`](lexical_overflow.OverflowNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-overflow/src/index.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L39)

## Methods

### createDOM

▸ **createDOM**(`config`): `HTMLElement`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) | allows access to things like the EditorTheme (to apply classes) during reconciliation. |

#### Returns

`HTMLElement`

#### Overrides

[ElementNode](lexical.ElementNode.md).[createDOM](lexical.ElementNode.md#createdom)

#### Defined in

[packages/lexical-overflow/src/index.ts:51](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L51)

___

### excludeFromCopy

▸ **excludeFromCopy**(): `boolean`

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[excludeFromCopy](lexical.ElementNode.md#excludefromcopy)

#### Defined in

[packages/lexical-overflow/src/index.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L72)

___

### exportJSON

▸ **exportJSON**(): [`SerializedElementNode`](../modules/lexical.md#serializedelementnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedElementNode`](../modules/lexical.md#serializedelementnode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-overflow/src/index.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L44)

___

### insertNewAfter

▸ **insertNewAfter**(`selection`, `restoreSelection?`): ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

``null`` \| [`LexicalNode`](lexical.LexicalNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-overflow/src/index.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L64)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `dom`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`OverflowNode`](lexical_overflow.OverflowNode.md) |
| `dom` | `HTMLElement` |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-overflow/src/index.ts:60](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L60)

___

### clone

▸ **clone**(`node`): [`OverflowNode`](lexical_overflow.OverflowNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`OverflowNode`](lexical_overflow.OverflowNode.md) |

#### Returns

[`OverflowNode`](lexical_overflow.OverflowNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-overflow/src/index.ts:27](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L27)

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

[packages/lexical-overflow/src/index.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L23)

___

### importDOM

▸ **importDOM**(): ``null``

#### Returns

``null``

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-overflow/src/index.ts:35](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L35)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`OverflowNode`](lexical_overflow.OverflowNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedOverflowNode`](../modules/lexical_overflow.md#serializedoverflownode) |

#### Returns

[`OverflowNode`](lexical_overflow.OverflowNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-overflow/src/index.ts:31](https://github.com/facebook/lexical/tree/main/packages/lexical-overflow/src/index.ts#L31)
