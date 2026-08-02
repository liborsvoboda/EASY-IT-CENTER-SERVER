---
id: "lexical_table.TableObserver"
title: "Class: TableObserver"
custom_edit_url: null
---

[@lexical/table](../modules/lexical_table.md).TableObserver

## Constructors

### constructor

• **new TableObserver**(`editor`, `tableNodeKey`): [`TableObserver`](lexical_table.TableObserver.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](lexical.LexicalEditor.md) |
| `tableNodeKey` | `string` |

#### Returns

[`TableObserver`](lexical_table.TableObserver.md)

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:77](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L77)

## Properties

### anchorCell

• **anchorCell**: ``null`` \| [`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:68](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L68)

___

### anchorCellNodeKey

• **anchorCellNodeKey**: ``null`` \| `string`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L70)

___

### anchorX

• **anchorX**: `number`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:65](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L65)

___

### anchorY

• **anchorY**: `number`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L66)

___

### editor

• **editor**: [`LexicalEditor`](lexical.LexicalEditor.md)

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L72)

___

### focusCell

• **focusCell**: ``null`` \| [`TableDOMCell`](../modules/lexical_table.md#tabledomcell)

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L69)

___

### focusCellNodeKey

• **focusCellNodeKey**: ``null`` \| `string`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:71](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L71)

___

### focusX

• **focusX**: `number`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:60](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L60)

___

### focusY

• **focusY**: `number`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:61](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L61)

___

### hasHijackedSelectionStyles

• **hasHijackedSelectionStyles**: `boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L74)

___

### isHighlightingCells

• **isHighlightingCells**: `boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L64)

___

### isSelecting

• **isSelecting**: `boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:75](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L75)

___

### listenersToRemove

• **listenersToRemove**: `Set`\<() => `void`\>

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L62)

___

### table

• **table**: `TableDOMTable`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L63)

___

### tableNodeKey

• **tableNodeKey**: `string`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:67](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L67)

___

### tableSelection

• **tableSelection**: ``null`` \| [`TableSelection`](lexical_table.TableSelection.md)

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:73](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L73)

## Methods

### clearHighlight

▸ **clearHighlight**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:161](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L161)

___

### clearText

▸ **clearText**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:367](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L367)

___

### disableHighlightStyle

▸ **disableHighlightStyle**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:215](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L215)

___

### enableHighlightStyle

▸ **enableHighlightStyle**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:197](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L197)

___

### formatCells

▸ **formatCells**(`type`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`TextFormatType`](../modules/lexical.md#textformattype) |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:340](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L340)

___

### getTable

▸ **getTable**(): `TableDOMTable`

#### Returns

`TableDOMTable`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:101](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L101)

___

### removeListeners

▸ **removeListeners**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:105](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L105)

___

### setAnchorCellForSelection

▸ **setAnchorCellForSelection**(`cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | [`TableDOMCell`](../modules/lexical_table.md#tabledomcell) |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:320](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L320)

___

### setFocusCellForSelection

▸ **setFocusCellForSelection**(`cell`, `ignoreStart?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `cell` | [`TableDOMCell`](../modules/lexical_table.md#tabledomcell) | `undefined` |
| `ignoreStart` | `boolean` | `false` |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:244](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L244)

___

### trackTable

▸ **trackTable**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:111](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L111)

___

### updateTableTableSelection

▸ **updateTableTableSelection**(`selection`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | ``null`` \| [`TableSelection`](lexical_table.TableSelection.md) |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:229](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L229)
