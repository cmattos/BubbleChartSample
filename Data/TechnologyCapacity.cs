using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BubbleChartSample.Data
{
    public class TechnologyCapacity
    {
        public List<QuadrantModel> GetInMemoryData(int TechnologyGroupId)
        {
            var listQuadrantData = new List<QuadrantModel>
            {
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Microservices", Seniority = 8.00, Capacity = 1.80, BubbleSize = 0.40 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Container Security Scanning", Seniority = 7.00, Capacity = 2.80, BubbleSize = 0.40 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Micro Frontends", Seniority = 4.50, Capacity = 4.80, BubbleSize = 0.40 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Pipelines for IaC", Seniority = 6.80, Capacity = 2.00, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Automate Machine Learning (AutoML)", Seniority = 7.50, Capacity = 2.80, BubbleSize = 0.60 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Security Police as Code", Seniority = 8.00, Capacity = 4.50, BubbleSize = 0.60 },
                new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Run Cost as Architecture Fitness Function", Seniority = 5.90, Capacity = 0.30, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "PowerAutomate", Seniority = 8.60, Capacity = 1.00, BubbleSize = 0.30 },
                new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "Automate Anywhere", Seniority = 3.00, Capacity = 0.60, BubbleSize = 0.15 },
                new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "Automate", Seniority = 2.50, Capacity = 0.60, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "UIPath", Seniority = 1.50, Capacity = 0.30, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "BluePrism", Seniority = 3.20, Capacity = 1.00, BubbleSize = 0.40 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AWS", Seniority = 3.60, Capacity = 3.50, BubbleSize = 0.60 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "Azure", Seniority = 8.20, Capacity = 5.20, BubbleSize = 0.65 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "GCP", Seniority = 7.90, Capacity = 8.50, BubbleSize = 1.00 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "ICP", Seniority = 2.20, Capacity = 2.90, BubbleSize = 0.50 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AzureDevOps", Seniority = 7.30, Capacity = 8.20, BubbleSize = 0.70 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "OpenShift", Seniority = 4.20, Capacity = 2.50, BubbleSize = 0.60 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AWS Development Kit", Seniority = 5.20, Capacity = 5.30, BubbleSize = 0.50 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "GCP Pub/Sub", Seniority = 5.20, Capacity = 3.90, BubbleSize = 0.50 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "Apache Flink", Seniority = 4.80, Capacity = 3.00, BubbleSize = 0.50 },
                new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "SnowFlake", Seniority = 0.60, Capacity = 1.50, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Hadoop", Seniority = 0.20, Capacity = 0.40, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Hive", Seniority = 0.80, Capacity = 0.60, BubbleSize = 0.10 },
                new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Spark", Seniority = 7.60, Capacity = 5.00, BubbleSize = 0.80 }
            };

            if (TechnologyGroupId > 0)
            {
                return listQuadrantData.Where(x => x.GroupID.Equals(TechnologyGroupId)).ToList();
            }

            return listQuadrantData;
        }

    }
}
