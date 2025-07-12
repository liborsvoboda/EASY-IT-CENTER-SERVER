---
id: "lexical_react_LexicalTypeaheadMenuPlugin"
title: "Module: @lexical/react/LexicalTypeaheadMenuPlugin"
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

### MenuTextMatch

Ƭ **MenuTextMatch**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `leadOffset` | `number` |
| `matchingString` | `string` |
| `replaceableString` | `string` |

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L37)

___

### TriggerFn

Ƭ **TriggerFn**: (`text`: `string`, `editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => [`MenuTextMatch`](lexical_react_LexicalTypeaheadMenuPlugin.md#menutextmatch) \| ``null``

#### Type declaration

▸ (`text`, `editor`): [`MenuTextMatch`](lexical_react_LexicalTypeaheadMenuPlugin.md#menutextmatch) \| ``null``

##### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

##### Returns

[`MenuTextMatch`](lexical_react_LexicalTypeaheadMenuPlugin.md#menutextmatch) \| ``null``

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:581](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L581)

___

### TypeaheadMenuPluginProps

Ƭ **TypeaheadMenuPluginProps**\<`TOption`\>: `Object`

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
| `onClose?` | () => `void` |
| `onOpen?` | (`resolution`: [`MenuResolution`](lexical_react_LexicalContextMenuPlugin.md#menuresolution)) => `void` |
| `onQueryChange` | (`matchingString`: `string` \| ``null``) => `void` |
| `onSelectOption` | (`option`: `TOption`, `textNodeContainingQuery`: [`TextNode`](../classes/lexical.TextNode.md) \| ``null``, `closeMenu`: () => `void`, `matchingString`: `string`) => `void` |
| `options` | `TOption`[] |
| `parent?` | `HTMLElement` |
| `triggerFn` | [`TriggerFn`](lexical_react_LexicalTypeaheadMenuPlugin.md#triggerfn) |

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:191](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L191)

## Variables

### PUNCTUATION

• `Const` **PUNCTUATION**: ``"\\.,\\+\\*\\?\\$\\@\\|#{}\\(\\)\\^\\-\\[\\]\\\\/!%'\"~=<>_:;"``

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:34](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L34)

___

### SCROLL\_TYPEAHEAD\_OPTION\_INTO\_VIEW\_COMMAND

• `Const` **SCROLL\_TYPEAHEAD\_OPTION\_INTO\_VIEW\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<\{ `index`: `number` ; `option`: [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md)  }\>

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:149](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L149)

## Functions

### LexicalTypeaheadMenuPlugin

▸ **LexicalTypeaheadMenuPlugin**\<`TOption`\>(`«destructured»`): `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOption` | extends [`MenuOption`](../classes/lexical_react_LexicalContextMenuPlugin.MenuOption.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | [`TypeaheadMenuPluginProps`](lexical_react_LexicalTypeaheadMenuPlugin.md#typeaheadmenupluginprops)\<`TOption`\> |

#### Returns

`JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:209](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L209)

___

### getScrollParent

▸ **getScrollParent**(`element`, `includeHidden`): `HTMLElement` \| `HTMLBodyElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` |
| `includeHidden` | `boolean` |

#### Returns

`HTMLElement` \| `HTMLBodyElement`

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:117](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L117)

___

### useBasicTypeaheadTriggerMatch

▸ **useBasicTypeaheadTriggerMatch**(`trigger`, `«destructured»`): [`TriggerFn`](lexical_react_LexicalTypeaheadMenuPlugin.md#triggerfn)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `trigger` | `string` | `undefined` |
| `«destructured»` | `Object` | `undefined` |
| › `maxLength?` | `number` | `75` |
| › `minLength?` | `number` | `1` |

#### Returns

[`TriggerFn`](lexical_react_LexicalTypeaheadMenuPlugin.md#triggerfn)

#### Defined in

[packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx:154](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalTypeaheadMenuPlugin.tsx#L154)

___

### useDynamicPositioning

▸ **useDynamicPositioning**(`resolution`, `targetElement`, `onReposition`, `onVisibilityChange?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `resolution` | ``null`` \| [`MenuResolution`](lexical_react_LexicalContextMenuPlugin.md#menuresolution) |
| `targetElement` | ``null`` \| `HTMLElement` |
| `onReposition` | () => `void` |
| `onVisibilityChange?` | (`isInView`: `boolean`) => `void` |

#### Returns

`void`

#### Defined in

[packages/lexical-react/src/shared/LexicalMenu.ts:198](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/shared/LexicalMenu.ts#L198)
