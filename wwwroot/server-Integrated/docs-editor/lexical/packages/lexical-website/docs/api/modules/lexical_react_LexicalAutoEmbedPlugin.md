---
id: "lexical_react_LexicalAutoEmbedPlugin"
title: "Module: @lexical/react/LexicalAutoEmbedPlugin"
custom_edit_url: null
---

## Classes

- [AutoEmbedOption](../classes/lexical_react_LexicalAutoEmbedPlugin.AutoEmbedOption.md)

## Interfaces

- [EmbedConfig](../interfaces/lexical_react_LexicalAutoEmbedPlugin.EmbedConfig.md)

## Type Aliases

### EmbedMatchResult

Ƭ **EmbedMatchResult**\<`TEmbedMatchResult`\>: `Object`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEmbedMatchResult` | `unknown` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `data?` | `TEmbedMatchResult` |
| `id` | `string` |
| `url` | `string` |

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:36](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L36)

## Variables

### INSERT\_EMBED\_COMMAND

• `Const` **INSERT\_EMBED\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<[`EmbedConfig`](../interfaces/lexical_react_LexicalAutoEmbedPlugin.EmbedConfig.md)[``"type"``]\>

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:59](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L59)

___

### URL\_MATCHER

• `Const` **URL\_MATCHER**: `RegExp`

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:56](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L56)

## Functions

### LexicalAutoEmbedPlugin

▸ **LexicalAutoEmbedPlugin**\<`TEmbedConfig`\>(`«destructured»`): `JSX.Element` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEmbedConfig` | extends [`EmbedConfig`](../interfaces/lexical_react_LexicalAutoEmbedPlugin.EmbedConfig.md)\<`unknown`, [`EmbedMatchResult`](lexical_react_LexicalAutoEmbedPlugin.md#embedmatchresult)\<`unknown`\>\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `LexicalAutoEmbedPluginProps`\<`TEmbedConfig`\> |

#### Returns

`JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx:89](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoEmbedPlugin.tsx#L89)
