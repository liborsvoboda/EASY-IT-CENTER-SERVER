---
id: "lexical.ElementNode"
title: "Class: ElementNode"
custom_edit_url: null
---

[lexical](../modules/lexical.md).ElementNode

## Hierarchy

- [`LexicalNode`](lexical.LexicalNode.md)

  ↳ **`ElementNode`**

  ↳↳ [`LinkNode`](lexical_link.LinkNode.md)

  ↳↳ [`OverflowNode`](lexical_overflow.OverflowNode.md)

  ↳↳ [`QuoteNode`](lexical_rich_text.QuoteNode.md)

  ↳↳ [`HeadingNode`](lexical_rich_text.HeadingNode.md)

  ↳↳ [`ArtificialNode__DO_NOT_USE`](lexical.ArtificialNode__DO_NOT_USE.md)

  ↳↳ [`ParagraphNode`](lexical.ParagraphNode.md)

  ↳↳ [`RootNode`](lexical.RootNode.md)

  ↳↳ [`CodeNode`](lexical_code.CodeNode.md)

  ↳↳ [`ListItemNode`](lexical_list.ListItemNode.md)

  ↳↳ [`ListNode`](lexical_list.ListNode.md)

  ↳↳ [`MarkNode`](lexical_mark.MarkNode.md)

  ↳↳ [`TableCellNode`](lexical_table.TableCellNode.md)

  ↳↳ [`TableNode`](lexical_table.TableNode.md)

  ↳↳ [`TableRowNode`](lexical_table.TableRowNode.md)

## Constructors

### constructor

• **new ElementNode**(`key?`): [`ElementNode`](lexical.ElementNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`ElementNode`](lexical.ElementNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[constructor](lexical.LexicalNode.md#constructor)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:85](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L85)

## Properties

### constructor

• **constructor**: [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`ElementNode`](lexical.ElementNode.md)\>

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L69)

___

### importDOM

▪ `Static` `Optional` **importDOM**: () => ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)\<`any`\>

#### Type declaration

▸ (): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)\<`any`\>

##### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)\<`any`\>

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[importDOM](lexical.LexicalNode.md#importdom)

#### Defined in

[packages/lexical/src/LexicalNode.ts:209](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L209)

## Methods

### append

▸ **append**(`...nodesToAppend`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `...nodesToAppend` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:362](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L362)

___

### canBeEmpty

▸ **canBeEmpty**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:555](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L555)

___

### canIndent

▸ **canIndent**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:533](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L533)

___

### canInsertTextAfter

▸ **canInsertTextAfter**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:561](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L561)

___

### canInsertTextBefore

▸ **canInsertTextBefore**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:558](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L558)

___

### canMergeWhenEmpty

▸ **canMergeWhenEmpty**(): `boolean`

Determines whether this node, when empty, can merge with a first block
of nodes being inserted.

This method is specifically called in [RangeSelection.insertNodes](lexical.RangeSelection.md#insertnodes)
to determine merging behavior during nodes insertion.

#### Returns

`boolean`

**`Example`**

```ts
// In a ListItemNode or QuoteNode implementation:
canMergeWhenEmpty(): true {
 return true;
}
```

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:599](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L599)

___

### clear

▸ **clear**(): `this`

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:356](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L356)

___

### collapseAtStart

▸ **collapseAtStart**(`selection`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:541](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L541)

___

### createDOM

