using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// now after finishing, if we have any number of listeners, they will be notified on each iteration
// of the for loop, and notified when the work is completed
// in below demo you see how to take an event, and create some event raising method

namespace ConsoleApp1
{
    // the word "Handler" is typically used when naming the delegates
    //public delegate int workPerformedHandler(int hours, WorkType workType);
    //public delegate int workPerformedHandler(object sender, WorkPerformedEventArgs e);
    public class Worker
    {   // now we need a way to raise below 2 events, and
        // pass the data on pipeline to event listeners
        //public event workPerformedHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 0; i < hours; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);
            }
            //Raise event here for work completed
            OnWorkCompleted();
        }

        // event raising method
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                // raising an event
                //del(hours, workType);
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        // event raising method
        protected virtual void OnWorkCompleted()
        {
            // now we need to raise the events, and we have 2 techniques
            // first way
            //if(WorkCompleted != null)
            //{
            //    WorkCompleted(this, EventArgs.Empty);
            //}

            // second way
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                // this refers to this class
                del(this, EventArgs.Empty);
            }
        }
    }
}
