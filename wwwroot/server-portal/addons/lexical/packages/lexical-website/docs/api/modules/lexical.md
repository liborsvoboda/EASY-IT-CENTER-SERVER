---
id: "lexical"
title: "Module: lexical"
custom_edit_url: null
---

## Classes

- [ArtificialNode\_\_DO\_NOT\_USE](../classes/lexical.ArtificialNode__DO_NOT_USE.md)
- [DecoratorNode](../classes/lexical.DecoratorNode.md)
- [EditorState](../classes/lexical.EditorState.md)
- [ElementNode](../classes/lexical.ElementNode.md)
- [LexicalEditor](../classes/lexical.LexicalEditor.md)
- [LexicalNode](../classes/lexical.LexicalNode.md)
- [LineBreakNode](../classes/lexical.LineBreakNode.md)
- [NodeSelection](../classes/lexical.NodeSelection.md)
- [ParagraphNode](../classes/lexical.ParagraphNode.md)
- [Point](../classes/lexical.Point.md)
- [RangeSelection](../classes/lexical.RangeSelection.md)
- [RootNode](../classes/lexical.RootNode.md)
- [TabNode](../classes/lexical.TabNode.md)
- [TextNode](../classes/lexical.TextNode.md)

## Interfaces

- [BaseSelection](../interfaces/lexical.BaseSelection.md)
- [EditorStateReadOptions](../interfaces/lexical.EditorStateReadOptions.md)
- [SerializedEditorState](../interfaces/lexical.SerializedEditorState.md)

## Type Aliases

### CommandListener

