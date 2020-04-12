using System.IO;
using System.Configuration;

namespace BubbleChartSample.Config
{
    public static class Tools
    {
        public static void ToggleSectionEncryption(string appConfigName, string sectionName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(appConfigName);

            ConnectionStringsSection section =
                config.GetSection(sectionName) as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            else
            {
                section.SectionInformation.UnprotectSection();
            }

            config.Save();
        }

        public static string GetConnectionStringByName(string cnStringName)
        {
            string returnValue = null;

            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[cnStringName];

            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }

            return returnValue;
        }

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
