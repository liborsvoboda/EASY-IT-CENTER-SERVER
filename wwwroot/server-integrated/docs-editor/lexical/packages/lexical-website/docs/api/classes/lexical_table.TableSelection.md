---
id: "lexical_table.TableSelection"
title: "Class: TableSelection"
custom_edit_url: null
---

[@lexical/table](../modules/lexical_table.md).TableSelection

## Implements

- [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

## Constructors

### constructor

• **new TableSelection**(`tableKey`, `anchor`, `focus`): [`TableSelection`](lexical_table.TableSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableKey` | `string` |
| `anchor` | [`PointType`](../modules/lexical.md#pointtype) |
| `focus` | [`PointType`](../modules/lexical.md#pointtype) |

#### Returns

[`TableSelection`](lexical_table.TableSelection.md)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L49)

## Properties

### \_cachedNodes

• **\_cachedNodes**: ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[_cachedNodes](../interfaces/lexical.BaseSelection.md#_cachednodes)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L46)

___

### anchor

• **anchor**: [`PointType`](../modules/lexical.md#pointtype)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L44)

___

### dirty

• **dirty**: `boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[dirty](../interfaces/lexical.BaseSelection.md#dirty)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:47](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L47)

___

### focus

• **focus**: [`PointType`](../modules/lexical.md#pointtype)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L45)

___

### tableKey

• **tableKey**: `string`

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L43)

## Methods

### clone

▸ **clone**(): [`TableSelection`](lexical_table.TableSelection.md)

#### Returns

[`TableSelection`](lexical_table.TableSelection.md)

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[clone](../interfaces/lexical.BaseSelection.md#clone)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:99](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L99)

___

### extract

▸ **extract**(): [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[extract](../interfaces/lexical.BaseSelection.md#extract)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:107](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L107)

___

### getCachedNodes

▸ **getCachedNodes**(): ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getCachedNodes](../interfaces/lexical.BaseSelection.md#getcachednodes)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L72)

___

### getNodes

▸ **getNodes**(): [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getNodes](../interfaces/lexical.BaseSelection.md#getnodes)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:181](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L181)

___

### getShape

▸ **getShape**(): [`TableSelectionShape`](../modules/lexical_table.md#tableselectionshape)

#### Returns

[`TableSelectionShape`](../modules/lexical_table.md#tableselectionshape)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:132](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L132)

___

### getStartEndPoints

▸ **getStartEndPoints**(): [[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Returns

[[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getStartEndPoints](../interfaces/lexical.BaseSelection.md#getstartendpoints)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:59](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L59)

___

### getTextContent

▸ **getTextContent**(): `string`

#### Returns

`string`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getTextContent](../interfaces/lexical.BaseSelection.md#gettextcontent)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:333](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L333)

___

### insertNodes

▸ **insertNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertNodes](../interfaces/lexical.BaseSelection.md#insertnodes)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:119](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L119)

___

### insertRawText

▸ **insertRawText**(`text`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertRawText](../interfaces/lexical.BaseSelection.md#insertrawtext)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:111](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L111)

___

### insertText

▸ **insertText**(): `void`

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertText](../interfaces/lexical.BaseSelection.md#inserttext)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:115](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L115)

___

### is

▸ **is**(`selection`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

`boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[is](../interfaces/lexical.BaseSelection.md#is)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L80)

___

### isBackward

▸ **isBackward**(): `boolean`

Returns whether the Selection is "backwards", meaning the focus
logically precedes the anchor in the EditorState.

#### Returns

`boolean`

true if the Selection is backwards, false otherwise.

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[isBackward](../interfaces/lexical.BaseSelection.md#isbackward)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:68](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L68)

___

### isCollapsed

▸ **isCollapsed**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[isCollapsed](../interfaces/lexical.BaseSelection.md#iscollapsed)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:103](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L103)

___

### set

▸ **set**(`tableKey`, `anchorCellKey`, `focusCellKey`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tableKey` | `string` |
| `anchorCellKey` | `string` |
| `focusCellKey` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:91](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L91)

___

### setCachedNodes

▸ **setCachedNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[setCachedNodes](../interfaces/lexical.BaseSelection.md#setcachednodes)

#### Defined in

[packages/lexical-table/src/LexicalTableSelection.ts:76](https://github.com/facebook/lexical/tree/main/packages/lexical-table/src/LexicalTableSelection.ts#L76)
