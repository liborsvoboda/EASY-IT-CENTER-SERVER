---
id: "lexical_table.TableNode"
title: "Class: TableNode"
custom_edit_url: null
---

[@lexical/table](../modules/lexical_table.md).TableNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`TableNode`**

## Constructors

### constructor

• **new TableNode**(`key?`): [`TableNode`](lexical_table.TableNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`TableNode`](lexical_table.TableNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:58](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L58)

## Methods

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canBeEmpty](lexical.ElementNode.md#canbeempty)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:114](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L114)

___

### canIndent

▸ **canIndent**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canIndent](lexical.ElementNode.md#canindent)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:226](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L226)

___

### canSelectBefore

▸ **canSelectBefore**(): ``true``

#### Returns

``true``

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:222](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L222)

___

### createDOM

▸ **createDOM**(`config`, `editor?`): `HTMLElement`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) | allows access to things like the EditorTheme (to apply classes) during reconciliation. |
| `editor?` | [`LexicalEditor`](lexical.LexicalEditor.md) | allows access to the editor for context during reconciliation. |

#### Returns

`HTMLElement`

#### Overrides

[ElementNode](lexical.ElementNode.md).[createDOM](lexical.ElementNode.md#createdom)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L70)

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

[packages/lexical-table/src/LexicalTableNode.ts:82](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L82)

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

[packages/lexical-table/src/LexicalTableNode.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L62)

___

### getCellNodeFromCords

▸ **getCellNodeFromCords**(`x`, `y`, `table`): ``null`` \| [`TableCellNode`](lexical_table.TableCellNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |
| `table` | `TableDOMTable` |

#### Returns

``null`` \| [`TableCellNode`](lexical_table.TableCellNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:188](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L188)

___

### getCellNodeFromCordsOrThrow

▸ **getCellNodeFromCordsOrThrow**(`x`, `y`, `table`): [`TableCellNode`](lexical_table.TableCellNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |
| `table` | `TableDOMTable` |

#### Returns

[`TableCellNode`](lexical_table.TableCellNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:208](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L208)

___

### getCordsFromCellNode

▸ **getCordsFromCellNode**(`tableCellNode`, `table`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableCellNode` | [`TableCellNode`](lexical_table.TableCellNode.md) |
| `table` | `TableDOMTable` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:122](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L122)

___

### getDOMCellFromCords

▸ **getDOMCellFromCords**(`x`, `y`, `table`): ``null`` \| [`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |
| `table` | `TableDOMTable` |

#### Returns

``null`` \| [`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:152](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L152)

___

### getDOMCellFromCordsOrThrow

▸ **getDOMCellFromCordsOrThrow**(`x`, `y`, `table`): [`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |
| `table` | `TableDOMTable` |

#### Returns

[`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:174](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L174)

___

### isShadowRoot

▸ **isShadowRoot**(): `boolean`

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[isShadowRoot](lexical.ElementNode.md#isshadowroot)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:118](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L118)

___

### updateDOM

▸ **updateDOM**(): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:78](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L78)

___

### clone

▸ **clone**(`node`): [`TableNode`](lexical_table.TableNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`TableNode`](lexical_table.TableNode.md) |

#### Returns

[`TableNode`](lexical_table.TableNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L41)

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

[packages/lexical-table/src/LexicalTableNode.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L37)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L45)

___

### importJSON

▸ **importJSON**(`_serializedNode`): [`TableNode`](lexical_table.TableNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `_serializedNode` | [`SerializedTableNode`](../modules/lexical_table.md#serializedtablenode) |

#### Returns

[`TableNode`](lexical_table.TableNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:54](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L54)
