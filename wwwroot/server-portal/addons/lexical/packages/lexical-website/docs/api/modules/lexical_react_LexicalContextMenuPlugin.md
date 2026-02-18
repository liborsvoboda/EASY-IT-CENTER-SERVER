---
id: "lexical_react_LexicalContextMenuPlugin"
title: "Module: @lexical/react/LexicalContextMenuPlugin"
custom_edit_url: null
---

## Classes

- [MenuOption](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md)

## Type Aliases

### ContextMenuRenderFn

Ƭ **ContextMenuRenderFn**\<`TOption`\>: (`anchorElementRef`: `MutableRefObject`\<`HTMLElement` \| ``null``\>, `itemProps`: \{ `options`: `TOption`[] ; `selectOptionAndCleanUp`: (`option`: `TOption`) => `void` ; `selectedIndex`: `number` \| ``null`` ; `setHighlightedIndex`: (`index`: `number`) => `void`  }, `menuProps`: \{ `setMenuRef`: (`element`: `HTMLElement` \| ``null``) => `void`  }) => `ReactPortal` \| `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Type declaration

▸ (`anchorElementRef`, `itemProps`, `menuProps`): `ReactPortal` \| `JSX.Element` \| ``null``

##### Parameters

| Name | Type |
| :------ | :------ |
| `anchorElementRef` | `MutableRefObject`\<`HTMLElement` \| ``null``\> |
| `itemProps` | `Object` |
| `itemProps.options` | `TOption`[] |
| `itemProps.selectOptionAndCleanUp` | (`option`: `TOption`) => `void` |
| `itemProps.selectedIndex` | `number` \| ``null`` |
| `itemProps.setHighlightedIndex` | (`index`: `number`) => `void` |
| `menuProps` | `Object` |
| `menuProps.setMenuRef` | (`element`: `HTMLElement` \| ``null``) => `void` |

##### Returns

`ReactPortal` \| `JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalContextMenuPlugin.tsx:28](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalContextMenuPlugin.tsx#L28)

___

### LexicalContextMenuPluginProps

Ƭ **LexicalContextMenuPluginProps**\<`TOption`\>: `Object`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `anchorClassName?` | `string` |
| `commandPriority?` | [`CommandListenerPriority`](lexical.md#commandlistenerpriority) |
| `menuRenderFn` | [`ContextMenuRenderFn`](lexical_react_LexicalContextMenuPlugin.md#contextmenurenderfn)\<`TOption`\> |
| `onClose?` | () => `void` |
| `onOpen?` | (`resolution`: [`MenuResolution`](lexical_react_LexicalContextMenuPlugin.md#menuresolution)) => `void` |
| `onSelectOption` | (`option`: `TOption`, `textNodeContainingQuery`: [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null``, `closeMenu`: () => `void`, `matchingString`: `string`) => `void` |
| `onWillOpen?` | (`event`: `MouseEvent`) => `void` |
| `options` | `TOption`[] |
| `parent?` | `HTMLElement` |

#### Defined in

[packages/lexical-react/src/LexicalContextMenuPlugin.tsx:41](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalContextMenuPlugin.tsx#L41)

___

### MenuRenderFn

Ƭ **MenuRenderFn**\<`TOption`\>: (`anchorElementRef`: `MutableRefObject`\<`HTMLElement` \| ``null``\>, `itemProps`: \{ `options`: `TOption`[] ; `selectOptionAndCleanUp`: (`option`: `TOption`) => `void` ; `selectedIndex`: `number` \| ``null`` ; `setHighlightedIndex`: (`index`: `number`) => `void`  }, `matchingString`: `string` \| ``null``) => `ReactPortal` \| `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Type declaration

▸ (`anchorElementRef`, `itemProps`, `matchingString`): `ReactPortal` \| `JSX.Element` \| ``null``

##### Parameters

| Name | Type |
| :------ | :------ |
| `anchorElementRef` | `MutableRefObject`\<`HTMLElement` \| ``null``\> |
| `itemProps` | `Object` |
| `itemProps.options` | `TOption`[] |
| `itemProps.selectOptionAndCleanUp` | (`option`: `TOption`) => `void` |
| `itemProps.selectedIndex` | `number` \| ``null`` |
| `itemProps.setHighlightedIndex` | (`index`: `number`) => `void` |
| `matchingString` | `string` \| ``null`` |

##### Returns

`ReactPortal` \| `JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L66)

___

### MenuResolution

Ƭ **MenuResolution**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `getRect` | () => `DOMRect` |
| `match?` | [`MenuTextMatch`](lexical_react_LexicalTypeaheadMenuPlugin.md#menutextmatch) |

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L43)

## Functions

### LexicalContextMenuPlugin

▸ **LexicalContextMenuPlugin**\<`TOption`\>(`«destructured»`): `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | [`LexicalContextMenuPluginProps`](lexical_react_LexicalContextMenuPlugin.md#lexicalcontextmenupluginprops)\<`TOption`\> |

#### Returns

`JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalContextMenuPlugin.tsx:60](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalContextMenuPlugin.tsx#L60)
