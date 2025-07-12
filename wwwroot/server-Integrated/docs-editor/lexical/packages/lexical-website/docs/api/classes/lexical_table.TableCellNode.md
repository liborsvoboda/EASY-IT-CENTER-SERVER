---
id: "lexical_table.TableCellNode"
title: "Class: TableCellNode"
custom_edit_url: null
---

[@lexical/table](../modules/lexical_table.md).TableCellNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`TableCellNode`**

## Constructors

### constructor

• **new TableCellNode**(`headerState?`, `colSpan?`, `width?`, `key?`): [`TableCellNode`](lexical_table.TableCellNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `headerState` | `number` | `TableCellHeaderStates.NO_STATUS` |
| `colSpan` | `number` | `1` |
| `width?` | `number` | `undefined` |
| `key?` | `string` | `undefined` |

#### Returns

[`TableCellNode`](lexical_table.TableCellNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:109](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L109)

## Methods

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canBeEmpty](lexical.ElementNode.md#canbeempty)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:280](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L280)

___

### canIndent

▸ **canIndent**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canIndent](lexical.ElementNode.md#canindent)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:284](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L284)

___

### collapseAtStart

▸ **collapseAtStart**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:276](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L276)

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

[packages/lexical-table/src/LexicalTableCellNode.ts:123](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L123)

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

[packages/lexical-table/src/LexicalTableCellNode.ts:150](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L150)

___

### exportJSON

▸ **exportJSON**(): [`SerializedTableCellNode`](../modules/lexical_table.md#serializedtablecellnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedTableCellNode`](../modules/lexical_table.md#serializedtablecellnode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:180](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L180)

___

### getBackgroundColor

▸ **getBackgroundColor**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:234](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L234)

___

### getColSpan

▸ **getColSpan**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:192](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L192)

___

### getHeaderStyles

▸ **getHeaderStyles**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:220](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L220)

___

### getRowSpan

▸ **getRowSpan**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:201](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L201)

___

### getTag

▸ **getTag**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:210](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L210)

___

### getWidth

▸ **getWidth**(): `undefined` \| `number`

#### Returns

`undefined` \| `number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:230](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L230)

___

### hasHeader

▸ **hasHeader**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:258](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L258)

___

### hasHeaderState

▸ **hasHeaderState**(`headerState`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `headerState` | `number` |

#### Returns

`boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:254](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L254)

___

### isShadowRoot

▸ **isShadowRoot**(): `boolean`

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[isShadowRoot](lexical.ElementNode.md#isshadowroot)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:272](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L272)

___

### setBackgroundColor

▸ **setBackgroundColor**(`newBackgroundColor`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newBackgroundColor` | ``null`` \| `string` |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:238](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L238)

___

### setColSpan

▸ **setColSpan**(`colSpan`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `colSpan` | `number` |

#### Returns

`this`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:196](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L196)

___

### setHeaderStyles

▸ **setHeaderStyles**(`headerState`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `headerState` | `number` |

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:214](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L214)

___

### setRowSpan

▸ **setRowSpan**(`rowSpan`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rowSpan` | `number` |

#### Returns

`this`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:205](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L205)

___

### setWidth

▸ **setWidth**(`width`): `undefined` \| ``null`` \| `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `width` | `number` |

#### Returns

`undefined` \| ``null`` \| `number`

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:224](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L224)

___

### toggleHeaderStyle

▸ **toggleHeaderStyle**(`headerStateToToggle`): [`TableCellNode`](lexical_table.TableCellNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `headerStateToToggle` | `number` |

#### Returns

[`TableCellNode`](lexical_table.TableCellNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:242](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L242)

___

### updateDOM

▸ **updateDOM**(`prevNode`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`TableCellNode`](lexical_table.TableCellNode.md) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:262](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L262)

___

### clone

▸ **clone**(`node`): [`TableCellNode`](lexical_table.TableCellNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`TableCellNode`](lexical_table.TableCellNode.md) |

#### Returns

[`TableCellNode`](lexical_table.TableCellNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:71](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L71)

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

[packages/lexical-table/src/LexicalTableCellNode.ts:67](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L67)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:83](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L83)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`TableCellNode`](lexical_table.TableCellNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedTableCellNode`](../modules/lexical_table.md#serializedtablecellnode) |

#### Returns

[`TableCellNode`](lexical_table.TableCellNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:96](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L96)
