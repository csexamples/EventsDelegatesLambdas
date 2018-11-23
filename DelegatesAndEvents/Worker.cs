using System;

namespace DelegatesAndEvents
{
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

    //public delegate void WorkPerformerdHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;

            //if (del != null) // listeners are attached
            //{
            //    del(this, new WorkPerformedEventArgs { Hours = hours, WorkType = workType });
            //}

            if (WorkPerformed != null)
            {
                WorkPerformed(this, new WorkPerformedEventArgs { Hours = hours, WorkType = workType });
            }
        }

        protected virtual void OnWorkCompleted()
        {
            //var del = WorkCompleted as EventHandler;

            //if (del != null) // listeners are attached
            //{
            //    del(this, EventArgs.Empty);
            //}

            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }
        }
    }
}