▸ **createDOM**(`_config`, `_editor`): `HTMLElement`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `_config` | [`EditorConfig`](../modules/lexical.md#editorconfig) | allows access to things like the EditorTheme (to apply classes) during reconciliation. |
| `_editor` | [`LexicalEditor`](lexical.LexicalEditor.md) | allows access to the editor for context during reconciliation. |

#### Returns

`HTMLElement`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[createDOM](lexical.LexicalNode.md#createdom)

#### Defined in

[packages/lexical/src/LexicalNode.ts:769](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L769)

___

### createParentElementNode

▸ **createParentElementNode**(): [`ElementNode`](lexical.ElementNode.md)

The creation logic for any required parent. Should be implemented if [isParentRequired](lexical.LexicalNode.md#isparentrequired) returns true.

#### Returns

[`ElementNode`](lexical.ElementNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[createParentElementNode](lexical.LexicalNode.md#createparentelementnode)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1048](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1048)

___

### excludeFromCopy

▸ **excludeFromCopy**(`destination?`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `destination?` | ``"html"`` \| ``"clone"`` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:544](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L544)

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

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[exportDOM](lexical.LexicalNode.md#exportdom)

#### Defined in

[packages/lexical/src/LexicalNode.ts:799](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L799)

___

### exportJSON

▸ **exportJSON**(): [`SerializedElementNode`](../modules/lexical.md#serializedelementnode)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedElementNode`](../modules/lexical.md#serializedelementnode)\<[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)\>

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[exportJSON](lexical.LexicalNode.md#exportjson)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:516](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L516)

___

### extractWithChild

▸ **extractWithChild**(`child`, `selection`, `destination`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `child` | [`LexicalNode`](lexical.LexicalNode.md) |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |
| `destination` | ``"html"`` \| ``"clone"`` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:578](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L578)

___

### getAllTextNodes

▸ **getAllTextNodes**(): [`TextNode`](lexical.TextNode.md)[]

#### Returns

[`TextNode`](lexical.TextNode.md)[]

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:147](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L147)

___

### getChildAtIndex

▸ **getChildAtIndex**\<`T`\>(`index`): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `index` | `number` |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:228](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L228)

___

### getChildren

▸ **getChildren**\<`T`\>(): `T`[]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`T`[]

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:112](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L112)

___

### getChildrenKeys

▸ **getChildrenKeys**(): `string`[]

#### Returns

`string`[]

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:121](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L121)

___

### getChildrenSize

▸ **getChildrenSize**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:130](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L130)

___

### getCommonAncestor

▸ **getCommonAncestor**\<`T`\>(`node`): ``null`` \| `T`

Returns the closest common ancestor of this node and the provided one or null
if one cannot be found.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`ElementNode`](lexical.ElementNode.md) = [`ElementNode`](lexical.ElementNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | [`LexicalNode`](lexical.LexicalNode.md) | the other node to find the common ancestor of. |

#### Returns

``null`` \| `T`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getCommonAncestor](lexical.LexicalNode.md#getcommonancestor)

#### Defined in

[packages/lexical/src/LexicalNode.ts:508](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L508)

___

### getDescendantByIndex

▸ **getDescendantByIndex**\<`T`\>(`index`): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `index` | `number` |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:184](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L184)

___

### getDirection

▸ **getDirection**(): ``null`` \| ``"rtl"`` \| ``"ltr"``

#### Returns

``null`` \| ``"rtl"`` \| ``"ltr"``

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:289](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L289)

___

### getFirstChild

▸ **getFirstChild**\<`T`\>(): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:204](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L204)

___

### getFirstChildOrThrow

▸ **getFirstChildOrThrow**\<`T`\>(): `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:209](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L209)

___

### getFirstDescendant

▸ **getFirstDescendant**\<`T`\>(): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:162](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L162)

___

### getFormat

▸ **getFormat**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:96](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L96)

___

### getFormatType

▸ **getFormatType**(): [`ElementFormatType`](../modules/lexical.md#elementformattype)

#### Returns

[`ElementFormatType`](../modules/lexical.md#elementformattype)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:100](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L100)

___

### getIndent

▸ **getIndent**(): `number`

#### Returns

`number`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:108](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L108)

___

### getIndexWithinParent

▸ **getIndexWithinParent**(): `number`

Returns the zero-based index of this node within the parent.

#### Returns

`number`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getIndexWithinParent](lexical.LexicalNode.md#getindexwithinparent)

#### Defined in

[packages/lexical/src/LexicalNode.ts:336](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L336)

___

### getKey

▸ **getKey**(): `string`

Returns this nodes key.

#### Returns

`string`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getKey](lexical.LexicalNode.md#getkey)

#### Defined in

[packages/lexical/src/LexicalNode.ts:328](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L328)

___

### getLastChild

▸ **getLastChild**\<`T`\>(): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:216](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L216)

___

### getLastChildOrThrow

▸ **getLastChildOrThrow**\<`T`\>(): `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:221](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L221)

