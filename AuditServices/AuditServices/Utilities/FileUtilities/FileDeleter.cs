using System.IO;

namespace AuditServices.Utilities.FileUtilities
{
    public static class FileDeleter
    {
        public static void Delete(string folder, string imageName)
        {
            string path = Path.Combine(folder, imageName??"");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
