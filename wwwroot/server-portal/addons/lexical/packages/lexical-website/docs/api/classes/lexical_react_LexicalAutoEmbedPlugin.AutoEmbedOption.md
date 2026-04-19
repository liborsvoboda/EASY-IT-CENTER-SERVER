---
id: "lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption"
title: "Class: AutoEmbedOption"
custom_edit_url: null
---

[@lexical/react/LexicalAutoEmbedPlugin](../modules/lexical_react_LexicalAutoEmbedPlugin.md).AutoEmbedOption

## Hierarchy

- [`MenuOption`](lexical_react_LexicalContextMenuPlugin.MenuOption.md)

  ↳ **`AutoEmbedOption`**

## Constructors

### constructor

• **new AutoEmbedOption**(`title`, `options`): [`AutoEmbedOption`](lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `title` | `string` |
| `options` | `Object` |
| `options.onSelect` | (`targetNode`: ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)) => `void` |

#### Returns

[`AutoEmbedOption`](lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption.md)

#### Overrides

[MenuOption](lexical_react_LexicalContextMenuPlugin.MenuOption.md).[constructor](lexical_react_LexicalContextMenuPlugin.MenuOption.md#constructor)

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:65](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L65)

## Properties

### key

• **key**: `string`

#### Inherited from

[MenuOption](lexical_react_LexicalContextMenuPlugin.MenuOption.md).[key](lexical_react_LexicalContextMenuPlugin.MenuOption.md#key)

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:52](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L52)

___

### onSelect

• **onSelect**: (`targetNode`: ``null`` \| [`LexicalNode`](lexical.LexicalNode.md)) => `void`

#### Type declaration

▸ (`targetNode`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `targetNode` | ``null`` \| [`LexicalNode`](lexical.LexicalNode.md) |

##### Returns

`void`

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:64](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L64)

___

### ref

• `Optional` **ref**: `MutableRefObject`\<``null`` \| `HTMLElement`\>

#### Inherited from

[MenuOption](lexical_react_LexicalContextMenuPlugin.MenuOption.md).[ref](lexical_react_LexicalContextMenuPlugin.MenuOption.md#ref)

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:53](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L53)

___

### title

• **title**: `string`

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:63](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L63)

## Methods

### setRefElement

▸ **setRefElement**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | ``null`` \| `HTMLElement` |

#### Returns

`void`

#### Inherited from

[MenuOption](lexical_react_LexicalContextMenuPlugin.MenuOption.md).[setRefElement](lexical_react_LexicalContextMenuPlugin.MenuOption.md#setrefelement)

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:61](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L61)
