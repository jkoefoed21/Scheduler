using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Week
    {
        private List<Worker>[,] scheduledWorkers = new List<Worker>[7, 48];
        private List<Job>[,] neededJobs = new List<Job>[7, 48];

        public Week()
        {

        }

        public void scheduleWorker(Worker w, int day, int start, int end)
        {
            for (int ii=start*2; ii<end*2; ii++)
            {
                scheduledWorkers[day, ii].Add(w);
            }
        }


        public void descheduleWorker(Worker w, int day, int start, int end)
        {
            for (int ii = start * 2; ii < end * 2; ii++)
            {
                scheduledWorkers[day, ii].Remove(w);
            }
        }
    }
}
