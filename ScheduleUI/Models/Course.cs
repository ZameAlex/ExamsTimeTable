using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleUI.Models
{
	public class Course
	{
		public int Number { get; set; }

		public List<Division> Divisions { get; set; }

		public Course()
		{
			Divisions = new List<Division>();
		}

		public override string ToString()
		{
			switch (Number)
			{
				case 1:
					return "I";
				case 2:
					return "II";
				case 3:
					return "III";
				case 4: 
					return "IV";
				case 5:
					return "V";
				case 6:
					return "VI";
				default:
					return Number.ToString();
			}
		}
	}
}
