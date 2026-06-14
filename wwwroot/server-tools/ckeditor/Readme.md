CKEditor 5 classic editor build v11.2.0
=======================================

- Only include Script and Style for Dynamic Editor Tool
- All Languages are supported

````
<script type="text/javascript" src="/server-tools/ckeditor/ckeditor.js"></script>
````

Init Editor to HTML  Element
````
ClassicEditor
		.create( document.querySelector( '#editor' ), {
			// toolbar: [ 'heading', '|', 'bold', 'italic', 'link' ]
		} )
		.then( editor => {
			window.editor = editor;
		} )
		.catch( err => {
			console.error( err.stack );
		} );
````



- Inpout Data To Editor Function
````

````

- OutPut Data From Editor
````

````




In order to start using CKEditor 5 Builds, configure or customize them, please visit http://docs.ckeditor.com/ckeditor5/latest/builds/index.html

## License

Licensed under the terms of [GNU General Public License Version 2 or later](http://www.gnu.org/licenses/gpl.html).
For full details about the license, please check the LICENSE.md file.