Ƭ **CommandListener**\<`P`\>: (`payload`: `P`, `editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => `boolean`

#### Type parameters

| Name |
| :------ |
| `P` |

#### Type declaration

▸ (`payload`, `editor`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `payload` | `P` |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

##### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:256](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L256)

___

### CommandListenerPriority

Ƭ **CommandListenerPriority**: ``0`` \| ``1`` \| ``2`` \| ``3`` \| ``4``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:260](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L260)

___

### CommandPayloadType

Ƭ **CommandPayloadType**\<`TCommand`\>: `TCommand` extends [`LexicalCommand`](lexical.md#lexicalcommand)\<infer TPayload\> ? `TPayload` : `never`

Type helper for extracting the payload type from a command.

**`Example`**

```ts
const MY_COMMAND = createCommand<SomeType>();

// ...

editor.registerCommand(MY_COMMAND, payload => {
  // Type of `payload` is inferred here. But lets say we want to extract a function to delegate to
  handleMyCommand(editor, payload);
  return true;
});

function handleMyCommand(editor: LexicalEditor, payload: CommandPayloadType<typeof MY_COMMAND>) {
  // `payload` is of type `SomeType`, extracted from the command.
}
```

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TCommand` | extends [`LexicalCommand`](lexical.md#lexicalcommand)\<`unknown`\> |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:293](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L293)

___

### CreateEditorArgs

Ƭ **CreateEditorArgs**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `disableEvents?` | `boolean` |
| `editable?` | `boolean` |
| `editorState?` | [`EditorState`](../classes/lexical.EditorState.md) |
| `html?` | [`HTMLConfig`](lexical.md#htmlconfig) |
| `namespace?` | `string` |
| `nodes?` | `ReadonlyArray`\<[`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\> \| [`LexicalNodeReplacement`](lexical.md#lexicalnodereplacement)\> |
| `onError?` | `ErrorHandler` |
| `parentEditor?` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `theme?` | [`EditorThemeClasses`](lexical.md#editorthemeclasses) |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:180](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L180)

___

### DOMChildConversion

Ƭ **DOMChildConversion**: (`lexicalNode`: [`LexicalNode`](../classes/lexical.LexicalNode.md), `parentLexicalNode`: [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null`` \| `undefined`) => [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null`` \| `undefined`

#### Type declaration

▸ (`lexicalNode`, `parentLexicalNode`): [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null`` \| `undefined`

##### Parameters

| Name | Type |
| :------ | :------ |
| `lexicalNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |
| `parentLexicalNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null`` \| `undefined` |

##### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null`` \| `undefined`

#### Defined in

[packages/lexical/src/LexicalNode.ts:134](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L134)

___

### DOMConversion

Ƭ **DOMConversion**\<`T`\>: `Object`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends `HTMLElement` = `HTMLElement` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `conversion` | [`DOMConversionFn`](lexical.md#domconversionfn)\<`T`\> |
| `priority?` | ``0`` \| ``1`` \| ``2`` \| ``3`` \| ``4`` |

#### Defined in

[packages/lexical/src/LexicalNode.ts:125](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L125)

___

### DOMConversionFn

Ƭ **DOMConversionFn**\<`T`\>: (`element`: `T`) => [`DOMConversionOutput`](lexical.md#domconversionoutput) \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends `HTMLElement` = `HTMLElement` |

#### Type declaration

▸ (`element`): [`DOMConversionOutput`](lexical.md#domconversionoutput) \| ``null``

##### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `T` |

##### Returns

[`DOMConversionOutput`](lexical.md#domconversionoutput) \| ``null``

#### Defined in

[packages/lexical/src/LexicalNode.ts:130](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L130)

___

### DOMConversionMap

Ƭ **DOMConversionMap**\<`T`\>: `Record`\<`NodeName`, (`node`: `T`) => [`DOMConversion`](lexical.md#domconversion)\<`T`\> \| ``null``\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends `HTMLElement` = `HTMLElement` |

#### Defined in

[packages/lexical/src/LexicalNode.ts:139](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L139)

___

### DOMConversionOutput

Ƭ **DOMConversionOutput**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `after?` | (`childLexicalNodes`: [`LexicalNode`](../classes/lexical.LexicalNode.md)[]) => [`LexicalNode`](../classes/lexical.LexicalNode.md)[] |
| `forChild?` | [`DOMChildConversion`](lexical.md#domchildconversion) |
| `node` | ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) \| [`LexicalNode`](../classes/lexical.LexicalNode.md)[] |

#### Defined in

[packages/lexical/src/LexicalNode.ts:145](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L145)

___

### DOMExportOutput

Ƭ **DOMExportOutput**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `after?` | (`generatedElement`: `HTMLElement` \| `Text` \| ``null`` \| `undefined`) => `HTMLElement` \| `Text` \| ``null`` \| `undefined` |
| `element` | `HTMLElement` \| `Text` \| ``null`` |

#### Defined in

[packages/lexical/src/LexicalNode.ts:151](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L151)

___

### EditableListener

Ƭ **EditableListener**: (`editable`: `boolean`) => `void`

#### Type declaration

▸ (`editable`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `editable` | `boolean` |

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:258](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L258)

___

### EditorConfig

Ƭ **EditorConfig**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `disableEvents?` | `boolean` |
| `namespace` | `string` |
| `theme` | [`EditorThemeClasses`](lexical.md#editorthemeclasses) |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:157](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L157)

___

### EditorSetOptions

Ƭ **EditorSetOptions**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `tag?` | `string` |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L86)

___

### EditorThemeClassName

Ƭ **EditorThemeClassName**: `string`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L63)

___

### EditorThemeClasses

Ƭ **EditorThemeClasses**: `Object`

#### Index signature

▪ [key: `string`]: `any`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `blockCursor?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `characterLimit?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `code?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `codeHighlight?` | `Record`\<`string`, [`EditorThemeClassName`](lexical.md#editorthemeclassname)\> |
| `embedBlock?` | \{ `base?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `focus?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)  } |
| `embedBlock.base?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `embedBlock.focus?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `hashtag?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading?` | \{ `h1?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `h2?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `h3?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `h4?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `h5?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `h6?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)  } |
| `heading.h1?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading.h2?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading.h3?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading.h4?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading.h5?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `heading.h6?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `hr?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `image?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `indent?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `link?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list?` | \{ `checklist?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `listitem?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `listitemChecked?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `listitemUnchecked?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `nested?`: \{ `list?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `listitem?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)  } ; `ol?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `olDepth?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)[] ; `ul?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `ulDepth?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)[]  } |
| `list.checklist?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.listitem?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.listitemChecked?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.listitemUnchecked?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.nested?` | \{ `list?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname) ; `listitem?`: [`EditorThemeClassName`](lexical.md#editorthemeclassname)  } |
| `list.nested.list?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.nested.listitem?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.ol?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.olDepth?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname)[] |
| `list.ul?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `list.ulDepth?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname)[] |
| `ltr?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `mark?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `markOverlap?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `paragraph?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `quote?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `root?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `rtl?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `table?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableAddColumns?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableAddRows?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCell?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellActionButton?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellActionButtonContainer?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellEditing?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellHeader?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellPrimarySelected?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellResizer?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellSelected?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableCellSortedIndicator?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableResizeRuler?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableRow?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `tableSelected?` | [`EditorThemeClassName`](lexical.md#editorthemeclassname) |
| `text?` | `TextNodeThemeClasses` |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:94](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L94)

___

### EditorUpdateOptions

Ƭ **EditorUpdateOptions**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `discrete?` | ``true`` |
| `onUpdate?` | () => `void` |
| `skipTransforms?` | ``true`` |
| `tag?` | `string` |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:79](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L79)

___

### ElementFormatType

Ƭ **ElementFormatType**: ``"left"`` \| ``"start"`` \| ``"center"`` \| ``"right"`` \| ``"end"`` \| ``"justify"`` \| ``""``

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:51](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L51)

___

### ElementPoint

Ƭ **ElementPoint**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `_selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |
| `getNode` | () => [`ElementNode`](../classes/lexical.ElementNode.md) |
| `is` | (`point`: [`PointType`](lexical.md#pointtype)) => `boolean` |
| `isBefore` | (`point`: [`PointType`](lexical.md#pointtype)) => `boolean` |
| `key` | [`NodeKey`](lexical.md#nodekey) |
| `offset` | `number` |
| `set` | (`key`: [`NodeKey`](lexical.md#nodekey), `offset`: `number`, `type`: ``"text"`` \| ``"element"``) => `void` |
| `type` | ``"element"`` |

#### Defined in

[packages/lexical/src/LexicalSelection.ts:78](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L78)

___

### EventHandler

Ƭ **EventHandler**: (`event`: `Event`, `editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md)) => `void`

#### Type declaration

▸ (`event`, `editor`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `event` | `Event` |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEvents.ts:1207](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEvents.ts#L1207)

___

### HTMLConfig

Ƭ **HTMLConfig**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `export?` | `Map`\<[`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\>, (`editor`: [`LexicalEditor`](../classes/lexical.LexicalEditor.md), `target`: [`LexicalNode`](../classes/lexical.LexicalNode.md)) => [`DOMExportOutput`](lexical.md#domexportoutput)\> |
| `import?` | [`DOMConversionMap`](lexical.md#domconversionmap) |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:172](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L172)

___

### Klass

Ƭ **Klass**\<`T`\>: `InstanceType`\<`T`[``"constructor"``]\> extends `T` ? `T`[``"constructor"``] : `GenericConstructor`\<`T`\> & `T`[``"constructor"``]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L57)

___

### KlassConstructor

Ƭ **KlassConstructor**\<`Cls`\>: `GenericConstructor`\<`InstanceType`\<`Cls`\>\> & \{ [k in keyof Cls]: Cls[k] }

#### Type parameters

| Name | Type |
| :------ | :------ |
| `Cls` | extends `GenericConstructor`\<`any`\> |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:52](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L52)

___

### LexicalCommand

Ƭ **LexicalCommand**\<`TPayload`\>: `Object`

#### Type parameters

| Name |
| :------ |
| `TPayload` |

#### Type declaration

| Name | Type |
| :------ | :------ |
| `type?` | `string` |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:269](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L269)

___

### LexicalNodeReplacement

Ƭ **LexicalNodeReplacement**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `replace` | [`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\> |
| `with` | \<T\>(`node`: `InstanceType`\<`T`\>) => [`LexicalNode`](../classes/lexical.LexicalNode.md) |
| `withKlass?` | [`Klass`](lexical.md#klass)\<[`LexicalNode`](../classes/lexical.LexicalNode.md)\> |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:163](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L163)

___

### MutationListener

Ƭ **MutationListener**: (`nodes`: `Map`\<[`NodeKey`](lexical.md#nodekey), [`NodeMutation`](lexical.md#nodemutation)\>, `payload`: \{ `dirtyLeaves`: `Set`\<`string`\> ; `prevEditorState`: [`EditorState`](../classes/lexical.EditorState.md) ; `updateTags`: `Set`\<`string`\>  }) => `void`

#### Type declaration

▸ (`nodes`, `payload`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | `Map`\<[`NodeKey`](lexical.md#nodekey), [`NodeMutation`](lexical.md#nodemutation)\> |
| `payload` | `Object` |
| `payload.dirtyLeaves` | `Set`\<`string`\> |
| `payload.prevEditorState` | [`EditorState`](../classes/lexical.EditorState.md) |
| `payload.updateTags` | `Set`\<`string`\> |

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:247](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L247)

___

### NodeKey

Ƭ **NodeKey**: `string`

#### Defined in

[packages/lexical/src/LexicalNode.ts:158](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L158)

___

### NodeMap

Ƭ **NodeMap**: `Map`\<[`NodeKey`](lexical.md#nodekey), [`LexicalNode`](../classes/lexical.LexicalNode.md)\>

#### Defined in

[packages/lexical/src/LexicalNode.ts:52](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L52)

___

### NodeMutation

Ƭ **NodeMutation**: ``"created"`` \| ``"updated"`` \| ``"destroyed"``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:213](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L213)

___

### PasteCommandType

Ƭ **PasteCommandType**: `ClipboardEvent` \| `InputEvent` \| `KeyboardEvent`

#### Defined in

[packages/lexical/src/LexicalCommands.ts:17](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L17)

___

### PointType

Ƭ **PointType**: [`TextPoint`](lexical.md#textpoint) \| [`ElementPoint`](lexical.md#elementpoint)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:89](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L89)

___

### SerializedEditor

Ƭ **SerializedEditor**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `editorState` | [`SerializedEditorState`](../interfaces/lexical.SerializedEditorState.md) |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:334](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L334)

___

### SerializedElementNode

Ƭ **SerializedElementNode**\<`T`\>: [`Spread`](lexical.md#spread)\<\{ `children`: `T`[] ; `direction`: ``"ltr"`` \| ``"rtl"`` \| ``null`` ; `format`: [`ElementFormatType`](lexical.md#elementformattype) ; `indent`: `number`  }, [`SerializedLexicalNode`](lexical.md#serializedlexicalnode)\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`SerializedLexicalNode`](lexical.md#serializedlexicalnode) = [`SerializedLexicalNode`](lexical.md#serializedlexicalnode) |

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L39)

___

### SerializedLexicalNode

Ƭ **SerializedLexicalNode**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `version` | `number` |

#### Defined in

[packages/lexical/src/LexicalNode.ts:54](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNode.ts#L54)

___

### SerializedLineBreakNode

Ƭ **SerializedLineBreakNode**: [`SerializedLexicalNode`](lexical.md#serializedlexicalnode)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:21](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L21)

___

### SerializedParagraphNode

Ƭ **SerializedParagraphNode**: [`Spread`](lexical.md#spread)\<\{ `textFormat`: `number` ; `textStyle`: `string`  }, [`SerializedElementNode`](lexical.md#serializedelementnode)\>

#### Defined in

[packages/lexical/src/nodes/LexicalParagraphNode.ts:37](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalParagraphNode.ts#L37)

___

### SerializedRootNode

Ƭ **SerializedRootNode**\<`T`\>: [`SerializedElementNode`](lexical.md#serializedelementnode)\<`T`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`SerializedLexicalNode`](lexical.md#serializedlexicalnode) = [`SerializedLexicalNode`](lexical.md#serializedlexicalnode) |

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:20](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L20)

___

### SerializedTabNode

Ƭ **SerializedTabNode**: [`SerializedTextNode`](lexical.md#serializedtextnode)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L23)

___

### SerializedTextNode

Ƭ **SerializedTextNode**: [`Spread`](lexical.md#spread)\<\{ `detail`: `number` ; `format`: `number` ; `mode`: [`TextModeType`](lexical.md#textmodetype) ; `style`: `string` ; `text`: `string`  }, [`SerializedLexicalNode`](lexical.md#serializedlexicalnode)\>

#### Defined in

[packages/lexical/src/nodes/LexicalTextNode.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTextNode.ts#L72)

___

### Spread

Ƭ **Spread**\<`T1`, `T2`\>: `Omit`\<`T2`, keyof `T1`\> & `T1`

#### Type parameters

| Name |
| :------ |
| `T1` |
| `T2` |

#### Defined in

[packages/lexical/src/LexicalEditor.ts:48](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L48)

___

### TextFormatType

Ƭ **TextFormatType**: ``"bold"`` \| ``"underline"`` \| ``"strikethrough"`` \| ``"italic"`` \| ``"highlight"`` \| ``"code"`` \| ``"subscript"`` \| ``"superscript"``

#### Defined in

[packages/lexical/src/nodes/LexicalTextNode.ts:85](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTextNode.ts#L85)

___

### TextModeType

Ƭ **TextModeType**: ``"normal"`` \| ``"token"`` \| ``"segmented"``

#### Defined in

[packages/lexical/src/nodes/LexicalTextNode.ts:95](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTextNode.ts#L95)

___

### TextPoint

Ƭ **TextPoint**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `_selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |
| `getNode` | () => [`TextNode`](../classes/lexical.TextNode.md) |
| `is` | (`point`: [`PointType`](lexical.md#pointtype)) => `boolean` |
| `isBefore` | (`point`: [`PointType`](lexical.md#pointtype)) => `boolean` |
| `key` | [`NodeKey`](lexical.md#nodekey) |
| `offset` | `number` |
| `set` | (`key`: [`NodeKey`](lexical.md#nodekey), `offset`: `number`, `type`: ``"text"`` \| ``"element"``) => `void` |
| `type` | ``"text"`` |

#### Defined in

[packages/lexical/src/LexicalSelection.ts:67](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L67)

___

### Transform

Ƭ **Transform**\<`T`\>: (`node`: `T`) => `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Type declaration

▸ (`node`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `T` |

##### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalEditor.ts:205](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L205)

## Variables

### BLUR\_COMMAND

• `Const` **BLUR\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`FocusEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:122](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L122)

___

### CAN\_REDO\_COMMAND

• `Const` **CAN\_REDO\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:116](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L116)

___

### CAN\_UNDO\_COMMAND

• `Const` **CAN\_UNDO\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:118](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L118)

___

### CLEAR\_EDITOR\_COMMAND

• `Const` **CLEAR\_EDITOR\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:110](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L110)

___

### CLEAR\_HISTORY\_COMMAND

• `Const` **CLEAR\_HISTORY\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:113](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L113)

___

### CLICK\_COMMAND

• `Const` **CLICK\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`MouseEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:30](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L30)

___

### COMMAND\_PRIORITY\_CRITICAL

• `Const` **COMMAND\_PRIORITY\_CRITICAL**: ``4``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:266](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L266)

___

### COMMAND\_PRIORITY\_EDITOR

• `Const` **COMMAND\_PRIORITY\_EDITOR**: ``0``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:262](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L262)

___

### COMMAND\_PRIORITY\_HIGH

• `Const` **COMMAND\_PRIORITY\_HIGH**: ``3``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:265](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L265)

___

### COMMAND\_PRIORITY\_LOW

• `Const` **COMMAND\_PRIORITY\_LOW**: ``1``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:263](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L263)

___

### COMMAND\_PRIORITY\_NORMAL

• `Const` **COMMAND\_PRIORITY\_NORMAL**: ``2``

#### Defined in

[packages/lexical/src/LexicalEditor.ts:264](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L264)

___

### CONTROLLED\_TEXT\_INSERTION\_COMMAND

• `Const` **CONTROLLED\_TEXT\_INSERTION\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`InputEvent` \| `string`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L41)

___

### COPY\_COMMAND

• `Const` **COPY\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`ClipboardEvent` \| `KeyboardEvent` \| ``null``\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:102](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L102)

___

### CUT\_COMMAND

• `Const` **CUT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`ClipboardEvent` \| `KeyboardEvent` \| ``null``\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:105](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L105)

___

### DELETE\_CHARACTER\_COMMAND

• `Const` **DELETE\_CHARACTER\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:32](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L32)

___

### DELETE\_LINE\_COMMAND

• `Const` **DELETE\_LINE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:51](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L51)

___

### DELETE\_WORD\_COMMAND

• `Const` **DELETE\_WORD\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:48](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L48)

___

### DRAGEND\_COMMAND

• `Const` **DRAGEND\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`DragEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:100](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L100)

___

### DRAGOVER\_COMMAND

• `Const` **DRAGOVER\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`DragEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:98](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L98)

___

### DRAGSTART\_COMMAND

• `Const` **DRAGSTART\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`DragEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:96](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L96)

___

### DROP\_COMMAND

• `Const` **DROP\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`DragEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:92](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L92)

___

### FOCUS\_COMMAND

• `Const` **FOCUS\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`FocusEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:120](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L120)

___

### FORMAT\_ELEMENT\_COMMAND

• `Const` **FORMAT\_ELEMENT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<[`ElementFormatType`](lexical.md#elementformattype)\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:94](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L94)

___

### FORMAT\_TEXT\_COMMAND

• `Const` **FORMAT\_TEXT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<[`TextFormatType`](lexical.md#textformattype)\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:54](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L54)

___

### INDENT\_CONTENT\_COMMAND

• `Const` **INDENT\_CONTENT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L86)

___

### INSERT\_LINE\_BREAK\_COMMAND

• `Const` **INSERT\_LINE\_BREAK\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`boolean`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:35](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L35)

___

### INSERT\_PARAGRAPH\_COMMAND

• `Const` **INSERT\_PARAGRAPH\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:38](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L38)

___

### INSERT\_TAB\_COMMAND

• `Const` **INSERT\_TAB\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:84](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L84)

___

### IS\_ALL\_FORMATTING

• `Const` **IS\_ALL\_FORMATTING**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:48](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L48)

___

### IS\_BOLD

• `Const` **IS\_BOLD**: ``1``

#### Defined in

[packages/lexical/src/LexicalConstants.ts:39](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L39)

___

### IS\_CODE

• `Const` **IS\_CODE**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:43](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L43)

___

### IS\_HIGHLIGHT

• `Const` **IS\_HIGHLIGHT**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L46)

___

### IS\_ITALIC

• `Const` **IS\_ITALIC**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:40](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L40)

___

### IS\_STRIKETHROUGH

• `Const` **IS\_STRIKETHROUGH**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:41](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L41)

___

### IS\_SUBSCRIPT

• `Const` **IS\_SUBSCRIPT**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L44)

___

### IS\_SUPERSCRIPT

• `Const` **IS\_SUPERSCRIPT**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:45](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L45)

___

### IS\_UNDERLINE

• `Const` **IS\_UNDERLINE**: `number`

#### Defined in

[packages/lexical/src/LexicalConstants.ts:42](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L42)

___

### KEY\_ARROW\_DOWN\_COMMAND

• `Const` **KEY\_ARROW\_DOWN\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:70](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L70)

