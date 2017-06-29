using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Job //could probably convert to ENUM at some point but I hate enums
    {
        private static List<Job> allJobs = new List<Job>();

        public static Job returnJob(String jobToCheck)
        {
            Job[] jobsArr=allJobs.ToArray();
            foreach (Job j in jobsArr)
            {
                if(j.jobName==jobToCheck)
                {
                    return j;
                }
            }
            return null;
        }

        private string jobName{ get; set; }

        public Job(String name)
        {
            jobName = name;
        }

        public bool deleteJob()
        {
            return allJobs.Remove(this);
        }
    }
}
