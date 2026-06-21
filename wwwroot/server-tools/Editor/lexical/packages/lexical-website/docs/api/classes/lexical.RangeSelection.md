---
id: "lexical.RangeSelection"
title: "Class: RangeSelection"
custom_edit_url: null
---

[lexical](../modules/lexical.md).RangeSelection

## Implements

- [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

## Constructors

### constructor

• **new RangeSelection**(`anchor`, `focus`, `format`, `style`): [`RangeSelection`](lexical.RangeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchor` | [`PointType`](../modules/lexical.md#pointtype) |
| `focus` | [`PointType`](../modules/lexical.md#pointtype) |
| `format` | `number` |
| `style` | `string` |

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:405](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L405)

## Properties

### \_cachedNodes

• **\_cachedNodes**: ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[_cachedNodes](../interfaces/lexical.BaseSelection.md#_cachednodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:402](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L402)

___

### anchor

• **anchor**: [`PointType`](../modules/lexical.md#pointtype)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:400](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L400)

___

### dirty

• **dirty**: `boolean`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[dirty](../interfaces/lexical.BaseSelection.md#dirty)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:403](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L403)

___

### focus

• **focus**: [`PointType`](../modules/lexical.md#pointtype)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:401](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L401)

___

### format

• **format**: `number`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:398](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L398)

___

### style

• **style**: `string`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:399](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L399)

## Methods

### applyDOMRange

▸ **applyDOMRange**(`range`): `void`

Attempts to map a DOM selection range onto this Lexical Selection,
setting the anchor, focus, and type accordingly

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `range` | `StaticRange` | a DOM Selection range conforming to the StaticRange interface. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:608](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L608)

___

### clone

▸ **clone**(): [`RangeSelection`](lexical.RangeSelection.md)

Creates a new RangeSelection, copying over all the property values from this one.

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

a new RangeSelection with the same property values as this one.

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[clone](../interfaces/lexical.BaseSelection.md#clone)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:644](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L644)

___

### deleteCharacter

▸ **deleteCharacter**(`isBackward`): `void`

Performs one logical character deletion operation on the EditorState based on the current Selection.
Handles different node types.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isBackward` | `boolean` | whether or not the selection is backwards. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1594](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1594)

___

### deleteLine

▸ **deleteLine**(`isBackward`): `void`

Performs one logical line deletion operation on the EditorState based on the current Selection.
Handles different node types.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isBackward` | `boolean` | whether or not the selection is backwards. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1700](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1700)

___

### deleteWord

▸ **deleteWord**(`isBackward`): `void`

Performs one logical word deletion operation on the EditorState based on the current Selection.
Handles different node types.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `isBackward` | `boolean` | whether or not the selection is backwards. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1735](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1735)

___

### extract

▸ **extract**(): [`LexicalNode`](lexical.LexicalNode.md)[]

Extracts the nodes in the Selection, splitting nodes where necessary
to get offset-level precision.

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

The nodes in the Selection

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[extract](../interfaces/lexical.BaseSelection.md#extract)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1355](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1355)

___

### formatText

▸ **formatText**(`formatType`): `void`

Applies the provided format to the TextNodes in the Selection, splitting or
merging nodes as necessary.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `formatType` | [`TextFormatType`](../modules/lexical.md#textformattype) | the format type to apply to the nodes in the Selection. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1073](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1073)

___

### forwardDeletion

▸ **forwardDeletion**(`anchor`, `anchorNode`, `isBackward`): `boolean`

Helper for handling forward character and word deletion that prevents element nodes
like a table, columns layout being destroyed

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `anchor` | [`PointType`](../modules/lexical.md#pointtype) | the anchor |
| `anchorNode` | [`ElementNode`](lexical.ElementNode.md) \| [`TextNode`](lexical.TextNode.md) | the anchor node in the selection |
| `isBackward` | `boolean` | whether or not selection is backwards |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1562](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1562)

___

### getCachedNodes

▸ **getCachedNodes**(): ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Returns

``null`` \| [`LexicalNode`](lexical.LexicalNode.md)[]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getCachedNodes](../interfaces/lexical.BaseSelection.md#getcachednodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:421](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L421)

___

### getNodes

▸ **getNodes**(): [`LexicalNode`](lexical.LexicalNode.md)[]

Gets all the nodes in the Selection. Uses caching to make it generally suitable
for use in hot paths.

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

an Array containing all the nodes in the Selection

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getNodes](../interfaces/lexical.BaseSelection.md#getnodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:463](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L463)

___

### getStartEndPoints

▸ **getStartEndPoints**(): ``null`` \| [[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Returns

``null`` \| [[`PointType`](../modules/lexical.md#pointtype), [`PointType`](../modules/lexical.md#pointtype)]

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getStartEndPoints](../interfaces/lexical.BaseSelection.md#getstartendpoints)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1756](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1756)

___

### getTextContent

▸ **getTextContent**(): `string`

Gets the (plain) text content of all the nodes in the selection.

#### Returns

`string`

a string representing the text content of all the nodes in the Selection

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[getTextContent](../interfaces/lexical.BaseSelection.md#gettextcontent)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:540](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L540)

___

### hasFormat

▸ **hasFormat**(`type`): `boolean`

Returns whether the provided TextFormatType is present on the Selection. This will be true if any node in the Selection
has the specified format.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | [`TextFormatType`](../modules/lexical.md#textformattype) | the TextFormatType to check for. |

#### Returns

`boolean`

true if the provided format is currently toggled on on the Selection, false otherwise.

#### Defined in

[packages/lexical/src/LexicalSelection.ts:683](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L683)

___

### insertLineBreak

▸ **insertLineBreak**(`selectStart?`): `void`

Inserts a logical linebreak, which may be a new LineBreakNode or a new ParagraphNode, into the EditorState at the
current Selection.

#### Parameters

| Name | Type |
| :------ | :------ |
| `selectStart?` | `boolean` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1338](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1338)

___

### insertNodes

▸ **insertNodes**(`nodes`): `void`

Attempts to "intelligently" insert an arbitrary list of Lexical nodes into the EditorState at the
current Selection according to a set of heuristics that determine how surrounding nodes
should be changed, replaced, or moved to accomodate the incoming ones.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `nodes` | [`LexicalNode`](lexical.LexicalNode.md)[] | the nodes to insert |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertNodes](../interfaces/lexical.BaseSelection.md#insertnodes)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1208](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1208)

___

### insertParagraph

▸ **insertParagraph**(): ``null`` \| [`ElementNode`](lexical.ElementNode.md)

Inserts a new ParagraphNode into the EditorState at the current Selection

#### Returns

``null`` \| [`ElementNode`](lexical.ElementNode.md)

the newly inserted node.

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1310](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1310)

___

### insertRawText

▸ **insertRawText**(`text`): `void`

Attempts to insert the provided text into the EditorState at the current Selection.
converts tabs, newlines, and carriage returns into LexicalNodes.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `text` | `string` | the text to insert into the Selection |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertRawText](../interfaces/lexical.BaseSelection.md#insertrawtext)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:694](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L694)

___

### insertText

▸ **insertText**(`text`): `void`

Attempts to insert the provided text into the EditorState at the current Selection as a new
Lexical TextNode, according to a series of insertion heuristics based on the selection type and position.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `text` | `string` | the text to insert into the Selection |

#### Returns

`void`

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[insertText](../interfaces/lexical.BaseSelection.md#inserttext)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:717](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L717)

___

### is

▸ **is**(`selection`): `boolean`

Used to check if the provided selections is equal to this one by value,
inluding anchor, focus, format, and style properties.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | the Selection to compare this one to. |

#### Returns

`boolean`

true if the Selections are equal, false otherwise.

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[is](../interfaces/lexical.BaseSelection.md#is)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:435](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L435)

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

[packages/lexical/src/LexicalSelection.ts:1752](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1752)

___

### isCollapsed

▸ **isCollapsed**(): `boolean`

Returns whether the Selection is "collapsed", meaning the anchor and focus are
the same node and have the same offset.

#### Returns

`boolean`

true if the Selection is collapsed, false otherwise.

#### Implementation of

[BaseSelection](../interfaces/lexical.BaseSelection.md).[isCollapsed](../interfaces/lexical.BaseSelection.md#iscollapsed)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:453](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L453)

___

### modify

▸ **modify**(`alter`, `isBackward`, `granularity`): `void`

Modifies the Selection according to the parameters and a set of heuristics that account for
various node types. Can be used to safely move or extend selection by one logical "unit" without
dealing explicitly with all the possible node types.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `alter` | ``"move"`` \| ``"extend"`` | the type of modification to perform |
| `isBackward` | `boolean` | whether or not selection is backwards |
| `granularity` | ``"character"`` \| ``"lineboundary"`` \| ``"word"`` | the granularity at which to apply the modification |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1413](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1413)

___

### removeText

▸ **removeText**(): `void`

Removes the text in the Selection, adjusting the EditorState accordingly.

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1063](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1063)

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

[packages/lexical/src/LexicalSelection.ts:425](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L425)

___

### setStyle

▸ **setStyle**(`style`): `void`

Sets the value of the style property on the Selection

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `style` | `string` | the style to set at the value of the style property. |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:671](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L671)

___

### setTextNodeRange

▸ **setTextNodeRange**(`anchorNode`, `anchorOffset`, `focusNode`, `focusOffset`): `void`

Sets this Selection to be of type "text" at the provided anchor and focus values.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `anchorNode` | [`TextNode`](lexical.TextNode.md) | the anchor node to set on the Selection |
| `anchorOffset` | `number` | the offset to set on the Selection |
| `focusNode` | [`TextNode`](lexical.TextNode.md) | the focus node to set on the Selection |
| `focusOffset` | `number` | the focus offset to set on the Selection |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:523](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L523)

___

### toggleFormat

▸ **toggleFormat**(`format`): `void`

Toggles the provided format on all the TextNodes in the Selection.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `format` | [`TextFormatType`](../modules/lexical.md#textformattype) | a string TextFormatType to toggle on the TextNodes in the selection |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:661](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L661)