___

### getLastDescendant

▸ **getLastDescendant**\<`T`\>(): ``null`` \| `T`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:173](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L173)

___

### getLatest

▸ **getLatest**(): `this`

Returns the latest version of the node from the active EditorState.
This is used to avoid getting values from stale node references.

#### Returns

`this`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getLatest](lexical.LexicalNode.md#getlatest)

#### Defined in

[packages/lexical/src/LexicalNode.ts:694](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L694)

___

### getNextSibling

▸ **getNextSibling**\<`T`\>(): ``null`` \| `T`

Returns the "next" siblings - that is, the node that comes
after this one in the same parent

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getNextSibling](lexical.LexicalNode.md#getnextsibling)

#### Defined in

[packages/lexical/src/LexicalNode.ts:481](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L481)

___

### getNextSiblings

▸ **getNextSiblings**\<`T`\>(): `T`[]

Returns all "next" siblings - that is, the nodes that come between this
one and the last child of it's parent, inclusive.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`T`[]

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getNextSiblings](lexical.LexicalNode.md#getnextsiblings)

#### Defined in

[packages/lexical/src/LexicalNode.ts:492](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L492)

___

### getNodesBetween

▸ **getNodesBetween**(`targetNode`): [`LexicalNode`](lexical.LexicalNode.md)[]

Returns a list of nodes that are between this node and
the target node in the EditorState.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `targetNode` | [`LexicalNode`](lexical.LexicalNode.md) | the node that marks the other end of the range of nodes to be returned. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)[]

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getNodesBetween](lexical.LexicalNode.md#getnodesbetween)

#### Defined in

[packages/lexical/src/LexicalNode.ts:613](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L613)

___

### getParent

▸ **getParent**\<`T`\>(): ``null`` \| `T`

Returns the parent of this node, or null if none is found.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`ElementNode`](lexical.ElementNode.md) |

#### Returns

``null`` \| `T`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getParent](lexical.LexicalNode.md#getparent)

#### Defined in

[packages/lexical/src/LexicalNode.ts:356](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L356)

___

### getParentKeys

▸ **getParentKeys**(): `string`[]

Returns a list of the keys of every ancestor of this node,
all the way up to the RootNode.

#### Returns

`string`[]

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getParentKeys](lexical.LexicalNode.md#getparentkeys)

#### Defined in

[packages/lexical/src/LexicalNode.ts:433](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L433)

___

### getParentOrThrow

▸ **getParentOrThrow**\<`T`\>(): `T`

Returns the parent of this node, or throws if none is found.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`ElementNode`](lexical.ElementNode.md) |

#### Returns

`T`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getParentOrThrow](lexical.LexicalNode.md#getparentorthrow)

#### Defined in

[packages/lexical/src/LexicalNode.ts:367](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L367)

___

### getParents

▸ **getParents**(): [`ElementNode`](lexical.ElementNode.md)[]

Returns a list of the every ancestor of this node,
all the way up to the RootNode.

#### Returns

[`ElementNode`](lexical.ElementNode.md)[]

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getParents](lexical.LexicalNode.md#getparents)

#### Defined in

[packages/lexical/src/LexicalNode.ts:418](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L418)

___

### getPreviousSibling

▸ **getPreviousSibling**\<`T`\>(): ``null`` \| `T`

Returns the "previous" siblings - that is, the node that comes
before this one in the same parent.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

``null`` \| `T`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getPreviousSibling](lexical.LexicalNode.md#getprevioussibling)

#### Defined in

[packages/lexical/src/LexicalNode.ts:448](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L448)

___

### getPreviousSiblings

▸ **getPreviousSiblings**\<`T`\>(): `T`[]

Returns the "previous" siblings - that is, the nodes that come between
this one and the first child of it's parent, inclusive.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Returns

`T`[]

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getPreviousSiblings](lexical.LexicalNode.md#getprevioussiblings)

#### Defined in

[packages/lexical/src/LexicalNode.ts:459](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L459)

___

### getStyle

▸ **getStyle**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:104](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L104)

