---
id: "lexical_rich_text.HeadingNode"
title: "Class: HeadingNode"
custom_edit_url: null
---

[@lexical/rich-text](../modules/lexical_rich_text.md).HeadingNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`HeadingNode`**

## Constructors

### constructor

• **new HeadingNode**(`tag`, `key?`): [`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `tag` | [`HeadingTagType`](../modules/lexical_rich_text.md#headingtagtype) |
| `key?` | `string` |

#### Returns

[`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-rich-text/src/index.ts:236](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L236)

## Methods

### collapseAtStart

▸ **collapseAtStart**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical-rich-text/src/index.ts:383](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L383)

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

[ElementNode](lexical.ElementNode.md).[createDOM](lexical.ElementNode.md#createdom)

#### Defined in

[packages/lexical-rich-text/src/index.ts:247](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L247)

___

### exportDOM

▸ **exportDOM**(`editor`): [`DOMExportOutput`](../modules/lexical.md#domexportoutput)

Controls how the this node is serialized to HTML. This is important for
copy and paste between Lexical and non-Lexical editors, or Lexical editors with different namespaces,
in which case the primary transfer format is HTML. It's also important if you're serializing
to HTML for any other reason via [@lexical/html!$generateHtmlFromNodes](../modules/lexical_html.md#$generatehtmlfromnodes). You could
also use this method to build your own HTML renderer.

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](lexical.LexicalEditor.md) |

#### Returns

[`DOMExportOutput`](../modules/lexical.md#domexportoutput)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportDOM](lexical.ElementNode.md#exportdom)

#### Defined in

[packages/lexical-rich-text/src/index.ts:317](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L317)

___

### exportJSON

▸ **exportJSON**(): [`SerializedHeadingNode`](../modules/lexical_rich_text.md#serializedheadingnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedHeadingNode`](../modules/lexical_rich_text.md#serializedheadingnode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-rich-text/src/index.ts:347](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L347)

___

### extractWithChild

▸ **extractWithChild**(): `boolean`

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[extractWithChild](lexical.ElementNode.md#extractwithchild)

#### Defined in

[packages/lexical-rich-text/src/index.ts:393](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L393)

___

### getTag

▸ **getTag**(): [`HeadingTagType`](../modules/lexical_rich_text.md#headingtagtype)

#### Returns

[`HeadingTagType`](../modules/lexical_rich_text.md#headingtagtype)

#### Defined in

[packages/lexical-rich-text/src/index.ts:241](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L241)

___

### insertNewAfter

▸ **insertNewAfter**(`selection?`, `restoreSelection?`): [`ParagraphNode`](lexical.ParagraphNode.md) \| [`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `selection?` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

[`ParagraphNode`](lexical.ParagraphNode.md) \| [`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-rich-text/src/index.ts:357](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L357)

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
| `prevNode` | [`HeadingNode`](lexical_rich_text.HeadingNode.md) |
| `dom` | `HTMLElement` |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-rich-text/src/index.ts:259](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L259)

___

### clone

▸ **clone**(`node`): [`HeadingNode`](lexical_rich_text.HeadingNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`HeadingNode`](lexical_rich_text.HeadingNode.md) |

#### Returns

[`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-rich-text/src/index.ts:232](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L232)

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

[packages/lexical-rich-text/src/index.ts:228](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L228)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-rich-text/src/index.ts:263](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L263)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`HeadingNode`](lexical_rich_text.HeadingNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedHeadingNode`](../modules/lexical_rich_text.md#serializedheadingnode) |

#### Returns

[`HeadingNode`](lexical_rich_text.HeadingNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-rich-text/src/index.ts:339](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L339)