___

### KEY\_ARROW\_LEFT\_COMMAND

• `Const` **KEY\_ARROW\_LEFT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L64)

___

### KEY\_ARROW\_RIGHT\_COMMAND

• `Const` **KEY\_ARROW\_RIGHT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:60](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L60)

___

### KEY\_ARROW\_UP\_COMMAND

• `Const` **KEY\_ARROW\_UP\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:68](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L68)

___

### KEY\_BACKSPACE\_COMMAND

• `Const` **KEY\_BACKSPACE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:76](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L76)

___

### KEY\_DELETE\_COMMAND

• `Const` **KEY\_DELETE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L80)

___

### KEY\_DOWN\_COMMAND

• `Const` **KEY\_DOWN\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:58](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L58)

___

### KEY\_ENTER\_COMMAND

• `Const` **KEY\_ENTER\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent` \| ``null``\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L72)

___

### KEY\_ESCAPE\_COMMAND

• `Const` **KEY\_ESCAPE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:78](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L78)

___

### KEY\_MODIFIER\_COMMAND

• `Const` **KEY\_MODIFIER\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:124](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L124)

___

### KEY\_SPACE\_COMMAND

• `Const` **KEY\_SPACE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:74](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L74)

___

### KEY\_TAB\_COMMAND

• `Const` **KEY\_TAB\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:82](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L82)

___

### MOVE\_TO\_END

• `Const` **MOVE\_TO\_END**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L62)

___

### MOVE\_TO\_START

• `Const` **MOVE\_TO\_START**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L66)

___

### OUTDENT\_CONTENT\_COMMAND

• `Const` **OUTDENT\_CONTENT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:89](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L89)

___

### PASTE\_COMMAND

• `Const` **PASTE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<[`PasteCommandType`](lexical.md#pastecommandtype)\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:44](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L44)

___

### REDO\_COMMAND

• `Const` **REDO\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L57)

___

### REMOVE\_TEXT\_COMMAND

• `Const` **REMOVE\_TEXT\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`InputEvent` \| ``null``\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:46](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L46)

___

### SELECTION\_CHANGE\_COMMAND

• `Const` **SELECTION\_CHANGE\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L23)

___

### SELECTION\_INSERT\_CLIPBOARD\_NODES\_COMMAND

• `Const` **SELECTION\_INSERT\_CLIPBOARD\_NODES\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<\{ `nodes`: [`LexicalNode`](../classes/lexical.LexicalNode.md)[] ; `selection`: [`BaseSelection`](../interfaces/lexical.BaseSelection.md)  }\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:26](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L26)

___

### SELECT\_ALL\_COMMAND

• `Const` **SELECT\_ALL\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`KeyboardEvent`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:108](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L108)

___

### TEXT\_TYPE\_TO\_FORMAT

• `Const` **TEXT\_TYPE\_TO\_FORMAT**: `Record`\<[`TextFormatType`](lexical.md#textformattype) \| `string`, `number`\>

#### Defined in

[packages/lexical/src/LexicalConstants.ts:98](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalConstants.ts#L98)

___

### UNDO\_COMMAND

• `Const` **UNDO\_COMMAND**: [`LexicalCommand`](lexical.md#lexicalcommand)\<`void`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:56](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L56)

## Functions

### $addUpdateTag

▸ **$addUpdateTag**(`tag`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tag` | `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1312](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1312)

___

### $applyNodeReplacement

▸ **$applyNodeReplacement**\<`N`\>(`node`): `N`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

`N`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1409](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1409)

___

### $cloneWithProperties

▸ **$cloneWithProperties**\<`T`\>(`latestNode`): `T`

Returns a clone of a node with the same key and parent/next/prev pointers and other
properties that are not set by the KlassConstructor.clone (format, style, etc.).

Does not mutate the EditorState.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `latestNode` | `T` |

#### Returns

`T`

The clone of the node.

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1763](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1763)

___

### $copyNode

▸ **$copyNode**\<`T`\>(`node`): `T`

Returns a shallow clone of node with a new key

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `T` | The node to be copied. |

#### Returns

`T`

The copy of the node.

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1403](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1403)

___

### $createLineBreakNode

▸ **$createLineBreakNode**(): [`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Returns

