using System;

namespace CustomDelegates
{
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

    public delegate void WorkPerformerdHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformerdHandler del1 = new WorkPerformerdHandler(WorkPerformed1);
            WorkPerformerdHandler del2 = new WorkPerformerdHandler(WorkPerformed2);
            WorkPerformerdHandler del3 = new WorkPerformerdHandler(WorkPerformed3);

            del1 += del2 + del3;

            DoWork(del1);
        }

        static void DoWork(WorkPerformerdHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 called {hours} {workType}");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called {hours} {workType}");
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called {hours} {workType}");
        }
    }
}
