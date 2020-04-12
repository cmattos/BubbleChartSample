/* ======= Reset Database ========== */
drop view if exists ListTechnologyQuadrant
drop table if exists TechnologyQuadrantDetail
drop table if exists Technology
drop table if exists TechnologyGroup
drop table if exists TechnologyQuadrant

/* ======= Table TechnologyGroup ========== */
create table TechnologyGroup(
	GroupID int not null identity(1,1),
	GroupName nvarchar(60) not null,
	GroupDescription nvarchar(4000) not null
)
go

create unique index PK_TechnologyGroup_GroupID on TechnologyGroup(GroupID);
go

create unique index UK_TechnologyGroup_GroupName on TechnologyGroup(GroupName);
go

alter table TechnologyGroup
	add primary key(GroupID);
go

insert into TechnologyGroup(GroupName, GroupDescription) values('Techniques','These include elements of a software development process, such as experience design; and ways of structuring software, such as microservices.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Automation','Robotic and Intelligent Process Automation (RPA, IPA), Bots, Virtual Assistants, User & Operational Analytics, KPIs.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Cloud Engineering','Cloud Assessment & Preparation, Migration & Optimisation, DevOps, CloudOps, Cloud Native Development, Mainframe Optimization.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Data Engineering','Data Engineering & Reengineering, Data Governance & Quality, Data Lineage & Insights, Data Lakes.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Languages & Frameworks','Languages, Frameworks, Libraries, other development components.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Tools','These can be components, such as databases, software development tools, such as versions control systems; or more generic categories of tools, such as the notion of polyglot persistence.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Customer Centricity','Frontend Modern Architectures, Design Thinking, Digital Product Design, Customer Life Journeys, Business Service Design, User Experience, Customer Experience.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Collaboration','Open APIs, Internal APIs, Business as Platform, Modular Architectures, Ecosystems, Low-code.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Game Changers','Artificial Intelligence (AI), Machine Learning (ML), Natural Language Processing (NLP), Distributed Ledger Technologies (DLT), Augmented, Virtual and Mixed Reality (AR, VR), Connected Services.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Platform Engineering','Agile & DevOps Transformation, Core Platform Optimisation & Management, ')
insert into TechnologyGroup(GroupName, GroupDescription) values('Regularoty, Risk & Compliance Services','Compliance & Risk Control, Regulatory Automation, Business Continuity.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Quality Assurance','QA, Test Automation, Test Engineering, Test Framework, Testing Tools, etc.')
insert into TechnologyGroup(GroupName, GroupDescription) values('Digital & Mobility','Digital Technologies, Mobile (Native & Hybrid), related technologies.')

go

--select * from TechnologyGroup

/* ======= Table Technology ========== */
create table Technology(
	TechnologyID int not null identity(1,1),
	TechnologyName nvarchar(60) not null, 
	TechnologyGroupID int not null
)
go

create unique index PK_Technology_TechnologyID on Technology(TechnologyID);
go

create unique index UK_Technology_TechnologyName on Technology(TechnologyName);
go

create index FK_Technology_TechnologyGroupID on Technology(TechnologyGroupID);
go


alter table Technology
	add primary key(TechnologyID);
go

alter table Technology
	add foreign key(TechnologyGroupID)
		references TechnologyGroup
