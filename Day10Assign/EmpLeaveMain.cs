using System;
using DelagateAndEventsLib;
using DelegateAndEventsLib;
namespace Day10Assign
{
    internal class EmpLeaveMain
    {
        public static event getLeaves LeaveEvent;
        static void Main(string[] args)
        {
            Employee e= new Employee();
            e.Leave = 10;
            getLeaves d1 = new getLeaves(e.ApplyLeave);
            LeaveEvent += d1;
            LeaveEvent(7);
            Console.Read();
        }
    }
}
