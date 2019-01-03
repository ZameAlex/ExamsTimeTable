using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleLib.Models
{
	public class Group
	{
		public string Name { get; set; }
		public List<DateTime> Days { get; set; } = new List<DateTime>();
		public List<Lesson> Lessons { get; set; } = new List<Lesson>();
		public Division Owner { get; set; }

		public void CreateName(Division division, int count, int course)
		{
			Name = $"{division.Name}-{(DateTime.Now.Year - course) % 10}{count.ToString()}";
		}

		public override string ToString()
		{
			return this.Name;
		}

	}
}
