using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    public class MyTime
    {

		private int myMinute; // מספר שלם חיובי בין 0 ל 59 כולל
        private int myHour; //מספר שלם חיובי בין 7 ל23 כולל

		public MyTime(int myMinute, int myHour)
		{
			this.myMinute = myMinute;
			this.myHour = myHour;
		}

        public int GetMyMinute()
		{
			return myMinute;
		}
		public void SetMyMinute(int value)
		{
			myMinute = value;
		}

		public int GetMyHour()
		{
			return myHour;
		}
		public void SetMyHour(int value)
		{
			myHour = value;
		}

		public bool Before(MyTime other)
		{
			if (myHour*60 + myMinute < other.myHour*60 + other.myMinute)
			{
				return true;
			}
			return false;
		}

		public int Diff (MyTime other)
		{
			myMinute -= other.myMinute;
			return Math.Abs(myMinute);
		}


    }
}
