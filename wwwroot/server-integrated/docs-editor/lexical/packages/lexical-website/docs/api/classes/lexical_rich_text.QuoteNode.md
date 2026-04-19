---
id: "lexical_rich_text.QuoteNode"
title: "Class: QuoteNode"
custom_edit_url: null
---

[@lexical/rich-text](../modules/lexical_rich_text.md).QuoteNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`QuoteNode`**

## Constructors

### constructor

• **new QuoteNode**(`key?`): [`QuoteNode`](lexical_rich_text.QuoteNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`QuoteNode`](lexical_rich_text.QuoteNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-rich-text/src/index.ts:127](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L127)

## Methods

### canMergeWhenEmpty

▸ **canMergeWhenEmpty**(): ``true``

Determines whether this node, when empty, can merge with a first block
of nodes being inserted.

This method is specifically called in [RangeSelection.insertNodes](lexical.RangeSelection.md#insertnodes)
to determine merging behavior during nodes insertion.

#### Returns

``true``

**`Example`**

```ts
// In a ListItemNode or QuoteNode implementation:
canMergeWhenEmpty(): true {
 return true;
}
```

#### Overrides

[ElementNode](lexical.ElementNode.md).[canMergeWhenEmpty](lexical.ElementNode.md#canmergewhenempty)

#### Defined in

[packages/lexical-rich-text/src/index.ts:206](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L206)

___

### collapseAtStart

▸ **collapseAtStart**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical-rich-text/src/index.ts:198](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L198)

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

[packages/lexical-rich-text/src/index.ts:133](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L133)

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

[packages/lexical-rich-text/src/index.ts:151](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L151)

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

[packages/lexical-rich-text/src/index.ts:181](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L181)

___

### insertNewAfter

▸ **insertNewAfter**(`_`, `restoreSelection?`): [`ParagraphNode`](lexical.ParagraphNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `_` | [`RangeSelection`](lexical.RangeSelection.md) |
| `restoreSelection?` | `boolean` |

#### Returns

[`ParagraphNode`](lexical.ParagraphNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-rich-text/src/index.ts:190](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L190)

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
| `prevNode` | [`QuoteNode`](lexical_rich_text.QuoteNode.md) |
| `dom` | `HTMLElement` |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-rich-text/src/index.ts:138](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L138)

___

### clone

▸ **clone**(`node`): [`QuoteNode`](lexical_rich_text.QuoteNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`QuoteNode`](lexical_rich_text.QuoteNode.md) |

#### Returns

[`QuoteNode`](lexical_rich_text.QuoteNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-rich-text/src/index.ts:123](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L123)

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

[packages/lexical-rich-text/src/index.ts:119](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L119)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-rich-text/src/index.ts:142](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L142)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`QuoteNode`](lexical_rich_text.QuoteNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedQuoteNode`](../modules/lexical_rich_text.md#serializedquotenode) |

#### Returns

[`QuoteNode`](lexical_rich_text.QuoteNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-rich-text/src/index.ts:173](https://github.com/facebook/lexical/tree/main/packages/lexical-rich-text/src/index.ts#L173)
