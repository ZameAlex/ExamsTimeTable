using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleUI.Models
{
	public class Division
	{
		public string Name { get; set; }
		public int Number { get; set; }
		public List<Group> Groups { get; set; }
		public Course Owner { get; set; }
	}
}
