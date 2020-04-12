using BubbleChartSample.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleChartSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EncryptConnectionStrings();
            Application.Run(new ChartSampleApp());
            
        }

        static void EncryptConnectionStrings()
        {
            string execonfigName = "BubbleChartSample.exe";
            string sectionName = "connectionStrings";
            Config.Tools.ToggleSectionEncryption(execonfigName, sectionName);
        }
    }

}
