---
id: "lexical_react_LexicalNodeMenuPlugin"
title: "Module: @lexical/react/LexicalNodeMenuPlugin"
custom_edit_url: null
---

## References

### MenuOption

Re-exports [MenuOption](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md)

___

### MenuRenderFn

Re-exports [MenuRenderFn](lexical_react_LexicalContextMenuPlugin.md#menurenderfn)

___

### MenuResolution

Re-exports [MenuResolution](lexical_react_LexicalContextMenuPlugin.md#menuresolution)

## Type Aliases

### NodeMenuPluginProps

Ƭ **NodeMenuPluginProps**\<`TOption`\>: `Object`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `anchorClassName?` | `string` |
| `commandPriority?` | [`CommandListenerPriority`](lexical.md#commandlistenerpriority) |
| `menuRenderFn` | [`MenuRenderFn`](lexical_react_LexicalContextMenuPlugin.md#menurenderfn)\<`TOption`\> |
| `nodeKey` | [`NodeKey`](lexical.md#nodekey) \| ``null`` |
| `onClose?` | () => `void` |
| `onOpen?` | (`resolution`: [`MenuResolution`](lexical_react_LexicalContextMenuPlugin.md#menuresolution)) => `void` |
| `onSelectOption` | (`option`: `TOption`, `textNodeContainingQuery`: [`TextNode`](../classes/lexical.TextNode.md) \| ``null``, `closeMenu`: () => `void`, `matchingString`: `string`) => `void` |
| `options` | `TOption`[] |
| `parent?` | `HTMLElement` |

#### Defined in

[packages/lexical-react/src/LexicalNodeMenuPlugin.tsx:32](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalNodeMenuPlugin.tsx#L32)

## Functions

### LexicalNodeMenuPlugin

▸ **LexicalNodeMenuPlugin**\<`TOption`\>(`«destructured»`): `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | [`NodeMenuPluginProps`](lexical_react_LexicalNodeMenuPlugin.md#nodemenupluginprops)\<`TOption`\> |

#### Returns

`JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalNodeMenuPlugin.tsx:49](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalNodeMenuPlugin.tsx#L49)
