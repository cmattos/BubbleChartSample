using System;
using System.Linq;
using System.Text;
using BubbleChartSample.Data;
using BubbleChartSample.Config;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Microsoft.Office.Interop.Excel;

namespace BubbleChartSample.Interop
{
    public class ExcelObject
    {
        public int CollorPatternCode { get; set; }
        public int ChartStyleCode { get; set; }
        public int TechnologyGroupId { get; set; }
        public bool CloseExcelAfterCompleteFlag { get; set; }
        private Application AppExcel { get; set; }
        private List<QuadrantModel> QuadrantDataList { get; set; }

        public ExcelObject(bool flagVisible, bool flagDisplayAlerts)
        {
            AppExcel = new Application()
            {
                Visible = flagVisible,
                DisplayAlerts = flagDisplayAlerts
            };

            if (AppExcel.Visible == true) AppExcel.WindowState = XlWindowState.xlMaximized;
        }

        public enum CustomChartFormat
        {
            TechnologyQuadrant,
            TechnologyRadar,
            TechOfficeUtilization
        }

        public void GenerateCustomChart(CustomChartFormat chartFormat)
        {
            switch (chartFormat)
            {
                case CustomChartFormat.TechnologyQuadrant:
                    CreateQuadrantSpreadsheets();
                    LoadQuadrantData();
                    GenerateQuadrantChart();
                    break;
                case CustomChartFormat.TechnologyRadar:
                    CreateTechnologyRadarSpreadsheets(AppExcel);
                    break;
                case CustomChartFormat.TechOfficeUtilization:
                    CreateTechOfficeUtilizationSpreadsheets(AppExcel);
                    break;
                default:
                    break;
            }
        }

        private void LoadQuadrantData()
        {
            TechnologyCapacity techCapacity = new TechnologyCapacity();
            QuadrantDataList = techCapacity.GetInMemoryData(TechnologyGroupId);

            Worksheet reportWorksheet = (Worksheet)AppExcel.Worksheets["Data"];

            int iCurrentRow = 2;

            foreach (QuadrantModel quadrantItem in QuadrantDataList)
            {
                reportWorksheet.Cells[iCurrentRow, "A"] = quadrantItem.GroupName.ToString();
                reportWorksheet.Cells[iCurrentRow, "B"] = quadrantItem.TechnologyName.ToString();
                reportWorksheet.Cells[iCurrentRow, "C"] = double.Parse(quadrantItem.Seniority.ToString().Replace(".", ","));
                reportWorksheet.Cells[iCurrentRow, "D"] = double.Parse(quadrantItem.Capacity.ToString().Replace(".", ","));
                reportWorksheet.Cells[iCurrentRow, "E"] = double.Parse(quadrantItem.BubbleSize.ToString().Replace(".", ","));
                iCurrentRow++;
            }

            int iFirstRow = 2;
            int iLastRow = iCurrentRow--;

            SetReportWorksheetRanges(reportWorksheet, iFirstRow, iLastRow);
        }

        private void SetReportWorksheetRanges(Worksheet reportWorksheet, int iFirstRow, int iLastRow)
        {
            Range titleRow = reportWorksheet.get_Range("A1", "E1");
            Range tableRange = reportWorksheet.get_Range("A1", "E" + iLastRow.ToString());
            Range chartDataRange = reportWorksheet.get_Range("C" + iFirstRow.ToString(), "E" + iLastRow.ToString());
            Range technologyRange = reportWorksheet.get_Range("B" + iFirstRow.ToString(), "B" + iLastRow.ToString());

            reportWorksheet.Names.Add("TitleRange", titleRow);
            reportWorksheet.Names.Add("TableRange", tableRange);
            reportWorksheet.Names.Add("ChartDataRange", chartDataRange);
            reportWorksheet.Names.Add("TechnologyRange", technologyRange);

            FormatReportWorksheet(reportWorksheet, titleRow, tableRange);
        }

        private void FormatReportWorksheet(Worksheet reportWorksheet, Range titleRow, Range tableRange)
        {
            titleRow.Font.Bold = true;

            reportWorksheet.Rows.Font.Size = 9;
            reportWorksheet.Columns.AutoFit();
            reportWorksheet.Rows.AutoFit();

            reportWorksheet.ListObjects.AddEx(XlListObjectSourceType.xlSrcRange, tableRange, Type.Missing, XlYesNoGuess.xlYes, Type.Missing).Name = "SampleTableStyle";
            reportWorksheet.ListObjects.get_Item("SampleTableStyle").TableStyle = "TableStyleMedium16";
        }

