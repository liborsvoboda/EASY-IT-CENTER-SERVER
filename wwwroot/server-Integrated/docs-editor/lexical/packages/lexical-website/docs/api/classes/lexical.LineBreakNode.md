---
id: "lexical.LineBreakNode"
title: "Class: LineBreakNode"
custom_edit_url: null
---

[lexical](../modules/lexical.md).LineBreakNode

## Hierarchy

- [`LexicalNode`](lexical.LexicalNode.md)

  ↳ **`LineBreakNode`**

## Constructors

### constructor

• **new LineBreakNode**(`key?`): [`LineBreakNode`](lexical.LineBreakNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`LineBreakNode`](lexical.LineBreakNode.md)

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[constructor](lexical.LexicalNode.md#constructor)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:34](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L34)

## Properties

### constructor

• **constructor**: [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`LineBreakNode`](lexical.LineBreakNode.md)\>

#### Overrides

LexicalNode.constructor

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:25](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L25)

## Methods

### createDOM

▸ **createDOM**(): `HTMLElement`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Returns

`HTMLElement`

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[createDOM](lexical.LexicalNode.md#createdom)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L42)

___

### exportJSON

▸ **exportJSON**(): [`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[exportJSON](lexical.LexicalNode.md#exportjson)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L70)

___

### getTextContent

▸ **getTextContent**(): ``"\n"``

Returns the text content of the node. Override this for
custom nodes that should have a representation in plain text
format (for copy + paste, for example)

#### Returns

``"\n"``

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[getTextContent](lexical.LexicalNode.md#gettextcontent)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:38](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L38)

___

### updateDOM

▸ **updateDOM**(): ``false``

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Returns

``false``

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[updateDOM](lexical.LexicalNode.md#updatedom)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L46)

___

### clone

▸ **clone**(`node`): [`LineBreakNode`](lexical.LineBreakNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LineBreakNode`](lexical.LineBreakNode.md) |

#### Returns

[`LineBreakNode`](lexical.LineBreakNode.md)

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[clone](lexical.LexicalNode.md#clone)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:30](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L30)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[getType](lexical.LexicalNode.md#gettype-1)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:26](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L26)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

LexicalNode.importDOM

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:50](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L50)

___

### importJSON

▸ **importJSON**(`serializedLineBreakNode`): [`LineBreakNode`](lexical.LineBreakNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedLineBreakNode` | [`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode) |

#### Returns

[`LineBreakNode`](lexical.LineBreakNode.md)

#### Overrides

[LexicalNode](lexical.LexicalNode.md).[importJSON](lexical.LexicalNode.md#importjson)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L64)
