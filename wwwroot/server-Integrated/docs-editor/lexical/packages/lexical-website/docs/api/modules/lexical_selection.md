---
id: "lexical_selection"
title: "Module: @lexical/selection"
custom_edit_url: null
---

## References

### $cloneWithProperties

Re-exports [$cloneWithProperties](lexical.md#$clonewithproperties)

## Functions

### $addNodeStyle

▸ **$addNodeStyle**(`node`): `void`

Gets the TextNode's style object and adds the styles to the CSS.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | [`TextNode`](../classes/lexical.TextNode.md) | The TextNode to add styles to. |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/lexical-node.ts:236](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/lexical-node.ts#L236)

___

### $getSelectionStyleValueForProperty

▸ **$getSelectionStyleValueForProperty**(`selection`, `styleProperty`, `defaultValue?`): `string`

Returns the current value of a CSS property for TextNodes in the Selection, if set. If not set, it returns the defaultValue.
If all TextNodes do not have the same value, it returns an empty string.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) \| [`TableSelection`](../classes/lexical_table.TableSelection.md) | `undefined` | The selection of TextNodes whose value to find. |
| `styleProperty` | `string` | `undefined` | The CSS style property. |
| `defaultValue` | `string` | `''` | The default value for the property, defaults to an empty string. |

#### Returns

`string`

The value of the property for the selected TextNodes.

#### Defined in

[packages/lexical-selection/src/range-selection.ts:520](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L520)

___

### $isAtNodeEnd

▸ **$isAtNodeEnd**(`point`): `boolean`

Determines if the current selection is at the end of the node.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `point` | [`Point`](../classes/lexical.Point.md) | The point of the selection to test. |

#### Returns

`boolean`

true if the provided point offset is in the last possible position, false otherwise.

#### Defined in

[packages/lexical-selection/src/lexical-node.ts:92](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/lexical-node.ts#L92)

___

### $isParentElementRTL

▸ **$isParentElementRTL**(`selection`): `boolean`

Tests a parent element for right to left direction.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) | The selection whose parent is to be tested. |

#### Returns

`boolean`

true if the selections' parent element has a direction of 'rtl' (right to left), false otherwise.

#### Defined in

[packages/lexical-selection/src/range-selection.ts:426](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L426)

___

### $moveCaretSelection

▸ **$moveCaretSelection**(`selection`, `isHoldingShift`, `isBackward`, `granularity`): `void`

Moves the selection according to the arguments.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) | The selected text or nodes. |
| `isHoldingShift` | `boolean` | Is the shift key being held down during the operation. |
| `isBackward` | `boolean` | Is the selection selected backwards (the focus comes before the anchor)? |
| `granularity` | ``"character"`` \| ``"lineboundary"`` \| ``"word"`` | The distance to adjust the current selection. |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/range-selection.ts:412](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L412)

___

### $moveCharacter

▸ **$moveCharacter**(`selection`, `isHoldingShift`, `isBackward`): `void`

Moves selection by character according to arguments.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) | The selection of the characters to move. |
| `isHoldingShift` | `boolean` | Is the shift key being held down during the operation. |
| `isBackward` | `boolean` | Is the selection backward (the focus comes before the anchor)? |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/range-selection.ts:441](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L441)

___

### $patchStyleText

▸ **$patchStyleText**(`selection`, `patch`): `void`

Applies the provided styles to the TextNodes in the provided Selection.
Will update partially selected TextNodes by splitting the TextNode and applying
the styles to the appropriate one.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | The selected node(s) to update. |
| `patch` | `Record`\<`string`, ``null`` \| `string` \| (`currentStyleValue`: ``null`` \| `string`) => `string`\> | The patch to apply, which can include multiple styles. \{CSSProperty: value\} . Can also accept a function that returns the new property value. |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/lexical-node.ts:277](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/lexical-node.ts#L277)

___

### $selectAll

▸ **$selectAll**(`selection`): `void`

Expands the current Selection to cover all of the content in the editor.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) | The current selection. |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/range-selection.ts:459](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L459)

___

### $setBlocksType

▸ **$setBlocksType**(`selection`, `createElement`): `void`

Converts all nodes in the selection that are of one block type to another.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | The selected blocks to be converted. |
| `createElement` | () => [`ElementNode`](../classes/lexical.ElementNode.md) | The function that creates the node. eg. $createParagraphNode. |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/range-selection.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L44)

___

### $shouldOverrideDefaultCharacterSelection

▸ **$shouldOverrideDefaultCharacterSelection**(`selection`, `isBackward`): `boolean`

