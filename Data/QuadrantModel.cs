namespace BubbleChartSample.Data
{
    public class QuadrantModel
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public string TechnologyName { get; set; } = string.Empty;
        public double Seniority { get; set; }
        public double Capacity { get; set; }
        public double BubbleSize { get; set; }
    }
}
