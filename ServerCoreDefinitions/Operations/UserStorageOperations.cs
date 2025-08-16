/*
* Server Core Web Helpers
* System Extensions for Correct Core working
* DataTypes Conversion Support, etc.
*/

namespace EasyITCenter.ServerCoreStructure {

    /// <summary>
    /// User Storage Operations
    /// </summary>
    public static class UserStorage {


        /// <summary>
        /// Create User Storage Directory on Authenticated User Login
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool CreateUserStorage(string username) {
            if (!FileOperations.CheckDirectory(Path.Combine(SrvRuntime.UserPath, username))){
                return FileOperations.CreatePath(Path.Combine(SrvRuntime.UserPath, username));
            }
            return true;
        }
        
    }
}