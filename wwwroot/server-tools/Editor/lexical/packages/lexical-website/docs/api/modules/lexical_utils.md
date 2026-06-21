---
id: "lexical_utils"
title: "Module: @lexical/utils"
custom_edit_url: null
---

## References

### $splitNode

Re-exports [$splitNode](lexical.md#$splitnode)

___

### isBlockDomNode

Re-exports [isBlockDomNode](lexical.md#isblockdomnode)

___

### isHTMLAnchorElement

Re-exports [isHTMLAnchorElement](lexical.md#ishtmlanchorelement)

___

### isHTMLElement

Re-exports [isHTMLElement](lexical.md#ishtmlelement)

___

### isInlineDomNode

Re-exports [isInlineDomNode](lexical.md#isinlinedomnode)

## Type Aliases

### DFSNode

Ƭ **DFSNode**: `Readonly`\<\{ `depth`: `number` ; `node`: [`LexicalNode`](../classes/lexical.LexicalNode.md)  }\>

#### Defined in

[packages/lexical-utils/src/index.ts:66](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L66)

___

### DOMNodeToLexicalConversion

Ƭ **DOMNodeToLexicalConversion**: (`element`: `Node`) => [`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Type declaration

▸ (`element`): [`LexicalNode`](../classes/lexical.LexicalNode.md)

##### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Node` |

##### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md)

#### Defined in

[packages/lexical-utils/src/index.ts:309](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L309)

___

### DOMNodeToLexicalConversionMap

Ƭ **DOMNodeToLexicalConversionMap**: `Record`\<`string`, [`DOMNodeToLexicalConversion`](lexical_utils.md#domnodetolexicalconversion)\>

#### Defined in

[packages/lexical-utils/src/index.ts:311](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L311)

## Variables

### CAN\_USE\_BEFORE\_INPUT

• `Const` **CAN\_USE\_BEFORE\_INPUT**: `boolean` = `CAN_USE_BEFORE_INPUT_`

#### Defined in

[packages/lexical-utils/src/index.ts:55](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L55)

___

### CAN\_USE\_DOM

• `Const` **CAN\_USE\_DOM**: `boolean` = `CAN_USE_DOM_`

#### Defined in

[packages/lexical-utils/src/index.ts:56](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L56)

___

### IS\_ANDROID

• `Const` **IS\_ANDROID**: `boolean` = `IS_ANDROID_`

#### Defined in

[packages/lexical-utils/src/index.ts:57](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L57)

___

### IS\_ANDROID\_CHROME

• `Const` **IS\_ANDROID\_CHROME**: `boolean` = `IS_ANDROID_CHROME_`

#### Defined in

[packages/lexical-utils/src/index.ts:58](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L58)

___

### IS\_APPLE

• `Const` **IS\_APPLE**: `boolean` = `IS_APPLE_`

#### Defined in

[packages/lexical-utils/src/index.ts:59](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L59)

___

### IS\_APPLE\_WEBKIT

• `Const` **IS\_APPLE\_WEBKIT**: `boolean` = `IS_APPLE_WEBKIT_`

#### Defined in

[packages/lexical-utils/src/index.ts:60](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L60)

___

### IS\_CHROME

• `Const` **IS\_CHROME**: `boolean` = `IS_CHROME_`

#### Defined in

[packages/lexical-utils/src/index.ts:61](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L61)

___

### IS\_FIREFOX

• `Const` **IS\_FIREFOX**: `boolean` = `IS_FIREFOX_`

#### Defined in

[packages/lexical-utils/src/index.ts:62](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L62)

___

### IS\_IOS

• `Const` **IS\_IOS**: `boolean` = `IS_IOS_`

#### Defined in

[packages/lexical-utils/src/index.ts:63](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L63)

___

### IS\_SAFARI

• `Const` **IS\_SAFARI**: `boolean` = `IS_SAFARI_`

#### Defined in

[packages/lexical-utils/src/index.ts:64](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L64)

## Functions

### $dfs

▸ **$dfs**(`startingNode?`, `endingNode?`): [`DFSNode`](lexical_utils.md#dfsnode)[]

"Depth-First Search" starts at the root/top node of a tree and goes as far as it can down a branch end
before backtracking and finding a new path. Consider solving a maze by hugging either wall, moving down a
branch until you hit a dead-end (leaf) and backtracking to find the nearest branching path and repeat.
It will then return all the nodes found in the search in an array of objects.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `startingNode?` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to start the search, if ommitted, it will start at the root node. |
| `endingNode?` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to end the search, if ommitted, it will find all descendants of the startingNode. |

#### Returns

[`DFSNode`](lexical_utils.md#dfsnode)[]

An array of objects of all the nodes found by the search, including their depth into the tree.
\{depth: number, node: LexicalNode\} It will always return at least 1 node (the ending node) so long as it exists

#### Defined in

[packages/lexical-utils/src/index.ts:179](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L179)

___

### $filter

▸ **$filter**\<`T`\>(`nodes`, `filterFn`): `T`[]

Filter the nodes

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `nodes` | [`LexicalNode`](../classes/lexical.LexicalNode.md)[] | Array of nodes that needs to be filtered |
| `filterFn` | (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md)) => ``null`` \| `T` | A filter function that returns node if the current node satisfies the condition otherwise null |

#### Returns

`T`[]

Array of filtered nodes

#### Defined in

[packages/lexical-utils/src/index.ts:558](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L558)

___

### $findMatchingParent

▸ **$findMatchingParent**\<`T`\>(`startingNode`, `findFn`): ``null`` \| `T`

Starts with a node and moves up the tree (toward the root node) to find a matching node based on
the search parameters of the findFn. (Consider JavaScripts' .find() function where a testing function must be
passed as an argument. eg. if( (node) => node.__type === 'div') ) return true; otherwise return false

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node where the search starts. |
| `findFn` | (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md)) => node is T | A testing function that returns true if the current node satisfies the testing parameters. |

#### Returns

``null`` \| `T`

A parent node that matches the findFn parameters, or null if one wasn't found.

#### Defined in

[packages/lexical-utils/src/index.ts:325](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L325)

▸ **$findMatchingParent**(`startingNode`, `findFn`): ``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)

Starts with a node and moves up the tree (toward the root node) to find a matching node based on
the search parameters of the findFn. (Consider JavaScripts' .find() function where a testing function must be
passed as an argument. eg. if( (node) => node.__type === 'div') ) return true; otherwise return false

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node where the search starts. |
| `findFn` | (`node`: [`LexicalNode`](../classes/lexical.LexicalNode.md)) => `boolean` | A testing function that returns true if the current node satisfies the testing parameters. |

#### Returns

``null`` \| [`LexicalNode`](../classes/lexical.LexicalNode.md)

A parent node that matches the findFn parameters, or null if one wasn't found.

#### Defined in

[packages/lexical-utils/src/index.ts:329](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L329)

___

### $getNearestBlockElementAncestorOrThrow

▸ **$getNearestBlockElementAncestorOrThrow**(`startNode`): [`ElementNode`](../classes/lexical.ElementNode.md)

Returns the element node of the nearest ancestor, otherwise throws an error.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `startNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The starting node of the search |

#### Returns

[`ElementNode`](../classes/lexical.ElementNode.md)

The ancestor node found

#### Defined in

[packages/lexical-utils/src/index.ts:292](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L292)

___

### $getNearestNodeOfType

▸ **$getNearestNodeOfType**\<`T`\>(`node`, `klass`): `T` \| ``null``

Takes a node and traverses up its ancestors (toward the root node)
in order to find a specific type of node.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`ElementNode`](../classes/lexical.ElementNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | the node to begin searching. |
| `klass` | [`Klass`](lexical.md#klass)\<`T`\> | an instance of the type of node to look for. |

#### Returns

`T` \| ``null``

the node of type klass that was passed, or null if none exist.

#### Defined in

[packages/lexical-utils/src/index.ts:270](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L270)

___

### $getNextRightPreorderNode

▸ **$getNextRightPreorderNode**(`startingNode`): [`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null``

Performs a right-to-left preorder tree traversal.
From the starting node it goes to the rightmost child, than backtracks to paret and finds new rightmost path.
It will return the next node in traversal sequence after the startingNode.
The traversal is similar to $dfs functions above, but the nodes are visited right-to-left, not left-to-right.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `startingNode` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | The node to start the search. |

#### Returns

[`LexicalNode`](../classes/lexical.LexicalNode.md) \| ``null``

The next node in pre-order right to left traversal sequence or `null`, if the node does not exist

#### Defined in

[packages/lexical-utils/src/index.ts:240](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L240)

___

### $insertFirst

▸ **$insertFirst**(`parent`, `node`): `void`

Appends the node before the first child of the parent node

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `parent` | [`ElementNode`](../classes/lexical.ElementNode.md) | A parent node |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | Node that needs to be appended |

#### Returns

`void`

#### Defined in

[packages/lexical-utils/src/index.ts:576](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L576)

___

### $insertNodeToNearestRoot

▸ **$insertNodeToNearestRoot**\<`T`\>(`node`): `T`

If the selected insertion area is the root/shadow root node (see [lexical!$isRootOrShadowRoot](lexical.md#$isrootorshadowroot)),
the node will be appended there, otherwise, it will be inserted before the insertion area.
If there is no selection where the node is to be inserted, it will be appended after any current nodes
within the tree, as a child of the root node. A paragraph node will then be added after the inserted node and selected.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `T` | extends [`LexicalNode`](../classes/lexical.LexicalNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | `T` | The node to be inserted |

#### Returns

`T`

The node after its insertion

#### Defined in

[packages/lexical-utils/src/index.ts:469](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L469)

___

### $isEditorIsNestedEditor

▸ **$isEditorIsNestedEditor**(`editor`): `boolean`

Checks if the editor is a nested editor created by LexicalNestedComposer

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |

#### Returns

`boolean`

#### Defined in

[packages/lexical-utils/src/index.ts:605](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L605)

___

### $restoreEditorState

▸ **$restoreEditorState**(`editor`, `editorState`): `void`

Clones the editor and marks it as dirty to be reconciled. If there was a selection,
it would be set back to its previous state, or null otherwise.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor |
| `editorState` | [`EditorState`](../classes/lexical.EditorState.md) | The editor's state |

#### Returns

`void`

#### Defined in

[packages/lexical-utils/src/index.ts:440](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L440)

___

### $wrapNodeInElement

▸ **$wrapNodeInElement**(`node`, `createElementNode`): [`ElementNode`](../classes/lexical.ElementNode.md)

Wraps the node into another node created from a createElementNode function, eg. $createParagraphNode

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `node` | [`LexicalNode`](../classes/lexical.LexicalNode.md) | Node to be wrapped. |
| `createElementNode` | () => [`ElementNode`](../classes/lexical.ElementNode.md) | Creates a new lexical element to wrap the to-be-wrapped node and returns it. |

#### Returns

[`ElementNode`](../classes/lexical.ElementNode.md)

A new lexical element with the previous node appended within (as a child, including its children).

#### Defined in

[packages/lexical-utils/src/index.ts:524](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L524)

___

### addClassNamesToElement

▸ **addClassNamesToElement**(`element`, `...classNames`): `void`

Takes an HTML element and adds the classNames passed within an array,
ignoring any non-string types. A space can be used to add multiple classes
eg. addClassNamesToElement(element, ['element-inner active', true, null])
will add both 'element-inner' and 'active' as classes to that element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` | The element in which the classes are added |
| `...classNames` | (`undefined` \| ``null`` \| `string` \| `boolean`)[] | An array defining the class names to add to the element |

#### Returns

`void`

#### Defined in

[packages/lexical-utils/src/index.ts:79](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L79)

___

### calculateZoomLevel

▸ **calculateZoomLevel**(`element`): `number`

Calculates the zoom level of an element as a result of using
css zoom property.

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | ``null`` \| `Element` |

#### Returns

`number`

#### Defined in

[packages/lexical-utils/src/index.ts:590](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L590)

___

### isMimeType

▸ **isMimeType**(`file`, `acceptableMimeTypes`): `boolean`

Returns true if the file type matches the types passed within the acceptableMimeTypes array, false otherwise.
The types passed must be strings and are CASE-SENSITIVE.
eg. if file is of type 'text' and acceptableMimeTypes = ['TEXT', 'IMAGE'] the function will return false.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `file` | `File` | The file you want to type check. |
| `acceptableMimeTypes` | `string`[] | An array of strings of types which the file is checked against. |

#### Returns

`boolean`

true if the file is an acceptable mime type, false otherwise.

#### Defined in

[packages/lexical-utils/src/index.ts:115](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L115)

___

### markSelection

▸ **markSelection**(`editor`, `onReposition?`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `onReposition?` | (`node`: `HTMLElement`[]) => `void` |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-utils/src/markSelection.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/markSelection.ts#L23)

___

### mediaFileReader

▸ **mediaFileReader**(`files`, `acceptableMimeTypes`): `Promise`\<\{ `file`: `File` ; `result`: `string`  }[]\>

Lexical File Reader with:
 1. MIME type support
 2. batched results (HistoryPlugin compatibility)
 3. Order aware (respects the order when multiple Files are passed)

const filesResult = await mediaFileReader(files, ['image/']);
filesResult.forEach(file => editor.dispatchCommand('INSERT_IMAGE', \{
  src: file.result,
\}));

#### Parameters

| Name | Type |
| :------ | :------ |
| `files` | `File`[] |
| `acceptableMimeTypes` | `string`[] |

#### Returns

`Promise`\<\{ `file`: `File` ; `result`: `string`  }[]\>

#### Defined in

[packages/lexical-utils/src/index.ts:138](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L138)

___

### mergeRegister

▸ **mergeRegister**(`...func`): () => `void`

Returns a function that will execute all functions passed when called. It is generally used
to register multiple lexical listeners and then tear them down with a single function call, such
as React's useEffect hook.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `...func` | `Func`[] | An array of cleanup functions meant to be executed by the returned function. |

#### Returns

`fn`

the function which executes all the passed cleanup functions.

▸ (): `void`

##### Returns

`void`

**`Example`**

```ts
useEffect(() => {
  return mergeRegister(
    editor.registerCommand(...registerCommand1 logic),
    editor.registerCommand(...registerCommand2 logic),
    editor.registerCommand(...registerCommand3 logic)
  )
}, [editor])
```
In this case, useEffect is returning the function returned by mergeRegister as a cleanup
function to be executed after either the useEffect runs again (due to one of its dependencies
updating) or the component it resides in unmounts.
Note the functions don't neccesarily need to be in an array as all arguments
are considered to be the func argument and spread from there.
The order of cleanup is the reverse of the argument order. Generally it is
expected that the first "acquire" will be "released" last (LIFO order),
because a later step may have some dependency on an earlier one.

#### Defined in

[packages/lexical-utils/src/mergeRegister.ts:36](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/mergeRegister.ts#L36)

___

### objectKlassEquals

▸ **objectKlassEquals**\<`T`\>(`object`, `objectClass`): `boolean`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `object` | `unknown` | = The instance of the type |
| `objectClass` | `ObjectKlass`\<`T`\> | = The class of the type |

#### Returns

`boolean`

Whether the object is has the same Klass of the objectClass, ignoring the difference across window (e.g. different iframs)

#### Defined in

[packages/lexical-utils/src/index.ts:542](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L542)

___

### positionNodeOnRange

▸ **positionNodeOnRange**(`editor`, `range`, `onReposition`): () => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) |
| `range` | `Range` |
| `onReposition` | (`node`: `HTMLElement`[]) => `void` |

#### Returns

`fn`

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-utils/src/positionNodeOnRange.ts:23](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/positionNodeOnRange.ts#L23)

___

### registerNestedElementResolver

▸ **registerNestedElementResolver**\<`N`\>(`editor`, `targetNode`, `cloneNode`, `handleOverlap`): () => `void`

Attempts to resolve nested element nodes of the same type into a single node of that type.
It is generally used for marks/commenting

#### Type parameters

| Name | Type |
| :------ | :------ |
| `N` | extends [`ElementNode`](../classes/lexical.ElementNode.md) |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `editor` | [`LexicalEditor`](../classes/lexical.LexicalEditor.md) | The lexical editor |
| `targetNode` | [`Klass`](lexical.md#klass)\<`N`\> | The target for the nested element to be extracted from. |
| `cloneNode` | (`from`: `N`) => `N` | See $createMarkNode |
| `handleOverlap` | (`from`: `N`, `to`: `N`) => `void` | Handles any overlap between the node to extract and the targetNode |

#### Returns

`fn`

The lexical editor

▸ (): `void`

##### Returns

`void`

#### Defined in

[packages/lexical-utils/src/index.ts:359](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L359)

___

### removeClassNamesFromElement

▸ **removeClassNamesFromElement**(`element`, `...classNames`): `void`

Takes an HTML element and removes the classNames passed within an array,
ignoring any non-string types. A space can be used to remove multiple classes
eg. removeClassNamesFromElement(element, ['active small', true, null])
will remove both the 'active' and 'small' classes from that element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `HTMLElement` | The element in which the classes are removed |
| `...classNames` | (`undefined` \| ``null`` \| `string` \| `boolean`)[] | An array defining the class names to remove from the element |

#### Returns

`void`

#### Defined in

[packages/lexical-utils/src/index.ts:97](https://github.com/facebook/lexical/tree/main/packages/lexical-utils/src/index.ts#L97)
