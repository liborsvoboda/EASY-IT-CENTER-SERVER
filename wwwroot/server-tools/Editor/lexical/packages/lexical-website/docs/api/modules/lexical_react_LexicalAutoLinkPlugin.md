---
id: "lexical_react_LexicalAutoLinkPlugin"
title: "Module: @lexical/react/LexicalAutoLinkPlugin"
custom_edit_url: null
---

## Type Aliases

### LinkMatcher

Ƭ **LinkMatcher**: (`text`: `string`) => `LinkMatcherResult` \| ``null``

#### Type declaration

▸ (`text`): `LinkMatcherResult` \| ``null``

##### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

##### Returns

`LinkMatcherResult` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalAutoLinkPlugin.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoLinkPlugin.ts#L45)

## Functions

### AutoLinkPlugin

▸ **AutoLinkPlugin**(`«destructured»`): `JSX.Element` \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `«destructured»` | `Object` |
| › `matchers` | [`LinkMatcher`](lexical_react_LexicalAutoLinkPlugin.md#linkmatcher)[] |
| › `onChange?` | `ChangeHandler` |

#### Returns

`JSX.Element` \| ``null``

#### Defined in

[packages/lexical-react/src/LexicalAutoLinkPlugin.ts:512](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoLinkPlugin.ts#L512)

___

### createLinkMatcherWithRegExp

▸ **createLinkMatcherWithRegExp**(`regExp`, `urlTransformer?`): (`text`: `string`) => ``null`` \| \{ `index`: `number` = match.index; `length`: `number` ; `text`: `string` ; `url`: `string`  }

#### Parameters

| Name | Type |
| :------ | :------ |
| `regExp` | `RegExp` |
| `urlTransformer` | (`text`: `string`) => `string` |

#### Returns

`fn`

▸ (`text`): ``null`` \| \{ `index`: `number` = match.index; `length`: `number` ; `text`: `string` ; `url`: `string`  }

##### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |

##### Returns

``null`` \| \{ `index`: `number` = match.index; `length`: `number` ; `text`: `string` ; `url`: `string`  }

#### Defined in

[packages/lexical-react/src/LexicalAutoLinkPlugin.ts:47](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/LexicalAutoLinkPlugin.ts#L47)
