using BubbleChartSample.App;
using System;
using System.Windows.Forms;

namespace BubbleChartSample
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChartSampleApp());
        }
    }

}
