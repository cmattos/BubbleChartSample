using System.Configuration;
using System.IO;

namespace BubbleChartSample.Config
{
    public static class Tools
    {
        public static string GetApplicationPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }

        public static void CheckIfApplicationFolderExists(string pathFolder)
        {
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }
        }

        public static string GetExcelFolder()
        {
            string excelFolder = Tools.GetApplicationPath() + ConfigurationManager.AppSettings["ExcelFilesFolder"].ToString();
            CheckIfApplicationFolderExists(excelFolder);
            return excelFolder;
        }

        public static string GetImagesFolder()
        {
            string imagesFolder = Tools.GetApplicationPath() + ConfigurationManager.AppSettings["ChartImagesFolder"].ToString();
            CheckIfApplicationFolderExists(imagesFolder);
            return imagesFolder;
        }
    }
}