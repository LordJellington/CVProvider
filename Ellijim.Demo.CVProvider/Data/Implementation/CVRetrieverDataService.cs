using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellijim.Demo.CVProvider.Data.Implementation
{
    public class CVRetrieverDataService : ICVRetrieverDataService
    {
        private readonly IEnumerable<Dictionary<string, object>> _cvs;

        public CVRetrieverDataService()
        {
            var employmentHistory = new List<Dictionary<string, object>>() {
                new Dictionary<string, object>()
                {
                    { "jobTitle", "Senior Developer" },
                    { "employer", "Riskonnect" },
                    { "startDate", new DateTime(2021, 7, 1) },
                    { "endDate", new DateTime(2024, 11, 30) },
                    { "description", new StringBuilder()
                        .Append("<p>At Riskonnect I work as part of an Agile team to develop new features and bug fixes for the Active Risk Manager product using C#, Angular, SQL Server, and Power BI.</p>")
                        .Append("<p>My main accomplishments at Riskonnect include:</p>")
                        .Append("<ul><li>Delivering a Dashboard tool for risk data</li>")
                        .Append("<li>Developing the trending data warehouse and the processes to populate it regularly with data</li>")
                        .Append("<li>Developing the trending reports as well as the SQL Server objects that support them</li></ul>")
                        .Append("<p>All work items are managed using Azure DevOps with all source control managed using Azure DevOps Git Repositories.</p>")
                        .ToString()
                    }
                },
                new Dictionary<string, object>()
                {
                    { "jobTitle", "Senior Consultant" },
                    { "employer", "Pythagoras" },
                    { "startDate", new DateTime(2013, 10, 1) },
                    { "endDate", new DateTime(2021, 6, 30) },
                    { "description", new StringBuilder()
                        .Append("<p>My accomplishments at Pythagoras include:</p>")
                        .Append("<ul><li>Developing SharePoint widgets using the SPFx framework featuring React and TypeScript</li>")
                        .Append("<li>Creating processes to transform and migrate data to Dynamics 365 using T-SQL and SQL Server Integration Services</li>")
                        .Append("<li>Writing extensions for a security compliance system using C# and T-SQL</li>")
                        .Append("<li>Developing a custom web application using React and TypeScript</li>")
                        .Append("<li>Creating a custom notification process using Power Automate</li>")
                        .Append("<li>Writing reports for clients using Power BI and SQL Server Reporting Services</li>")
                        .Append("<li>Training clients in SharePoint Online and Power BI</li>")
                        .Append("<li>Training colleagues in Power BI</li>")
                        .Append("<li>Writing and proofreading client-facing documentation</li></ul>")
                        .ToString()
                    }
                },
                new Dictionary<string, object>()
                {
                    { "jobTitle", "Consultant" },
                    { "employer", "Creative SharePoint" },
                    { "startDate", new DateTime(2010, 4, 1) },
                    { "endDate", new DateTime(2013, 9, 30) },
                    { "description", new StringBuilder()
                        .Append("<p>My accomplishments at Creative SharePoint include:</p>")
                        .Append("<ul><li>Developing SharePoint widgets using HTML, CSS, and JavaScript</li>")
                        .Append("<li>Working on the database for a custom application using T-SQL</li>")
                        .Append("<li>Training Clients in SharePoint 2007, 2010, and 2013</li>")
                        .Append("<li>Writing and proofreading client-facing documentation</li></ul>")
                        .ToString()
                    }
                },
            };
            
            var skills = new string[] { "C#", "Angular", "React", "TypeScript",
                "JavaScript", "CSS", "SQL Server", "Power BI", "SharePoint Online" };

            var educationalQualifications = new List<Dictionary<string, object>>()
            {
                new Dictionary<string, object>()
                {
                    { "establishment", "City University London" },
                    { "courseName", "Artificial Intelligence" },
                    { "qualification", "MSc with Distinction" },
                    { "startDate", new DateTime(2006, 9, 1) },
                    { "endDate", new DateTime(2007, 10, 31) }
                },
                new Dictionary<string, object>()
                {
                    { "establishment", "Robert Gordon University" },
                    { "courseName", "Computer Science" },
                    { "qualification", "BSc (Hons) 1st Class" },
                    { "startDate", new DateTime(2000, 9, 1) },
                    { "endDate", new DateTime(2005, 8, 31) }
                }
            };

            _cvs = new List<Dictionary<string, object>>() {
                new Dictionary<string, object>()
                {
                    { "name", "James Ellins" },
                    { "dob", new DateTime(1982, 4, 2) },
                    { "skills", skills },
                    { "employmentHistory", employmentHistory.ToArray() },
                    { "educationalQualifications", educationalQualifications.ToArray() }
                }
            };
        }

        public Dictionary<string, object> GetCV(string name)
        {
            return _cvs.FirstOrDefault(cv => (string)cv["name"] == name);
        }
    }
}
