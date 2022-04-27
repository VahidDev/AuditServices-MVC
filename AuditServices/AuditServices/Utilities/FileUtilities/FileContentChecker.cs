using Microsoft.AspNetCore.Http;

namespace AuditServices.Utilities.FileUtilities
{
    public static class FileContentChecker
    {
        public static bool IsImg(this IFormFile file)
        {
            if (!file.ContentType.Contains("image")) return false;
            return true;
        }
    }
}
