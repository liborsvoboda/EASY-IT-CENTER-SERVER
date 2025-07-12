---
id: "lexical_eslint_plugin"
title: "Module: @lexical/eslint-plugin"
custom_edit_url: null
---

## Type Aliases

### RulesOfLexicalOptions

Ƭ **RulesOfLexicalOptions**\<\>: `Partial`\<`BaseMatchers`\<`ToMatcher` \| `ToMatcher`[]\>\>

#### Defined in

[packages/lexical-eslint-plugin/src/rules/rules-of-lexical.js:87](https://github.com/facebook/lexical/tree/main/packages/lexical-eslint-plugin/src/rules/rules-of-lexical.js#L87)

## Variables

### plugin

• `Const` **plugin**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `configs` | \{ `all`: \{ `plugins`: `string`[] ; `rules`: \{ `@lexical/rules-of-lexical`: `string` = 'warn' }  } ; `recommended`: \{ `plugins`: `string`[] ; `rules`: \{ `@lexical/rules-of-lexical`: `string` = 'warn' }  } = all } |
| `configs.all` | \{ `plugins`: `string`[] ; `rules`: \{ `@lexical/rules-of-lexical`: `string` = 'warn' }  } |
| `configs.all.plugins` | `string`[] |
| `configs.all.rules` | \{ `@lexical/rules-of-lexical`: `string` = 'warn' } |
| `configs.all.rules.@lexical/rules-of-lexical` | `string` |
| `configs.recommended` | \{ `plugins`: `string`[] ; `rules`: \{ `@lexical/rules-of-lexical`: `string` = 'warn' }  } |
| `configs.recommended.plugins` | `string`[] |
| `configs.recommended.rules` | \{ `@lexical/rules-of-lexical`: `string` = 'warn' } |
| `configs.recommended.rules.@lexical/rules-of-lexical` | `string` |
| `meta` | \{ `name`: `string` ; `version`: `string`  } |
| `meta.name` | `string` |
| `meta.version` | `string` |
| `rules` | \{ `rules-of-lexical`: `RuleModule` = rulesOfLexical } |
| `rules.rules-of-lexical` | `RuleModule` |

#### Defined in

[packages/lexical-eslint-plugin/src/LexicalEslintPlugin.js:21](https://github.com/facebook/lexical/tree/main/packages/lexical-eslint-plugin/src/LexicalEslintPlugin.js#L21)
