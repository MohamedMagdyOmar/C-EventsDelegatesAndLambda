using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // the word "Handler" is typically used when naming the delegates
        public delegate void workPerformedHandler(int hours, WorkType workType);

        static void Main(string[] args)
        {
            workPerformedHandler del1 = new workPerformedHandler(WorkPerformed1);
            workPerformedHandler del2 = new workPerformedHandler(WorkPerformed2);

            // lets say we had a method, and we do not know what this method should do
            // we need it to be dynamic method

            DoWork(del1);
            del2(10, WorkType.PlayingFootball);
            Console.ReadLine();
        }

        // this method become dynamic
        // you pass function to a function
        public static void DoWork(workPerformedHandler del)
        {
            del(5, WorkType.Golf);
        }

        public static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 1 called " + hours.ToString());
        }

        public static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 2 called " + hours.ToString());
        }

        public enum WorkType
        {
            Golf,
            Meetings,
            PlayingFootball
        }
    }
}
