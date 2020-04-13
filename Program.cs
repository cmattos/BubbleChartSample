using System;
using System.Windows.Forms;
using BubbleChartSample.App;

namespace BubbleChartSample
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EncryptConnectionStrings();
            Application.Run(new ChartSampleApp());
        }

        private static void EncryptConnectionStrings()
        {
            string execonfigName = "BubbleChartSample.exe";
            string sectionName = "connectionStrings";
            Config.Tools.ToggleSectionEncryption(execonfigName, sectionName);
        }
    }

}
