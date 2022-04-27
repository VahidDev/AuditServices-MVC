using Microsoft.AspNetCore.Http;

namespace AuditServices.Utilities.FileUtilities
{
    public static class FileSizeChecker
    {
        public static bool CheckSizeForMg(this IFormFile file)
        {
            if (file.Length >= 3 * 1000_000) return false;
            return true;
        }
    }
}
