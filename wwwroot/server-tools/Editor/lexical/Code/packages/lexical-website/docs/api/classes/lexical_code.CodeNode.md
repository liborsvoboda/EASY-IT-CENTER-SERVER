---
id: "lexical_code.CodeNode"
title: "Class: CodeNode"
custom_edit_url: null
---

[@lexical/code](../modules/lexical_code.md).CodeNode

## Hierarchy

- [`ElementNode`](lexical.ElementNode.md)

  ↳ **`CodeNode`**

## Constructors

### constructor

• **new CodeNode**(`language?`, `key?`): [`CodeNode`](lexical_code.CodeNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `language?` | ``null`` \| `string` |
| `key?` | `string` |

#### Returns

[`CodeNode`](lexical_code.CodeNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[constructor](lexical.ElementNode.md#constructor)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:90](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L90)

## Methods

### canIndent

▸ **canIndent**(): ``false``

#### Returns

``false``

#### Overrides

[ElementNode](lexical.ElementNode.md).[canIndent](lexical.ElementNode.md#canindent)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:315](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L315)

___

### collapseAtStart

▸ **collapseAtStart**(): `boolean`

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[collapseAtStart](lexical.ElementNode.md#collapseatstart)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:319](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L319)

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

[packages/lexical-code/src/CodeNode.ts:97](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L97)

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

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportDOM](lexical.ElementNode.md#exportdom)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:137](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L137)

___

### exportJSON

▸ **exportJSON**(): [`SerializedCodeNode`](../modules/lexical_code.md#serializedcodenode)

Controls how the this node is serialized to JSON. This is important for
copy and paste between Lexical editors sharing the same namespace. It's also important
if you're serializing to JSON for persistent storage somewhere.
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Returns

[`SerializedCodeNode`](../modules/lexical_code.md#serializedcodenode)

#### Overrides

[ElementNode](lexical.ElementNode.md).[exportJSON](lexical.ElementNode.md#exportjson)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:227](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L227)

___

### getIsSyntaxHighlightSupported

▸ **getIsSyntaxHighlightSupported**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical-code/src/CodeNode.ts:338](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L338)

___

### getLanguage

▸ **getLanguage**(): `undefined` \| ``null`` \| `string`

#### Returns

`undefined` \| ``null`` \| `string`

#### Defined in

[packages/lexical-code/src/CodeNode.ts:334](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L334)

___

### insertNewAfter

▸ **insertNewAfter**(`selection`, `restoreSelection?`): ``null`` \| [`ParagraphNode`](lexical.ParagraphNode.md) \| [`TabNode`](lexical.TabNode.md) \| [`CodeHighlightNode`](lexical_code.CodeHighlightNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `selection` | [`RangeSelection`](lexical.RangeSelection.md) | `undefined` |
| `restoreSelection` | `boolean` | `true` |

#### Returns

``null`` \| [`ParagraphNode`](lexical.ParagraphNode.md) \| [`TabNode`](lexical.TabNode.md) \| [`CodeHighlightNode`](lexical_code.CodeHighlightNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[insertNewAfter](lexical.ElementNode.md#insertnewafter)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:237](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L237)

___

### setLanguage

▸ **setLanguage**(`language`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `language` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical-code/src/CodeNode.ts:327](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L327)

___

### updateDOM

▸ **updateDOM**(`prevNode`, `dom`, `config`): `boolean`

Called when a node changes and should update the DOM
in whatever way is necessary to make it align with any changes that might
have happened during the update.

Returning "true" here will cause lexical to unmount and recreate the DOM node
(by calling createDOM). You would need to do this if the element tag changes,
for instance.

#### Parameters

| Name | Type |
| :------ | :------ |
| `prevNode` | [`CodeNode`](lexical_code.CodeNode.md) |
| `dom` | `HTMLElement` |
| `config` | [`EditorConfig`](../modules/lexical.md#editorconfig) |

#### Returns

`boolean`

#### Overrides

[ElementNode](lexical.ElementNode.md).[updateDOM](lexical.ElementNode.md#updatedom)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:111](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L111)

___

### clone

▸ **clone**(`node`): [`CodeNode`](lexical_code.CodeNode.md)

Clones this node, creating a new node with a different key
and adding it to the EditorState (but not attaching it anywhere!). All nodes must
implement this method.

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`CodeNode`](lexical_code.CodeNode.md) |

#### Returns

[`CodeNode`](lexical_code.CodeNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[clone](lexical.ElementNode.md#clone)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L86)

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

[packages/lexical-code/src/CodeNode.ts:82](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L82)

___

### importDOM

▸ **importDOM**(): ``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Returns

``null`` \| [`DOMConversionMap`](../modules/lexical.md#domconversionmap)

#### Overrides

ElementNode.importDOM

#### Defined in

[packages/lexical-code/src/CodeNode.ts:152](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L152)

___

### importJSON

▸ **importJSON**(`serializedNode`): [`CodeNode`](lexical_code.CodeNode.md)

Controls how the this node is deserialized from JSON. This is usually boilerplate,
but provides an abstraction between the node implementation and serialized interface that can
be important if you ever make breaking changes to a node schema (by adding or removing properties).
See [Serialization & Deserialization](https://lexical.dev/docs/concepts/serialization#lexical---html).

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedCodeNode`](../modules/lexical_code.md#serializedcodenode) |

#### Returns

[`CodeNode`](lexical_code.CodeNode.md)

#### Overrides

[ElementNode](lexical.ElementNode.md).[importJSON](lexical.ElementNode.md#importjson)

#### Defined in

[packages/lexical-code/src/CodeNode.ts:219](https://github.com/facebook/lexical/tree/main/packages/lexical-code/src/CodeNode.ts#L219)
