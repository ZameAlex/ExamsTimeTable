using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleUI.Models
{
	public class Group
	{
		public string Name { get; set; }
		public List<DateTime> Days { get; set; }
		public List<Lesson> Lessons { get; set; }
		public Division Owner { get; set; }

	}
}
