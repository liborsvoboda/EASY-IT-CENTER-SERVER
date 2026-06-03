# JSDoc Cheat Sheet

Things I found myself researching over and over without taking the time to write them down. Until now.

**Table of Contents**

1. [Should I use `{String}` _vs_ `{string}` or `{Number}` _vs_ `{number}` ...?](#literal-vs-constructor-types)
2. [Type Expression: Optional _vs_ Nullable _vs_ Non-nullable](#opt-vs-nullable-vs-nonnullable)
3. [When do I need to use the `@function` tag?](#tag-function-use-cases)

<a name="literal-vs-constructor-types"></a>
## Should I use `{String}` _vs_ `{string}` or `{Number}` _vs_ `{number}` ...?

### Strings, numbers and booleans

These aren't interchangeable type expressions. For example if a symbol is meant to hold a literal string you should use `{string}` and not `{String}`: _(The same is true for `{Number}` e.g. `new Number(42)` _vs_ `{number}` e.g. `42` and `{Boolean}` e.g. `new Boolean` and `{boolean}` e.g. `false`.)_

```javascript
/** @param {String} x */
const a = x => x;

/** @param {string} x */
const b = x => x;
```

| _fn_ | Annotation   | fn("foo") | fn(new String("foo")) |
|:-----|:-------------|:----------|:----------------------|
| a    | `{String} x` | ╳         | ✓                     |
| b    | `{string} x` | ✓         | ╳                     |

╳ represents the _JSC_TYPE_MISMATCH_ error in GCC.

Examples have been compiled with the [Google Closure Compiler][gcc-home] and are available [here](https://closure-compiler.appspot.com/home#code%3D%252F%252F%2520%253D%253DClosureCompiler%253D%253D%250A%252F%252F%2520%2540output_file_name%2520default.js%250A%252F%252F%2520%2540compilation_level%2520ADVANCED_OPTIMIZATIONS%250A%252F%252F%2520%253D%253D%252FClosureCompiler%253D%253D%250A%250A%252F**%2520%2540param%2520%257BString%257D%2520x%2520*%252F%250Aconst%2520a%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257Bstring%257D%2520x%2520*%252F%250Aconst%2520b%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250Aa(%2522foo%2522)%253B%250Aa(new%2520String(%2522foo%2522))%253B%250A%250Ab(%2522foo%2522)%253B%250Ab(new%2520String(%2522foo%2522))%253B).

### Objects and arrays

Objects and arrays are covered respectively by the `{Object}` and `{Array}` type expressions which both handle literal and constructor expressions: (`{}` _vs_ `new Object` and `[]` _vs_ `new Array`)

```javascript
/** @param {Object} x */
const a = x => x;

/** @param {Array} x */
const b = x => x;
```

| _fn_ | Annotation   | fn() | fn(&lt;literal&gt;) | fn(&lt;constructor&gt;) | fn(null) | fn(undefined) |
|:-----|:-------------|:-----|:--------------------|:------------------------|:---------|:--------------|
| a    | `{Object} x` | ╳1   | ✓                   | ✓                       | ✓        | ╳2            |
| b    | `{Array} x`  | ╳1   | ✓                   | ✓                       | ✓        | ╳2            |

╳1 represents the _JSC_WRONG_ARGUMENT_COUNT_ error in GCC.<br>
╳2 represents the _JSC_TYPE_MISMATCH_ error in GCC.

Examples have been compiled using the [Google Closure Compiler][gcc-home] and are available [here](https://closure-compiler.appspot.com/home#code%3D%252F%252F%2520%253D%253DClosureCompiler%253D%253D%250A%252F%252F%2520%2540compilation_level%2520ADVANCED_OPTIMIZATIONS%250A%252F%252F%2520%2540output_file_name%2520default.js%250A%252F%252F%2520%253D%253D%252FClosureCompiler%253D%253D%250A%250A%252F**%2520%2540param%2520%257BObject%257D%2520x%2520*%252F%250Aconst%2520a%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257BArray%257D%2520x%2520*%252F%250Aconst%2520b%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250Aa(%257B%257D)%253B%250Aa(new%2520Object)%253B%250Aa()%253B%250Aa(null)%253B%250Aa(undefined)%253B%250A%250Ab(%255B%255D)%253B%250Ab(new%2520Array)%253B%250Ab()%253B%250Ab(null)%253B%250Ab(undefined)%253B%250A%250A%250A).

Note that arrays, objects (and functions) are nullable by default. So `{Object}` is the same as `{?Object}` which explains why `a(null)` passed the type check.

> Note that the following are already nullable, and thus prepending `?` is redundant, but is recommended so that the intent is clear and explicit:
> `?Object`, `?Array`, `?Function`

See [Types in the Closure Type System][gcc-types]

### Functions

There are two type expressions: `{function()}` and `{Function}`. The former being preferred over the latter as it allows to document parameters and return values.

```javascript
/** @param {Function} x */
const a = x => x;

/** @param {function()} x */
const b = x => x;
```

| Code                             | `{Function} x` | `{function()} x` |
|:---------------------------------|:---------------|:-----------------|
| `fn(() => 42);`                  | ✓              | ✓                |
| `fn(function () { return 42 });` | ✓              | ✓                |
| `fn(new Function('return 42'));` | ✓              | ✓                |
| `fn();`                          | ╳1             | ╳1               |
| `fn(null);`                      | ✓              | ╳2               |
| `fn(undefined);`                 | ╳2             | ╳2               |

╳1 represents the _JSC_WRONG_ARGUMENT_COUNT_ error in GCC.<br>
╳2 represents the _JSC_TYPE_MISMATCH_ error in GCC.

Examples have been compiled using the [Google Closure Compiler][gcc-home] and are available [here](https://closure-compiler.appspot.com/home#code%3D%252F%252F%2520%253D%253DClosureCompiler%253D%253D%250A%252F%252F%2520%2540output_file_name%2520default.js%250A%252F%252F%2520%2540compilation_level%2520ADVANCED_OPTIMIZATIONS%250A%252F%252F%2520%253D%253D%252FClosureCompiler%253D%253D%250A%250A%252F**%2520%2540param%2520%257BFunction%257D%2520x%2520*%252F%250Aconst%2520a%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257Bfunction()%257D%2520x%2520*%252F%250Aconst%2520b%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250Aa(()%2520%253D%253E%252042)%253B%250Aa(function%2520()%2520%257B%2520return%252042%2520%257D)%253B%250Aa(new%2520Function('return%252042'))%253B%250Aa()%253B%250Aa(null)%253B%250Aa(undefined)%253B%250A%250Ab(()%2520%253D%253E%252042)%253B%250Ab(function%2520()%2520%257B%2520return%252042%2520%257D)%253B%250Ab(new%2520Function('return%252042'))%253B%250Ab()%253B%250Ab(null)%253B%250Ab(undefined)%253B).

Note that `{Function}` is the same as `{?Function}` meaning that it is nullable by default.

<a name="opt-vs-nullable-vs-nonnullable"></a>
## Type Expression: Optional _vs_ Nullable _vs_ Non-nullable

A type expression is used to document the type of many different things such as a parameter, a variable or a property or the return value of a function. [JSDoc][jsdoc-home] supports the [Google Closure Compiler Type System][gcc-types] in type expressions.

```javascript
/** @param {number} x */
const a = x => x;

/** @param {number=} x */
const b = x => x;

/** @param {number} [x] */
const c = x => x;

/** @param {number} [x=42] */
const d = x => x;

/** @param {!number} x */
const e = x => x;

/** @param {!number=} x */
const f = x => x;

/** @param {!number} [x] */
const g = x => x;

/** @param {!number} [x=42] */
const h = x => x;

/** @param {?number} x */
const i = x => x;

/** @param {?number=} x */
const j = x => x;

/** @param {?number} [x] */
const k = x => x;

/** @param {?number} [x=42] */
const l = x => x;
```

| _fn_ | Annotation         | Expect                        | Default     | fn() | fn("42") | fn(null) | fn(undefined) | fn(42) |
|:-----|:-------------------|:------------------------------|:------------|:-----|:---------|:---------|:--------------|:-------|
| a    | `{number} x`       | Number                        |             | ╳1   | ╳2       | ╳2       | ╳2            | ✓      |
| b    | `{number=} x`      | Number or `undefined`         | `undefined` | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| c    | `{number} [x]`     | Number or `undefined`         | `undefined` | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| d    | `{number} [x=42]`  | Number or `undefined`         | `42`        | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| e    | `{!number} x`      | Number                        |             | ╳1   | ╳2       | ╳2       | ╳2            | ✓      |
| f    | `{!number=} x`     | Number or `undefined`         | `undefined` | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| g    | `{!number} [x]`    | Number or `undefined`         | `undefined` | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| h    | `{!number} [x=42]` | Number or `undefined`         | `42`        | ✓    | ╳2       | ╳2       | ✓             | ✓      |
| i    | `{?number} x`      | Number or `null`              |             | ╳1   | ╳2       | ✓        | ╳2            | ✓      |
| j    | `{?number=} x`     | Number, `null` or `undefined` | `undefined` | ✓    | ╳2       | ✓        | ✓             | ✓      |
| k    | `{?number} [x]`    | Number, `null` or `undefined` | `undefined` | ✓    | ╳2       | ✓        | ✓             | ✓      |
| l    | `{?number} [x=42]` | Number, `null` or `undefined` | `42`        | ✓    | ╳2       | ✓        | ✓             | ✓      |

╳1 represents the _JSC_WRONG_ARGUMENT_COUNT_ error in GCC.<br>
╳2 represents the _JSC_TYPE_MISMATCH_ error in GCC.

Examples have been compiled with the [Google Closure Compiler][gcc-home] and are available [here](https://closure-compiler.appspot.com/home#code%3D%252F%252F%2520%253D%253DClosureCompiler%253D%253D%250A%252F%252F%2520%2540output_file_name%2520default.js%250A%252F%252F%2520%2540compilation_level%2520ADVANCED_OPTIMIZATIONS%250A%252F%252F%2520%253D%253D%252FClosureCompiler%253D%253D%250A%250A%252F**%2520%2540param%2520%257Bnumber%257D%2520x%2520*%252F%250Aconst%2520a%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257Bnumber%253D%257D%2520x%2520*%252F%250Aconst%2520b%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257Bnumber%257D%2520%255Bx%255D%2520*%252F%250Aconst%2520c%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257Bnumber%257D%2520%255Bx%253D42%255D%2520*%252F%250Aconst%2520d%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B!number%257D%2520x%2520*%252F%250Aconst%2520e%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B!number%253D%257D%2520x%2520*%252F%250Aconst%2520f%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B!number%257D%2520%255Bx%255D%2520*%252F%250Aconst%2520g%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B!number%257D%2520%255Bx%253D42%255D%2520*%252F%250Aconst%2520h%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B%253Fnumber%257D%2520x%2520*%252F%250Aconst%2520i%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B%253Fnumber%253D%257D%2520x%2520*%252F%250Aconst%2520j%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B%253Fnumber%257D%2520%255Bx%255D%2520*%252F%250Aconst%2520k%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250A%252F**%2520%2540param%2520%257B%253Fnumber%257D%2520%255Bx%253D42%255D%2520*%252F%250Aconst%2520l%2520%253D%2520x%2520%253D%253E%2520x%253B%250A%250Aa()%253B%250Aa(%252242%2522)%253B%250Aa(null)%253B%250Aa(undefined)%253B%250Aa(42)%253B%250Ab()%253B%250Ab(%252242%2522)%253B%250Ab(null)%253B%250Ab(undefined)%253B%250Ab(42)%253B%250Ac()%253B%250Ac(%252242%2522)%253B%250Ac(null)%253B%250Ac(undefined)%253B%250Ac(42)%253B%250Ad()%253B%250Ad(%252242%2522)%253B%250Ad(null)%253B%250Ad(undefined)%253B%250Ad(42)%253B%250Ae()%253B%250Ae(%252242%2522)%253B%250Ae(null)%253B%250Ae(undefined)%253B%250Ae(42)%253B%250Af()%253B%250Af(%252242%2522)%253B%250Af(null)%253B%250Af(undefined)%253B%250Af(42)%253B%250Ag()%253B%250Ag(%252242%2522)%253B%250Ag(null)%253B%250Ag(undefined)%253B%250Ag(42)%253B%250Ah()%253B%250Ah(%252242%2522)%253B%250Ah(null)%253B%250Ah(undefined)%253B%250Ah(42)%253B%250Ai()%253B%250Ai(%252242%2522)%253B%250Ai(null)%253B%250Ai(undefined)%253B%250Ai(42)%253B%250Aj()%253B%250Aj(%252242%2522)%253B%250Aj(null)%253B%250Aj(undefined)%253B%250Aj(42)%253B%250Ak()%253B%250Ak(%252242%2522)%253B%250Ak(null)%253B%250Ak(undefined)%253B%250Ak(42)%253B%250Al()%253B%250Al(%252242%2522)%253B%250Al(null)%253B%250Al(undefined)%253B%250Al(42)%253B).

<a name="tag-function-use-cases"></a>
## When do I need to use the `@function` tag?

This would be necessary when a function gets assigned to a variable for example. 

> This marks an object as being a function, even though it may not appear to be one to the parser. It sets the doclet's @kind to 'function'.

See [JSDoc @function tag documentation][jsdoc-function].

If we dump the doclets of index.js with: `jsdoc -X index.js`

```javascript
// index.js

/** @param {?} y */
function a(y) {}

/** @param {?} y */
const b = a;

/**
 * @function
 * @param {?} y
 */
const c = a;
```

Doclet for  `a`:

```javascript
{
  // ...
  "name": "a",
  "longname": "a",
  "kind": "function",
  "scope": "global"
}
```

Doclet for `b`:

```javascript
{
  // ...
  "name": "b",
  "longname": "b",
  "kind": "constant",
  "scope": "global"
}
```

Doclet for `c`:

```javascript
{
  // ...
  "name": "b",
  "longname": "b",
  "kind": "function",
  "scope": "global"
}
```

We can see that `b` doesn't appear as a function to the JSDoc parser. This isn't the case for `c` as we explicitly marked it as such with the `@function` tag.

[jsdoc-home]: https://jsdoc.app/
[jsdoc-function]: https://jsdoc.app/tags-function.html
[gcc-home]: https://developers.google.com/closure/compiler
[gcc-types]: https://github.com/google/closure-compiler/wiki/Types-in-the-Closure-Type-System
