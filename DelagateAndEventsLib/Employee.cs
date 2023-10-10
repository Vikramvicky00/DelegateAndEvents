using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEventsLib
{
	public delegate void getLeaves(int l);
    public class Employee
    {
		private int leaves;

		public int Leave
		{
			get { return leaves; }
			set { leaves = value; }
		}


		public void ApplyLeave(int days)
		{
			if(days<=Leave)
			{
				Leave -= days;
                Console.WriteLine(" Leave appiled Successfully. \n Remaining Leave : {0}",Leave);
			}
			else
			{
                Console.WriteLine("Unable to apply leave , Beacause Leaves remaining :{0}", Leave);
            }
		}
    }
}