        private void CreateTechOfficeUtilizationSpreadsheets(Application appExcel)
        {
            throw new NotImplementedException();
        }

        private void CreateTechnologyRadarSpreadsheets(Application appExcel)
        {
            throw new NotImplementedException();
        }

        private void CreateQuadrantSpreadsheets()
        {
            Workbook reportWorkbook = AppExcel.Workbooks.Add();
            Worksheet reportWorksheet = (Worksheet)reportWorkbook.ActiveSheet;
            Worksheet chartWorksheet = (Worksheet)reportWorkbook.Worksheets.Add();

            reportWorksheet.Cells[1, "A"] = "Group Name";
            reportWorksheet.Cells[1, "B"] = "Technology";
            reportWorksheet.Cells[1, "C"] = "Seniority";
            reportWorksheet.Cells[1, "D"] = "Capacity";
            reportWorksheet.Cells[1, "E"] = "Bubble Size";

            reportWorksheet.Name = "Data";
            chartWorksheet.Name = "Chart";

            RemoveWorksheetsGridLInes();
        }

        private void RemoveWorksheetsGridLInes()
        {
            Worksheet chartWorksheet = (Worksheet)AppExcel.Worksheets["Chart"];
            Worksheet reportWorksheet = (Worksheet)AppExcel.Worksheets["Data"];

            reportWorksheet.Select();
            AppExcel.ActiveWindow.DisplayGridlines = false;

            chartWorksheet.Select();
            AppExcel.ActiveWindow.DisplayGridlines = false;
        }

        private List<string> RangeToList(Range rangeToConvert)
        {
            object[,] cellValues = (object[,])rangeToConvert.Value2;
            List<string> listRangeValues = cellValues.Cast<object>().ToList().ConvertAll(x => Convert.ToString(x));
            return listRangeValues;
        }

        private void GenerateQuadrantChart()
        {
            Worksheet chartWorksheet = (Worksheet)AppExcel.Worksheets["Chart"];
            Worksheet reportWorksheet = (Worksheet)AppExcel.Worksheets["Data"];

            Chart chartPage = InsertBubbleChart(chartWorksheet, reportWorksheet);

            Series series1 = FormatChartSeries(chartPage);

            FormatChartAxis(chartPage);

            SetDataLabelsValuesFromCells(reportWorksheet, series1);

            SetBubbleCollorsByCategory(series1);

            chartPage.ChartStyle = ChartStyleCode;

            CopyChartPictureToClipboard(reportWorksheet, chartPage);

            SaveChartPictureFromClipboard();

            SaveWorkbookAndClose();
        }

        private Series FormatChartSeries(Chart chartPage)
        {
            Series series1 = (Series)chartPage.SeriesCollection(1);
            series1.HasDataLabels = true;

            series1.DataLabels(0).Position = XlDataLabelPosition.xlLabelPositionCenter;
            series1.DataLabels(0).ShowCategoryName = false;
            series1.DataLabels(0).ShowValue = false;
            series1.DataLabels(0).ShowRange = true;
            series1.DataLabels(0).Font.Bold = true;
            return series1;
        }

        private Chart InsertBubbleChart(Worksheet chartWorksheet, Worksheet reportWorksheet)
        {
            ChartObjects xlCharts = (ChartObjects)chartWorksheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(5, 5, 600, 330);

            Chart chartPage = myChart.Chart;

            chartPage.ChartType = XlChartType.xlBubble;
            chartPage.HasLegend = false;

            Range chartRange = reportWorksheet.Range["ChartDataRange"];
            chartPage.SetSourceData(chartRange);
            return chartPage;
        }

