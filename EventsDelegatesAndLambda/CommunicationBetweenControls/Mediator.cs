using CommunicationBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenControls
{
   public class Mediator
    {
        // singleton patter, so we share one instance ("_instance") between all modules
        private static readonly Mediator _instance = new Mediator();
        private Mediator()
        {

        }

        public static Mediator GetInstance()
        {
            return _instance;
        }
        public event EventHandler<JobChangedEventArgs> JobChanged;
        public void OnJobChanged(object sender, Job job)
        {
            var JobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            if(JobChangeDelegate != null)
            {
                JobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }
    }
}
