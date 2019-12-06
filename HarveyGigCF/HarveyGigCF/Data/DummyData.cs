using HarveyGigCF.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarveyGigCF.Data
{
    public class DummyData
    {
        public static List<App> getApps()
        {
            List<App> apps = new List<App>() {
                new App(){
                    AppName="Metro Hospital"
                },
                new App(){
                    AppName="Capital Risk"
                },
                new App(){
                    AppName="Disney"
                },
                new App(){
                    AppName="ET"
                }
            };
            return apps;
        }

        public static List<Job> getJobs(JobsContext context)
        {
            List<Job> jobs = new List<Job>() {
                new Job(){
                    Day = "Monday",
                    Time = TimeSpan.FromHours(8.5),
                    Success = "Success",
                    Files_DwUp = 60,
                    Files_Sorted = 60,
                    AppId = context.Apps.Find(2).AppId
                },
                 new Job(){
                    Day = "Friday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    Files_DwUp = 20,
                    Files_Sorted = 20,
                    AppId = context.Apps.Find(1).AppId
                },
                  new Job(){
                    Day = "Monday",
                    Time = TimeSpan.FromHours(5),
                    Success = "Failed",
                    Files_DwUp = 0,
                    Files_Sorted = 0,
                    AppId = context.Apps.Find(2).AppId
                },
                   new Job(){
                    Day = "Wednesday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    Files_DwUp = 750,
                    Files_Sorted = 750,
                    AppId = context.Apps.Find(3).AppId
                }
            };

            return jobs;
        }


    }
}