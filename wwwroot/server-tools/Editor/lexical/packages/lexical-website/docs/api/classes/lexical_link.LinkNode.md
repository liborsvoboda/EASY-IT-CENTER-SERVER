---
id: "lexical_link.LinkNode"
title: "Class: LinkNode"
custom_edit_url: null
---

[@lexical/link](../modules/lexical_link.md).LinkNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`LinkNode`**

  ↳↳ [`AutoLinkNode`](lexical_link.AutoLinkNode.md)

## Constructors

### constructor

• **new LinkNode**(`url`, `attributes?`, `key?`): [`LinkNode`](lexical_link.LinkNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `url` | `string` |
| `attributes` | [`LinkAttributes`](../modules/lexical_link.md#linkattributes) |
| `key?` | `string` |

#### Returns

[`LinkNode`](lexical_link.LinkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-link/src/index.ts:82](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L82)

## Methods

### canBeEmpty

▸ **canBeEmpty**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canBeEmpty](lexical.ElementNode.md#canbeempty)

#### Defined in

[packages/lexical-link/src/index.ts:253](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L253)

___

### canInsertTextAfter

▸ **canInsertTextAfter**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canInsertTextAfter](lexical.ElementNode.md#caninserttextafter)

#### Defined in

[packages/lexical-link/src/index.ts:249](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L249)

___

### canInsertTextBefore

▸ **canInsertTextBefore**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canInsertTextBefore](lexical.ElementNode.md#caninserttextbefore)

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

[ElementNode](lexical.ElementNode.md).[createDOM](lexical.ElementNode.md#createdom)

#### Defined in

[packages/lexical-link/src/index.ts:91](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L91)

___

### exportJSON

▸ **exportJSON**(): [`SerializedLinkNode`](../modules/lexical_link.md#serializedlinknode) \| [`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedLinkNode`](../modules/lexical_link.md#serializedlinknode) \| [`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-link/src/index.ts:184](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L184)

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

[packages/lexical-link/src/index.ts:261](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L261)

___

### getRel

▸ **getRel**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Defined in

[packages/lexical-link/src/index.ts:214](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L214)

___

### getTarget

▸ **getTarget**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Defined in

[packages/lexical-link/src/index.ts:205](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L205)

___

### getTitle

▸ **getTitle**(): ``null`` \| `string`

#### Returns

``null`` \| `string`

#### Defined in

[packages/lexical-link/src/index.ts:223](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L223)

___

### getURL

▸ **getURL**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical-link/src/index.ts:196](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L196)

___

### insertNewAfter

▸ **insertNewAfter**(`_`, `restoreSelection?`): ``null`` \| [`ElementNode`](lexical.ElementNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `_` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

``null`` \| [`ElementNode`](lexical.ElementNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-link/src/index.ts:232](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L232)

___

### isEmailURI

▸ **isEmailURI**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical-link/src/index.ts:280](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L280)

___

### isInline

▸ **isInline**(): ``true``

#### Returns

``true``

#### Overrides

[ElementNode](lexical.ElementNode.md).[isInline](lexical.ElementNode.md#isinline)

#### Defined in

[packages/lexical-link/src/index.ts:257](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L257)

___

### isWebSiteURI

▸ **isWebSiteURI**(): `boolean`

#### Returns

`boolean`

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

#### Defined in

[packages/lexical-link/src/index.ts:171](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L171)

___

### setRel

▸ **setRel**(`rel`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rel` | ``null`` \| `string` |

#### Returns

`void`

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
| `prevNode` | [`LinkNode`](lexical_link.LinkNode.md) |
| `anchor` | `LinkHTMLElementType` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-link/src/index.ts:107](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L107)

___

### clone

▸ **clone**(`node`): [`LinkNode`](lexical_link.LinkNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LinkNode`](lexical_link.LinkNode.md) |

#### Returns

[`LinkNode`](lexical_link.LinkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-link/src/index.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L74)

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

[packages/lexical-link/src/index.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L70)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-link/src/index.ts:148](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L148)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`LinkNode`](lexical_link.LinkNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedLinkNode`](../modules/lexical_link.md#serializedlinknode) \| [`SerializedAutoLinkNode`](../modules/lexical_link.md#serializedautolinknode) |

#### Returns

[`LinkNode`](lexical_link.LinkNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-link/src/index.ts:157](https://github.com/facebook/lexical/tree/main/packages/lexical-link/src/index.ts#L157)
