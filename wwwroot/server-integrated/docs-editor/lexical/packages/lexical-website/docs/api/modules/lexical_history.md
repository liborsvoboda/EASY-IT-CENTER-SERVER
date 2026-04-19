---
id: "lexical_history"
title: "Module: @lexical/history"
custom_edit_url: null
---

## Type Aliases

### HistoryState

Ƭ **HistoryState**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `current` | ``null`` \| [`HistoryStateEntry`](lexical_history.md#historystateentry) |
| `redoStack` | [`HistoryStateEntry`](lexical_history.md#historystateentry)[] |
| `undoStack` | [`HistoryStateEntry`](lexical_history.md#historystateentry)[] |

#### Defined in

[packages/lexical-history/src/index.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical-history/src/index.ts#L41)

___

### HistoryStateEntry

Ƭ **HistoryStateEntry**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `editorState` | [`EditorState`](../classes/lexical.EditorState.md) |

#### Defined in

[packages/lexical-history/src/index.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical-history/src/index.ts#L37)

## Functions

### createEmptyHistoryState

▸ **createEmptyHistoryState**(): [`HistoryState`](lexical_history.md#historystate)

Creates an empty history state.

#### Returns

[`HistoryState`](lexical_history.md#historystate)

- The empty history state, as an object.

#### Defined in

[packages/lexical-history/src/index.ts:495](https://github.com/facebook/lexical/tree/main/packages/lexical-history/src/index.ts#L495)

___

### registerHistory

▸ **registerHistory**(`editor`, `historyState`, `delay`): () => `void`

Registers necessary listeners to manage undo/redo history stack and related editor commands.
It returns `unregister` callback that cleans up all listeners and should be called on editor unmount.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor. |
| `historyState` | [`HistoryState`](lexical_history.md#historystate) | The history state, containing the current state and the undo/redo stack. |
| `delay` | `number` | The time (in milliseconds) the editor should delay generating a new history stack, instead of merging the current changes with the current stack. |

#### Returns

`fn`

The listeners cleanup callback function.

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-history/src/index.ts:389](https://github.com/facebook/lexical/tree/main/packages/lexical-history/src/index.ts#L389)