___

### getTextContent

▸ **getTextContent**(): `string`

Returns the text content of the node. Override this for
custom nodes that should have a representation in plain text
format (for copy + paste, for example)

#### Returns

`string`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getTextContent](lexical.LexicalNode.md#gettextcontent)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:255](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L255)

___

### getTextContentSize

▸ **getTextContentSize**(): `number`

Returns the length of the string produced by calling getTextContent on this node.

#### Returns

`number`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getTextContentSize](lexical.LexicalNode.md#gettextcontentsize)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:272](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L272)

___

### getTopLevelElement

▸ **getTopLevelElement**(): ``null`` \| [`ElementNode`](lexical.ElementNode.md)

Returns the highest (in the EditorState tree)
non-root ancestor of this node, or null if none is found. See [lexical!$isRootOrShadowRoot](../modules/lexical.md#$isrootorshadowroot)
for more information on which Elements comprise "roots".

#### Returns

``null`` \| [`ElementNode`](lexical.ElementNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getTopLevelElement](lexical.LexicalNode.md#gettoplevelelement)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L62)

___

### getTopLevelElementOrThrow

▸ **getTopLevelElementOrThrow**(): [`ElementNode`](lexical.ElementNode.md)

Returns the highest (in the EditorState tree)
non-root ancestor of this node, or throws if none is found. See [lexical!$isRootOrShadowRoot](../modules/lexical.md#$isrootorshadowroot)
for more information on which Elements comprise "roots".

#### Returns

[`ElementNode`](lexical.ElementNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getTopLevelElementOrThrow](lexical.LexicalNode.md#gettoplevelelementorthrow)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L63)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node.

#### Returns

`string`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getType](lexical.LexicalNode.md#gettype)

#### Defined in

[packages/lexical/src/LexicalNode.ts:230](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L230)

___

### getWritable

▸ **getWritable**(): `this`

Returns a mutable version of the node. Will throw an error if
called outside of a Lexical Editor [LexicalEditor.update](lexical.LexicalEditor.md#update) callback.

#### Returns

`this`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getWritable](lexical.LexicalNode.md#getwritable)

#### Defined in

[packages/lexical/src/LexicalNode.ts:710](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L710)

___

### hasFormat

▸ **hasFormat**(`type`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`ElementFormatType`](../modules/lexical.md#elementformattype) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:293](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L293)

___

### insertAfter

▸ **insertAfter**(`nodeToInsert`, `restoreSelection?`): [`LexicalNode`](lexical.LexicalNode.md)

Inserts a node after this LexicalNode (as the next sibling).

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `nodeToInsert` | [`LexicalNode`](lexical.LexicalNode.md) | `undefined` | The node to insert after this one. |
| `restoreSelection` | `boolean` | `true` | Whether or not to attempt to resolve the selection to the appropriate place after the operation is complete. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[insertAfter](lexical.LexicalNode.md#insertafter)

#### Defined in

[packages/lexical/src/LexicalNode.ts:933](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L933)

___

### insertBefore

▸ **insertBefore**(`nodeToInsert`, `restoreSelection?`): [`LexicalNode`](lexical.LexicalNode.md)

Inserts a node before this LexicalNode (as the previous sibling).

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `nodeToInsert` | [`LexicalNode`](lexical.LexicalNode.md) | `undefined` | The node to insert before this one. |
| `restoreSelection` | `boolean` | `true` | Whether or not to attempt to resolve the selection to the appropriate place after the operation is complete. |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[insertBefore](lexical.LexicalNode.md#insertbefore)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1000](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1000)

___

### insertNewAfter

▸ **insertNewAfter**(`selection`, `restoreSelection?`): ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) |
| `restoreSelection?` | `boolean` |

#### Returns

``null`` \| [`LexicalNode`](lexical.LexicalNode.md)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:527](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L527)

___

### is

▸ **is**(`object`): `boolean`

Returns true if the provided node is the exact same one as this node, from Lexical's perspective.
Always use this instead of referential equality.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `object` | `undefined` \| ``null`` \| [`LexicalNode`](lexical.LexicalNode.md) | the node to perform the equality comparison on. |

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[is](lexical.LexicalNode.md#is)

#### Defined in

[packages/lexical/src/LexicalNode.ts:540](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L540)

___

### isAttached

▸ **isAttached**(): `boolean`

Returns true if there is a path between this node and the RootNode, false otherwise.
This is a way of determining if the node is "attached" EditorState. Unattached nodes
won't be reconciled and will ultimatelt be cleaned up by the Lexical GC.

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isAttached](lexical.LexicalNode.md#isattached)

#### Defined in

[packages/lexical/src/LexicalNode.ts:247](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L247)

___

### isBefore

▸ **isBefore**(`targetNode`): `boolean`

Returns true if this node logical precedes the target node in the editor state.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `targetNode` | [`LexicalNode`](lexical.LexicalNode.md) | the node we're testing to see if it's after this one. |

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isBefore](lexical.LexicalNode.md#isbefore)

#### Defined in

[packages/lexical/src/LexicalNode.ts:552](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L552)

___

### isDirty

▸ **isDirty**(): `boolean`

Returns true if this node has been marked dirty during this update cycle.

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isDirty](lexical.LexicalNode.md#isdirty)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:137](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L137)

___

### isEmpty

▸ **isEmpty**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:134](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L134)

___

### isInline

▸ **isInline**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isInline](lexical.LexicalNode.md#isinline)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:564](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L564)

___

### isLastChild

▸ **isLastChild**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:142](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L142)

___

### isParentOf

▸ **isParentOf**(`targetNode`): `boolean`

Returns true if this node is the parent of the target node, false otherwise.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `targetNode` | [`LexicalNode`](lexical.LexicalNode.md) | the would-be child node. |

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isParentOf](lexical.LexicalNode.md#isparentof)

#### Defined in

[packages/lexical/src/LexicalNode.ts:591](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L591)

___

### isParentRequired

▸ **isParentRequired**(): `boolean`

Whether or not this node has a required parent. Used during copy + paste operations
to normalize nodes that would otherwise be orphaned. For example, ListItemNodes without
a ListNode parent or TextNodes with a ParagraphNode parent.

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isParentRequired](lexical.LexicalNode.md#isparentrequired)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1040](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1040)

___

### isSelected

▸ **isSelected**(`selection?`): `boolean`

Returns true if this node is contained within the provided Selection., false otherwise.
Relies on the algorithms implemented in [BaseSelection.getNodes](../interfaces/lexical.BaseSelection.md#getnodes) to determine
what's included.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selection?` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) | The selection that we want to determine if the node is in. |

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[isSelected](lexical.LexicalNode.md#isselected)

#### Defined in

[packages/lexical/src/LexicalNode.ts:271](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L271)

___

### isShadowRoot

▸ **isShadowRoot**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:571](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L571)

___

### markDirty

▸ **markDirty**(): `void`

Marks a node dirty, triggering transforms and
forcing it to be reconciled during the update cycle.

#### Returns

`void`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[markDirty](lexical.LexicalNode.md#markdirty)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1109](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1109)

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

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[remove](lexical.LexicalNode.md#remove)

#### Defined in

[packages/lexical/src/LexicalNode.ts:852](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L852)

___

### replace

▸ **replace**\<`N`\>(`replaceWith`, `includeChildren?`): `N`

Replaces this LexicalNode with the provided node, optionally transferring the children
of the replaced node to the replacing node.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | extends [`LexicalNode`](lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `replaceWith` | `N` | The node to replace this one with. |
| `includeChildren?` | `boolean` | Whether or not to transfer the children of this node to the replacing node. |

#### Returns

`N`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[replace](lexical.LexicalNode.md#replace)

#### Defined in

[packages/lexical/src/LexicalNode.ts:863](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L863)

___

### select

▸ **select**(`_anchorOffset?`, `_focusOffset?`): [`RangeSelection`](lexical.RangeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `_anchorOffset?` | `number` |
| `_focusOffset?` | `number` |

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:303](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L303)

___

### selectEnd

▸ **selectEnd**(): [`RangeSelection`](lexical.RangeSelection.md)

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[selectEnd](lexical.LexicalNode.md#selectend)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:352](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L352)

___

### selectNext

▸ **selectNext**(`anchorOffset?`, `focusOffset?`): [`RangeSelection`](lexical.RangeSelection.md)

Moves selection to the next sibling of this node, at the specified offsets.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `anchorOffset?` | `number` | The anchor offset for selection. |
| `focusOffset?` | `number` | The focus offset for selection |

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[selectNext](lexical.LexicalNode.md#selectnext)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1088](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1088)

___

### selectPrevious

▸ **selectPrevious**(`anchorOffset?`, `focusOffset?`): [`RangeSelection`](lexical.RangeSelection.md)

Moves selection to the previous sibling of this node, at the specified offsets.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `anchorOffset?` | `number` | The anchor offset for selection. |
| `focusOffset?` | `number` | The focus offset for selection |

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[selectPrevious](lexical.LexicalNode.md#selectprevious)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1066](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1066)

___

### selectStart

▸ **selectStart**(): [`RangeSelection`](lexical.RangeSelection.md)

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[selectStart](lexical.LexicalNode.md#selectstart)

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:348](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L348)

___

### setDirection

▸ **setDirection**(`direction`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `direction` | ``null`` \| ``"rtl"`` \| ``"ltr"`` |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:365](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L365)

___

### setFormat

▸ **setFormat**(`type`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | [`ElementFormatType`](../modules/lexical.md#elementformattype) |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:370](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L370)

___

### setIndent

▸ **setIndent**(`indentLevel`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `indentLevel` | `number` |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:380](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L380)

___

### setStyle

▸ **setStyle**(`style`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `style` | `string` |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:375](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L375)

___

### splice

▸ **splice**(`start`, `deleteCount`, `nodesToInsert`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `start` | `number` |
| `deleteCount` | `number` |
| `nodesToInsert` | [`LexicalNode`](lexical.LexicalNode.md)[] |

#### Returns

`this`

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:385](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L385)

___

### updateDOM

▸ **updateDOM**(`_prevNode`, `_dom`, `_config`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `_prevNode` | `unknown` |
| `_dom` | `HTMLElement` |
| `_config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[updateDOM](lexical.LexicalNode.md#updatedom)

#### Defined in

[packages/lexical/src/LexicalNode.ts:783](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L783)

___

### clone

▸ **clone**(`_data`): [`LexicalNode`](lexical.LexicalNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `_data` | `unknown` |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[clone](lexical.LexicalNode.md#clone)

#### Defined in

[packages/lexical/src/LexicalNode.ts:200](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L200)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[getType](lexical.LexicalNode.md#gettype-1)

#### Defined in

[packages/lexical/src/LexicalNode.ts:186](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L186)

___

### importJSON

▸ **importJSON**(`_serializedNode`): [`LexicalNode`](lexical.LexicalNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `_serializedNode` | [`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode) |

#### Returns

[`LexicalNode`](lexical.LexicalNode.md)

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[importJSON](lexical.LexicalNode.md#importjson)

#### Defined in

[packages/lexical/src/LexicalNode.ts:822](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L822)

___

### transform

▸ **transform**(): ``null`` \| (`node`: [`LexicalNode`](lexical.LexicalNode.md)) => `void`

Registers the returned function as a transform on the node during
Editor initialization. Most such use cases should be addressed via
the [LexicalEditor.registerNodeTransform](lexical.LexicalEditor.md#registernodetransform) API.

Experimental - use at your own risk.

#### Returns

``null`` \| (`node`: [`LexicalNode`](lexical.LexicalNode.md)) => `void`

#### Inherited from

[LexicalNode](lexical.LexicalNode.md).[transform](lexical.LexicalNode.md#transform)

#### Defined in

[packages/lexical/src/LexicalNode.ts:838](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L838)
