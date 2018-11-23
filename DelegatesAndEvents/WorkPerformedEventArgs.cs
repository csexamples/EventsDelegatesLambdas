using System;

namespace DelegatesAndEvents
{
    public class WorkPerformedEventArgs
    {
        public int Hours { get; set; }

        public WorkType WorkType { get; set; }
    }
}
