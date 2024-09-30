

//window onload
window.onload = function(e) {
	console.log("window loaded");
};



//const fs=require('fs');
var files = [];
function getFiles (dir, files_){
    files_ = files_ || [];
    var files = fs.readdirSync(dir+"/img");
    for (var i in files){
        var name = dir + '/img' + files[i];
        if (fs.statSync(name).isDirectory()){
            getFiles(name, files_);
        } else {
            files_.push(name);
        }
    }
    return files_;
}


function readFile(file) {
  const reader = new FileReader();
  reader.addEventListener('load', (event) => {
    const result = event.target.result;
    reader.readAsDataURL(file);
  });
}

//automatic load files
let sources = [];
for (var i = 104; i >= -1; i--) {sources.push({title: i, href: './images/'+i+'.png', thumbnail: './images/'+i+'.png'});};


