using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public interface IWorkRoutine
    {
        void getJobStartTime();
        void getBreakDuration();
        void getJobEndTime();
    }
    public class WorkRoutine : IWorkRoutine
    {
        IWorkRoutine routine;
        public WorkRoutine(IWorkRoutine _IWorkRoutine)
        {
            routine = _IWorkRoutine;
        }
        public void getBreakDuration()
        {
            routine.getBreakDuration();
        }

        public void getJobEndTime()
        {
            routine.getJobEndTime();
        }

        public void getJobStartTime()
        {
            routine.getJobStartTime();
        }
    }

    public class Labor : IWorkRoutine
    {
        public void getBreakDuration()
        {
            Console.WriteLine("30 min.");
        }

        public void getJobEndTime()
        {
            Console.WriteLine("7:00 pm");
        }

        public void getJobStartTime()
        {
            Console.WriteLine("8:00 am");
        }
    }
    public class ShopKeeper : IWorkRoutine
    {
        public void getBreakDuration()
        {
            Console.WriteLine("0 min.");
        }

        public void getJobEndTime()
        {
            Console.WriteLine("9:00 pm");
        }

        public void getJobStartTime()
        {
            Console.WriteLine("6:30 am");
        }
    }
    public class SoftwareEngineer : IWorkRoutine
    {
        public void getBreakDuration()
        {
            Console.WriteLine("1 hour");
        }

        public void getJobEndTime()
        {
            Console.WriteLine("5:30 pm");
        }

        public void getJobStartTime()
        {
            Console.WriteLine("8:30 am");
        }
    }
}
