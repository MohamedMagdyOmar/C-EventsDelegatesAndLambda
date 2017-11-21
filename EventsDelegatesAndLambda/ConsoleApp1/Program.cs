using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {

        static void Main(string[] args)
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate mulDel = (x, y) => x * y;

            ProcessData m1 = new ProcessData();
            m1.Process(2, 3, mulDel);

            // notice that here you do not need to define the above delegate
            Action<int, int> myAdditionAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMulAction = (x, y) => Console.WriteLine(x * y);

            m1.ProcessAction(2, 3, myAdditionAction);
            //workPerformedHandler del1 = new workPerformedHandler(WorkPerformed1);
            //workPerformedHandler del2 = new workPerformedHandler(WorkPerformed2);
            //workPerformedHandler del3 = new workPerformedHandler(WorkPerformed3);
            //// lets say we had a method, and we do not know what this method should do
            //// we need it to be dynamic method

            ////del1 += del2;
            ////del1 += del3;
            //del1 += del2 + del3;

            //// it will return int value of the last method only because it is the last method to be invoked
            //int finalHours = DoWork(del1);

            //Console.WriteLine(finalHours);
            ////del2(10, WorkType.PlayingFootball);
            var worker = new Worker();
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_workPerformed);
            //worker.WorkCompleted += new EventHandler(work_workCompleted);
            worker.WorkPerformed += (s,e) =>
            { Console.WriteLine("Hours worker: " + e.Hours + " " + e.WorkType); };

            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker Is Done");
            //worker.WorkCompleted -= work_workCompleted;
            worker.DoWork(8, WorkType.PlayingFootball);
            Console.ReadLine();
        }

        // this method become dynamic
        // you pass function to a function
        //public static int DoWork(workPerformedHandler del)
        //{
        //    return del(5, WorkType.Golf);
        //}

        //public static void worker_workPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours worker: " + e.Hours + " " + e.WorkType);
        //}

        //public static void work_workCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker Is Done");
        //}

        public static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 1 called " + hours.ToString());
            return hours + 1;
        }

        public static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 2 called " + hours.ToString());
            return hours + 2;
        }

        public static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 3 called " + hours.ToString());
            return hours + 3;
        }

    }

    public enum WorkType
    {
        Golf,
        Meetings,
        PlayingFootball
    }
}
