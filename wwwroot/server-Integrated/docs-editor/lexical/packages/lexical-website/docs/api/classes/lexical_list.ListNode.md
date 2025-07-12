---
id: "lexical_list.ListNode"
title: "Class: ListNode"
custom_edit_url: null
---

[@lexical/list](../modules/lexical_list.md).ListNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`ListNode`**

## Constructors

### constructor

• **new ListNode**(`listType`, `start`, `key?`): [`ListNode`](lexical_list.ListNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `listType` | [`ListType`](../modules/lexical_list.md#listtype) |
| `start` | `number` |
| `key?` | `string` |

#### Returns

[`ListNode`](lexical_list.ListNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L72)

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

[packages/lexical-list/src/LexicalListNode.ts:191](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L191)

___

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canBeEmpty](lexical.ElementNode.md#canbeempty)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:183](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L183)

___

### canIndent

▸ **canIndent**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canIndent](lexical.ElementNode.md#canindent)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:187](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L187)

___

### createDOM

▸ **createDOM**(`config`, `_editor?`): `HTMLElement`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) | allows access to things like the EditorTheme (to apply classes) during reconciliation. |
| `_editor?` | [`LexicalEditor`](lexical.LexicalEditor.md) | allows access to the editor for context during reconciliation. |

#### Returns

`HTMLElement`

#### Overrides

[ElementNode](lexical.ElementNode.md).[createDOM](lexical.ElementNode.md#createdom)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:100](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L100)

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

[packages/lexical-list/src/LexicalListNode.ts:157](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L157)

___

### exportJSON

▸ **exportJSON**(): [`SerializedListNode`](../modules/lexical_list.md#serializedlistnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedListNode`](../modules/lexical_list.md#serializedlistnode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:172](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L172)

___

### extractWithChild

▸ **extractWithChild**(`child`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `child` | [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[extractWithChild](lexical.ElementNode.md#extractwithchild)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:214](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L214)

___

### getListType

▸ **getListType**(): [`ListType`](../modules/lexical_list.md#listtype)

#### Returns

[`ListType`](../modules/lexical_list.md#listtype)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:90](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L90)

___

### getStart

▸ **getStart**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:94](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L94)

___

### getTag

▸ **getTag**(): `ListNodeTagType`

#### Returns

`ListNodeTagType`

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L80)

___

### setListType

▸ **setListType**(`type`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`ListType`](../modules/lexical_list.md#listtype) |

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:84](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L84)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `dom`, `config`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`ListNode`](lexical_list.ListNode.md) |
| `dom` | `HTMLElement` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:114](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L114)

___

### clone

▸ **clone**(`node`): [`ListNode`](lexical_list.ListNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`ListNode`](lexical_list.ListNode.md) |

#### Returns

[`ListNode`](lexical_list.ListNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L66)

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

[packages/lexical-list/src/LexicalListNode.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L62)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:136](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L136)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`ListNode`](lexical_list.ListNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedListNode`](../modules/lexical_list.md#serializedlistnode) |

#### Returns

[`ListNode`](lexical_list.ListNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:149](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L149)

___

### transform

▸ **transform**(): (`node`: [`LexicalNode`](lexical.LexicalNode.md)) => `void`

Registers the returned function as a transform on the node during
Editor initialization. Most such use cases should be addressed via
the [LexicalEditor.registerNodeTransform](lexical.LexicalEditor.md#registernodetransform) API.

Experimental - use at your own risk.

#### Returns

`fn`

▸ (`node`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](lexical.LexicalNode.md) |

##### Returns

`void`

#### Overrides

[ElementNode](lexical.ElementNode.md).[transform](lexical.ElementNode.md#transform)

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:128](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L128)
