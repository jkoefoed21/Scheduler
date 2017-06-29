using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Worker
    {
        private string name { get; set; }

        private List<Job> workerSkills=new List<Job>();

        private bool[,] availability = new bool[7, 48];

        private byte desiredNumHours { get; set; }

        private byte scheduledHours { get; set; }

        public Worker(String workerName)
        {
            name = workerName;
        }

        public void addJob(String j)
        {
            if (Job.returnJob(j)!=null)
            {
                workerSkills.Add(Job.returnJob(j));
            }
        }

        public bool removeJob(String j)
        {
            if (Job.returnJob(j) != null)
            {
                return workerSkills.Remove(Job.returnJob(j));
            }
            return false;
        }

        public void setAvailability(int day, int start, int end, bool isAvailable)
        {
            if (day<0 || day>6 || start<0 || end>23.5 || end<start || 
                start*2!=Math.Ceiling((double) start*2)|| end * 2 != Math.Ceiling((double) end * 2))
            {
                throw new ArgumentException("invalid parameters in setAvailability");
            }
            else
            {
                for (int ii=start*2; ii<end*2; ii++)
                {
                    availability[day, ii] = isAvailable;
                }
            }
        }

        public bool isAvailable(int day, int hour)
        {
            return availability[day, hour * 2];
        }

    }
}