[`LineBreakNode`](../classes/lexical.LineBreakNode.md)

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:82](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L82)

___

### $createNodeSelection

▸ **$createNodeSelection**(): [`NodeSelection`](../classes/lexical.NodeSelection.md)

#### Returns

[`NodeSelection`](../classes/lexical.NodeSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2222](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2222)

___

### $createParagraphNode

▸ **$createParagraphNode**(): [`ParagraphNode`](../classes/lexical.ParagraphNode.md)

#### Returns

[`ParagraphNode`](../classes/lexical.ParagraphNode.md)

#### Defined in

[packages/lexical/src/nodes/LexicalParagraphNode.ts:222](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalParagraphNode.ts#L222)

___

### $createPoint

▸ **$createPoint**(`key`, `offset`, `type`): [`PointType`](lexical.md#pointtype)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `offset` | `number` |
| `type` | ``"element"`` \| ``"text"`` |

#### Returns

[`PointType`](lexical.md#pointtype)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:159](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L159)

___

### $createRangeSelection

▸ **$createRangeSelection**(): [`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Returns

[`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2216](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2216)

___

### $createRangeSelectionFromDom

▸ **$createRangeSelectionFromDom**(`domSelection`, `editor`): ``null`` \| [`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `domSelection` | ``null`` \| `Selection` |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

#### Returns

``null`` \| [`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2244](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2244)

___

### $createTabNode

▸ **$createTabNode**(): [`TabNode`](../classes/lexical.TabNode.md)

#### Returns

[`TabNode`](../classes/lexical.TabNode.md)

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:85](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L85)

___

### $createTextNode

▸ **$createTextNode**(`text?`): [`TextNode`](../classes/lexical.TextNode.md)

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `text` | `string` | `''` |

#### Returns

[`TextNode`](../classes/lexical.TextNode.md)

#### Defined in

[packages/lexical/src/nodes/LexicalTextNode.ts:1295](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTextNode.ts#L1295)

___

### $getAdjacentNode

▸ **$getAdjacentNode**(`focus`, `isBackward`): ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `focus` | [`PointType`](lexical.md#pointtype) |
| `isBackward` | `boolean` |

#### Returns

``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1176](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1176)

___

### $getCharacterOffsets

▸ **$getCharacterOffsets**(`selection`): [`number`, `number`]

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

[`number`, `number`]

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1777](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1777)

___

### $getEditor

▸ **$getEditor**(): [`LexicalEditor`](../classes/lexical.LexicalEditor.md)

Utility function for accessing current active editor instance.

#### Returns

[`LexicalEditor`](../classes/lexical.LexicalEditor.md)

Current active editor

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1714](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1714)

___

### $getNearestNodeFromDOMNode

▸ **$getNearestNodeFromDOMNode**(`startingDOM`, `editorState?`): [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `startingDOM` | `Node` |
| `editorState?` | [`EditorState`](../classes/lexical.EditorState.md) |

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null``

#### Defined in

[packages/lexical/src/LexicalUtils.ts:453](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L453)

___

### $getNearestRootOrShadowRoot

▸ **$getNearestRootOrShadowRoot**(`node`): [`RootNode`](../classes/lexical.RootNode.md) \| [`ElementNode`](../classes/lexical.ElementNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

[`RootNode`](../classes/lexical.RootNode.md) \| [`ElementNode`](../classes/lexical.ElementNode.md)

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1371](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1371)

___

### $getNodeByKey

▸ **$getNodeByKey**\<`T`\>(`key`, `_editorState?`): `T` \| ``null``

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `_editorState?` | [`EditorState`](../classes/lexical.EditorState.md) |

#### Returns

`T` \| ``null``

#### Defined in

[packages/lexical/src/LexicalUtils.ts:428](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L428)

___

### $getNodeByKeyOrThrow

▸ **$getNodeByKeyOrThrow**\<`N`\>(`key`): `N`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`N`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1452](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1452)

___

### $getPreviousSelection

▸ **$getPreviousSelection**(): ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Returns

``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2336](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2336)

