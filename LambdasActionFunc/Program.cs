using System;

namespace LambdasActionFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            worker.WorkPerformed += (s, e) => Console.WriteLine($"Hours worked: {e.Hours}, work type: {e.WorkType}");
            
            worker.WorkCompleted += (s, e) => Console.WriteLine("Work completed");

            worker.DoWork(8, WorkType.GoToMeetings);

            Action<int, int> actionAdd = (x, y) => Console.WriteLine(x + y);

            ProcessAction(2, 3, actionAdd);

            Func<int, int, int> funcAdd = (x, y) => x + y;

            var result = ProcessFunc(2, 3, funcAdd);

            Console.WriteLine(result);
        }

        public static void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
        }

        public static int ProcessFunc(int x, int y, Func<int, int, int> func)
        {
            return func(x, y);
        }
    }
}
