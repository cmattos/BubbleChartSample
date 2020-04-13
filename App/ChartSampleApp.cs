using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BubbleChartSample.Config;
using BubbleChartSample.Interop;
using System.Collections.Generic;

namespace BubbleChartSample.App
{
    public partial class ChartSampleApp : Form
    {
        public ChartSampleApp()
        {
            InitializeComponent();
        }

        private void ChartSampleApp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }

        private void RunInteropExcel_Click(object sender, EventArgs e)
        {
            CreateExcelObject(DisplayAlertsCheckBox.Checked, IsVisibleCheckBox.Checked);
        }

        private void CreateExcelObject(bool displayAlerts, bool isVisible)
        {
            Cursor = Cursors.WaitCursor;

            ExcelObject objExcel = new ExcelObject(isVisible,displayAlerts)
            {
                CloseExcelAfterCompleteFlag = CloseAfterCompleteCheckBox.Checked,
                ChartStyleCode = int.Parse(ChartStyleCombo.SelectedValue.ToString()),
                CollorPatternCode = int.Parse(CollorPatternCombo.SelectedValue.ToString()),
                TechnologyGroupId = int.Parse(GroupNameList.SelectedValue.ToString())
            };

            objExcel.GenerateCustomChart(ExcelObject.CustomChartFormat.TechnologyQuadrant);

            DisplayChartPicture();

            Cursor = Cursors.Default;
        }

        private void DisplayChartPicture()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Tools.GetImagesFolder());
            FileInfo chartPicture = GetNewestFile(directoryInfo,"*.png");

            BubbleChartPicture.Image = System.Drawing.Image.FromFile(chartPicture.FullName);
            BubbleChartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            BubbleChartPicture.Refresh();
        }

        private FileInfo GetNewestFile(DirectoryInfo directory, string filePattern)
        {
            return directory.GetFiles(filePattern)
                .Union(directory.GetDirectories().Select(folderInfo => GetNewestFile(folderInfo, filePattern)))
                .OrderByDescending(newestFile => (newestFile == null ? DateTime.MinValue : newestFile.LastWriteTime))
                .FirstOrDefault();
        }

        private void LoadCollorPatternCombo()
        {
            Dictionary<string, int> collorPatterns = new Dictionary<string, int>()
            {
                {"Default",10 },
                {"Light Pink",5 },
                {"Light SteelBlue",15 },
                {"Light Red", 20 },
                {"Light Yellow", 25 },
                {"Dark Blue", 30 },
                {"Light Blue", 35 }
           };

            CollorPatternCombo.DataSource = new BindingSource(collorPatterns, null);
            CollorPatternCombo.DisplayMember = "Key";
            CollorPatternCombo.ValueMember = "Value";
        }

        private void LoadChartStyleCombo()
        {
            Dictionary<string, int> chartStyles = new Dictionary<string, int>()
            {
                {"Default",269},
                {"Style 1",242},
                {"Style 2",246},
                {"Style 3",248},
                {"Style 4",270},
                {"Style 5",271},
                {"Style 6",272},
                {"Style 7",273},
                {"Style 8",274},
                {"Style 9",275},
                {"Style 10",343}
            };

            ChartStyleCombo.DataSource = new BindingSource(chartStyles, null);
            ChartStyleCombo.DisplayMember = "Key";
            ChartStyleCombo.ValueMember = "Value";
        }

        private void LoadGroupNameList()
        {
            Dictionary<string, int> groupNamesList = new Dictionary<string, int>()
            {
                {"All Groups (Default)",0},
                {"Automation",2},
                {"Cloud Engineering",3},
                {"Data Engineering",4},
                {"Techniques",1}
            };

            GroupNameList.DataSource = new BindingSource(groupNamesList, null);
            GroupNameList.DisplayMember = "Key";
            GroupNameList.ValueMember = "Value";
        }

        private void ChartSampleApp_Load(object sender, EventArgs e)
        {
            LoadCollorPatternCombo();
            LoadChartStyleCombo();
            LoadGroupNameList();
        }

    }
}
