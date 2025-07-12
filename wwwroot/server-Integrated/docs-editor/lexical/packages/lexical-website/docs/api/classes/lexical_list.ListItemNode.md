---
id: "lexical_list.ListItemNode"
title: "Class: ListItemNode"
custom_edit_url: null
---

[@lexical/list](../modules/lexical_list.md).ListItemNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`ListItemNode`**

## Constructors

### constructor

• **new ListItemNode**(`value?`, `checked?`, `key?`): [`ListItemNode`](lexical_list.ListItemNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `value?` | `number` |
| `checked?` | `boolean` |
| `key?` | `string` |

#### Returns

[`ListItemNode`](lexical_list.ListItemNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:68](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L68)

## Methods

### append

▸ **append**(`...nodes`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `...nodes` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`this`

#### Overrides

[ElementNode](lexical.ElementNode.md).[append](lexical.ElementNode.md#append)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:152](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L152)

___

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

[packages/lexical-list/src/LexicalListItemNode.ts:415](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L415)

___

### canMergeWith

▸ **canMergeWith**(`node`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`boolean`

#### Overrides

ElementNode.canMergeWith

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:388](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L388)

___

### collapseAtStart

▸ **collapseAtStart**(`selection`): ``true``

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) |

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:270](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L270)

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

[packages/lexical-list/src/LexicalListItemNode.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L74)

___

### createParentElementNode

▸ **createParentElementNode**(): [`ElementNode`](lexical.ElementNode.md)

The creation logic for any required parent. Should be implemented if [isParentRequired](lexical.LexicalNode.md#isparentrequired) returns true.

#### Returns

[`ElementNode`](lexical.ElementNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[createParentElementNode](lexical.ElementNode.md#createparentelementnode)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:411](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L411)

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

[packages/lexical-list/src/LexicalListItemNode.ts:134](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L134)

___

### exportJSON

▸ **exportJSON**(): [`SerializedListItemNode`](../modules/lexical_list.md#serializedlistitemnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedListItemNode`](../modules/lexical_list.md#serializedlistitemnode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:142](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L142)

___

### extractWithChild

▸ **extractWithChild**(`child`, `selection`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `child` | [`LexicalNode`](lexical.LexicalNode.md) |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[extractWithChild](lexical.ElementNode.md#extractwithchild)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:392](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L392)

___

### getChecked

▸ **getChecked**(): `undefined` \| `boolean`

#### Returns

`undefined` \| `boolean`

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:320](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L320)

___

### getIndent

▸ **getIndent**(): `number`

#### Returns

`number`

#### Overrides

[ElementNode](lexical.ElementNode.md).[getIndent](lexical.ElementNode.md#getindent)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:342](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L342)

___

### getValue

▸ **getValue**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:309](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L309)

___

### insertAfter

▸ **insertAfter**(`node`, `restoreSelection?`): [`LexicalNode`](lexical.LexicalNode.md)

Inserts a node after this LexicalNode (as the next sibling).

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `node` | [`LexicalNode`](lexical.LexicalNode.md) | `undefined` | The node to insert after this one. |
| `restoreSelection` | `boolean` | `true` | Whether or not to attempt to resolve the selection to the appropriate place after the operation is complete. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertAfter](lexical.ElementNode.md#insertafter)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:212](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L212)

___

### insertNewAfter

▸ **insertNewAfter**(`_`, `restoreSelection?`): [`ParagraphNode`](lexical.ParagraphNode.md) \| [`ListItemNode`](lexical_list.ListItemNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `_` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

[`ParagraphNode`](lexical.ParagraphNode.md) \| [`ListItemNode`](lexical_list.ListItemNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:258](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L258)

___

### isParentRequired

▸ **isParentRequired**(): ``true``

Whether or not this node has a required parent. Used during copy + paste operations
to normalize nodes that would otherwise be orphaned. For example, ListItemNodes without
a ListNode parent or TextNodes with a ParagraphNode parent.

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[isParentRequired](lexical.ElementNode.md#isparentrequired)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:407](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L407)

___

### remove

▸ **remove**(`preserveEmptyParent?`): `void`

Removes this LexicalNode from the EditorState. If the node isn't re-inserted
somewhere, the Lexical garbage collector will eventually clean it up.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `preserveEmptyParent?` | `boolean` | If falsy, the node's parent will be removed if it's empty after the removal operation. This is the default behavior, subject to other node heuristics such as [ElementNode#canBeEmpty](lexical.ElementNode.md#canbeempty) |

#### Returns

`void`

#### Overrides

[ElementNode](lexical.ElementNode.md).[remove](lexical.ElementNode.md#remove)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:242](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L242)

___

### replace

▸ **replace**\<`N`\>(`replaceWithNode`, `includeChildren?`): `N`

Replaces this LexicalNode with the provided node, optionally transferring the children
of the replaced node to the replacing node.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `replaceWithNode` | `N` | The node to replace this one with. |
| `includeChildren?` | `boolean` | Whether or not to transfer the children of this node to the replacing node. |

#### Returns

`N`

#### Overrides

[ElementNode](lexical.ElementNode.md).[replace](lexical.ElementNode.md#replace)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:168](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L168)

___

### setChecked

▸ **setChecked**(`checked?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `checked?` | `boolean` |

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:333](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L333)

___

### setIndent

▸ **setIndent**(`indent`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `indent` | `number` |

#### Returns

`this`

#### Overrides

[ElementNode](lexical.ElementNode.md).[setIndent](lexical.ElementNode.md#setindent)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:359](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L359)

___

### setValue

▸ **setValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `number` |

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:315](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L315)

___

### toggleChecked

▸ **toggleChecked**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:338](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L338)

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
| `prevNode` | [`ListItemNode`](lexical_list.ListItemNode.md) |
| `dom` | `HTMLElement` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:85](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L85)

___

### clone

▸ **clone**(`node`): [`ListItemNode`](lexical_list.ListItemNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`ListItemNode`](lexical_list.ListItemNode.md) |

#### Returns

[`ListItemNode`](lexical_list.ListItemNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L64)

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

[packages/lexical-list/src/LexicalListItemNode.ts:60](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L60)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:116](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L116)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`ListItemNode`](lexical_list.ListItemNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedListItemNode`](../modules/lexical_list.md#serializedlistitemnode) |

#### Returns

[`ListItemNode`](lexical_list.ListItemNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:125](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L125)

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

[packages/lexical-list/src/LexicalListItemNode.ts:101](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L101)