        private void FormatChartAxis(Chart chartPage)
        {
            Axis yAxis = (Axis)chartPage.Axes(XlAxisType.xlValue, XlAxisGroup.xlPrimary);
            Axis xAxis = (Axis)chartPage.Axes(XlAxisType.xlCategory, XlAxisGroup.xlPrimary);

            string xAxisTitle = "   →    →    →    S E N I O R I T Y   →    →    →";
            string yAxisTitle = "   →    →    →    C A P A C I T Y   →    →    →";

            xAxis.HasTitle = true;
            xAxis.AxisTitle.Text = xAxisTitle;
            xAxis.MinimumScale = 0;
            xAxis.MaximumScale = 10;

            yAxis.HasTitle = true;
            yAxis.AxisTitle.Text = yAxisTitle;
            yAxis.MinimumScale = 0;
            yAxis.MaximumScale = 10;
        }

        private void SetDataLabelsValuesFromCells(Worksheet reportWorksheet, Series series1)
        {
            int msoChartFieldRange = 7;
            int msoFieldPosition = 0;

            Range technologyRange = reportWorksheet.Range["TechnologyRange"];
            string technologyRangeAbsoluteAddress = "=" + technologyRange.Worksheet.Name + "!" + technologyRange.Address;

            series1.DataLabels(0).Format.TextFrame2.TextRange.InsertChartField(msoChartFieldRange, technologyRangeAbsoluteAddress, msoFieldPosition);
        }

        private void SetBubbleCollorsByCategory(Series series1)
        {
            int iBubbleColor = CollorPatternCode;

            QuadrantModel firstTechnologyGroup = QuadrantDataList.Find(QuadrantDetail => QuadrantDetail.TechnologyName == series1.DataLabels(1).Text.ToString());

            string sGroupName = firstTechnologyGroup.GroupName;

            int iChartDataPoints = QuadrantDataList.Count;

            for (int iDataLabel = 1; iDataLabel <= iChartDataPoints; iDataLabel++)
            {
                QuadrantModel objQuadrantDetail = QuadrantDataList.Find(QuadrantModel => QuadrantModel.TechnologyName == series1.DataLabels(iDataLabel).Text.ToString());

                if (objQuadrantDetail.GroupName != sGroupName)
                {
                    iBubbleColor++;
                    sGroupName = objQuadrantDetail.GroupName;
                }

                if (TechnologyGroupId > 0)
                {
                    iBubbleColor++;
                }

                series1.Points(iDataLabel).Interior.ColorIndex = iBubbleColor;
                series1.Points(iDataLabel).Format.Fill.Transparency = 0.4;
            }
        }

        private void CopyChartPictureToClipboard(Worksheet reportWorksheet, Chart chartPage)
        {
            System.Windows.Forms.Clipboard.Clear();
            chartPage.CopyPicture();
            reportWorksheet.Paste();
            reportWorksheet.Shapes.Item(reportWorksheet.Shapes.Count).Cut();
        }

        private void SaveChartPictureFromClipboard()
        {
            StringBuilder chartImageFilename = new StringBuilder();
            chartImageFilename.Append(Tools.GetImagesFolder());
            chartImageFilename.Append("\\TechnologyQuadrant_");
            chartImageFilename.Append(DateTime.Now.ToString("MMM_ddd_HHmmss").ToUpper());
            chartImageFilename.Append(".png");

            BitmapEncoder bmpEncoder = new BmpBitmapEncoder();

            bmpEncoder.Frames.Add(BitmapFrame.Create(System.Windows.Clipboard.GetImage()));

            using (System.IO.MemoryStream outStream = new System.IO.MemoryStream())
            {
                bmpEncoder.Save(outStream);
                System.Drawing.Image imgGraph = new System.Drawing.Bitmap(outStream);
                imgGraph.Save(chartImageFilename.ToString());
            }
        }

        private void SaveWorkbookAndClose()
        {
            StringBuilder workbookFilename = new StringBuilder();
            workbookFilename.Append(Tools.GetExcelFolder());
            workbookFilename.Append("\\TechnologyQuadrant_");
            workbookFilename.Append(DateTime.Now.ToString("MMM_ddd_HHmmss").ToUpper());
            workbookFilename.Append(".xlsx");

            if (CloseExcelAfterCompleteFlag || !AppExcel.Visible)
            {
                AppExcel.ActiveWorkbook.SaveAs(workbookFilename.ToString());
                AppExcel.ActiveWorkbook.Close();
                AppExcel.Quit();
                AppExcel = null;
            }
        }
    }
}
