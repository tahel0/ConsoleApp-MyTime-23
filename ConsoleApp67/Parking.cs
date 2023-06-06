using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Parking
    {

		private MyTime out1;
		private MyTime in1;
		private string id;

		public Parking(MyTime Out, MyTime In, string id)
		{
			this.out1 = Out;
			this.in1 = In;
			this.id = id;
		}

		public string GetId()
		{
			return id;
		}
		public void SetId(string value)
		{
			id = value;
		}
		
		public MyTime GetIn1()
		{
			return in1;
		}
		public void SetIn1(MyTime value)
		{
			in1 = value;
		}

		public MyTime GetOut1()
		{
			return out1;
		}
		public void SetOut1(MyTime value)
		{
			out1 = value;
		}

		//שאלה ב.1
		public int total ()
		{
			return GetIn1().Diff(GetOut1());
		}

    }
}
