---
id: "lexical_table"
title: "Module: @lexical/table"
custom_edit_url: null
---

## Classes

- [TableCellNode](../classes/lexical_table.TableCellNode.md)
- [TableNode](../classes/lexical_table.TableNode.md)
- [TableObserver](../classes/lexical_table.TableObserver.md)
- [TableRowNode](../classes/lexical_table.TableRowNode.md)
- [TableSelection](../classes/lexical_table.TableSelection.md)

## Type Aliases

### HTMLTableElementWithWithTableSelectionState

Ƭ **HTMLTableElementWithWithTableSelectionState**: `HTMLTableElement` & `Record`\<typeof `LEXICAL_ELEMENT_KEY`, [`TableObserver`](../classes/lexical_table.TableObserver.md)\>

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:897](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L897)

___

### InsertTableCommandPayload

Ƭ **InsertTableCommandPayload**: `Readonly`\<\{ `columns`: `string` ; `includeHeaders?`: [`InsertTableCommandPayloadHeaders`](lexical_table.md#inserttablecommandpayloadheaders) ; `rows`: `string`  }\>

#### Defined in

[packages/lexical-table/src/LexicalTableCommands.ts:20](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCommands.ts#L20)

___

### InsertTableCommandPayloadHeaders

Ƭ **InsertTableCommandPayloadHeaders**: `Readonly`\<\{ `columns`: `boolean` ; `rows`: `boolean`  }\> \| `boolean`

#### Defined in

[packages/lexical-table/src/LexicalTableCommands.ts:13](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCommands.ts#L13)

___

### SerializedTableCellNode

Ƭ **SerializedTableCellNode**: [`Spread`](lexical.md#spread)\<\{ `backgroundColor?`: ``null`` \| `string` ; `colSpan?`: `number` ; `headerState`: `TableCellHeaderState` ; `rowSpan?`: `number` ; `width?`: `number`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L43)

___

### SerializedTableNode

Ƭ **SerializedTableNode**: [`SerializedElementNode`](lexical.md#serializedelementnode)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:33](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L33)

___

### SerializedTableRowNode

Ƭ **SerializedTableRowNode**: [`Spread`](lexical.md#spread)\<\{ `height?`: `number`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-table/src/LexicalTableRowNode.ts:25](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableRowNode.ts#L25)

___

### TableDOMCell

Ƭ **TableDOMCell**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `elem` | `HTMLElement` |
| `hasBackgroundColor` | `boolean` |
| `highlighted` | `boolean` |
| `x` | `number` |
| `y` | `number` |

#### Defined in

[packages/lexical-table/src/LexicalTableObserver.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableObserver.ts#L43)

___

### TableMapType

Ƭ **TableMapType**: [`TableMapValueType`](lexical_table.md#tablemapvaluetype)[][]

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L40)

___

### TableMapValueType

Ƭ **TableMapValueType**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `cell` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |
| `startColumn` | `number` |
| `startRow` | `number` |

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:35](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L35)

___

### TableSelectionShape

Ƭ **TableSelectionShape**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `fromX` | `number` |
| `fromY` | `number` |
| `toX` | `number` |
| `toY` | `number` |

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:28](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L28)

## Variables

### INSERT\_TABLE\_COMMAND

• `Const` **INSERT\_TABLE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<[`InsertTableCommandPayload`](lexical_table.md#inserttablecommandpayload)\>

#### Defined in

[packages/lexical-table/src/LexicalTableCommands.ts:26](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCommands.ts#L26)

___

### TableCellHeaderStates

• `Const` **TableCellHeaderStates**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `BOTH` | `number` |
| `COLUMN` | `number` |
| `NO_STATUS` | `number` |
| `ROW` | `number` |

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:33](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L33)

## Functions

### $computeTableMap

▸ **$computeTableMap**(`grid`, `cellA`, `cellB`): [[`TableMapType`](lexical_table.md#tablemaptype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype)]

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`TableNode`](../classes/lexical_table.TableNode.md) |
| `cellA` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |
| `cellB` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

[[`TableMapType`](lexical_table.md#tablemaptype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype)]

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:724](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L724)

___

### $computeTableMapSkipCellCheck

▸ **$computeTableMapSkipCellCheck**(`grid`, `cellA`, `cellB`): [[`TableMapType`](lexical_table.md#tablemaptype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype) \| ``null``, [`TableMapValueType`](lexical_table.md#tablemapvaluetype) \| ``null``]

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`TableNode`](../classes/lexical_table.TableNode.md) |
| `cellA` | ``null`` \| [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |
| `cellB` | ``null`` \| [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

[[`TableMapType`](lexical_table.md#tablemaptype), [`TableMapValueType`](lexical_table.md#tablemapvaluetype) \| ``null``, [`TableMapValueType`](lexical_table.md#tablemapvaluetype) \| ``null``]

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:739](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L739)

___

### $createTableCellNode

▸ **$createTableCellNode**(`headerState`, `colSpan?`, `width?`): [`TableCellNode`](../classes/lexical_table.TableCellNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `headerState` | `number` | `undefined` |
| `colSpan` | `number` | `1` |
| `width?` | `number` | `undefined` |

#### Returns

[`TableCellNode`](../classes/lexical_table.TableCellNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:362](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L362)

___

### $createTableNode

▸ **$createTableNode**(): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:248](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L248)

___

### $createTableNodeWithDimensions

▸ **$createTableNodeWithDimensions**(`rowCount`, `columnCount`, `includeHeaders?`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `rowCount` | `number` | `undefined` |
| `columnCount` | `number` | `undefined` |
| `includeHeaders` | [`InsertTableCommandPayloadHeaders`](lexical_table.md#inserttablecommandpayloadheaders) | `true` |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L39)

___

### $createTableRowNode

▸ **$createTableRowNode**(`height?`): [`TableRowNode`](../classes/lexical_table.TableRowNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `height?` | `number` |

#### Returns

[`TableRowNode`](../classes/lexical_table.TableRowNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableRowNode.ts:122](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableRowNode.ts#L122)

___

### $createTableSelection

▸ **$createTableSelection**(): [`TableSelection`](../classes/lexical_table.TableSelection.md)

#### Returns

[`TableSelection`](../classes/lexical_table.TableSelection.md)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:347](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L347)

___

### $deleteTableColumn

▸ **$deleteTableColumn**(`tableNode`, `targetIndex`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) |
| `targetIndex` | `number` |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:476](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L476)

___

### $deleteTableColumn\_\_EXPERIMENTAL

▸ **$deleteTableColumn__EXPERIMENTAL**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:575](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L575)

___

### $deleteTableRow\_\_EXPERIMENTAL

▸ **$deleteTableRow__EXPERIMENTAL**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:499](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L499)

___

### $findCellNode

▸ **$findCellNode**(`node`): ``null`` \| [`TableCellNode`](../classes/lexical_table.TableCellNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

``null`` \| [`TableCellNode`](../classes/lexical_table.TableCellNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:1284](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L1284)

___

### $findTableNode

▸ **$findTableNode**(`node`): ``null`` \| [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

``null`` \| [`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:1289](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L1289)

___

### $getElementForTableNode

▸ **$getElementForTableNode**(`editor`, `tableNode`): `TableDOMTable`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) |

#### Returns

`TableDOMTable`

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:231](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L231)

___

### $getNodeTriplet

▸ **$getNodeTriplet**(`source`): [[`TableCellNode`](../classes/lexical_table.TableCellNode.md), [`TableRowNode`](../classes/lexical_table.TableRowNode.md), [`TableNode`](../classes/lexical_table.TableNode.md)]

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | [`LexicalNode`](../classes/lexical.LexicalNode.md) \| [`PointType`](lexical.md#pointtype) \| [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

[[`TableCellNode`](../classes/lexical_table.TableCellNode.md), [`TableRowNode`](../classes/lexical_table.TableRowNode.md), [`TableNode`](../classes/lexical_table.TableNode.md)]

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:798](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L798)

___

### $getTableCellNodeFromLexicalNode

▸ **$getTableCellNodeFromLexicalNode**(`startingNode`): [`TableCellNode`](../classes/lexical_table.TableCellNode.md) \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

[`TableCellNode`](../classes/lexical_table.TableCellNode.md) \| ``null``

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:81](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L81)

___

### $getTableCellNodeRect

▸ **$getTableCellNodeRect**(`tableCellNode`): \{ `colSpan`: `number` ; `columnIndex`: `number` ; `rowIndex`: `number` ; `rowSpan`: `number`  } \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableCellNode` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

\{ `colSpan`: `number` ; `columnIndex`: `number` ; `rowIndex`: `number` ; `rowSpan`: `number`  } \| ``null``

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:832](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L832)

___

### $getTableColumnIndexFromTableCellNode

▸ **$getTableColumnIndexFromTableCellNode**(`tableCellNode`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableCellNode` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:125](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L125)

___

### $getTableNodeFromLexicalNodeOrThrow

▸ **$getTableNodeFromLexicalNodeOrThrow**(`startingNode`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:105](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L105)

___

### $getTableRowIndexFromTableCellNode

▸ **$getTableRowIndexFromTableCellNode**(`tableCellNode`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableCellNode` | [`TableCellNode`](../classes/lexical_table.TableCellNode.md) |

#### Returns

`number`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:117](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L117)

___

### $getTableRowNodeFromTableCellNodeOrThrow

▸ **$getTableRowNodeFromTableCellNodeOrThrow**(`startingNode`): [`TableRowNode`](../classes/lexical_table.TableRowNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

[`TableRowNode`](../classes/lexical_table.TableRowNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:93](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L93)

___

### $insertTableColumn

▸ **$insertTableColumn**(`tableNode`, `targetIndex`, `shouldInsertAfter?`, `columnCount`, `table`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) | `undefined` |
| `targetIndex` | `number` | `undefined` |
| `shouldInsertAfter` | `boolean` | `true` |
| `columnCount` | `number` | `undefined` |
| `table` | `TableDOMTable` | `undefined` |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:317](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L317)

___

### $insertTableColumn\_\_EXPERIMENTAL

▸ **$insertTableColumn__EXPERIMENTAL**(`insertAfter?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `insertAfter` | `boolean` | `true` |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:376](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L376)

___

### $insertTableRow

▸ **$insertTableRow**(`tableNode`, `targetIndex`, `shouldInsertAfter?`, `rowCount`, `table`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) | `undefined` |
| `targetIndex` | `number` | `undefined` |
| `shouldInsertAfter` | `boolean` | `true` |
| `rowCount` | `number` | `undefined` |
| `table` | `TableDOMTable` | `undefined` |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:168](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L168)

___

### $insertTableRow\_\_EXPERIMENTAL

▸ **$insertTableRow__EXPERIMENTAL**(`insertAfter?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `insertAfter` | `boolean` | `true` |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:248](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L248)

___

### $isTableCellNode

▸ **$isTableCellNode**(`node`): node is TableCellNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is TableCellNode

#### Defined in

[packages/lexical-table/src/LexicalTableCellNode.ts:370](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableCellNode.ts#L370)

___

### $isTableNode

▸ **$isTableNode**(`node`): node is TableNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is TableNode

#### Defined in

[packages/lexical-table/src/LexicalTableNode.ts:252](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableNode.ts#L252)

___

### $isTableRowNode

▸ **$isTableRowNode**(`node`): node is TableRowNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is TableRowNode

#### Defined in

[packages/lexical-table/src/LexicalTableRowNode.ts:126](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableRowNode.ts#L126)

___

### $isTableSelection

▸ **$isTableSelection**(`x`): x is TableSelection

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `unknown` |

#### Returns

x is TableSelection

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:343](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L343)

___

### $removeTableRowAtIndex

▸ **$removeTableRowAtIndex**(`tableNode`, `indexToDelete`): [`TableNode`](../classes/lexical_table.TableNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) |
| `indexToDelete` | `number` |

#### Returns

[`TableNode`](../classes/lexical_table.TableNode.md)

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:153](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L153)

___

### $unmergeCell

▸ **$unmergeCell**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableUtils.ts:666](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableUtils.ts#L666)

___

### applyTableHandlers

▸ **applyTableHandlers**(`tableNode`, `tableElement`, `editor`, `hasTabHandler`): [`TableObserver`](../classes/lexical_table.TableObserver.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableNode` | [`TableNode`](../classes/lexical_table.TableNode.md) |
| `tableElement` | [`HTMLTableElementWithWithTableSelectionState`](lexical_table.md#htmltableelementwithwithtableselectionstate) |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `hasTabHandler` | `boolean` |

#### Returns

[`TableObserver`](../classes/lexical_table.TableObserver.md)

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L86)

___

### getDOMCellFromTarget

▸ **getDOMCellFromTarget**(`node`): [`TableDOMCell`](lexical_table.md#tabledomcell) \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `Node` |

#### Returns

[`TableDOMCell`](lexical_table.md#tabledomcell) \| ``null``

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:913](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L913)

___

### getTableObserverFromTableElement

▸ **getTableObserverFromTableElement**(`tableElement`): [`TableObserver`](../classes/lexical_table.TableObserver.md) \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableElement` | [`HTMLTableElementWithWithTableSelectionState`](lexical_table.md#htmltableelementwithwithtableselectionstate) |

#### Returns

[`TableObserver`](../classes/lexical_table.TableObserver.md) \| ``null``

#### Defined in

[packages/lexical-table/src/LexicalTableSelectionHelpers.ts:907](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelectionHelpers.ts#L907)
