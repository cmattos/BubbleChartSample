using System.Data;
using System.Data.SqlClient;
using BubbleChartSample.Config;
using System.Collections.Generic;
using System.Linq;

namespace BubbleChartSample.Data
{
    public class TechnologyCapacity
    {
        public List<QuadrantModel> GetSQLData()
        {
            SqlConnection cnQuadrantDB = new SqlConnection();
            SqlCommand cmdQuadrantModel = new SqlCommand();
            SqlDataReader drQuadrantModel;

            cnQuadrantDB.ConnectionString = Tools.GetConnectionStringByName("QuadrantDB");

            cmdQuadrantModel.Connection = cnQuadrantDB;
            cmdQuadrantModel.CommandType = System.Data.CommandType.Text;
            cmdQuadrantModel.CommandText = "select GroupName, TechnologyName, Seniority, Capacity, BubbleSize from ListTechnologyQuadrant";

            cnQuadrantDB.Open();

            drQuadrantModel = cmdQuadrantModel.ExecuteReader(CommandBehavior.CloseConnection);

            List<QuadrantModel> listQuadrantData = new List<QuadrantModel>();

            while (drQuadrantModel.Read())
            {
                listQuadrantData.Add(new QuadrantModel
                {
                   GroupID = 1,  GroupName = drQuadrantModel["GroupName"].ToString(),
                    TechnologyName = drQuadrantModel["TechnologyName"].ToString(),
                    Seniority = double.Parse(drQuadrantModel["Seniority"].ToString().Replace(".", ",")),
                    Capacity = double.Parse(drQuadrantModel["Capacity"].ToString().Replace(".", ",")),
                    BubbleSize = double.Parse(drQuadrantModel["BubbleSize"].ToString().Replace(".", ","))
                });
            }
            return listQuadrantData;
        }

        public List<QuadrantModel> GetInMemoryData(int TechnologyGroupId)
        {

            List<QuadrantModel> listQuadrantData = new List<QuadrantModel>();

            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Microservices", Seniority = 8.00, Capacity = 1.80, BubbleSize = 0.40 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Container Security Scanning", Seniority = 7.00, Capacity = 2.80, BubbleSize = 0.40 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Micro Frontends", Seniority = 4.50, Capacity = 4.80, BubbleSize = 0.40 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Pipelines for IaC", Seniority = 6.80, Capacity = 2.00, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Automate Machine Learning (AutoML)", Seniority = 7.50, Capacity = 2.80, BubbleSize = 0.60 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Security Police as Code", Seniority = 8.00, Capacity = 4.50, BubbleSize = 0.60 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 1, GroupName = "Techniques", TechnologyName = "Run Cost as Architecture Fitness Function", Seniority = 5.90, Capacity = 0.30, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "PowerAutomate", Seniority = 8.60, Capacity = 1.00, BubbleSize = 0.30 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "Automate Anywhere", Seniority = 3.00, Capacity = 0.60, BubbleSize = 0.15 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "Automate", Seniority = 2.50, Capacity = 0.60, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "UIPath", Seniority = 1.50, Capacity = 0.30, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 2, GroupName = "Automation", TechnologyName = "BluePrism", Seniority = 3.20, Capacity = 1.00, BubbleSize = 0.40 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AWS", Seniority = 3.60, Capacity = 3.50, BubbleSize = 0.60 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "Azure", Seniority = 8.20, Capacity = 5.20, BubbleSize = 0.65 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "GCP", Seniority = 7.90, Capacity = 8.50, BubbleSize = 1.00 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "ICP", Seniority = 2.20, Capacity = 2.90, BubbleSize = 0.50 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AzureDevOps", Seniority = 7.30, Capacity = 8.20, BubbleSize = 0.70 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "OpenShift", Seniority = 4.20, Capacity = 2.50, BubbleSize = 0.60 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "AWS Development Kit", Seniority = 5.20, Capacity = 5.30, BubbleSize = 0.50 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "GCP Pub/Sub", Seniority = 5.20, Capacity = 3.90, BubbleSize = 0.50 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "Apache Flink", Seniority = 4.80, Capacity = 3.00, BubbleSize = 0.50 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 3, GroupName = "Cloud Engineering", TechnologyName = "SnowFlake", Seniority = 0.60, Capacity = 1.50, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Hadoop", Seniority = 0.20, Capacity = 0.40, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Hive", Seniority = 0.80, Capacity = 0.60, BubbleSize = 0.10 });
            listQuadrantData.Add(new QuadrantModel { GroupID = 4, GroupName = "Data Engineering", TechnologyName = "Spark", Seniority = 7.60, Capacity = 5.00, BubbleSize = 0.80 });

            List<QuadrantModel> selectedTechnologies = listQuadrantData;

            if (TechnologyGroupId > 0)
            {
                selectedTechnologies = listQuadrantData.Where(x => x.GroupID.Equals(TechnologyGroupId)).ToList();
            }

            return selectedTechnologies;
        }

    }
}
