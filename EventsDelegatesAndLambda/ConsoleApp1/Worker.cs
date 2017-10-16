using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    // the word "Handler" is typically used when naming the delegates
    public delegate int workPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        

        public event workPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {

        }
    }
}
