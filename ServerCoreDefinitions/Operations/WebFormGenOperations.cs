/*
* Server Core User Operations
*/

namespace EasyITCenter.ServerCoreStructure {

    public class WebFormGenOperations {


        private static string GetOrCreateFilePath(string fileName, string contentRootPath, string userName, string filesDirectory = "uploadFiles") {
            var directoryPath = Path.Combine(SrvRuntime.UserPath, userName, filesDirectory);
            FileOperations.CreateDirectory(directoryPath);
            return Path.Combine(directoryPath, fileName);
        }


        public static async Task SaveFileWithName(IFormFile file, string fileSaveName, string contentRootPath, string userName = "guest") {
            var filePath = GetOrCreateFilePath(fileSaveName, userName, contentRootPath);
            await using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
        }

        //TODO CHAnge to generator or template OR DB or VARIABLE By Class/JSON/TABLE/DEFINEDTYPE/
        public static string GenerateHtmlPage() {
            string variable = "test";
            return $"<html><body><form action='/upload' method='POST' enctype='multipart/form-data'>" 
            + $"<input name='{variable}' type='hidden' value='{variable}' required/>" 
            + $"<br/><input name='Name' type=''text' placeholder='Name of file' pattern='(jpg|jpeg|png)' required/>"
            + $"<br/><input name='Description' type='text' placeholder='Description of file' required/>"
            + $"<br/><input type='file' name='FileDocument' placeholder='Upload an image...' accept='.jpg, .jpeg, .png' />"
            + $"<input type='submit' /></form></body></html>";
        }
    }
}