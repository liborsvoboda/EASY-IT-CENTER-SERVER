# Server PORTAL
>**Server Portal is Created AS COMPANY CLOUD SYSTEM**   

- Its Developer Centrum for C#, HTML, JS, CSS, Electron, WPF, 
- Managing User Storage
- Managing Public Storage
- Managing Helps
- Fully Dynamic Creation via Online Builder
- Managing Media Documents


- Each Tool can Open "Readme.md" in Path with "index.html" over ToolList




### Code Help

# Handlebar.js Code Generator   
   
````   
var source = "<p>Hello, my name is {{name}}. I am from {{hometown}}. I have " +   
             "{{kids.length}} kids:</p>" +   
             "<ul>{{#kids}}<li>{{name}} is {{age}}</li>{{/kids}}</ul>";   
var template = Handlebars.compile(source);   

var data = { "name": "Alan", "hometown": "Somewhere, TX",   
             "kids": [{"name": "Jimmy", "age": "12"}, {"name": "Sally", "age": "4"}]};   
var result = template(data);   

````   

**Output**   
````   
<p>Hello, my name is Alan. I am from Somewhere, TX. I have 2 kids:</p>   
  <ul>   
   <li>Jimmy is 12</li>   
   <li>Sally is 4</li>   
 </ul>   
 
````   

# Cookie Use for ApiToken    
https://github.com/js-cookie/js-cookie     
````    
  Cookies.set('ApiToken', data.Token);   
  Cookies.remove('ApiToken');    
  Cookies.get('ApiToken');  

````    



# ClipBoard      
https://clipboardjs.com/     

var clipboard = new ClipboardJS('.btn');

clipboard.on('success', function(e) {
    console.info('Action:', e.action);
    console.info('Text:', e.text);
    console.info('Trigger:', e.trigger);

    e.clearSelection();
});

clipboard.on('error', function(e) {
    console.error('Action:', e.action);
    console.error('Trigger:', e.trigger);
});



# Console subscriber
 
A drop-in tool to subscribe to the console output. Useful for debugging JS scripts on a device where the console is not easily accessible like mobile device browsers, or even in Node environments.
 
## Installation

### npm

```sh
npm install console-subscriber
``` 

### script
<pre>
<script src="node_modules/console-subscriber/index.js"></script>
</pre>
 
## Usage

<pre>
let cs = require('console-subscriber'); // window.ConsoleSubscriber object is available in browsers

/**
 * Function to be called on console output
 * WARNING: calling console.log inside the callback would lead to an infinite recursion
 *
 * @param string $category info|warn|error|debug
 * @param array $args initial arguments of the call 
 */
let callback = (category, args) => {

    // In a browser env you could write to a DOM element
    let message = category + ": " + JSON.stringify(args) + "\n";
    document.getElementById('console').innerHTML += message; 

    // In a Node env you could store the console output (errors)
    if (category === "error"){
        redisClient.sadd("console:error", JSON.stringify(args));
    }
};

// Bind callback fn. Multiple functions can be bound.
cs.bind(callback); 

// Unbind a previously bound callback
cs.unbind(callback);

// Restore defaults
cs.unbind();    
</pre>


