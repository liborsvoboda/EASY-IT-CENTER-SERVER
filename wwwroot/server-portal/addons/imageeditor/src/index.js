const container = document.getElementById("image-editor");
const config = {
    source: localStorage.getItem("SourceImageEditor")
};
const ImageEditor = new window.FilerobotImageEditor(container, config);

window.ImageEditor = ImageEditor;

ImageEditor.render({
  // additional config provided while rendering
  observePluginContainerSize: true,
  onSave: (imageInfo, designState) => {
    const tmpLink = document.createElement("a");
    tmpLink.download = imageInfo.fullName;
    tmpLink.href = imageInfo.imageBase64;
    tmpLink.style = "position: absolute; z-index: -111; visibility: none;";
    document.body.appendChild(tmpLink);
    tmpLink.click();
    document.body.removeChild(tmpLink);
  }
});
