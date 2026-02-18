---
id: "lexical_mark.MarkNode"
title: "Class: MarkNode"
custom_edit_url: null
---

[@lexical/mark](../modules/lexical_mark.md).MarkNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`MarkNode`**

## Constructors

### constructor

• **new MarkNode**(`ids`, `key?`): [`MarkNode`](lexical_mark.MarkNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `ids` | `string`[] |
| `key?` | `string` |

#### Returns

[`MarkNode`](lexical_mark.MarkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L66)

## Methods

### addID

▸ **addID**(`id`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:118](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L118)

___

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canBeEmpty](lexical.ElementNode.md#canbeempty)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:164](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L164)

___

### canInsertTextAfter

▸ **canInsertTextAfter**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canInsertTextAfter](lexical.ElementNode.md#caninserttextafter)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:160](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L160)

___

### canInsertTextBefore

▸ **canInsertTextBefore**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canInsertTextBefore](lexical.ElementNode.md#caninserttextbefore)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:156](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L156)

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

[packages/lexical-mark/src/MarkNode.ts:71](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L71)

___

### deleteID

▸ **deleteID**(`id`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:133](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L133)

___

### excludeFromCopy

▸ **excludeFromCopy**(`destination`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `destination` | ``"html"`` \| ``"clone"`` |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[excludeFromCopy](lexical.ElementNode.md#excludefromcopy)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:195](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L195)

___

### exportJSON

▸ **exportJSON**(): [`SerializedMarkNode`](../modules/lexical_mark.md#serializedmarknode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedMarkNode`](../modules/lexical_mark.md#serializedmarknode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L57)

___

### extractWithChild

▸ **extractWithChild**(`child`, `selection`, `destination`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `child` | [`LexicalNode`](lexical.LexicalNode.md) |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |
| `destination` | ``"html"`` \| ``"clone"`` |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[extractWithChild](lexical.ElementNode.md#extractwithchild)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:172](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L172)

___

### getIDs

▸ **getIDs**(): `string`[]

#### Returns

`string`[]

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:113](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L113)

___

### hasID

▸ **hasID**(`id`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`boolean`

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:103](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L103)

___

### insertNewAfter

▸ **insertNewAfter**(`selection`, `restoreSelection?`): ``null`` \| [`ElementNode`](lexical.ElementNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

``null`` \| [`ElementNode`](lexical.ElementNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:147](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L147)

___

### isInline

▸ **isInline**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[isInline](lexical.ElementNode.md#isinline)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:168](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L168)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `element`, `config`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`MarkNode`](lexical_mark.MarkNode.md) |
| `element` | `HTMLElement` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L80)

___

### clone

▸ **clone**(`node`): [`MarkNode`](lexical_mark.MarkNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`MarkNode`](lexical_mark.MarkNode.md) |

#### Returns

[`MarkNode`](lexical_mark.MarkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L41)

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

[packages/lexical-mark/src/MarkNode.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L37)

___

### importDOM

▸ **importDOM**(): ``null``

#### Returns

``null``

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L45)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`MarkNode`](lexical_mark.MarkNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedMarkNode`](../modules/lexical_mark.md#serializedmarknode) |

#### Returns

[`MarkNode`](lexical_mark.MarkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-mark/src/MarkNode.ts:49](https://github.com/facebook/lexical/tree/main/packages/lexical-mark/src/MarkNode.ts#L49)
