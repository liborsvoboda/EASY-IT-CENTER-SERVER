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

````    
  Cookies.set('ApiToken', data.Token);   
  Cookies.remove('ApiToken');    
  
````    

