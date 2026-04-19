---
id: "lexical.TabNode"
title: "Class: TabNode"
custom_edit_url: null
---

[lexical](../modules/lexical.md).TabNode

## Hierarchy

- [`TextNode`](lexical.TextNode.md)

  ↳ **`TabNode`**

## Constructors

### constructor

• **new TabNode**(`key?`): [`TabNode`](lexical.TabNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`TabNode`](lexical.TabNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[constructor](lexical.TextNode.md#constructor)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L40)

## Methods

### canInsertTextAfter

▸ **canInsertTextAfter**(): `boolean`

This method is meant to be overriden by TextNode subclasses to control the behavior of those nodes
when a user event would cause text to be inserted after them in the editor. If true, Lexical will attempt
to insert text into this node. If false, it will insert the text in a new sibling node.

#### Returns

`boolean`

true if text can be inserted after the node, false otherwise.

#### Overrides

[TextNode](lexical.TextNode.md).[canInsertTextAfter](lexical.TextNode.md#caninserttextafter)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L80)

___

### canInsertTextBefore

▸ **canInsertTextBefore**(): `boolean`

This method is meant to be overriden by TextNode subclasses to control the behavior of those nodes
when a user event would cause text to be inserted before them in the editor. If true, Lexical will attempt
to insert text into this node. If false, it will insert the text in a new sibling node.

#### Returns

`boolean`

true if text can be inserted before the node, false otherwise.

#### Overrides

[TextNode](lexical.TextNode.md).[canInsertTextBefore](lexical.TextNode.md#caninserttextbefore)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:76](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L76)

___

### exportJSON

▸ **exportJSON**(): [`SerializedTextNode`](../modules/lexical.md#serializedtextnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedTextNode`](../modules/lexical.md#serializedtextnode)

#### Overrides

[TextNode](lexical.TextNode.md).[exportJSON](lexical.TextNode.md#exportjson)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:56](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L56)

___

### setDetail

▸ **setDetail**(`_detail`): `this`

Sets the node detail to the provided TextDetailType or 32-bit integer. Note that the TextDetailType
version of the argument can only specify one detail value and doing so will remove all other detail values that
may be applied to the node. For toggling behavior, consider using [TextNode.toggleDirectionless](lexical.TextNode.md#toggledirectionless)
or [TextNode.toggleUnmergeable](lexical.TextNode.md#toggleunmergeable)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `_detail` | `number` \| `TextDetailType` | TextDetailType or 32-bit integer representing the node detail. |

#### Returns

`this`

this TextNode.
// TODO 0.12 This should just be a `string`.

#### Overrides

[TextNode](lexical.TextNode.md).[setDetail](lexical.TextNode.md#setdetail)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:68](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L68)

___

### setMode

▸ **setMode**(`_type`): `this`

Sets the mode of the node.

#### Parameters

| Name | Type |
| :------ | :------ |
| `_type` | [`TextModeType`](../modules/lexical.md#textmodetype) |

#### Returns

`this`

this TextNode.

#### Overrides

[TextNode](lexical.TextNode.md).[setMode](lexical.TextNode.md#setmode)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L72)

___

### setTextContent

▸ **setTextContent**(`_text`): `this`

Sets the text content of the node.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `_text` | `string` | the string to set as the text value of the node. |

#### Returns

`this`

this TextNode.

#### Overrides

[TextNode](lexical.TextNode.md).[setTextContent](lexical.TextNode.md#settextcontent)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L64)

___

### clone

▸ **clone**(`node`): [`TabNode`](lexical.TabNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`TabNode`](lexical.TabNode.md) |

#### Returns

[`TabNode`](lexical.TabNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[clone](lexical.TextNode.md#clone)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:31](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L31)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Overrides

[TextNode](lexical.TextNode.md).[getType](lexical.TextNode.md#gettype-1)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:27](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L27)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

[TextNode](lexical.TextNode.md).[importDOM](lexical.TextNode.md#importdom)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L45)

___

### importJSON

▸ **importJSON**(`serializedTabNode`): [`TabNode`](lexical.TabNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedTabNode` | [`SerializedTextNode`](../modules/lexical.md#serializedtextnode) |

#### Returns

[`TabNode`](lexical.TabNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[importJSON](lexical.TextNode.md#importjson)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L49)
