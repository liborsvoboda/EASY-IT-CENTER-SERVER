/*
* Server Core Web Helpers
* System Extensions for Correct Core working
* DataTypes Conversion Support, etc.
*/

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// User Storage Operations
    /// </summary>
    public static class UserStorageOperations {


        public static bool CreateUserStorage(string username) {
            return FileOperations.CreatePath(Path.Combine(SrvRuntime.UserPath,username));
        }
        
    }
}