Determines if the default character selection should be overridden. Used with DecoratorNodes

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) | The selection whose default character selection may need to be overridden. |
| `isBackward` | `boolean` | Is the selection backwards (the focus comes before the anchor)? |

#### Returns

`boolean`

true if it should be overridden, false if not.

#### Defined in

[packages/lexical-selection/src/range-selection.ts:391](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L391)

___

### $sliceSelectedTextNodeContent

▸ **$sliceSelectedTextNodeContent**(`selection`, `textNode`): [`LexicalNode`](../classes/lexical.LexicalNode.md)

Generally used to append text content to HTML and JSON. Grabs the text content and "slices"
it to be generated into the new TextNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | The selection containing the node whose TextNode is to be edited. |
| `textNode` | [`TextNode`](../classes/lexical.TextNode.md) | The TextNode to be edited. |

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)

The updated TextNode.

#### Defined in

[packages/lexical-selection/src/lexical-node.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/lexical-node.ts#L41)

___

### $trimTextContentFromAnchor

▸ **$trimTextContentFromAnchor**(`editor`, `anchor`, `delCount`): `void`

Trims text from a node in order to shorten it, eg. to enforce a text's max length. If it deletes text
that is an ancestor of the anchor then it will leave 2 indents, otherwise, if no text content exists, it deletes
the TextNode. It will move the focus to either the end of any left over text or beginning of a new TextNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `anchor` | [`Point`](../classes/lexical.Point.md) | The anchor of the current selection, where the selection should be pointing. |
| `delCount` | `number` | The amount of characters to delete. Useful as a dynamic variable eg. textContentSize - maxLength; |

#### Returns

`void`

#### Defined in

[packages/lexical-selection/src/lexical-node.ts:113](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/lexical-node.ts#L113)

___

### $wrapNodes

▸ **$wrapNodes**(`selection`, `createElement`, `wrappingElement?`): `void`

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | `undefined` | The selection of nodes to be wrapped. |
| `createElement` | () => [`ElementNode`](../classes/lexical.ElementNode.md) | `undefined` | A function that creates the wrapping ElementNode. eg. $createParagraphNode. |
| `wrappingElement` | ``null`` \| [`ElementNode`](../classes/lexical.ElementNode.md) | `null` | An element to append the wrapped selection and its children to. |

#### Returns

`void`

**`Deprecated`**

Wraps all nodes in the selection into another node of the type returned by createElement.

#### Defined in

[packages/lexical-selection/src/range-selection.ts:116](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/range-selection.ts#L116)

___

### createDOMRange

▸ **createDOMRange**(`editor`, `anchorNode`, `_anchorOffset`, `focusNode`, `_focusOffset`): `Range` \| ``null``

Creates a selection range for the DOM.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `anchorNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The anchor node of a selection. |
| `_anchorOffset` | `number` | The amount of space offset from the anchor to the focus. |
| `focusNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The current focus. |
| `_focusOffset` | `number` | The amount of space offset from the focus to the anchor. |

#### Returns

`Range` \| ``null``

The range of selection for the DOM that was created.

#### Defined in

[packages/lexical-selection/src/utils.ts:47](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/utils.ts#L47)

___

### createRectsFromDOMRange

▸ **createRectsFromDOMRange**(`editor`, `range`): `ClientRect`[]

Creates DOMRects, generally used to help the editor find a specific location on the screen.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor |
| `range` | `Range` | A fragment of a document that can contain nodes and parts of text nodes. |

#### Returns

`ClientRect`[]

The selectionRects as an array.

#### Defined in

[packages/lexical-selection/src/utils.ts:124](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/utils.ts#L124)

___

### getStyleObjectFromCSS

▸ **getStyleObjectFromCSS**(`css`): `Record`\<`string`, `string`\>

Given a CSS string, returns an object from the style cache.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `css` | `string` | The CSS property as a string. |

#### Returns

`Record`\<`string`, `string`\>

The value of the given CSS property.

#### Defined in

[packages/lexical-selection/src/utils.ts:198](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/utils.ts#L198)

___

### trimTextContentFromAnchor

▸ **trimTextContentFromAnchor**(`editor`, `anchor`, `delCount`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `anchor` | [`Point`](../classes/lexical.Point.md) |
| `delCount` | `number` |

#### Returns

`void`

**`Deprecated`**

renamed to [$trimTextContentFromAnchor](lexical_selection.md#$trimtextcontentfromanchor) by @lexical/eslint-plugin rules-of-lexical

#### Defined in

[packages/lexical-selection/src/index.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-selection/src/index.ts#L43)
