---
id: "lexical_hashtag.HashtagNode"
title: "Class: HashtagNode"
custom_edit_url: null
---

[@lexical/hashtag](../modules/lexical_hashtag.md).HashtagNode

## Hierarchy

- [`TextNode`](lexical.TextNode.md)

  ↳ **`HashtagNode`**

## Constructors

### constructor

• **new HashtagNode**(`text`, `key?`): [`HashtagNode`](lexical_hashtag.HashtagNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |
| `key?` | `string` |

#### Returns

[`HashtagNode`](lexical_hashtag.HashtagNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[constructor](lexical.TextNode.md#constructor)

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:29](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L29)

## Methods

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

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:55](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L55)

___

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

[TextNode](lexical.TextNode.md).[createDOM](lexical.TextNode.md#createdom)

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:33](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L33)

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

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:48](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L48)

___

### isTextEntity

▸ **isTextEntity**(): ``true``

This method is meant to be overriden by TextNode subclasses to control the behavior of those nodes
when used with the registerLexicalTextEntity function. If you're using registerLexicalTextEntity, the
node class that you create and replace matched text with should return true from this method.

#### Returns

``true``

true if the node is to be treated as a "text entity", false otherwise.

#### Overrides

[TextNode](lexical.TextNode.md).[isTextEntity](lexical.TextNode.md#istextentity)

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:59](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L59)

___

### clone

▸ **clone**(`node`): [`HashtagNode`](lexical_hashtag.HashtagNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`HashtagNode`](lexical_hashtag.HashtagNode.md) |

#### Returns

[`HashtagNode`](lexical_hashtag.HashtagNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[clone](lexical.TextNode.md#clone)

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:25](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L25)

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

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:21](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L21)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`HashtagNode`](lexical_hashtag.HashtagNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedTextNode`](../modules/lexical.md#serializedtextnode) |

#### Returns

[`HashtagNode`](lexical_hashtag.HashtagNode.md)

#### Overrides

[TextNode](lexical.TextNode.md).[importJSON](lexical.TextNode.md#importjson)

#### Defined in

[packages/lexical-hashtag/src/LexicalHashtagNode.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-hashtag/src/LexicalHashtagNode.ts#L39)
