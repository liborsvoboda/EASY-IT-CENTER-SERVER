---
id: "lexical_list"
title: "Module: @lexical/list"
custom_edit_url: null
---

## Classes

- [ListItemNode](../classes/lexical_list.ListItemNode.md)
- [ListNode](../classes/lexical_list.ListNode.md)

## Type Aliases

### ListType

Ƭ **ListType**: ``"number"`` \| ``"bullet"`` \| ``"check"``

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L49)

___

### SerializedListItemNode

Ƭ **SerializedListItemNode**: [`Spread`](lexical.md#spread)\<\{ `checked`: `boolean` \| `undefined` ; `value`: `number`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L45)

___

### SerializedListNode

Ƭ **SerializedListNode**: [`Spread`](lexical.md#spread)\<\{ `listType`: [`ListType`](lexical_list.md#listtype) ; `start`: `number` ; `tag`: `ListNodeTagType`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L40)

## Variables

### INSERT\_CHECK\_LIST\_COMMAND

• `Const` **INSERT\_CHECK\_LIST\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical-list/src/index.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/index.ts#L45)

___

### INSERT\_ORDERED\_LIST\_COMMAND

• `Const` **INSERT\_ORDERED\_LIST\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical-list/src/index.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/index.ts#L42)

___

### INSERT\_UNORDERED\_LIST\_COMMAND

• `Const` **INSERT\_UNORDERED\_LIST\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical-list/src/index.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/index.ts#L40)

___

### REMOVE\_LIST\_COMMAND

• `Const` **REMOVE\_LIST\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical-list/src/index.ts:48](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/index.ts#L48)

## Functions

### $createListItemNode

▸ **$createListItemNode**(`checked?`): [`ListItemNode`](../classes/lexical_list.ListItemNode.md)

Creates a new List Item node, passing true/false will convert it to a checkbox input.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `checked?` | `boolean` | Is the List Item a checkbox and, if so, is it checked? undefined/null: not a checkbox, true/false is a checkbox and checked/unchecked, respectively. |

#### Returns

[`ListItemNode`](../classes/lexical_list.ListItemNode.md)

The new List Item.

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:540](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L540)

___

### $createListNode

▸ **$createListNode**(`listType`, `start?`): [`ListNode`](../classes/lexical_list.ListNode.md)

Creates a ListNode of listType.

#### Parameters

| Name | Type | Default value | Description |
| :------ | :------ | :------ | :------ |
| `listType` | [`ListType`](lexical_list.md#listtype) | `undefined` | The type of list to be created. Can be 'number', 'bullet', or 'check'. |
| `start` | `number` | `1` | Where an ordered list starts its count, start = 1 if left undefined. |

#### Returns

[`ListNode`](../classes/lexical_list.ListNode.md)

The new ListNode

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:354](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L354)

___

### $getListDepth

▸ **$getListDepth**(`listNode`): `number`

Checks the depth of listNode from the root node.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `listNode` | [`ListNode`](../classes/lexical_list.ListNode.md) | The ListNode to be checked. |

#### Returns

`number`

The depth of the ListNode.

#### Defined in

[packages/lexical-list/src/utils.ts:27](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/utils.ts#L27)

___

### $handleListInsertParagraph

▸ **$handleListInsertParagraph**(): `boolean`

Attempts to insert a ParagraphNode at selection and selects the new node. The selection must contain a ListItemNode
or a node that does not already contain text. If its grandparent is the root/shadow root, it will get the ListNode
(which should be the parent node) and insert the ParagraphNode as a sibling to the ListNode. If the ListNode is
nested in a ListItemNode instead, it will add the ParagraphNode after the grandparent ListItemNode.
Throws an invariant if the selection is not a child of a ListNode.

#### Returns

`boolean`

true if a ParagraphNode was inserted succesfully, false if there is no selection
or the selection does not contain a ListItemNode or the node already holds text.

#### Defined in

[packages/lexical-list/src/formatList.ts:473](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/formatList.ts#L473)

___

### $isListItemNode

▸ **$isListItemNode**(`node`): node is ListItemNode

Checks to see if the node is a ListItemNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to be checked. |

#### Returns

node is ListItemNode

true if the node is a ListItemNode, false otherwise.

#### Defined in

[packages/lexical-list/src/LexicalListItemNode.ts:549](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListItemNode.ts#L549)

___

### $isListNode

▸ **$isListNode**(`node`): node is ListNode

Checks to see if the node is a ListNode.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to be checked. |

#### Returns

node is ListNode

true if the node is a ListNode, false otherwise.

#### Defined in

[packages/lexical-list/src/LexicalListNode.ts:363](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/LexicalListNode.ts#L363)

___

### insertList

▸ **insertList**(`editor`, `listType`): `void`

Inserts a new ListNode. If the selection's anchor node is an empty ListItemNode and is a child of
the root/shadow root, it will replace the ListItemNode with a ListNode and the old ListItemNode.
Otherwise it will replace its parent with a new ListNode and re-insert the ListItemNode and any previous children.
If the selection's anchor node is not an empty ListItemNode, it will add a new ListNode or merge an existing ListNode,
unless the the node is a leaf node, in which case it will attempt to find a ListNode up the branch and replace it with
a new ListNode, or create a new ListNode at the nearest root/shadow root.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `listType` | [`ListType`](lexical_list.md#listtype) | The type of list, "number" \| "bullet" \| "check". |

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/formatList.ts:65](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/formatList.ts#L65)

___

### removeList

▸ **removeList**(`editor`): `void`

Searches for the nearest ancestral ListNode and removes it. If selection is an empty ListItemNode
it will remove the whole list, including the ListItemNode. For each ListItemNode in the ListNode,
removeList will also generate new ParagraphNodes in the removed ListNode's place. Any child node
inside a ListItemNode will be appended to the new ParagraphNodes.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |

#### Returns

`void`

#### Defined in

[packages/lexical-list/src/formatList.ts:227](https://github.com/facebook/lexical/tree/main/packages/lexical-list/src/formatList.ts#L227)
