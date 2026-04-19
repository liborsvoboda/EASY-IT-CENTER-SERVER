---
id: "lexical_link.AutoLinkNode"
title: "Class: AutoLinkNode"
custom_edit_url: null
---

[@lexical/link](../modules/lexical_link.md).AutoLinkNode

## Hierarchy

- [`LinkNode`](lexical_link.LinkNode.md)

  ↳ **`AutoLinkNode`**

## Constructors

### constructor

• **new AutoLinkNode**(`url`, `attributes?`, `key?`): [`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |
| `attributes` | `Partial`\<[`Spread`](../modules/lexical.md#spread)\<[`LinkAttributes`](../modules/lexical_link.md#linkattributes), \{ `isUnlinked?`: `boolean`  }\>\> |
| `key?` | `string` |

#### Returns

[`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[constructor](lexical_link.LinkNode.md#constructor)

#### Defined in

[packages/lexical-link/src/index.ts:344](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L344)

## Properties

### \_\_isUnlinked

• **\_\_isUnlinked**: `boolean`

Indicates whether the autolink was ever unlinked. *

#### Defined in

[packages/lexical-link/src/index.ts:342](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L342)

___

### constructor

• **constructor**: [`KlassConstructor`](../modules/lexical.md#klassconstructor)\<typeof [`ElementNode`](lexical.ElementNode.md)\>

#### Inherited from

LinkNode.constructor

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:69](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L69)

## Methods

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[canBeEmpty](lexical_link.LinkNode.md#canbeempty)

#### Defined in

[packages/lexical-link/src/index.ts:253](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L253)

___

### canInsertTextAfter

▸ **canInsertTextAfter**(): ``false``

#### Returns

``false``

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[canInsertTextAfter](lexical_link.LinkNode.md#caninserttextafter)

#### Defined in

[packages/lexical-link/src/index.ts:249](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L249)

___

### canInsertTextBefore

▸ **canInsertTextBefore**(): ``false``

#### Returns

``false``

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[canInsertTextBefore](lexical_link.LinkNode.md#caninserttextbefore)

#### Defined in

[packages/lexical-link/src/index.ts:245](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L245)

___

### createDOM

▸ **createDOM**(`config`): `LinkHTMLElementType`

Called during the reconciliation process to determine which nodes
to insert into the DOM for this Lexical Node.

This method must return exactly one HTMLElement. Nested elements are not supported.

Do not attempt to update the Lexical EditorState during this phase of the update lifecyle.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) | allows access to things like the EditorTheme (to apply classes) during reconciliation. |

#### Returns

`LinkHTMLElementType`

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[createDOM](lexical_link.LinkNode.md#createdom)

#### Defined in

[packages/lexical-link/src/index.ts:379](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L379)

___

### exportJSON

▸ **exportJSON**(): [`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode)

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[exportJSON](lexical_link.LinkNode.md#exportjson)

#### Defined in

[packages/lexical-link/src/index.ts:416](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L416)

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

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[extractWithChild](lexical_link.LinkNode.md#extractwithchild)

#### Defined in

[packages/lexical-link/src/index.ts:261](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L261)

___

### getIsUnlinked

▸ **getIsUnlinked**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical-link/src/index.ts:369](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L369)

___

### getRel

▸ **getRel**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[getRel](lexical_link.LinkNode.md#getrel)

#### Defined in

[packages/lexical-link/src/index.ts:214](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L214)

___

### getTarget

▸ **getTarget**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[getTarget](lexical_link.LinkNode.md#gettarget)

#### Defined in

[packages/lexical-link/src/index.ts:205](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L205)

___

### getTitle

▸ **getTitle**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[getTitle](lexical_link.LinkNode.md#gettitle)

#### Defined in

[packages/lexical-link/src/index.ts:223](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L223)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node.

#### Returns

`string`

#### Inherited from

LinkNode.getType

#### Defined in

[packages/lexical/src/LexicalNode.ts:230](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L230)

___

### getURL

▸ **getURL**(): `string`

#### Returns

`string`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[getURL](lexical_link.LinkNode.md#geturl)

#### Defined in

[packages/lexical-link/src/index.ts:196](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L196)

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

[LinkNode](lexical_link.LinkNode.md).[insertNewAfter](lexical_link.LinkNode.md#insertnewafter)

#### Defined in

[packages/lexical-link/src/index.ts:425](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L425)

___

### isEmailURI

▸ **isEmailURI**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[isEmailURI](lexical_link.LinkNode.md#isemailuri)

#### Defined in

[packages/lexical-link/src/index.ts:280](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L280)

___

### isInline

▸ **isInline**(): ``true``

#### Returns

``true``

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[isInline](lexical_link.LinkNode.md#isinline)

#### Defined in

[packages/lexical-link/src/index.ts:257](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L257)

___

### isWebSiteURI

▸ **isWebSiteURI**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[isWebSiteURI](lexical_link.LinkNode.md#iswebsiteuri)

#### Defined in

[packages/lexical-link/src/index.ts:284](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L284)

___

### sanitizeUrl

▸ **sanitizeUrl**(`url`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |

#### Returns

`string`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[sanitizeUrl](lexical_link.LinkNode.md#sanitizeurl)

#### Defined in

[packages/lexical-link/src/index.ts:171](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L171)

___

### setIsUnlinked

▸ **setIsUnlinked**(`value`): [`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

[`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Defined in

[packages/lexical-link/src/index.ts:373](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L373)

___

### setRel

▸ **setRel**(`rel`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rel` | ``null`` \| `string` |

#### Returns

`void`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[setRel](lexical_link.LinkNode.md#setrel)

#### Defined in

[packages/lexical-link/src/index.ts:218](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L218)

___

### setTarget

▸ **setTarget**(`target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | ``null`` \| `string` |

#### Returns

`void`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[setTarget](lexical_link.LinkNode.md#settarget)

#### Defined in

[packages/lexical-link/src/index.ts:209](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L209)

___

### setTitle

▸ **setTitle**(`title`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `title` | ``null`` \| `string` |

#### Returns

`void`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[setTitle](lexical_link.LinkNode.md#settitle)

#### Defined in

[packages/lexical-link/src/index.ts:227](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L227)

___

### setURL

▸ **setURL**(`url`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |

#### Returns

`void`

#### Inherited from

[LinkNode](lexical_link.LinkNode.md).[setURL](lexical_link.LinkNode.md#seturl)

#### Defined in

[packages/lexical-link/src/index.ts:200](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L200)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `anchor`, `config`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`AutoLinkNode`](lexical_link.AutoLinkNode.md) |
| `anchor` | `LinkHTMLElementType` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[updateDOM](lexical_link.LinkNode.md#updatedom)

#### Defined in

[packages/lexical-link/src/index.ts:387](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L387)

___

### clone

▸ **clone**(`node`): [`AutoLinkNode`](lexical_link.AutoLinkNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`AutoLinkNode`](lexical_link.AutoLinkNode.md) |

#### Returns

[`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[clone](lexical_link.LinkNode.md#clone)

#### Defined in

[packages/lexical-link/src/index.ts:356](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L356)

___

### getType

▸ **getType**(): `string`

Returns the string type of this node. Every node must
implement this and it MUST BE UNIQUE amongst nodes registered
on the editor.

#### Returns

`string`

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[getType](lexical_link.LinkNode.md#gettype)

#### Defined in

[packages/lexical-link/src/index.ts:352](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L352)

___

### importDOM

▸ **importDOM**(): ``null``

#### Returns

``null``

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[importDOM](lexical_link.LinkNode.md#importdom)

#### Defined in

[packages/lexical-link/src/index.ts:411](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L411)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`AutoLinkNode`](lexical_link.AutoLinkNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode) |

#### Returns

[`AutoLinkNode`](lexical_link.AutoLinkNode.md)

#### Overrides

[LinkNode](lexical_link.LinkNode.md).[importJSON](lexical_link.LinkNode.md#importjson)

#### Defined in

[packages/lexical-link/src/index.ts:398](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L398)
