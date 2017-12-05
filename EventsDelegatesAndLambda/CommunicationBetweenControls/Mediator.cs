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
        /// <summary>
        /// Mediator pattern is used to reduce communication complexity between multiple objects or classes.
        /// This pattern provides a mediator class which normally handles all the communications between different classes 
        /// and supports easy maintenance of the code by loose coupling.
        /// Mediator pattern falls under "behavioral pattern" category.
        /// </summary>

        // singleton pattern, so we share one instance ("_instance") between all modules
        private static readonly Mediator _instance = new Mediator();
        private Mediator()
        {

        }

        public static Mediator GetInstance()
        {
            return _instance;
        }

        // first component: attach event to event handler (delegate)
        public event EventHandler<JobChangedEventArgs> JobChanged;
        public void OnJobChanged(object sender, Job job)
        {
            var JobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            if(JobChangeDelegate != null)
            {
                // third component: fire event (notify subscribers)
                JobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }
    }
}
