---
id: "lexical_react_useLexicalEditable"
title: "Module: @lexical/react/useLexicalEditable"
custom_edit_url: null
---

## References

### useLexicalEditable

Re-exports [useLexicalEditable](lexical_react_useLexicalEditable.md#uselexicaleditable-1)

## Functions

### useLexicalEditable

▸ **useLexicalEditable**(): `boolean`

Get the current value for [LexicalEditor.isEditable](../classes/lexical.LexicalEditor.md#iseditable)
using [useLexicalSubscription](lexical_react_useLexicalSubscription.md#uselexicalsubscription-1).
You should prefer this over manually observing the value with
[LexicalEditor.registerEditableListener](../classes/lexical.LexicalEditor.md#registereditablelistener),
which is a bit tricky to do correctly, particularly when using
React StrictMode (the default for development) or concurrency.

#### Returns

`boolean`

#### Defined in

[packages/lexical-react/src/useLexicalEditable.ts:31](https://github.com/facebook/lexical/tree/main/packages/lexical-react/src/useLexicalEditable.ts#L31)