___

### $getRoot

▸ **$getRoot**(): [`RootNode`](../classes/lexical.RootNode.md)

#### Returns

[`RootNode`](../classes/lexical.RootNode.md)

#### Defined in

[packages/lexical/src/LexicalUtils.ts:507](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L507)

___

### $getSelection

▸ **$getSelection**(): ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Returns

``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md)

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2331](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2331)

___

### $getTextContent

▸ **$getTextContent**(): `string`

#### Returns

`string`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2718](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2718)

___

### $hasAncestor

▸ **$hasAncestor**(`child`, `targetNode`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `child` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |
| `targetNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1337](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1337)

___

### $hasUpdateTag

▸ **$hasUpdateTag**(`tag`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tag` | `string` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1307](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1307)

___

### $insertNodes

▸ **$insertNodes**(`nodes`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nodes` | [`LexicalNode`](../classes/lexical.LexicalNode.md)[] |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2709](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2709)

___

### $isBlockElementNode

▸ **$isBlockElementNode**(`node`): node is ElementNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is ElementNode

#### Defined in

[packages/lexical/src/LexicalSelection.ts:2186](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L2186)

___

### $isDecoratorNode

▸ **$isDecoratorNode**\<`T`\>(`node`): node is DecoratorNode\<T\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is DecoratorNode\<T\>

#### Defined in

[packages/lexical/src/nodes/LexicalDecoratorNode.ts:52](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalDecoratorNode.ts#L52)

___

### $isElementNode

▸ **$isElementNode**(`node`): node is ElementNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is ElementNode

#### Defined in

[packages/lexical/src/nodes/LexicalElementNode.ts:604](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalElementNode.ts#L604)

___

### $isInlineElementOrDecoratorNode

▸ **$isInlineElementOrDecoratorNode**(`node`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1364](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1364)

___

### $isLeafNode

▸ **$isLeafNode**(`node`): node is DecoratorNode\<unknown\> \| TextNode \| LineBreakNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is DecoratorNode\<unknown\> \| TextNode \| LineBreakNode

#### Defined in

[packages/lexical/src/LexicalUtils.ts:229](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L229)

___

### $isLineBreakNode

▸ **$isLineBreakNode**(`node`): node is LineBreakNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is LineBreakNode

#### Defined in

[packages/lexical/src/nodes/LexicalLineBreakNode.ts:86](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalLineBreakNode.ts#L86)

___

### $isNodeSelection

▸ **$isNodeSelection**(`x`): x is NodeSelection

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `unknown` |

#### Returns

x is NodeSelection

#### Defined in

[packages/lexical/src/LexicalSelection.ts:1761](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L1761)

___

### $isParagraphNode

▸ **$isParagraphNode**(`node`): node is ParagraphNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is ParagraphNode

#### Defined in

[packages/lexical/src/nodes/LexicalParagraphNode.ts:226](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalParagraphNode.ts#L226)

___

### $isRangeSelection

▸ **$isRangeSelection**(`x`): x is RangeSelection

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `unknown` |

#### Returns

x is RangeSelection

#### Defined in

[packages/lexical/src/LexicalSelection.ts:393](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalSelection.ts#L393)

___

### $isRootNode

▸ **$isRootNode**(`node`): node is RootNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) \| [`RootNode`](../classes/lexical.RootNode.md) |

#### Returns

node is RootNode

#### Defined in

[packages/lexical/src/nodes/LexicalRootNode.ts:128](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalRootNode.ts#L128)

___

### $isRootOrShadowRoot

▸ **$isRootOrShadowRoot**(`node`): node is RootNode \| ShadowRootNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is RootNode \| ShadowRootNode

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1391](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1391)

___

### $isTabNode

▸ **$isTabNode**(`node`): node is TabNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is TabNode

#### Defined in

[packages/lexical/src/nodes/LexicalTabNode.ts:89](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTabNode.ts#L89)

___

### $isTextNode

▸ **$isTextNode**(`node`): node is TextNode

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | `undefined` \| ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Returns

node is TextNode

#### Defined in

[packages/lexical/src/nodes/LexicalTextNode.ts:1299](https://github.com/facebook/lexical/tree/main/packages/lexical/src/nodes/LexicalTextNode.ts#L1299)

___

### $isTokenOrSegmented

▸ **$isTokenOrSegmented**(`node`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`TextNode`](../classes/lexical.TextNode.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:189](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L189)

___

### $nodesOfType

▸ **$nodesOfType**\<`T`\>(`klass`): `T`[]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `klass` | [`Klass`](lexical.md#klass)\<`T`\> |

#### Returns

`T`[]

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1133](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1133)

___

### $normalizeSelection\_\_EXPERIMENTAL

▸ **$normalizeSelection__EXPERIMENTAL**(`selection`): [`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | [`RangeSelection`](../classes/lexical.RangeSelection.md) |

#### Returns

[`RangeSelection`](../classes/lexical.RangeSelection.md)

#### Defined in

[packages/lexical/src/LexicalNormalization.ts:89](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalNormalization.ts#L89)

___

### $parseSerializedNode

▸ **$parseSerializedNode**(`serializedNode`): [`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `serializedNode` | [`SerializedLexicalNode`](lexical.md#serializedlexicalnode) |

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Defined in

[packages/lexical/src/LexicalUpdates.ts:329](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUpdates.ts#L329)

___

### $selectAll

▸ **$selectAll**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1068](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1068)

___

### $setCompositionKey

▸ **$setCompositionKey**(`compositionKey`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `compositionKey` | ``null`` \| `string` |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:399](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L399)

___

### $setSelection

▸ **$setSelection**(`selection`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `selection` | ``null`` \| [`BaseSelection`](../interfaces/lexical.BaseSelection.md) |

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:515](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L515)

___

### $splitNode

▸ **$splitNode**(`node`, `offset`): [[`ElementNode`](../classes/lexical.ElementNode.md) \| ``null``, [`ElementNode`](../classes/lexical.ElementNode.md)]

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | [`ElementNode`](../classes/lexical.ElementNode.md) |
| `offset` | `number` |

#### Returns

[[`ElementNode`](../classes/lexical.ElementNode.md) \| ``null``, [`ElementNode`](../classes/lexical.ElementNode.md)]

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1567](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1567)

___

### createCommand

▸ **createCommand**\<`T`\>(`type?`): [`LexicalCommand`](lexical.md#lexicalcommand)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type?` | `string` |

#### Returns

[`LexicalCommand`](lexical.md#lexicalcommand)\<`T`\>

#### Defined in

[packages/lexical/src/LexicalCommands.ts:19](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalCommands.ts#L19)

___

### createEditor

▸ **createEditor**(`editorConfig?`): [`LexicalEditor`](../classes/lexical.LexicalEditor.md)

Creates a new LexicalEditor attached to a single contentEditable (provided in the config). This is
the lowest-level initialization API for a LexicalEditor. If you're using React or another framework,
consider using the appropriate abstractions, such as LexicalComposer

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editorConfig?` | [`CreateEditorArgs`](lexical.md#createeditorargs) | the editor configuration. |

#### Returns

[`LexicalEditor`](../classes/lexical.LexicalEditor.md)

a LexicalEditor instance

#### Defined in

[packages/lexical/src/LexicalEditor.ts:421](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalEditor.ts#L421)

___

### getNearestEditorFromDOMNode

▸ **getNearestEditorFromDOMNode**(`node`): [`LexicalEditor`](../classes/lexical.LexicalEditor.md) \| ``null``

#### Parameters

| Name | Type |
| :------ | :------ |
| `node` | ``null`` \| `Node` |

#### Returns

[`LexicalEditor`](../classes/lexical.LexicalEditor.md) \| ``null``

#### Defined in

[packages/lexical/src/LexicalUtils.ts:159](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L159)

___

### isBlockDomNode

▸ **isBlockDomNode**(`node`): `boolean`

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `Node` | the Dom Node to check |

#### Returns

`boolean`

if the Dom Node is a block node

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1667](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1667)

___

### isCurrentlyReadOnlyMode

▸ **isCurrentlyReadOnlyMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUpdates.ts:72](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUpdates.ts#L72)

___

### isHTMLAnchorElement

▸ **isHTMLAnchorElement**(`x`): x is HTMLAnchorElement

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `x` | `Node` | The element being tested |

#### Returns

x is HTMLAnchorElement

Returns true if x is an HTML anchor tag, false otherwise

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1636](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1636)

___

### isHTMLElement

▸ **isHTMLElement**(`x`): x is HTMLElement

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `x` | `EventTarget` \| `Node` | The element being testing |

#### Returns

x is HTMLElement

Returns true if x is an HTML element, false otherwise.

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1644](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1644)

___

### isInlineDomNode

▸ **isInlineDomNode**(`node`): `boolean`

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `Node` | the Dom Node to check |

#### Returns

`boolean`

if the Dom Node is an inline node

#### Defined in

[packages/lexical/src/LexicalUtils.ts:1654](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L1654)

___

### isLexicalEditor

▸ **isLexicalEditor**(`editor`): editor is LexicalEditor

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | `unknown` |

#### Returns

editor is LexicalEditor

true if the given argument is a LexicalEditor instance from this build of Lexical

#### Defined in

[packages/lexical/src/LexicalUtils.ts:154](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L154)

___

### isSelectionCapturedInDecoratorInput

▸ **isSelectionCapturedInDecoratorInput**(`anchorDOM`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `anchorDOM` | `Node` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:113](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L113)

___

### isSelectionWithinEditor

▸ **isSelectionWithinEditor**(`editor`, `anchorDOM`, `focusDOM`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `anchorDOM` | ``null`` \| `Node` |
| `focusDOM` | ``null`` \| `Node` |

#### Returns

`boolean`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:130](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L130)

___

### resetRandomKey

▸ **resetRandomKey**(): `void`

#### Returns

`void`

#### Defined in

[packages/lexical/src/LexicalUtils.ts:80](https://github.com/facebook/lexical/tree/main/packages/lexical/src/LexicalUtils.ts#L80)
