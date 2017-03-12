using FluentScheduler;

namespace WebScheduler
{
    public class ScheduledTasks : Registry
    {
        public ScheduledTasks()
        {
            // Schedule an IJob to run at an interval
            Schedule<MyJob>().ToRunNow().AndEvery(2).Seconds();
        }
    }
}