go
insert into Technology(TechnologyName, TechnologyGroupID) values('Microservices',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Container Security Scanning',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Micro Frontends',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Pipelines for IaC',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Automate Machine Learning (AutoML)',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Security Police as Code',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('Run Cost as Architecture Fitness Function',1)
insert into Technology(TechnologyName, TechnologyGroupID) values('PowerAutomate',2)
insert into Technology(TechnologyName, TechnologyGroupID) values('Automate Anywhere',2)
insert into Technology(TechnologyName, TechnologyGroupID) values('Automate',2)
insert into Technology(TechnologyName, TechnologyGroupID) values('UIPath',2)
insert into Technology(TechnologyName, TechnologyGroupID) values('BluePrism',2)
insert into Technology(TechnologyName, TechnologyGroupID) values('AWS',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('Azure',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('GCP',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('ICP',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('AzureDevOps',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('OpenShift',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('AWS Development Kit',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('GCP Pub/Sub',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('Apache Flink',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('SnowFlake',3)
insert into Technology(TechnologyName, TechnologyGroupID) values('Hadoop',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Hive',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Spark',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Kafka',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('HDInsight',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Redis',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Cassandra',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('MongoDB',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('CosmosDB',4)
insert into Technology(TechnologyName, TechnologyGroupID) values('Java',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('.NET',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('Cobol',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('Python',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('Spring',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('SpringBoot',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('Swagger',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('NodeJS',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('Angular',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('React',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('React Testing Library',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('TensorFlow',5)
insert into Technology(TechnologyName, TechnologyGroupID) values('SQL Server',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('Oracle',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('MySQL',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('GitHub',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('GitLab',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('KuberFlow',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('Docker',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('Kubernetes',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('Docker Notary',6)
insert into Technology(TechnologyName, TechnologyGroupID) values('Design Thinking',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('Product Design',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('Life Journey',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('UX',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('CX',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('Lean Inception',7)
insert into Technology(TechnologyName, TechnologyGroupID) values('Azure API Management',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Mulesoft',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('IBM API Management',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Axway',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Oracle API',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Akana',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Kong',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Salesforce',8)
insert into Technology(TechnologyName, TechnologyGroupID) values('Artificial Intelligence (AI)',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Machine Learning (ML)',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Natural Language Processing (NLP)',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Distributed Ledger Technologies (DLT)',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Augmented Reality',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Virtual Reality',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Mixed Reality',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Connected Services',9)
insert into Technology(TechnologyName, TechnologyGroupID) values('Agile Transformation',10)
insert into Technology(TechnologyName, TechnologyGroupID) values('DevSecOps',10)
insert into Technology(TechnologyName, TechnologyGroupID) values('DataOps',10)
insert into Technology(TechnologyName, TechnologyGroupID) values('Core Platform Optimisation',10)
insert into Technology(TechnologyName, TechnologyGroupID) values('Core Platform Management',10)
insert into Technology(TechnologyName, TechnologyGroupID) values('GDPR',11)
insert into Technology(TechnologyName, TechnologyGroupID) values('LGPD',11)
insert into Technology(TechnologyName, TechnologyGroupID) values('Regulatory Automation',11)
insert into Technology(TechnologyName, TechnologyGroupID) values('Business Continuity',11)
insert into Technology(TechnologyName, TechnologyGroupID) values('QA',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('Test Automation',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('Test Engineering',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('Test Framework',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('TDM',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('Other Testing Tools',12)
insert into Technology(TechnologyName, TechnologyGroupID) values('Ionic',13)
insert into Technology(TechnologyName, TechnologyGroupID) values('Android',13)
insert into Technology(TechnologyName, TechnologyGroupID) values('Xamarin',13)
insert into Technology(TechnologyName, TechnologyGroupID) values('ReactNative',13)
insert into Technology(TechnologyName, TechnologyGroupID) values('Flutter',13)
insert into Technology(TechnologyName, TechnologyGroupID) values('NativeScript',13)
go

/* ======= Table Technology Quadrant ========== */
create table TechnologyQuadrant(
	QuadrantID int not null identity(1,1),
	QuadrantName nvarchar(60) not null, 
	QuadrantDate smalldatetime not null default getdate()
)
go

create unique index PK_TechnologyQuadrant_QuadrantID on TechnologyQuadrant(QuadrantID);
go

create unique index UK_TechnologyQuadrant_QuadrantName on TechnologyQuadrant(QuadrantName);
go

alter table TechnologyQuadrant
	add primary key(QuadrantID);
go

insert into TechnologyQuadrant(QuadrantName) values('Technology Quadrant H1 2019')
insert into TechnologyQuadrant(QuadrantName) values('Technology Quadrant Q1 2020')
go

/* ======= Table Technology Quadrant Detail ========== */
create table TechnologyQuadrantDetail(
	QuadrantDetailID int not null identity(1,1),
	QuadrantID int not null,
	TechnologyID int not null, 
	Seniority decimal(9,2) not null default 0,
	Capacity decimal(9,2) not null default 0,
	BubbleSize decimal(9,2) not null default 0.1
)
go

create unique index PK_TechnologyQuadrantDetail_QuadrantDetailID on TechnologyQuadrantDetail(QuadrantDetailID);
go

create index IX_TechnologyQuadrantDetail_QuadrantID on TechnologyQuadrantDetail(QuadrantID);
go

create index IX_TechnologyQuadrantDetail_QuadrantTechnologyID on TechnologyQuadrantDetail(TechnologyID);
go

alter table TechnologyQuadrantDetail
	add primary key(QuadrantDetailID);
go

alter table TechnologyQuadrantDetail
	add foreign key(QuadrantID)
		references TechnologyQuadrant
go

alter table TechnologyQuadrantDetail
	add foreign key(TechnologyID)
		references Technology
go

insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,1,8,1.8,0.4)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,2,7,2.8,0.4)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,3,4.5,4.8,0.4)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,4,6.8,2,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,5,7.5,2.8,0.6)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,6,8,4.5,0.6)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,7,5.9,0.3,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,8,8.6,1,0.3)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,9,3,0.6,0.15)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,10,2.5,0.6,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,11,1.5,0.3,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,12,3.2,1,0.4)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,13,3.6,3.5,0.6)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,14,8.2,5.2,0.65)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,15,7.9,8.5,1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,16,2.2,2.9,0.5)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,17,7.3,8.2,0.7)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,18,4.2,2.5,0.6)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,19,5.2,5.3,0.5)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,20,5.2,3.9,0.5)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,21,4.8,3,0.5)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,22,0.6,1.5,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,23,0.2,0.4,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,24,0.8,0.6,0.1)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(1,25,7.6,5,0.8)
go


insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,8,6.67,0.06,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,9,6.67,0.04,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,10,5,0.03,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,11,7.5,0.1,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,12,7.5,0.05,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,13,5.9,0.33,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,14,5.21,1.09,0.11)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,15,5.26,0.33,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,16,4.62,0.33,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,17,6.06,0.14,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,18,6.06,0.41,0.04)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,22,4.44,0.08,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,59,5.71,0.18,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,60,4.55,0.14,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,61,4.44,0.11,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,62,4,0.13,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,65,4.44,0.04,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,66,4.71,0.36,0.04)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,53,6,0.06,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,56,6.67,0.14,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,58,6.67,0.13,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,23,6,0.25,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,24,5,0.08,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,25,4.44,0.08,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,26,4.44,0.04,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,28,7.5,0.05,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,29,5.24,0.09,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,30,4.55,0.55,0.06)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,31,5.24,0.09,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,90,6.09,0.29,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,91,6.35,0.26,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,92,5.83,0.05,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,93,4.33,0.13,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,94,4.44,0.04,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,67,5,0.1,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,68,5,0.08,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,69,6.36,0.14,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,70,8.33,0.03,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,32,7.17,6.38,0.64)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,33,7.3,6.73,0.67)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,34,8.33,0.85,0.09)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,35,5.04,0.56,0.06)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,36,6.76,2.64,0.26)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,37,6.44,0.56,0.06)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,38,6.89,0.19,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,39,5.31,0.74,0.07)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,40,6.56,2.64,0.26)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,41,5.86,0.41,0.04)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,43,3.33,0.01,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,75,7.35,0.68,0.07)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,76,6.27,0.21,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,84,8.06,4.01,0.4)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,85,6.49,0.24,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,86,6.94,0.15,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,87,5.83,0.1,0.01)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,88,10,0.01,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,80,0,0,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,81,0,0,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,82,0,0,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,83,0,0,0)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,1,5.51,0.29,0.03)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,44,7.24,1.23,0.12)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,45,7.11,2.94,0.29)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,46,6.81,1.13,0.11)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,47,6.94,1.7,0.17)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,50,5.37,0.23,0.02)
insert into TechnologyQuadrantDetail(QuadrantID, TechnologyID, Seniority, Capacity, BubbleSize) values(2,51,6,0.06,0.01)
go

/* ======= View List Technology Quadrant  ========== */
create view ListTechnologyQuadrant as
	select	QuadrantName, 
			QuadrantDate, 
			GroupName,
			TechnologyName, 
			Seniority, 
			Capacity, 
			BubbleSize
from TechnologyQuadrantDetail d
inner join TechnologyQuadrant q on d.QuadrantID = q.QuadrantID
inner join Technology t on d.TechnologyID = t.TechnologyID
inner join TechnologyGroup g on t.TechnologyGroupID = g.GroupID
where q.QuadrantID = 2
go

--select * from ListTechnologyQuadrant where QuadrantName = 'Technology Quadrant Q1 2020'
--select * from ListTechnologyQuadrant where QuadrantName = 'Technology Quadrant H1 2019'
--select GroupName, TechnologyID, TechnologyName from Technology t inner join TechnologyGroup g on g.GroupID = t.TechnologyGroupID order by GroupName