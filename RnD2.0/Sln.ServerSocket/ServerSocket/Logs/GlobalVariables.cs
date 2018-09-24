using System.IO;

namespace ServerSocket.Logs
{
    public static class GlobalVariables
    {
        public static string strFilesLocs = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
    }
}
