using System.IO;

namespace ExtensionWrapper.Interface
{
    public interface IDirectoryWrapper{
        void CreateDirectory(string path);
        void Delete(string path);
        void Delete(string path, bool recursive);
        string[] GetDirectories(string path);
        string[] GetDirectories(string path, string searchPattern);
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
        void CheckDirectoryExists(string path);
    }
}