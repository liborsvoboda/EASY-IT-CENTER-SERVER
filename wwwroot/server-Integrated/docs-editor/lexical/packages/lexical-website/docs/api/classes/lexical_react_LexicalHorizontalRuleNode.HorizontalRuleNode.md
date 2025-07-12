---
id: "lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode"
title: "Class: HorizontalRuleNode"
custom_edit_url: null
---

[@lexical/react/LexicalHorizontalRuleNode](../modules/lexical_react_LexicalHorizontalRuleNode.md).HorizontalRuleNode

## Hierarchy

- [`DecoratorNode`](lexical.DecoratorNode.md)\<`JSX.Element`\>

  ↳ **`HorizontalRuleNode`**

## Constructors

### constructor

• **new HorizontalRuleNode**(`key?`): [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key?` | `string` |

#### Returns

[`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[constructor](lexical.DecoratorNode.md#constructor)

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:28](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L28)

## Properties

### constructor

• **constructor**: [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<(`key?`: `string`) => [`DecoratorNode`](lexical.DecoratorNode.md)\<`Element`\>\>

#### Inherited from

DecoratorNode.constructor

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:27](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L27)

## Methods

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

[DecoratorNode](lexical.DecoratorNode.md).[createDOM](lexical.DecoratorNode.md#createdom)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:150](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L150)

___

### createParentElementNode

▸ **createParentElementNode**(): [`ElementNode`](lexical.ElementNode.md)

The creation logic for any required parent. Should be implemented if [isParentRequired](lexical.LexicalNode.md#isparentrequired) returns true.

#### Returns

[`ElementNode`](lexical.ElementNode.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[createParentElementNode](lexical.DecoratorNode.md#createparentelementnode)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1048](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1048)

___

### decorate

▸ **decorate**(): `Element`

The returned value is added to the LexicalEditor._decorators

#### Returns

`Element`

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[decorate](lexical.DecoratorNode.md#decorate)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:168](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L168)

___

### exportDOM

▸ **exportDOM**(): [`DOMExportOutput`](../modules/lexical.md#domexportoutput)

Controls how the this node is serialized to HTML. This is important for
copy and paste between Lexical and non-Lexical editors, or Lexical editors with different namespaces,
in which case the primary transfer format is HTML. It's also important if you're serializing
to HTML for any other reason via [@lexical/html!$generateHtmlFromNodes](../modules/lexical_html.md#$generatehtmlfromnodes). You could
also use this method to build your own HTML renderer.

#### Returns

[`DOMExportOutput`](../modules/lexical.md#domexportoutput)

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[exportDOM](lexical.DecoratorNode.md#exportdom)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:146](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L146)

___

### exportJSON

▸ **exportJSON**(): [`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode)

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[exportJSON](lexical.DecoratorNode.md#exportjson)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:139](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L139)

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

[DecoratorNode](lexical.DecoratorNode.md).[getCommonAncestor](lexical.DecoratorNode.md#getcommonancestor)

#### Defined in

[packages/lexical/src/LexicalNode.ts:508](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L508)

___

### getIndexWithinParent

▸ **getIndexWithinParent**(): `number`

Returns the zero-based index of this node within the parent.

#### Returns

`number`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getIndexWithinParent](lexical.DecoratorNode.md#getindexwithinparent)

#### Defined in

[packages/lexical/src/LexicalNode.ts:336](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L336)

___

### getKey

▸ **getKey**(): `string`

Returns this nodes key.

#### Returns

`string`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getKey](lexical.DecoratorNode.md#getkey)

#### Defined in

[packages/lexical/src/LexicalNode.ts:328](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L328)

___

### getLatest

▸ **getLatest**(): `this`

Returns the latest version of the node from the active EditorState.
This is used to avoid getting values from stale node references.

#### Returns

`this`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getLatest](lexical.DecoratorNode.md#getlatest)

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

[DecoratorNode](lexical.DecoratorNode.md).[getNextSibling](lexical.DecoratorNode.md#getnextsibling)

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

[DecoratorNode](lexical.DecoratorNode.md).[getNextSiblings](lexical.DecoratorNode.md#getnextsiblings)

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

[DecoratorNode](lexical.DecoratorNode.md).[getNodesBetween](lexical.DecoratorNode.md#getnodesbetween)

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

[DecoratorNode](lexical.DecoratorNode.md).[getParent](lexical.DecoratorNode.md#getparent)

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

[DecoratorNode](lexical.DecoratorNode.md).[getParentKeys](lexical.DecoratorNode.md#getparentkeys)

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

[DecoratorNode](lexical.DecoratorNode.md).[getParentOrThrow](lexical.DecoratorNode.md#getparentorthrow)

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

[DecoratorNode](lexical.DecoratorNode.md).[getParents](lexical.DecoratorNode.md#getparents)

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

[DecoratorNode](lexical.DecoratorNode.md).[getPreviousSibling](lexical.DecoratorNode.md#getprevioussibling)

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

[DecoratorNode](lexical.DecoratorNode.md).[getPreviousSiblings](lexical.DecoratorNode.md#getprevioussiblings)

#### Defined in

[packages/lexical/src/LexicalNode.ts:459](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L459)

___

### getTextContent

▸ **getTextContent**(): `string`

Returns the text content of the node. Override this for
custom nodes that should have a representation in plain text
format (for copy + paste, for example)

#### Returns

`string`

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[getTextContent](lexical.DecoratorNode.md#gettextcontent)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:156](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L156)

___

### getTextContentSize

▸ **getTextContentSize**(): `number`

Returns the length of the string produced by calling getTextContent on this node.

#### Returns

`number`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getTextContentSize](lexical.DecoratorNode.md#gettextcontentsize)

#### Defined in

[packages/lexical/src/LexicalNode.ts:751](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L751)

___

### getTopLevelElement

▸ **getTopLevelElement**(): ``null`` \| [`ElementNode`](lexical.ElementNode.md) \| [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

Returns the highest (in the EditorState tree)
non-root ancestor of this node, or null if none is found. See [lexical!$isRootOrShadowRoot](../modules/lexical.md#$isrootorshadowroot)
for more information on which Elements comprise "roots".

#### Returns

``null`` \| [`ElementNode`](lexical.ElementNode.md) \| [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getTopLevelElement](lexical.DecoratorNode.md#gettoplevelelement)

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:20](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L20)

___

### getTopLevelElementOrThrow

▸ **getTopLevelElementOrThrow**(): [`ElementNode`](lexical.ElementNode.md) \| [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

Returns the highest (in the EditorState tree)
non-root ancestor of this node, or throws if none is found. See [lexical!$isRootOrShadowRoot](../modules/lexical.md#$isrootorshadowroot)
for more information on which Elements comprise "roots".

#### Returns

[`ElementNode`](lexical.ElementNode.md) \| [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getTopLevelElementOrThrow](lexical.DecoratorNode.md#gettoplevelelementorthrow)

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:21](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L21)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node.

#### Returns

`string`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[getType](lexical.DecoratorNode.md#gettype)

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

[DecoratorNode](lexical.DecoratorNode.md).[getWritable](lexical.DecoratorNode.md#getwritable)

#### Defined in

[packages/lexical/src/LexicalNode.ts:710](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L710)

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

[DecoratorNode](lexical.DecoratorNode.md).[insertAfter](lexical.DecoratorNode.md#insertafter)

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

[DecoratorNode](lexical.DecoratorNode.md).[insertBefore](lexical.DecoratorNode.md#insertbefore)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1000](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1000)

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

[DecoratorNode](lexical.DecoratorNode.md).[is](lexical.DecoratorNode.md#is)

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

[DecoratorNode](lexical.DecoratorNode.md).[isAttached](lexical.DecoratorNode.md#isattached)

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

[DecoratorNode](lexical.DecoratorNode.md).[isBefore](lexical.DecoratorNode.md#isbefore)

#### Defined in

[packages/lexical/src/LexicalNode.ts:552](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L552)

___

### isDirty

▸ **isDirty**(): `boolean`

Returns true if this node has been marked dirty during this update cycle.

#### Returns

`boolean`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[isDirty](lexical.DecoratorNode.md#isdirty)

#### Defined in

[packages/lexical/src/LexicalNode.ts:683](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L683)

___

### isInline

▸ **isInline**(): ``false``

#### Returns

``false``

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[isInline](lexical.DecoratorNode.md#isinline)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:160](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L160)

___

### isIsolated

▸ **isIsolated**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[isIsolated](lexical.DecoratorNode.md#isisolated)

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L39)

___

### isKeyboardSelectable

▸ **isKeyboardSelectable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[isKeyboardSelectable](lexical.DecoratorNode.md#iskeyboardselectable)

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:47](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L47)

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

[DecoratorNode](lexical.DecoratorNode.md).[isParentOf](lexical.DecoratorNode.md#isparentof)

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

[DecoratorNode](lexical.DecoratorNode.md).[isParentRequired](lexical.DecoratorNode.md#isparentrequired)

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

[DecoratorNode](lexical.DecoratorNode.md).[isSelected](lexical.DecoratorNode.md#isselected)

#### Defined in

[packages/lexical/src/LexicalNode.ts:271](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L271)

___

### markDirty

▸ **markDirty**(): `void`

Marks a node dirty, triggering transforms and
forcing it to be reconciled during the update cycle.

#### Returns

`void`

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[markDirty](lexical.DecoratorNode.md#markdirty)

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

[DecoratorNode](lexical.DecoratorNode.md).[remove](lexical.DecoratorNode.md#remove)

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

[DecoratorNode](lexical.DecoratorNode.md).[replace](lexical.DecoratorNode.md#replace)

#### Defined in

[packages/lexical/src/LexicalNode.ts:863](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L863)

___

### selectEnd

▸ **selectEnd**(): [`RangeSelection`](lexical.RangeSelection.md)

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[selectEnd](lexical.DecoratorNode.md#selectend)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1056](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1056)

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

[DecoratorNode](lexical.DecoratorNode.md).[selectNext](lexical.DecoratorNode.md#selectnext)

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

[DecoratorNode](lexical.DecoratorNode.md).[selectPrevious](lexical.DecoratorNode.md#selectprevious)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1066](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1066)

___

### selectStart

▸ **selectStart**(): [`RangeSelection`](lexical.RangeSelection.md)

#### Returns

[`RangeSelection`](lexical.RangeSelection.md)

#### Inherited from

[DecoratorNode](lexical.DecoratorNode.md).[selectStart](lexical.DecoratorNode.md#selectstart)

#### Defined in

[packages/lexical/src/LexicalNode.ts:1052](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L1052)

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

[DecoratorNode](lexical.DecoratorNode.md).[updateDOM](lexical.DecoratorNode.md#updatedom)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:164](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L164)

___

### clone

▸ **clone**(`node`): [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md) |

#### Returns

[`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[clone](lexical.DecoratorNode.md#clone)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:120](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L120)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[getType](lexical.DecoratorNode.md#gettype-1)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:116](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L116)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

DecoratorNode.importDOM

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:130](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L130)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedLexicalNode`](../modules/lexical.md#serializedlexicalnode) |

#### Returns

[`HorizontalRuleNode`](lexical_react_LexicalHorizontalRuleNode.HorizontalRuleNode.md)

#### Overrides

[DecoratorNode](lexical.DecoratorNode.md).[importJSON](lexical.DecoratorNode.md#importjson)

#### Defined in

[packages/lexical-react/src/LexicalHorizontalRuleNode.tsx:124](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalHorizontalRuleNode.tsx#L124)

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

[DecoratorNode](lexical.DecoratorNode.md).[transform](lexical.DecoratorNode.md#transform)

#### Defined in

[packages/lexical/src/LexicalNode.ts:838](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L838)
