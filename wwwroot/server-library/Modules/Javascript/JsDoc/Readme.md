### JSDOC Generator

- Example of valid Comment 
````
/**
 * A quite wonderful function.
 * @param {object} - Privacy gown
 * @param {object} - Security
 * @returns {survival}
 */
function protection (cloak, dagger) {}
 
````
- Use a JSDoc tag to describe your code
````
/**
 * Represents a book.
 * @constructor
 */
function Book(title, author) {
}
````

- Adding more information with tags
````
/**
 * Represents a book.
 * @constructor
 * @param {string} title - The title of the book.
 * @param {string} author - The author of the book.
 */
function Book(title, author) {
}
````

[Configure](https://jsdoc.app/about-configuring-jsdoc)

```javascript
/** @param {Function} x */
const a = x => x;

/** @param {function()} x */
const b = x => x;
```

````
/**
 * Site Name
 * @type {string}
 */
const siteName = "GeeksForGeeks";
````

````
/**
* AI generated function description.
* @author Crystal Spider
*
* @param {number}     num AI generated parameter description.
* @param {boolean}    bool AI generated parameter description.
* @returns {string} AI generated return description.
*/
function foo(num: number, bool: number): string {
  return `${num}-${bool}`;
}
````

