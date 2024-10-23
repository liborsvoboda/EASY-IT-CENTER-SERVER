﻿
//Global Functions Library


function ChangeSource(url) {
    $("#WebPageHTMLContent").attr("src",url);
    ScrollToTop();
}



function str2bytes(str) {
    var bytes = new Uint8Array(str.length);
    for (var i = 0; i < str.length; i++) {
        bytes[i] = str.charCodeAt(i);
    }
    return bytes;
}